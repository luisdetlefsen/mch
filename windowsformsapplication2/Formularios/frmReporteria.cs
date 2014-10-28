using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApplication2.Formularios;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication2
{
    public partial class frmReporteria : Form
    {
        frmReporteria fforma;
        frmMenu fMenu;
        List<string> camposVisibles;
        string queryReporte;

        public frmReporteria(frmMenu menu)
        {
            fMenu = menu;
            InitializeComponent();
        }

        private void frmReporteria_Load(object sender, EventArgs e)
        {
            ((Control)tabVista).Enabled = true;
            ((Control)tabCampos).Enabled = false;
            ((Control)tabCriterios).Enabled = false;
            ((Control)tabExportar).Enabled = false;

            System.Data.DataTable dtTabla = new System.Data.DataTable();
            Datos.GetReportesMCH(ref dtTabla);
            if (dtTabla.Rows.Count > 0)
            {
                foreach (DataRow dr in dtTabla.Rows)
                {
                    rcReportes.Items.Add(new ItemReporte(Convert.ToString(dr["Nombre"]), Convert.ToString(dr["IdReporte"]), Convert.ToString(dr["Descripcion"]), Convert.ToString(dr["Vista"]), Convert.ToString(dr["Definicion"]), Convert.ToString(dr["Datasource"])));
                }
                rcReportes.SelectedIndex = 0;
            }
        }

        private class ItemCombobox
        {
            public string Text, Value;

            public ItemCombobox()
            {
            }
            public ItemCombobox(string text, string value)
            {
                Text = text; Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private class ItemReporte : ItemCombobox
        {
            public string Descripcion, Vista, Definicion, Datasource;

            public ItemReporte(string text, string value, string descripcion, string vista, string definicion, string datasource)
            {
                Text = text; Value = value; Descripcion = descripcion; Vista = vista; Definicion = definicion; Datasource = datasource;
            }
        }

        private class ItemCampo : ItemCombobox
        {
            public string Descripcion, Campo;
            public int IdTipo, Ordena, Opera;

            public ItemCampo(string name, string campo, string descripcion, int idTipo, int ordena, int opera)
            {
                Text = name; Descripcion = descripcion; Campo = campo; IdTipo = idTipo; Ordena = ordena; Opera = opera;
            }
        }

        #region tabVista
        private void rcReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rcReportes.SelectedItem != null)
            {
                tbDescRep.Text = ((ItemReporte)rcReportes.SelectedItem).Descripcion;
            }
        }

        private void pbSig1_Click(object sender, EventArgs e)
        {
            if (rcReportes.SelectedItem != null)
            {
                ((Control)tabVista).Enabled = false;
                ((Control)tabCampos).Enabled = true;
                tabControl1.SelectedIndex = 1;

                lbDisponibles.Items.Clear();
                tbDescDisp.Text = "";
                dgvCampos.Rows.Clear();
                tbDescSel.Text = "";
                System.Data.DataTable dtTabla = new System.Data.DataTable();
                Datos.GetCamposReporteMCH(Convert.ToInt32(((ItemReporte)rcReportes.SelectedItem).Value), ref dtTabla);
                if (dtTabla.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtTabla.Rows)
                    {
                        lbDisponibles.Items.Add(new ItemCampo(Convert.ToString(dr["Nombre"]), Convert.ToString(dr["NombreCampo"]), Convert.ToString(dr["Descripcion"]), Convert.ToInt32(dr["IdTipo"]), Convert.ToInt32(dr["Ordena"]), Convert.ToInt32(dr["Opera"])));
                    }
                    lbDisponibles.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un reporte.");
                rcReportes.Focus();
            }
        }
        #endregion

        #region tabCampos
        private void lbDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDisponibles.SelectedItem != null)
            {
                tbDescDisp.Text = ((ItemCampo)lbDisponibles.SelectedItem).Descripcion;
            }
            else
            {
                tbDescDisp.Text = "";
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCampos.SelectedRows.Count > 0)
            {
                int index = dgvCampos.SelectedRows[0].Index;
                tbDescSel.Text = Convert.ToString(dgvCampos["descripcionGVcampos", index].Value);
            }
            else
            {
                tbDescSel.Text = "";
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (lbDisponibles.SelectedItem != null)
            {
                foreach (int actual in lbDisponibles.SelectedIndices)
                {

                    int index = dgvCampos.Rows.Add();
                    ItemCampo item = (ItemCampo)lbDisponibles.Items[actual];
                    dgvCampos["nombreGVcampos", index].Value = item.Text;
                    dgvCampos["campoGVcampos", index].Value = item.Campo;
                    dgvCampos["descripcionGVcampos", index].Value = item.Descripcion;
                    dgvCampos["idTipoGVcampos", index].Value = item.IdTipo;
                    dgvCampos["ordenaGVcampos", index].Value = item.Ordena;
                    dgvCampos["operaGVcampos", index].Value = item.Opera;
                    if (item.Ordena == 0)
                    {
                        dgvCampos["comboGVCampos", index].ReadOnly = true;
                    }

                }

                for (int x = lbDisponibles.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    lbDisponibles.Items.RemoveAt(lbDisponibles.SelectedIndices[x]);
                }

                if (lbDisponibles.Items.Count > 0)
                {
                    lbDisponibles.SelectedIndex = 0;
                }
                dgvCampos.ClearSelection();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo disponible.");
            }
        }

        private void btQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCampos.SelectedRows.Count > 0)
            {
                int index = dgvCampos.SelectedRows[0].Index;
                string nombreCampo, descripcionCampo, campo;
                int idTipoCampo, ordenaCampo, operaCampo;
                nombreCampo = Convert.ToString(dgvCampos["nombreGVcampos", index].Value);
                campo = Convert.ToString(dgvCampos["campoGVcampos", index].Value);
                descripcionCampo = Convert.ToString(dgvCampos["descripcionGVcampos", index].Value);
                idTipoCampo = Convert.ToInt32(dgvCampos["idTipoGVcampos", index].Value);
                ordenaCampo = Convert.ToInt32(dgvCampos["ordenaGVcampos", index].Value);
                operaCampo = Convert.ToInt32(dgvCampos["operaGVcampos", index].Value);

                lbDisponibles.Items.Add(new ItemCampo(nombreCampo, campo, descripcionCampo, idTipoCampo, ordenaCampo, operaCampo));

                dgvCampos.Rows.Remove(dgvCampos.Rows[index]);
                if (dgvCampos.Rows.Count > 0)
                {
                    dgvCampos.Rows[0].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo.");
            }
        }

        private void btnSubirCampo_Click(object sender, EventArgs e)
        {
            if (dgvCampos.SelectedRows.Count > 0)
            {
                int totalRows = dgvCampos.Rows.Count;
                int index = dgvCampos.SelectedRows[0].Index;
                if (index == 0)
                    return;
                DataGridViewRowCollection rows = dgvCampos.Rows;
                DataGridViewRow row = rows[index];
                rows.Remove(row);
                rows.Insert(index - 1, row);
                dgvCampos.ClearSelection();
                dgvCampos.Rows[index - 1].Selected = true;
            }
        }

        private void btnBajarCampo_Click(object sender, EventArgs e)
        {
            if (dgvCampos.SelectedRows.Count > 0)
            {
                int totalRows = dgvCampos.Rows.Count;
                int index = dgvCampos.SelectedRows[0].Index;
                if (index == totalRows - 1)
                    return;
                DataGridViewRowCollection rows = dgvCampos.Rows;
                DataGridViewRow row = rows[index];
                rows.Remove(row);
                rows.Insert(index + 1, row);
                dgvCampos.ClearSelection();
                dgvCampos.Rows[index + 1].Selected = true;
            }
        }

        private void pbSig2_Click(object sender, EventArgs e)
        {
            if (dgvCampos.Rows.Count > 0)
            {
                ((Control)tabCampos).Enabled = false;
                ((Control)tabCriterios).Enabled = true;
                tabControl1.SelectedIndex = 2;
                System.Data.DataTable dtTabla = new System.Data.DataTable();
                Datos.GetCamposReporteMCH(Convert.ToInt32(((ItemReporte)rcReportes.SelectedItem).Value), ref dtTabla);
                cbCamposCriterios.Items.Clear();
                foreach (DataRow dr in dtTabla.Rows)
                {
                    cbCamposCriterios.Items.Add(new ItemCampo(Convert.ToString(dr["Nombre"]), Convert.ToString(dr["NombreCampo"]), Convert.ToString(dr["Descripcion"]), Convert.ToInt32(dr["IdTipo"]), Convert.ToInt32(dr["Ordena"]), Convert.ToInt32(dr["Opera"])));
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar por lo menos un campo.");
            }
        }

        private void pbReg2_Click(object sender, EventArgs e)
        {
            ((Control)tabCampos).Enabled = false;
            ((Control)tabVista).Enabled = true;
            tabControl1.SelectedIndex = 0;
        }
        #endregion

        #region tabCriterios
        #region Objetos de Manejo de Criteria
        private enum CriteriaOperador
        {
            Ninguno = 0,
            Mayor = 1,
            MayorIgual = 2,
            Menor = 3,
            MenorIgual = 4,
            Igual = 5,
            Diferente = 6,
            En = 7,
            Como = 8,

            // Estos extras son para poner textos
            Contiene = 9,
            Empieza = 10,
            Termina = 11
        }

        private enum CriteriaUnion
        {
            Ninguno = 0,
            AND = 1,
            OR = 2
        }

        private enum CriteriaTipo
        {
            Segmento = 0,
            Item = 1
        }

        private interface ICriteriaGenericItem
        {
            CriteriaUnion Union { get; set; }
            CriteriaTipo Tipo { get; }
            string ToString();
            string ToString(bool esInicio);

            /// <summary>
            /// Agrega la informacion del criterio a una tabla.
            /// </summary>
            /// <param name="esInicio">Indica si colocar la union para el primer elemento.</param>
            /// <param name="tabla">Tabla a utilizar.</param>
            /// <param name="colUnion">Nombre de la columna que contendra la union. Si nulo entonces se omite.</param>
            /// <param name="colNegar">Nombre de la columna que contendra la negacion. Si nulo entonces se omite.</param>
            /// <param name="colColumna">Nombre de la columna que contendra la columna. Si nulo entonces se omite.</param>
            /// <param name="colOperador">Nombre de la columna que contendra el operador. Si nulo entonces se omite.</param>
            /// <param name="colValor">Nombre de la columna que contendra el valor. Si nulo entonces se omite.</param>
            void GenerarTabla(bool esInicio, System.Data.DataTable tabla, string colUnion, string colNegar, string colColumna, string colOperador, string colValor);

            /// <summary>
            /// Agrega la informacion del criterio a una tabla.
            /// </summary>
            /// <param name="tabla">Tabla a utilizar.</param>
            /// <param name="colUnion">Nombre de la columna que contendra la union. Si nulo entonces se omite.</param>
            /// <param name="colNegar">Nombre de la columna que contendra la negacion. Si nulo entonces se omite.</param>
            /// <param name="colColumna">Nombre de la columna que contendra la columna. Si nulo entonces se omite.</param>
            /// <param name="colOperador">Nombre de la columna que contendra el operador. Si nulo entonces se omite.</param>
            /// <param name="colValor">Nombre de la columna que contendra el valor. Si nulo entonces se omite.</param>
            void GenerarTabla(System.Data.DataTable tabla, string colUnion, string colNegar, string colColumna, string colOperador, string colValor);
        }

        private class CriteriaItem : ICriteriaGenericItem
        {
            private CriteriaUnion union;
            private CriteriaOperador operador;
            private bool negar;
            private string columna;
            private string valor;

            public CriteriaItem()
            {
                this.Union = CriteriaUnion.Ninguno;
                this.Operador = CriteriaOperador.Ninguno;
                this.Columna = null;
                this.Valor = null;
                this.Negar = false;
            }

            public CriteriaItem(CriteriaUnion union, CriteriaOperador operador)
                : this()
            {
                this.Union = union;
                this.Operador = operador;
            }

            public CriteriaItem(CriteriaUnion union, CriteriaOperador operador, string columna, string valor, bool negar)
                : this(union, operador)
            {
                this.Columna = columna;
                this.Valor = valor;
                this.Negar = negar;
            }

            public string Columna
            {
                get { return this.columna; }
                set { this.columna = value; }
            }

            public string Valor
            {
                get { return this.valor; }
                set { this.valor = value; }
            }

            public CriteriaOperador Operador
            {
                get { return this.operador; }
                set { this.operador = value; }
            }

            public bool Negar
            {
                get { return this.negar; }
                set { this.negar = value; }
            }

            #region ICriteriaGenericItem Members
            public CriteriaUnion Union
            {
                get { return this.union; }
                set { this.union = value; }
            }

            public CriteriaTipo Tipo
            {
                get { return CriteriaTipo.Item; }
            }

            /// <summary>
            /// Agrega la informacion del criterio a una tabla.
            /// </summary>
            /// <param name="esInicio">Indica si colocar la union para el primer elemento.</param>
            /// <param name="tabla">Tabla a utilizar.</param>
            /// <param name="colUnion">Nombre de la columna que contendra la union. Si nulo entonces se omite.</param>
            /// <param name="colNegar">Nombre de la columna que contendra la negacion. Si nulo entonces se omite.</param>
            /// <param name="colColumna">Nombre de la columna que contendra la columna. Si nulo entonces se omite.</param>
            /// <param name="colOperador">Nombre de la columna que contendra el operador. Si nulo entonces se omite.</param>
            /// <param name="colValor">Nombre de la columna que contendra el valor. Si nulo entonces se omite.</param>
            public void GenerarTabla(bool esInicio, System.Data.DataTable tabla, string colUnion, string colNegar, string colColumna, string colOperador, string colValor)
            {
                DataRow fila = tabla.NewRow();

                // Union
                if (colUnion != null && !esInicio)
                {
                    switch (this.Union)
                    {
                        case CriteriaUnion.AND:
                            fila[colUnion] = "Y";
                            break;
                        case CriteriaUnion.OR:
                            fila[colUnion] = "O";
                            break;
                        default:
                            fila[colUnion] = string.Empty;
                            break;
                    }
                }

                // Negacion
                if (colNegar != null)
                    fila[colNegar] = (this.Negar) ? "Si" : "No";

                // Columna
                if (colColumna != null)
                    fila[colColumna] = (this.Columna != null) ? this.Columna : string.Empty;

                // Valor
                if (colValor != null)
                    fila[colValor] = (this.Valor != null) ? this.Valor : string.Empty;

                // Operador
                if (colOperador != null)
                {
                    switch (this.Operador)
                    {
                        case CriteriaOperador.Mayor:
                            fila[colOperador] = "Mayor";
                            break;
                        case CriteriaOperador.MayorIgual:
                            fila[colOperador] = "Mayor o Igual";
                            break;
                        case CriteriaOperador.Menor:
                            fila[colOperador] = "Menor";
                            break;
                        case CriteriaOperador.MenorIgual:
                            fila[colOperador] = "Menor o Igual";
                            break;
                        case CriteriaOperador.Igual:
                            fila[colOperador] = "Igual";
                            break;
                        case CriteriaOperador.Diferente:
                            fila[colOperador] = "Diferente";
                            break;
                        case CriteriaOperador.En:
                            fila[colOperador] = "En";
                            break;
                        case CriteriaOperador.Como:
                            fila[colOperador] = "Como";
                            break;
                        // "Contiene", "Empieza" y "Termina" son extras solo para poner un texto descriptivo
                        case CriteriaOperador.Contiene:
                            fila[colOperador] = "Contiene";
                            if (colValor != null)
                                fila[colValor] = (this.Valor != null) ? "\'" + this.Valor.Substring(2, this.Valor.Length - 4) + "\'" : string.Empty;
                            break;
                        case CriteriaOperador.Empieza:
                            fila[colOperador] = "Empieza";
                            if (colValor != null)
                                fila[colValor] = (this.Valor != null) ? this.Valor.Substring(0, this.Valor.Length - 2) + "\'" : string.Empty;
                            break;
                        case CriteriaOperador.Termina:
                            fila[colOperador] = "Termina";
                            if (colValor != null)
                                fila[colValor] = (this.Valor != null) ? "\'" + this.Valor.Substring(2, this.Valor.Length - 2) : string.Empty;
                            break;
                        default:
                            fila[colOperador] = string.Empty;
                            break;
                    }

                    // Evitar omision de la union
                    if (esInicio)
                        esInicio = false;
                }

                // Se agrega la Fila
                tabla.Rows.Add(fila);
            }

            /// <summary>
            /// Agrega la informacion del criterio a una tabla.
            /// </summary>
            /// <param name="tabla">Tabla a utilizar.</param>
            /// <param name="colUnion">Nombre de la columna que contendra la union. Si nulo entonces se omite.</param>
            /// <param name="colNegar">Nombre de la columna que contendra la negacion. Si nulo entonces se omite.</param>
            /// <param name="colColumna">Nombre de la columna que contendra la columna. Si nulo entonces se omite.</param>
            /// <param name="colOperador">Nombre de la columna que contendra el operador. Si nulo entonces se omite.</param>
            /// <param name="colValor">Nombre de la columna que contendra el valor. Si nulo entonces se omite.</param>
            public void GenerarTabla(System.Data.DataTable tabla, string colUnion, string colNegar, string colColumna, string colOperador, string colValor)
            {
                this.GenerarTabla(false, tabla, colUnion, colNegar, colColumna, colOperador, colValor);
            }
            #endregion

            public string ToString(bool esInicio)
            {
                string cadena = string.Empty;

                // Union
                if (!esInicio)
                {
                    switch (this.Union)
                    {
                        case CriteriaUnion.AND:
                            cadena = " AND";
                            break;
                        case CriteriaUnion.OR:
                            cadena = " OR";
                            break;
                        default:
                            cadena = string.Empty;
                            break;
                    }
                }

                // Negacion
                if (this.Negar)
                    cadena += " NOT";

                // Columna
                if (this.Columna != null)
                    cadena += " " + this.Columna;

                // Operador
                switch (this.Operador)
                {
                    case CriteriaOperador.Mayor:
                        cadena += " >";
                        break;
                    case CriteriaOperador.MayorIgual:
                        cadena += " >=";
                        break;
                    case CriteriaOperador.Menor:
                        cadena += " <";
                        break;
                    case CriteriaOperador.MenorIgual:
                        cadena += " <=";
                        break;
                    case CriteriaOperador.Igual:
                        cadena += " =";
                        break;
                    case CriteriaOperador.Diferente:
                        cadena += " <>";
                        break;
                    case CriteriaOperador.En:
                        cadena += " IN";
                        break;
                    case CriteriaOperador.Como:
                    // "Contiene", "Empieza" y "Termina" son extras solo para poner un texto descriptivo
                    case CriteriaOperador.Contiene:
                    case CriteriaOperador.Empieza:
                    case CriteriaOperador.Termina:
                        cadena += " LIKE";
                        break;
                }

                // Valor
                if (this.Valor != null)
                    cadena += " " + this.Valor;

                return cadena;
            }

            public override string ToString()
            {
                return this.ToString(false);
            }
        }

        private class CriteriaSegmento : ICriteriaGenericItem
        {
            private List<ICriteriaGenericItem> items;
            private CriteriaUnion union;
            private bool negar;

            public CriteriaSegmento()
            {
                this.items = new List<ICriteriaGenericItem>();
                this.Union = CriteriaUnion.Ninguno;
            }

            public CriteriaSegmento(CriteriaUnion union)
                : this()
            {
                this.Union = union;
            }

            public List<ICriteriaGenericItem> Items
            {
                get { return this.items; }
                protected set { this.items = value; }
            }

            public ICriteriaGenericItem this[int index]
            {
                get { return this.Items[index]; }
                protected set { this.Items[index] = value; }
            }

            public void Agregar(ICriteriaGenericItem item)
            {
                this.Items.Add(item);
            }

            public void Agregar(int index, ICriteriaGenericItem item)
            {
                this.Items.Insert(index, item);
            }

            public void Remover(ICriteriaGenericItem item)
            {
                this.Items.Remove(item);
            }

            public ICriteriaGenericItem Remover(int index)
            {
                ICriteriaGenericItem item = this.Items[index];
                this.Remover(item);
                return item;
            }

            /// <summary>
            /// Busca un elemento por el pseudo indice.
            /// </summary>
            /// <remarks>
            /// El pseudo indice toma en cuenta los elementos en los
            /// subsegmentos para la numeracion del indice.
            /// </remarks>
            /// <param name="pseudoIndex">Pseudo indice del elemento a buscar.</param>
            /// <param name="item">Elemento del pseudo indice o nulo si no existe.</param>
            /// <param name="segmento">Segmento del pseudo indice o nulo si no existe el elemento.</param>
            /// <returns>True si la busqueda fue exitosa o false si no lo fue.</returns>
            public bool Buscar(int pseudoIndex, out ICriteriaGenericItem item, out CriteriaSegmento segmento, out int posicion, out bool finalSubSegmento)
            {
                Stack<KeyValuePair<CriteriaSegmento, int>> recorrido;
                KeyValuePair<CriteriaSegmento, int> lugar;
                CriteriaSegmento segmentoAux;
                int index;
                int posicionAux;

                posicionAux = -1;
                index = -1;
                finalSubSegmento = false;
                segmentoAux = this;
                recorrido = new Stack<KeyValuePair<CriteriaSegmento, int>>();
                while (pseudoIndex > index)
                {
                    index++;
                    posicionAux++;

                    // Salir del segmento al llegar al limite
                    if (posicionAux > segmentoAux.Contar - 1)
                    {
                        // Salir si el recorrido termino
                        if (recorrido.Count < 1)
                            break;

                        // Se carga el segmento anterior
                        lugar = recorrido.Pop();
                        segmentoAux = lugar.Key;
                        posicionAux = lugar.Value;

                        // Continuar cuando no es el elemento
                        if (pseudoIndex != index)
                            continue;

                        // Se indica que es el final de un subsegmento y se retorna el elemento
                        item = segmentoAux[posicionAux];
                        segmento = segmentoAux;
                        posicion = posicionAux;
                        finalSubSegmento = true;
                        return true;
                    }

                    // Salir, y retoarnar el elemento y segmento cuando se encuentre
                    if (pseudoIndex == index)
                    {
                        item = segmentoAux[posicionAux];
                        segmento = segmentoAux;
                        posicion = posicionAux;
                        return true;
                    }

                    // Si es un segmento entonces ingresar
                    if (segmentoAux[posicionAux].Tipo == CriteriaTipo.Segmento)
                    {
                        // Ingresar al sub segmento cuando contenga el pseudo indice
                        // (Se considera cada subsegmento como 2 elementos extra)
                        recorrido.Push(new KeyValuePair<CriteriaSegmento, int>(segmentoAux, posicionAux));
                        segmentoAux = (CriteriaSegmento)segmentoAux[posicionAux];
                        posicionAux = -1;
                        continue;
                    }
                }

                // No se encontro el elemento;
                item = null;
                segmento = null;
                posicion = -1;
                return false;
            }

            /// <summary>
            /// Busca y remueve un elemento por el pseudo indice.
            /// </summary>
            /// <remarks>
            /// El pseudo indice toma en cuenta los elementos en los
            /// subsegmentos para la numeracion del indice.
            /// </remarks>
            /// <param name="pseudoIndex">Pseudo indice del elemento a remover.</param>
            /// <returns>Elemento del pseudo indice removido o nulo si no existe.</returns>
            public ICriteriaGenericItem BuscarYRemover(int pseudoIndex)
            {
                ICriteriaGenericItem item;
                CriteriaSegmento segmento;
                int posicion;
                bool finalSubSegmento;
                if (!this.Buscar(pseudoIndex, out item, out segmento, out posicion, out finalSubSegmento))
                    return null;

                segmento.Remover(item);
                return item;
            }

            /// <summary>
            /// Busca el pseudo indice y agrega un elemento.
            /// </summary>
            /// <remarks>
            /// El pseudo indice toma en cuenta los elementos en los
            /// subsegmentos para la numeracion del indice.
            /// </remarks>
            /// <param name="pseudoIndex">Pseudo indice del elemento a remover.</param>
            /// <returns>True si se encontro la pseudo posicion y agrego exitosamente o false si no lo fue.</returns>
            public bool BuscarYAgregar(int pseudoIndex, ICriteriaGenericItem item)
            {
                ICriteriaGenericItem itemAux;
                CriteriaSegmento segmento;
                int posicion;
                bool finalSubSegmento;
                if (!this.Buscar(pseudoIndex, out itemAux, out segmento, out posicion, out finalSubSegmento))
                    return false;

                // Se posiciona en la siguiente posicion
                posicion++;

                // Si el elemento es un segmento
                if (itemAux.Tipo == CriteriaTipo.Segmento)
                {
                    // Agregar dentro del sub segmento cuando no sea index final
                    if (!finalSubSegmento)
                    {
                        segmento = (CriteriaSegmento)itemAux;
                        if (segmento.Contar > 0)
                            segmento.Agregar(0, item);
                        else
                            segmento.Agregar(item);
                        return true;
                    }

                    // Agregar al final del segmento cuando posicion final
                    if (posicion > segmento.Contar - 1)
                    {
                        segmento.Agregar(item);
                        return true;
                    }
                }

                segmento.Agregar(posicion, item);
                return true;
            }

            public ICriteriaGenericItem Dequeue()
            {
                int cantidad = this.Items.Count;
                if (cantidad < 1)
                    return null;
                return this.Remover(cantidad - 1);
            }

            public void Queue(ICriteriaGenericItem item)
            {
                this.Items.Insert(0, item);
            }

            public int Contar
            {
                get { return this.Items.Count; }
            }

            #region ICriteriaGenericItem Members
            public CriteriaUnion Union
            {
                get { return this.union; }
                set { this.union = value; }
            }

            public CriteriaTipo Tipo
            {
                get { return CriteriaTipo.Segmento; }
            }
            #endregion

            public string ToString(bool esInicio)
            {
                string cadena = string.Empty;
                string aux = null;

                // Items
                foreach (ICriteriaGenericItem item in this.Items)
                {
                    switch (item.Tipo)
                    {
                        case CriteriaTipo.Item:
                            cadena += item.ToString(esInicio);
                            break;
                        case CriteriaTipo.Segmento:
                            aux = item.ToString(true);
                            if (string.IsNullOrEmpty(aux))
                                continue;

                            // Union
                            if (!esInicio)
                            {
                                switch (item.Union)
                                {
                                    case CriteriaUnion.AND:
                                        cadena += " AND";
                                        break;
                                    case CriteriaUnion.OR:
                                        cadena += " OR";
                                        break;
                                    default:
                                        break;
                                }
                            }
                            cadena += " (" + aux + ")";
                            break;
                    }

                    // Evitar omision de la union
                    if (esInicio)
                        esInicio = false;
                }

                return cadena;
            }

            public override string ToString()
            {
                return this.ToString(false);
            }

            /// <summary>
            /// Agrega los criterios y sub segmentos a una tabla.
            /// </summary>
            /// <param name="esInicio">Indica si colocar la union para el primer elemento.</param>
            /// <param name="tabla">Tabla a utilizar.</param>
            /// <param name="colUnion">Nombre de la columna que contendra la union. Si nulo entonces se omite.</param>
            /// <param name="colNegar">Nombre de la columna que contendra la negacion. Si nulo entonces se omite.</param>
            /// <param name="colColumna">Nombre de la columna que contendra la columna. Si nulo entonces se omite.</param>
            /// <param name="colOperador">Nombre de la columna que contendra el operador. Si nulo entonces se omite.</param>
            /// <param name="colValor">Nombre de la columna que contendra el valor. Si nulo entonces se omite.</param>
            public void GenerarTabla(bool esInicio, System.Data.DataTable tabla, string colUnion, string colNegar, string colColumna, string colOperador, string colValor)
            {
                // Items
                foreach (ICriteriaGenericItem item in this.Items)
                {
                    switch (item.Tipo)
                    {
                        case CriteriaTipo.Item:
                            // Se agrega el criterio
                            item.GenerarTabla(esInicio, tabla, colUnion, colNegar, colColumna, colOperador, colValor);
                            break;
                        case CriteriaTipo.Segmento:
                            DataRow fila = tabla.NewRow();

                            // Union
                            if (esInicio)
                                fila[colUnion] = "(";
                            else if (colUnion != null)
                            {
                                switch (item.Union)
                                {
                                    case CriteriaUnion.AND:
                                        fila[colUnion] = "Y (";
                                        break;
                                    case CriteriaUnion.OR:
                                        fila[colUnion] = "O (";
                                        break;
                                    default:
                                        fila[colUnion] = "(";
                                        break;
                                }
                            }

                            // Columnas no utilizadas
                            if (colNegar != null)
                                fila[colNegar] = string.Empty;
                            if (colColumna != null)
                                fila[colColumna] = string.Empty;
                            if (colOperador != null)
                                fila[colOperador] = string.Empty;
                            if (colValor != null)
                                fila[colValor] = string.Empty;

                            // Se agrega la union con parentesis
                            tabla.Rows.Add(fila);

                            // Se agregan los criterios del sub segmento
                            item.GenerarTabla(tabla, colUnion, colNegar, colColumna, colOperador, colValor);

                            // Se agrega el parentesis final
                            fila = tabla.NewRow();
                            if (colUnion != null)
                                fila[colUnion] = ")";
                            if (colNegar != null)
                                fila[colNegar] = string.Empty;
                            if (colColumna != null)
                                fila[colColumna] = string.Empty;
                            if (colOperador != null)
                                fila[colOperador] = string.Empty;
                            if (colValor != null)
                                fila[colValor] = string.Empty;
                            tabla.Rows.Add(fila);
                            break;
                    }

                    // Evitar omision de la union
                    if (esInicio)
                        esInicio = false;
                }
            }

            /// <summary>
            /// Agrega los criterios y sub segmentos a una tabla.
            /// </summary>
            /// <param name="tabla">Tabla a utilizar.</param>
            /// <param name="colUnion">Nombre de la columna que contendra la union. Si nulo entonces se omite.</param>
            /// <param name="colNegar">Nombre de la columna que contendra la negacion. Si nulo entonces se omite.</param>
            /// <param name="colColumna">Nombre de la columna que contendra la columna. Si nulo entonces se omite.</param>
            /// <param name="colOperador">Nombre de la columna que contendra el operador. Si nulo entonces se omite.</param>
            /// <param name="colValor">Nombre de la columna que contendra el valor. Si nulo entonces se omite.</param>
            public void GenerarTabla(System.Data.DataTable tabla, string colUnion, string colNegar, string colColumna, string colOperador, string colValor)
            {
                this.GenerarTabla(true, tabla, colUnion, colNegar, colColumna, colOperador, colValor);
            }

            /// <summary>
            /// Genera una tabla con las columnas proporcionadas y la informacion de los criterios y sub segmentos.
            /// </summary>
            /// <param name="colUnion">Nombre de la columna que contendra la union. Si nulo entonces se omite.</param>
            /// <param name="colNegar">Nombre de la columna que contendra la negacion. Si nulo entonces se omite.</param>
            /// <param name="colColumna">Nombre de la columna que contendra la columna. Si nulo entonces se omite.</param>
            /// <param name="colOperador">Nombre de la columna que contendra el operador. Si nulo entonces se omite.</param>
            /// <param name="colValor">Nombre de la columna que contendra el valor. Si nulo entonces se omite.</param>
            /// <returns>Tabla generada con los criterios y sub segmentos.</returns>
            public System.Data.DataTable GenerarTabla(string colUnion, string colNegar, string colColumna, string colOperador, string colValor)
            {
                System.Data.DataTable tabla = new System.Data.DataTable();
                if (colUnion != null)
                    tabla.Columns.Add(colUnion, typeof(string));
                if (colNegar != null)
                    tabla.Columns.Add(colNegar, typeof(string));
                if (colColumna != null)
                    tabla.Columns.Add(colColumna, typeof(string));
                if (colOperador != null)
                    tabla.Columns.Add(colOperador, typeof(string));
                if (colValor != null)
                    tabla.Columns.Add(colValor, typeof(string));
                this.GenerarTabla(true, tabla, colUnion, colNegar, colColumna, colOperador, colValor);
                return tabla;
            }
        }
        #endregion

        // Constantes para la tabla de criterios
        protected const string COLUMNA_UNION = "Union";
        protected const string COLUMNA_NEGAR = null;
        protected const string COLUMNA_CAMPO = "Campo";
        protected const string COLUMNA_CRITERIO = "Criterio";
        protected const string COLUMNA_VALOR = "Valor";
        protected const string CB_OPERACION_MAYOR = ">";
        protected const string CB_OPERACION_MAYOR_IGUAL = ">=";
        protected const string CB_OPERACION_MENOR = "<";
        protected const string CB_OPERACION_MENOR_IGUAL = "<=";
        protected const string CB_OPERACION_IGUAL = "=";
        protected const string CB_OPERACION_DISTINTO = "<>";
        protected const string CB_OPERACION_CONTIENE = "contiene";
        protected const string CB_OPERACION_EMPIEZA = "empieza";
        protected const string CB_OPERACION_TERMINA = "termina";

        // Segmento principal de Criterios
        private CriteriaSegmento segmentoCriterios = new CriteriaSegmento();

        // Tabla para desplegar los criterios
        private System.Data.DataTable tablaCriterios = null;

        private int ObtenerGridCriteriaIndexSeleccionado()
        {
            if (this.dgvCriterios.SelectedRows.Count < 1)
                return -1;
            return this.dgvCriterios.Rows.IndexOf(dgvCriterios.SelectedRows[0]);
        }

        private CriteriaOperador ParsearOperadorCriterio(string valor)
        {
            switch (valor)
            {
                case CB_OPERACION_MAYOR:
                    return CriteriaOperador.Mayor;
                case CB_OPERACION_MAYOR_IGUAL:
                    return CriteriaOperador.MayorIgual;
                case CB_OPERACION_MENOR:
                    return CriteriaOperador.Menor;
                case CB_OPERACION_MENOR_IGUAL:
                    return CriteriaOperador.MenorIgual;
                case CB_OPERACION_IGUAL:
                    return CriteriaOperador.Igual;
                case CB_OPERACION_DISTINTO:
                    return CriteriaOperador.Diferente;
                case CB_OPERACION_CONTIENE:
                    return CriteriaOperador.Contiene;
                case CB_OPERACION_EMPIEZA:
                    return CriteriaOperador.Empieza;
                case CB_OPERACION_TERMINA:
                    return CriteriaOperador.Termina;
                default:
                    return CriteriaOperador.Ninguno;
            }
        }

        private string ParsearValorCriterio(string valor, CriteriaOperador operador)
        {
            int TipoSeleccionado = ((ItemCampo)cbCamposCriterios.SelectedItem).IdTipo;
            switch (TipoSeleccionado)
            {
                case 2:
                    // Numerico
                    float valorNumerico;
                    if (!float.TryParse(valor, out valorNumerico))
                    {
                        MessageBox.Show("Debe ingresar un valor numerico para el criterio.");
                        mtbValor.Focus();
                        return null;
                    }
                    return valorNumerico.ToString();
                    break;
                case 5:
                    // Numerico
                    float valorNumerico2;
                    if (!float.TryParse(valor, out valorNumerico2))
                    {
                        MessageBox.Show("Debe ingresar un valor numerico para el criterio.");
                        mtbValor.Focus();
                        return null;
                    }
                    return valorNumerico2.ToString();
                    break;
                case 3:
                    // Fecha
                    DateTime valorFecha;
                    if (!DateTime.TryParse(valor, out valorFecha))
                    {
                        MessageBox.Show("Debe ingresar una fecha valida para el criterio.");
                        mtbValor.Focus();
                        return null;
                    }
                    return valorFecha.ToString("yyyy-MM-dd");
                    break;
                case 1:
                    // Cadena
                    string valorFiltro = null;
                    switch (operador)
                    {
                        case CriteriaOperador.Contiene:
                            valorFiltro = "%" + valor + "%";
                            break;
                        case CriteriaOperador.Empieza:
                            valorFiltro = valor + "%";
                            break;
                        case CriteriaOperador.Termina:
                            valorFiltro = "%" + valor;
                            break;
                        default:
                            valorFiltro = valor;
                            break;
                    }
                    return "'" + valorFiltro + "'";
                    break;
                default:
                    return null;
                    break;
            }
        }

        /// <summary>
        /// Actualiza el grid de criterios.
        /// </summary>
        private void ActualizarGridCriteria()
        {
            // Crear y asignar tabla de criterios si no existe
            if (tablaCriterios == null)
            {
                this.tablaCriterios = this.segmentoCriterios.GenerarTabla(
                    COLUMNA_UNION,
                    COLUMNA_NEGAR,
                    COLUMNA_CAMPO,
                    COLUMNA_CRITERIO,
                    COLUMNA_VALOR);
                this.dgvCriterios.Rows.Clear();
                this.dgvCriterios.Columns.Clear();
                this.dgvCriterios.AutoGenerateColumns = true;
                this.dgvCriterios.DataSource = this.tablaCriterios;
            }

            this.tablaCriterios.Rows.Clear();
            this.segmentoCriterios.GenerarTabla(
                    true,
                    this.tablaCriterios,
                    COLUMNA_UNION,
                    COLUMNA_NEGAR,
                    COLUMNA_CAMPO,
                    COLUMNA_CRITERIO,
                    COLUMNA_VALOR);
        }

        private bool ValidarCampoUnion(out CriteriaUnion union)
        {
            // Validar el Campo Union
            union = CriteriaUnion.Ninguno;
            int pseudoIndex = this.ObtenerGridCriteriaIndexSeleccionado();
            // No requerido cuando es el primer criterio
            if (segmentoCriterios.Contar < 1)
                return true;
            if (cbUnion.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una union.");
                cbUnion.Focus();
                return false;
            }

            if (cbUnion.SelectedItem.ToString() == "Y")
                union = CriteriaUnion.AND;
            else if (cbUnion.SelectedItem.ToString() == "O")
                union = CriteriaUnion.OR;
            return true;
        }

        private void cbCamposCriterios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TipoSeleccionado = ((ItemCampo)cbCamposCriterios.SelectedItem).IdTipo;
            cbCondicion.Items.Clear();
            mtbValor.Text = "";
            switch (TipoSeleccionado)
            {
                case 2:
                case 3:
                    //numerico y fecha
                    cbCondicion.Items.Add(new ItemCombobox("Mayor que", CB_OPERACION_MAYOR));
                    cbCondicion.Items.Add(new ItemCombobox("Mayor o igual que", CB_OPERACION_MAYOR_IGUAL));
                    cbCondicion.Items.Add(new ItemCombobox("Menor que", CB_OPERACION_MENOR));
                    cbCondicion.Items.Add(new ItemCombobox("Menor o igual que", CB_OPERACION_MENOR_IGUAL));
                    cbCondicion.Items.Add(new ItemCombobox("Igual que", CB_OPERACION_IGUAL));
                    cbCondicion.Items.Add(new ItemCombobox("Distinto que", CB_OPERACION_DISTINTO));

                    //numerico
                    if (TipoSeleccionado == 2)
                    {
                        mtbValor.Mask = "9999999999.99";
                        break;
                    }

                    //fecha
                    mtbValor.Mask = "00/00/0000";
                    break;
                case 5:
                    //numerico y fecha
                    cbCondicion.Items.Add(new ItemCombobox("Mayor que", CB_OPERACION_MAYOR));
                    cbCondicion.Items.Add(new ItemCombobox("Mayor o igual que", CB_OPERACION_MAYOR_IGUAL));
                    cbCondicion.Items.Add(new ItemCombobox("Menor que", CB_OPERACION_MENOR));
                    cbCondicion.Items.Add(new ItemCombobox("Menor o igual que", CB_OPERACION_MENOR_IGUAL));
                    cbCondicion.Items.Add(new ItemCombobox("Igual que", CB_OPERACION_IGUAL));
                    cbCondicion.Items.Add(new ItemCombobox("Distinto que", CB_OPERACION_DISTINTO));

                    //numerico
                    if (TipoSeleccionado == 5)
                    {
                        mtbValor.Mask = "9999999999.99";
                        break;
                    }

                    //fecha
                    mtbValor.Mask = "00/00/0000";
                    break;
                case 1:
                    //cadena
                    cbCondicion.Items.Add(new ItemCombobox("Igual que", CB_OPERACION_IGUAL));
                    cbCondicion.Items.Add(new ItemCombobox("Distinto que", CB_OPERACION_DISTINTO));
                    cbCondicion.Items.Add(new ItemCombobox("Contiene", CB_OPERACION_CONTIENE));
                    cbCondicion.Items.Add(new ItemCombobox("Empieza", CB_OPERACION_EMPIEZA));
                    cbCondicion.Items.Add(new ItemCombobox("Termina", CB_OPERACION_TERMINA));
                    mtbValor.Mask = "";
                    break;
                default:
                    break;
            }
        }

        private void cbCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbValor.Focus();
        }

        private void btAgregarCriterio_Click(object sender, EventArgs e)
        {
            CriteriaUnion union = CriteriaUnion.Ninguno;
            CriteriaOperador operador = CriteriaOperador.Ninguno;
            CriteriaItem item;
            string campo;
            string operador_cadena;
            string valor;
            int pseudoIndex;

            // Validar el campo Criterios
            if (cbCamposCriterios.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un campo.");
                cbCamposCriterios.Focus();
                return;
            }

            // Validar el campo Union
            if (!this.ValidarCampoUnion(out union))
                return;

            // Validar el Campo Condicion
            if (cbCondicion.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un criterio.");
                cbCondicion.Focus();
                return;
            }

            // Validar el campo Valor
            if (string.IsNullOrEmpty(mtbValor.Text))
            {
                MessageBox.Show("Debe ingresar un valor.");
                mtbValor.Focus();
                return;
            }

            // Validar cuando el valor es una fecha
            DateTime Fecha;
            if (((ItemCampo)cbCamposCriterios.SelectedItem).IdTipo == 3 && !DateTime.TryParse(mtbValor.Text, out Fecha))
            {
                MessageBox.Show("El formato de la fecha es incorrecto.");
                mtbValor.Focus();
                return;
            }

            // Parsear informacion
            operador_cadena = ((ItemCombobox)cbCondicion.SelectedItem).Value;
            campo = ((ItemCampo)cbCamposCriterios.SelectedItem).Campo;
            operador = this.ParsearOperadorCriterio(operador_cadena);
            valor = this.ParsearValorCriterio(mtbValor.Text, operador);
            if (valor == null)
                return;

            // Agregar criterio y actualizar tabla de criterios
            pseudoIndex = this.ObtenerGridCriteriaIndexSeleccionado();
            item = new CriteriaItem(union, operador, campo, valor, false);
            if (pseudoIndex < 0)
                this.segmentoCriterios.Agregar(item);
            else
                this.segmentoCriterios.BuscarYAgregar(pseudoIndex, item);

            // Se acutaliza el grid de criterios
            this.ActualizarGridCriteria();

            //int indexNewRow = dgvCriterios.Rows.Add();
            //dgvCriterios["Campo", indexNewRow].Value = ((ItemCampo)cbCamposCriterios.SelectedItem).Text;
            //dgvCriterios["ValueCampo", indexNewRow].Value = ((ItemCampo)cbCamposCriterios.SelectedItem).Campo;
            //dgvCriterios["Criterio", indexNewRow].Value = ((ItemCombobox)cbCondicion.SelectedItem).Text;
            //dgvCriterios["ValueCriterio", indexNewRow].Value = ((ItemCombobox)cbCondicion.SelectedItem).Value;
            //dgvCriterios["Valor", indexNewRow].Value = mtbValor.Text;
        }

        private void btAgregarSubSegmento_Click(object sender, EventArgs e)
        {
            CriteriaUnion union = CriteriaUnion.Ninguno;
            CriteriaSegmento segmento;
            int pseudoIndex;

            // Validar el campo Union
            if (!this.ValidarCampoUnion(out union))
                return;

            // Agregar sub segmento
            pseudoIndex = this.ObtenerGridCriteriaIndexSeleccionado();
            segmento = new CriteriaSegmento(union);
            if (pseudoIndex < 0)
                this.segmentoCriterios.Agregar(segmento);
            else
                this.segmentoCriterios.BuscarYAgregar(pseudoIndex, segmento);

            // Se acutaliza el grid de criterios
            this.ActualizarGridCriteria();
        }

        private void btQuitarCriterio_Click(object sender, EventArgs e)
        {
            int pseudoIndex = this.ObtenerGridCriteriaIndexSeleccionado();
            if (pseudoIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un criterio para poder eliminarlo");
                return;
            }

            // Se advierte si es un sub segmento
            DataRow fila = this.tablaCriterios.Rows[pseudoIndex];
            if (fila[COLUMNA_CAMPO].ToString() == string.Empty)
            {
                DialogResult resultado = MessageBox.Show(
                    "Realmente desea eliminar esta agrupacion de criterios y todos los criterios que contiene?",
                    "Quitar Criterio",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (resultado != DialogResult.Yes)
                    return;
            }

            // Se elimina el criterio seleccionado
            this.segmentoCriterios.BuscarYRemover(pseudoIndex);
            this.ActualizarGridCriteria();
        }

        private string traducirCriterio(string criterio, string valor)
        {
            string result = "";
            switch (criterio)
            {
                case "like1":
                    {
                        result = "like '%" + valor + "%'";
                        break;
                    }
                case "like2":
                    {
                        result = "like '" + valor + "%'";
                        break;
                    }
                case "like3":
                    {
                        result = "like '%" + valor + "'";
                        break;
                    }
                default:
                    {
                        result = criterio + " " + valor;
                        break;
                    }
            }
            return result;
        }

        private void pbSig3_Click(object sender, EventArgs e)
        {
            /* Se debe validar antes de pasar a la siguiente pestaña*/
            ((Control)tabCriterios).Enabled = false;
            ((Control)tabExportar).Enabled = true;

            string Campos = "", Criterios = "", Ordenamiento = "";
            camposVisibles = new List<string>();

            // Campos a mostrar y agrupamiento
            foreach (DataGridViewRow row in dgvCampos.Rows)
            {
                if (Campos == "")
                {
                    Campos = "SELECT " + Convert.ToString(row.Cells["campoGVcampos"].Value);
                }
                else
                {
                    Campos += ", " + Convert.ToString(row.Cells["campoGVcampos"].Value);
                }
                camposVisibles.Add(Convert.ToString(row.Cells["campoGVcampos"].Value));

                if (Convert.ToInt32(row.Cells["ordenaGVcampos"].Value) == 1)
                {
                    string tipoOrdena = (Convert.ToString(row.Cells["comboGVcampos"].Value) == "Ascendente") ? "ASC" : "DESC";
                    if (Ordenamiento == "")
                    {
                        Ordenamiento = " ORDER BY " + Convert.ToString(row.Cells["campoGVcampos"].Value) + " " + tipoOrdena;
                    }
                    else
                    {
                        Ordenamiento += ", " + Convert.ToString(row.Cells["campoGVcampos"].Value) + " " + tipoOrdena;
                    }
                }
            }

            Campos += " FROM " + ((ItemReporte)rcReportes.SelectedItem).Vista.ToString();

            Criterios = (!string.IsNullOrEmpty(segmentoCriterios.ToString())) ? " WHERE " + segmentoCriterios.ToString() : "";

            queryReporte = Campos + " " + Criterios + " " + Ordenamiento;

            tbResumen.Text = "";

            tbResumen.Text = "\r\nReporte: " + ((ItemReporte)rcReportes.SelectedItem).Text;
            tbResumen.Text += "\r\n\r\nCampos seleccionados: ";
            foreach (DataGridViewRow row in dgvCampos.Rows)
            {
                tbResumen.Text += "\r\n - " + row.Cells["campoGVcampos"].Value;
            }
            if (!string.IsNullOrEmpty(segmentoCriterios.ToString()))
            {
                tbResumen.Text += "\r\n\r\nCriterios:" + segmentoCriterios.ToString();
            }

            tabControl1.SelectedIndex = 3;
        }

        private void pbReg3_Click(object sender, EventArgs e)
        {
            ((Control)tabCriterios).Enabled = false;
            ((Control)tabCampos).Enabled = true;
            tabControl1.SelectedIndex = 1;
        }
        #endregion

        #region tabExportar
        private void pbFin_Click(object sender, EventArgs e)
        {
            ReportParameter[] Parametros = null;
            try
            {
                System.Data.DataTable dtTabla = new System.Data.DataTable();
                Datos.GetDataQueryMCH(queryReporte, ref dtTabla);
                string definicionReporte = ((ItemReporte)rcReportes.SelectedItem).Definicion.ToString();
                switch (definicionReporte)
                {
                    case "RstatusPago.rdlc":
                        {
                            Parametros = new ReportParameter[12];
                            Parametros[0] = new ReportParameter("PNoPersona", (!camposVisibles.Contains("No_Persona")).ToString());
                            Parametros[1] = new ReportParameter("PCUI", (!camposVisibles.Contains("CUI")).ToString());
                            Parametros[2] = new ReportParameter("PPersona", (!camposVisibles.Contains("Persona")).ToString());
                            Parametros[3] = new ReportParameter("PNoContrato", (!camposVisibles.Contains("No_Contrato")).ToString());
                            Parametros[4] = new ReportParameter("PNoLectura", (!camposVisibles.Contains("No_Lectura")).ToString());
                            Parametros[5] = new ReportParameter("PFechaLectura", (!camposVisibles.Contains("Fecha_Lectura")).ToString());
                            Parametros[6] = new ReportParameter("PDiaLectura", (!camposVisibles.Contains("Dia_Lectura")).ToString());
                            Parametros[7] = new ReportParameter("PMesLectura", (!camposVisibles.Contains("Mes_Lectura")).ToString());
                            Parametros[8] = new ReportParameter("PAñoLectura", (!camposVisibles.Contains("Año_Lectura")).ToString());
                            Parametros[9] = new ReportParameter("PLectura", (!camposVisibles.Contains("Lectura")).ToString());
                            Parametros[10] = new ReportParameter("PSaldo", (!camposVisibles.Contains("Saldo")).ToString());
                            Parametros[11] = new ReportParameter("PEstatus", (!camposVisibles.Contains("Status")).ToString());
                            break;
                        }
                    case "RestadoCta.rdlc":
                        {
                            Parametros = new ReportParameter[24];
                            Parametros[0] = new ReportParameter("ID_Persona", (!camposVisibles.Contains("ID_Persona")).ToString());
                            Parametros[1] = new ReportParameter("CUI", (!camposVisibles.Contains("CUI")).ToString());
                            Parametros[2] = new ReportParameter("Nombre", (!camposVisibles.Contains("Nombre")).ToString());
                            Parametros[3] = new ReportParameter("No_Registro", (!camposVisibles.Contains("No_Registro")).ToString());
                            Parametros[4] = new ReportParameter("No_Cedula", (!camposVisibles.Contains("No_Cedula")).ToString());
                            Parametros[5] = new ReportParameter("Sexo", (!camposVisibles.Contains("Sexo")).ToString());
                            Parametros[6] = new ReportParameter("Fecha_Nacimiento", (!camposVisibles.Contains("Fecha_Nacimiento")).ToString());
                            Parametros[7] = new ReportParameter("Mes_Nacimiento", (!camposVisibles.Contains("Mes_Nacimiento")).ToString());
                            Parametros[8] = new ReportParameter("Dia_Nacimiento", (!camposVisibles.Contains("Dia_Nacimiento")).ToString());
                            Parametros[9] = new ReportParameter("Año_Nacimiento", (!camposVisibles.Contains("Año_Nacimiento")).ToString());
                            Parametros[10] = new ReportParameter("ID_Contrato", (!camposVisibles.Contains("ID_Contrato")).ToString());
                            Parametros[11] = new ReportParameter("ID_Lectura", (!camposVisibles.Contains("ID_Lectura")).ToString());
                            Parametros[12] = new ReportParameter("Fecha_Lectura", (!camposVisibles.Contains("Fecha_Lectura")).ToString());
                            Parametros[13] = new ReportParameter("Mes_Lectura", (!camposVisibles.Contains("Mes_Lectura")).ToString());
                            Parametros[14] = new ReportParameter("Dia_Lectura", (!camposVisibles.Contains("Dia_Lectura")).ToString());
                            Parametros[15] = new ReportParameter("Año_Lectura", (!camposVisibles.Contains("Año_Lectura")).ToString());
                            Parametros[16] = new ReportParameter("Lectura", (!camposVisibles.Contains("Lectura")).ToString());
                            Parametros[17] = new ReportParameter("Monto", (!camposVisibles.Contains("Monto")).ToString());
                            Parametros[18] = new ReportParameter("Concepto", (!camposVisibles.Contains("Concepto")).ToString());
                            Parametros[19] = new ReportParameter("Fecha_Pago", (!camposVisibles.Contains("Fecha_Pago")).ToString());
                            Parametros[20] = new ReportParameter("Cargo", (!camposVisibles.Contains("Cargo")).ToString());
                            Parametros[21] = new ReportParameter("Abono", (!camposVisibles.Contains("Abono")).ToString());
                            Parametros[22] = new ReportParameter("Tipo", (!camposVisibles.Contains("Tipo")).ToString());
                            Parametros[23] = new ReportParameter("Operacion", (!camposVisibles.Contains("Operacion")).ToString());
                            break;
                        }
                }
                ReportDataSource rptDataSource = new ReportDataSource(((ItemReporte)rcReportes.SelectedItem).Datasource.ToString(), dtTabla);
                DirectoryInfo myDirectory = new DirectoryInfo(Environment.CurrentDirectory);
                string parentDirectory = myDirectory.Parent.Parent.FullName;
                frmReporteriaPreview frmPreview = new frmReporteriaPreview(parentDirectory + "\\" + definicionReporte, rptDataSource, Parametros);
                frmPreview.ShowDialog(this);

            }
            catch (Exception exc)
            {

            }
            finally
            {

            }
        }

        private void pbReg5_Click(object sender, EventArgs e)
        {
            ((Control)tabExportar).Enabled = false;
            ((Control)tabCriterios).Enabled = true;
            tabControl1.SelectedIndex = 2;
        }
        #endregion

        private void frmReporteria_FormClosed(object sender, FormClosedEventArgs e)
        {
            fMenu.Show();   
        }
    }
}
