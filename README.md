# Vehicle Management

Projeto que permite realizar um CRUD de veículos, comunicando uma aplicação web MCV com uma API, ambas construídas com C#.

## Tecnologias

- Swagger
- Dapper
- DotEnv
- Bootstrap CSS
- Bootbox.js

## Como utilizar

1. Faça o clone do projeto
2. Execute os scripts da pasta _Scripts_, na ordem
3. Restaure os pacotes NuGet e compile a solução
4. No arquivo **.env** localizado no mesmo diretório da solução, altere o texto depois de _CONNECTION_STRING=_ para sua string de conexão com o banco de dados
5. Execute o projeto

> Defini as rotas de comunicação nos arquivos abaixo. Caso haja alguma alteração, é necessário ajustar nesses arquivos:

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
