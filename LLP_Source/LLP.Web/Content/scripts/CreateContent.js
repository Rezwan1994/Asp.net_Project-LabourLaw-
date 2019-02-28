var scrollToErrorMessagePublic = function () {
            if ($($(".required").get(0)).offset() != undefined) {
                var topcal = $($(".required").get(0)).offset().top;
                if (topcal == 0) {
                    topcal = $($(".required").get(0)).position().top;
                    topcal -= 40;
                } else {
                    topcal -= 180;
                }
                jQuery('html, body').animate({
                    scrollTop: topcal
                }, 1000);
            }
        }
        $(document).ready(function () {

            $('#btnSaveContent').click(function () {
                if (CommonUiValidation()) {
                    var content = {};
                    var resourceTitle = {};
                    var resourceContent = {};


                    content.Id = $("#Id").val();
                    content.TitleNo = $("#txtTitleNo").val();
                    content.Title = $("#txtTitle").val();

                    content.ChapterId = $("#txtChapter").val();
                    content.ParentId = parseInt($("#txtParent").val());
                    var cpn = tinymce.get("txtContent").getContent();
                    content.CpContent = cpn;
                    var cpnbangla = tinymce.get("txtContentbangla").getContent();


                    resourceTitle.ResourceName = $("#txtTitle").val();
                    resourceTitle.ResourceValue = $("#txtTitlebangla").val();
                    resourceContent.ResourceName = cpn;
                    resourceContent.ResourceValue = cpnbangla;
                    var param = JSON.stringify({
                        resourceTitle: resourceTitle,
                        resourceContent: resourceContent,
                        content: content,


                    });


                    $.ajax({
                        type: "POST",
                        url: "/Admin/SaveContent",
                        data: param,
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        cache: false,
                        success: function (response) {
                            $("#txtTitleNo").val('');
                            $("#txtTitle").val('');
                            $("#txtChapter").val('');
                            $("#txtParent").val('');
                            $("#txtContent").val('');
                            if (response == true) {
                                new PNotify({
                                    title: 'Saved Successfully',
                                    text: 'The Content is saved...',
                                    type: 'success',
                                    styling: 'bootstrap3'
                                });
                            }
                            else {
                                new PNotify({
                                    title: 'Saved Successfully',
                                    text: 'The Content is saved...',
                                    type: 'error',
                                    styling: 'bootstrap3'
                                });
                            }


                            //window.location.reload();
                        }
                    });




                }
                else {
                    scrollToErrorMessagePublic();
                }

        });

        });

    $(function () {
        $(".pre_load").fadeOut(2000, function () {
            $(".content").fadeIn(1000)
        });
    });