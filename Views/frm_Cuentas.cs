using EvaluaciónParcial2Banco.Controllers;
using EvaluaciónParcial2Banco.Models;
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
    public partial class frm_Cuentas : Form
    {
        CuentasController _cuentasController = new CuentasController();
        CuentasModel cuentasModel = new CuentasModel();
        int id = 0;
        public frm_Cuentas()
        {
            InitializeComponent();
        }

        private void frm_Cuentas_Load(object sender, EventArgs e)
        {
            cargalista();
            cmb_Tipo.SelectedIndex = 0;
        }


            private void cargalista()
            {
                var listaCuentas = _cuentasController.ObtenerTodasLasCuentas();
                lst_Cuentas.DataSource = null;
                lst_Cuentas.DataSource = listaCuentas;
                lst_Cuentas.DisplayMember = "Tipo";
                lst_Cuentas.ValueMember = "ID_Cuenta";
            }

       

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                var resultado = new CuentasModel();
                string res = "";
                var cuenta = new CuentasModel
                {
                    ID_Cuenta = this.id,
                    Tipo = cmb_Tipo.SelectedItem.ToString(),
                    ID_Cliente = txt_Cliente.Text.Trim(),
                    Fecha_Apertura = DateTime.Parse(dtp_FechaApertura.Text.Trim()),
                    ID_Sucursal = txt_Sucursal.Text.Trim()
                };
                MessageBox.Show(cmb_Tipo.SelectedItem.ToString());
                if (this.id != 0)
                {
                    res = CuentasModel.Actualizar(cuenta);
                }
                else
                {
                    resultado = _cuentasController.InsertarCuenta(cuenta);
                    res = resultado.ID_Cuenta > 0 ? "ok" : "error";
                }

                if (res == "ok")
                {
                    MessageBox.Show("Se guardó con éxito");
                    cargalista();
                    LimpiarForm();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar, inténtelo más tarde");
                }
            }
        }

        public bool comprobar()
        {
            if (cmb_Tipo.SelectedIndex == -1 || cmb_Tipo.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccion un item de la lista de Tipo");
                return false;
            }
            else if (txt_Cliente.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el ID del cliente");
                return false;
            }
            else if (dtp_FechaApertura.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la fecha de apertura");
                return false;
            }
            else if (txt_Sucursal.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el ID de la sucursal");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LimpiarForm()
        {
            cmb_Tipo.SelectedIndex = 0;
            txt_Cliente.Text = string.Empty;
            dtp_FechaApertura.Text = string.Empty;
            txt_Sucursal.Text = string.Empty;
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar la cuenta?", "Formulario de cuentas", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var cuenta = _cuentasController.EliminarCuenta(Convert.ToInt32(lst_Cuentas.SelectedValue));
                if (lst_Cuentas.SelectedItem == null)
                {
                    MessageBox.Show("Error al eliminar la cuenta");
                }
                else
                {
                    MessageBox.Show("La cuenta se eliminó con éxito");
                    cargalista();
                }
            }
            else
            {
                MessageBox.Show("El usuario canceló la operación");
            }
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void lst_Cuentas_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (lst_Cuentas.SelectedValue != null)
            {
                var cuenta = _cuentasController.ObtenerCuentaPorId((int)lst_Cuentas.SelectedValue);
                this.id = cuenta.ID_Cuenta;
                cmb_Tipo.SelectedItem = cuenta.Tipo;
                txt_Cliente.Text = cuenta.ID_Cliente;
                dtp_FechaApertura.Value = cuenta.Fecha_Apertura;
                txt_Sucursal.Text = cuenta.ID_Sucursal;
            }
            else
            {
                MessageBox.Show("Seleccione una cuenta de la lista");
            }
        }



        /* private void btn_reporte_Click(object sender, EventArgs e)
         {
             frm_reporte_cuentas _Reportes_Cuentas = new frm_reporte_cuentas();
             _Reportes_Cuentas.ShowDialog();
         }
     */



    }
}
