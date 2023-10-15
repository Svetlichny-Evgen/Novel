namespace Novel
{
    partial class Fight
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
            dice = new Components.DiceComponent();
            helthPlayer = new Components.HelthBar();
            helthEnemy = new Components.HelthBar();
            SuspendLayout();
            // 
            // dice
            // 
            dice.Location = new Point(565, 265);
            dice.Margin = new Padding(5, 4, 5, 4);
            dice.Name = "dice";
            dice.Size = new Size(150, 150);
            dice.TabIndex = 0;
            // 
            // helthPlayer
            // 
            helthPlayer.FirstColor = Color.Red;
            helthPlayer.LastColor = Color.Silver;
            helthPlayer.Location = new Point(14, 46);
            helthPlayer.Margin = new Padding(5, 4, 5, 4);
            helthPlayer.Name = "helthPlayer";
            helthPlayer.Revers = false;
            helthPlayer.Size = new Size(364, 35);
            helthPlayer.TabIndex = 1;
            helthPlayer.Value = 100F;
            // 
            // helthEnemy
            // 
            helthEnemy.FirstColor = Color.Red;
            helthEnemy.LastColor = Color.Silver;
            helthEnemy.Location = new Point(911, 46);
            helthEnemy.Margin = new Padding(5, 4, 5, 4);
            helthEnemy.Name = "helthEnemy";
            helthEnemy.Revers = true;
            helthEnemy.Size = new Size(364, 35);
            helthEnemy.TabIndex = 2;
            helthEnemy.Value = 100F;
            // 
            // Fight
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 613);
            Controls.Add(helthEnemy);
            Controls.Add(helthPlayer);
            Controls.Add(dice);
            Font = new Font("MT Extra", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Fight";
            Text = "Fight";
            Load += Fight_Load;
            ResumeLayout(false);
        }

        #endregion

        private Components.DiceComponent dice;
        private Components.HelthBar helthPlayer;
        private Components.HelthBar helthEnemy;
    }
}