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
            lbChoice2 = new Label();
            lbChoice1 = new Label();
            lbEvent = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lbChoice2, 0, 2);
            tableLayoutPanel1.Controls.Add(lbChoice1, 0, 1);
            tableLayoutPanel1.Controls.Add(lbEvent, 0, 0);
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
            // lbChoice2
            // 
            lbChoice2.AutoSize = true;
            lbChoice2.Dock = DockStyle.Fill;
            lbChoice2.Location = new Point(3, 202);
            lbChoice2.Name = "lbChoice2";
            lbChoice2.Size = new Size(653, 187);
            lbChoice2.TabIndex = 2;
            lbChoice2.Text = "Choice2";
            lbChoice2.TextAlign = ContentAlignment.MiddleCenter;
            lbChoice2.Click += Choice_Click;
            // 
            // lbChoice1
            // 
            lbChoice1.AutoSize = true;
            lbChoice1.Dock = DockStyle.Fill;
            lbChoice1.Location = new Point(3, 15);
            lbChoice1.Name = "lbChoice1";
            lbChoice1.Size = new Size(653, 187);
            lbChoice1.TabIndex = 1;
            lbChoice1.Text = "Choice1";
            lbChoice1.TextAlign = ContentAlignment.MiddleCenter;
            lbChoice1.Click += Choice_Click;
            // 
            // lbEvent
            // 
            lbEvent.AutoSize = true;
            lbEvent.Dock = DockStyle.Fill;
            lbEvent.Location = new Point(3, 0);
            lbEvent.Name = "lbEvent";
            lbEvent.Size = new Size(653, 15);
            lbEvent.TabIndex = 0;
            lbEvent.Text = "Event";
            lbEvent.TextAlign = ContentAlignment.MiddleCenter;
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
        public static Label lbChoice2;
        public static Label lbChoice1;
        public static Label lbEvent;
    }
}
