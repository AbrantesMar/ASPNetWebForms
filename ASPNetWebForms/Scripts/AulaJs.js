$(document).ready(function () {
    $("#btnSalvar").click(function () {
        if ($("#MainContent_txtName").val() === "") {
            //alert("Campo nome em banco.");
            $("#MainContent_txtDescription").css("background-color", "red");
        }
        if ($("#MainContent_txtDescription").val() === "") {
            //alert("Descriçaõ não foi informada.");
            $("#MainContent_txtDescription").css("background-color", "red");
        }
    });
    $("#listaOrdenada > li").addClass("azul");
});