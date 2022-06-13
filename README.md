<h2 align="center">
    SENAI - SP    
</h2>
<h3 align="center">
    ExoAPI - Gerenciamento de projetos
</h3>

<h2 align="center">
A ExoAPI fornece endpoints para o cadastro de projetos e o cadastro de usuários. Cada um de seus métodos está listado a seguir.
</h2>

<h2 align="center">
## Endpoints e seus métodos
</h2>

<h2 align="center">
### Login
</h2>
<h2 align="center">
Permite que o usuário faça cadastro na API.
	</h2>

<h2 align="center">
#### Request
</h2>

> POST: /api/login

```json
{
	"email": "teste@teste.com",
	"senha": "12346"
}
```
<h2 align="center">
#### Response
</h2>

```json
{
	"token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...."
}
```

---
<h2 align="center">
### Lista de projetos
</h2>
<h2 align="center">
Seu propósito é procurar todos os projetos cadastrados no banco, mas precisa de autenticação.
	</h2>
<h2 align="center">
#### Request
</h2>

> GET: /api/projetos
<h2 align="center">
#### Response
</h2>

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
<h2 align="center">
### Busca de projeto por id
</h2>
<h2 align="center">
Localiza um projeto específico pelo seu id, mas precisa de autenticação.
	</h2>

<h2 align="center">
#### Request
</h2>

> GET: /api/projetos/{id}
<h2 align="center">
#### Response
</h2>

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
<h2 align="center">
### Cadastro de projeto
</h2>
<h2 align="center">
Arquiva um novo projeto no banco de dados, mas precisa de autenticação.
	</h2>

<h2 align="center">
#### Request
</h2>

> POST: /api/projetos

```json
{
	"titulo": "Projeto 4",
	"inicio": "2021-10-31T13:30:00",
	"status": 1,
	"tecnologias": ".net"
}
```
<h2 align="center">
#### Response
</h2>

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
<h2 align="center">
### Alteração de projeto
</h2>
<h2 align="center">
Permite os dados de um projeto existente sejam alterados, mas precisa de autenticação.
	</h2>

<h2 align="center">
#### Request
</h2>

> PUT: /api/projetos/{id}

```json
{
	"titulo": "Projeto 4",
	"inicio": "2021-10-31T13:30:00",
	"status": 2,
	"tecnologias": ".net"
}
```
<h2 align="center">
#### Response
</h2>

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
<h2 align="center">
### Exclusão projeto
</h2>
<h2 align="center">
Deleta um projeto do banco de dados, mas precisa de autenticação.
	</h2>

<h2 align="center">
#### Request
</h2>

> DELETE: /api/projetos/{id}
<h2 align="center">
#### Response
</h2>

```json
"Projeto removido"
```

---
<h2 align="center">
### Lista de usuários
</h2>
<h2 align="center">
Busca todos os usuários cadastrados no banco de dados, mas precisa de autenticação.
	</h2>

<h2 align="center">
#### Request
</h2>

> GET: /api/usuarios
<h2 align="center">
#### Response
</h2>

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
<h2 align="center">
### Busca de usuário
</h2>
<h2 align="center">
Busca um usuário específico pelo seu id, mas precisa de autenticação.
<h2 align="center">
#### Request
</h2>

> GET: /api/usuarios/{id}
<h2 align="center">
#### Response
</h2>

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
<h2 align="center">
### Cadastro de usuário
</h2>
<h2 align="center">
Insere um novo usuário na base de dados.
	</h2>

<h2 align="center">
#### Request
</h2>

> POST: /api/usuarios

```json
{
	"nome": "Teste 5",
	"email": "teste5@teste.com",
	"senha": "12345"
}
```
<h2 align="center">
#### Response
</h2>

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
<h2 align="center">
### Alteração de usuário
</h2>
<h2 align="center">
Altera os dados de um usuário existente, mas precisa de autenticação.
	</h2>

<h2 align="center">
#### Request
</h2>

> PUT: /api/usuarios/{id}

```json
{
	"nome": "Teste 5",
	"email": "teste5@teste.com",
	"senha": "12345"
}
```
<h2 align="center">
#### Response
</h2>

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
<h2 align="center">
### Exclusão usuário
</h2>
<h2 align="center">
Deleta um usuário pelo seu id, mas precisa de autenticação e perfil do administrador.
	</h2>

<h2 align="center">
#### Request
</h2>
<h2 align="center">
> DELETE: /api/usuarios/{id}
	</h2>

<h2 align="center">
#### Response
</h2>

```json
"Usuário removido"
```
<h2 align="center">
## Tecnologias utilizadas
</h2>
<h2 align="center">
Web API escrita em C# na plataforma .NET 6.0.
	</h2>

<h2 align="center">
## Organização do projeto
</h2>
<h2 align="center">
O projeto está organizado conforme descrição a seguir:
<h2 align="center">
**Pasta Contexts**: contém a classe de acesso e mapeamento do banco de dados
	</h2>

<h2 align="center">
**Pasta Repositories**: contém as classes de manipulação de dados de cada uma das entidades
	</h2>

<h2 align="center">
**Pasta Models**: contém as classes de modelo que representam cada uma das entidades
	</h2>

<h2 align="center">
**Pasta Enumeradores**: contém as especificações de perfil do usuário (administrador, usuário comum) e os possíveis status de um projeto (não iniciado, em desenvolvimento, cancelado, pausado, em homologação, finalizado)
	</h2>

<h2 align="center">
**Pasta Controllers**: contém os controladores que implementam e expõem os endpoints e métodos da API
	</h2>

<h2 align="center">
**Pasta Tools**: contém a classe Password.cs que oferece método para hashear as senhas antes de transitar com elas entre camadas
	</h2>

<h2 align="center">
## Pré-requisitos para edição
	</h2>

<h2 align="center">
-   .NET SDK 6.0
-   Visual Studio 2022 ou Visual Studio for Mac
-   Git e acesso ao GitHub
	</h2>

<h2 align="center">
## Pré-requisitos para execução
	</h2>

<h2 align="center">
-   .NET Runtime 6.0
	</h2>

<h2 align="center">
## Execução da aplicação
	</h2>

<h2 align="center">
### No Visual Studio 2022
	</h2>

<h2 align="center">
Clique com o botão direito do mouse na solução e selecione a opção "Run solution"
	</h2>

<h2 align="center">
## Colaboradores
	</h2>

<h2 align="center">
João Pedro Neves Guerreiro
	</h2>

