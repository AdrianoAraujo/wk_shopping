# WK Shopping
<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/AdrianoAraujo/wk_shopping">

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/AdrianoAraujo/wk_shopping">
  
  <a href="https://github.com/AdrianoAraujo/wk_shopping/commits/master">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/AdrianoAraujo/wk_shopping">
  </a>

  <img alt="Packagist" src="https://img.shields.io/badge/License-MIT-green.svg">
</p>

**Microsserviços para cadastro de produtos e categorias.**
Nele você pode gerenciar seus produtos e categorias.

## Tecnologias
- Banco de Dados MySQL
- ASP.NET Core 
- HTML5
- CSS3
- Bootstrap
- Javascript
- Injeção de Dependência - Swagger

## Requisitos
- .NET 6
- MySQL Server 8.0.29

## Sobre a aplicação
### Home
Essa é a tela de inicial.

![image](https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/Home.png?raw=true)

### Detalhes
Essa é a tela de detalhes do produto.

![image](https://user-images.githubusercontent.com/41703972/80524330-cf3ff980-8965-11ea-8000-2e4466110ae9.png)

### Cadastros
#### Cadastro de Produtos
Essa é a tela de cadastro de produtos; aqui você pode inserir, alterar e excluir produtos.

![image](https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/Lista%20de%20Produtos.png?raw=true)

#### Cadastro de Categoria
Essa é a tela de cadastro de categoria; aqui você pode inserir, alterar e excluir categorias.

![image](https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/Lista%20de%20Categorias.png?raw=true)

## Bibliotecas e frameworks utilizados
### Backend
- Entity Framework - ORM
- AutoMapper - para mapeamento de propriedades de um objeto para outro.

### Web
- Bootstrap - para desenvolvimento de componentes de interface.

## Rodando a aplicação
1. Primeiro clone o repositório rodando `git clone https://github.com/AdrianoAraujo/wk_shopping.git` no seu terminal favorito.
2. Depois, crie os bancos de dados rodando os scripts: CREATE SCHEMA `wk_shopping_produto_api` e CREATE SCHEMA `wk_shopping_categoria_api`.
3. Após a criação dos bancos, executar os comandos no console do gerenciador de pacotes de cada microserviço (ProdutoAPI e CategoriaAPI): add-migrations e em seguida Update-DataBase.
4. Pronto, basta executar a aplicação.

## Licença
Este projeto está sob licença do MIT. Veja a [Licença](https://github.com/AdrianoAraujo/wk_shopping/blob/master/LICENSE) para mais detalhes.
