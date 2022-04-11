using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Model
{
    public class Character
    {

        public int Id { get; set; }
        public String Name { get; set; } = "GameCharac†er1";
        public int Points { get; set; } = 10;
        public Rpg Class { get; set; } = Rpg.Knights;

    }
}