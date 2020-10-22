using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGen.Generate
{
    public class SorcererGenerator : Generator
    {
        public override int GetHP(int conMod)
        {
            //return RollDFour() + conMod;

            return 4 + conMod;
        }

        public override int GetBaseAttackBonus(int baseAttackBonus)
        {
            return baseAttackBonus = 0;
        }

        public override int FortMod(int fortitude)
        {
            return fortitude = 0;
        }

        public override int ReflexMod(int reflex)
        {
            return reflex = 0;
        }

        public override int WillMod(int will)
        {
            return will = 2;
        }

        public override int ZeroSpells(int zeroSpells)
        {
            return zeroSpells = 5;
        }

        public override int FirstSpells(int firstSpells, int cha)
        {
            firstSpells = 3;

            if (cha >= 14 && cha <= 17)
            {
                firstSpells = 0;
                firstSpells = 4;
            }
            else if (cha >= 18 && cha <= 21)
            {
                firstSpells = 0;
                firstSpells = 5;
            }

            return firstSpells;
        }
    }
}
