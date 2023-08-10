//Edição dos poderes/armas no heróis
$(document).ready(function () {
    $("#btnAddPower").click(function () {
        var chkRptPower = false;
        var currentValue = $("#PowerId option:selected").text().trim();

        if (currentValue == "Selecione...") {
            return false;
        }

        $('#listPowers li').each(function () {
            var current = $(this).text().trim();

            if (current == $("#PowerId option:selected").text().trim()) {
                chkRptPower = true;
            }
        });

        if (!chkRptPower) {
            $("#listPowers").append(
                "<li>" +
                $("#PowerId option:selected").text() +
                "<input type='hidden' name='chkPower' id='chkPower' class='chkPower' value='" + $("#PowerId option:selected").val() + "'>" +
                "</li>");
        } else {
            alert("Poder/Arma já adicionado!");
        }
    });

    $('#listPowers').on('click', "li", function () {
        $(this).remove();
        console.log("oi")
        return false;
    });
});