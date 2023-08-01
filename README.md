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

## ⬆️ Requests and Responses ⬇️ [User]

| API  | Description | Request | Response Body |
| ------------- | ------------- | ------------- | ------------- |
| GET /api/users/index | Returns all users | None | Array of User |
| GET /api/users/show/{id}  | Returns a user via id | Guid item  | JSON of type User  |
| POST /api/users/create  | Adds a new user | UserCreateDTO item  | JSON of type User |
| PUT /api/users/update/{id}  | Updates a user via id | UserUpdateDTO item  | JSON of type User |
| DELETE /api/users/delete/{id}  | Deletes a user via id | Guid item  | JSON of type DeleteResponseDTO |

## ⬆️ Requests and Responses ⬇️ [Course]

| API  | Description | Request | Response Body |
| ------------- | ------------- | ------------- | ------------- |
| GET /api/courses/index | Returns all courses | None | Array of CourseResponseDTO |
| GET /api/courses/show/{id}  | Returns a course via Id | Guid item  | JSON of type CourseResponseDTO  |
| POST /api/courses/create  | Adds a new course | CourseCreateDTO item  | JSON of type CourseResponseDTO |
| PUT /api/courses/update/date/{id}  | Updates the dates of a course via id | CourseUpdateDTO item | JSON of type CourseResponseDTO |
| PATCH /api/courses/update/status/{id}  | Updates the status of a course via id | StatusCourseEnum item  | JSON of type CourseResponseDTO |
| PATCH /api/courses/update/title/{id}  | Updates the title of a course via id | Guid item  | JSON of type CourseResponseDTO |
| DELETE /api/courses/delete/{id}  | Deletes a course via id | Guid item  | JSON of type DeleteResponseDTO |


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
