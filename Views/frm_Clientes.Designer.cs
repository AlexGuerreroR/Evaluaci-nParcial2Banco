namespace EvaluaciónParcial2Banco.Views
{
    partial class frm_Clientes
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
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.lbl_NombreCliente = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.lst_Clientes = new System.Windows.Forms.ListBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCliente.Location = new System.Drawing.Point(257, 109);
            this.lblTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(80, 25);
            this.lblTituloCliente.TabIndex = 0;
            this.lblTituloCliente.Text = "Cliente";
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.Location = new System.Drawing.Point(93, 152);
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(81, 25);
            this.lbl_NombreCliente.TabIndex = 2;
            this.lbl_NombreCliente.Text = "Nombre";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(194, 152);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(237, 30);
            this.txt_NombreCliente.TabIndex = 4;
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Location = new System.Drawing.Point(99, 200);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(75, 25);
            this.lbl_Cedula.TabIndex = 5;
            this.lbl_Cedula.Text = "Cédula";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(194, 200);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(237, 30);
            this.txt_Cedula.TabIndex = 6;
            // 
            // lst_Clientes
            // 
            this.lst_Clientes.FormattingEnabled = true;
            this.lst_Clientes.ItemHeight = 25;
            this.lst_Clientes.Location = new System.Drawing.Point(471, 96);
            this.lst_Clientes.Name = "lst_Clientes";
            this.lst_Clientes.Size = new System.Drawing.Size(290, 304);
            this.lst_Clientes.TabIndex = 7;
            this.lst_Clientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_Clientes_MouseDoubleClick);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(82, 435);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(106, 53);
            this.btn_Agregar.TabIndex = 8;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(216, 435);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(106, 53);
            this.btn_Eliminar.TabIndex = 9;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(341, 435);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(106, 53);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista de Clientes";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(194, 353);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(237, 30);
            this.txt_Correo.TabIndex = 17;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(99, 353);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(72, 25);
            this.lbl_Correo.TabIndex = 16;
            this.lbl_Correo.Text = "Correo";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(194, 305);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(237, 30);
            this.txt_Telefono.TabIndex = 15;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(194, 249);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(237, 30);
            this.txt_Direccion.TabIndex = 14;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(93, 305);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(89, 25);
            this.lbl_Telefono.TabIndex = 13;
            this.lbl_Telefono.Text = "Teléfono";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(77, 254);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(93, 25);
            this.lbl_Direccion.TabIndex = 12;
            this.lbl_Direccion.Text = "Dirección";
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 528);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lst_Clientes);
            this.Controls.Add(this.txt_Cedula);
            this.Controls.Add(this.lbl_Cedula);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.lbl_NombreCliente);
            this.Controls.Add(this.lblTituloCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frm_Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.Label lbl_NombreCliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.ListBox lst_Clientes;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Direccion;
    }
}