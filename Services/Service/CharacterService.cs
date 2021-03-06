using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet.Dtos;
using dotnet.Model;

namespace dotnet.Services.Service
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;
        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        private static List<Character> characters = new List<Character>
          { new Character(),
           new Character { Id = 1, Name = "sam" } };

        public async Task<ServiceResponse<List<GetCharacterDto>>> create(AddCharacterDto newCharacter)

        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            Character character = _mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c => c.Id) + 1;
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> getSingle(int id)
        {
            var ServiceResponse = new ServiceResponse<GetCharacterDto>();
            //characters.FirstOrDefault(c => c.Id == id);
            ServiceResponse.Data = _mapper.Map<GetCharacterDto>(characters[0]);
            return ServiceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> updatecharacter(UpdateCharacterDto updatedCharacter)
        {
            var ServiceResponse = new ServiceResponse<GetCharacterDto>();
            try
            {
                Character character = characters.FirstOrDefault(c => c.Id == updatedCharacter.Id);

                if (character.Id == 0)
                {
                    character.Name = updatedCharacter.Name;
                    character.Points = updatedCharacter.Points;

                    character.Class = updatedCharacter.Class;


                    ServiceResponse.Data = _mapper.Map<GetCharacterDto>(character);
                }
                else
                {
                    ServiceResponse.Success = false;
                    ServiceResponse.Message = "Character not found.";
                }
            }
            catch (Exception ex)
            {
                ServiceResponse.Success = false;
                ServiceResponse.Message = ex.Message;
            }
            return ServiceResponse;
        }


    }
}
