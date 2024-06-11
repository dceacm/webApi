using Api.Dtos;

namespace Api.Services;

public interface IPersonaService
{
    Persona GetPersonaById(int id);

    ICollection<Persona> Get();
}