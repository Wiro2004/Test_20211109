using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        Ucet ucet1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucet1 = new Ucet("Jan Novák", 10000);
            Zobraz(ucet1);  //tady mi to nefunguje
        }

        private void Zobraz(Ucet ucet)
        {

            jmenolbl.Text = "" +ucet.jmeno;
            stavlbl.Text = "" + ucet.stav;
        }

        private void vlozitNN_Click(object sender, EventArgs e)
        {
            var vlozeno = ucet1.vlozit((int)vlozitN.Value);
            Zobraz(ucet1);
            MessageBox.Show($"Vložil jste {vlozeno} kč");
        }

        private void vybratNN_Click(object sender, EventArgs e)
        {
           var vybrano = ucet1.vybrat((int)vybratN.Value);
            Zobraz(ucet1);
            MessageBox.Show($"Vybral jste {vybrano} kč");
        }

        private void zaplatitNN_Click(object sender, EventArgs e)
        {
            var zaplaceno = ucet1.zaplat((int)zaplatitN.Value);
            Zobraz(ucet1);
            MessageBox.Show($"Zaplatil jste {zaplaceno} kč");
        }
    }
}

