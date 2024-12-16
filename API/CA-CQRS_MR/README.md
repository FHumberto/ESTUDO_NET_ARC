# Aquitetura

Este projeto segue uma arquitetura em camadas, onde cada camada tem responsabilidades específicas. 

Abaixo estão as camadas que compõem o projeto:

## Presentation

A camada de Presentation é responsável pela interação entre a aplicação e o consumidor.

- `WebApi`: Exposição da API que serve como ponto de entrada para as requisições dos clientes. Ela lida com as requisições HTTP e delega a lógica de negócios para a camada de aplicação.

## Core

A camada de Core é o núcleo da aplicação e é composta por duas partes essenciais: `Application` e `Domain`.

- `Application`: Contém a lógica de aplicação, como casos de uso (Use Cases), serviços e orquestração de operações. Interage diretamente com o domínio e com a infraestrutura para realizar tarefas específicas.
- `Domain`: Contém as entidades do domínio, que representam os principais conceitos da aplicação, como regras de negócios e lógica fundamental. A camada de domínio é independente de qualquer tecnologia ou framework específico.

## Infrastructure

A camada de Infrastructure fornece implementações concretas para os serviços necessários pela aplicação, como persistência de dados, autenticação, e serviços externos.

- `Identity`: Implementações relacionadas à autenticação e autorização de usuários, como gerenciamento de identidade e integração com o sistema de autenticação.
- `Infrastructure`: Implementações genéricas de infraestrutura, como serviços internos, externos, integração com APIs e outros recursos essenciais para o funcionamento da aplicação.
- `Persistence`: Responsável pela persistência de dados, com implementações concretas de repositórios, acesso a banco de dados e manipulação de entidades persistidas.

# TECNOLOGIAS

- `.NET 9` 