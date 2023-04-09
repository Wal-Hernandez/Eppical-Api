# EppicalApi

Este es un proyecto de ejemplo de una API REST desarrollada en .NET Core 3.1 utilizando una base de datos in-memory, AutoMapper y Swagger.

## Requisitos

Para poder correr este proyecto es necesario tener instalado:

- .NET Core 3.1 SDK
- Visual Studio (opcional)

## Instalación

1. Clonar el repositorio o descargar el código fuente.
2. Abrir la solución `EppicalApi.sln` en Visual Studio Code o en Visual Studio.
3. En Visual Studio, seleccionar el proyecto `EppicalApi` como proyecto de inicio y correr la aplicación.
4. Abrir un navegador y acceder a la URL `https://localhost:5001/swagger` para visualizar la documentación de la API.

## Endpoints

La API contiene los siguientes endpoints:

### Librerías

- `GET /api/libraries/{id}`: Obtiene una librería por su identificador.
- `POST /api/libraries`: Agrega una nueva librería.
- `DELETE /api/libraries/{id}`: Elimina una librería por su identificador.

### Libros

- `GET /api/libraries/{libraryId}/books`: Obtiene todos los libros de una librería por su identificador.
- `POST /api/libraries/{libraryId}/books`: Agrega un libro a una librería por su identificador.


