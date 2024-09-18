namespace EvaluaciónParcial2Banco.Views
{
    partial class frm_Transacciones
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
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lst_Transacciones = new System.Windows.Forms.ListBox();
            this.lbl_IdCuenta = new System.Windows.Forms.Label();
            this.txt_IdCuenta = new System.Windows.Forms.TextBox();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_ListaTransacciones = new System.Windows.Forms.Label();
            this.lbl_NuevaCuenta = new System.Windows.Forms.Label();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(81, 346);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(133, 74);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lst_Transacciones
            // 
            this.lst_Transacciones.FormattingEnabled = true;
            this.lst_Transacciones.ItemHeight = 25;
            this.lst_Transacciones.Location = new System.Drawing.Point(565, 112);
            this.lst_Transacciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_Transacciones.Name = "lst_Transacciones";
            this.lst_Transacciones.Size = new System.Drawing.Size(439, 354);
            this.lst_Transacciones.TabIndex = 3;
            this.lst_Transacciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_Transacciones_MouseDoubleClick_1);
            // 
            // lbl_IdCuenta
            // 
            this.lbl_IdCuenta.AutoSize = true;
            this.lbl_IdCuenta.Location = new System.Drawing.Point(46, 180);
            this.lbl_IdCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdCuenta.Name = "lbl_IdCuenta";
            this.lbl_IdCuenta.Size = new System.Drawing.Size(97, 25);
            this.lbl_IdCuenta.TabIndex = 4;
            this.lbl_IdCuenta.Text = "Id Cuenta";
            // 
            // txt_IdCuenta
            // 
            this.txt_IdCuenta.Location = new System.Drawing.Point(161, 180);
            this.txt_IdCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IdCuenta.Name = "txt_IdCuenta";
            this.txt_IdCuenta.Size = new System.Drawing.Size(351, 30);
            this.txt_IdCuenta.TabIndex = 5;
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(161, 279);
            this.txt_Monto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(351, 30);
            this.txt_Monto.TabIndex = 9;
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Location = new System.Drawing.Point(76, 279);
            this.lbl_Monto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(67, 25);
            this.lbl_Monto.TabIndex = 8;
            this.lbl_Monto.Text = "Monto";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(76, 228);
            this.lbl_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(67, 25);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(255, 346);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(128, 74);
            this.btn_Eliminar.TabIndex = 10;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click_1);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(411, 346);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(121, 74);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // lbl_ListaTransacciones
            // 
            this.lbl_ListaTransacciones.AutoSize = true;
            this.lbl_ListaTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaTransacciones.Location = new System.Drawing.Point(663, 67);
            this.lbl_ListaTransacciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ListaTransacciones.Name = "lbl_ListaTransacciones";
            this.lbl_ListaTransacciones.Size = new System.Drawing.Size(236, 25);
            this.lbl_ListaTransacciones.TabIndex = 12;
            this.lbl_ListaTransacciones.Text = "Lista de Transacciones";
            // 
            // lbl_NuevaCuenta
            // 
            this.lbl_NuevaCuenta.AutoSize = true;
            this.lbl_NuevaCuenta.Location = new System.Drawing.Point(250, 127);
            this.lbl_NuevaCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NuevaCuenta.Name = "lbl_NuevaCuenta";
            this.lbl_NuevaCuenta.Size = new System.Drawing.Size(138, 25);
            this.lbl_NuevaCuenta.TabIndex = 13;
            this.lbl_NuevaCuenta.Text = "Nueva Cuenta";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(161, 228);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(351, 30);
            this.dtp_Fecha.TabIndex = 14;
            // 
            // frm_Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 516);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.lbl_NuevaCuenta);
            this.Controls.Add(this.lbl_ListaTransacciones);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.lbl_Monto);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.txt_IdCuenta);
            this.Controls.Add(this.lbl_IdCuenta);
            this.Controls.Add(this.lst_Transacciones);
            this.Controls.Add(this.btn_Agregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Transacciones";
            this.Text = "Transacciones";
            this.Load += new System.EventHandler(this.frm_Transacciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ListBox lst_Transacciones;
        private System.Windows.Forms.Label lbl_IdCuenta;
        private System.Windows.Forms.TextBox txt_IdCuenta;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_ListaTransacciones;
        private System.Windows.Forms.Label lbl_NuevaCuenta;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
    }
}