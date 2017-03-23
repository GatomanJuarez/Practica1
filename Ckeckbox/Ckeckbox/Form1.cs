using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ckeckbox
{
    public partial class Form1 : Form
    {
        string permisos = "";

        public Form1()
        {
            InitializeComponent();
        }
        //By Jesus Antonio Juarez Devora
        // ISW 3B

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_uno_CheckedChanged(object sender, EventArgs e)
        {
            //Message.Box.Show("Marcado");
            if (chk_uno.Checked)
            {
                //textBox1.Text +=chk_uno.Text;
                permisos += chk_uno.Text + ",";
            }
            else
            {
                permisos = permisos.Replace(chk_uno.Text + ",", " ");
            }
            textBox1.Text = permisos;
        }

        private void chk_dos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_dos.Checked)
            {
                permisos += chk_dos.Text + ",";
            }
            else
            {
                permisos = permisos.Replace(chk_dos.Text + ",", " ");
            }
            textBox1.Text = permisos;
        }

        private void chk_tres_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_tres.Checked)
            {
                permisos += chk_tres.Text + ",";
            }
            else
            {
                permisos = permisos.Replace(chk_tres.Text + ",", " ");
            }
            textBox1.Text = permisos;
        }

        private void chk_cuatro_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cuatro.Checked)
            {
                permisos += chk_cuatro.Text + ",";
            }
            else
            {
                permisos=permisos.Replace(chk_cuatro.Text + ",", " ");
            }
            textBox1.Text = permisos;
        }

        private void chk_cinco_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cinco.Checked)
            {
                permisos += chk_cinco.Text + ",";
            }
            else
            {
                permisos = permisos.Replace(chk_cinco.Text + ",", " ");
            }
            textBox1.Text = permisos;
        }

        private void chk_seis_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_seis.Checked)
            {
                permisos += chk_seis.Text+",";
            }
            else
            {
                permisos = permisos.Replace(chk_seis.Text + ",", " ");
            }
            textBox1.Text = permisos;
        }
    }
}
