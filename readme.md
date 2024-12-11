# Sistema de Vendas TP1

Este é um sistema de vendas desenvolvido como parte do Trabalho Avaliativo da disciplina de Técnicas de Programação 1. O sistema permite gerenciar clientes, produtos e vendas, armazenando os dados em memória.

## Funcionalidades

- **Clientes**:

  - Cadastrar cliente
  - Buscar cliente por código
  - Listar todos os clientes
  - Deletar Cliente

- **Produtos**:

  - Cadastrar produto
  - Buscar produto por código
  - Listar todos os produtos
  - Deletar produto

- **Vendas**:
  - Cadastrar venda
  - Buscar venda por código
  - Listar todas as vendas
  - Exibir valor total das vendas

## Estrutura do Projeto

- **Controller**: Contém os controladores que gerenciam a lógica de negócios.

  - `BaseController.cs`
  - `ClientController.cs`
  - `ProductController.cs`
  - `SaleController.cs`

- **Model**: Contém as classes de modelo que representam os dados.

  - `Client.cs`
  - `Product.cs`
  - `Sale.cs`
  - `ProductSale.cs`

- **Repository**: Contém os repositórios que manipulam os dados armazenados em memória.

  - `BaseRepository`
  - `ClientRepository.cs`
  - `ProductRepository.cs`
  - `SaleRepository.cs`

- **Utils**: Contém classes utilitárias.

  - `Format.cs`
  - `GenerateCodeClass.cs`

- **View**: Contém as classes de visualização que interagem com o usuário.

  - `ClientMenuView.cs`
  - `ProductMenuView.cs`
  - `SaleMenuView.cs`
  - `MainMenuView.cs`

  ## Regras de Negócio

  - **Clientes**:

    - Não pode cadastrar clientes menores de 18 anos.
    - Clientes não podem ser excluídos caso façam parte de uma venda.

  - **Produtos**:

    - Produtos não podem ser excluídos caso façam parte de uma venda.

  - **Vendas**:
    - Só é possível cadastrar uma venda se houver um `clientCode` e no mínimo um produto.

## Como Executar

1. Clone o repositório:

```bash
  git clone https://github.com/marcuslaraa/sistema_vendas_TP1

```

2. Navegue até o diretório do projeto

**cd sistema_vendas_TP1**

3. Compile e execute o projeto

**dontnet run**

## Requisitos

- .NET SDK 8.0 ou superior
- IDE de sua preferência (Visual Studio, Visual Studio Code, etc.)

## Contribuição

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova feature'`)
4. Faça o push para a branch (`git push origin feature/nova-feature`)
5. Abra um Pull Request

## Contato

Para mais informações, entre em contato com [marcus.lara@hotmail.com](mailto:marcus.lara@hotmail.com).
