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
    public partial class Form1 : Form
    {



        public TableLayoutPanelCellPosition cell = new TableLayoutPanelCellPosition();

        public static int[] zz = new int[1];
        public static char[] sud_arr = new char[100];
        public static char[] res_arr = new char[100];
        public static char[] play = new char[100];

        [DllImport("Project.dll")]
        private static extern void finish();

        //[DllImport("Project.dll")]
        //private static extern void FillIndecies(char[] arr, [In, Out] int[] arr2);

        [DllImport("Project.dll")]
        private static extern void start();


        [DllImport("Project.dll")]
        public static extern void difcu(int X, [In, Out]char[] arr, [In, Out]char[] arr2);

        [DllImport("Project.dll")]
        private static extern void Edit(int r ,int c, int v ,[In,Out] int[] S );


        
        
        public Form1()
        {
            InitializeComponent();
        }

        
       
        public void button_Click_1(object sender, EventArgs e)
        {
            Button button = sender as Button;
            val_panel.Visible = true;
            cell= board.GetPositionFromControl(button);
        }


        public void desgin(int col,char value,string Name_btn,int h,int w,int x,int y)
        {
            if (col == 1)
            {
               Button btn = new Button() { Text = value.ToString(), BackColor = Color.Red, Name = Name_btn, Height = h, Width = w, Enabled = false };
                board.Controls.Add(btn, y, x);
                
            }
            else
            {
                Button btn = new Button() { Text = value.ToString(), Name = Name_btn, Height = h, Width = w };

                board.Controls.Add(btn, y, x);
                btn.Click += new EventHandler(button_Click_1);
            }
            

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            start(); 
           

            board.Width = 10* 50;
            board.Height = 10 * 50;
            board.RowCount = 9;
            board.ColumnCount = 9;
            

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string name="btn"+i+j;
                    char value=sud_arr[i*11+j];
                    
                    if (value=='0')
                    {
                        value = ' ';
                        desgin(0,value, name, 50, 50, i, j);
                    }
                    else
                    {
                        desgin(1,value, name, 50, 50, i, j);
                    }
                    
                    
                }
                
            }

            
        }

        private void board_Click(object sender, EventArgs e)
        {
        }

        private void finish_btn_Click(object sender, EventArgs e)
        {
            finish();   
            finish_form F = new finish_form();
            this.Hide();
            F.Show();
            
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Control C = new Control();
                int i = 0;
                string num = richTextBox1.Text.ToString();
                Edit(cell.Row, cell.Column, int.Parse(num), zz);
                if (zz[0] == 1)
                {
                    

                    C = board.GetControlFromPosition(cell.Column, cell.Row);
                    C.Text = num;
                    C.BackColor = Color.Green;
                    play[cell.Row * 11 + cell.Column] = char.Parse(num);
                    
                    val_panel.Visible = false;

                }
                else if (zz[0] == 0)
                {
                    val_panel.Visible = false;
                    MessageBox.Show(" Incorrect Value. ");
                   
                }
                else
                {
                    MessageBox.Show(" You had Entered out of range Value ");
                }
            }
            catch
            {
                MessageBox.Show("Enter Value. ");
                val_panel.Visible = false;
            }
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            board.Controls.Clear();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string name = "btn" + i + j;
                    char value = sud_arr[i * 11 + j];

                    if (value == '0')
                    {
                        value = ' ';
                        desgin(0, value, name, 50, 50, i, j);
                    }
                    else
                    {
                        desgin(1, value, name, 50, 50, i, j);
                    }


                }

            }

        }
    }
}
