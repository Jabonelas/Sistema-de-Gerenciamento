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
            MessageBox.Show($"(BUS-EP01) Erro ao Buscar Estoque Produto \n\nErro: {_e}", "Erro Estoque Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Estoque Produto

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

        public void ErroAoAdicionarDespesaNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-DE01) Erro ao Inserir Despesa \n\nErro: {_e}", "Erro Inserir Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Despesa

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

        #region Despesa

        public void ErroAoAtualizarDespesaNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-DE01) Erro ao Atualizar Cadastro de Despesa \n\nErro: {_e}", "Erro Atualizacao Cadasto Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Despesa

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

        #region Despesa

        public void ErroAoExluirCadastroDespesaNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-DE01) Erro ao Excluir Despesa \n\nErro: {_e}", "Erro Excluir Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Despesa

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

        public void ErroAoBuscarCodigoClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL03) Erro ao Realizar Busca de Codigo do Cliente \n\nErro: {_e}", "Erro Busca Codigo Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-CL04) Erro ao Realizar Busca de Lista do Cliente \n\nErro: {_e}", "Erro Busca Lista Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void ErroAoBuscarCodigoFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-FN03) Erro ao Realizar Busca de Codigo do Fornecedor \n\nErro: {_e}", "Erro Busca Codigo Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarListaFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-FN04) Erro ao Realizar Busca dos Fornecedores \n\nErro: {_e}", "Erro Busca Fornecedores!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Fornecedor

        #region Produto

        public void ErroAoBuscarCodigoProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR03) Erro ao Realizar Busca de Codigo de Barras do Produto \n\nErro: {_e}", "Erro Busca Codigo de Barras Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarGrupoProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR04) Erro ao Realizar Busca de Grupo do Produto \n\nErro: {_e}", "Erro Busca Grupo Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarSubGrupoProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR04) Erro ao Realizar Busca de Sub-Grupo do Produto \n\nErro: {_e}", "Erro Busca Sub-Grupo Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR05) Erro ao Realizar Busca do Produto \n\nErro: {_e}", "Erro Busca Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarImagemProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR06) Erro ao Realizar Busca de Imagem do Produto \n\nErro: {_e}", "Erro Busca Imagem Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion Empresa

        #region Despesa

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

        #endregion Despesa

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

        #endregion Estoque Produto

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
            MessageBox.Show($"(EXI-PR01) Erro ao Verificar Existencia de Usuario \n\nErro: {_e}", "Erro Verificar Existencia de Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Usuario

        #endregion Verificar Existencia No Banco

        #region Exportar Dados para o Excel

        public void ErroAoExportarDadosExecel(Exception _e)
        {
            MessageBox.Show($"(EDE-EX01) Erro ao Exportar Dados Para o Excel \n\nErro: {_e}", "Erro Exportar Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Exportar Dados para o Excel
    }
}