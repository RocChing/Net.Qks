(function () {
    $.serializeJSON.splitInputNameIntoKeysArray = function (nameWithNoType) {
        var keys, f;
        f = $.serializeJSON;
        keys = nameWithNoType.split('['); // split string into array

        var rs = [];
        $.map(keys, function (key) {
            var item = key.replace(/\]/g, '');
            rs.push(...item.split('.'));// 处理 foo[0].Name 这样的情况
        }); // remove closing brackets
        if (rs[0] === '') { rs.shift(); } // ensure no opening bracket ("[foo][inn]" should be same as "foo[inn]")
        return rs;
    }
})();

(function () {
    $(function () {
        abp.event.on('app.opendModal', function () {
            $("input,select,textarea", ".list-group .template").each(function () {
                if (!$(this).prop("disabled")) {
                    $(this).prop("disabled", true);
                    $(this).attr("editable", true);
                }
            });
        });

        $(document).on("click", ".list-group .add", function () {
            //var index = $(this).parent('li').siblings(".template").children(".item").size();
            var index = $('ul.content').children('li').length - 1;
            var template = $('ul.content').children('.template').clone(); //$($(this).siblings(".template").html());
            $("input,select,textarea", template).attr("data-val", true).each(function () {
                if ($(this).attr("editable")) {
                    $(this).prop("disabled", false);
                    $(this).removeAttr("editable");
                }
                var name = $(this).attr("name");
                if (name) {
                    $(this).attr("name", name.replace(/\[(\d+)\]/, "[" + index + "]"));
                }
                var id = $(this).attr("id");
                if (id) {
                    $(this).attr("id", id.replace(/\_(\d+)\_/, "_" + index + "_"));
                }

                if ($(this).hasClass("Date") && !$(this).prop("readonly") && !$(this).prop("disabled")) {
                    $(this).datepicker({ language: "zh-CN", format: $(this).attr("JsDateFormat") });
                }
            });

            $(".field-validation-error,.field-validation-valid", template).each(function () {
                var msgFor = $(this).attr("data-valmsg-for");
                $(this).attr("data-valmsg-for", msgFor.replace(/\[(\d+)\]/, "[" + index + "]"))
            });
            template.removeClass('hidden template');
            $('ul.content').append(template);

            var form = $(this).closest("form");
            form.removeData("validator").removeData("unobtrusiveValidation");//unobtrusiveValidation
            $.validator.unobtrusive.parse(form);
        }).on("click", "ul.content .delete", function () {
            var li = $(this).parent();
            $('input[type="hidden"]', li).each(function () {
                var input = $(this);
                var name = input.attr('name');
                if (name.indexOf('ActionType') > -1) {
                    input.val('Delete');
                   // return false;
                }
                if (name.indexOf('IsDeleted') > -1) {
                    input.val('true');
                }
            });
            li.addClass('hidden');
        }).on("change", ".input-group-collection .form-control", function () {
            var actionType = $(".ActionType", $(this).closest(".item"));
            if (actionType.val() !== "Create") {
                actionType.val("Update");
            }
        });
    });
})();