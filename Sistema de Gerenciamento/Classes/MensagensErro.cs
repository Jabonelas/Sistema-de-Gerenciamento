using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento
{
    internal class MensagensErro
    {
        #region Forms

        #region Cadastro Cliente

        public void ErroAoCadastroCliente(Exception _e)
        {
            MessageBox.Show($"(CAD-CL01) Erro ao Cadastrar Cliente \n\nErro: {_e}", "Erro Cadastro Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarCadastroCliente(Exception _e)
        {
            MessageBox.Show($"(CAD-CL02) Erro ao Atualizar Cadastro Cliente \n\nErro: {_e}", "Erro Atualizar Cadastro Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirCadastroCliente(Exception _e)
        {
            MessageBox.Show($"(CAD-CL03) Erro ao Excluir Cadastro Cliente \n\nErro: {_e}", "Erro Excluir Cadastro Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Cliente

        #region Cadastro Fornecedor

        public void ErroAoCadastroFornecedor(Exception _e)
        {
            MessageBox.Show($"(CAD-FN01) Erro ao Cadastrar Fornecedor \n\nErro: {_e}", "Erro Cadastro Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarCadastroFornecedor(Exception _e)
        {
            MessageBox.Show($"(CAD-FN02) Erro ao Atualizar Cadastro Fornecedor \n\nErro: {_e}", "Erro Atualizar Cadastro Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirCadastroFornecedor(Exception _e)
        {
            MessageBox.Show($"(CAD-FN03) Erro ao Excluir Cadastro Fornecedor \n\nErro: {_e}", "Erro Excluir Cadastro Forncedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Fornecedor

        #region Cadastro Produto

        public void ErroAoCadastroProduto(Exception _e)
        {
            MessageBox.Show($"(CAD-PR01) Erro ao Cadastrar Produto \n\nErro: {_e}", "Erro Cadastro Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarCadastroProduto(Exception _e)
        {
            MessageBox.Show($"(CAD-PR02) Erro ao Atualizar Cadastro Produto \n\nErro: {_e}", "Erro Atualizar Cadastro Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirCadastroProduto(Exception _e)
        {
            MessageBox.Show($"(CAD-PR03) Erro ao Excluir Cadastro Produto \n\nErro: {_e}", "Erro Excluir Cadastro Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Produto

        #region Cadastro Grupo Material

        public void ErroAoCadastroGrupoMaterial(Exception _e)
        {
            MessageBox.Show($"(CAD-GR01) Erro ao Cadastrar Grupo de Material \n\nErro: {_e}", "Erro Cadastro Grupo Material!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Grupo Material

        #region Cadastro Empresa

        public void ErroAoCadastroEmpresa(Exception _e)
        {
            MessageBox.Show($"(CAD-EM01) Erro ao Cadastrar Empresa \n\nErro: {_e}", "Erro Cadastro Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoCarregarDadosEmpresa(Exception _e)
        {
            MessageBox.Show($"(CAD-EM02) Erro ao Carregar Dados da Empresa \n\nErro: {_e}", "Erro Carregar Dados Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarCadastroEmpresa(Exception _e)
        {
            MessageBox.Show($"(CAD-EM03) Erro ao Atualizar Empresa \n\nErro: {_e}", "Erro Atualizar Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Empresa

        #region Cadastro Usuario

        public void ErroAoCadastroUsuario(Exception _e)
        {
            MessageBox.Show($"(CAD-US01) Erro ao Cadastrar Usuario \n\nErro: {_e}", "Erro Cadastro Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarCadastroUsuario(Exception _e)
        {
            MessageBox.Show($"(CAD-US02) Erro ao Atualizar Usuario \n\nErro: {_e}", "Erro Atualizar Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroUsuario(Exception _e)
        {
            MessageBox.Show($"(CAD-US03) Erro ao Buscar Usuario \n\nErro: {_e}", "Erro Buscar Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Usuario

        #region Cadastro Despesa

        public void ErroAoInserirCadastroDespesa(Exception _e)
        {
            MessageBox.Show($"(CAD-DE01) Erro ao Inserir Despesa \n\nErro: {_e}", "Erro Inserir Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarCadastroDespesa(Exception _e)
        {
            MessageBox.Show($"(CAD-DE02) Erro ao Atualizar Cadastro Despesa \n\nErro: {_e}", "Erro Atualizar Cadastro Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirCadastroDespesa(Exception _e)
        {
            MessageBox.Show($"(CAD-DE03) Erro ao Excluir Cadastro Despesa \n\nErro: {_e}", "Erro Excluir Cadastro Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Despesa

        #region Estoque Produto

        public void ErroAoBuscarEstoqueProduto(Exception _e)
        {
            MessageBox.Show($"(ESP-EP01) Erro ao Buscar Estoque Produto \n\nErro: {_e}", "Erro Estoque Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarEstoqueProduto(Exception _e)
        {
            MessageBox.Show($"(ESP-EP02) Erro ao Adicionar Estoque Produto \n\nErro: {_e}", "Erro Adicionar Estoque Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Estoque Produto

        #region Compras

        public void ErroAoBuscarNotaFiscalEntrada(Exception _e)
        {
            MessageBox.Show($"(COM-EP01) Erro ao Buscar Estoque Produto \n\nErro: {_e}", "Erro Estoque Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAlterarCodigoBarrasNotaFiscalEntrada(Exception _e)
        {
            MessageBox.Show($"(COM-EP02) Erro ao Alterar Codigo de Barras Nota Fiscal Entrada \n\nErro: {_e}", "Erro Alterar Codigo de Barras Nota Fiscal Entrada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoSalvarNotaFiscalEntrada(Exception _e)
        {
            MessageBox.Show($"(COM-EP03) Erro ao Salvar Nota Fiscal de Entrada \n\nErro: {_e}", "Erro Salvar Nota Fiscal de Entrada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroExcluirNotaFiscalEntrada(Exception _e)
        {
            MessageBox.Show($"(COM-EP03) Erro ao Excluir Nota Fiscal de Entrada \n\nErro: {_e}", "Erro Excluit Nota Fiscal de Entrada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Compras

        #region Gerar Carne

        public void ErroAoBuscarDadosParaPreencherTextBox(Exception _e)
        {
            MessageBox.Show($"(GEC-VE01) Erro ao Buscar Dados Para Preenchimento TextBox \n\nErro: {_e}", "Erro Preencher TextBox!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarJurosGerarCarne(Exception _e)
        {
            MessageBox.Show($"(GEC-VE02) Erro ao Buscar Juros Do Carne \n\nErro: {_e}", "Erro Buscar Juros !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Gerar Carne

        #region Despesa

        public void ErroAoInserirDadosDespesa(Exception _e)
        {
            MessageBox.Show($"(DES-DE01) Erro ao Inserir Dados de Despesa \n\nErro: {_e}", "Erro Inserir Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Despesa

        #region Tela PDV

        public void ErroAoBuscarProdutoPorCodigoProduto(Exception _e)
        {
            MessageBox.Show($"(PDV-VE01) Erro ao Buscar Produto Por Codigo \n\nErro: {_e}", "Erro Produto Por Codigo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarProdutoPorCodigoBarras(Exception _e)
        {
            MessageBox.Show($"(PDV-VE02) Erro ao Buscar Produto Por Codigo Barras  \n\nErro: {_e}", "Erro Produto Por Codigo Barras!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoInserirProdutoPorCodigoProdutoTelaPDV(Exception _e)
        {
            MessageBox.Show($"(PDV-VE03) Erro ao Inserir Produto Por Codigo de Produto \n\nErro: {_e}", "Erro Inserir Produto Por Codigo de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoInserirProdutoPorCodigoBarrasTelaPDV(Exception _e)
        {
            MessageBox.Show($"(PDV-VE04) Erro ao Inserir Produto Por Codigo de Barras \n\nErro: {_e}", "Erro Inserir Produto Por Codigo de Barras!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoInserirDadosNaNotaFiscalSaidaTelaPDV(Exception _e)
        {
            MessageBox.Show($"(PDV-VE05) Erro ao Inserir Dados Nota Fiscal Saida \n\nErro: {_e}", "Erro Inserir Dados Nota Fiscal Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Tela PDV

        #region Devolução/Troca

        public void ErroAoBuscarNotaFiscalSaida(Exception _e)
        {
            MessageBox.Show($"(DVT-DV01) Erro ao Buscar Nota Fiscal Saida \n\nErro: {_e}", "Erro Buscar Nota Fiscal Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Devolução/Troca

        #endregion Forms

        #region Banco

        #region Inserir No Banco

        #region Cliente

        public void ErroAoAdicionarClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-CL01) Erro ao Inserir Cadastro Cliente \n\nErro: {_e}", "Erro Inserir Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarImagemClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-CL02) Erro ao Inserir Imagem No Cadastro Cliente \n\nErro: {_e}", "Erro Inserir Imagem Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cliente

        #region Forncedor

        public void ErroAoAdicionarFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-FN01) Erro ao Inserir Cadastro Fornecedor \n\nErro: {_e}", "Erro Inserir Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarImagemFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-FN02) Erro ao Inserir Imagem No Cadastro Fornecedor \n\nErro: {_e}", "Erro Inserir Imagem Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Forncedor

        #region Produto

        public void ErroAoAdicionarProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-PR01) Erro ao Inserir Cadastro Produto \n\nErro: {_e}", "Erro Inserir Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarImagemProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-PR02) Erro ao Inserir Imagem No Cadastro Produto \n\nErro: {_e}", "Erro Inserir Imagem Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Produto

        #region Grupo

        public void ErroAoAdicionarGrupoMaterialNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-GR01) Erro ao Inserir Grupo de Material \n\nErro: {_e}", "Erro Inserir Grupo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Grupo

        #region Empresa

        public void ErroAoAdicionarEmpresaNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-EM01) Erro ao Inserir Empresa \n\nErro: {_e}", "Erro Inserir Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Empresa

        #region Usuario

        public void ErroAoAdicionarUsuarioNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-EM01) Erro ao Inserir Empresa \n\nErro: {_e}", "Erro Inserir Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Usuario

        #region Despesa

        public void ErroAoAdicionarDespesaCustoNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-DE01) Erro ao Inserir Despesa/Custo \n\nErro: {_e}", "Erro Inserir Despesa/Custo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarDespesaNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-DE02) Erro ao Inserir Despesa \n\nErro: {_e}", "Erro Inserir Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarImagemPagameentoDespesaCustoNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-DE03) Erro ao Inserir Imagem de Pagamento Despesa e Custo \n\nErro: {_e}", "Erro Inserir Imagem Pagamento Despesa/Custo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarDespesaCustoFixaNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-DE04) Erro ao Inserir Despesa e Custo Fixo \n\nErro: {_e}", "Erro Inserir Despesa/Custo Fixo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Despesa

        #region Estoque Produto

        public void ErroAoAdicionarEstoqueProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-EP01) Erro ao Inserir Estoque de Produto \n\nErro: {_e}", "Erro Inserir Estoque Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Estoque Produto

        #region Nota Fiscal Saida

        public void ErroAoAdicionarNotaFiscalSaidaNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-NFS01) Erro ao Inserir Nota Fiscal Saida \n\nErro: {_e}", "Erro Inserir Nota Fiscal Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Nota Fiscal Saida

        #region Troca

        public void ErroAoAdicionarNoEstoqueMaterialSegregadoNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-EMS01) Erro ao Adcionar No Estoque Material Segregado \n\nErro: {_e}", "Erro Adcionar No Estoque Material Segregado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Troca

        #region Pagamento Carne

        public void ErroAoAdicionarPagamentoCarneNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-PC01) Erro ao Adicionar Pagamento Carnê \n\nErro: {_e}", "Erro Adcionar Pagamento Carnê!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Pagamento Carne

        #endregion Inserir No Banco

        #region Atualizacao Do Banco

        #region Cliente

        public void ErroAoAtualizarClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-CL01) Erro ao Atualizar Cadastro de Cliente \n\nErro: {_e}", "Erro Atualizacao Cadastro Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarImagemClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-CL02) Erro ao Atualizar Imagem do Cliente \n\nErro: {_e}", "Erro Atualizacao Imagem Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarSaldoClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-CL03) Erro ao Atualizar Saldo do Cliente \n\nErro: {_e}", "Erro Atualizacao Saldo Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cliente

        #region Fornecedor

        public void ErroAoAtualizarFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-FN01) Erro ao Atualizar Cadastro de Fornecedor \n\nErro: {_e}", "Erro Atualizacao Cadastro Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarImagemFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-FN02) Erro ao Atualizar Imagem do Fornecedor \n\nErro: {_e}", "Erro Atualizacao Imagem Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Fornecedor

        #region Produto

        public void ErroAoAtualizarProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-PR01) Erro ao Atualizar Cadastro do Produto \n\nErro: {_e}", "Erro Atualizacao Cadastro Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarImagemProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-PR02) Erro ao Atualizar Imagem do Produto \n\nErro: {_e}", "Erro Atualizacao Imagem Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Produto

        #region Empresa

        public void ErroAoAtualizarEmpresaNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EM01) Erro ao Atualizar Cadastro da Empresa \n\nErro: {_e}", "Erro Atualizacao Cadastro Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarImagemEmpresaNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EM02) Erro ao Atualizar Imagem da Empresa \n\nErro: {_e}", "Erro Atualizacao Imagem Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Empresa

        #region Usuario

        public void ErroAoAtualizarUsuarioNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-US01) Erro ao Atualizar Cadastro do Usuario \n\nErro: {_e}", "Erro Atualizacao Cadasto Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Usuario

        #region Cadastro Despesa

        public void ErroAoAtualizarCadastroDespesaCustoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-DE01) Erro ao Atualizar Cadastro de Despesa \n\nErro: {_e}", "Erro Atualizacao Cadasto Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Despesa

        #region Estoque Produto

        public void ErroAoAtualizarQuantidadeDataEntradaEstoqueProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EP01) Erro ao Atualizar Quantidade de Estoque! \n\nErro: {_e}", "Erro Atualizacao Quantidade Estoque!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarQuantidadeEstoqueProdutoNotaFiscalEntradaCanceladaNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EP02) Erro ao Atualizar Quantidade de Estoque! \n\nErro: {_e}", "Erro Atualizacao Quantidade Estoque!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarQuantidadeEstoqueProdutoPosVendaNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EP03) Erro ao Atualizar Quantidade de Estoque Pós Venda! \n\nErro: {_e}", "Erro Atualizacao Quantidade Estoque Pós Venda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarCodigoBarrasEstoqueProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EP04) Erro ao Atualizar Codigo de Barras de Produto! \n\nErro: {_e}", "Erro Atualizacao Codigo de Barras de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Estoque Produto

        #region Nota Fiscal Entrada

        public void ErroAoAtualizarDataLancamentoNotaFiscalEntradaNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EP01) Erro ao Atualizar Data Lancamento Nota Fiscal! \n\nErro: {_e}", "Erro Atualizacao Data Lancamento Nota Fiscal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarDataLancamentoNotaFiscalEntradaQuandoCanceladaNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EP02) Erro ao Atualizar Data Lancamento Nota Fiscal Cancelamento! \n\nErro: {_e}", "Erro Atualizacao Data Lancamento Nota Fiscal Cancelamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Nota Fiscal Entrada

        #region Desepesa e Custo

        public void ErroAoAtualizarDespesaCustoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-DE01) Erro ao Atualizar Despesa e Custo \n\nErro: {_e}", "Erro Atualizacao Despesa/Custo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarCodigoDespesaCustoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-DE02) Erro ao Atualizar Codigo Despesa e Custo \n\nErro: {_e}", "Erro Atualizacao Codigo Despesa/Custo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarCodigoDespesaCustoFixoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-DE03) Erro ao Atualizar Codigo Despesa e Custo Fixo \n\nErro: {_e}", "Erro Atualizacao Codigo Despesa/Custo Fixo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Desepesa e Custo

        #region Edição Pagamento

        public void ErroAoAtualizarPagamentoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EP01) Erro ao Atualizar Pagamento de Despesa e Custo! \n\nErro: {_e}", "Erro Atualizacao Pagamento de Despesa e Custo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarDadosTrocaoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EP02) Erro ao Atualizar Dados Para Troca! \n\nErro: {_e}", "Erro Atualizar Dados Para Troca!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarGarantiaTrocaoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-EP03) Erro ao Atualizar Garantia Para Troca! \n\nErro: {_e}", "Erro Atualizar Garantia Para Troca!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Edição Pagamento

        #region Pagameento Carne

        public void ErroAoAtualizarImagemStatusPagamentoCarneNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-PC01) Erro ao Atualizar Imagem Status Pagamento Carne! \n\nErro: {_e}", "Erro Atualizar Imagem Status Pagamento Carne!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Pagameento Carne

        #region Edicao Pagamento a Receber

        public void ErroAoAtualizarImagemStatusPagamentoAReceberNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-PR01) Erro ao Atualizar Imagem e Status Pagamento a Receber! \n\nErro: {_e}", "Erro Atualizar Imagem e Status Pagamento a Receber!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Edicao Pagamento a Receber

        #endregion Atualizacao Do Banco

        #region Excluir No Banco

        #region Cliente

        public void ErroAoExluirCadastroClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-CL01) Erro ao Excluir Cadastro Cliente \n\nErro: {_e}", "Erro Excluir Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirImagemClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-CL02) Erro ao Excluir Imagem Cliente \n\nErro: {_e}", "Erro Excluir Imagem Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cliente

        #region Fornecedor

        public void ErroAoExluirCadastroFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-FN01) Erro ao Excluir Cadastro Fornecedor \n\nErro: {_e}", "Erro Excluir Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirImagemFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-FN02) Erro ao Excluir Imagem Fornecedor \n\nErro: {_e}", "Erro Excluir Imagem Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Fornecedor

        #region Produto

        public void ErroAoExluirCadastroProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-PR01) Erro ao Excluir Cadastro Produto \n\nErro: {_e}", "Erro Excluir Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirImagemProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-PR02) Erro ao Excluir Imagem Produto \n\nErro: {_e}", "Erro Excluir Imagem Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Produto

        #region Grupo

        public void ErroAoExluirCadastroGrupoMaterialNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-GR01) Erro ao Excluir Grupo Material \n\nErro: {_e}", "Erro Excluir Grupo Materail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Grupo

        #region Cadastro Despesa

        public void ErroAoExluirCadastroDespesaNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-CD01) Erro ao Excluir Despesa \n\nErro: {_e}", "Erro Excluir Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Despesa

        #region Despesa e Custo

        public void ErroAoExluirDespesaCustoNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-DC01) Erro ao Excluir Despesa e Custo \n\nErro: {_e}", "Erro Excluir Despesa/Custo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Despesa e Custo

        #endregion Excluir No Banco

        #region Buscar No Banco

        #region Cliente

        public void ErroAoBuscarClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL01) Erro ao Realizar Busca de Cliente \n\nErro: {_e}", "Erro Busca Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarImagemClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL02) Erro ao Realizar Busca de Imagem do Cliente \n\nErro: {_e}", "Erro Busca Imagem Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL04) Erro ao Realizar Busca de Lista do Cliente \n\nErro: {_e}", "Erro Busca Lista Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaDadosClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL05) Erro ao Realizar Busca de Lista de Dados do Cliente \n\nErro: {_e}", "Erro Busca Lista de Dados Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarClientePorPesquisaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL06) Erro ao Realizar Busca da Lista Cliente Por Pesquisa \n\nErro: {_e}", "Erro Busca Lista Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroClientePorCodigoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL07) Erro ao Realizar Busca Cadastro Cliente Por Codigo \n\nErro: {_e}", "Erro Busca Cadastro Cliente Por Codigo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroClienteCPF_CNPJNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL08) Erro ao Realizar Busca Cadastro Cliente Por CPF/CNPJ \n\nErro: {_e}", "Erro Busca Cadastro Cliente Por CPF/CNPJ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroClienteRGNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL09) Erro ao Realizar Busca Cadastro Cliente Por RG \n\nErro: {_e}", "Erro Busca Cadastro Cliente Por RG!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroClientePorNomeNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL10) Erro ao Realizar Busca Cadastro de Cliente Por Nome \n\nErro: {_e}", "Erro Busca Cadastro Cliente Por Nome!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarIdClientePorNomeNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL11) Erro ao Realizar Busca Cadastro de ID Cliente Por Nome \n\nErro: {_e}", "Erro Busca ID Cadastro Cliente Por Nome!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroCompletoClientePorNomeNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL12) Erro ao Realizar Busca Cadastro Completo Cliente Por Nome \n\nErro: {_e}", "Erro Busca Cadastro Completo Cliente Por Nome!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cliente

        #region Fornecedor

        public void ErroAoBuscarFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-FN01) Erro ao Realizar Busca de Fornecedor \n\nErro: {_e}", "Erro Busca Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarImagemFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-FN02) Erro ao Realizar Busca de Imagem do Fornecedor \n\nErro: {_e}", "Erro Busca Imagem Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-FN04) Erro ao Realizar Busca dos Fornecedores \n\nErro: {_e}", "Erro Busca Fornecedores!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Fornecedor

        #region Produto

        public void ErroAoBuscarGrupoProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR04) Erro ao Realizar Busca de Grupo do Produto \n\nErro: {_e}", "Erro Busca Grupo Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarSubGrupoProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR05) Erro ao Realizar Busca de Sub-Grupo do Produto \n\nErro: {_e}", "Erro Busca Sub-Grupo Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR06) Erro ao Realizar Busca do Produto \n\nErro: {_e}", "Erro Busca Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarImagemProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR07) Erro ao Realizar Busca de Imagem do Produto \n\nErro: {_e}", "Erro Busca Imagem Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR08) Erro ao Realizar Busca de Lista do Produto \n\nErro: {_e}", "Erro Busca Lista Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarProdutoPorPesquisaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR09) Erro ao Realizar Busca do Produto Por Pesquisa \n\nErro: {_e}", "Erro Busca Produto Pesquisa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDescontoProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR10) Erro ao Realizar Busca Desconto do Produto \n\nErro: {_e}", "Erro Busca Desconto Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarComissaoProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR11) Erro ao Realizar Busca Comissao do Produto \n\nErro: {_e}", "Erro Busca Comissao Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarExistenciaCodigoBarrasProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR12) Erro ao Realizar Busca de Existencia Codigo de Barras do Produto \n\nErro: {_e}", "Erro Busca Existencia Codigo de Barras Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroProdutoPorCodigoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR13) Erro ao Realizar Busca de Cadastro do Produto Por Codigo \n\nErro: {_e}", "Erro Busca Produto Por Codigo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroProdutoPorDescricaoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR14) Erro ao Realizar Busca de Cadastro do Produto Por Descricao \n\nErro: {_e}", "Erro Busca Produto Por Descricao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroProdutoPorGrupoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR15) Erro ao Realizar Busca de Cadastro do Produto Por Grupo \n\nErro: {_e}", "Erro Busca Produto Por Grupo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroProdutoPorSubGrupoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR16) Erro ao Realizar Busca de Cadastro do Produto Por Sub-Grupo \n\nErro: {_e}", "Erro Busca Produto Por Sub-Grupo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroProdutoPorMarcaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR17) Erro ao Realizar Busca de Cadastro do Produto Por Marca \n\nErro: {_e}", "Erro Busca Produto Por Marca!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaEstoqueProdutoPorCodidoBarrasNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR18) Erro ao Realizar Busca de Lista do Estoque de Produto \n\nErro: {_e}", "Erro Busca de Lista do Estoque de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCodigoBarrasDoMesmoProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR19) Erro ao Realizar Busca do Codigo de Barras do mesmo Produto no Estoque de Produto \n\nErro: {_e}", "Erro Busca do Codigo de Barras do mesmo Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCodigoBarrasProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR20) Erro ao Realizar Busca Codigo de Barras \n\nErro: {_e}", "Erro Busca Realizar Busca Codigo de Barras!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Produto

        #region Empresa

        public void ErroAoBuscarEmpresaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-EM01) Erro ao Realizar Busca de Cadastro da Empresa \n\nErro: {_e}", "Erro Busca Cadastro Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarImagemEmpresaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-EM02) Erro ao Realizar Busca de Imagem da Emrpesa \n\nErro: {_e}", "Erro Busca Imagem Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarQRCodeNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-EM03) Erro ao Realizar Busca de QR Code Pix da Emrpesa \n\nErro: {_e}", "Erro Busca QR Code Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Empresa

        #region Cadastro Despesa Custo

        public void ErroAoBuscarCodigoDespesaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE01) Erro ao Realizar Busca de Cadastro de Despesa \n\nErro: {_e}", "Erro Busca Cadastro Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroDespesaPorCodigoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE02) Erro ao Realizar Busca de Despesa Por Codigo \n\nErro: {_e}", "Erro Busca Despesa Por Codigo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroDespesaPorDescricaoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE03) Erro ao Realizar Busca de Despesa Por Descricao \n\nErro: {_e}", "Erro Busca Despesa Por Descricao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroDespesaPorTipoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE04) Erro ao Realizar Busca de Despesa Por Tipo \n\nErro: {_e}", "Erro Busca Despesa Por Tipo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCadastroTudoDespesa(Exception _e)
        {
            MessageBox.Show($"(BUS-DE05) Erro ao Realizar Busca de Despesa \n\nErro: {_e}", "Erro Busca Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaDespesa(Exception _e)
        {
            MessageBox.Show($"(BUS-DE06) Erro ao Realizar Busca Lista de Despesa \n\nErro: {_e}", "Erro Busca Lista Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Despesa Custo

        #region Usuairo

        public void ErroAoBuscarUsuarioNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-US01) Erro ao Realizar Busca de Usuario \n\nErro: {_e}", "Erro Busca Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Usuairo

        #region Estoque Produto

        public void ErroAoBuscarEstoqueProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-EP01) Erro ao Realizar Busca do Estoque Produto \n\nErro: {_e}", "Erro Busca Estoque Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaEstoqueProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-EP02) Erro ao Realizar Busca da Lista de Estoque Produto \n\nErro: {_e}", "Erro Busca Lista Estoque Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarTotalEstoqueProdutoMesmaNFEntradaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-EP03) Erro ao Realizar Busca da Quantidade Total no Estoque Com a Mesma Nota Fiscal Entrada \n\nErro: {_e}", "Erro Busca Quantidade Total no Estoque Com a Mesma Nota Fiscal Entrada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Estoque Produto

        #region Compras

        public void ErroAoBuscarNotaFiscalEntradaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-NE01) Erro ao Realizar Busca de Nota Fiscal Entrada \n\nErro: {_e}", "Erro Busca Nota Fiscal Entrada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarValorTotalNotaFiscalEntradaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-NE02) Erro ao Realizar Busca de Valor Total da Nota Fiscal Entrada \n\nErro: {_e}", "Erro Busca Valor Total Nota Fiscal Entrada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarTotalNotaFiscalEntradaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-NE03) Erro ao Realizar Busca da Quantidade Total da Nota Fiscal Entrada \n\nErro: {_e}", "Erro Busca Quantidade Total Nota Fiscal Entrada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Compras

        #region Gerar Carne

        public void ErroAoBuscarListaCarneProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-GC01) Erro ao Realizar Busca de Dados do Carne \n\nErro: {_e}", "Erro Busca Dados Carne!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarSaldoClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-GC02) Erro ao Realizar Busca de Dados de Cliente para Gerar Carne \n\nErro: {_e}", "Erro Busca Dados de Cliente para Gerar Carne!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Gerar Carne

        #region Pesquisar Despesa

        public void ErroAoBuscarDespesaPorCodigoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE01) Erro ao Realizar Busca de Despesa Por Codigo \n\nErro: {_e}", "Erro Busca Despesa Por Codigo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaPorTipoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE02) Erro ao Realizar Busca de Despesa Por Tipo \n\nErro: {_e}", "Erro Busca Despesa Por Tipo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaPorTituloNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE03) Erro ao Realizar Busca de Despesa Por Titulo \n\nErro: {_e}", "Erro Busca Despesa Por Titulo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaPorDescricaoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE04) Erro ao Realizar Busca de Despesa Por Descricao \n\nErro: {_e}", "Erro Busca Despesa Por Descricao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE05) Erro ao Realizar Busca de Despesa \n\nErro: {_e}", "Erro Busca Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCodigoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE06) Erro ao Realizar Busca de Codigo de Despesa \n\nErro: {_e}", "Erro Busca Codigo Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaDespesaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE07) Erro ao Realizar Busca de Lista de Despesa \n\nErro: {_e}", "Erro Busca Lista Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoPorDescricaoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE08) Erro ao Realizar Busca de Despesa e Custo Por Descricao \n\nErro: {_e}", "Erro Busca Despesa e Custos Por Descricao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoPorCodigoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE09) Erro ao Realizar Busca de Despesa e Custo Por Codigo \n\nErro: {_e}", "Erro Busca Despesa e Custo Por Codigo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoPorTituloNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE10) Erro ao Realizar Busca de Despesa e Custo Por Titulo \n\nErro: {_e}", "Erro Busca Despesa e Custo Por Titulo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaTituloDespesaCustoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE11) Erro ao Realizar Busca de Lista Para Titulo de Despesa e Custo \n\nErro: {_e}", "Erro Busca de Lista Titulo Despesa e Custo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoStatusPagamentoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE12) Erro ao Realizar Busca de Despesa e Custo Por Status de Pagamento \n\nErro: {_e}", "Erro Busca Despesa e Custo Por Status Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoStatusNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE13) Erro ao Realizar Busca de Despesa e Custo \n\nErro: {_e}", "Erro Busca Despesa e Custo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoValorPagoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE14) Erro ao Realizar Busca de Despesa e Custo Valores Pagos \n\nErro: {_e}", "Erro Busca Despesa e Custo Valores Pagos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoValorPagoTotalNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE15) Erro ao Realizar Busca de Despesa e Custo Valores Total Pagos \n\nErro: {_e}", "Erro Busca Despesa e Custo Valores Total Pagos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoValorNaoPagoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE16) Erro ao Realizar Busca de Despesa e Custo Valores Não Pagos \n\nErro: {_e}", "Erro Busca Despesa e Custo Valores Não Pagos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoVencidasNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE17) Erro ao Realizar Busca de Despesa e Custo Contas Vencidas \n\nErro: {_e}", "Erro Busca Despesa e Custo Contas Vencidas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoFixaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE18) Erro ao Realizar Busca de Despesa e Custo Fixa \n\nErro: {_e}", "Erro Busca Despesa e Custo Fixa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoPorCodigoStatusPagamentoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE19) Erro ao Realizar Busca de Despesa e Custo Por Codigo e Status do Pagamento \n\nErro: {_e}", "Erro Busca Despesa e Custo Por Codigo e Status do Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoPorTituloStatusPagamentoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE20) Erro ao Realizar Busca de Despesa e Custo Por Titulo e Status de Pagamento \n\nErro: {_e}", "Erro Busca Despesa e Custo Por Titulo e Status de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarDespesaCustoPorDescricaoStatusPagamentoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-DE21) Erro ao Realizar Busca de Despesa e Custo Por Descricao e Status de Pagamento \n\nErro: {_e}", "Erro Busca Despesa e Custos Por Descricao e Status de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Pesquisar Despesa

        #region Buscar Cliente Tela PDV

        public void ErroAoBuscarClientePorCPFTelaPDVNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PDV01) Erro ao Realizar Busca Cliente Por CPF \n\nErro: {_e}", "Erro Busca Cliente Por CPF!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarProdutoPorCodigoTelaPDVNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PDV02) Erro ao Realizar Busca Produto Por Codigo \n\nErro: {_e}", "Erro Busca Produto Por Codigo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Buscar Cliente Tela PDV

        #region Buscar Nota Fiscal Saida

        public void ErroAoBuscarNotaFiscalSaidaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-NFSV01) Erro ao Realizar Busca Nota Fiscal Saida \n\nErro: {_e}", "Erro Busca Nota Fiscal Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaNotaFiscalSaidaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-NFSV02) Erro ao Realizar Busca Lista Nota Fiscal Saida \n\nErro: {_e}", "Erro Busca Lista Nota Fiscal Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaPermissoesNotaFiscalSaidaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-NFSV03) Erro ao Realizar Busca Lista de Permissões Nota Fiscal Saida \n\nErro: {_e}", "Erro Busca Lista de Permissões Nota Fiscal Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaPermissoesNotaFiscalSaidaCompetaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-NFSV04) Erro ao Realizar Busca Lista de Permissões Nota Fiscal Saida Completa \n\nErro: {_e}", "Erro Busca Lista de Permissões Nota Fiscal Saida Completa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Buscar Nota Fiscal Saida

        #region Buscar Contas A Receber

        public void ErroAoBuscarCarnePorNumeroNotaFiscalSaidaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CE01) Erro ao Realizar Busca Carnê Por Nota Fiscal Saida \n\nErro: {_e}", "Erro Busca Carnê Por Nota Fiscal Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCarnePorCPFCNPJNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CE02) Erro ao Realizar Busca Carnê Por CPF/CNPJ \n\nErro: {_e}", "Erro Busca Carnê Por CPF/CNPJ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCarnePorNomeClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CE03) Erro ao Realizar Busca Carnê Por Nome Cliente \n\nErro: {_e}", "Erro Busca Carnê Por Nome Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCarnePorStatusPagamentoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CE04) Erro ao Realizar Busca Carnê Por Status Pagamento \n\nErro: {_e}", "Erro Busca Carnê Por Status Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCarnePorNumeroNotaFiscalSaidaComStatusPagamentoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CE05) Erro ao Realizar Busca Carnê Por Nota Fiscal Saida e Status Pagamento \n\nErro: {_e}", "Erro Busca Carnê Por Nota Fiscal Saida e Status Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCarnePorCPFCNPJComStatusPagamentoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CE06) Erro ao Realizar Busca Carnê Por CPF/CNPJ e Status Pagamento \n\nErro: {_e}", "Erro Busca Carnê Por CPF/CNPJ e Status Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCarnePorNomeClienteComStatusPagamentoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CE07) Erro ao Realizar Busca Carnê Por Nome Cliente e Status Pagamento \n\nErro: {_e}", "Erro Busca Carnê Por Nome Cliente e Status Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCarneBuscaCompletaNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CE08) Erro ao Realizar Busca Carnê Busca Completa \n\nErro: {_e}", "Erro Busca Carnê Bucsar Completa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Buscar Contas A Receber

        #region Consultar Estoque Produto

        public void ErroAoBuscarDescricaoUnidadeEstoqueProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CEP01) Erro ao Realizar Busca Descrição e Unidade na Consulta do Estoque e Produto \n\nErro: {_e}", "Erro Busca Descrição e Unidade na Consulta de Estoque de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarQuantidadeLiberadaEstoqueProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CEP02) Erro ao Realizar Busca Quantidade Liberada Estoque e Produto \n\nErro: {_e}", "Erro Busca Quantidade Liberada Estoque de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarQuantidadeRejeitadaEstoqueProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CEP03) Erro ao Realizar Busca Quantidade Rejeitada Estoque e Produto \n\nErro: {_e}", "Erro Busca Quantidade Rejeitada Estoque de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarQuantidadeEmTransitoEstoqueProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CEP04) Erro ao Realizar Busca Quantidade Em Transito Estoque e Produto \n\nErro: {_e}", "Erro Busca Quantidade Em Transito Estoque de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarQuantidadeEmTerceirosEstoqueProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CEP05) Erro ao Realizar Busca Quantidade Em Terceiros Estoque e Produto \n\nErro: {_e}", "Erro Busca Quantidade Em Terceiros Estoque de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarCompletaEstoqueProdutoPorCodigoProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CEP06) Erro ao Realizar Busca Completa em Estoque e Produto Por Codigo de Produto \n\nErro: {_e}", "Erro Busca Completa em Estoque de Produto Por Codigo de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Consultar Estoque Produto

        #endregion Buscar No Banco

        #region Verificar Existencia No Banco

        #region Cliente

        public void ErroAoVerificarExistenciaDeClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXI-CL01) Erro ao Verificar Existencia de Cliente \n\nErro: {_e}", "Erro Verificar Existencia de Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cliente

        #region Fornecedor

        public void ErroAoVerificarExistenciaDeFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXI-FN01) Erro ao Verificar Existencia de Fornecedor \n\nErro: {_e}", "Erro Verificar Existencia de Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Fornecedor

        #region Produto

        public void ErroAoVerificarExistenciaDeProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXI-PR01) Erro ao Verificar Existencia de Produto \n\nErro: {_e}", "Erro Verificar Existencia de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Produto

        #region Usuario

        public void ErroAoVerificarExistenciaDeUsuarioNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXI-US01) Erro ao Verificar Existencia de Usuario \n\nErro: {_e}", "Erro Verificar Existencia de Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Usuario

        #region Estoque Produto

        public void ErroAoVerificarSeEstoqueFoiConsumidoNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXI-EP01) Erro ao Verificar Se Estoque Foi Consumido \n\nErro: {_e}", "Erro Verificar Se Estoque Consumido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Estoque Produto

        #endregion Verificar Existencia No Banco

        #region Configuracao Gerencial

        public void ErroAoAtualizarDescontoPorGrupoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-CG01) Erro ao Atualizar Desconto Por Grupo de Produto! \n\nErro: {_e}", "Erro Atualizacao Grupo Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarDescontoAvistaNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-CG02) Erro ao Atualizar Desconto Avista! \n\nErro: {_e}", "Erro Atualizacao Desconto Avista!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarJurosCarneNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-CG03) Erro ao Atualizar Juros Carne! \n\nErro: {_e}", "Erro Atualizacao Juros Carne!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarJurosCreditoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-CG04) Erro ao Atualizar Juros Credito! \n\nErro: {_e}", "Erro Atualizacao Juros Credito!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Configuracao Gerencial

        #endregion Banco

        #region Exportar Dados para o Excel

        public void ErroAoExportarDadosExcel(Exception _e)
        {
            MessageBox.Show($"(EDE-EX01) Erro ao Exportar Dados Para o Excel \n\nErro: {_e}", "Erro Exportar Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Exportar Dados para o Excel
    }
}