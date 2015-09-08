$(function () {
 
    //$(".leftmenu").find("a").click(function () {

    //    var data = {
    //        pCategoryName: $(this).attr('categoryName'),
    //        pID: 0
    //    };
      
    //    if (!data.pCategoryName) {
    //        return;
    //    }
    //    $.ajax({
    //        type: 'POST',
    //        url: '/Gallery/GetImagesByCategory',
    //        data: data,
    //        dataType: 'json',
    //        success: function (result) {
    //            debugger;
    //            if (result.filenames.length > 0) {
    //                $('.templatebelow').empty();
    //                var stringHtml='';
    //                $.each(result.filenames, function (key,value) {
    //                    stringHtml += '<li>' +
    //                               '<div class="contain_template">' +
    //                               '<a href="#"><img src="../img/Category/' + data.pCategoryName + '/' + value + '"></a>' +
    //                               '</div></li>';
    //                });
    //                $('.templatebelow').append(stringHtml);
    //            }
                

    //        },
    //        failure: function (result) {
    //            WaitOverlay.hide();
    //        }
    //    });
    //});

})