    $(document).ready(function () {
        $(".cplist").click(function (item) {
            var clickitem = $(item.target).attr('data-location');
            $(".Content").load(clickitem);
        }) // Hide all 2-level ul

    });