namespace Novel
{
    partial class PlayerPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            head = new PictureBox();
            body = new PictureBox();
            legs = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)head).BeginInit();
            ((System.ComponentModel.ISupportInitialize)body).BeginInit();
            ((System.ComponentModel.ISupportInitialize)legs).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // head
            // 
            head.BackgroundImageLayout = ImageLayout.Zoom;
            head.Dock = DockStyle.Fill;
            head.Image = Properties.Resources.image_part_001;
            head.Location = new Point(0, 0);
            head.Margin = new Padding(0);
            head.Name = "head";
            head.Size = new Size(275, 106);
            head.SizeMode = PictureBoxSizeMode.StretchImage;
            head.TabIndex = 0;
            head.TabStop = false;
            // 
            // body
            // 
            body.BackgroundImageLayout = ImageLayout.Zoom;
            body.Dock = DockStyle.Fill;
            body.Image = Properties.Resources.image_part_002;
            body.Location = new Point(0, 106);
            body.Margin = new Padding(0);
            body.Name = "body";
            body.Size = new Size(275, 106);
            body.SizeMode = PictureBoxSizeMode.StretchImage;
            body.TabIndex = 1;
            body.TabStop = false;
            // 
            // legs
            // 
            legs.BackgroundImageLayout = ImageLayout.Zoom;
            legs.Dock = DockStyle.Fill;
            legs.Image = Properties.Resources.image_part_003;
            legs.Location = new Point(0, 212);
            legs.Margin = new Padding(0);
            legs.Name = "legs";
            legs.Size = new Size(275, 106);
            legs.SizeMode = PictureBoxSizeMode.StretchImage;
            legs.TabIndex = 2;
            legs.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(head, 0, 0);
            tableLayoutPanel1.Controls.Add(legs, 0, 2);
            tableLayoutPanel1.Controls.Add(body, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(275, 318);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // PlayerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PlayerPanel";
            Size = new Size(275, 318);
            ((System.ComponentModel.ISupportInitialize)head).EndInit();
            ((System.ComponentModel.ISupportInitialize)body).EndInit();
            ((System.ComponentModel.ISupportInitialize)legs).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox head;
        private PictureBox body;
        private PictureBox legs;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
