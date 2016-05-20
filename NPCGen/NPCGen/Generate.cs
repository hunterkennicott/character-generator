using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGen
{
    class Generate
    {
        Random rnd = new Random();
        int stat;
        int abMod;
        int hp;        

        public int StatRoll()
        {
            
            int dice = 0;
            
            for (int i = 0; i < 3; i++)
            {
                dice = rnd.Next(1, 7) + dice;
            }
                
            
            stat = dice;

            return stat;
        }

        public int AbilityMod(int statMod)
        {
            switch (statMod)
            {
                case 3:
                    abMod = -4;
                    break;
                case 4:
                    abMod = -3;
                    break;
                case 5:
                    abMod = -3;
                    break;
                case 6:
                    abMod = -2;
                    break;
                case 7:
                    abMod = -2;
                    break;
                case 8:
                    abMod = -1;
                    break;
                case 9:
                    abMod = -1;
                    break;
                case 10:
                    abMod = 0;
                    break;
                case 11:
                    abMod = 0;
                    break;
                case 12:
                    abMod = 1;
                    break;
                case 13:
                    abMod = 1;
                    break;
                case 14:
                    abMod = 2;
                    break;
                case 15:
                    abMod = 2;
                    break;
                case 16:
                    abMod = 3;
                    break;
                case 17:
                    abMod = 3;
                    break;
                case 18:
                    abMod = 4;
                    break;
                case 19:
                    abMod = 4;
                    break;
                case 20:
                    abMod = 5;
                    break;
                default:
                    break;
            }

            return abMod;
        }

        public int HP(string classMods, int conMod)
        {
            if (classMods == "Fighter")
            {
                hp = rnd.Next(1, 11) + conMod;
            }
            else if (classMods == "Sorcerer")
            {
                hp = rnd.Next(1, 5) + conMod;
            }
            else if (classMods == "Rogue")
            {
                hp = rnd.Next(1, 7) + conMod;
            }
            else if (classMods == "Cleric")
            {
                hp = rnd.Next(1, 9) + conMod;
            }
            else
            {

            }

            return hp;
        }

    }
}
