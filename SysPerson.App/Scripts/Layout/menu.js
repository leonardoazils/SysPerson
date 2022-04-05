function ativarOpcao(elemento) {
  $(elemento).parent("li").parent().parent().parent().parent().addClass("active open");
  $(elemento).parent("li").parent().parent().addClass("open");
  $(elemento).parent("li").parent().toggle();
  $(elemento).parent("li").addClass("active");
}

$(document).ready(function () {
  $(".opcao").on("click", function (e) {
    localStorage.elemento = $(this).attr("id");
    localStorage.url = $(this).attr("href");
  });

  if (localStorage.length > 0 && localStorage.elemento != "dashboard") {
    if (window.location.href.indexOf(localStorage.url) != -1) {
      var elemento = "#" + localStorage.elemento;
      ativarOpcao(elemento);
    } else {
      $(".opcao").each(function () {
        if (window.location.href.indexOf($(this).attr("href")) != -1 && $(this).attr("id") != "dashboard") {
          ativarOpcao("#" + localStorage.elemento);
          return false;
        }
      });

      //if (window.location.href.indexOf("ListaRelatorios") != -1) {
      //  ativarOpcao("#relatorios");
      //  return false;
      //}

      //if (window.location.href.indexOf("ListaConfiguracoes") != -1) {
      //  ativarOpcao("#configuracoes");
      //  return false;
      //}

      //if (window.location.href.indexOf("ListaProdutos") != -1) {
      //  ativarOpcao("#produtos");
      //  return false;
      //}

      //if (window.location.href.indexOf("ListaFinanceiro") != -1) {
      //  ativarOpcao("#financeiro");
      //  return false;
      //}

      //if (window.location.href.indexOf("ListaVendas") != -1) {
      //  ativarOpcao("#vendas");
      //  return false;
      //}

      //if (window.location.href.indexOf("ListaEstabelecimentos") != -1) {
      //  ativarOpcao("#estabelecimentos");
      //  return false;
      //}

      //if (window.location.href.indexOf("LiberacaoTablet") != -1) {
      //  ativarOpcao("#inicial-dados");
      //  return false;
      //}

      //if (window.location.href.indexOf("LiberacaoTablet") != -1) {
      //  ativarOpcao("#configuracoes");
      //  return false;
      //}

      //if (window.location.href.indexOf("CertificadoDigital") != -1) {
      //  ativarOpcao("#inicial-loja");
      //  return false;
      //}

      //if (window.location.href.indexOf("CertificadoDigital") != -1) {
      //  ativarOpcao("#configuracoes");
      //  return false;
      //}

      //if (window.location.href.indexOf("Empresa") != -1) {
      //  ativarOpcao("#inicial-empresa");
      //  return false;
      //}

      //if (window.location.href.indexOf("Empresa") != -1) {
      //  ativarOpcao("#configuracoes");
      //  return false;
      //}

      //if (window.location.href.indexOf("Filial") != -1) {
      //  ativarOpcao("#inicial-loja");
      //  return false;
      //}

      //if (window.location.href.indexOf("Filial") != -1) {
      //  ativarOpcao("#configuracoes");
      //  return false;
      //}

      //if (window.location.href.indexOf("Perfil") != -1) {
      //  ativarOpcao("#inicial-acesso-perfil");
      //  return false;
      //}

      //if (window.location.href.indexOf("Perfil") != -1) {
      //  ativarOpcao("#configuracoes");
      //  return false;
      //}

      //if (window.location.href.indexOf("Funcionario") != -1) {
      //  ativarOpcao("#inicial-acesso-usuario");
      //  return false;
      //}

      //if (window.location.href.indexOf("Funcionario") != -1) {
      //  ativarOpcao("#configuracoes");
      //  return false;
      //}

      //if (window.location.href.indexOf("ProdutosFaturados") != -1) {
      //  ativarOpcao("#relatorio-produtos-faturados");
      //  return false;
      //}

      //if (window.location.href.indexOf("ProdutosFaturados") != -1) {
      //  ativarOpcao("#relatorios");
      //  return false;
      //}

      //if (window.location.href.indexOf("FechamentoCaixa") != -1) {
      //  ativarOpcao("#relatorio-fechamento-caixa");
      //  return false;
      //}

      //if (window.location.href.indexOf("FechamentoCaixa") != -1) {
      //  ativarOpcao("#relatorios");
      //  return false;
      //}

      //if (window.location.href.indexOf("Produto") != -1) {
      //  ativarOpcao("#produto-cadastro");
      //  return false;
      //}

      //if (window.location.href.indexOf("Produto") != -1) {
      //  ativarOpcao("#produtos");
      //  return false;
      //}

      //if (window.location.href.indexOf("ComposicaoObrigatoria") != -1) {
      //  ativarOpcao("#produto-cadastro");
      //  return false;
      //}

      //if (window.location.href.indexOf("ComposicaoObrigatoria") != -1) {
      //  ativarOpcao("#produtos");
      //  return false;
      //}

      //if (window.location.href.indexOf("PrecoComposicaoAgrupamento") != -1) {
      //  ativarOpcao("#produto-cadastro");
      //  return false;
      //}

      //if (window.location.href.indexOf("PrecoComposicaoAgrupamento") != -1) {
      //  ativarOpcao("#produtos");
      //  return false;
      //}

      //if (window.location.href.indexOf("Ingrediente") != -1) {
      //  ativarOpcao("#produto-cadastro");
      //  return false;
      //}

      //if (window.location.href.indexOf("Ingrediente") != -1) {
      //  ativarOpcao("#produtos");
      //  return false;
      //}

      //if (window.location.href.indexOf("UnidadeMedida") != -1) {
      //  ativarOpcao("#produto-unidade-medida");
      //  return false;
      //}

      //if (window.location.href.indexOf("UnidadeMedida") != -1) {
      //  ativarOpcao("#produtos");
      //  return false;
      //}

      //if (window.location.href.indexOf("Agrupamento") != -1) {
      //  ativarOpcao("#produto-categoria");
      //  return false;
      //}

      //if (window.location.href.indexOf("Agrupamento") != -1) {
      //  ativarOpcao("#produtos");
      //  return false;
      //}

      //if (window.location.href.indexOf("Adicional") != -1) {
      //  ativarOpcao("#produto-categoria");
      //  return false;
      //}

      //if (window.location.href.indexOf("Adicional") != -1) {
      //  ativarOpcao("#produtos");
      //  return false;
      //}

      //if (window.location.href.indexOf("PlanoConta") != -1) {
      //  ativarOpcao("#financeiro-plano-conta");
      //  return false;
      //}

      //if (window.location.href.indexOf("PlanoConta") != -1) {
      //  ativarOpcao("#financeiro");
      //  return false;
      //}

      //if (window.location.href.indexOf("Subconta") != -1) {
      //  ativarOpcao("#financeiro-plano-conta");
      //  return false;
      //}

      //if (window.location.href.indexOf("Subconta") != -1) {
      //  ativarOpcao("#financeiro");
      //  return false;
      //}

      //if (window.location.href.indexOf("TipoOperacaoCartao") != -1) {
      //  ativarOpcao("#financeiro-tipo-operacao");
      //  return false;
      //}

      //if (window.location.href.indexOf("TipoOperacaoCartao") != -1) {
      //  ativarOpcao("#financeiro");
      //  return false;
      //}

      //if (window.location.href.indexOf("BandeiraCartao") != -1) {
      //  ativarOpcao("#financeiro-bandeira-cartao");
      //  return false;
      //}

      //if (window.location.href.indexOf("BandeiraCartao") != -1) {
      //  ativarOpcao("#financeiro");
      //  return false;
      //}

      //if (window.location.href.indexOf("RedeAdquirente") != -1) {
      //  ativarOpcao("#financeiro-rede-adquirente");
      //  return false;
      //}

      //if (window.location.href.indexOf("RedeAdquirente") != -1) {
      //  ativarOpcao("#financeiro");
      //  return false;
      //}

      //if (window.location.href.indexOf("OperacaoCartao") != -1) {
      //  ativarOpcao("#financeiro-operacao-cartao");
      //  return false;
      //}

      //if (window.location.href.indexOf("OperacaoCartao") != -1) {
      //  ativarOpcao("#financeiro");
      //  return false;
      //}

      //if (window.location.href.indexOf("FormaPagamento") != -1) {
      //  ativarOpcao("#vendas-formas-pagamento");
      //  return false;
      //}

      //if (window.location.href.indexOf("FormaPagamento") != -1) {
      //  ativarOpcao("#vendas");
      //  return false;
      //}

      //if (window.location.href.indexOf("MotivoDesconto") != -1) {
      //  ativarOpcao("#vendas-motivo-desconto");
      //  return false;
      //}

      //if (window.location.href.indexOf("MotivoDesconto") != -1) {
      //  ativarOpcao("#vendas");
      //  return false;
      //}

      //if (window.location.href.indexOf("MotivoCancelamento") != -1) {
      //  ativarOpcao("#vendas-motivo-cancelamento");
      //  return false;
      //}

      //if (window.location.href.indexOf("MotivoCancelamento") != -1) {
      //  ativarOpcao("#vendas");
      //  return false;
      //}

      //if (window.location.href.indexOf("Observacao") != -1) {
      //  ativarOpcao("#vendas-obervacoes-item");
      //  return false;
      //}

      //if (window.location.href.indexOf("Observacao") != -1) {
      //  ativarOpcao("#vendas");
      //  return false;
      //}

      //if (window.location.href.indexOf("Convenio") != -1) {
      //  ativarOpcao("#vendas-convenio");
      //  return false;
      //}

      //if (window.location.href.indexOf("Convenio") != -1) {
      //  ativarOpcao("#vendas");
      //  return false;
      //}

      //if (window.location.href.indexOf("Garcom") != -1) {
      //  ativarOpcao("#vendas-garcom");
      //  return false;
      //}

      //if (window.location.href.indexOf("Garcom") != -1) {
      //  ativarOpcao("#vendas");
      //  return false;
      //}

      //if (window.location.href.indexOf("GrupoCartaoVip") != -1) {
      //  ativarOpcao("#estabelecimento-grupo-cartao-vip");
      //  return false;
      //}

      //if (window.location.href.indexOf("GrupoCartaoVip") != -1) {
      //  ativarOpcao("#estabelecimentos");
      //  return false;
      //}

      //if (window.location.href.indexOf("Pessoa") != -1) {
      //  ativarOpcao("#estabelecimento-pessoa");
      //  return false;
      //}

      //if (window.location.href.indexOf("Pessoa") != -1) {
      //  ativarOpcao("#estabelecimentos");
      //  return false;
      //}

      //if (window.location.href.indexOf("PontoReferencia") != -1) {
      //  ativarOpcao("#estabelecimento-ponto-referencia");
      //  return false;
      //}

      //if (window.location.href.indexOf("PontoReferencia") != -1) {
      //  ativarOpcao("#estabelecimentos");
      //  return false;
      //}

      //if (window.location.href.indexOf("Mesa") != -1) {
      //  ativarOpcao("#estabelecimento-mesa");
      //  return false;
      //}

      //if (window.location.href.indexOf("Mesa") != -1) {
      //  ativarOpcao("#estabelecimentos");
      //  return false;
      //}

      //if (window.location.href.indexOf("Turno") != -1) {
      //  ativarOpcao("#estabelecimento-turno");
      //  return false;
      //}

      //if (window.location.href.indexOf("Turno") != -1) {
      //  ativarOpcao("#estabelecimentos");
      //  return false;
      //}
    }
  } else if ((localStorage.length > 0 && localStorage.elemento == "dashboard") || (localStorage.length == 0)) {
    $("#dashboard").parent("li").addClass("active");
  }
});