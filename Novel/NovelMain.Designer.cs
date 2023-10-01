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
            Event = new Label();
            Choice1 = new Label();
            Choice2 = new Label();
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
            // Event
            // 
            Event.AutoSize = true;
            Event.Location = new Point(470, 0);
            Event.Name = "Event";
            Event.Size = new Size(91, 19);
            Event.TabIndex = 3;
            Event.Text = "label1";
            // 
            // Choice1
            // 
            Choice1.AutoSize = true;
            Choice1.Location = new Point(470, 38);
            Choice1.Name = "Choice1";
            Choice1.Size = new Size(91, 19);
            Choice1.TabIndex = 4;
            Choice1.Text = "label2";
            Choice1.Click += Choice_Click;
            // 
            // Choice2
            // 
            Choice2.AutoSize = true;
            Choice2.Location = new Point(470, 85);
            Choice2.Name = "Choice2";
            Choice2.Size = new Size(91, 19);
            Choice2.TabIndex = 5;
            Choice2.Text = "label3";
            Choice2.Click += Choice_Click;
            // 
            // NovelMain
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 613);
            Controls.Add(Choice2);
            Controls.Add(Choice1);
            Controls.Add(Event);
            Controls.Add(imageLayer);
            Font = new Font("MT Extra", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "NovelMain";
            Text = "NovelMain";
            ((System.ComponentModel.ISupportInitialize)imageLayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox imageLayer;
        private Label Event;
        private Label Choice1;
        private Label Choice2;
    }
}