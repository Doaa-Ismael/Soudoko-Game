namespace sudoko__Asm
{
    partial class finish_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cor_label = new System.Windows.Forms.Label();
            this.Incor_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.options_btn = new System.Windows.Forms.Button();
            this.opt_panel = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.back_opt = new System.Windows.Forms.Button();
            this.scor_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.score_panel = new System.Windows.Forms.Panel();
            this.back_score = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.opt_panel.SuspendLayout();
            this.score_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.Sienna;
            this.board.ColumnCount = 1;
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.board.Location = new System.Drawing.Point(1, 3);
            this.board.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.board.Name = "board";
            this.board.RowCount = 1;
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.board.Size = new System.Drawing.Size(117, 107);
            this.board.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correct:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incorrect:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 700);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time:";
            // 
            // cor_label
            // 
            this.cor_label.AutoSize = true;
            this.cor_label.Location = new System.Drawing.Point(151, 584);
            this.cor_label.Name = "cor_label";
            this.cor_label.Size = new System.Drawing.Size(71, 26);
            this.cor_label.TabIndex = 6;
            this.cor_label.Text = "Time:";
            // 
            // Incor_label
            // 
            this.Incor_label.AutoSize = true;
            this.Incor_label.Location = new System.Drawing.Point(423, 584);
            this.Incor_label.Name = "Incor_label";
            this.Incor_label.Size = new System.Drawing.Size(71, 26);
            this.Incor_label.TabIndex = 7;
            this.Incor_label.Text = "Time:";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(130, 700);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(71, 26);
            this.time_label.TabIndex = 8;
            this.time_label.Text = "Time:";
            // 
            // options_btn
            // 
            this.options_btn.Location = new System.Drawing.Point(357, 678);
            this.options_btn.Name = "options_btn";
            this.options_btn.Size = new System.Drawing.Size(157, 45);
            this.options_btn.TabIndex = 11;
            this.options_btn.Text = "Options";
            this.options_btn.UseVisualStyleBackColor = true;
            this.options_btn.Click += new System.EventHandler(this.options_btn_Click);
            // 
            // opt_panel
            // 
            this.opt_panel.Controls.Add(this.exit_btn);
            this.opt_panel.Controls.Add(this.back_opt);
            this.opt_panel.Controls.Add(this.scor_btn);
            this.opt_panel.Controls.Add(this.button3);
            this.opt_panel.Location = new System.Drawing.Point(74, 111);
            this.opt_panel.Name = "opt_panel";
            this.opt_panel.Size = new System.Drawing.Size(395, 438);
            this.opt_panel.TabIndex = 12;
            this.opt_panel.Visible = false;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(97, 264);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(214, 61);
            this.exit_btn.TabIndex = 16;
            this.exit_btn.Text = "Exit Game";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // back_opt
            // 
            this.back_opt.Location = new System.Drawing.Point(138, 358);
            this.back_opt.Name = "back_opt";
            this.back_opt.Size = new System.Drawing.Size(127, 53);
            this.back_opt.TabIndex = 15;
            this.back_opt.Text = "Back";
            this.back_opt.UseVisualStyleBackColor = true;
            this.back_opt.Click += new System.EventHandler(this.back_opt_Click);
            // 
            // scor_btn
            // 
            this.scor_btn.Location = new System.Drawing.Point(97, 157);
            this.scor_btn.Name = "scor_btn";
            this.scor_btn.Size = new System.Drawing.Size(214, 66);
            this.scor_btn.TabIndex = 13;
            this.scor_btn.Text = "Score";
            this.scor_btn.UseVisualStyleBackColor = true;
            this.scor_btn.Click += new System.EventHandler(this.scor_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 68);
            this.button3.TabIndex = 14;
            this.button3.Text = "Play Again";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // score_panel
            // 
            this.score_panel.Controls.Add(this.back_score);
            this.score_panel.Controls.Add(this.label5);
            this.score_panel.Controls.Add(this.button12);
            this.score_panel.Controls.Add(this.button11);
            this.score_panel.Controls.Add(this.button10);
            this.score_panel.Controls.Add(this.button9);
            this.score_panel.Controls.Add(this.label9);
            this.score_panel.Controls.Add(this.label8);
            this.score_panel.Controls.Add(this.label7);
            this.score_panel.Controls.Add(this.label6);
            this.score_panel.Controls.Add(this.label4);
            this.score_panel.Controls.Add(this.button8);
            this.score_panel.Controls.Add(this.button7);
            this.score_panel.Controls.Add(this.button6);
            this.score_panel.Controls.Add(this.button5);
            this.score_panel.Controls.Add(this.button2);
            this.score_panel.Location = new System.Drawing.Point(1, 3);
            this.score_panel.Name = "score_panel";
            this.score_panel.Size = new System.Drawing.Size(826, 729);
            this.score_panel.TabIndex = 17;
            this.score_panel.Visible = false;
            // 
            // back_score
            // 
            this.back_score.Location = new System.Drawing.Point(532, 633);
            this.back_score.Name = "back_score";
            this.back_score.Size = new System.Drawing.Size(128, 50);
            this.back_score.TabIndex = 16;
            this.back_score.Text = "Back";
            this.back_score.UseVisualStyleBackColor = true;
            this.back_score.Click += new System.EventHandler(this.back_score_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Score Rate:";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(104, 119);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(116, 37);
            this.button12.TabIndex = 14;
            this.button12.Text = "Name";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(215, 119);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(128, 37);
            this.button11.TabIndex = 13;
            this.button11.Text = "Correct";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(340, 119);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 37);
            this.button10.TabIndex = 12;
            this.button10.Text = "incorrect";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(477, 119);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(164, 37);
            this.button9.TabIndex = 11;
            this.button9.Text = "time";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(38, 528);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 4;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(38, 439);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 3;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(38, 357);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 2;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(38, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 1;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // finish_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(667, 735);
            this.Controls.Add(this.score_panel);
            this.Controls.Add(this.opt_panel);
            this.Controls.Add(this.options_btn);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.Incor_label);
            this.Controls.Add(this.cor_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.board);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "finish_form";
            this.Text = "finish_form";
            this.Load += new System.EventHandler(this.finish_form_Load);
            this.opt_panel.ResumeLayout(false);
            this.score_panel.ResumeLayout(false);
            this.score_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cor_label;
        private System.Windows.Forms.Label Incor_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Button options_btn;
        private System.Windows.Forms.Panel opt_panel;
        private System.Windows.Forms.Button back_opt;
        private System.Windows.Forms.Button scor_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel score_panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back_score;
    }
}