using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGen.Generate
{
    public class FighterGenerator : Generator
    {

        public override int GetHP(int conMod)
        {
            return RollDTen() + conMod;
        }

        public override int GetBaseAttackBonus(int baseAttackBonus)
        {
            return baseAttackBonus = 1;
        }

        public override int FortMod(int fortitude)
        {
            return fortitude = 2;
        }

        public override int ReflexMod(int reflex)
        {
            return reflex = 0;
        }

        public override int WillMod(int will)
        {
            return will = 0;
        }
    }
}
