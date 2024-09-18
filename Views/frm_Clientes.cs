using System;
using EvaluaciónParcial2Banco.Models;
using EvaluaciónParcial2Banco.Controllers;
using System.Windows.Forms;
using EvaluaciónParcial2Banco.Config;

namespace EvaluaciónParcial2Banco.Views
{
    public partial class frm_Clientes : Form
    {

        ClientesModel cliente = new ClientesModel();    
        ClientesController _clientesControllers = new ClientesController();
        int id = 0;
        public frm_Clientes()
        {
            InitializeComponent();
            
        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            cargalista();
        }

        private void cargalista()
        {

            var listaClientes = _clientesControllers.ObtenerTodosLosClientes();
            lst_Clientes.DataSource = null;
            lst_Clientes.DataSource = listaClientes;
            lst_Clientes.DisplayMember = "Nombre";
            lst_Clientes.ValueMember = "ID_Cliente";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                var resultado = new ClientesModel();
                string res = "";
                var cliente = new ClientesModel
                {
                    ID_Cliente = this.id,
                    Nombre = txt_NombreCliente.Text.Trim().ToString(),
                    Cedula = txt_Cedula.Text.Trim().ToString(),
                    Direccion = txt_Direccion.Text.Trim().ToString(),
                    Telefono = txt_Telefono.Text.Trim().ToString(),
                    Correo = txt_Correo.Text.Trim().ToString(),

                };
 
                if (this.id != 0)
                {
                    res = ClientesModel.Actualizar(cliente);
                }
                else
                {
                    resultado = _clientesControllers.InsertarCliente(cliente);
                    res = resultado.ID_Cliente > 0 ? "ok" : "error";
                }
                if (res == "ok")
                {
                    MessageBox.Show("Se guardo con exito");
                    cargalista();
                    txt_NombreCliente.Text = "";
                    txt_Cedula.Text = "";
                    txt_Direccion.Text = "";
                    txt_Telefono.Text = "";
                    txt_Correo.Text = "";


                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar, intentelo mas tarde");
                }

            }
        }



        public bool comprobar()
        {

            if (txt_NombreCliente.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Nombre del Cliente");
                return false;
            }
            else if (txt_Cedula.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la Cedula");
                return false;
            }
            else if (txt_Direccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la Dirección");
                return false;
            }
            else if (txt_Telefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Teléfono");
                return false;
            }
            else if (txt_Correo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Correo");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void lst_Clientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (lst_Clientes.SelectedValue != null)
            {
                var cliente = _clientesControllers.ObtenerClientePorId((int)lst_Clientes.SelectedValue);
                this.id = (int)cliente.ID_Cliente;
                txt_NombreCliente.Text = cliente.Nombre;
                txt_Cedula.Text = cliente.Cedula;
                txt_Direccion.Text = cliente.Direccion;
                txt_Telefono.Text = cliente.Telefono;
                txt_Correo.Text = cliente.Correo;

            }
            else
            {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un Cliente de la lista");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Eliminar el Cliente?", "Formulario de Clientes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var usuario = _clientesControllers.EliminarCliente(Convert.ToInt32(lst_Clientes.SelectedValue));
                if (lst_Clientes.SelectedItem == null)
                {
                    ErrorHandler.ManejarEliminar();
                }
                else
                {
                    MessageBox.Show("El Cliente se elimino con exito");
                    cargalista();
                }
            }
            else
            {
                MessageBox.Show("El usuario cancelo la operacion");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void LimpiarForm()
        {
            txt_NombreCliente.Text = "";
            txt_Cedula.Text = "";
            txt_Direccion.Text = "";
            txt_Telefono.Text = "";
            txt_Correo.Text = "";
            this.id = 0;
        }






    }
}
