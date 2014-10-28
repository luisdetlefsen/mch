using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Formularios
{
    public partial class frmLectura : Form
    {
        frmMenu fForma2;

        string gsContrato; //variables que tendrán los valores.
        string gsNombre;
        double gdCuotaKW;
        double gdCuotaFija;
        int giUltimaLectura;
        DateTime gdtUltimaLectura;
        bool gbContrato;
        bool gbContador;

        public  frmLectura(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
        }

        private void frmLectura_Load(object sender, EventArgs e)
        {
            DateTime dtFecha = monthCalendar1.SelectionStart;
            txtFechaLectura.Text = dtFecha.Day + "/" + dtFecha.Month + "/" + dtFecha.Year;
        }

        private void frmLectura_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dtFecha = monthCalendar1.SelectionStart;
            if(dtFecha.Date > DateTime.Today)
            {
                dtFecha = DateTime.Today;
                monthCalendar1.SelectionStart = DateTime.Today;
            }
            txtFechaLectura.Text = dtFecha.Day + "/" + dtFecha.Month + "/" + dtFecha.Year;
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            txtNoContador.Text = "";
            txtLectura.Text = "";
            monthCalendar1.SelectionStart = DateTime.Today;
            txtNoContador.Focus();
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            if (txtNoContador.Text != "" && txtLectura.Text != "")  //valida que se hayan ingresado datos.
            {
                ObtenerDatos();
                if (gbContador && gbContrato)
                {
                   
                    if (gdtUltimaLectura.Year == DateTime.Parse(txtFechaLectura.Text).Year && gdtUltimaLectura.Month == DateTime.Parse(txtFechaLectura.Text).Month)
                    {
                        monthCalendar1.SelectionStart = gdtUltimaLectura;
                    }
                    //---------------Codigo para Mora-------------

                    string sContadorM = txtNoContador.Text;
                    string sMensajeM = string.Empty;
                    int iResultadoM = 0;

                    DataTable PagoPendienteDeMora = new DataTable();
                    Datos.VerCuotasPendientesSinMora(sContadorM, ref sMensajeM, ref iResultadoM, ref PagoPendienteDeMora);
                    
                    if (PagoPendienteDeMora.Rows.Count>0)
                    {
                        DialogResult r = new DialogResult();
                        r = MessageBox.Show("Existe un pago pendiente, ¿Desea aplicar mora?", "Aviso", MessageBoxButtons.YesNo);
                        if (r.ToString() == "Yes")
                        {
                            
                        
                        int iLecturaM = int.Parse(PagoPendienteDeMora.Rows[0]["ID_Lectura"].ToString());
                        double dMontoM = double.Parse(PagoPendienteDeMora.Rows[0]["Cuota_Pendiente"].ToString());
                        sMensajeM = string.Empty;
                        iResultadoM = 0;
                        DataTable dtTipoMora = new DataTable();
                        //!!!El id del tipo parametro depende del catálogo
                        Datos.ObtenerParametro(3, ref sMensajeM, ref iResultadoM, ref dtTipoMora);
                        int iTipoMora = int.Parse(dtTipoMora.Rows[0]["Parametro"].ToString());
                        double dMora = 0;
                        double dFactor = 0;
                        if (iTipoMora==1)
                        {
                            sMensajeM = string.Empty;
                            iResultadoM = 0;
                            DataTable dtPorcentajeMora = new DataTable();
                            //!!!El id del tipo parametro depende del catálogo
                            Datos.ObtenerParametro(4, ref sMensajeM, ref iResultadoM, ref dtPorcentajeMora);
                            dFactor = double.Parse(dtPorcentajeMora.Rows[0]["Parametro"].ToString());
                            dMora= dMontoM * (dFactor/100);
                        }
                        else
                        {
                            sMensajeM = string.Empty;
                            iResultadoM = 0;
                            DataTable dtValorMora = new DataTable();
                            //!!!El id del tipo parametro depende del catálogo
                            Datos.ObtenerParametro(5, ref sMensajeM, ref iResultadoM, ref dtValorMora);
                            dMora = double.Parse(dtValorMora.Rows[0]["Parametro"].ToString());
                        }
                        sMensajeM = string.Empty;
                        iResultadoM = 0;
                        //Modo de compatibilidad
                        dMora = dMora * -1;
                        //!!!El id del tipo cargo abono depende del catálogo
                        Datos.InsertarCargoAbono(iLecturaM, 5, dMora, "Cargo por mora",ref  sMensajeM, ref iResultadoM);
                        MessageBox.Show("El cliente contaba con un pago pendiente por lo cual se ha realizado un cargo por mora.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                      }

                    sMensajeM = string.Empty;
                    iResultadoM = 0;
                    DataTable TablaPagosPendientes = new DataTable();
                    Datos.BuscarPagosPendientes(sContadorM, ref  sMensajeM, ref iResultadoM, ref TablaPagosPendientes);
                    if (TablaPagosPendientes.Rows.Count >=3)
                    {
                        MessageBox.Show("El cliente cuenta con tres pagos pendientes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    //--------------------------------------------
                    string sFechaUltima = gdtUltimaLectura.Day + "/" + gdtUltimaLectura.Month + "/" + gdtUltimaLectura.Year;
                    if (DateTime.Parse(txtFechaLectura.Text) >= gdtUltimaLectura)
                    {
                        int iConsumido = int.Parse(txtLectura.Text) - giUltimaLectura;
                        double dMonto = iConsumido * gdCuotaKW;

                        int iResultado = 0;
                        string sMensaje = string.Empty;
                        DataTable dtLecturaMes = Datos.getLecturaMes(gsContrato, DateTime.Parse(txtFechaLectura.Text), ref sMensaje, ref iResultado);

                        double dMontoMensaje = dMonto;
                        if (dtLecturaMes.Rows.Count == 0)
                        {
                            dMontoMensaje += gdCuotaFija;
                        }
                        
                        if (MessageBox.Show("No. Contrato: " + gsContrato + "\nNombre: " + gsNombre + "\nÚltima lectura: " + giUltimaLectura + "\nFecha de la última lectura: " + sFechaUltima + "\nConsumido en el mes: " + iConsumido + " kW.\nMonto a cargar: Q." + dMontoMensaje, "¿Ingresar lectura?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            InsertarLectura(iConsumido, dMonto);
                        }
                    }
                    else
                    {
                        MessageBox.Show("LA FECHA DE LECTURA DEBE SER MAYOR A " + sFechaUltima + ".");
                    }
                }
            }
            else
            {
                MessageBox.Show("INGRESE UN NÚMERO DE CONTADOR Y UNA LECTURA VÁLIDA.");
            }
        }

        private void ObtenerDatos()
        {
            int iResultado = 0;
            string sMensaje = string.Empty;
            string sIDContador = txtNoContador.Text;
            DataTable dtResultado = new DataTable();
            gbContador = false; //reinicia las variables que dirán si existe o no el contador y el contrato.
            gbContrato = false;
            
            Datos.BuscarContador(sIDContador, ref sMensaje, ref iResultado, ref dtResultado);

            if (dtResultado.Rows.Count > 0) //verifica que el contador ingresado exista
            {
                gbContador = true;
                iResultado = 0; //limpia las variables.
                sMensaje = string.Empty;
                sIDContador = txtNoContador.Text;
                dtResultado = new DataTable();

                Datos.BuscarContrato("", sIDContador, false, ref sMensaje, ref iResultado, ref dtResultado);

                if (dtResultado.Rows.Count > 0) //verifica que el contador esté asociado a un contrato.
                {
                    gbContrato = true;
                    iResultado = 0; //limpia las variables
                    sMensaje = string.Empty;
                    sIDContador = txtNoContador.Text;
                    dtResultado = new DataTable();

                    gsContrato = ""; //reinicio de variables
                    gdCuotaKW = new double();
                    gdCuotaFija = new double();
                    giUltimaLectura = new int();
                    gdtUltimaLectura = new DateTime();

                    //se obtienen los datos necesarios para calcular e insertar la lectura.
                    Datos.GetDatosLectura(sIDContador, ref sMensaje, ref iResultado, ref dtResultado);

                    gsContrato = dtResultado.Rows[0]["NO_CONTRATO"].ToString();
                    gsNombre = dtResultado.Rows[0]["NOMBRE"].ToString();
                    gdCuotaKW = double.Parse(dtResultado.Rows[0]["CUOTA_KW"].ToString());
                    gdCuotaFija = double.Parse(dtResultado.Rows[0]["CUOTA_FIJA"].ToString());
                    if (dtResultado.Rows[0]["ULTIMA_LECTURA"].ToString() != "")//verifica si tiene alguna lectura ingresada anteriormente.
                    {
                        giUltimaLectura = int.Parse(dtResultado.Rows[0]["ULTIMA_LECTURA"].ToString());
                        gdtUltimaLectura = DateTime.Parse(dtResultado.Rows[0]["FECHA_ULTIMA_LECTURA"].ToString());
                    }
                    else
                    {
                        giUltimaLectura = 0;
                        gdtUltimaLectura = DateTime.Parse("01/01/0001");
                    }
                }
                else
                {
                    MessageBox.Show("EL CONTADOR INGRESADO NO TIENE CONTRATO ASOCIADO.");
                }
            }
            else
            {
                MessageBox.Show("EL CONTADOR INGRESADO NO EXISTE.");
            }
        }

        private void InsertarLectura(int eiConsumido, double edMonto)
        {
            int iResultado = 0;
            string sMensaje = string.Empty;

            double dMonto = edMonto;
            int iTipoCargoCuotaFija = 0;
            int iTipCargoAbono = 0;
            string sTipCargoAbono = "Cargo";
            string sDescripcion = "Cargo por consumo";
            int iInsertaCuotaFija = 1; //indicará si se debe insetar cuota fija o no.
            string sDescripcionCuotaFija = "Cargo por cuota fija del mes";

            if (edMonto < 0)//determina si será cargo o compesnación
            {
                sTipCargoAbono = "Compensación";
                dMonto *= -1;
                sDescripcion = "Compensación";
            }

            DataTable dtTipCargoAbono = Datos.getTipCargoAbono(ref sMensaje, ref iResultado);
            if (dtTipCargoAbono.Rows.Count > 0) //revisa si existe cargo abono.
            {
                for (int i = 0; i < dtTipCargoAbono.Rows.Count; i++) //obtiene el id del tipo cargo_abono para la cuota fija y el monto
                {
                    if (dtTipCargoAbono.Rows[i][1].ToString() == sTipCargoAbono)
                    {
                        iTipCargoAbono = int.Parse(dtTipCargoAbono.Rows[i][0].ToString());
                    }
                    if (dtTipCargoAbono.Rows[i][1].ToString() == "Cuota Fija")
                    {
                        iTipoCargoCuotaFija = int.Parse(dtTipCargoAbono.Rows[i][0].ToString());
                    }
                }

                DataTable dtLecturaMes = Datos.getLecturaMes(gsContrato, DateTime.Parse(txtFechaLectura.Text), ref sMensaje, ref iResultado);

                if (dtLecturaMes.Rows.Count > 0)
                {
                    iInsertaCuotaFija = 0;
                    gdCuotaFija = 0;
                    sDescripcionCuotaFija = "";
                }

                Datos.InsertarLectura(gsContrato, DateTime.Parse(txtFechaLectura.Text), int.Parse(txtLectura.Text), iTipCargoAbono, dMonto, sDescripcion, iInsertaCuotaFija, iTipoCargoCuotaFija, gdCuotaFija, sDescripcionCuotaFija, ref sMensaje, ref iResultado);

                switch(iResultado)
                {
                    case 0:
                        MessageBox.Show("LECTURA INSERTADA CORRECTAMENTE");
                        txtNoContador.Text = "";
                        txtLectura.Text = "";
                        monthCalendar1.SelectionStart = DateTime.Today;
                        txtNoContador.Focus();
                    break;
                    case -3:
                        MessageBox.Show("YA EXISTE UN PAGO PARA ESTE MES, NO SE PUDO INSERTAR LA LECTURA.");
                    break;
                    default:
                        MessageBox.Show("ERROR AL INSETAR LA LECTURA, INTENTE NUEVAMENTE");
                    break;
                }
            }
            else
            {
                MessageBox.Show("NO EXISTE TIPO DE CARGO/ABONO INGRESADO.\nLECTURA NO INSERTADA.");
            }

        }

        private void txtLectura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //solo permite ingresar números enteros.
            {
                e.Handled = true;
            }
        }

        private void txtNoContador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar)) //solo permite ingresar alfanuméricos.
            {
                e.Handled = true;
            }
        }

        private void txtNoContador_TextChanged(object sender, EventArgs e)
        {
            txtNoContador.CharacterCasing = CharacterCasing.Upper;
        }

        MCH_CN CN = new MCH_CN();
        private void btn_eliminar_lecturas_Click(object sender, EventArgs e)
        {
            if (txtNoContador.Text!="")
            {

                dgv_lecturas_no_pagadas.Visible = true;
                
            dgv_lecturas_no_pagadas.DataSource = CN.getLectura_Nopagada(txtNoContador.Text);
            dgv_lecturas_no_pagadas.Columns[0].Visible = false;

            }
            else
            {
                MessageBox.Show("No ha escrito el número de contador");
            }
        }
        int row_index = -1;
        private void dgv_lecturas_no_pagadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_lectura=Convert.ToInt32(dgv_lecturas_no_pagadas.Rows[row_index].Cells[0].Value.ToString());
                string nombre_usuario = Sesion.Log;
                CN.Ejecutar_stored_procedure_sp_ingresar_historial_lectura_eliminada(nombre_usuario,id_lectura);
                CN.Ejecutar_stored_procedure_eliminar_lectura(id_lectura);
                dgv_lecturas_no_pagadas.DataSource = CN.getLectura_Nopagada(txtNoContador.Text);
                dgv_lecturas_no_pagadas.Columns[0].Visible = false;
                btn_eliminar.Visible = false;
                dgv_lecturas_no_pagadas.Visible = false;
            }
            catch
            {

                MessageBox.Show("No ha seleccionado ninguna lectura a eliminar");
            }

            
        }

        private void dgv_lecturas_no_pagadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_eliminar.Visible = true;
            row_index = e.RowIndex;
        }

    }
}
