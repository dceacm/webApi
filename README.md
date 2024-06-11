# webApi
Web API ASP.NET Core 8 de *personas* para realizar pruebas desde un frontal con los GET y Status Code (400, 401, 404) más comunes. 

- No tiene conexión con ninguna base de datos, los datos son consumidos desde un service.
- La devolución de los Status Code es mediante objetos de tipo **ProblemDetails**

Endpoints que actualmente ofrece:
- /api/v1/Persona/{id}
- /api/v1/Persona
- /api/v1/Persona/GetNotFound
- /api/v1/Persona/GetBadRequest
- /api/v1/Persona/GetUnauthorized
