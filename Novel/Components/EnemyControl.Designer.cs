namespace Novel
{
    partial class EnemyControl
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
            head = new Button();
            body = new Button();
            legs = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // head
            // 
            head.BackgroundImage = Properties.Resources.imgonline_com_ua_Mirror_dZKJDvksmS_removebg_preview;
            head.BackgroundImageLayout = ImageLayout.Zoom;
            head.Dock = DockStyle.Fill;
            head.FlatAppearance.BorderSize = 0;
            head.FlatStyle = FlatStyle.Flat;
            head.Location = new Point(0, 0);
            head.Margin = new Padding(0);
            head.Name = "head";
            head.Size = new Size(290, 117);
            head.TabIndex = 0;
            head.UseVisualStyleBackColor = true;
            // 
            // body
            // 
            body.BackgroundImage = Properties.Resources.imgonline_com_ua_Mirror_weAmx4nygAWp_removebg_preview;
            body.BackgroundImageLayout = ImageLayout.Zoom;
            body.Dock = DockStyle.Fill;
            body.FlatAppearance.BorderSize = 0;
            body.FlatStyle = FlatStyle.Flat;
            body.Location = new Point(0, 117);
            body.Margin = new Padding(0);
            body.Name = "body";
            body.Size = new Size(290, 117);
            body.TabIndex = 1;
            body.UseVisualStyleBackColor = true;
            // 
            // legs
            // 
            legs.BackgroundImage = Properties.Resources.imgonline_com_ua_Mirror_gU5vpXsSl673NnZp_removebg_preview;
            legs.BackgroundImageLayout = ImageLayout.Zoom;
            legs.Dock = DockStyle.Fill;
            legs.FlatAppearance.BorderSize = 0;
            legs.FlatStyle = FlatStyle.Flat;
            legs.Location = new Point(0, 234);
            legs.Margin = new Padding(0);
            legs.Name = "legs";
            legs.Size = new Size(290, 117);
            legs.TabIndex = 2;
            legs.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(legs, 0, 2);
            tableLayoutPanel1.Controls.Add(head, 0, 0);
            tableLayoutPanel1.Controls.Add(body, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(290, 351);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // EnemyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "EnemyControl";
            Size = new Size(290, 351);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button head;
        private Button body;
        private Button legs;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
