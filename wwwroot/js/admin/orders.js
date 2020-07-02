$(function () {
    var pageItems = 9;
    /*======== VARIABLE ========*/
    // Color for dropdown
    var dropDownColor = ['btn-danger', 'btn-success', 'btn-info', 'btn-primary', 'btn-secondary'];
    var statusOrder = ['Chưa xác nhận', 'Đã xác nhận', 'Đang giao', 'Hoàn thành', 'Huỷ'];
    // Date defautl
    var start = moment().subtract(6, 'days');
    var end = moment();

    /*======== GET DATA ========*/
    function findWithKey(key) {
        $.ajax({
            method: "GET", url: '/Admin/Order/Find',
            data: { key: key, pageItems: pageItems },
            dataType: "JSON"
        }).done(data => displayData(data));
    }

    function getData(fromDate, toDate) {
        $.ajax({
            method: "GET", url: '/Admin/Order/Orders',
            data: { start: fromDate.format(dateFormter), end: toDate.format(dateFormter), pageItems: pageItems },
            dataType: "JSON"
        }).done(data => {
            displayData(data)
        });
    }

    function getDataByPage(number) {
        $.ajax({
            method: "GET", url: '/Admin/Order/Page',
            data: { number: number, pageItems: pageItems },
            dataType: "JSON"
        }).done(data => showData(data));
    }

    function getDataOrderBy(indxStatus, indXCost) {
        let uri;
        let indx;
        if (indxStatus === -1) {
            uri = 'OrderByCost';
            indx = indxStatus;
        }
        else {
            uri = 'OrderByStatus'
            indx = indXCost;
        }
        $.ajax({
            method: "GET", url: `/Admin/Order/${uri}`,
            data: { index: indx, pageItems: pageItems },
            dataType: "JSON"
        }).done(data => {
            firstPageOnlyView();
            showData(data);
        });
    }

    function getDetail(id) {
        $.ajax({
            method: 'GET', url: "/Admin/Order/Detail",
            data: { id: id },
            dataType: 'JSON',
        }).done(data => showModelData(data))
    }

    function updateStatus(orderID, index) {
        $.ajax({
            method: "POST",
            url: '/Admin/Order/UpdateStatus',
            data: { orderID: orderID, index: index },
            dataType: "JSON"
        });
    }

    /*======== DEFINE EVENT ON VIEW ========*/
    var onChangeDate = function (start, end) {
        $('#reportrange span').html(start.format(dateFormter) + ' - ' + end.format(dateFormter));
        getData(start, end);
    }

    var onDropDownChange = function (idDropDown, handler) {
        $(`div[aria-labelledby="${idDropDown}"] > .dropdown-item`).on('click', function () {
            let el = $(this);
            let index = el.data('index');
            let parents = el.parents();
            let elPrev = $(parents[0]).prev();
            let delClass = elPrev.get(0).classList[4];
            elPrev.removeClass(delClass).addClass(`${dropDownColor[index]}`).text(el.text());
            handler($(parents[2]).prev().children().children(':first-child').text(), index);
        });
    }

    var onShowModal = function (handler) {
        $('.vt-modal-open').on('click', function (e) {
            handler($(this).children(':first-child').text());
        });
    }

    /*======== ATTACH EVENT ========*/
    // Attach event on change select date
    $('#reportrange').daterangepicker({
        startDate: start,
        endDate: end,
        ranges: {
            'Last 7 Days': [moment().subtract(6, 'days'), moment()],
            'Last 30 Days': [moment().subtract(29, 'days'), moment()],
            'This Month': [moment().startOf('month'), moment().endOf('month')],
            'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
        }
    }, onChangeDate);

    // Attach event search
    $('#search-input').on('keydown', function (e) {
        if (e.keyCode === 13) findWithKey($(this).val());
    });

    // Attach event for Order with cost
    $('#vt-orderby-cost .dropdown-item').on('click', function () {
        getDataOrderBy($(this).data('index'), -1)
    });

    // Attach event for Order with status
    $('#vt-orderby-status .dropdown-item').on('click', function () {
        getDataOrderBy(-1, $(this).data('index'))
    });

    // Attach event for Export func
    $('#vt-export').on('click', function (e) {
        console.log("Exporting...");
    });

    /*======== UPDATE VIEW ========*/
    // Display data on get new data.
    function displayData(data) {
        showPages(data[1], pageItems, number => getDataByPage(number));
        showData(data[0]);
    }

    // Show list Order and attach Event on View
    function showData(list) {
        let container = $('#vt-container-data');
        container.fadeOut(50).empty();
        list.forEach(item => container.fadeIn(300).append(crtHTMLElement(item)));
        // Attach event change status
        onDropDownChange('dropdownChangeStatus', updateStatus)
        // Attach event show order detail
        onShowModal(getDetail);
    }

    // Create HTML Elemetn for each Orders
    function crtHTMLElement(order) {
        return `<div class="row mb-2">
                    <div class="col-md-10 col-8">
                        <div class="row vt-modal-open" data-toggle="modal" data-target="#orderModal">
                            <div class="col-md-2 col-4">${order.id}</div>
                            <div class="col-md-2 vt-d-none">${order.dateCreated}</div>
                            <div class="col-md-4 col-8">${order.customer}</div>
                            <div class="col-md-2 vt-d-none">${order.phone}</div>
                            <div class="col-md-2 vt-d-none" >${order.total}</div>
                        </div>
                    </div>   
                    <div class="col-md-2 col-4">
                        <div class="dropdown d-inline-block mb-1">
                            <button class="btn dropdown-toggle btn-sm vt-dropdown-w btn-danger "
                            type="button" id="dropdownChangeStatus" 
                            data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" data-display="static">
                                ${statusOrder[order.status]}
                            </button>
                            <div class="dropdown-menu" aria-labelledby="dropdownChangeStatus">
                                <a class="dropdown-item" data-index="0">Chưa xác nhận</a>
                                <a class="dropdown-item" data-index="1">Đã xác nhận</a>
                                <a class="dropdown-item" data-index="2">Đang giao</a>
                                <a class="dropdown-item" data-index="3">Hoàn thành</a>
                                <a class="dropdown-item" data-index="4">Huỷ</a>
                            </div>
                        </div> 
                    </div>
                </div>`
    }

    // Show Order Detail 
    function showModelData(order) {
        $('#vt-order-id').text("123")
        $('#vt-order-name').text("Dnag Viet Toan")
        $('#vt-order-phone').text('0656312154')
        $('#vt-order-address').text('329/9/13 Nguyen Tieu La, P8, Quan 10, TP.HCM')
        $('#vt-order-note').text()
        $('#vt-order-total').text('54.545')
        $('#vt-order-discountBill').text('0')
        $('#vt-order-ship').text('30.000')
        $('#vt-order-pay').text('14.545')
        $('#vt-order-products').empty();
        for (let index = 0; index < 3; index++) {
            let str =
                `<tr>
                <td scope="row">${index}</td>
                <td class="text-center">
                    <div class="vt-img mx-auto" style="width:50px">
                        <img src="/product/img_watch_1.jpg" alt="">
                    </div>
                    <p class="pt-1">Lucia Lucia Lucia</p>
                </td>
                <td>1</td>
                <td>1.23213123.</td>
            </tr>`;
            $('#vt-order-products').fadeIn(300).append(str);
        }
    }

    /*======== Execute========*/
    onChangeDate(start, end);
    /*======== END ========*/
    $("#loading").fadeOut(500);
});

