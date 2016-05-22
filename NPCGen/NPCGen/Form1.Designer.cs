namespace NPCGen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.raceBox = new System.Windows.Forms.ComboBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.race = new System.Windows.Forms.Label();
            this.npcClass = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Pristina", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(36, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(350, 104);
            this.title.TabIndex = 17;
            this.title.Text = "Dungeons and Dragons \r\n3.5 NPC Generator";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(918, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "x";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(117, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 57);
            this.button1.TabIndex = 15;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // classBox
            // 
            this.classBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.classBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(117, 247);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(229, 33);
            this.classBox.TabIndex = 14;
            // 
            // raceBox
            // 
            this.raceBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.raceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceBox.FormattingEnabled = true;
            this.raceBox.Location = new System.Drawing.Point(117, 208);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(229, 33);
            this.raceBox.TabIndex = 13;
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.PapayaWhip;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(117, 170);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(300, 31);
            this.nameInput.TabIndex = 12;
            // 
            // race
            // 
            this.race.AutoSize = true;
            this.race.BackColor = System.Drawing.Color.Transparent;
            this.race.Font = new System.Drawing.Font("Pristina", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(36, 206);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(78, 44);
            this.race.TabIndex = 11;
            this.race.Text = "Race";
            // 
            // npcClass
            // 
            this.npcClass.AutoSize = true;
            this.npcClass.BackColor = System.Drawing.Color.Transparent;
            this.npcClass.Font = new System.Drawing.Font("Pristina", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcClass.Location = new System.Drawing.Point(38, 245);
            this.npcClass.Name = "npcClass";
            this.npcClass.Size = new System.Drawing.Size(77, 44);
            this.npcClass.TabIndex = 10;
            this.npcClass.Text = "Class";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Pristina", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(24, 167);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(90, 44);
            this.name.TabIndex = 9;
            this.name.Text = "Name";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.output.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(443, 42);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(492, 358);
            this.output.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NPCGen.Properties.Resources.scroll;
            this.ClientSize = new System.Drawing.Size(947, 456);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.raceBox);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.race);
            this.Controls.Add(this.npcClass);
            this.Controls.Add(this.name);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPCGen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.ComboBox raceBox;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label race;
        private System.Windows.Forms.Label npcClass;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox output;
    }
}

