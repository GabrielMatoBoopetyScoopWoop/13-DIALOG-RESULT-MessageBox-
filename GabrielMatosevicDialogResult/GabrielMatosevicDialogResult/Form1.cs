using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabrielMatosevicDialogResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Butun_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("", "",MessageBoxButtons.YesNoCancel);
            switch (rez)

            {

                case DialogResult.Yes:

                    TextKutija.Text = "Izabrali ste dugme YES";

                    break;

                case DialogResult.No:

                    TextKutija.Text = "Izabrali ste dugme NO";

                    break;

                case DialogResult.Cancel:

                    TextKutija.Text = "Izabrali ste dugme Cancel";

                    break;

            }
        }
    }
}
