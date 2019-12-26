using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFuncionário addFunc = new AddFuncionário();
            addFunc.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello Word");
           Close();
        }
    }
}
