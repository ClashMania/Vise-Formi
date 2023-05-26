using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vise_formi
{
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void fDodajSt_Click(object sender, EventArgs e)
        {
            NoviStudent frm = new NoviStudent();
            DialogResult rez = frm.ShowDialog();

            if (rez == System.Windows.Forms.DialogResult.OK)
                fPodatci.Items.Add(frm.Student1.ToString());
        }

        private void fPodatci_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fObrisiSve_Click(object sender, EventArgs e)
        {
            fPodatci.Items.Clear();
        }

        private void fObrisiSt_Click(object sender, EventArgs e)
        {

        }
    }
}
