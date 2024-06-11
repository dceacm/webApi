using Api.Dtos;

namespace Api.Services;

public class PersonaService : IPersonaService
{
    private static readonly List<Persona> Persons = new()
    {
        new Persona { Id = 1, FirstName = "Nombre1", LastName = "Apellido1", DateOfBirth = DateTime.Today },
        new Persona { Id = 2, FirstName = "Nombre2", LastName = "Apellido2", DateOfBirth = DateTime.Today },
        new Persona { Id = 3, FirstName = "Nombre3", LastName = "Apellido3", DateOfBirth = DateTime.Today },
        new Persona { Id = 4, FirstName = "Nombre4", LastName = "Apellido4", DateOfBirth = DateTime.Today }
    };

    public PersonaService()
    {
    }

    public Persona GetPersonaById(int id)
    {
        return Persons.First(p => p.Id == id);
    }

    public ICollection<Persona> Get()
    {
        return Persons;
    }
}