$(function () {
    var arImages = [];
    /*======== REQUEST ========*/
    function getImages() {
        let id = $("input[name='ID']").val();
        $.ajax({
            method: 'GET', url: '/Admin/Product/GetImages', data: { id: id },
            dataType: 'JSON'
        }).done(data => showImages(data));
    }

    function uploadImage(img) {
        let formData = new FormData();
        let imgName = img.name.split('.');
        formData.append('img', img, `product_${Date.now()}.${imgName[1]}`);
        $.ajax({
            method: 'POST',
            url: '/Admin/Product/UploadImage',
            data: formData,
            dataType: 'text',
            contentType: false,
            processData: false
        }).done(data => showImages(data));
    };

    /*======== DEFINE EVENT ON VIEW ========*/

    function onImgDefaulClick() {
        $('.vt-set-default').on('click', function () {
            let src = $(this).parent().prev().children('img').prop('src').split('/');
            $('#vt-default-img').prop('src', `/product/${src[src.length - 1]}`);
        });
    }

    function onImgDelClick() {
        $('.vt-delete-img').on('click', function () {
            let src = $(this).parent().prev().children('img').prop('src').split('/');
            let imgDefault = $('#vt-default-img');
            if (imgDefault.prop('src') === src) {
                imgDefault.prop('src', `/product/img_null.jpg`)
            }
            let parent = $(this).parents()[1];
            $(parent).fadeOut(300)
        });
    }

    /*======== ATTACH EVENT ========*/
    $(document).ready(() => getImages());

    $('#vt-image-input').on('change', function () {
        uploadImage($(this).prop('files')[0]);
    });

    $('#vt-upload').on('click', () => $('#vt-image-input').click());

    $('#vt-form').on('submit', function (e) {
        $(`<input type='hidden' name='Files' value=${arImages.toString()} multiple />`).appendTo($(this));
        return true;
    });
    /*======== UPDATE VIEW ========*/
    function showImages(images) {
        let containter = $('#vt-containter-img');
        if (typeof (images) !== 'string') {
            arImages = [...images];
            images.forEach(img => containter.append(crtImageElement(img)).fadeIn(300));
        }
        else {
            arImages.push(images);
            containter.append(crtImageElement(images)).fadeIn(300);
        }
        onImgDefaulClick();
        onImgDelClick();
    }

    function crtImageElement(imgName) {
        return `<div class="col-3 p-1 pb-3">
                    <div class="vt-img mx-auto">
                        <img src="/product/${imgName}">
                    </div>
                    <div class="mx-auto d-flex justify-content-center">
                        <button class="vt-set-default btn btn-primary mdi mdi-tshirt-crew w-50 m-2"></button>
                        <button class="vt-delete-img btn btn-danger mdi mdi-delete w-50 m-2"></button>
                    </div>
                </div> `
    }

    /*======== END ========*/
    $('#loading').fadeOut(500);
})