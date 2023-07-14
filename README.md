# Testes-Sky.One

  Solução dos testes de .Net para o processo seletivo de Sky.One

# SOBRE O CONTEÚDO DO REPOSITÓRIO

  A Primeira pasta, "Teste SkyOne 1-3" contém o código da Console Application dos testes 1-2-3.
  A Segunda contém um Windows forms com dois formulários para os testes 4-5-6-7-8-9-10, junto do script 
  sql para a criação da tabela usada no projeto.

 # PRIMEIRA PASTA:
    
  Ao iniciar esta aplicação, é possível notar que os testes estão separados por 3 funções que os usuários podem escolher qual usar.
  A 1ª função realiza um cálculo de média de duas notas.
  A 2ª função realiza um cálculo de média para uma quantia x de provas, das quais cada nota são inseridas pelo usuário.
  A 3ª função permite a inserção das notas individuais de múltiplos alunos, retornando o resultado de suas médias,  junto a informação de aprovado ou reprovado. é possível inserir as informações de diversos alunos e terminar a execução do Programa digitando "fim".

 # SEGUNDA PASTA:
  
  Esta é mais complexa, pois trata-se de uma aplicação de Windows Forms junto de um banco de dados.
  O primeiro Form, (solução do teste 4) é uma página de Login para professor, nela é possível inserir Login e senha para acessar o formulário 
  do teste 5. É válido ressaltar que é possível seguir para o Forms seguinte se e somente se ambas as caixas de texto 
  estiverem preenchidas.
    A solução do teste 5 é a mais complexa, pois esta engloba a solução dos testes 6, 7 e 10.
  Trata-se de um formulário de inserção de notas de alunos, onde existe um botão que apaga as informações nas caixas de texto
  (que também é imperativo que estejam preenchidas para o envio dos dados), e um de inserção das informações nas caixas de texto
  no banco de dados, funcionalidade do teste 7.
    Para o funcionamento deste formulário, a necessidade da criação de um banco de dados (teste 6), foi muito alta. 
    O mesmo foi construído com SQL Server, que tem como intuito, salvar as informações, como solicitado do teste 10.
    Para a construção deste foi necessário seguir o seguinte caminho: ``gerenciador de servidores -> (depois de clicar com o botão direito) 
    Adicionar conexão -> escolher o nome da conexão -> (Botão direito em tabelas) adicionar tabela -> usar o script sql no arquivo dbo.table.sql 
    para a criação da tabela -> em propriedades da conexão, copiar a "Cadeia de conexão". -> adicionar à variável "String connectionString" em "paginateste5.cs"   
    `` 

  # TESTES 5, 7 E 10: 
  
  ![aluno aprovado](https://github.com/LeoACF/Testes-Sky.One/assets/70867390/8b4375be-7d5b-4e9c-8947-b38f3cff2897)
  
  ![aluno reprovado](https://github.com/LeoACF/Testes-Sky.One/assets/70867390/a836a763-1459-4a41-aa22-f0a5e59e0a94)
  
  Nestas imagens é possível ver a inserção de um aluno aprovado e um reprovado, demonstrando assim a inserção de informações no banco para o
  teste7.

  # TESTES 8 E 9:
  Para as consultas realizadas no banco foi necessário clicar com o botão direito do mouse na tabela "Alunos" e selecionar "realizar uma consulta".
  Nesta aba, foram utilizados os códigos apresentados nas legendas das imagens abaixo.
  
  ![teste 8](https://github.com/LeoACF/Testes-Sky.One/assets/70867390/dcefa746-c421-4f0c-89cd-c2e09416308b)
  
  Teste8: consultar os alunos com notas menores ou iguais à 6,5 (portanto reprovados).
  
  SQL:``SELECT * FROM [dbo].[Alunos-Notas] WHERE [Media_Anual] <= 6.5;``

  ![teste 9](https://github.com/LeoACF/Testes-Sky.One/assets/70867390/11876ff0-42e1-4857-88e0-2e00bdff5f6b)

  Teste9: consultar os alunos com notas maiores que 6 (portanto aprovados).
  
  SQL:``SELECT * FROM [dbo].[Alunos-Notas] WHERE [Media_Anual] > 6;``
  
  ![modificação do banco](https://github.com/LeoACF/Testes-Sky.One/assets/70867390/678b6aef-5094-4435-9743-8508ac6df877)
  
  Aqui são demonstrados os dados sendo armazenados no banco.

