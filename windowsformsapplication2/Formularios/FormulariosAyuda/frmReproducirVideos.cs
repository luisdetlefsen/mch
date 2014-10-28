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
    public partial class frmReproducirVideo : Form
    {
        string strDireccionVideo;
        string strDireccionVideoEfecto;
        string strTit;
        bool blEjecutarVideo;
        bool blPlayVideo;
        Form Forma;
        //frmAyudaVideoContador fForma3;
        bool bSalir;
        public frmReproducirVideo(string strDirVideo,string strTitulo, Form F2,string strDirVideoE)
        {
            strDireccionVideo = strDirVideo;
            strDireccionVideoEfecto = strDirVideoE;
            strTit = strTitulo;
            InitializeComponent();
            Forma = F2;
            blEjecutarVideo = false;
            blPlayVideo = false;
            bSalir = false;
        }
        //public frmReproducirVideo(string strDirVideo, string strTitulo, frmAyudaVideoContador F2)
        //{
        //    strDireccionVideo = strDirVideo;
        //    strTit = strTitulo;
        //    InitializeComponent();
        //    fForma3 = F2;
        //    blRegresar = false;
        //}
        private void frmReproducirVideo_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format(label1.Text, strTit);
            label2.Visible = false;
            label1.Visible = true;
            axWindowsMediaPlayer1.URL = strDireccionVideo;
        }
        private void pbCancelar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Close();
            Forma.Show();
            //if (blRegresar)
            //{
            //    frmSplash fspal = new frmSplash();
            //    frmMenu f1 = new frmMenu(fspal);
            //    frmAyudaVideo fa = new frmAyudaVideo(f1);
            //    this.Hide();
            //    f1.Show();
            //}
            //else 
            //{
            //    frmAyudaVideoContador fa = new frmAyudaVideoContador();
            //    this.Hide();
            //    fa.Show();
            //}
            
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 0:    // Undefined
                    //MessageBox.Show("Undefined");
                    break;

                case 1:    // Stopped
                    //MessageBox.Show("Stopped");
                    if (bSalir == false)
                    {
                        if (blEjecutarVideo)
                        {
                            blEjecutarVideo = false;
                            blPlayVideo = true;
                            //axWindowsMediaPlayer1.Ctlcontrols.stop();
                            label1.Visible = false;
                            label2.Visible = true;
                            label2.Text = string.Format(label2.Text, strTit);

                            //label1.Text = "Video con Efecto" + label1.Text;
                            axWindowsMediaPlayer1.URL = strDireccionVideoEfecto;

                        }
                        else
                        {
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                    }
                    break;

                case 2:    // Paused
                    //MessageBox.Show("Paused");
                    break;

                case 3:    // Playing
                    //MessageBox.Show("Playing");
                    break;

                case 4:    // ScanForward
                    //MessageBox.Show("ScanForward");
                    break;

                case 5:    // ScanReverse
                    //MessageBox.Show("ScanReverse");
                    break;

                case 6:    // Buffering
                    //MessageBox.Show("Buffering");
                    break;

                case 7:    // Waiting
                    //MessageBox.Show("Waiting");
                    break;

                case 8:    // MediaEnded
                    if (bSalir == false)
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Quiere ver el video de nuevo?", "Auto-Aprendizaje", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //do something
                            //Formularios.frmReproducirVideo fvidereproducir;
                            //fvidereproducir = new Formularios.frmReproducirVideo("Buscar Contador SE.wmv", "Buscar Contador", this);
                            //this.Hide();
                            //fvidereproducir.Show();
                            blEjecutarVideo = true;

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("¡Excelente trabajo, sigue auto-capacitándote!");
                            bSalir = true;
                            axWindowsMediaPlayer1.Ctlcontrols.stop();
                            this.Hide();
                            Forma.Show();
                            //do something else
                        }
                    }
                    //MessageBox.Show("MediaEnded");
                    break;

                case 9:    // Transitioning
                    //MessageBox.Show("Transitioning");
                    break;

                case 10:   // Ready
                    //MessageBox.Show("Ready");
                    if (bSalir == false)
                    {
                        if (blPlayVideo)
                        {
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                    }
                    break;

                case 11:   // Reconnecting
                    //MessageBox.Show("Reconnecting");
                    break;

                case 12:   // Last
                    //MessageBox.Show("Last");
                    break;

                default:
                    //MessageBox.Show("Unknown State: " + e.newState.ToString());
                    break;
            }
        }

        private void frmReproducirVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Forma.Show();
        }

        
    }
}
