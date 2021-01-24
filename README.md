# Vehicle Management

Projeto que permite realizar um CRUD de veículos, comunicando uma aplicação web MCV com uma API, ambas construídas com C#.

## Projetos da solução

- VehicleManagement.UI - Aplicação web para interação do usuário
- VehicleManagement.API - API que contém os métodos da aplicação
- VehicleManagement.Business - Camada responsável pelas regras de negócio
- VehicleManagement.Data - Camada responsável pela comunicação com banco de dados
- VehicleManagement.Models - Projeto que armazena as classes que são modelo de negócio
- VehicleManagement.Configuration - Carrega configurações gerais do projeto

## Tecnologias

Abaixo uma lista das principais tecnologias utilizadas no projeto:

|     Nome      | Versão |                                     Link                                     |
| :-----------: | :----: | :--------------------------------------------------------------------------: |
|    Swagger    | 5.6.3  |     [Swagger](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)     |
|    Dapper     | 2.0.78 |              [Dapper](https://github.com/StackExchange/Dapper)               |
|    DotEnv     | 2.1.3  |            [DotEnv](https://github.com/bolorundurowb/dotenv.net)             |
| Bootstrap CSS | 4.3.1  | [Bootstrap](https://getbootstrap.com/docs/4.3/getting-started/introduction/) |
|  Bootbox.js   | 5.5.2  |             [Bootbox](http://bootboxjs.com/getting-started.html)             |

## Como utilizar

1. Faça o clone do projeto
2. Execute os scripts da pasta _Scripts_, na ordem
3. Restaure os pacotes NuGet e compile a solução
4. No arquivo **.env** localizado no mesmo diretório da solução, altere o texto depois de _CONNECTION_STRING=_ para sua string de conexão com o banco de dados
5. Execute o projeto

> As rotas de comunicação entre os projetos web foram definidas nos arquivos abaixo. Caso haja alguma alteração, é necessário ajustar nesses arquivos:

**VehicleManagement/VehicleManagement.UI/wwwroot/js/site.js:**

```javascript
//Definição das urls
const API_BASE_URL = `https://localhost:44348/api`;
const WEB_BASE_URL = `https://localhost:44367/Vehicles`;
```

**VehicleManagement/.env:**

```.env
API_BASE_URL=https://localhost:44348/api
MVC_BASE_URL=https://localhost:44367/Vehicles
```
