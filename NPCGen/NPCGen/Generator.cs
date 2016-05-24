using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGen.Generate
{
    public abstract class Generator
    {
        private Random rnd = new Random();
        private int minRoll = 1;
        private int rolledNumber = 0;

        public int GetStatRoll()
        {
            int dicerolls = 3;
            int stat = 0;
            
            for (int i = 0; i < dicerolls; i++)
            {
                stat += RollDSix();
            }

            return stat;
        }

        public int GetAbilityMod(int statMod)
        {
            int abilityModifier;
            switch (statMod)
            {
                case 3:
                    abilityModifier = -4;
                    break;
                case 4:
                case 5:
                    abilityModifier = -3;
                    break;
                case 6:
                case 7:
                    abilityModifier = -2;
                    break;
                case 8:
                case 9:
                    abilityModifier = -1;
                    break;
                case 10:
                case 11:
                    abilityModifier = 0;
                    break;
                case 12:
                case 13:
                    abilityModifier = 1;
                    break;
                case 14:
                case 15:
                    abilityModifier = 2;
                    break;
                case 16:
                case 17:
                    abilityModifier = 3;
                    break;
                case 18:
                case 19:
                    abilityModifier = 4;
                    break;
                case 20:
                    abilityModifier = 5;
                    break;
                default:
                    throw new ArgumentException();
                    break;
            }

            return abilityModifier;
        }

        public abstract int GetHP(int conMod);
        public abstract int GetBaseAttackBonus(int baseAttackBonus);
        public abstract int FortMod(int fortitude);
        public abstract int ReflexMod(int reflex);
        public abstract int WillMod(int will);
        public abstract int ZeroSpells(int zeroSpells);
        public abstract int FirstSpells(int firstSpells, int bonusSpells);

        protected int RollDFour()
        {
            int maxRoll = 4;
            rolledNumber = rnd.Next(minRoll, maxRoll);
            return rolledNumber;
        }

        protected int RollDSix()
        {
            int maxRoll = 6;
            rolledNumber = rnd.Next(minRoll, maxRoll);
            return rolledNumber;
        }

        protected int RollDEight()
        {
            int maxRoll = 8;
            rolledNumber = rnd.Next(minRoll, maxRoll);
            return rolledNumber;
        }

        protected int RollDTen()
        {
            int maxRoll = 10;
            rolledNumber = rnd.Next(minRoll, maxRoll);
            return rolledNumber;
        }

    }
}
