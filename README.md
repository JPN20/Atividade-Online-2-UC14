<h2 align="center">
    SENAI - SP    
</h2>
<h3 align="center">
    ExoAPI - Gerenciamento de projetos
</h3>


A ExoAPI fornece endpoints para o cadastro de projetos e o cadastro de usuários. Cada um de seus métodos está listado a seguir.

## Endpoints e seus métodos

### Login

Permite que o usuário faça cadastro na API.

#### Request

> POST: /api/login

```json
{
	"email": "teste@teste.com",
	"senha": "12346"
}
```

#### Response

```json
{
	"token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...."
}
```

---

### Lista de projetos

Seu proósito é procurar todos os projetos cadastrados no banco, mas precisa de autenticação.

#### Request

> GET: /api/projetos

#### Response

```json
[
	{
		"id": 2,
		"titulo": "Projeto 2",
		"inicio": "2021-10-31T00:00:00",
		"status": 1,
		"tecnologias": ".net"
	},
	{
		"id": 3,
		"titulo": "Projeto 3",
		"inicio": "2021-10-31T13:30:00",
		"status": 2,
		"tecnologias": ".net, c#, api, angular"
	}
]
```

---

### Busca de projeto por id

Localiza um projeto específico pelo seu id, mas precisa de autenticação.

#### Request

> GET: /api/projetos/{id}

#### Response

```json
{
	"id": 2,
	"titulo": "Projeto 2",
	"inicio": "2021-10-31T00:00:00",
	"status": 1,
	"tecnologias": ".net"
}
```

---

### Cadastro de projeto

Arquiva um novo projeto no banco de dados, mas precisa de autenticação.

#### Request

> POST: /api/projetos

```json
{
	"titulo": "Projeto 4",
	"inicio": "2021-10-31T13:30:00",
	"status": 1,
	"tecnologias": ".net"
}
```

#### Response

```json
{
	"id": 4,
	"titulo": "Projeto 4",
	"inicio": "2021-10-31T13:30:00",
	"status": 1,
	"tecnologias": ".net"
}
```

---

### Alteração de projeto

Permite os dados de um projeto existente sejam alterados, mas precisa de autenticação.

#### Request

> PUT: /api/projetos/{id}

```json
{
	"titulo": "Projeto 4",
	"inicio": "2021-10-31T13:30:00",
	"status": 2,
	"tecnologias": ".net"
}
```

#### Response

```json
{
	"id": 4,
	"titulo": "Projeto 4",
	"inicio": "2021-10-31T13:30:00",
	"status": 2,
	"tecnologias": ".net"
}
```

---

### Exclusão projeto

Deleta um projeto do banco de dados, mas precisa de autenticação.

#### Request

> DELETE: /api/projetos/{id}

#### Response

```json
"Projeto removido"
```

---

### Lista de usuários

Busca todos os usuários cadastrados no banco de dados, mas precisa de autenticação.

#### Request

> GET: /api/usuarios

#### Response

```json
[
	{
		"id": 1,
		"nome": "Teste 1",
		"email": "teste1@teste.com",
		"senha": "",
		"perfil": 1
	},
	{
		"id": 2,
		"nome": "Teste 2",
		"email": "teste2@teste.com",
		"senha": "",
		"perfil": 2
	}
]
```

---

### Busca de usuário

Busca um usuário específico pelo seu id, mas precisa de autenticação.

#### Request

> GET: /api/usuarios/{id}

#### Response

```json
{
	"id": 1,
	"nome": "Teste 1",
	"email": "teste1@teste.com",
	"senha": "",
	"perfil": 1
}
```

---

### Cadastro de usuário

Insere um novo usuário na base de dados.

#### Request

> POST: /api/usuarios

```json
{
	"nome": "Teste 5",
	"email": "teste5@teste.com",
	"senha": "12345"
}
```

#### Response

```json
{
	"id": 5,
	"nome": "Teste 5",
	"email": "teste5@teste.com",
	"senha": "",
	"perfil": 2
}
```

---

### Alteração de usuário

Altera os dados de um usuário existente, mas precisa de autenticação.

#### Request

> PUT: /api/usuarios/{id}

```json
{
	"nome": "Teste 5",
	"email": "teste5@teste.com",
	"senha": "12345"
}
```

#### Response

```json
{
	"id": 5,
	"nome": "Teste 5",
	"email": "teste5@teste.com",
	"senha": "",
	"perfil": 2
}
```

---

### Exclusão usuário

Deleta um usuário pelo seu id, mas precisa de autenticação e perfil do administrador.

#### Request

> DELETE: /api/usuarios/{id}

#### Response

```json
"Usuário removido"
```

## Tecnologias utilizadas

Web API escrita em C# na plataforma .NET 6.0.

## Organização do projeto

O projeto está organizado conforme descrição a seguir:

**Pasta Contexts**: contém a classe de acesso e mapeamento do banco de dados

**Pasta Repositories**: contém as classes de manipulação de dados de cada uma das entidades

**Pasta Models**: contém as classes de modelo que representam cada uma das entidades

**Pasta Enumeradores**: contém as especificações de perfil do usuário (administrador, usuário comum) e os possíveis status de um projeto (não iniciado, em desenvolvimento, cancelado, pausado, em homologação, finalizado)

**Pasta Controllers**: contém os controladores que implementam e expõem os endpoints e métodos da API

**Pasta Tools**: contém a classe Password.cs que oferece método para hashear as senhas antes de transitar com elas entre camadas

## Pré-requisitos para edição

-   .NET SDK 6.0
-   Visual Studio 2022 ou Visual Studio for Mac
-   Git e acesso ao GitHub

## Pré-requisitos para execução

-   .NET Runtime 6.0

## Execução da aplicação

### No Visual Studio 2022

Clique com o botão direito do mouse na solução e selecione a opção "Run solution"

## Colaboradores

João Pedro Neves Guerreiro
