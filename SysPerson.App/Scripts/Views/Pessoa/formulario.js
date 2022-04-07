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

function bloqueiaCamposPessoaFisica() {
    $("#TipoPessoaId").prop('disabled', 'disabled');
    $("#Nacional").prop('disabled', 'disabled');
    $("#EstadoCivilId").prop('disabled', 'disabled');
    $("#TipoEmpresaId").prop('disabled', 'disabled');
    $("#GeneroId").prop('disabled', 'disabled');
    $("#Nascimento").prop('disabled', 'disabled');
    $("#Cpf").prop('readonly', 'readonly');
    $("#Nome").prop('readonly', 'readonly');
    $("#EmailPrincipal").prop('readonly', 'readonly');
    $("#Profissao").prop('readonly', 'readonly');
    $("#TelefonePrincipal").prop('readonly', 'readonly');
    $("#TelefoneSecundario").prop('readonly', 'readonly');
    $("#TelefoneReserva").prop('readonly', 'readonly');
    $("#Nacionalidade").prop('readonly', 'readonly');
}

function LiberaCamposPessoaFisica() {
    $("#TipoPessoaId").removeProp('disabled');
    $("#Nacional").removeProp('disabled');
    $("#EstadoCivilId").removeProp('disabled');
    $("#TipoEmpresaId").removeProp('disabled');
    $("#GeneroId").removeProp('disabled');
    $("#Nascimento").removeProp('disabled');
    $("#Cpf").removeProp('readonly');
    $("#Nome").removeProp('readonly');
    $("#EmailPrincipal").removeProp('readonly');
    $("#Profissao").removeProp('readonly');
    $("#TelefonePrincipal").removeProp('readonly');
    $("#TelefoneSecundario").removeProp('readonly');
    $("#TelefoneReserva").removeProp('readonly');
    $("#Nacionalidade").removeProp('readonly');
}

function bloqueiaCamposPessoaJuridica() {
    $("#TipoPessoaId").prop('disabled', 'disabled');
    $("#Nacional").prop('disabled', 'disabled');
    $("#CaracterizacaoCapitalId").prop('disabled', 'disabled');
    $("#TipoEmpresaPjId").prop('disabled', 'disabled');
    $("#PorteId").prop('disabled', 'disabled');
    $("#Cnpj").prop('readonly', 'readonly');
    $("#RazaoSocial").prop('readonly', 'readonly');
    $("#NomeFantasia").prop('readonly', 'readonly');
    $("#DataConstituicao").prop('disabled', 'disabled');
    $("#Website").prop('readonly', 'readonly');
    $("#EmailPrincipalEmpresa").prop('readonly', 'readonly');
    $("#QuantidadeQuota").prop('readonly', 'readonly');
    $("#ValorQuota").prop('readonly', 'readonly');
    $("#CapitalSocial").prop('readonly', 'readonly');
    $("#TelefonePrincipalEmpresa").prop('readonly', 'readonly');
    $("#TelefoneSecundarioEmpresa").prop('readonly', 'readonly');
    $("#TelefoneReservaEmpresa").prop('readonly', 'readonly');
    $("#Nacionalidade").prop('readonly', 'readonly');
}

function LiberaCamposPessoaJuridica() {
    $("#TipoPessoaId").removeProp('disabled');
    $("#Nacional").removeProp('disabled');
    $("#CaracterizacaoCapitalId").removeProp('disabled');
    $("#TipoEmpresaPjId").removeProp('disabled');
    $("#PorteId").removeProp('disabled');
    $("#Cnpj").removeProp('readonly');
    $("#RazaoSocial").removeProp('readonly');
    $("#NomeFantasia").removeProp('readonly');
    $("#DataConstituicao").removeProp('disabled');
    $("#Website").removeProp('readonly');
    $("#EmailPrincipalEmpresa").removeProp('readonly');
    $("#QuantidadeQuota").removeProp('readonly');
    $("#ValorQuota").removeProp('readonly');
    $("#CapitalSocial").removeProp('readonly');
    $("#TelefonePrincipalEmpresa").removeProp('readonly');
    $("#TelefoneSecundarioEmpresa").removeProp('readonly');
    $("#TelefoneReservaEmpresa").removeProp('readonly');
    $("#Nacionalidade").removeProp('readonly');
}

$(document).ready(function () {
    $('.telefone').mask('(99) 9999?9-9999');

    $('.cnpj').mask('99.999.999/9999-99');

    $('.cpf').mask('999.999.999-99');

    $('.cep').mask('99.999-999');

    $("#QuantidadeQuota, #ValorQuota, #CapitalSocial").maskMoney({ prefix: '', allowNegative: false, thousands: '', decimal: ',', affixesStay: false, allowEmpty: true, allowZero: true, precision: 2 });

    $(".consulta").select2({
        width: "100%"
    });

    showForm();
    
    if ($("#BloqueiaCampos").val() == "True") {
        bloqueiaCamposPessoaFisica();
        bloqueiaCamposPessoaJuridica();
    }
    else {
        LiberaCamposPessoaFisica();
        LiberaCamposPessoaJuridica();
    }

    $("#TipoPessoaId").on("change", function (e) {
        debugger;
        showForm();
    });
});