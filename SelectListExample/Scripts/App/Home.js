var options = {
    ajax: {
        url: "/Home/GetUnitDataJson",
        type: "POST",
        dataType: "json",
        data: {
            q: "{{{q}}}"
        }
    },
    //locale: {
    //    emptyTitle: "Select and Begin Typing"
    //},
    log: 3,
    preprocessData: function (data) {
        var i, l = data.length, array = [];
        if (l) {
            for (i = 0; i < l; i++) {
                array.push($.extend(true, data[i], {
                    text: data[i].UserLocation + " (" + data[i].LongName + ")",
                    value: data[i].Id,
                    data: {
                        subtext: data[i].ManagerFirstName + " " + data[i].ManagerLastName,
                        token: data[i].ShortName
                    }
                }));
            }
        }
        return array;
    }
};

$(document).ready(function () {
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
    $(".selectpicker").selectpicker().filter(".with-ajax").ajaxSelectPicker(options);
    $("select").trigger("change");
});