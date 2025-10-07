Modelo de PDV
=

Modelo de PDV para controle de estoque e vendas.

Como iniciar o projeto:
=

Inicie o migrations: **dotnet-ef migrations add IniciarBancoSqlite**

Atualize as tabelas do banco: **dotnet-ef database update**

O que você pode fazer:
=

De antemão, insira Saldo para seu usuário com o script abaixo:

**INSERT INTO Gestao (NomeGestor, Saldo, Lucro, Gasto, NumVendas) VALUES ('SEU_NOME', 100, 0, 0);**

Após isso inicie o projeto no terminal com: **dotnet run**.

Você será apresentado com um menu de opções:

 - Vender Produto      
 - Comprar Produto     
 - Estoque             
 - Gestão Financeira   
 - Adicionar Produto

Guia
=
~**[Inicie adicionando um produto para o PDV]**~
   
Em "**Adicionar Produto**" você pode inserir o nome do produto, o custo de mercado dele e o preço que irá definir para vender.

Em **Comprar Produto** você pode adicionar o produto ao seu estoque para vendas

Em **Vender Produto** você pode selecionar o produto a ser vendido, acarretando em aumento de saldo e diminuição da quantidade do produto em estoque

Em **Estoque** você pode verificar os valores de custo e venda dos produtos e a quantidade que ainda possui em seu estoque

Em **Gestão Financeira** você pode verificar seus gastos, saldo, numero de vendas e lucro [***Ainda em Desenvolvimento]
