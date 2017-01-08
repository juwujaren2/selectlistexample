$(document).ready(function() {
    $(".selectpicker").on("changed.bs.select",
        function () {
            var show = $(this).data("toggle");
            if ($(this).is("select")) {
                var val = $(this).val();
                var $module = $(this).closest("[data-module]");
                var $reasonShow = $module.find("[data-show^=" + show + "]");
                $reasonShow.each(function() {
                    var visible = $(this).data("show") === show + "-" + val;
                    $(this).toggle(visible);
                });
            } else {
                $(show).toggle();
            }
        });
});