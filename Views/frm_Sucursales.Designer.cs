namespace EvaluaciónParcial2Banco.Views
{
    partial class frm_Sucursales
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
            this.lbl_ListasSucursales = new System.Windows.Forms.Label();
            this.txt_IdSucursal = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lst_Sucursales = new System.Windows.Forms.ListBox();
            this.lbl_IdSucursal = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ListasSucursales
            // 
            this.lbl_ListasSucursales.AutoSize = true;
            this.lbl_ListasSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListasSucursales.Location = new System.Drawing.Point(774, 91);
            this.lbl_ListasSucursales.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ListasSucursales.Name = "lbl_ListasSucursales";
            this.lbl_ListasSucursales.Size = new System.Drawing.Size(202, 25);
            this.lbl_ListasSucursales.TabIndex = 0;
            this.lbl_ListasSucursales.Text = "Lista de Sucursales";
            // 
            // txt_IdSucursal
            // 
            this.txt_IdSucursal.Location = new System.Drawing.Point(268, 199);
            this.txt_IdSucursal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_IdSucursal.Name = "txt_IdSucursal";
            this.txt_IdSucursal.Size = new System.Drawing.Size(293, 30);
            this.txt_IdSucursal.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(85, 427);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(142, 86);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // lst_Sucursales
            // 
            this.lst_Sucursales.FormattingEnabled = true;
            this.lst_Sucursales.ItemHeight = 25;
            this.lst_Sucursales.Location = new System.Drawing.Point(665, 134);
            this.lst_Sucursales.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lst_Sucursales.Name = "lst_Sucursales";
            this.lst_Sucursales.Size = new System.Drawing.Size(471, 379);
            this.lst_Sucursales.TabIndex = 3;
            // 
            // lbl_IdSucursal
            // 
            this.lbl_IdSucursal.AutoSize = true;
            this.lbl_IdSucursal.Location = new System.Drawing.Point(118, 199);
            this.lbl_IdSucursal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_IdSucursal.Name = "lbl_IdSucursal";
            this.lbl_IdSucursal.Size = new System.Drawing.Size(110, 25);
            this.lbl_IdSucursal.TabIndex = 4;
            this.lbl_IdSucursal.Text = "Id Sucursal";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(134, 278);
            this.lbl_Direccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(93, 25);
            this.lbl_Direccion.TabIndex = 5;
            this.lbl_Direccion.Text = "Dirección";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(268, 278);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(293, 30);
            this.txt_Direccion.TabIndex = 7;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(258, 427);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(150, 86);
            this.btn_Eliminar.TabIndex = 8;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(446, 427);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(142, 86);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 572);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_IdSucursal);
            this.Controls.Add(this.lst_Sucursales);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_IdSucursal);
            this.Controls.Add(this.lbl_ListasSucursales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_Sucursales";
            this.Text = "frm_Sucursales";
            this.Load += new System.EventHandler(this.frm_Sucursales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ListasSucursales;
        private System.Windows.Forms.TextBox txt_IdSucursal;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ListBox lst_Sucursales;
        private System.Windows.Forms.Label lbl_IdSucursal;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}