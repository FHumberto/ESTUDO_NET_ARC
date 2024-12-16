# Aquitetura

Este projeto segue uma arquitetura em camadas, onde cada camada tem responsabilidades espec�ficas. 

Abaixo est�o as camadas que comp�em o projeto:

## Presentation

A camada de Presentation � respons�vel pela intera��o entre a aplica��o e o consumidor.

- `WebApi`: Exposi��o da API que serve como ponto de entrada para as requisi��es dos clientes. Ela lida com as requisi��es HTTP e delega a l�gica de neg�cios para a camada de aplica��o.

## Core

A camada de Core � o n�cleo da aplica��o e � composta por duas partes essenciais: `Application` e `Domain`.

- `Application`: Cont�m a l�gica de aplica��o, como casos de uso (Use Cases), servi�os e orquestra��o de opera��es. Interage diretamente com o dom�nio e com a infraestrutura para realizar tarefas espec�ficas.
- `Domain`: Cont�m as entidades do dom�nio, que representam os principais conceitos da aplica��o, como regras de neg�cios e l�gica fundamental. A camada de dom�nio � independente de qualquer tecnologia ou framework espec�fico.

## Infrastructure

A camada de Infrastructure fornece implementa��es concretas para os servi�os necess�rios pela aplica��o, como persist�ncia de dados, autentica��o, e servi�os externos.

- `Identity`: Implementa��es relacionadas � autentica��o e autoriza��o de usu�rios, como gerenciamento de identidade e integra��o com o sistema de autentica��o.
- `Infrastructure`: Implementa��es gen�ricas de infraestrutura, como servi�os internos, externos, integra��o com APIs e outros recursos essenciais para o funcionamento da aplica��o.
- `Persistence`: Respons�vel pela persist�ncia de dados, com implementa��es concretas de reposit�rios, acesso a banco de dados e manipula��o de entidades persistidas.

# TECNOLOGIAS

- `.NET 9` 