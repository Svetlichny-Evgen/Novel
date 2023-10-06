namespace Novel
{
    partial class ChoiseControlPanel
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Choice2 = new Label();
            Choice1 = new Label();
            Event = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(Choice2, 0, 2);
            tableLayoutPanel1.Controls.Add(Choice1, 0, 1);
            tableLayoutPanel1.Controls.Add(Event, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(659, 389);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Choice2
            // 
            Choice2.AutoSize = true;
            Choice2.Dock = DockStyle.Fill;
            Choice2.Location = new Point(3, 202);
            Choice2.Name = "Choice2";
            Choice2.Size = new Size(653, 187);
            Choice2.TabIndex = 2;
            Choice2.Text = "Choice2";
            Choice2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Choice1
            // 
            Choice1.AutoSize = true;
            Choice1.Dock = DockStyle.Fill;
            Choice1.Location = new Point(3, 15);
            Choice1.Name = "Choice1";
            Choice1.Size = new Size(653, 187);
            Choice1.TabIndex = 1;
            Choice1.Text = "Choice1";
            Choice1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Event
            // 
            Event.AutoSize = true;
            Event.Dock = DockStyle.Fill;
            Event.Location = new Point(3, 0);
            Event.Name = "Event";
            Event.Size = new Size(653, 15);
            Event.TabIndex = 0;
            Event.Text = "Event";
            Event.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChoiseControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ChoiseControlPanel";
            Size = new Size(659, 389);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public TableLayoutPanel tableLayoutPanel1;
        public Label Choice2;
        public Label Choice1;
        public Label Event;
    }
}
