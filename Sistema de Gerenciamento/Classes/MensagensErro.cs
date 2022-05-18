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

        #endregion Cadastro Empresa

        #region Inserir No Banco

        public void ErroAoAdicionarClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-CL01) Erro ao Inserir Cadastro Cliente \n\nErro: {_e}", "Erro Inserir Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarImagemClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-CL02) Erro ao Inserir Imagem No Cadastro Cliente \n\nErro: {_e}", "Erro Inserir Imagem Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-FN01) Erro ao Inserir Cadastro Fornecedor \n\nErro: {_e}", "Erro Inserir Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarImagemFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-FN02) Erro ao Inserir Imagem No Cadastro Fornecedor \n\nErro: {_e}", "Erro Inserir Imagem Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-PR01) Erro ao Inserir Cadastro Produto \n\nErro: {_e}", "Erro Inserir Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarImagemProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-PR02) Erro ao Inserir Imagem No Cadastro Produto \n\nErro: {_e}", "Erro Inserir Imagem Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarGrupoMaterialNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-GR01) Erro ao Inserir Grupo de Material \n\nErro: {_e}", "Erro Inserir Grupo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAdicionarEmpresaNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-EM01) Erro ao Inserir Empresa \n\nErro: {_e}", "Erro Inserir Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Inserir No Banco

        #region Atualizacao Do Banco

        public void ErroAoAtualizarClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-CL01) Erro ao Atualizar Cadastro de Cliente \n\nErro: {_e}", "Erro Atualizacao Cadastro Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarImagemClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-CL02) Erro ao Atualizar Imagem do Cliente \n\nErro: {_e}", "Erro Atualizacao Imagem Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-FN01) Erro ao Atualizar Cadastro de Fornecedor \n\nErro: {_e}", "Erro Atualizacao Cadastro Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarImagemFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-FN02) Erro ao Atualizar Imagem do Fornecedor \n\nErro: {_e}", "Erro Atualizacao Imagem Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-PR01) Erro ao Atualizar Cadastro de Produto \n\nErro: {_e}", "Erro Atualizacao Cadastro Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoAtualizarImagemProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-PR02) Erro ao Atualizar Imagem do Produto \n\nErro: {_e}", "Erro Atualizacao Imagem Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Atualizacao Do Banco

        #region Excluir No Banco

        public void ErroAoExluirCadastroClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-CL01) Erro ao Excluir Cadastro Cliente \n\nErro: {_e}", "Erro Excluir Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirImagemClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-CL02) Erro ao Excluir Imagem Cliente \n\nErro: {_e}", "Erro Excluir Imagem Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirCadastroFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-FN01) Erro ao Excluir Cadastro Fornecedor \n\nErro: {_e}", "Erro Excluir Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirImagemFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-FN02) Erro ao Excluir Imagem Fornecedor \n\nErro: {_e}", "Erro Excluir Imagem Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirCadastroProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-PR01) Erro ao Excluir Cadastro Produto \n\nErro: {_e}", "Erro Excluir Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirImagemProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-PR02) Erro ao Excluir Imagem Produto \n\nErro: {_e}", "Erro Excluir Imagem Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoExluirCadastroGrupoMaterialNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXC-GR02) Erro ao Excluir Grupo Material \n\nErro: {_e}", "Erro Excluir Grupo Materail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Excluir No Banco

        #region Buscar No Banco

        //Cliente
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

        //Fornecedor
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

        //Produto
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

        #endregion Buscar No Banco

        #region Verificar Existencia No Banco

        public void ErroAoVerificarExistenciaDeClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXI-CL01) Erro ao Verificar Existencia de Cliente \n\nErro: {_e}", "Erro Verificar Existencia de Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoVerificarExistenciaDeFornecedorNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXI-FN01) Erro ao Verificar Existencia de Fornecedor \n\nErro: {_e}", "Erro Verificar Existencia de Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoVerificarExistenciaDeProdutoNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXI-PR01) Erro ao Verificar Existencia de Produto \n\nErro: {_e}", "Erro Verificar Existencia de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoVerificarExistenciaEmpresaNoBanco(Exception _e)
        {
            MessageBox.Show($"(EXI-EM01) Erro ao Verificar Existencia de Empresa \n\nErro: {_e}", "Erro Verificar Existencia de Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Verificar Existencia No Banco

        #region Exportar Dados para o Excel

        public void ErroAoExportarDadosExecel(Exception _e)
        {
            MessageBox.Show($"(EDE-EX01) Erro ao Exportar Dados Para o Excel \n\nErro: {_e}", "Erro Exportar Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Exportar Dados para o Excel
    }
}