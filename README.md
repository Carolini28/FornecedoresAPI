# FornecedoresAPI

Este projeto é uma Web API desenvolvida em C# utilizando ASP.NET Core para gerenciar fornecedores relacionados a uma empresa.

## Funcionalidades

A API permite realizar as seguintes operações:
- Listar todos os fornecedores.
- Buscar um fornecedor específico pelo ID.
- Adicionar um novo fornecedor.
- Atualizar um fornecedor existente pelo ID.
- Remover um fornecedor pelo ID.

## Estrutura do Projeto

- **Controllers**: Contém o controlador `FornecedoresController.cs` que implementa os endpoints da API.
- **Models**: Contém o modelo `Fornecedor.cs` que define a estrutura dos dados do fornecedor.
- **Data**: Contém o contexto `FornecedoresContext.cs` que gerencia a interação com o banco de dados.
- **Properties**: Contém arquivos de propriedades do projeto.
- **appsettings.json**: Arquivo de configuração para definir a string de conexão com o banco de dados.
- **Program.cs**: Arquivo principal para configuração e inicialização do aplicativo.

## Endpoints da API

- **GET /api/fornecedores**: Retorna todos os fornecedores.
- **GET /api/fornecedores/{id}**: Retorna um fornecedor específico pelo ID.
- **POST /api/fornecedores**: Adiciona um novo fornecedor.
- **PUT /api/fornecedores/{id}**: Atualiza um fornecedor existente pelo ID.
- **DELETE /api/fornecedores/{id}**: Remove um fornecedor pelo ID.

## Modelo de Dados

O modelo `Fornecedor` possui os seguintes atributos:
- `Id` (int): Identificador único do fornecedor.
- `Nome` (string): Nome do fornecedor.
- `Email` (string): Endereço de e-mail do fornecedor.
- `Telefone` (string): Telefone de contato do fornecedor.

## Configuração do Projeto

### Requisitos

- .NET 6.0 ou superior
- SQL Server

### Passo a Passo

1. **Clone o repositório**
   ```sh
   git clone https://github.com/seu-usuario/fornecedores-api.git
   cd fornecedores-api
