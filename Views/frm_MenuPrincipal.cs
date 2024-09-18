using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluaciónParcial2Banco.Views
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }
        public void AjustarMenuSegunRol(string rol)
        {
            if (rol == "Cajero")
            {
                UsuariosToolStripMenuItem1.Enabled = false; 
            }
            else if (rol == "Administrador")
            {
                UsuariosToolStripMenuItem1.Enabled = true; 
            }
        }
        private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Usuarios _Usuarios = new frm_Usuarios();
            _Usuarios.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Clientes _Clientes = new frm_Clientes();
            _Clientes.ShowDialog();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cuentas _Cuentas = new frm_Cuentas();
            _Cuentas.ShowDialog();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sucursales _Sucursales = new frm_Sucursales();
            _Sucursales.ShowDialog();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Transacciones _Transacciones = new frm_Transacciones();
            _Transacciones.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Reportes _Reportes = new frm_Reportes();
            _Reportes.ShowDialog();
        }

    }
}
