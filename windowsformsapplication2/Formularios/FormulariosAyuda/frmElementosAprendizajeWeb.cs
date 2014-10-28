using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication2.Formularios.FormulariosAyuda
{
    public partial class frmElementosAprendizajeWeb : Form
    {
        Form Forma;
        int id;

        public frmElementosAprendizajeWeb(Form F2,int Id)
        {
            InitializeComponent();
            Forma = F2;
            id = Id;
        }

    
        private void frmElementosAprendizajeWeb_Load(object sender, EventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            this.webbGenerico.Url = new Uri(String.Format("file:///{0}/html/{1}/engage.html", curDir,id));
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Forma.Show();
        }

        private void frmElementosAprendizajeWeb_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forma.Show();
        }
    }
}
