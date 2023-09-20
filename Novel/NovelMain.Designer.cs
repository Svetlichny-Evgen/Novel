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
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Choice2 = new Label();
            Event = new Label();
            Choice1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Workshop;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.TalkingEngineer;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(920, 613);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Choice2, 0, 2);
            tableLayoutPanel1.Controls.Add(Event, 0, 0);
            tableLayoutPanel1.Controls.Add(Choice1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Font = new Font("Goudy Stout", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 408);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(920, 205);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Choice2
            // 
            Choice2.Anchor = AnchorStyles.None;
            Choice2.AutoSize = true;
            Choice2.Location = new Point(386, 147);
            Choice2.Name = "Choice2";
            Choice2.Size = new Size(147, 26);
            Choice2.TabIndex = 2;
            Choice2.Tag = "2";
            Choice2.Text = "label3";
            Choice2.TextAlign = ContentAlignment.MiddleCenter;
            Choice2.Click += Choice2_Click;
            // 
            // Event
            // 
            Event.Anchor = AnchorStyles.None;
            Event.AutoSize = true;
            Event.Location = new Point(386, 0);
            Event.Name = "Event";
            Event.Size = new Size(147, 26);
            Event.TabIndex = 0;
            Event.Text = "label1";
            Event.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Choice1
            // 
            Choice1.Anchor = AnchorStyles.None;
            Choice1.AutoSize = true;
            Choice1.Location = new Point(386, 57);
            Choice1.Name = "Choice1";
            Choice1.Size = new Size(147, 26);
            Choice1.TabIndex = 1;
            Choice1.Tag = "1";
            Choice1.Text = "label2";
            Choice1.TextAlign = ContentAlignment.MiddleCenter;
            Choice1.Click += Choice1_Click;
            // 
            // NovelMain
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 613);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Font = new Font("MT Extra", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "NovelMain";
            Text = "NovelMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Choice2;
        private Label Event;
        private Label Choice1;
    }
}