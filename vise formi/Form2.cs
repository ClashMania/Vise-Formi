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
    public partial class NoviStudent : Form
    {
        private Student student1;

        internal Student Student1 { get => student1; set => student1 = value; }
        public NoviStudent()
        {
            InitializeComponent();
        }

        

        private void fSnimi_Click(object sender, EventArgs e)
        {
            student1 = new Student(fIme.Text, fPrezime.Text, fBrojIndeksa.Text, fDatRodjenja.Value, fSmjer.Text);
           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
