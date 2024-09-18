# Actividad 01 API RESTful CRUD de tareas con ASP.NET Core 8, MySQL y Docker

Este proyecto es una API RESTful construida con **ASP.NET Core 8** y **MySQL** como base de datos, empaquetado con **Docker** para facilitar la configuración y el uso de mysql en entornos de desarrollo y producción.

## Requisitos previos

Antes de clonar y ejecutar este proyecto, asegúrate de tener instalados los siguientes requisitos:

- **.NET 8 SDK**: [Descargar e instalar .NET 8 SDK](https://dotnet.microsoft.com/download)
- **Docker**: [Descargar e instalar Docker](https://www.docker.com/get-started)
- **Git**: [Descargar e instalar Git](https://git-scm.com/)

## Clonar el proyecto

Primero, clona este repositorio en tu máquina local y accede a la rama `actividad-01`:

```bash
git clone https://github.com/tu-usuario/tu-repositorio.git
git checkout actividad-01
```
## Ejecutar el proyecto
Primero debes correr el servicio de base de datos MySQL en tu máquina local, ejecutando el siguiente comando en la terminal:

```bash
docker-compose up -d
```

Una vez que se haya ejecutado el servicio de base de datos, puedes correr el proyecto de la actividad en la terminal:

```bash
dotnet run
```


## Administrar tareas 
- ** Swagger **: [acceder a la documentacion de la API RESTful](http://localhost:5097/swagger/index.html)
