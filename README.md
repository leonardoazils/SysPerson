# SysPerson
Sistema para controle de pessoa física e júridica

- Foi utilizado um template baseado em Material Design para montar a aplicação proposta, composto por um conjunto de partials views (Footer, Header, Menu e Body).
Deixei a implementação do template mais "enxuta" possível para que não houvesse complexidade desnecessária na execução do desafio.
- Utilizei para componente de grid (lista de fornecedores) o datatable: https://datatables.net/.
- Utilizado Bootstrap 4 conforme solicitado no desafio.
- Utilizado banco de dados SQL Server acoplado a aplicação para que fique simples de executar localmente quando forem avaliarem.
- Utilizado Entity Framework 6 como ORM para conexão com o banco de dados.
- Para criação da estrutura de banco foi utilizado Migrations, o mesmo foi habilitado no projeto SysPerson.Repository.
- Utilizado FluentValidation para validar as informações preenchidas pelo usuário.
- Utilizado Razor pages.
- Utilizado JQuery.

Estrutura do Projeto:

- SysPerson.App: Projeto principal, utilizando ASP.NET MVC 5 onde tenho o controller, view e modelos de tela.
- SysPerson.Framework: Projeto no formato Biblioteca de Classes que contêm arquivos auxiliares no desenvolvimento da aplicação como por exemplo enumeradores, 
                       extensões entre outros.
- SysPerson.Domain: Projeto no formato Biblioteca de Classes que abrange as entidades do sistema e interfaces de apoio as mesmas.
- SysPerson.Service: Projeto no formato Biblioteca de Classes que tem como objetivo armazenar as regras de negócio pertinentes a cada tela do sistema.
- SysPerson.Repository: Projeto no formato Biblioteca de Classes que faz o papel de camada para ligação da aplicação com o banco de dados. 

Utilizei essa estrutura de projeto pois acredito que as responsabilidades ficam bem separadas facilitando para quem está programando, neste caso o desafio possuí apenas
um cadastro o que deixa os projetos sem muita implementação, mas eu quis mostrar como fica mais fácil escalar caso fosse ter novas funcionalidades.

Foi criado uma pasta chamada "Seeders" dentro do projeto "SysPerson.Framework" e lá coloquei classes que emulam as tabelas auxiliares do cadastro de pessoa.
O conceito desse nome no Migration seria para criar tabelas já com dados carregados por padrão, mas optei por usar a mesma nomenclatura nesse caso para facilitar o entendimento.

OBS: Não é necessário fazer o download de nenhuma biblioteca para compilar a aplicação pois os arquivos javascript e css estão adicionados na mesma.

Para utilizar a aplicação basta realizar o download dos fontes (clone) e abrir a solução no Visual Studio. O banco de dados está ligado ao projeto portanto já está
criado.

Caso queira rodar um novo Migration ou o banco de dados não foi criado por algum motivo basta seguir o seguinte passo a passo:

- Vá para o menu superior e abra: Exibir / Outras Janelas / Console do Gerenciador de Pacotes.
- Na janela que irá abrir selecione o projeto SysPerson.Repository.
- Digite o comando Add-Migration <nome-do-migration>.
- Quando o processo for concluído digite: Update-Database.
  
  
