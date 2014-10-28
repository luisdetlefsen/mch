using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmDialogCargoAbonoAdicional : Form
    {

        public Decimal MontoCargoAbono { get; set; }
        public int CargoAbono { get; set; }
        public Boolean Bandera { get; set; }
        
        public frmDialogCargoAbonoAdicional()
        {
            InitializeComponent();
            if (CargoAbono == -1) {

                label1.Text = "Ingrese el monto Variable de Cargo";
            
            }
            if (CargoAbono == 1)
            {
                label1.Text = "Ingrese el monto Variable de Abono";
            


            }
        
        }

        private void pbNuevoCobroAdiconal_Click(object sender, EventArgs e)
        {
            try
            {
                Bandera = true;
                MontoCargoAbono = Convert.ToDecimal(textBox1.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ocurrió un error inesperado");
            Bandera=false;
            
            }

        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            Bandera = false;
            this.Close();
        }
   
     

    }
}
