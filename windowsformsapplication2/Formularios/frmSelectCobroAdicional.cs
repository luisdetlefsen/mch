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
    public partial class frmSelectCobroAdicional : Form
    {
        public frmSelectCobroAdicional()
        {
            InitializeComponent();

            CleanAndFill();
       
        }
        public int Lectura { get; set; }
        public Decimal Monto { get; set; }

        public void CleanAndFill() {
            gridViewCobrosAdicionales.Rows.Clear();
            gridViewCobrosAdicionales.DataSource = Datos.JoinCobroAdicional ();
            gridViewCobrosAdicionales.Columns[0].Width = 0;
            gridViewCobrosAdicionales.Columns[3].Width =0;
        
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbNuevoCobroAdiconal_Click(object sender, EventArgs e)
        {
            string sMensajeM = string.Empty;
            int iResultadoM = 0;
            
            int numero = gridViewCobrosAdicionales.CurrentCell.RowIndex;
            decimal montoCargo;
            string Descripcion;
            int cargoAbono;
            int idCobroAdicional;
            DataTable dtDatos;
            DataRow dtRow;
            Boolean flag;
            idCobroAdicional  = Convert.ToInt32(gridViewCobrosAdicionales[0, numero].Value);
            Descripcion = Convert.ToString(gridViewCobrosAdicionales[1, numero].Value);
            cargoAbono=Convert.ToInt16(gridViewCobrosAdicionales[2,numero].Value);
            dtDatos = Datos.CalculaCobroAdicional(idCobroAdicional, Monto);
            dtRow = dtDatos.Rows[0];
            
            montoCargo = Convert.ToDecimal(dtRow.ItemArray[0]);

            if (montoCargo == 0)
            {

                frmDialogCargoAbonoAdicional frmSelect;
                frmSelect = new frmDialogCargoAbonoAdicional();
                frmSelect.Bandera = true;
                frmSelect.CargoAbono = cargoAbono;
                frmSelect.ShowDialog();

                flag = frmSelect.Bandera;
                montoCargo = frmSelect.MontoCargoAbono;
            }

            else
            {
                flag = true;

            }


            if (flag == true)
            {
                string message = "¿Desea realizar el cargo de: " + Convert.ToString(montoCargo) + " por el concepto de " + Descripcion + "?";
                string caption = "Cargos Adicionales";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Datos.InsertarCargoAbono(Lectura, idCobroAdicional, Convert.ToDouble(montoCargo) * cargoAbono, Descripcion, ref  sMensajeM, ref iResultadoM);
                   if(cargoAbono==-1){
                       MessageBox.Show("Cargo Ingresado Correctamente");

                   }
                   if (cargoAbono == 1)
                   {
                       MessageBox.Show("Abono Ingresado Correctamente");

                   }
                    

                    
                }
                else
                {
                    MessageBox.Show("No se ha realizado ningún cargo/Abono");

                }


            }

            else
            {
                MessageBox.Show("No se ha realizado ningún cargo/Abono");

            }
        }

        private void frmSelectCobroAdicional_Load(object sender, EventArgs e)
        {

        }

    
    }
}
