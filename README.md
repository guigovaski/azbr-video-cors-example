# CORS Example — ASP.NET Core

Projeto de exemplo criado para acompanhar o vídeo sobre **CORS (Cross-Origin Resource Sharing)** no canal **AzureBrasil**.

## O que é CORS?

CORS é um mecanismo de segurança do navegador que bloqueia requisições feitas de uma origem (domínio, protocolo ou porta) diferente da origem do servidor. Para permitir essas requisições, o servidor precisa informar ao navegador quais origens, métodos e cabeçalhos são aceitos através de cabeçalhos HTTP específicos, como `Access-Control-Allow-Origin`.

## Sobre o projeto

Este projeto é uma Web API mínima em **ASP.NET Core (.NET 10)** que demonstra duas formas de configurar o CORS:

1. **Middleware customizado** — implementado manualmente no `Program.cs`, adicionando os cabeçalhos `Access-Control-Allow-Origin`, `Access-Control-Allow-Methods` e `Access-Control-Allow-Headers` a cada resposta e tratando a requisição *preflight* (`OPTIONS`).

2. **Middleware padrão do ASP.NET Core** — uso do `app.UseCors(...)` nativo (disponível como alternativa comentada no `Program.cs`).

### Endpoints disponíveis

| Método | Rota | Descrição            |
|--------|------|----------------------|
| GET    | `/`  | Retorna "Hello World!" |
| POST   | `/`  | Retorna "Hello World!" |
| PUT    | `/`  | Retorna "Hello World!" |

## Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Como executar

```bash
# Clone o repositório
git clone https://github.com/guigovaski/azbr-video-cors-example.git
cd azbr-video-cors-example

# Execute a aplicação
dotnet run --project CorsExampleBackend
```

A API ficará disponível em `https://localhost:5001` (ou `http://localhost:5000`).

## Estrutura do projeto

```
azbr-video-cors-example/
├── CorsExampleBackend/
│   ├── Program.cs                  # Configuração do middleware e endpoints
│   ├── CorsExampleBackend.csproj   # Definição do projeto
│   ├── appsettings.json            # Configurações da aplicação
│   └── appsettings.Development.json
└── CorsExampleBackend.sln          # Solution file
```

## Referências

- [MDN — Cross-Origin Resource Sharing (CORS)](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/CORS)
- [Documentação oficial — Enable CORS in ASP.NET Core](https://learn.microsoft.com/aspnet/core/security/cors)
