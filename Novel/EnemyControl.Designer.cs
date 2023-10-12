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
            SuspendLayout();
            // 
            // head
            // 
            head.BackgroundImage = Properties.Resources.imgonline_com_ua_Mirror_dZKJDvksmS_removebg_preview;
            head.BackgroundImageLayout = ImageLayout.Zoom;
            head.Dock = DockStyle.Top;
            head.FlatStyle = FlatStyle.Flat;
            head.Location = new Point(0, 0);
            head.Margin = new Padding(0);
            head.Name = "head";
            head.Size = new Size(200, 94);
            head.TabIndex = 0;
            head.UseVisualStyleBackColor = true;
            // 
            // body
            // 
            body.BackgroundImage = Properties.Resources.imgonline_com_ua_Mirror_weAmx4nygAWp_removebg_preview;
            body.BackgroundImageLayout = ImageLayout.Zoom;
            body.Dock = DockStyle.Top;
            body.FlatStyle = FlatStyle.Flat;
            body.Location = new Point(0, 94);
            body.Margin = new Padding(0);
            body.Name = "body";
            body.Size = new Size(200, 94);
            body.TabIndex = 1;
            body.UseVisualStyleBackColor = true;
            // 
            // legs
            // 
            legs.BackgroundImage = Properties.Resources.imgonline_com_ua_Mirror_gU5vpXsSl673NnZp_removebg_preview;
            legs.BackgroundImageLayout = ImageLayout.Zoom;
            legs.Dock = DockStyle.Top;
            legs.FlatStyle = FlatStyle.Flat;
            legs.Location = new Point(0, 188);
            legs.Margin = new Padding(0);
            legs.Name = "legs";
            legs.Size = new Size(200, 96);
            legs.TabIndex = 2;
            legs.UseVisualStyleBackColor = true;
            // 
            // EnemyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(legs);
            Controls.Add(body);
            Controls.Add(head);
            Name = "EnemyControl";
            Size = new Size(200, 284);
            ResumeLayout(false);
        }

        #endregion

        private Button head;
        private Button body;
        private Button legs;
    }
}
