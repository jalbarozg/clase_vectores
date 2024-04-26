using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppVector
{
    public partial class frmvector : Form
    {
        //creando una instancia de mi clase vector
        clsVector v = new clsVector();

        public frmvector()
        {
            InitializeComponent();
        }
        private void mostrarVector()
        {
            for (int i = 0; i < v.longitud(); i++)
            {
                lbresultado.Text = lbresultado.Text + v.obtenervalor(i) + " , ";
            }
            lbresulato.Text = lbresultado.Text + "]";
        }

         

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
        }
    }
}
