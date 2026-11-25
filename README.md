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

### Pré-requisitos

- Windows 10 ou Windows 11
- Visual Studio compatível com .NET 10
- SDK do .NET 10
- Workload **Desenvolvimento para desktop com .NET**
- Microsoft SQL Server
- SQL Server Management Studio (SSMS), recomendado

### Como executar

#### 1. Clonar o repositório

```bash
git clone https://github.com/IsaacRogovski/sistema-vendas-csharp.git
```

```bash
cd sistema-vendas-csharp
```

#### 2. Abrir a solução

Abra o arquivo `SistemaVendas.slnx` utilizando o Visual Studio.

Aguarde a restauração automática das dependências NuGet.

#### 3. Configurar o banco de dados

Após a implementação do banco:

1. Abra o SQL Server Management Studio.
2. Conecte-se à instância do SQL Server.
3. Execute o script de criação do banco disponibilizado na pasta `Database`.

#### 4. Configurar a conexão

Configure a conexão com o SQL Server conforme as instruções do projeto.

Não utilize credenciais pessoais ou senhas expostas no repositório.

#### 5. Executar

Defina `SistemaVendas` como projeto de inicialização e execute pelo Visual Studio utilizando `F5` ou `Ctrl + F5`.


## Estrutura do projeto

A estrutura será organizada de acordo com a implementação do sistema.

```text
sistema-vendas-csharp/
├── SistemaVendas.slnx
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
