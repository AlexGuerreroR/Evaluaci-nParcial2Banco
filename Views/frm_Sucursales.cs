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
    public partial class frm_Sucursales : Form
    {
        SucursalesController _sucursalesController = new SucursalesController();
        SucursalesModel sucursalesModel = new SucursalesModel();
        int id = 0;

        public frm_Sucursales()
        {
            InitializeComponent();
        }

        private void frm_Sucursales_Load(object sender, EventArgs e)
        {
            cargalista();
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                var resultado = new SucursalesModel();
                string res = "";
                var sucursal = new SucursalesModel
                {
                    ID_Sucursal = this.id,
                    Nombre_Sucursal = txt_Sucursal.Text.Trim(),
                    Direccion = txt_Direccion.Text.Trim()
                };

                if (this.id != 0)
                {
                    res = SucursalesModel.Actualizar(sucursal);
                }
                else
                {
                    resultado = _sucursalesController.InsertarSucursal(sucursal);
                    res = resultado.ID_Sucursal > 0 ? "ok" : "error";
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
            var listaSucursales = _sucursalesController.ObtenerTodasLasSucursales();
            lst_Sucursales.DataSource = null;
            lst_Sucursales.DataSource = listaSucursales;
            lst_Sucursales.DisplayMember = "Nombre_Sucursal";
            lst_Sucursales.ValueMember = "ID_Sucursal";
        }


        public bool comprobar()
        {
            if (txt_Sucursal.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre de la sucursal");
                return false;
            }
            else if (txt_Direccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la dirección de la sucursal");
                return false;
            }
            else
            {
                return true;
            }
        }




        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar la sucursal?", "Formulario de sucursales", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var sucursal = _sucursalesController.EliminarSucursal(Convert.ToInt32(lst_Sucursales.SelectedValue));
                if (lst_Sucursales.SelectedItem == null)
                {
                    MessageBox.Show("Error al eliminar la sucursal");
                }
                else
                {
                    MessageBox.Show("La sucursal se eliminó con éxito");
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

        private void lst_Sucursales_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (lst_Sucursales.SelectedValue != null)
            {
                var sucursal = _sucursalesController.ObtenerSucursalPorId((int)lst_Sucursales.SelectedValue);
                this.id = sucursal.ID_Sucursal;
                txt_Sucursal.Text = sucursal.Nombre_Sucursal;
                txt_Direccion.Text = sucursal.Direccion;
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal de la lista");
            }
        }

        public void LimpiarForm()
        {
            txt_Sucursal.Text = string.Empty;
            txt_Direccion.Text = string.Empty;
        }


        private void btn_reporte_Click(object sender, EventArgs e)
        {
            //frm_reporte_sucursales _Reportes_Sucursales = new frm_reporte_sucursales();
            //_Reportes_Sucursales.ShowDialog();
        }



    }
}
