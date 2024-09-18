namespace EvaluaciónParcial2Banco.Views
{
    partial class frm_Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_NuevoUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Contrasenia = new System.Windows.Forms.Label();
            this.lbl_ConfirmacionContrasenia = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.lbl_ListaUsuarios = new System.Windows.Forms.Label();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.txt_Repita = new System.Windows.Forms.TextBox();
            this.cmb_Roles = new System.Windows.Forms.ComboBox();
            this.lst_Usuarios = new System.Windows.Forms.ListBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_NuevoUsuario
            // 
            this.lbl_NuevoUsuario.AutoSize = true;
            this.lbl_NuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NuevoUsuario.Location = new System.Drawing.Point(151, 61);
            this.lbl_NuevoUsuario.Name = "lbl_NuevoUsuario";
            this.lbl_NuevoUsuario.Size = new System.Drawing.Size(154, 25);
            this.lbl_NuevoUsuario.TabIndex = 0;
            this.lbl_NuevoUsuario.Text = "Nuevo Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Usuario";
            // 
            // lbl_Contrasenia
            // 
            this.lbl_Contrasenia.AutoSize = true;
            this.lbl_Contrasenia.Location = new System.Drawing.Point(111, 172);
            this.lbl_Contrasenia.Name = "lbl_Contrasenia";
            this.lbl_Contrasenia.Size = new System.Drawing.Size(114, 25);
            this.lbl_Contrasenia.TabIndex = 2;
            this.lbl_Contrasenia.Text = "Contraseña";
            // 
            // lbl_ConfirmacionContrasenia
            // 
            this.lbl_ConfirmacionContrasenia.AutoSize = true;
            this.lbl_ConfirmacionContrasenia.Location = new System.Drawing.Point(111, 239);
            this.lbl_ConfirmacionContrasenia.Name = "lbl_ConfirmacionContrasenia";
            this.lbl_ConfirmacionContrasenia.Size = new System.Drawing.Size(194, 25);
            this.lbl_ConfirmacionContrasenia.TabIndex = 3;
            this.lbl_ConfirmacionContrasenia.Text = "Repita la Contraseña";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(116, 303);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(40, 25);
            this.lbl_Rol.TabIndex = 4;
            this.lbl_Rol.Text = "Rol";
            // 
            // lbl_ListaUsuarios
            // 
            this.lbl_ListaUsuarios.AutoSize = true;
            this.lbl_ListaUsuarios.Location = new System.Drawing.Point(425, 107);
            this.lbl_ListaUsuarios.Name = "lbl_ListaUsuarios";
            this.lbl_ListaUsuarios.Size = new System.Drawing.Size(162, 25);
            this.lbl_ListaUsuarios.TabIndex = 5;
            this.lbl_ListaUsuarios.Text = "Lista de Usuarios";
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Location = new System.Drawing.Point(111, 136);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(229, 30);
            this.txt_NombreUsuario.TabIndex = 6;
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.Location = new System.Drawing.Point(111, 200);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(229, 30);
            this.txt_Contrasenia.TabIndex = 7;
            // 
            // txt_Repita
            // 
            this.txt_Repita.Location = new System.Drawing.Point(111, 267);
            this.txt_Repita.Name = "txt_Repita";
            this.txt_Repita.Size = new System.Drawing.Size(229, 30);
            this.txt_Repita.TabIndex = 8;
            // 
            // cmb_Roles
            // 
            this.cmb_Roles.FormattingEnabled = true;
            this.cmb_Roles.Items.AddRange(new object[] {
            "Seleccione una opción",
            "Administrador",
            "Cajero",
            ""});
            this.cmb_Roles.Location = new System.Drawing.Point(111, 331);
            this.cmb_Roles.Name = "cmb_Roles";
            this.cmb_Roles.Size = new System.Drawing.Size(229, 33);
            this.cmb_Roles.TabIndex = 9;
            // 
            // lst_Usuarios
            // 
            this.lst_Usuarios.FormattingEnabled = true;
            this.lst_Usuarios.ItemHeight = 25;
            this.lst_Usuarios.Location = new System.Drawing.Point(379, 135);
            this.lst_Usuarios.Name = "lst_Usuarios";
            this.lst_Usuarios.Size = new System.Drawing.Size(265, 229);
            this.lst_Usuarios.TabIndex = 10;
            this.lst_Usuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_Usuarios_MouseDoubleClick);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(111, 412);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(114, 61);
            this.btn_Guardar.TabIndex = 11;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(254, 412);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(99, 61);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(379, 412);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(104, 61);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 514);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lst_Usuarios);
            this.Controls.Add(this.cmb_Roles);
            this.Controls.Add(this.txt_Repita);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.txt_NombreUsuario);
            this.Controls.Add(this.lbl_ListaUsuarios);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.lbl_ConfirmacionContrasenia);
            this.Controls.Add(this.lbl_Contrasenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_NuevoUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frm_Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NuevoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Contrasenia;
        private System.Windows.Forms.Label lbl_ConfirmacionContrasenia;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.Label lbl_ListaUsuarios;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.TextBox txt_Repita;
        private System.Windows.Forms.ComboBox cmb_Roles;
        private System.Windows.Forms.ListBox lst_Usuarios;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}