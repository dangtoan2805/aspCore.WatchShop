$(function () {
    var pageItems = 10;
    var datas = [];
    var temp;
    var count = 0;
    /*======== Request ========*/
    function getData() {
        preHandler();
        $.ajax({
            method: 'GET', url: '/Admin/Customer/Customers',
            dateType: 'JSON'
        }).done(data => requestSuccess(data));
    }

    /*======== ATTACH EVENT ========*/
    $('#search-input').on('keydown', function (e) {
        if (e.keyCode == 13) findCustomter($(this).val());
        if (e.keyCode == 46 && $(this).val() == '') {
            displayData(datas);
        }
    })

    /*======== UPDATE VIEW ========*/
    function startLoader() {
        let el = $('#vt-loader');
        el.show();
        el.parent().addClass('vt-event-none');
    }

    function stopLoader() {
        let el = $('#vt-loader');
        el.hide();
        el.parent().removeClass('vt-event-none');
    }

    function preHandler() {
        startLoader();
    }

    function requestSuccess(data) {
        stopLoader();
        $('#search-input').val('');
        if (data != null && data.length > 0) {
            for (let index = 0; index < data.length; index++) {
                let obj = data[index];
                datas.push(Object.assign({ number: index }, obj));
            }
            displayData(datas);
        }
        else
            showNotFound();
    }

    function displayData(data) {
        let len = data.length
        $('#vt-total').text(len);
        $('#vt-pagination').show();
        showPages(len, pageItems, number => getPage(number));
        fisrtPage();
    }

    function getPage(page) {
        let obj = datas;
        let start = (page - 1) * pageItems;
        let end = start + (pageItems - 1);
        showData(obj.slice(start, end));
    }

    function fisrtPage() {
        firstPageOnlyView();
        getPage(1);
    }

    function findCustomter(key) {
        temp = datas.filter(item => item.phone.includes(key) || item.name.includes(key));
        if (temp == null) showNotFound();
        displayData(temp);
    }

    function showNotFound() {
        $('#vt-pagination').hide();
        $('#vt-total').text(0);
        let container = $('#vt-container-data');
        container.empty();
        container.fadeIn(150).append(crtHTMLNotFound());
        $('#vt-data .dropdown').addClass('vt-event-none');
    }

    function showData(data) {
        let container = $('#vt-container-data');
        container.empty();
        data.forEach(item => container.fadeIn(300).append(crtHTMLElement(item)));
    }

    function crtHTMLElement(customer) {
        return ` <div class="row mb-4 align-items-center ">
                    <div class="col-md-1 col-2">${customer.number}</div>
                    <div class="col-md-3 col-6">${customer.name}</div>
                    <div class="col-md-2 col-4">${customer.phone}</div>
                    <div class="col-md-6 vt-d-none">${customer.address}</div>
                </div>`
    }

    getData();
    // Show page and attach Event on View
    $('#loading').fadeOut(500);
});