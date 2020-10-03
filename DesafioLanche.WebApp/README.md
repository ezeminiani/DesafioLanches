# DesafioLanches
Desafio Prático Interaxa

Descrição das Camadas

; DesafioLanche.Business
: Camada com as regras de negócios.
; DesafioLanche.Domain
: Camada com as classes de domínio (entidades que representam as tabelas do banco de dados)
; DesafioLanche.DTO
: Camada com as classes de transferência. É utilizado como model para o projeto MVC e poderá ser usado futuramente numa API.
; DesafioLanche.Repository
: Camada de acesso ao banco de dados através do Entity Framework e migrações.
; DesafioLanche.WebApp
: Aplicação web MVC e projeto startup da solução.
; DesafioLanche.Tests
: Aplicação de teste unitário.

Sobre os entregáveis

Infelizmente não foi possível terminar a solução devido ao prazo (tempo). Procurei utilizar as melhores práticas para tornar o código 
reaproveitável em vários tipos de soluções como por exemplo projetos web, mobile, API ou serviços.
Tive algumas dificuldades para implementar a injeção de dependência no projeto MVC e acabou tomando tempo, mas funcionou! 
Em projetos .Net Core a injeção é nativa.

O que consegui implementar:

* Acesso a dados com Entity Framework com utilização do Linq e preparado para executar queries (scripts SQL e Stored Procedures).
* Classes de transferência de objetos (DTO) utilizando o Automapper.
* Utilização de padrão MVC no projeto Web com Bootstrap na versão mais recente 4.5 e Jquery

Para executar:

* Após baixar a solução, antes de executá-lo precisa processar a geração do banco de dados através das "Migrations" do Entity Framework.
No VisualStudio abrir o "Package Manager Console", selecionar na lista acima do console o projeto default "DesafioLanche.Repository" e executar o comando
"update-database". O Entity Framework irá gerar o banco de dados e popular as tabelas com os valores pré-definidos nas "Migrations"
* Atentar ao arquivo web.config do projeto DesafioLance.WebApp que a string de conexão aponta para um banco local SQLServerExpress. Se
precisar apontar para outro servidor em outro endereço precisará alterar essa string de conexão.





