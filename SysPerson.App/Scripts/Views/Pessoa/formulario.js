$(document).ready(function () {
    var urlBase = window.location.href.toLowerCase().split("/aplicacao/").length > 1 ? "/aplicacao" : "";

    $('.telefone').mask('(99) 9999?9-9999');

    $('.cnpj').mask('99.999.999/9999-99');

    $('.cep').mask('99.999-999');

    $("#QuantidadeQuota, #ValorQuota, #CapitalSocial").maskMoney({ prefix: '', allowNegative: false, thousands: '', decimal: ',', affixesStay: false, allowEmpty: true, allowZero: true, precision: 2 });

    $(".consulta").select2({
        width: "100%"
    });
});