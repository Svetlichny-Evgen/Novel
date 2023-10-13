namespace Novel
{
    partial class NovelMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            imageLayer = new PictureBox();
            choiseControlPanel1 = new ChoiseControlPanel();
            ((System.ComponentModel.ISupportInitialize)imageLayer).BeginInit();
            SuspendLayout();
            // 
            // imageLayer
            // 
            imageLayer.BackgroundImage = Properties.Resources.Workshop;
            imageLayer.BackgroundImageLayout = ImageLayout.Zoom;
            imageLayer.Dock = DockStyle.Fill;
            imageLayer.Image = Properties.Resources.TalkingEngineer;
            imageLayer.Location = new Point(0, 0);
            imageLayer.Name = "imageLayer";
            imageLayer.Size = new Size(920, 613);
            imageLayer.SizeMode = PictureBoxSizeMode.Zoom;
            imageLayer.TabIndex = 2;
            imageLayer.TabStop = false;
            // 
            // choiseControlPanel1
            // 
            choiseControlPanel1.Dock = DockStyle.Bottom;
            choiseControlPanel1.Location = new Point(0, 388);
            choiseControlPanel1.Margin = new Padding(5, 4, 5, 4);
            choiseControlPanel1.Name = "choiseControlPanel1";
            choiseControlPanel1.Size = new Size(920, 225);
            choiseControlPanel1.TabIndex = 3;
            // 
            // NovelMain
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 613);
            Controls.Add(choiseControlPanel1);
            Controls.Add(imageLayer);
            Font = new Font("MT Extra", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "NovelMain";
            Text = "NovelMain";
            ((System.ComponentModel.ISupportInitialize)imageLayer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private static PictureBox imageLayer;
        private ChoiseControlPanel choiseControlPanel1;
    }
}