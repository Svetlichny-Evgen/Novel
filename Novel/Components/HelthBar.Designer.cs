namespace Novel.Components
{
    partial class HelthBar
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
            healthArea = new TableLayoutPanel();
            lastLine = new Label();
            firstLine = new Label();
            healthArea.SuspendLayout();
            SuspendLayout();
            // 
            // healthArea
            // 
            healthArea.ColumnCount = 2;
            healthArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            healthArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            healthArea.Controls.Add(lastLine, 1, 0);
            healthArea.Controls.Add(firstLine, 0, 0);
            healthArea.Dock = DockStyle.Fill;
            healthArea.Location = new Point(0, 0);
            healthArea.Name = "healthArea";
            healthArea.RowCount = 1;
            healthArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            healthArea.Size = new Size(364, 35);
            healthArea.TabIndex = 0;
            // 
            // lastLine
            // 
            lastLine.AutoSize = true;
            lastLine.Dock = DockStyle.Fill;
            lastLine.Location = new Point(182, 0);
            lastLine.Margin = new Padding(0);
            lastLine.Name = "lastLine";
            lastLine.Size = new Size(182, 35);
            lastLine.TabIndex = 1;
            // 
            // firstLine
            // 
            firstLine.AutoSize = true;
            firstLine.Dock = DockStyle.Fill;
            firstLine.Location = new Point(0, 0);
            firstLine.Margin = new Padding(0);
            firstLine.Name = "firstLine";
            firstLine.Size = new Size(182, 35);
            firstLine.TabIndex = 0;
            // 
            // HelthBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(healthArea);
            Name = "HelthBar";
            Size = new Size(364, 35);
            healthArea.ResumeLayout(false);
            healthArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel healthArea;
        private Label lastLine;
        private Label firstLine;
    }
}
