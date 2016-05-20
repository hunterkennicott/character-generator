using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGen
{
    class Modifiers
    {
        public int BabMod(string classMod, int bab)
        {
            if (classMod == "Fighter")
            {
                bab = 1;
            }
            else if (classMod == "Sorcerer")
            {
                bab = 0;
            }
            else if (classMod == "Rogue")
            {
                bab = 0;
            }
            else if (classMod == "Cleric")
            {
                bab = 0;
            }
            else
            {

            }

            return bab;
        }

        public int FortMod(string classMod, int fort)
        {
            if (classMod == "Fighter")
            {
                fort = 2;
            }
            else if (classMod == "Sorcerer")
            {
                fort = 0;
            }
            else if (classMod == "Rogue")
            {
                fort = 0;
            }
            else if (classMod == "Cleric")
            {
                fort = 2;
            }
            else
            {

            }

            return fort;
        }

        public int ReflexMod(string classMod, int reflex)
        {
            if (classMod == "Fighter")
            {
                reflex = 0;
            }
            else if (classMod == "Sorcerer")
            {
                reflex = 0;
            }
            else if (classMod == "Rogue")
            {
                reflex = 2;
            }
            else if (classMod == "Cleric")
            {
                reflex = 0;
            }
            else
            {

            }

            return reflex;
        }

        public int WillMod(string classMod, int will)
        {
            if (classMod == "Fighter")
            {
                will = 0;
            }
            else if (classMod == "Sorcerer")
            {
                will = 2;
            }
            else if (classMod == "Rogue")
            {
                will = 0;
            }
            else if (classMod == "Cleric")
            {
                will = 2;
            }
            else
            {

            }

            return will;
        }
    }
}
