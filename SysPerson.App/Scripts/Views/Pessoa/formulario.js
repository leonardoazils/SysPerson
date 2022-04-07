function showForm() {
    let tipoPessoa = $("#TipoPessoaId").val();

    if (tipoPessoa == 1) {
        $("#container-pessoa-juridica").addClass("hidden");
        $("#container-pessoa-fisica").removeClass("hidden");
    }
    else if (tipoPessoa == 2) {
        $("#container-pessoa-fisica").addClass("hidden");
        $("#container-pessoa-juridica").removeClass("hidden");
    }
    else {
        $("#container-pessoa-juridica").addClass("hidden");
        $("#container-pessoa-fisica").addClass("hidden");
    } 
}

$(document).ready(function () {
    var urlBase = window.location.href.toLowerCase().split("/aplicacao/").length > 1 ? "/aplicacao" : "";

    $('.telefone').mask('(99) 9999?9-9999');

    $('.cnpj').mask('99.999.999/9999-99');

    $('.cpf').mask('999.999.999-99');

    $('.cep').mask('99.999-999');

    $("#QuantidadeQuota, #ValorQuota, #CapitalSocial").maskMoney({ prefix: '', allowNegative: false, thousands: '', decimal: ',', affixesStay: false, allowEmpty: true, allowZero: true, precision: 2 });

    $(".consulta").select2({
        width: "100%"
    });

    if ($("#Id").val() == "00000000-0000-0000-0000-000000000000") {
        $("#container-pessoa-juridica").addClass("hidden");
        $("#container-pessoa-fisica").addClass("hidden");
    } else {
        showForm();
    }

    $("#TipoPessoaId").on("change", function (e) {
        showForm();
    });
});