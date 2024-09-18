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
            this.lst_ListaCuentas = new System.Windows.Forms.ListBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_IdSucursal = new System.Windows.Forms.Label();
            this.lbl_IdCliente = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.lbl_TituloCuentas.Location = new System.Drawing.Point(214, 86);
            this.lbl_TituloCuentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TituloCuentas.Name = "lbl_TituloCuentas";
            this.lbl_TituloCuentas.Size = new System.Drawing.Size(150, 25);
            this.lbl_TituloCuentas.TabIndex = 1;
            this.lbl_TituloCuentas.Text = "Nueva Cuenta";
            // 
            // lst_ListaCuentas
            // 
            this.lst_ListaCuentas.FormattingEnabled = true;
            this.lst_ListaCuentas.ItemHeight = 25;
            this.lst_ListaCuentas.Location = new System.Drawing.Point(525, 86);
            this.lst_ListaCuentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_ListaCuentas.Name = "lst_ListaCuentas";
            this.lst_ListaCuentas.Size = new System.Drawing.Size(464, 329);
            this.lst_ListaCuentas.TabIndex = 2;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(28, 147);
            this.lbl_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(147, 25);
            this.lbl_Tipo.TabIndex = 6;
            this.lbl_Tipo.Text = "Tipo de Cuenta";
            // 
            // lbl_IdSucursal
            // 
            this.lbl_IdSucursal.AutoSize = true;
            this.lbl_IdSucursal.Location = new System.Drawing.Point(86, 238);
            this.lbl_IdSucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdSucursal.Name = "lbl_IdSucursal";
            this.lbl_IdSucursal.Size = new System.Drawing.Size(89, 25);
            this.lbl_IdSucursal.TabIndex = 10;
            this.lbl_IdSucursal.Text = "Sucursal";
            // 
            // lbl_IdCliente
            // 
            this.lbl_IdCliente.AutoSize = true;
            this.lbl_IdCliente.Location = new System.Drawing.Point(102, 194);
            this.lbl_IdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdCliente.Name = "lbl_IdCliente";
            this.lbl_IdCliente.Size = new System.Drawing.Size(73, 25);
            this.lbl_IdCliente.TabIndex = 9;
            this.lbl_IdCliente.Text = "Cliente";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 233);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(244, 30);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(193, 189);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(244, 30);
            this.textBox4.TabIndex = 7;
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
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seleccione una Opción",
            "Corriente",
            "Ahorro"});
            this.comboBox1.Location = new System.Drawing.Point(193, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 33);
            this.comboBox1.TabIndex = 14;
            // 
            // frm_Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 451);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_IdSucursal);
            this.Controls.Add(this.lbl_IdCliente);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lst_ListaCuentas);
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
        private System.Windows.Forms.ListBox lst_ListaCuentas;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_IdSucursal;
        private System.Windows.Forms.Label lbl_IdCliente;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}