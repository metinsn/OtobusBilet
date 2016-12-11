using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void otobusTipCMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                

                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Width = 60;
                    btn.Height = 60;
                    btn.Text = Convert.ToString(i);
                    btn.Left = (btn.Width) * j;
                    btn.Top = (btn.Height) * i;
                    panel1.Controls.Add(btn);
                }

                
            }
        }
    }
}
