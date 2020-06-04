var pageShowing;
let quantity = 0;

$(document).ready(() => {
  let main = $("#vt-main");
  if (main.length == 1) main.ready(() => $("#loading").fadeOut(500));
});

$("#products").ready(() => {
  //*******Add Event Filter*******/
  $("#select-wire").on("click", ".dropdown-item", function () {
    //Get ID or Wire need Show
    let wireID = $(this).data("wire");
    //Update Text Select Lable
    $("#vt-selectFilter").text($(this).text());
    console.log(wireID);
  });
  //*******Add Event Filter Order*******/
  $("#select-order").on("click", ".dropdown-item", function () {
    //Get ID or Order need Show
    let orderID = $(this).data("order");
    //Update Text Select Lable
    $("#vt-orderFilter").text($(this).text());
    console.log(orderID);
  });
  // Load List Product Default
  loadProducts();
});

function loadProducts() {
  $.ajax({
    url: `/Product/GetProducts`,
    type: "GET",
    contentType: "application/json;charset=utf-8",
    dataType: "json",
    success: function (re) {
      displayPages(re[0]);
      displayCountItem(re[1]);
      updateUIPage($("#vt-displayPages li:first-child a"));
      displayProducts(re[2]);
      $("#loading").fadeOut(500);
    },
    error: function (er) {
      console.log(er.responseText);
    },
  });
}

function displayCountItem(quan) {
  this.quantity = quan; //Show totle Item matching
  $("#countItem").text(quantity);
  quan > 0 ? $("#vt-empty").hide() : $("#vt-empty").show();
}

function displayPages(pageNumber) {
  //Show paging
  let container = $("#vt-displayPages");
  container.empty();
  for (let i = 1; i <= pageNumber + 1; i++) {
    let str = `<li class="page-item">
                <a class="page-link py-2 px-3" >${i}</a>
            </li>`;
    let el = $(str).on("click", ".page-link", changePage);
    container.append(el);
  }
}

function changePage() {
  updateUIPage($(this));
  // $.ajax({
  //     url: `/Product/Page?page=${page}`,
  //     type: "GET",
  //     contentType: "application/json;charset=utf-8",
  //     dataType: "json",
  //     success: function (re) {
  //         displayProducts(re);
  //     },
  //     error: function (er) {
  //         console.log(er.responseText);
  //     }
  // });
  //Animation All OnLoaded
  $("html,body").animate({ scrollTop: "0" }, 500);
}

function updateUIPage(el) {
  if (this.perElement != undefined) this.perElement.removeClass("vt-disabled");
  this.perElement = el.parent().addClass("vt-disabled");
}

function displayProducts(products) {
  let container = $("#vt-displayProducts");
  container.empty();
  products.forEach((e) => {
    let str = `<div class="col-lg-3 col-6">
                    <div class="vt-product">
                    <a href="/Product/ProductDetail?id=${e.id}">
                        <div class="vt-product-img">
                            <img src="/product/img_watch_2.jpg" alt="Image product">
                                <img class="" src="/images/sale.png" />
                            </div>
                            <div class="vt-product-content">
                                <h5 class="vt-product-name">${e.name}</h5>
                                <div class="vt-price">
                                    <p>${e.price}</p>
                                    <del class="${e.showSale}">${e.pricePromotion}</del>
                                </div>
                            </div>
                        </a>
                    </div>
                  </div >`;
    container.append(str);
  });
}
