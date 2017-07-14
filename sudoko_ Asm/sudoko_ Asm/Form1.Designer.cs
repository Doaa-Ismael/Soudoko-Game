namespace sudoko__Asm
{
    partial class Form1
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
            this.board = new System.Windows.Forms.TableLayoutPanel();
            this.finish_btn = new System.Windows.Forms.Button();
            this.val_panel = new System.Windows.Forms.Panel();
            this.OK_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clr_btn = new System.Windows.Forms.Button();
            this.val_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.Sienna;
            this.board.ColumnCount = 1;
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.board.Location = new System.Drawing.Point(0, 0);
            this.board.Margin = new System.Windows.Forms.Padding(6);
            this.board.Name = "board";
            this.board.RowCount = 1;
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.board.Size = new System.Drawing.Size(55, 55);
            this.board.TabIndex = 1;
            this.board.Click += new System.EventHandler(this.board_Click);
            // 
            // finish_btn
            // 
            this.finish_btn.Location = new System.Drawing.Point(47, 666);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Size = new System.Drawing.Size(185, 55);
            this.finish_btn.TabIndex = 2;
            this.finish_btn.Text = "Finish";
            this.finish_btn.UseVisualStyleBackColor = true;
            this.finish_btn.Click += new System.EventHandler(this.finish_btn_Click);
            // 
            // val_panel
            // 
            this.val_panel.Controls.Add(this.OK_btn);
            this.val_panel.Controls.Add(this.richTextBox1);
            this.val_panel.Location = new System.Drawing.Point(186, 148);
            this.val_panel.Name = "val_panel";
            this.val_panel.Size = new System.Drawing.Size(200, 139);
            this.val_panel.TabIndex = 3;
            this.val_panel.Visible = false;
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(67, 88);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(78, 38);
            this.OK_btn.TabIndex = 5;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(45, 25);
            this.richTextBox1.MaxLength = 1;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(115, 42);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // clr_btn
            // 
            this.clr_btn.Location = new System.Drawing.Point(337, 666);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(185, 55);
            this.clr_btn.TabIndex = 4;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(667, 735);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.val_panel);
            this.Controls.Add(this.finish_btn);
            this.Controls.Add(this.board);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.val_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel board;
        private System.Windows.Forms.Button finish_btn;
        private System.Windows.Forms.Panel val_panel;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button clr_btn;

    }
}

