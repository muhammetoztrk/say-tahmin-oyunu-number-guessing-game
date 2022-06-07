using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayi_tahmin_oyunu
{
    public partial class Form1 : Form
    {
        int tutulansaayi;
        int hak = 5;
        int tahmin;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tutulansaayi = rnd.Next(100);
        }

        private void btntahmin_Click(object sender, EventArgs e)
        {
            if (hak!=0)
            {
                tahmin = Convert.ToInt32(tbtahmin.Text);
                if (tahmin < tutulansaayi)  
                {
                    lblgoster.Text = "Yukarı / Up";
                }
                else if (tahmin > tutulansaayi)
                {
                    lblgoster.Text = "Aşağı / Down";
                }
                else
                {
                    lblgoster.Text = "Doğru tahmin / Right guess ";
                }
                hak--;
            }
            else
            {
                lblgoster.Text = "Hakkınız Bitti / Your right is over ";
            }
        }
    }
}
