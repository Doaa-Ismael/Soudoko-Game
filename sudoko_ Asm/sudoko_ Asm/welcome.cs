using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoko__Asm
{
    public partial class welcome : Form
    {
        Form1 F = new Form1();
        Random R = new Random();

        public static string User_Name ="";
        public welcome()
        {
            InitializeComponent();
           
           
        }

        private void esy_btn_Click(object sender, EventArgs e)
        {

           int x= R.Next(0, 3);
            Form1.difcu(x, Form1.sud_arr,Form1.res_arr);
            this.Hide();
            F.Show();
        }

        private void med_btn_Click(object sender, EventArgs e)
        {
            int x = R.Next(3, 6);
            Form1.difcu(x, Form1.sud_arr, Form1.res_arr);
            this.Hide();
            F.Show();
        
        }

        private void hrd_btn_Click(object sender, EventArgs e)
        {
            int x = R.Next(6, 9);
            Form1.difcu(x, Form1.sud_arr,Form1.res_arr);
            this.Hide();
            F.Show();
        
        
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            User_Name = name_box.Text.ToString();
            Name_panel.Visible = false;
        }


        
    }
}
