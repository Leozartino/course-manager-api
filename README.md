# Gerenciador de Cursos REST API ASP .NET Core 5

<div align="center">

  <a href="">[![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)</a>
  <a href="">[![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-5.0)</a>
</div>



<p align="center">
   <a href="#" target="blank"><img style="border-radius:50px;" src="https://media.discordapp.net/attachments/832452168111489045/952386516762656828/open-book_1.png"           alt="Course Logo"/></a>
</p>



## 💻 Pré-requisitos

Antes de começar, verifique se você atendeu aos seguintes requisitos:
* Você instalou a versão do ASP .NET Core 5.0 [SDK 5.0.405](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* Você tem uma máquina `<Windows / Linux / Mac>`. O projeto foi desenvolvido no Windows 10
* Você possui instalado o [SQLServer Express 2016](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15)
* Opcional [SQLServer Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
* Opcional [Postman](https://www.postman.com/downloads/)

## 🚀 Rodando o projeto Gerenciador_de_cursos

Dentro da pasta do projeto Gerenciador_de_cursos, siga estas etapas:

CLI (Windows / Linux):
```bash
dotnet restore
dotnet build
dotnet run
```

Acesso o link em: https://localhost:50001/api
ou http://localhost:5000/api


## ⬆️ Requisições e Respostas ⬇️ [User]

| API  | Descrição | Request Body  | Response Body |
| ------------- | ------------- | ------------- | ------------- |
| GET /api/users/index | Retorna todos os users | None | Array de users |
| GET /api/users/show/{id}  | Retorna um user via Id | None  | Um json do tipo user  |
| POST /api/users/create  | Add um novo user | UserCreateDTO item  | Json do tipo User |
| PUT /api/users/update/{id}  | Atualiza um user | UserUpdateDTO item  | Json do tipo User |
| DELETE /api/users/delete/{id}  | Deleta um user | None  | Mensagem de confirmação em json |


## ⬆️ Requisições e Respostas ⬇️ [Course]

| API  | Descrição | Request Body  | Response Body |
| ------------- | ------------- | ------------- | ------------- |
| GET /api/courses/index | Retorna todos os courses | None | Array de courses |
| GET /api/courses/show/{id}  | Retorna um course via Id | None  | Json do tipo Course  |
| POST /api/courses/create  | Add um novo course | CourseCreateDTO item  | Json do tipo CourseResponseDTO |
| PUT /api/courses/update/date/{id}  | Atualiza as datas de um course via id | CourseUpdateDTO item | Json do tipo CourseResponseDTO |
| PATCH /api/courses/update/status/{id}  | Atualiza o status de um course | StatusCourseEnum item  | Json do tipo CourseResponseDTO |
| PATCH /api/courses/update/title/{id}  | Atualiza o titulo de um course | string item  | Json do tipo CourseResponseDTO |

| DELETE /api/courses/delete/{id}  | Deleta um course | None  | Mensagem de confirmação em json |


## Status Code usados no projeto

| StatusCode  | Descrição | 
| ------------- | ------------- | 
| 200 🟢| Sucess | 
| 201 🟢| Created |
| 400 🟡| Bad Request | 
| 401 🟡| Unauthorized | 
| 403 🟡| Forbidden |
| 404 🟡| Not Found | 
| 500 🔴| Internal Server Error | 


## ✍️ Autor

Feito por mim :)

<table>
    <td align="center">
      <a href="#">
        <img src="https://avatars.githubusercontent.com/u/38565099?v=4" width="100px;" alt="Leo"/><br>
        <sub>
          <b>Leonardo Oliveira</b>
        </sub>
      </a>
    <td align="center">
</table>

## 📝 Licença

Esse projeto está sob licença. Veja o arquivo [MIT](https://choosealicense.com/licenses/mit/) para mais detalhes.
