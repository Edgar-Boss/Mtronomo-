using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            
      
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btonmenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 35)
            {
                panel1.Visible = false;
                panel1.Width = 200;
                paneltransition.ShowSync(panel1);
                Logotransition.ShowSync(logo);
                
            }
            else
            {
                Mtronomo_logo_letras.Visible = false;
                logo.Visible = false;
                panel1.Visible = false;
                panel1.Width =35;
                paneltransition.ShowSync(panel1);
            }
        }
    }
}
