using Api.Dtos;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PersonaController : BaseController
{
    private readonly IPersonaService _personaService;

    public PersonaController(IPersonaService personService)
    {
        _personaService = personService;
    }

    [HttpGet("{id}")]
    public ActionResult<Persona> GetPersonById(int id)
    {
        var person = _personaService.GetPersonaById(id);
        if (person == null)
        {
            return NotFound(GetNotFoundProblemDetails());
        }
        return Ok(person);
    }

    [HttpGet]
    public ActionResult<ICollection<Persona>> Get()
    {
        var persons = _personaService.Get();
        if (!persons.Any())
        {
            return NotFound(GetNotFoundProblemDetails());
        }
        return Ok(persons);
    }

    [HttpGet("GetNotFound")]
    public IActionResult GetNotFound() => NotFound(GetNotFoundProblemDetails());

    [HttpGet("GetBadRequest")]
    public IActionResult GetBadRequest() => BadRequest(GetBadRequestProblemDetails());

    [HttpGet("GetUnauthorized")]
    public IActionResult GetUnauthorized() => Unauthorized(GetUnauthorizedProblemDetails());
}