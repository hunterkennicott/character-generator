﻿using System;
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
            return RollDFour() + conMod;
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
    }
}
