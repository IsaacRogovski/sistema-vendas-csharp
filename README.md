# Sistema de Vendas — C# Windows Forms

Sistema desktop de gerenciamento de vendas desenvolvido em C# com Windows Forms e Microsoft SQL Server, como projeto acadêmico da disciplina de Programação Orientada a Objetos.

O projeto tem como objetivo implementar operações CRUD (Create, Read, Update e Delete), integrando uma interface gráfica com um banco de dados relacional.

## Tecnologias utilizadas

- C#
- Windows Forms
- Microsoft SQL Server
- SQL
- Visual Studio
- Git e GitHub

## Funcionalidades

- [x] Interface gráfica
- [ ] Cadastro de categorias
- [ ] Cadastro de produtos
- [ ] Consulta de registros
- [ ] Edição de registros
- [ ] Exclusão de registros
- [ ] Cadastro de vendas
- [ ] Integração com SQL Server

> O projeto está em desenvolvimento. As funcionalidades serão implementadas progressivamente.

## Pré-requisitos

Para executar o projeto, será necessário instalar:

- [Visual Studio](https://visualstudio.microsoft.com/)
- Workload **Desenvolvimento para desktop com .NET**
- Microsoft SQL Server
- SQL Server Management Studio (SSMS), recomendado para administrar o banco de dados

## Como executar

### 1. Clonar o repositório

```bash
git clone https://github.com/IsaacRogovski/sistema-vendas-csharp.git
```

Entre na pasta do projeto:

```bash
cd sistema-vendas-csharp
```

### 2. Abrir o projeto

Abra o arquivo `.sln` na pasta do projeto utilizando o Visual Studio.

Caso necessário, aguarde a restauração automática dos pacotes NuGet.

### 3. Configurar o banco de dados

- Abra o SQL Server Management Studio.
- Conecte-se à sua instância do SQL Server.
- Execute o script SQL disponibilizado neste repositório para criar o banco de dados e suas tabelas.

> O script de criação do banco de dados será disponibilizado na pasta `Database` após sua implementação.

### 4. Configurar a conexão

Configure a string de conexão para apontar para sua instância local do SQL Server.

A configuração de conexão poderá variar de acordo com a instalação de cada usuário.

### 5. Executar o sistema

No Visual Studio:

1. Defina o projeto Windows Forms como projeto de inicialização.
2. Compile a solução.
3. Execute utilizando `F5` ou `Ctrl + F5`.

## Estrutura do projeto

A estrutura será organizada de acordo com a implementação do sistema.

```text
sistema-vendas-csharp/
├── SistemaVendas.sln
├── SistemaVendas/
│   ├── Forms/
│   ├── Database/
│   ├── Resources/
│   └── ...
├── README.md
└── .gitignore
```

## Objetivo acadêmico

Projeto desenvolvido para aplicar conhecimentos de Programação Orientada a Objetos, desenvolvimento de interfaces desktop, integração com bancos de dados relacionais e operações CRUD.

## Autor

**Isaac Rogovski**

GitHub: [@IsaacRogovski](https://github.com/IsaacRogovski)
