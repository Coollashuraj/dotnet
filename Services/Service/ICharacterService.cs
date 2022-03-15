using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Dtos;
using dotnet.Model;

namespace dotnet.Services.Service
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> getSingle(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> create(AddCharacterDto newCharacter);
    }
}