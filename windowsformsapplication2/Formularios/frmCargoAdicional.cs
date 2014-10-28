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
    public partial class frmCargoAdicional : Form
    {
        public int idCobroAdicional { get; set; }
        public int idAccion { get; set; }
        public frmCargoAdicional()
        {
            InitializeComponent();

          
        
        }
       
        private void frmCargoAdicional_Load(object sender, EventArgs e)
        {
            if (idAccion == 2)
            {
                DataTable dtDatos;
                DataRow dtRow;
                dtDatos = Datos.JoinCobroAdicionalMantenimiento(idCobroAdicional);
                dtRow = dtDatos.Rows[0];
                txtDescripcion.Text = Convert.ToString(dtRow.ItemArray[1]);
                txtMontoFijo.Text = Convert.ToString(dtRow.ItemArray[4]);
                txtPercent.Text = Convert.ToString(dtRow.ItemArray[5]);
                if (Convert.ToDouble(dtRow.ItemArray[4]) + Convert.ToDouble (dtRow.ItemArray[5]) == 0) 
                
                {

                    txtMontoFijo.Visible = false;
                    txtPercent.Visible=false;
                    chkTipoCobro.Checked = true;
                }
                if (Convert.ToInt16(dtRow.ItemArray[2]) == -1)
                {
                    cmbCargoAbono.SelectedItem = "Cargo";
                }

                else
                {
                    cmbCargoAbono.SelectedItem = "Abono";
                
                }
            
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {


            int cargoAbono;
            decimal MontoFijo;
            decimal Percent;
            int bandera=1;
            if ((chkTipoCobro.Checked == false) && (txtMontoFijo.Text == "0") && (txtPercent.Text == "0"))
            {
                bandera = 0;

            }
            else {
                bandera = 1;
            }


            if (cmbCargoAbono.Text == "Abono")
            {
                cargoAbono = 1;
            }
            else
            {
                cargoAbono = -1;
            }
            try
            {
                 MontoFijo = Convert.ToDecimal(txtMontoFijo.Text);
            }
            catch { MontoFijo = 0.0m; }

            try { Percent = Convert.ToDecimal(txtPercent.Text); }
            catch { Percent = 0.0m; }

           
            
            decimal percent = Convert.ToDecimal(txtPercent.Text);

            if (txtDescripcion.Text != "")
            {
                if (cmbCargoAbono.Text != "")
                {
                    if (bandera == 1)
                    {

                        if (idAccion == 1)
                        {


                            Datos.InsertCobroAdicional(txtDescripcion.Text, MontoFijo, Percent, cargoAbono);
                            MessageBox.Show("Registro Ingresado Correctamente");
                            this.Close();
                        }
                        if (idAccion == 2)
                        {
                            Datos.UpdateCobroAdicional(idCobroAdicional, txtDescripcion.Text, MontoFijo, Percent, cargoAbono);
                            MessageBox.Show("Registro Modificado Correctamente");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un monto o porcentaje de Cargo/Abono");
                    }
                
                }
                
                else
                {
                    MessageBox.Show("Debe seleccionar Cargo/abono");
                }
            
            }
            
            
            else
            {

                MessageBox.Show("Debe ingresar una descripción del Cargo/Abono");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTipoCobro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTipoCobro.Checked == true)

            {
                txtMontoFijo.Text = "0";
                txtPercent.Text = "0";
                txtMontoFijo.Visible = false;
                txtPercent.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            
            }
            else
            {
                txtMontoFijo.Visible = true;
                txtPercent.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
        
            
            }


        }
    }
}
