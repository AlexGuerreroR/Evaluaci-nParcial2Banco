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
            this.lbl_IdTransacciones = new System.Windows.Forms.Label();
            this.txt_IdTransaccion = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lst_ListaTransaccion = new System.Windows.Forms.ListBox();
            this.lbl_IdCuenta = new System.Windows.Forms.Label();
            this.txt_IdCuenta = new System.Windows.Forms.TextBox();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_ListaTransacciones = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_IdTransacciones
            // 
            this.lbl_IdTransacciones.AutoSize = true;
            this.lbl_IdTransacciones.Location = new System.Drawing.Point(68, 117);
            this.lbl_IdTransacciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdTransacciones.Name = "lbl_IdTransacciones";
            this.lbl_IdTransacciones.Size = new System.Drawing.Size(162, 25);
            this.lbl_IdTransacciones.TabIndex = 0;
            this.lbl_IdTransacciones.Text = "Id Transacciones";
            // 
            // txt_IdTransaccion
            // 
            this.txt_IdTransaccion.Location = new System.Drawing.Point(255, 112);
            this.txt_IdTransaccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IdTransaccion.Name = "txt_IdTransaccion";
            this.txt_IdTransaccion.Size = new System.Drawing.Size(272, 30);
            this.txt_IdTransaccion.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(97, 392);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(133, 74);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // lst_ListaTransaccion
            // 
            this.lst_ListaTransaccion.FormattingEnabled = true;
            this.lst_ListaTransaccion.ItemHeight = 25;
            this.lst_ListaTransaccion.Location = new System.Drawing.Point(565, 112);
            this.lst_ListaTransaccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_ListaTransaccion.Name = "lst_ListaTransaccion";
            this.lst_ListaTransaccion.Size = new System.Drawing.Size(439, 354);
            this.lst_ListaTransaccion.TabIndex = 3;
            // 
            // lbl_IdCuenta
            // 
            this.lbl_IdCuenta.AutoSize = true;
            this.lbl_IdCuenta.Location = new System.Drawing.Point(154, 183);
            this.lbl_IdCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdCuenta.Name = "lbl_IdCuenta";
            this.lbl_IdCuenta.Size = new System.Drawing.Size(97, 25);
            this.lbl_IdCuenta.TabIndex = 4;
            this.lbl_IdCuenta.Text = "Id Cuenta";
            // 
            // txt_IdCuenta
            // 
            this.txt_IdCuenta.Location = new System.Drawing.Point(255, 183);
            this.txt_IdCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IdCuenta.Name = "txt_IdCuenta";
            this.txt_IdCuenta.Size = new System.Drawing.Size(272, 30);
            this.txt_IdCuenta.TabIndex = 5;
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(255, 325);
            this.txt_Monto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(272, 30);
            this.txt_Monto.TabIndex = 9;
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Location = new System.Drawing.Point(154, 325);
            this.lbl_Monto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(67, 25);
            this.lbl_Monto.TabIndex = 8;
            this.lbl_Monto.Text = "Monto";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(154, 255);
            this.lbl_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(67, 25);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(255, 392);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(128, 74);
            this.btn_Eliminar.TabIndex = 10;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(406, 392);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(121, 74);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 30);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // frm_Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 516);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_ListaTransacciones);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.lbl_Monto);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.txt_IdCuenta);
            this.Controls.Add(this.lbl_IdCuenta);
            this.Controls.Add(this.lst_ListaTransaccion);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_IdTransaccion);
            this.Controls.Add(this.lbl_IdTransacciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Transacciones";
            this.Text = "Transacciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IdTransacciones;
        private System.Windows.Forms.TextBox txt_IdTransaccion;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ListBox lst_ListaTransaccion;
        private System.Windows.Forms.Label lbl_IdCuenta;
        private System.Windows.Forms.TextBox txt_IdCuenta;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_ListaTransacciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}