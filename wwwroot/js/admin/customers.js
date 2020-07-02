$(function () {
    var pageItems = 7;
    /*======== Request ========*/
    function getData() {
        $.ajax({
            method: 'GET',
            url: '/Admin/Customer/Customers',
            data: { pageItems: pageItems },
            dateType: 'JSON'
        }).done(data => displayData(data));
    }

    function findWithKey(key) {
        $.ajax({
            method: 'GET',
            url: '/Admin/Customer/Find',
            data: { key: key, pageItems: pageItems },
            dateType: 'JSON'
        }).done(data => displayData(data));
    }

    function getDataByPage(number) {
        $.ajax({
            method: 'GET',
            url: '/Admin/Customer/Page',
            data: { number: number - 1, pageItems: pageItems },
            dateType: 'JSON'
        }).done(data => showData(data));
    }

    /*======== ATTACH EVENT ========*/
    $('#search-input').on('keydown', function (e) {
        if (e.keyCode == 13) findWithKey($(this).val());
    })

    /*======== UPDATE VIEW ========*/
    function displayData(data) {
        $('#vt-total').text(data[1]);
        showPages(data[1], pageItems, number => getDataByPage(number));
        showData(data[0]);
    }

    function showData(data) {
        let container = $('#vt-container-data');
        container.empty();
        for (let index = 0; index < data.length; index++) {
            container.append(ctrHTMLItem(index, data[index]));
        }
    }

    function ctrHTMLItem(index, customer) {
        return ` <div class="row mb-4 align-items-center ">
                    <div class="col-md-1 col-2">${index}</div>
                    <div class="col-md-3 col-6">${customer.name}</div>
                    <div class="col-md-2 col-4">${customer.phone}</div>
                    <div class="col-md-6 vt-d-none">${customer.address}</div>
                </div>`
    }
    getData();
    // Show page and attach Event on View
    $('#loading').fadeOut(500);
});