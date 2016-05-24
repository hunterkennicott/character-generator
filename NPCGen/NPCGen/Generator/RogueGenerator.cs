using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGen.Generate
{
    public class RogueGenerator : Generator
    {
        public override int GetHP(int conMod)
        {
            return RollDSix() + conMod;
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
            return reflex = 2;
        }

        public override int WillMod(int will)
        {
            return will = 0;
        }

        public override int ZeroSpells(int zeroSpells)
        {
            return zeroSpells = 0;
        }

        public override int FirstSpells(int firstSpellsSorc, int cha)
        {
            return firstSpellsSorc = 0;
        }
    }
}
