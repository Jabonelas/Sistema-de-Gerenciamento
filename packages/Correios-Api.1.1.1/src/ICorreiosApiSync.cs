using Correios.CorreiosServiceReference;
namespace Correios
{
    public interface ICorreiosApiSync
    {
        long fechaPlp(string xml, long idPlpCliente, string cartaoPostagem, string faixaEtiquetas, string usuario, string senha);
        retorno[] registrarPedidosInformacao(pedidoInformacaoRegistro[] pedidosInformacao, string usuario, string senha);
        clienteERP buscaCliente(string idContrato, string idCartaoPostagem, string usuario, string senha);
        bool validaEtiquetaPLP(string numeroEtiqueta, long idPlp, string usuario, string senha);
        bool verificaDisponibilidadeServico(int codAdministrativo, string numeroServico, string cepOrigem, string cepDestino, string usuario, string senha);
        statusPlp getStatusPLP(objetoPostal[] arg0, string arg1);
        string bloquearObjeto(string numeroEtiqueta, long idPlp, tipoBloqueio tipoBloqueio, acao acao, string usuario, string senha);
        string solicitaEtiquetas(string tipoDestinatario, string identificador, long idServico, int qtdEtiquetas, string usuario, string senha);
        mensagemRetornoPIMaster[] obterMensagemRetornoPI();
        retorno[] consultarPedidosInformacao(pedidoInformacaoConsulta[] pedidosInformacao, string usuario, string senha);
        string buscaPagamentoEntrega(string usuario, string senha);
        int[] geraDigitoVerificadorEtiquetas(string[] etiquetas, string usuario, string senha);
        bool validarPostagemReversa(int codAdministrativo, int codigoServico, string cepDestinatario, coletaReversaTO coleta, string usuario, string senha);
        long fechaPlpVariosServicos(string xml, long idPlpCliente, string cartaoPostagem, string[] listaEtiquetas, string usuario, string senha);
        bool cancelarObjeto(long idPlp, string numeroEtiqueta, string usuario, string senha);
        bool validaPlp(long cliente, string numero, long diretoria, string cartao, string unidadePostagem, long servico, string[] servicosAdicionais, string usuario, string senha);
        bool validarPostagemSimultanea(int codAdministrativo, int codigoServico, string cepDestinatario, coletaSimultaneaTO coleta, string usuario, string senha);
        embalagemLRSMaster[] obterEmbalagemLRS();
        retornoCancelamentoTO cancelarPedidoScol(int codAdministrativo, string idPostagem, string tipo, string usuario, string senha);
        servicoERP[] buscaServicos(string idContrato, string idCartaoPostagem, string usuario, string senha);
        string solicitarPostagemScol(int codAdministrativo, string xml, string usuario, string senha);
        string solicitaPLP(long idPlpMaster, string numEtiqueta, string usuario, string senha);
        statusCartao getStatusCartaoPostagem(string numeroCartaoPostagem, string usuario, string senha);
        string solicitaXmlPlp(long idPlpMaster, string usuario, string senha);
        motivoPIMaster[] obterMotivosPI();
        contratoERP buscaContrato(string numero, long diretoria, string usuario, string senha);
        string consultaSRO(string[] listaObjetos, string tipoConsulta, string tipoResultado, string usuarioSro, string senhaSro);
        System.DateTime obterClienteAtualizacao(string cnpjCliente, string usuario, string senha);
        bool integrarUsuarioScol(int codAdministrativo, string usuario, string senha);
        bool atualizaPLP(long idPlpMaster, string numEtiqueta, string usuario, string senha, string xml);
        assuntoPIMaster[] obterAssuntosPI();
        enderecoERP consultaCEP(string cep);
    }
}