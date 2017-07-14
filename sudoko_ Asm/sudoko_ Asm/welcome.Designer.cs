namespace sudoko__Asm
{
    partial class welcome
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
            this.esy_btn = new System.Windows.Forms.Button();
            this.med_btn = new System.Windows.Forms.Button();
            this.hrd_btn = new System.Windows.Forms.Button();
            this.Name_panel = new System.Windows.Forms.Panel();
            this.Play_btn = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // esy_btn
            // 
            this.esy_btn.Location = new System.Drawing.Point(180, 127);
            this.esy_btn.Name = "esy_btn";
            this.esy_btn.Size = new System.Drawing.Size(192, 98);
            this.esy_btn.TabIndex = 0;
            this.esy_btn.Text = "Easy";
            this.esy_btn.UseVisualStyleBackColor = true;
            this.esy_btn.Click += new System.EventHandler(this.esy_btn_Click);
            // 
            // med_btn
            // 
            this.med_btn.Location = new System.Drawing.Point(180, 328);
            this.med_btn.Name = "med_btn";
            this.med_btn.Size = new System.Drawing.Size(192, 98);
            this.med_btn.TabIndex = 1;
            this.med_btn.Text = "Medium";
            this.med_btn.UseVisualStyleBackColor = true;
            this.med_btn.Click += new System.EventHandler(this.med_btn_Click);
            // 
            // hrd_btn
            // 
            this.hrd_btn.Location = new System.Drawing.Point(180, 524);
            this.hrd_btn.Name = "hrd_btn";
            this.hrd_btn.Size = new System.Drawing.Size(192, 98);
            this.hrd_btn.TabIndex = 2;
            this.hrd_btn.Text = "Hard";
            this.hrd_btn.UseVisualStyleBackColor = true;
            this.hrd_btn.Click += new System.EventHandler(this.hrd_btn_Click);
            // 
            // Name_panel
            // 
            this.Name_panel.Controls.Add(this.Play_btn);
            this.Name_panel.Controls.Add(this.name_box);
            this.Name_panel.Controls.Add(this.label1);
            this.Name_panel.Location = new System.Drawing.Point(43, 26);
            this.Name_panel.Name = "Name_panel";
            this.Name_panel.Size = new System.Drawing.Size(539, 675);
            this.Name_panel.TabIndex = 3;
            // 
            // Play_btn
            // 
            this.Play_btn.Location = new System.Drawing.Point(264, 377);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(200, 69);
            this.Play_btn.TabIndex = 2;
            this.Play_btn.Text = "play";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(40, 205);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(406, 32);
            this.name_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name:";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(667, 735);
            this.Controls.Add(this.Name_panel);
            this.Controls.Add(this.hrd_btn);
            this.Controls.Add(this.med_btn);
            this.Controls.Add(this.esy_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "welcome";
            this.Text = "welcome";
            this.Name_panel.ResumeLayout(false);
            this.Name_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button esy_btn;
        private System.Windows.Forms.Button med_btn;
        private System.Windows.Forms.Button hrd_btn;
        private System.Windows.Forms.Panel Name_panel;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Play_btn;

    }
}