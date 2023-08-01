# Course Manager REST API ASP .NET Core 5

<div align="center">

  <a href="">[![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)</a>
  <a href="">[![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-5.0)</a>
</div>



<p align="center">
   <a href="#" target="blank"><img style="border-radius:50px;" src="https://media.discordapp.net/attachments/832452168111489045/952386516762656828/open-book_1.png"           alt="Course Logo"/></a>
     <a href="#" target="blank"><img style="border-radius:50px;" src="https://media.discordapp.net/attachments/832452168111489045/952709797734662144/teacher_1.png"           alt="Professor Logo"/></a>
</p>



## 💻 Prerequisites
Before you begin, make sure you meet the following requirements:

* You have installed the ASP .NET Core 5.0 [SDK 5.0.405](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* You have a <Windows / Linux / Mac> machine. The project was developed on Windows 10
* You have installed [SQLServer Express 2016](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15)
* Optional [SQLServer Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
* Optional [Postman](https://www.postman.com/downloads/)

## 🚀 Running the Course Manager project

Inside the Gerenciador_de_cursos project folder, follow these steps:

CLI (Windows / Linux):

```bash
dotnet restore
dotnet build
dotnet run
```

Access the link at: https://localhost:50001/api or http://localhost:5000/api

⬆️ Requests and Responses ⬇️ [User]


## ⬆️ Requisições e Respostas ⬇️ [User]

| API	| Description	| Request |	Response Body |
| ------------- | ------------- | ------------- | ------------- |
| GET /api/users/index | Retorna todos os users | None | Array de User |
| GET /api/users/show/{id}  | Retorna um user via id | Guid item  | Json do tipo User  |
| POST /api/users/create  | Add um novo user | UserCreateDTO item  | Json do tipo User |
| PUT /api/users/update/{id}  | Atualiza um user via id | UserUpdateDTO item  | Json do tipo User |
| DELETE /api/users/delete/{id}  | Deleta um user via id | Guid item  | Json do tipo DeleteResponseDTO |


## ⬆️ Requisições e Respostas ⬇️ [Course]

| API  | Description | Request | Response Body |
| ------------- | ------------- | ------------- | ------------- |
| GET /api/courses/index | Retorna todos os courses | None | Array de CourseResponseDTO |
| GET /api/courses/show/{id}  | Retorna um course via Id | Guid item  | Json do tipo CourseResponseDTO  |
| POST /api/courses/create  | Add um novo course | CourseCreateDTO item  | Json do tipo CourseResponseDTO |
| PUT /api/courses/update/date/{id}  | Atualiza as datas de um course via id | CourseUpdateDTO item | Json do tipo CourseResponseDTO |
| PATCH /api/courses/update/status/{id}  | Atualiza o status de um course via id| StatusCourseEnum item  | Json do tipo CourseResponseDTO |
| PATCH /api/courses/update/title/{id}  | Atualiza o titulo de um course via id | Guid item  | Json do tipo CourseResponseDTO |
| DELETE /api/courses/delete/{id}  | Deleta um course via id | Guid item  | Json do tipo DeleteResponseDTO |


## Tables Diagram

<div align="center">
     <a href="#" target="blank"><img style="border-radius:50px;" src="https://media.discordapp.net/attachments/832452168111489045/952752177867288656/diagramas.PNG"           alt="Diagrama"/></a>
</div>

## Status Codes used in the project

| StatusCode  | Description | 
| ------------- | ------------- | 
| 200 🟢| Sucess | 
| 201 🟢| Created |
| 400 🟡| Bad Request | 
| 401 🟡| Unauthorized | 
| 403 🟡| Forbidden |
| 404 🟡| Not Found | 
| 500 🔴| Internal Server Error | 


## ✍️ Author

Made by me, with love ❤️ :)

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

## 📝 License

This project is under a license. See the MIT file for more details. [MIT](https://choosealicense.com/licenses/mit/) para mais detalhes.
