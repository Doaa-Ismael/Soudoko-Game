using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
namespace sudoko__Asm
{
    public partial class finish_form : Form
    {
        List<string> Score_list = new List<string> ();
        public static char[] correct = new char[2];
        public static char[] Incorrect = new char[2];
        
        public static char[] time = new char[8];

        public static char[] scores = new char[110];
        [DllImport("Project.dll")]
        private static extern void endgame([Out] char[] corr, [Out] char[] Incorr, [Out] char[] T);

        [DllImport("Project.dll")]
        private static extern void score([In] string N, [Out] char[] S);

        public void desgin2(int col, char value, string Name_btn, int h, int w, int x, int y)
        {
            if (col == 1)
            {
                Button btn = new Button() { Text = value.ToString(), BackColor = Color.Red, Name = Name_btn, Height = h, Width = w, Enabled = false };
                board.Controls.Add(btn, y, x);

            }
            else if (col==0)
            {
                Button btn = new Button() { Text = value.ToString(), Name = Name_btn, Height = h, Width = w, Enabled = false};

                board.Controls.Add(btn, y, x);
                
            }
            else
            {
                Button btn = new Button() { Text = value.ToString(), BackColor = Color.Green, Name = Name_btn, Height = h, Width = w, Enabled = false };
                board.Controls.Add(btn, y, x);

            }


        }

        public finish_form()
        {
            InitializeComponent();
        }

        private void finish_form_Load(object sender, EventArgs e)
        {

            endgame(correct, Incorrect, time);
            string timee = ""; 
           
            for (int i = 0; i < 8; i++)
            {
                if (time[i] == 0)
                {
                    time[i] = '0';
                }
                timee += time[i];
            }
            if (correct[0] == 0)
            {
                correct[0] = '0';
 
            }
            if (Incorrect[0] == 0)
            {
                Incorrect[0] = '0';

            }
                cor_label.Text = string.Concat(correct[0], correct[1]);
            Incor_label.Text = string.Concat(Incorrect[0], Incorrect[1]);
            time_label.Text = timee;

            board.Width = 10 * 50;
            board.Height = 10 * 50;
            board.RowCount = 9;
            board.ColumnCount = 9;

            int index = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    index = i * 11 + j;
                    string name = "btn" + i + j;
                    char value = Form1.res_arr[index];

                    if ( Form1.play[index] !=0)
                    {
                        
                        desgin2(2, value, name, 50, 50, i, j);
                    }
                    else if (Form1.sud_arr[index] != '0')
                    {
                        desgin2(1, value, name, 50, 50, i, j);
                    }
                    else
                    {
                        desgin2(0, value, name, 50, 50, i, j);
                    }

                }

            }
           
            
            score(welcome.User_Name, scores);


            

           int z = 3;
            for (int i = 0; i <5 ; i++)
            {
                string s = "";  
                for (int x = z; x < z+19 ; x++)
                {
                    if (x == z+10)
                    {
                        s += "     ";
                    }
                    
                    if (scores[x] == 0)
                    {
                        scores[x] = '0';
 
                    }
                    if (scores[x] == 32)
                    {
                        s+= "           ";
                        continue;
                    }
                    s+= scores[x];
                }
                Score_list.Add(s);
                z = z + 22;

            }


        }

        
            

        private void button3_Click(object sender, EventArgs e)   // play_agin btn
        {
        welcome F = new welcome();
            this.Hide();
            F.Show();
           
        }

        private void options_btn_Click(object sender, EventArgs e)
        {
            opt_panel.Visible=true;
           


        }

        private void scor_btn_Click(object sender, EventArgs e)
        {
            
            opt_panel.Visible = false;
            score_panel.Visible = true;
            label4.Text = Score_list[0];
            label9.Text = Score_list[1];
            label8.Text = Score_list[2];
            label7.Text = Score_list[3];
            label6.Text = Score_list[4];
            
        }

        private void back_score_Click(object sender, EventArgs e)
        {
            score_panel.Visible = false;

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome f = new welcome();
            f.Close();
        }

        private void back_opt_Click(object sender, EventArgs e)
        {
            opt_panel.Visible = false;
        }

        

        
    }
}
