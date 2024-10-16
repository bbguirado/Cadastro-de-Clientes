# Cadastro de Clientes

Este projeto é uma aplicação console em C# para gerenciar um cadastro de clientes. Ele permite adicionar, visualizar, editar e excluir informações de clientes de maneira simples e interativa.

## Funcionalidades

- **Adicionar Cliente**: Permite cadastrar um novo cliente com nome e e-mail.
- **Visualizar Clientes**: Exibe todos os clientes cadastrados.
- **Editar Cliente**: Altera as informações de um cliente existente.
- **Excluir Cliente**: Remove um cliente do cadastro.

## Estrutura do Código

- **Program.cs**: Classe principal que controla o fluxo da aplicação.
- **Cliente.cs**: Classe que representa um cliente.
- **ClienteManager.cs**: Gerencia as operações de clientes (adicionar, editar, excluir, visualizar).
- **ValidadorEmail.cs**: Valida os e-mails inseridos.

## Como Executar

Exemplo de Uso

Após executar o programa, um menu será exibido:

Selecione uma opção:
1 - Adicionar cliente
2 - Visualizar clientes
3 - Editar cliente
4 - Excluir cliente
5 - Sair

Você pode selecionar uma opção digitando o número correspondente e seguindo as instruções na tela.

Exemplo de Adição de Cliente
Ao selecionar a opção para adicionar um cliente, o programa pedirá o nome e o e-mail. O sistema validará se os dados inseridos são válidos antes de adicionar o cliente.


## Estrutura de Diretórios

CadastroClientesPOO/
│
├── Program.cs        # Classe principal do programa
├── Cliente.cs        # Classe que representa um cliente
├── ClienteManager.cs  # Classe que gerencia as operações de clientes
└── ValidadorEmail.cs # Classe que valida e-mails



## Requisitos

.NET SDK 5.0 ou superior.

Melhorias Futuras

- Implementar uma interface gráfica para facilitar a interação.
- Adicionar persistência de dados em arquivos ou banco de dados.
- Melhorar as validações de entrada, como verificação mais detalhada de e-mails.
- Implementar testes automatizados para as funcionalidades principais.


Sinta-se à vontade para fazer quaisquer ajustes necessários!
