using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorRat
{
    public partial class ListaRat : Form
    {
        private Dictionary<int, double> listaRat;

        public ListaRat()
        {
            InitializeComponent();
        }

        public ListaRat(Dictionary<int, double> listaRat) : this()
        {
            this.listaRat = listaRat;
            dataGridView1.DataSource = listaRat.ToArray();
        }
    }
}
