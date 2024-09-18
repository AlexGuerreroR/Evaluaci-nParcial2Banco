using EvaluaciónParcial2Banco.Config;
using EvaluaciónParcial2Banco.Controllers;
using EvaluaciónParcial2Banco.Models;
using System;
using System.Windows.Forms;

namespace EvaluaciónParcial2Banco.Views
{
    public partial class frm_Usuarios : Form
    {
        UsuariosController _usuariosController = new UsuariosController();
        UsuariosModel usuariosModel = new UsuariosModel();
        int id = 0;


        public frm_Usuarios()
        {
            InitializeComponent();
        }


        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            cargalista();
            cmb_Roles.SelectedIndex = 0;
        }

        private void cargalista()
        {

            var listausuarios = _usuariosController.ObtenerUsuarios();
            lst_Usuarios.DataSource = null;
            lst_Usuarios.DataSource = listausuarios;
            lst_Usuarios.DisplayMember = "NombreUsuario";
            lst_Usuarios.ValueMember = "ID";
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                var resultado = new UsuariosModel();
                string res = "";
                var usuario = new UsuariosModel
                {
                    ID = this.id,
                    NombreUsuario = txt_NombreUsuario.Text.Trim().ToString(),
                    Password = txt_Contrasenia.Text.Trim().ToString(),
                    Roles = cmb_Roles.SelectedItem.ToString()
                };
                MessageBox.Show(cmb_Roles.SelectedItem.ToString());
                if (this.id != 0)
                {
                    res = UsuariosModel.Actualizar(usuario);
                }
                else
                {
                    resultado = _usuariosController.InsertarUsuario(usuario);
                    res = resultado.ID > 0 ? "ok" : "error";
                }
                if (res == "ok")
                {
                    MessageBox.Show("Se guardo con exito");
                    cargalista();
                    txt_Contrasenia.Text = "";
                    txt_NombreUsuario.Text = "";
                    txt_Repita.Text = "";
                    cmb_Roles.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar, intentelo mas tarde");
                }

            }
        }

        public bool comprobar()
        {

            if (txt_NombreUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del usuario");
                return false;
            }
            else if (txt_Contrasenia.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la contrasenia");
                return false;
            }
            else if (txt_Repita.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la contrasenia");
                return false;
            }
            else if (cmb_Roles.SelectedIndex == -1 || cmb_Roles.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccion un item de la lista de roles");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }





        public void LimpiarForm()
        {
            txt_NombreUsuario.Text = string.Empty;
            txt_Contrasenia.Text = string.Empty;
            txt_Repita.Text = string.Empty;
            cmb_Roles.SelectedIndex = 0;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Eliminar el usuario?", "Formulario de usuarios", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var usuario = _usuariosController.EliminarUsuario(Convert.ToInt32(lst_Usuarios.SelectedValue));
                if (lst_Usuarios.SelectedItem == null)
                {
                    ErrorHandler.ManejarEliminar();
                }
                else
                {
                    MessageBox.Show("El usuario se elimino con exito");
                    cargalista();
                }
            }
            else
            {
                MessageBox.Show("El usuario cancelo la operacion");
            }
        }

        private void lst_Usuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lst_Usuarios.SelectedValue != null)
            {
                var usuario = _usuariosController.ObtenerUsuarioPorId((int)lst_Usuarios.SelectedValue);
                this.id = (int)usuario.ID;
                txt_NombreUsuario.Text = usuario.NombreUsuario;
                txt_Contrasenia.Text = usuario.Password;
                txt_Repita.Text = usuario.Password;
                cmb_Roles.SelectedItem = usuario.Roles;
            }
            else
            {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un usuario de la lista");
            }
        }
    }
}
