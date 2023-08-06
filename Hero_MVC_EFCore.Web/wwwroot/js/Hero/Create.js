//Adição dos poderes/armas no heróis
$(document).ready(function () {
    $("#btnAddPower").click(function () {
        var chkRptAviamento = false;
        var currentValue = $("#PowerId option:selected").text().trim();

        if (currentValue == "Selecione... ") {
            return false;
        }

        $('#listPowers li').each(function () {
            var current = $(this).text().trim();

            if (current == $("#PowerId option:selected").text().trim()) {
                chkRptAviamento = true;
            }
        });

        if (!chkRptAviamento) {
            $("#listPowers").append("<li>" +
                $("#PowerId option:selected").text() +
                " <input type='hidden' name='chkPower' id='chkPower' class='chkPower' value='" +
                $("#PowerId option:selected").val() +
                "'></li>");
        } else {
            alert("Poder já adicionado!");
        }
    });

    $('#listPowers').on('click', "li", function () {
        $(this).remove();
        return false;
    });
});