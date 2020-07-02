$(function () {
    var indexCate = -1;
    var indexWire = -1;
    var pageItems = 7;
    /*======== Request ========*/
    function getData(cate, wire) {
        $.ajax({
            method: 'GET', url: '/Admin/Product/Products',
            data: { indexCate: cate, indexWire: wire, pageItems: pageItems },
            dateType: 'JSON'
        }).done(data => displayData(data));
    }

    function getDataByPage(number) {
        $.ajax({
            method: 'GET', url: '/Admin/Product/Page',
            data: { number: number - 1, pageItems: pageItems },
            dateType: 'JSON'
        }).done(data => showProduct(data));
    }

    function getDataOrderby(status, sale) {
        $.ajax({
            method: 'GET', url: '/Admin/Product/OrderBy',
            data: { indexStatus: status, indexSale: sale, pageItems: pageItems },
            dateType: 'JSON'
        }).done(data => displayData(data));
    }

    function findWithKey(key) {
        $.ajax({
            method: 'GET',
            url: '/Admin/Product/Find',
            data: { key: key, pageItems: pageItems },
            dateType: 'JSON'
        }).done(data => displayData(data));
    }

    function updateStatus(id, indexStatus) {
        $.ajax({
            method: 'GET',
            url: '/Admin/Product/UpdateStatus',
            data: { id: id, indexStatus: indexStatus }
        });
    }

    /*======== DEFINE EVENT ON VIEW ========*/
    var onChangeSwitch = function (handler) {
        $('.switch').on('change', function () {
            let el = $(this);
            let indexStatus = el.children('.switch-input').prop('checked');
            let id = el.parent().prev().children(':first-child').children(':first-child').children(':first-child').text();
            handler(id, indexStatus ? 1 : 0);
        });
    }
    /*======== ATTACH EVENT ========*/

    $('#vt-filter-cate .dropdown-item').on('click', function () {
        indexCate = $(this).data('index');
        getData(indexCate, indexWire)
    });

    $('#vt-filter-wire .dropdown-item').on('click', function () {
        indexWire = $(this).data('index');
        getData(indexCate, indexWire)
    });

    $('#vt-orderby-sale .dropdown-item').on('click', function () {
        getDataOrderby(-1, $(this).data('index'))
    });

    $('#vt-orderby-status .dropdown-item').on('click', function () {
        getDataOrderby($(this).data('index'), -1);
    });

    $('#search-input').on('keydown', function (e) {
        if (e.keyCode == 13) findWithKey($(this).val());
    })

    /*======== UPDATE VIEW ========*/
    function displayData(data) {
        $('#vt-total').text(data[1]);
        showPages(data[1], pageItems, number => getDataByPage(number));
        showProduct(data[0]);
    }

    function showProduct(products) {
        console.log(Array.isArray(products));
        let container = $('#vt-container-data');
        container.empty();
        products.forEach(p => container.append(ctrHTMLElement(p)));
        //Attch event
        onChangeSwitch(updateStatus);
    }

    function ctrHTMLElement(product) {
        return ` <div class="row mb-5 align-items-center ">
                    <div class="col-10">
                        <a href="/Admin/Product/Detail?id=${product.id}">
                            <div class="row vt-item align-items-center text-dark">
                                <div class="col-md-1 col-4">${product.id}</div>
                                <div class="col-md-2 vt-d-none">
                                    <div class="vt-img" style="width:100px">
                                        <img src="/product/${product.imageDefault}">
                                    </div>
                                </div>
                                <div class="col-md-2 col-4">${product.name}</div>
                                <div class="col-md-2 col-4">${product.price}</div>
                                <div class="col-md-2 vt-d-none" >${product.categoryID}</div>
                                <div class="col-md-2 vt-d-none" >${product.typeWireID}</div>
                                <div class="col-md-1 vt-d-none" >${product.saleCount}</div>
                            </div>
                        </a>
                    </div>   
                    <div class="col-2 text-center vt-custom">
                        <label class="switch switch-icon switch-primary switch-pill vt-switch-sm form-control-label">
                            <input type="checkbox" class="switch-input form-check-input" value="on" >
                            <span class="switch-label"></span>
                            <span class="switch-handle"></span>
                        </label>
                    </div>
                </div>`
    }

    getData(indexCate, indexWire);
    /*======== END========*/
    $('#loading').fadeOut(500);
})
