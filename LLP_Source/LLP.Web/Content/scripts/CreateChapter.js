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

            $('#btnSaveChapter').click(function () {
                if (CommonUiValidation()) {
                    alert("sdf");
                    var chapter = {};
                    chapter.Id = $("#Id").val();
                    chapter.ChapterNo = $("#txtChapterNo").val();
                    chapter.Name = $("#txtName").val();
                    chapter.Type = $("#txtType").val();

                    var content = tinymce.get("txtDescription").getContent();



                    chapter.Description = content;


                    $.ajax({

                        type: "POST",
                        url: "/Admin/SaveChapter",
                        data: '{chapter: ' + JSON.stringify(chapter) + '}',
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (response) {
                            if (response == true) {
                                $("#txtChapterNo").val('');
                                $("#txtName").val('');
                                $("#txtType").val('');
                                $("#txtDescription").val('');
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