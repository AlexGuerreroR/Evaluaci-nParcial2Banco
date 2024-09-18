namespace EvaluaciónParcial2Banco.Views
{
    partial class frm_Cuentas
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
            this.lbl_ListaCuentas = new System.Windows.Forms.Label();
            this.lbl_TituloCuentas = new System.Windows.Forms.Label();
            this.lst_Cuentas = new System.Windows.Forms.ListBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_IdSucursal = new System.Windows.Forms.Label();
            this.lbl_IdCliente = new System.Windows.Forms.Label();
            this.txt_Sucursal = new System.Windows.Forms.TextBox();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.lbl_FechaApertura = new System.Windows.Forms.Label();
            this.dtp_FechaApertura = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_ListaCuentas
            // 
            this.lbl_ListaCuentas.AutoSize = true;
            this.lbl_ListaCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaCuentas.Location = new System.Drawing.Point(666, 56);
            this.lbl_ListaCuentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ListaCuentas.Name = "lbl_ListaCuentas";
            this.lbl_ListaCuentas.Size = new System.Drawing.Size(178, 25);
            this.lbl_ListaCuentas.TabIndex = 0;
            this.lbl_ListaCuentas.Text = "Lista De Cuentas";
            // 
            // lbl_TituloCuentas
            // 
            this.lbl_TituloCuentas.AutoSize = true;
            this.lbl_TituloCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloCuentas.Location = new System.Drawing.Point(309, 67);
            this.lbl_TituloCuentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TituloCuentas.Name = "lbl_TituloCuentas";
            this.lbl_TituloCuentas.Size = new System.Drawing.Size(150, 25);
            this.lbl_TituloCuentas.TabIndex = 1;
            this.lbl_TituloCuentas.Text = "Nueva Cuenta";
            // 
            // lst_Cuentas
            // 
            this.lst_Cuentas.FormattingEnabled = true;
            this.lst_Cuentas.ItemHeight = 25;
            this.lst_Cuentas.Location = new System.Drawing.Point(600, 86);
            this.lst_Cuentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_Cuentas.Name = "lst_Cuentas";
            this.lst_Cuentas.Size = new System.Drawing.Size(389, 329);
            this.lst_Cuentas.TabIndex = 2;
            this.lst_Cuentas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_Cuentas_MouseDoubleClick_1);
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(57, 118);
            this.lbl_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(147, 25);
            this.lbl_Tipo.TabIndex = 6;
            this.lbl_Tipo.Text = "Tipo de Cuenta";
            // 
            // lbl_IdSucursal
            // 
            this.lbl_IdSucursal.AutoSize = true;
            this.lbl_IdSucursal.Location = new System.Drawing.Point(115, 209);
            this.lbl_IdSucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdSucursal.Name = "lbl_IdSucursal";
            this.lbl_IdSucursal.Size = new System.Drawing.Size(89, 25);
            this.lbl_IdSucursal.TabIndex = 10;
            this.lbl_IdSucursal.Text = "Sucursal";
            // 
            // lbl_IdCliente
            // 
            this.lbl_IdCliente.AutoSize = true;
            this.lbl_IdCliente.Location = new System.Drawing.Point(131, 165);
            this.lbl_IdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdCliente.Name = "lbl_IdCliente";
            this.lbl_IdCliente.Size = new System.Drawing.Size(73, 25);
            this.lbl_IdCliente.TabIndex = 9;
            this.lbl_IdCliente.Text = "Cliente";
            // 
            // txt_Sucursal
            // 
            this.txt_Sucursal.Location = new System.Drawing.Point(222, 204);
            this.txt_Sucursal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Sucursal.Name = "txt_Sucursal";
            this.txt_Sucursal.Size = new System.Drawing.Size(355, 30);
            this.txt_Sucursal.TabIndex = 8;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Location = new System.Drawing.Point(222, 160);
            this.txt_Cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(355, 30);
            this.txt_Cliente.TabIndex = 7;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(34, 349);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(140, 66);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(202, 349);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(140, 66);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click_1);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(362, 349);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(140, 66);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Seleccione una Opción",
            "Corriente",
            "Ahorro"});
            this.cmb_Tipo.Location = new System.Drawing.Point(222, 110);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(355, 33);
            this.cmb_Tipo.TabIndex = 14;
            // 
            // lbl_FechaApertura
            // 
            this.lbl_FechaApertura.AutoSize = true;
            this.lbl_FechaApertura.Location = new System.Drawing.Point(30, 256);
            this.lbl_FechaApertura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FechaApertura.Name = "lbl_FechaApertura";
            this.lbl_FechaApertura.Size = new System.Drawing.Size(174, 25);
            this.lbl_FechaApertura.TabIndex = 15;
            this.lbl_FechaApertura.Text = "Fecha de Apertura";
            // 
            // dtp_FechaApertura
            // 
            this.dtp_FechaApertura.Location = new System.Drawing.Point(222, 251);
            this.dtp_FechaApertura.Name = "dtp_FechaApertura";
            this.dtp_FechaApertura.Size = new System.Drawing.Size(355, 30);
            this.dtp_FechaApertura.TabIndex = 16;
            // 
            // frm_Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 451);
            this.Controls.Add(this.dtp_FechaApertura);
            this.Controls.Add(this.lbl_FechaApertura);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_IdSucursal);
            this.Controls.Add(this.lbl_IdCliente);
            this.Controls.Add(this.txt_Sucursal);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lst_Cuentas);
            this.Controls.Add(this.lbl_TituloCuentas);
            this.Controls.Add(this.lbl_ListaCuentas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Cuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.frm_Cuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ListaCuentas;
        private System.Windows.Forms.Label lbl_TituloCuentas;
        private System.Windows.Forms.ListBox lst_Cuentas;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_IdSucursal;
        private System.Windows.Forms.Label lbl_IdCliente;
        private System.Windows.Forms.TextBox txt_Sucursal;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.Label lbl_FechaApertura;
        private System.Windows.Forms.DateTimePicker dtp_FechaApertura;
    }
}