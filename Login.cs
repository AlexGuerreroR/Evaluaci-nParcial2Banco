﻿using EvaluaciónParcial2Banco.Controllers;
using EvaluaciónParcial2Banco.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluaciónParcial2Banco
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            #region
            try
            {
                UsuariosController _usuariosController = new UsuariosController();
                var usuariomodel = _usuariosController.AutenticarUsuario(txt_Usuario.Text.Trim(), txt_Contrasenia.Text.Trim());
                if (usuariomodel != null)
                {
                    lbl_mensaje.Text = "Ingreso exitoso";
                    this.Hide();

                    ConfiguracionProyecto.IDusuario = usuariomodel.ID;
                    ConfiguracionProyecto.usuario = usuariomodel.NombreUsuario;
                    ConfiguracionProyecto.rol = usuariomodel.Roles;

                    frm_MenuPrincipal _frm_usuarios = new frm_MenuPrincipal();
                    this.Hide();
                    _frm_usuarios.AjustarMenuSegunRol(usuariomodel.Roles);
                    _frm_usuarios.Show();
                }
                else
                {
                    lbl_mensaje.Text = "Usuario o contraseña incorrectos";
                }
            }
            catch (Exception ex)
            {
                lbl_mensaje.Text = $"Error: {ex.Message}";
            }
            #endregion

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Usuario.Text = "";
            txt_Contrasenia.Text = "";
           
        }

      
    }
}
