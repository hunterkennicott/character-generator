using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPCGen.Generate;

namespace NPCGen
{
    public partial class Form1 : Form
    {
        private int str, 
            dex, 
            con, 
            intel, 
            wis, 
            cha, 
            hp, 
            baseAttackBonus, 
            fort, 
            reflex, 
            will, 
            strAbMod, 
            dexAbMod, 
            conAbMod, 
            intelAbMod, 
            wisAbMod, 
            chaAbMod,
            zeroSpells,
            firstSpells;

        public Form1()
        {
            InitializeComponent();
        }

        //Drag screen
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //Finish drag screen

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RaceData();
            ClassData();

            //Store NPC name input
            string name = nameInput.Text;
        }

        //Populate race combobox
        public void RaceData()
        {
            var npcRace = new List<RaceClass>();
            npcRace.Add(new RaceClass() { NPCRace = "Human", RaceValue = "human" });
            npcRace.Add(new RaceClass() { NPCRace = "Elf", RaceValue = "elf" });
            npcRace.Add(new RaceClass() { NPCRace = "Dwarf", RaceValue = "dwarf" });
            npcRace.Add(new RaceClass() { NPCRace = "Halfling", RaceValue = "halfling" });

            this.raceBox.DataSource = npcRace;
            this.raceBox.DisplayMember = "NPCRace";
            this.raceBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Populate class combobox
        public void ClassData()
        {
            var npcClass = new List<RaceClass>();
            npcClass.Add(new RaceClass() { NPCClass = "Fighter", ClassValue = "fighter" });
            npcClass.Add(new RaceClass() { NPCClass = "Sorcerer", ClassValue = "sorc" });
            npcClass.Add(new RaceClass() { NPCClass = "Rogue", ClassValue = "rogue" });
            npcClass.Add(new RaceClass() { NPCClass = "Cleric", ClassValue = "cleric" });

            this.classBox.DataSource = npcClass;
            this.classBox.DisplayMember = "NPCClass";
            this.classBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Clear();
            PrintData();
        }

        private void PrintData()
        {
            ExecuteGen();

            output.AppendText(
                "Name: " + nameInput.Text +
                "\r\nLevel: 1" + "                                HP: " + hp +
                "\r\nRace: " + raceBox.Text + "                    Base Attack Bonus: " + baseAttackBonus +
                "\r\nClass: " + classBox.Text + "                    Fort: " + fort +
                "\r\nAttributes:" + "                         Reflex: " + reflex
            );

            RaceMod();
            SpellCount();            
            
            output.AppendText(
                "\r\nDEX: " + dex + " (" + dexAbMod + ")" + "                    Will: " + will +
                "\r\nSTR: " + str + " (" + strAbMod + ")" +
                "\r\nCON: " + con + " (" + conAbMod + ")" + "                    Spells: " + 
                "\r\nINT: " + intel + " (" + intelAbMod + ")" + "                            0 Level: " + zeroSpells +
                "\r\nWIS: " + wis + " (" + wisAbMod + ")" + "                         1st Level: " + firstSpells +
                "\r\nCHA: " + cha + " (" + chaAbMod + ")"
            );
        }

        private void RaceMod()
        {
            if (raceBox.Text == "Dwarf")
            {
                con = con + 2;
                cha = cha - 2;
            }
            else if (raceBox.Text == "Elf")
            {
                dex = dex + 2;
                con = con - 2;
            }
            else if (raceBox.Text == "Halfling")
            {
                dex = dex + 2;
                str = str - 2;
            }
        }

        private void SpellCount()
        {
            if (classBox.Text == "Sorcerer")
            {
                zeroSpells = 0;
                zeroSpells = zeroSpells + 5;
                firstSpells = 0;
                firstSpells = firstSpells + 3;
                
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
            }
            else if (classBox.Text == "Cleric")
            {
                zeroSpells = 0;
                zeroSpells = zeroSpells + 3;
                firstSpells = 0;
                firstSpells = firstSpells + 1;

                if (wis >= 14 && wis <= 17)
                {
                    firstSpells = 0;
                    firstSpells = 2;
                }
                else if (wis >= 18 && wis <= 21)
                {
                    firstSpells = 0;
                    firstSpells = 3;
                }
            }
            else
            {
                zeroSpells = 0;
                firstSpells = 0;
            }
        }

        private void ExecuteGen()
        {
            Generator execute = GeneratorFactory.GetGenerator(classBox.Text);

            //stats
            str = execute.GetStatRoll();
            dex = execute.GetStatRoll();
            con = execute.GetStatRoll();
            intel = execute.GetStatRoll();
            wis = execute.GetStatRoll();
            cha = execute.GetStatRoll();

            //ability modifiers
            strAbMod = execute.GetAbilityMod(str);
            dexAbMod = execute.GetAbilityMod(dex);
            conAbMod = execute.GetAbilityMod(con);
            intelAbMod = execute.GetAbilityMod(intel);
            wisAbMod = execute.GetAbilityMod(wis);
            chaAbMod = execute.GetAbilityMod(cha);

            //hp and saving throws
            hp = execute.GetHP(conAbMod);
            baseAttackBonus = execute.GetBaseAttackBonus(baseAttackBonus);
            fort = execute.FortMod(fort);
            reflex = execute.ReflexMod(reflex);
            will = execute.WillMod(will);
        }
    }
}
