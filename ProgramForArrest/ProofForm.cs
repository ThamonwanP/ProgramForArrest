using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForArrest
{
    public partial class ProofForm : Form
    {
        string card;
        public ProofForm(string card)
        {
            InitializeComponent();
            card = this.card;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
