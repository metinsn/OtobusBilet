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
    public partial class YolcuForm : Form
    {
        public YolcuForm()
        {
            InitializeComponent();            
        }
        List<string> yolcular = new List<string>();
        private void kaydetBTN_Click(object sender, EventArgs e)
        {
            yolcular.Add(adSoyadTBOX.Text);
            listBox1.Items.AddRange(yolcular.ToArray());
            MessageBox.Show(adSoyadTBOX.Text + " kaydedildi");
        }
    }
}
