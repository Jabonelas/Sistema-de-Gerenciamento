using System.Threading.Tasks;
using Correios.CorreiosServiceReference;
namespace Correios
{
    public interface ICorreiosApiAsync
    {
        Task<fechaPlpResponse> fechaPlpAsync(string xml, long idPlpCliente, string cartaoPostagem, string faixaEtiquetas, string usuario, string senha);
        Task<registrarPedidosInformacaoResponse> registrarPedidosInformacaoAsync(pedidoInformacaoRegistro[] pedidosInformacao, string usuario, string senha);
        Task<buscaClienteResponse> buscaClienteAsync(string idContrato, string idCartaoPostagem, string usuario, string senha);
        Task<validaEtiquetaPLPResponse> validaEtiquetaPLPAsync(string numeroEtiqueta, long idPlp, string usuario, string senha);
        Task<verificaDisponibilidadeServicoResponse> verificaDisponibilidadeServicoAsync(int codAdministrativo, string numeroServico, string cepOrigem, string cepDestino, string usuario, string senha);
        Task<getStatusPLPResponse> getStatusPLPAsync(objetoPostal[] arg0, string arg1);
        Task<bloquearObjetoResponse> bloquearObjetoAsync(string numeroEtiqueta, long idPlp, tipoBloqueio tipoBloqueio, acao acao, string usuario, string senha);
        Task<solicitaEtiquetasResponse> solicitaEtiquetasAsync(string tipoDestinatario, string identificador, long idServico, int qtdEtiquetas, string usuario, string senha);
        Task<obterMensagemRetornoPIResponse> obterMensagemRetornoPIAsync();
        Task<consultarPedidosInformacaoResponse> consultarPedidosInformacaoAsync(pedidoInformacaoConsulta[] pedidosInformacao, string usuario, string senha);
        Task<buscaPagamentoEntregaResponse> buscaPagamentoEntregaAsync(string usuario, string senha);
        Task<geraDigitoVerificadorEtiquetasResponse> geraDigitoVerificadorEtiquetasAsync(string[] etiquetas, string usuario, string senha);
        Task<validarPostagemReversaResponse> validarPostagemReversaAsync(int codAdministrativo, int codigoServico, string cepDestinatario, coletaReversaTO coleta, string usuario, string senha);
        Task<fechaPlpVariosServicosResponse> fechaPlpVariosServicosAsync(string xml, long idPlpCliente, string cartaoPostagem, string[] listaEtiquetas, string usuario, string senha);
        Task<cancelarObjetoResponse> cancelarObjetoAsync(long idPlp, string numeroEtiqueta, string usuario, string senha);
        Task<validaPlpResponse> validaPlpAsync(long cliente, string numero, long diretoria, string cartao, string unidadePostagem, long servico, string[] servicosAdicionais, string usuario, string senha);
        Task<validarPostagemSimultaneaResponse> validarPostagemSimultaneaAsync(int codAdministrativo, int codigoServico, string cepDestinatario, coletaSimultaneaTO coleta, string usuario, string senha);
        Task<obterEmbalagemLRSResponse> obterEmbalagemLRSAsync();
        Task<cancelarPedidoScolResponse> cancelarPedidoScolAsync(int codAdministrativo, string idPostagem, string tipo, string usuario, string senha);
        Task<buscaServicosResponse> buscaServicosAsync(string idContrato, string idCartaoPostagem, string usuario, string senha);
        Task<solicitarPostagemScolResponse> solicitarPostagemScolAsync(int codAdministrativo, string xml, string usuario, string senha);
        Task<solicitaPLPResponse> solicitaPLPAsync(long idPlpMaster, string numEtiqueta, string usuario, string senha);
        Task<getStatusCartaoPostagemResponse> getStatusCartaoPostagemAsync(string numeroCartaoPostagem, string usuario, string senha);
        Task<solicitaXmlPlpResponse> solicitaXmlPlpAsync(long idPlpMaster, string usuario, string senha);
        Task<obterMotivosPIResponse> obterMotivosPIAsync();
        Task<buscaContratoResponse> buscaContratoAsync(string numero, long diretoria, string usuario, string senha);
        Task<consultaSROResponse> consultaSROAsync(string[] listaObjetos, string tipoConsulta, string tipoResultado, string usuarioSro, string senhaSro);
        Task<obterClienteAtualizacaoResponse> obterClienteAtualizacaoAsync(string cnpjCliente, string usuario, string senha);
        Task<integrarUsuarioScolResponse> integrarUsuarioScolAsync(int codAdministrativo, string usuario, string senha);
        Task<atualizaPLPResponse> atualizaPLPAsync(long idPlpMaster, string numEtiqueta, string usuario, string senha, string xml);
        Task<obterAssuntosPIResponse> obterAssuntosPIAsync();
        Task<consultaCEPResponse> consultaCEPAsync(string cep);
    }
}