using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS
{
    public partial class ChanDoan : Form
    {
        public ChanDoan()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string DiagnosisResult
        {
            get { return txt_kqua.Text; }
            set { txt_kqua.Text = value; }
        }
    }
}
