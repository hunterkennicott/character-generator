using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGen.Generate
{
    public static class GeneratorFactory
    {
        public static Generator GetGenerator(string className)
        {
            if ("Fighter".Equals(className)) 
            {
                return new FighterGenerator();
            }
            else if ("Sorcerer".Equals(className))
            {
                return new SorcererGenerator();
            }
            else if ("Rogue".Equals(className))
            {
                return new RogueGenerator();
            }
            else if ("Cleric".Equals(className))
            {
                return new ClericGenerator();
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
