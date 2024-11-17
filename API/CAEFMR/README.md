# Aquitetura

Este projeto segue uma arquitetura em camadas, onde cada camada tem responsabilidades específicas. 

Abaixo estão as camadas que compõem o projeto:

## Presentation

A camada de Presentation é responsável pela interação entre a aplicação e o consumidor.

- WebApi: Exposição da API que serve como ponto de entrada para as requisições dos clientes. Ela lida com as requisições HTTP e delega a lógica de negócios para a camada de aplicação.

## Core

A camada de Core é o núcleo da aplicação e é composta por duas partes essenciais: Application e Domain.

- Application: Contém a lógica de aplicação, como casos de uso (Use Cases), serviços e orquestração de operações. Interage diretamente com o domínio e com a infraestrutura para realizar tarefas específicas.
- Domain: Contém as entidades do domínio, que representam os principais conceitos da aplicação, como regras de negócios e lógica fundamental. A camada de domínio é independente de qualquer tecnologia ou framework específico.

## Infrastructure

A camada de Infrastructure fornece implementações concretas para os serviços necessários pela aplicação, como persistência de dados, autenticação, e serviços externos.

- Identity: Implementações relacionadas à autenticação e autorização de usuários, como gerenciamento de identidade e integração com o sistema de autenticação.
- Infrastructure: Implementações genéricas de infraestrutura, como serviços internos, externos, integração com APIs e outros recursos essenciais para o funcionamento da aplicação.
- Persistence: Responsável pela persistência de dados, com implementações concretas de repositórios, acesso a banco de dados e manipulação de entidades persistidas.

# SERVIÇOS

- `SWAGGER` - https://localhost:7101/swagger/index.html
- `HEALTH CHECK DASHBOARD` - https://localhost:7101/dashboard#/healthchecks
- `HEALTH CHEACK ENDPOINTS` - https://localhost:7101/health

# TECNOLOGIAS

- `.NET 8` 
- `C# 12.0`
- `MediatR`
- `Swagger`
- `HealthChecks`
- `HealthChecks.UI`
- `Entity Framework Core`
- `FluentValidation`
- `AutoMapper`
- `JWT (JSON Web Token)`
- `API Versioning`
- `Rate Limiting`
- `Problem Details`

# MATERIAL DE REFERÊNCIA

- [RateLimiter (Doc. Microsoft)](https://learn.microsoft.com/en-us/aspnet/core/performance/rate-limit?view=aspnetcore-8.0)
- [Handle Erros (Doc. Microsoft)](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-8.0)
- [Global Error Handling (Blog. Milan)](https://www.milanjovanovic.tech/blog/global-error-handling-in-aspnetcore-8)

# EXECUTANDO O PROJETO

## Pré-requisitos

- Visual Studio 2022
- .NET 8 SDK
- SQL Server

## Passo 1: Abrir o Projeto no Visual Studio

Abra o Visual Studio 2022 e selecione `Open a project or solution`. Navegue até o diretório onde você clonou o repositório e selecione o arquivo da solução (`.sln`).

## Passo 2: Configurar a String de Conexão

Edite o arquivo `appsettings.json` no projeto `CAEFMR.Api`:

```json
{ "ConnectionStrings": { "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USER;Password=YOUR_PASSWORD;" } }
```

## Passo 3: Aplicar as Migrations

No `Package Manager Console`, selecione o projeto `CAEFMR.Persistence` e execute:

`Update-Database -Context AppDbContext`

Em seguida, selecione o projeto `CAEFMR.Identity` e execute:

`Update-Database -Context IdentityDbContext`

## Passo 4: Executar a Aplicação

Selecione o projeto `CAEFMR.Api` como projeto de inicialização e pressione `F5` ou clique em `Start`.

## Passo 5: Acessar os Serviços

- `SWAGGER` - [https://localhost:7101/swagger/index.html](https://localhost:7101/swagger/index.html)
- `HEALTH CHECK DASHBOARD` - [https://localhost:7101/dashboard#/healthchecks](https://localhost:7101/dashboard#/healthchecks)
- `HEALTH CHECK ENDPOINTS` - [https://localhost:7101/health](https://localhost:7101/health)