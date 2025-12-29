using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay17
{
    internal class Game_Character : ICloneable
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public List<string> Skills { get; set; }
        public Game_Character()
        {
            Skills = new List<string>();
        }
        public object Clone()
        {
            Game_Character game_Character = (Game_Character)this.MemberwiseClone();
            game_Character.Skills = new List<string>(this.Skills);
            return game_Character;
        }
        public void ShowData(string name)
        {
            Console.WriteLine($"\n{name}");
            Console.WriteLine($"Health : {Health}");
            Console.WriteLine($"Attack : {Attack}");
            Console.WriteLine($"Defense : {Defense}");
            Console.WriteLine("Skills : " + string.Join(",", Skills));
        }
    }
}
