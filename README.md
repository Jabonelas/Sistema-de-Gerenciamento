# Sistema-de-Gerenciamento
Sistema de Gerenciamento - C# - SQL Server



Sistema de gerenciamento de faturamento, clientes, fornecedores,  estoque e controle financeiro com diferentes níveis de acessos.


 
 -  Todos os campos de endereço são preenchidos automáticos com buscar pelo CEP.

 - Todos os campos de CPF/CNPJ possuem validação para verificar se o CPF/CNPJ inserido é valido.

 -  Todos os campos de datas possuem validação para verificar se a data inserida é válida e não é um fim de semana ou feriado nacional.

 -  Todos os campos de e-mail possuem validação para verificar se o e-mail inserido é valido.

**

## Acessado apenas pelo ADMIN

**

Alerta Inicial informando sobre contas (Despesas e Custos) atrasadas exibindo seus dados e verificação de estoque baixo para produtos que estão com estoque mínimo (setados pelos ADMIN no Cadastro do produto) esta verificação ocorre a cada 20h se o sistema não for interrompido ou a cada momento em que o ADMIN logar.

![enter image description here](https://i.imgur.com/6Zo2AbE.gif)

**Configurações Gerenciais:**

- [x] Juros Por Pagamento a Credito: porcentagem de juros no pagamento por credito e quantidade de parcelas a gerar juros

- [x] Comissão Por Produto: porcentagem da comissão geral

- [x] Desconto Por Pagamento Avista: porcentagem de desconto com pagamento avista e debito

- [x] Desconto Por Grupo e Sub-Grupo de Produtos: porcentagem de desconto setado por Grupo e Sub-grupo

- [x] Gerenciamento Pagamento Carnê: porcentagem dos juros por quantidade de parcelas, porcentagem dos juros por parcela, por pagamento atrasado, prazo para 1ª parcela, porcentagem da multa por atraso de pagamento, quantidade de parcelas a gerar juros.

![enter image description here](https://i.imgur.com/JhnKi22.gif)

**Cadastro Empresa:**

- [x] Cadastro dos Dados da Empresa e logo.

- [x] Cadastro de chave Pix e dados gerando QRCode.

- [x] Atualização de dados.

![enter image description here](https://i.imgur.com/b8BiKxr.gif)

**Cadastro Usuário:**

- [x] Cadastro de usuário e senha sendo possível adicionar permissões para excluir itens na tela de venda, acesso a tela de troca de produto, cancelar vendas e cancelar pagamento.

- [x] Atualização de dados.

![!\[enter image description here\](https://imgur.com/JuoqYc0](https://i.imgur.com/JuoqYc0.gif)

**Cadastro Produto:**

- [x] Cadastro de Produtos, com grupo e sub-grupo, imagem do produto, valor de custo, porcentagem de lucro e exibição automática do valor de venda e valor do lucro.

- [x] Atualização de dados de cadastro de produto.

- [x] #1 - Buscar Produtos Cadastrados por código, descrição, grupo e sub-grupo ou marca. Podendo imprimir os resultados ou exportar os dados para o Excel.

- [x] Deletar Cadastro do Produto.

![enter image description here](https://i.imgur.com/BiwP4nD.gif)

- #1 - Buscar Produto

![enter image description here](https://i.imgur.com/iRVqTHO.gif)


**Cadastro Grupo de Material:**

- [x] Cadastro de Grupo e Sub-Grupo.

- [x] Deletar Cadastro de Grupo e Sub-Grupo.

![enter image description here](https://i.imgur.com/OcmRvQO.gif)

**Cadastro Fornecedor:**

- [x] Cadastro do Fornecedor e imagem do logo fornecedor.

- [x] Atualização de dados de cadastro do Fornecedor.

- [x] #2 - Buscar Fornecedores Cadastrados por código, CNPJ ou nome fantasia.  Podendo imprimir os resultados ou exportar os dados para o Excel.

- [x] Deletar Cadastro do Fornecedor.

![enter image description here](https://i.imgur.com/tqhKVLX.gif)

- #2 - Buscar Fornecedores

![enter image description here](https://i.imgur.com/xcXi1wc.gif)

**Cadastro Cliente:**

- [x] Cadastro do Cliente e imagem do Cliente.

- [x] Atualização de dados de cadastro do Cliente.

- [x] #3 - Buscar Clientes Cadastrados por código, nome, por CPF/CPNJ ou RG.  Podendo imprimir os resultados ou exportar os dados para o Excel.

- [x] Deletar Cadastro do Cliente.

![enter image description here](https://i.imgur.com/ols4r0W.gif)


- #3 - Buscar Clientes 

![enter image description here](https://i.imgur.com/yUT3eg9.gif)

**Cadastro de Despesa/Custos:**

- [x] Cadastro de despesas e custos por título e tipo de despesa.

![enter image description here](https://i.imgur.com/WFSPnnj.gif)

**Compras:**

- [x] Entrada nota fiscal, ao inserir nota fiscal é possível cadastrar o código de barras e inserir em contas a pagar informando a data de pagamento e quantas vezes foi parcelado.
- Ao dar entrada na NF exibe mensagem questionando ao usuário se deseja cadastra em a NF despesas, caso deseje poderá o usuário deve adicionar os dados como ex: a data de vencimento e em quantas vezes foi parcelada. .

- [x] Feita a verificação em 4 fatores:
- 1º verifica se a NF já foi dada entrada.
- 2º verifica se o fornecedor possui cadastro. 
- 3º verifica se os produtos possuem cadastro. 
- 4º verifica se os preços unitários do produto estão iguais ao preço unitário cadastrado.

- [x] Deletar nota fiscal, caso o saldo não tenha sofrido alteração.

- [x] #4 - Atualizar Códigos de barras, caso o saldo não tenha sofrido alteração.

![enter image description here](https://i.imgur.com/QJuQ5Ay.gif)

- #4 - Atualizar Códigos de barras

![enter image description here](https://i.imgur.com/iKHSAs4.gif)

**Controle de Despesas:**

- [x] Cadastro de despesa fixa e variável com data de vencimento, frequência e valor.

- [x] Buscar cadastro das despesas por código, tipo, título e descrição. Podendo imprimir os resultados ou exportar os dados para o Excel.

- [x] Atualização de dados de cadastro de despesa.

- [x] Deletar Cadastro de despesa.

![enter image description here](https://i.imgur.com/gdfqPKB.gif)


- Buscar cadastro das despesas

![enter image description here](https://i.imgur.com/ozuutBX.gif)


**Contas a Pagar:**

- [x] Buscar contas a pagar por código, categoria tipo e título, descrição, e status do pagamento todas as buscas definidas por data.

- [x] Informa em R$ os valores das contas pagas, contas a pagar, contas vencidas, total de contas pagas, quantidade de contas encontradas na pesquisa, sendo possível marcas as linhas do GridView e mostra quantidade de contas listadas, total em R$ das contas listadas.

- [x] #5- Ao Selecionar conta inicia a tela de editar pagamento onde mostra todos os dados da conta como ex: tipo de despesa, título, descrição, quantidade de parcelas, CNPJ, data de emissão, data de vencimento, valor da parcela e valor total. Caso deseje confirmar de pagamento sendo possível indicar caso possua, incluir as porcentagens de desconto e de juros sendo calculado automaticamente e exibindo o total valor a ser pago.

- [x] Podendo imprimir os resultados ou exportar os dados para o Excel.

![enter image description here](https://i.imgur.com/qjiWkkA.gif)

- #5- Tela Editar Pagamento

![enter image description here](https://i.imgur.com/r6jZpNN.gif)

**Lançar contas a pagar:**

- [x] Cadastro de custos fixo e variável com data de vencimento, frequência e valor.

- [x] #6 - Buscar cadastro dos custos por código, tipo, título e descrição. Podendo imprimir os resultados ou exportar os dados para o Excel.

- [x] Atualização de dados de cadastro de custos.

- [x] Deletar Cadastro dos custos.

![enter image description here](https://i.imgur.com/gAAc0zB.gif)


- #6 - Buscar cadastro dos custos

![enter image description here](https://i.imgur.com/QaHSb3X.gif)



**Contas a Receber:**

- [x] Buscar contas a receber por nº da NF, tipo e CPF/CPNJ, nome cliente e status do pagamento todas as buscas definidas por data.

- [x] #7 - Ao Selecionar conta inicia a tela de pagamento a receber onde mostra todos os dados da como ex: nº NF, CPF/CNPJ, nome cliente, quantidade parcelas, data de emissão, data de vencimento, valor da parcela e valor total. Caso deseje confirmar o pagamento calculando automaticamente os valores dos juros e multa (setados pelos ADMIN na tela de Configurações Gerenciais) caso tenho passado da data de vencimento.

- [x] Podendo imprimir os resultados ou exportar os dados para o Excel.

![enter image description here](https://i.imgur.com/LYgIa8k.gif)


- #7 - Tela de Pagamento a Receber

![enter image description here](https://i.imgur.com/ygHPM7i.gif)


**Resumo Vendas:**

- [x] Buscar o resumo de vendas por data, devoluções, produtos mais vendidos, tipo de pagamento ou vendedor todas as buscas definidas por data.

- [x] Exibindo também a quantidade de produtos vendidos e o valor bruto total vendido ambas encontrados na busca.

![enter image description here](https://i.imgur.com/kCvEYgR.gif)

**Fluxo de Caixa:**

- [x] Buscar por nome do usuário cadastrado e definidas por data.

- [x] Exibindo também o valor total de vendas daquele usuário, sua comissão geral (setados pelos ADMIN na tela de Configurações Gerenciais), e sua comissão por produto (setados pelos ADMIN na tela de cadastro produto).

![enter image description here](https://i.imgur.com/1XQKbbk.gif)


**Estatísticas Financeiras:**

- [x] Exibe gráfico altamente customizável, com os valores brutos, líquidos, de produtos, de contas pagas, de contas a pagar e contas a receber, sendo possível definir datas para obtenção dos meses anteriores para possíveis comparações.

- [x] Podendo imprimir os resultados.

![enter image description here](https://i.imgur.com/Abk8KU2.gif)


## Acessado apenas pelo ADMIN ou usuários que possuem permissão

**Troca:**

- [x] Buscar por NF, exibi os dados de usuário que realizou a venda, validade da troca, nome do cliente e produtos contidos na NF.

- [x] Verifica se o código de barras do produto que está sendo devolvido realmente pertence a nota fiscal.

- [x] Ao selecionar o produto pelo código barras, acionar a quantidade a ser devolvida.

- [x] Selecionar o Produto que deseja realizar (Sendo possível acessar a tela de pesquisa de produtos #1) a troca e a sua quantidade exibira os valores total do produto devolvido e produto da troca e o valor da diferença entre os dois sendo necessário que seja informado o motivo da troca e só podendo realizar a troca caso a diferença seja 0 ou positiva, ao confirmar a troca irar iniciar a tela de pagamento.

![enter image description here](https://i.imgur.com/qGzydX4.gif)

## Acessado por todos os usuários


**Tela de Pagamento**


- [x] #8 - Possivel selecionar o tipo de pagamento:
-  Carnê ou Credito seleciona a quantidade de parcelas e exibe os valores de juros e valor total. 
- Dinheiro ou Debito informa o desconto (Calcula o desconto baseado com a porcentagem de desconto setada pelo ADMIN na tela de Configurações Gerenciais) inserir o valor recebido e exibe automaticamente o valor. 
- Pix informa o valor do desconto (Calcula o desconto baseado com a porcentagem de desconto setada pelo ADMIN na tela de Configurações Gerenciais) exibe a chave pix e o QRCode para pagamento.

![enter image description here](https://i.imgur.com/lCTIprf.gif)

**Venda:**



- Opção Venda:

- [x]  Buscar Clientes Cadastrados #3.
 
 - Acesso a Busca de clientes já cadastrados, informando seu código, e seu CPF/CNPJ.



- [x] Verificação de 2 fatores:
- 1º fator verifica se a nota fiscal informada consta no sistema.
- 2º fator verifica se o produto que está sendo devolvido pertence a nota fiscal informada, esta verificação e feita através do código de barras do produto.

- [x] Adição de produto por código de barras e quantidade desejada.

- [x] Exibição de valor total e quantidade total de itens na NF.

- [x] Cancelamento de venda e remoção de itens com verificação de permissão (verifica se o usuário possui autorização, caso seja negativo solicita que seja liberado pelo ADMIN) para execução de ação.

- [x] Acesso a tela de Gerar Carnê;

- [x] Acesso a tela de Pagamento.

![enter image description here](https://i.imgur.com/ypoRXtN.gif)

- Opção Orçamento:

- [x] Adição de produto por nome e quantidade desejada.

- [x] Exibição de valor total e quantidade de itens.

- [x] Opção para tipo de pagamento a vista calculando o desconto, e para pagamento por credito sendo possível colocar a quantidade de parcelas e calculando os seus juros.

![enter image description here](https://i.imgur.com/XarNx3u.gif)

**Pesquisar Cliente:**

- [x]  Buscar Clientes Cadastrados #3.

**Pesquisar Produto:**

- [x] Buscar Produtos Cadastrados #1.

**Tela de PDV:**

- [x] Mudança automática para exibição de Caixa Ocupado quando inicia a compra e para Caixa Disponível quando finaliza a compra.

- [x] Inserção de produto por código de barras, com exibição de imagem.

- [x] Exibição de descrição de produto, valor por unidade, valor total, desconto.

**Atalhos:**

- [x] F1: Nova Venda.

- [x] F2: Excluir item (verifica se o usuário possui autorização, caso seja negativo solicita que seja liberado pelo ADMIN)

- [x] F3: Inserir CPF. Busca Cadastro de cliente e exibe seu nome.

- [x] F4: Buscar Produto por código.

- [x] F5: Buscar Produtos Cadastrados por código, descrição, grupo e sub-grupo ou marca.

- [x] F6: Inserir Quantidade.

- [x] F7: Pagamento (Acesso a Tela de Pagamento #8).

- [x] F8: Cancela Venda (verifica se o usuário possui autorização, caso seja negativo solicita que seja liberado pelo ADMIN)

- [x] F9: Troca (verifica se o usuário possui autorização, caso seja negativo solicita que seja liberado pelo ADMIN).

- [x] Esc: Fechar Tela.

- [x] F10: Finaliza o pagamento. Caso o pagamento escolhido seja Carnê exibe a tela de Gerar Carnê.

- [x] F12: Cancela o Pagamento (verifica se o usuário possui autorização, caso seja negativo solicita que seja liberado pelo ADMIN).

![enter image description here](https://i.imgur.com/kYIYZXe.gif)

**Pesquisar Produto**

- [x] Buscar Produtos Cadastrados #1.


**Consultar Estoque:**

- [x] Buscar Produtos Cadastrados #1.

- [x] Buscar por Código de produto com exibição das quantidades liberadas, rejeitadas, em contagem (material aguardando cadastro código de barras acessivel na tela de Compras Alterar Codigo Barras #4),  tem terceiros (material que foi vendido), quantidade total no estoque, em trânsito (material que já foram emitidas nota fiscal no fornecedor).

- [x] Acesso a tela de Consulta estoque em contagem, exibindo nº da nota fiscal, data de emissão, quantidade e valor unitário.

- [x] Exibição de lotes com os seus códigos de barras, data de entrada, quantidade, e status caso o esteja rejeitado.

- [x] Acesso a tela de Consulta Detalhada Exibindo nº na nota fiscal, data de entrada, código de barras, código do produto, descrição do produto, quantidade, valor unitário, status, e caso esteja rejeitado o motivo do rejeito.

![enter image description here](https://i.imgur.com/uDxUoDQ.gif)




