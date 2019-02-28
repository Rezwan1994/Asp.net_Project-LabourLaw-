  var myFunction = function(){


        var input, filter, table, tr, td, i;
        input = document.getElementById("search");
        filter = input.value.toUpperCase();
        table = document.getElementById("myTable");


        tr = table.getElementsByClassName("ChapterName");

        for (i = 0; i < tr.length; i++) {
            tdlength = $('.' + tr[0].className).children().length
            for (j = 0; j < tdlength; j++)
            {
                td = $('.' + tr[i].className).children().children().children()[j].innerHTML;

                if (td) {
                    if (td.toUpperCase().indexOf(filter) > -1) {
                        $('.' + tr[i].className).children().children().children()[j].style.visibility = "visible";
                       // $('.' + tr[i].className).children().children().children()[j].style.display = "block";
                       // table.style.display = "block";
                        tr[i].style.display = "";
                        console.log(td);
                    } else {
                        $('.' + tr[i].className).children().children().children()[j].style.visibility = "hidden";

                    }
                    //if (filter.length == 0) {
                    //    table.style.display = "none";
                    //    tab.style.display = "none";
                    //}
                }
            }

        }
    }


        $(".ContentTitle").click(function (item) {
            var clickitem1 = $(item.target).attr('data-location');

            $(".Chapter_Content").load(clickitem1);
        })












        var s = $("#sticker");
        var h = $("headersticker");
        var pos = s.position();
        $(window).scroll(function () {
            var windowpos = $(window).scrollTop();
            console.log(windowpos + " " + pos);
            if (windowpos > pos.top) {
                s.addClass("stick");
                h.addClass("headerstick");
            } else if (windowpos == 0) {
                console.log("dfgdfg");
                s.removeClass("stick");
            }
        });



        //var myFunction = function (item) {
        //    //var clickitem1 = $(item.target).attr('data-location');data-location='+gurl+'
        //    //  encodeURIComponent(_href))
        //    var value = $(item).attr("item");
        //    var clickitem = $(item).attr('data-location');
        //    // alert(clickitem);
        //    $('#searchSuggestion').html("");
        //    $(".Chapter_Content").load(clickitem);
        //    // alert(value);
        //    //$(".Chapter_Content").load(clickitem1);
        //    // data - location="/Home/ShowContentbyTitle?Title=value";

        //}
        var NavigatePageListing = function () {
            var searchText = $("#search").val();
            $("#partial_View").load("/Home/TreePartialView", { SearchText: searchText});
        }
            //alert(pageNumber);
            //if (typeof (pageNumber) == "undefined") {
            //    return;
            //}

            //var FilterKey = $("#PropertyListingCategory").val();


            //$("#partialViewLoadListing").load("/JobsCategory/JobList", { FilterKey: FilterKey, CompanyId: AgencyId, SearchText: searchText, PageNumber: pageNumber, UnitPerPage: unitperpage });
        var delay = (function () {
            var timer = 0;
            return function (callback, ms) {
                clearTimeout(timer);
                timer = setTimeout(callback, ms);
            };
        })();

        $(document).ready(function(){
            $('#search').keyup(function () {
                delay(function () {
                    NavigatePageListing();
                }, 100);



            })

            $("#partial_View").load("/Home/TreePartialView2")



        });
        var ps = new PerfectScrollbar('#partial_View');

        $(document).ready(function () {
            ps.update();
        })
  