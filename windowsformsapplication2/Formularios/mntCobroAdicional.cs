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
    public partial class selectCobroAdicional : Form
    {
        public selectCobroAdicional()
        {
            InitializeComponent();
            CleanAndFill();

        }

       

        private void pbNuevoCobroAdiconal_Click(object sender, EventArgs e)
        {
            frmCargoAdicional fVariable;
            fVariable = new frmCargoAdicional ();
       
          

            fVariable.idAccion = 1;
            fVariable.idCobroAdicional = 0;
            fVariable.ShowDialog();
            CleanAndFill();

        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCargoAdicional fVariable;
            fVariable = new frmCargoAdicional();

            try
            {
                int numero = gridViewCobrosAdicionales.CurrentCell.RowIndex;



                fVariable.idAccion = 2;
                fVariable.idCobroAdicional = Convert.ToInt32(gridViewCobrosAdicionales[0, numero].Value);
                fVariable.ShowDialog();
                CleanAndFill();
            }

            catch {
                MessageBox.Show("Seleccione el registro a modficar");
            }
          
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            int numero = gridViewCobrosAdicionales.CurrentCell.RowIndex;
            int idCobroAdicional = Convert.ToInt32(gridViewCobrosAdicionales[0, numero].Value);
            Datos.DeleteCobroAdicional(idCobroAdicional);
            CleanAndFill();
        

        }

        private void CleanAndFill()
        {
            gridViewCobrosAdicionales.DataSource= null;
            gridViewCobrosAdicionales.DataSource = Datos.SelectTipoCargoAbono();
            gridViewCobrosAdicionales.Columns[0].Visible = false;

        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void selectCobroAdicional_Load(object sender, EventArgs e)
        {

        }
    
    }
}
