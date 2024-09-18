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
    public partial class frm_Transacciones : Form
    {
        TransaccionesController transaccionesController = new TransaccionesController();
        TransaccionesModel transaccionesModel = new TransaccionesModel();
        int id = 0;

        public frm_Transacciones()
        {
            InitializeComponent();
        }

        private void frm_Transacciones_Load(object sender, EventArgs e)
        {
            cargalista();
            cmb_TipoTransaccion.SelectedIndex = 0;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                var resultado = new TransaccionesModel();
                string res = "";
                var transaccion = new TransaccionesModel
                {
                    ID_Transaccion = this.id,
                    ID_Cuenta = int.Parse(txt_IdCuenta.Text.Trim()),
                    Fecha = DateTime.Parse(dtp_Fecha.Text.Trim()),
                    Monto = decimal.Parse(txt_Monto.Text.Trim()),
                    Tipo_Transaccion = cmb_TipoTransaccion.SelectedItem.ToString()
                };
                MessageBox.Show(cmb_TipoTransaccion.SelectedItem.ToString());
                if (this.id != 0)
                {
                    res = TransaccionesModel.Actualizar(transaccion);
                }
                else
                {
                    resultado = transaccionesController.InsertarTransaccion(transaccion);
                    res = resultado.ID_Transaccion > 0 ? "ok" : "error";
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

        private void cargalista()
        {
            var listaTransacciones = transaccionesController.ObtenerTodasLasTransacciones();
            lst_Transacciones.DataSource = null;
            lst_Transacciones.DataSource = listaTransacciones;
            lst_Transacciones.DisplayMember = "ID_Cuenta";
            lst_Transacciones.ValueMember = "ID_Transaccion";
        }

     

        public bool comprobar()
        {
            if (txt_IdCuenta.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el ID de la cuenta");
                return false;
            }
            else if (dtp_Fecha.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la fecha de la transacción");
                return false;
            }
            else if (txt_Monto.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el monto de la transacción");
                return false;
            }
            else if (cmb_TipoTransaccion.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de transacción");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LimpiarForm()
        {
            txt_IdCuenta.Text = string.Empty;
            dtp_Fecha.Text = string.Empty;
            txt_Monto.Text = string.Empty;
            cmb_TipoTransaccion.SelectedIndex = 0;
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar la transacción?", "Formulario de transacciones", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var transaccion = transaccionesController.EliminarTransaccion(Convert.ToInt32(lst_Transacciones.SelectedValue));
                if (lst_Transacciones.SelectedItem == null)
                {
                    MessageBox.Show("Error al eliminar la transacción");
                }
                else
                {
                    MessageBox.Show("La transacción se eliminó con éxito");
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

        private void lst_Transacciones_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (lst_Transacciones.SelectedValue != null)
            {
                var transaccion = transaccionesController.ObtenerTransaccionPorId((int)lst_Transacciones.SelectedValue);
                this.id = transaccion.ID_Transaccion;
                txt_IdCuenta.Text = transaccion.ID_Cuenta.ToString();
                dtp_Fecha.Value = transaccion.Fecha;
                txt_Monto.Text = transaccion.Monto.ToString();
                cmb_TipoTransaccion.SelectedItem = transaccion.Tipo_Transaccion;
            }
            else
            {
                MessageBox.Show("Seleccione una transacción de la lista");
            }
        }
    }
}
