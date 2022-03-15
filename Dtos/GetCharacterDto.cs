using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Model;

namespace dotnet.Dtos
{
    public class GetCharacterDto
    {
        public int Id { get; set; } = 0;
        public String Name { get; set; } = "GameCharac†er1";
        public int Points { get; set; } = 10;
        public Rpg Class { get; set; } = Rpg.Knights;
    }
}