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
            this.txt_Sucursal = new System.Windows.Forms.TextBox();
            this.lst_Sucursales = new System.Windows.Forms.ListBox();
            this.lbl_NombreSucursal = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lbl_NuevaSucursal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ListasSucursales
            // 
            this.lbl_ListasSucursales.AutoSize = true;
            this.lbl_ListasSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListasSucursales.Location = new System.Drawing.Point(655, 91);
            this.lbl_ListasSucursales.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ListasSucursales.Name = "lbl_ListasSucursales";
            this.lbl_ListasSucursales.Size = new System.Drawing.Size(202, 25);
            this.lbl_ListasSucursales.TabIndex = 0;
            this.lbl_ListasSucursales.Text = "Lista de Sucursales";
            // 
            // txt_Sucursal
            // 
            this.txt_Sucursal.Location = new System.Drawing.Point(187, 146);
            this.txt_Sucursal.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Sucursal.Name = "txt_Sucursal";
            this.txt_Sucursal.Size = new System.Drawing.Size(293, 30);
            this.txt_Sucursal.TabIndex = 1;
            // 
            // lst_Sucursales
            // 
            this.lst_Sucursales.FormattingEnabled = true;
            this.lst_Sucursales.ItemHeight = 25;
            this.lst_Sucursales.Location = new System.Drawing.Point(529, 133);
            this.lst_Sucursales.Margin = new System.Windows.Forms.Padding(5);
            this.lst_Sucursales.Name = "lst_Sucursales";
            this.lst_Sucursales.Size = new System.Drawing.Size(389, 254);
            this.lst_Sucursales.TabIndex = 3;
            this.lst_Sucursales.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_Sucursales_MouseDoubleClick_1);
            // 
            // lbl_NombreSucursal
            // 
            this.lbl_NombreSucursal.AutoSize = true;
            this.lbl_NombreSucursal.Location = new System.Drawing.Point(86, 146);
            this.lbl_NombreSucursal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NombreSucursal.Name = "lbl_NombreSucursal";
            this.lbl_NombreSucursal.Size = new System.Drawing.Size(81, 25);
            this.lbl_NombreSucursal.TabIndex = 4;
            this.lbl_NombreSucursal.Text = "Nombre";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(74, 195);
            this.lbl_Direccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(93, 25);
            this.lbl_Direccion.TabIndex = 5;
            this.lbl_Direccion.Text = "Dirección";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(187, 195);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(293, 30);
            this.txt_Direccion.TabIndex = 7;
            // 
            // lbl_NuevaSucursal
            // 
            this.lbl_NuevaSucursal.AutoSize = true;
            this.lbl_NuevaSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NuevaSucursal.Location = new System.Drawing.Point(240, 91);
            this.lbl_NuevaSucursal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NuevaSucursal.Name = "lbl_NuevaSucursal";
            this.lbl_NuevaSucursal.Size = new System.Drawing.Size(165, 25);
            this.lbl_NuevaSucursal.TabIndex = 10;
            this.lbl_NuevaSucursal.Text = "Nueva Sucursal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 301);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 56);
            this.button3.TabIndex = 8;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Eliminar_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(380, 301);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 56);
            this.button5.TabIndex = 9;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // frm_Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 422);
            this.Controls.Add(this.lbl_NuevaSucursal);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_NombreSucursal);
            this.Controls.Add(this.lst_Sucursales);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Sucursal);
            this.Controls.Add(this.lbl_ListasSucursales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Sucursales";
            this.Text = "frm_Sucursales";
            this.Load += new System.EventHandler(this.frm_Sucursales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ListasSucursales;
        private System.Windows.Forms.TextBox txt_Sucursal;
        private System.Windows.Forms.ListBox lst_Sucursales;
        private System.Windows.Forms.Label lbl_NombreSucursal;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label lbl_NuevaSucursal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}