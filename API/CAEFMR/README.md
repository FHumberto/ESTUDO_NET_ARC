# Aquitetura

Este projeto segue uma arquitetura em camadas, onde cada camada tem responsabilidades espec�ficas. 

Abaixo est�o as camadas que comp�em o projeto:

## Presentation

A camada de Presentation � respons�vel pela intera��o entre a aplica��o e o consumidor.

- WebApi: Exposi��o da API que serve como ponto de entrada para as requisi��es dos clientes. Ela lida com as requisi��es HTTP e delega a l�gica de neg�cios para a camada de aplica��o.

## Core

A camada de Core � o n�cleo da aplica��o e � composta por duas partes essenciais: Application e Domain.

- Application: Cont�m a l�gica de aplica��o, como casos de uso (Use Cases), servi�os e orquestra��o de opera��es. Interage diretamente com o dom�nio e com a infraestrutura para realizar tarefas espec�ficas.
- Domain: Cont�m as entidades do dom�nio, que representam os principais conceitos da aplica��o, como regras de neg�cios e l�gica fundamental. A camada de dom�nio � independente de qualquer tecnologia ou framework espec�fico.

## Infrastructure

A camada de Infrastructure fornece implementa��es concretas para os servi�os necess�rios pela aplica��o, como persist�ncia de dados, autentica��o, e servi�os externos.

- Identity: Implementa��es relacionadas � autentica��o e autoriza��o de usu�rios, como gerenciamento de identidade e integra��o com o sistema de autentica��o.
- Infrastructure: Implementa��es gen�ricas de infraestrutura, como servi�os internos, externos, integra��o com APIs e outros recursos essenciais para o funcionamento da aplica��o.
- Persistence: Respons�vel pela persist�ncia de dados, com implementa��es concretas de reposit�rios, acesso a banco de dados e manipula��o de entidades persistidas.

# SERVI�OS

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

# MATERIAL DE REFER�NCIA

- [RateLimiter (Doc. Microsoft)](https://learn.microsoft.com/en-us/aspnet/core/performance/rate-limit?view=aspnetcore-8.0)
- [Handle Erros (Doc. Microsoft)](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-8.0)
- [Global Error Handling (Blog. Milan)](https://www.milanjovanovic.tech/blog/global-error-handling-in-aspnetcore-8)

# EXECUTANDO O PROJETO

## Pr�-requisitos

- Visual Studio 2022
- .NET 8 SDK
- SQL Server

## Passo 1: Abrir o Projeto no Visual Studio

Abra o Visual Studio 2022 e selecione `Open a project or solution`. Navegue at� o diret�rio onde voc� clonou o reposit�rio e selecione o arquivo da solu��o (`.sln`).

## Passo 2: Configurar a String de Conex�o

Edite o arquivo `appsettings.json` no projeto `CAEFMR.Api`:

```json
{ "ConnectionStrings": { "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USER;Password=YOUR_PASSWORD;" } }
```

## Passo 3: Aplicar as Migrations

No `Package Manager Console`, selecione o projeto `CAEFMR.Persistence` e execute:

`Update-Database -Context AppDbContext`

Em seguida, selecione o projeto `CAEFMR.Identity` e execute:

`Update-Database -Context IdentityDbContext`

## Passo 4: Executar a Aplica��o

Selecione o projeto `CAEFMR.Api` como projeto de inicializa��o e pressione `F5` ou clique em `Start`.

## Passo 5: Acessar os Servi�os

- `SWAGGER` - [https://localhost:7101/swagger/index.html](https://localhost:7101/swagger/index.html)
- `HEALTH CHECK DASHBOARD` - [https://localhost:7101/dashboard#/healthchecks](https://localhost:7101/dashboard#/healthchecks)
- `HEALTH CHECK ENDPOINTS` - [https://localhost:7101/health](https://localhost:7101/health)