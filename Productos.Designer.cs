namespace Proyecto_CRUD
{
    partial class FrProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PnlConsultarProducto = new System.Windows.Forms.Panel();
            this.PnlModificarProducto = new System.Windows.Forms.Panel();
            this.PnlEliminar = new System.Windows.Forms.Panel();
            this.cbxEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardarModificacion = new System.Windows.Forms.Button();
            this.txtModificarValor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModificarDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModificarProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxModificarProducto = new System.Windows.Forms.ComboBox();
            this.btnConsultarModificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxConsultarProducto = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsultarProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlIngresarProducto = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.PnlConsultarProducto.SuspendLayout();
            this.PnlModificarProducto.SuspendLayout();
            this.PnlEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PnlIngresarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // PnlConsultarProducto
            // 
            this.PnlConsultarProducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.PnlConsultarProducto.Controls.Add(this.PnlModificarProducto);
            this.PnlConsultarProducto.Controls.Add(this.cbxConsultarProducto);
            this.PnlConsultarProducto.Controls.Add(this.dataGridView1);
            this.PnlConsultarProducto.Controls.Add(this.btnConsultar);
            this.PnlConsultarProducto.Controls.Add(this.txtConsultarProducto);
            this.PnlConsultarProducto.Controls.Add(this.label8);
            this.PnlConsultarProducto.Location = new System.Drawing.Point(0, 0);
            this.PnlConsultarProducto.Name = "PnlConsultarProducto";
            this.PnlConsultarProducto.Size = new System.Drawing.Size(763, 255);
            this.PnlConsultarProducto.TabIndex = 10;
            this.PnlConsultarProducto.Visible = false;
            // 
            // PnlModificarProducto
            // 
            this.PnlModificarProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlModificarProducto.Controls.Add(this.PnlEliminar);
            this.PnlModificarProducto.Controls.Add(this.btnGuardarModificacion);
            this.PnlModificarProducto.Controls.Add(this.txtModificarValor);
            this.PnlModificarProducto.Controls.Add(this.label9);
            this.PnlModificarProducto.Controls.Add(this.txtModificarDescripcion);
            this.PnlModificarProducto.Controls.Add(this.label7);
            this.PnlModificarProducto.Controls.Add(this.txtModificarProducto);
            this.PnlModificarProducto.Controls.Add(this.label6);
            this.PnlModificarProducto.Controls.Add(this.cbxModificarProducto);
            this.PnlModificarProducto.Controls.Add(this.btnConsultarModificar);
            this.PnlModificarProducto.Controls.Add(this.label5);
            this.PnlModificarProducto.Location = new System.Drawing.Point(0, 0);
            this.PnlModificarProducto.Name = "PnlModificarProducto";
            this.PnlModificarProducto.Size = new System.Drawing.Size(763, 233);
            this.PnlModificarProducto.TabIndex = 12;
            this.PnlModificarProducto.Visible = false;
            // 
            // PnlEliminar
            // 
            this.PnlEliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PnlEliminar.Controls.Add(this.cbxEliminar);
            this.PnlEliminar.Controls.Add(this.btnEliminarProducto);
            this.PnlEliminar.Controls.Add(this.label13);
            this.PnlEliminar.Location = new System.Drawing.Point(0, 0);
            this.PnlEliminar.Name = "PnlEliminar";
            this.PnlEliminar.Size = new System.Drawing.Size(763, 220);
            this.PnlEliminar.TabIndex = 19;
            this.PnlEliminar.Visible = false;
            // 
            // cbxEliminar
            // 
            this.cbxEliminar.FormattingEnabled = true;
            this.cbxEliminar.Location = new System.Drawing.Point(297, 17);
            this.cbxEliminar.Name = "cbxEliminar";
            this.cbxEliminar.Size = new System.Drawing.Size(180, 21);
            this.cbxEliminar.TabIndex = 11;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(324, 64);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 9;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Producto:";
            // 
            // btnGuardarModificacion
            // 
            this.btnGuardarModificacion.Location = new System.Drawing.Point(324, 197);
            this.btnGuardarModificacion.Name = "btnGuardarModificacion";
            this.btnGuardarModificacion.Size = new System.Drawing.Size(102, 23);
            this.btnGuardarModificacion.TabIndex = 18;
            this.btnGuardarModificacion.Text = "Guardar Cambios";
            this.btnGuardarModificacion.UseVisualStyleBackColor = true;
            // 
            // txtModificarValor
            // 
            this.txtModificarValor.Location = new System.Drawing.Point(297, 157);
            this.txtModificarValor.Name = "txtModificarValor";
            this.txtModificarValor.Size = new System.Drawing.Size(180, 20);
            this.txtModificarValor.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Valor:";
            // 
            // txtModificarDescripcion
            // 
            this.txtModificarDescripcion.Location = new System.Drawing.Point(297, 126);
            this.txtModificarDescripcion.Name = "txtModificarDescripcion";
            this.txtModificarDescripcion.Size = new System.Drawing.Size(180, 20);
            this.txtModificarDescripcion.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descripción:";
            // 
            // txtModificarProducto
            // 
            this.txtModificarProducto.Location = new System.Drawing.Point(297, 90);
            this.txtModificarProducto.Name = "txtModificarProducto";
            this.txtModificarProducto.Size = new System.Drawing.Size(180, 20);
            this.txtModificarProducto.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Producto:";
            // 
            // cbxModificarProducto
            // 
            this.cbxModificarProducto.FormattingEnabled = true;
            this.cbxModificarProducto.Location = new System.Drawing.Point(297, 17);
            this.cbxModificarProducto.Name = "cbxModificarProducto";
            this.cbxModificarProducto.Size = new System.Drawing.Size(180, 21);
            this.cbxModificarProducto.TabIndex = 11;
            // 
            // btnConsultarModificar
            // 
            this.btnConsultarModificar.Location = new System.Drawing.Point(342, 49);
            this.btnConsultarModificar.Name = "btnConsultarModificar";
            this.btnConsultarModificar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarModificar.TabIndex = 9;
            this.btnConsultarModificar.Text = "Consultar";
            this.btnConsultarModificar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Producto:";
            // 
            // cbxConsultarProducto
            // 
            this.cbxConsultarProducto.FormattingEnabled = true;
            this.cbxConsultarProducto.Location = new System.Drawing.Point(527, 13);
            this.cbxConsultarProducto.Name = "cbxConsultarProducto";
            this.cbxConsultarProducto.Size = new System.Drawing.Size(121, 21);
            this.cbxConsultarProducto.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 162);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(241, 40);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtConsultarProducto
            // 
            this.txtConsultarProducto.Location = new System.Drawing.Point(342, 13);
            this.txtConsultarProducto.Name = "txtConsultarProducto";
            this.txtConsultarProducto.Size = new System.Drawing.Size(179, 20);
            this.txtConsultarProducto.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Producto:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductoToolStripMenuItem,
            this.consultarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresarProductoToolStripMenuItem
            // 
            this.ingresarProductoToolStripMenuItem.Name = "ingresarProductoToolStripMenuItem";
            this.ingresarProductoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.ingresarProductoToolStripMenuItem.Text = "Ingresar producto";
            this.ingresarProductoToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductoToolStripMenuItem_Click);
            // 
            // consultarProductoToolStripMenuItem
            // 
            this.consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            this.consultarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.consultarProductoToolStripMenuItem.Text = "Consultar producto";
            this.consultarProductoToolStripMenuItem.Click += new System.EventHandler(this.consultarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.modificarProductoToolStripMenuItem.Text = "Modificar producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // PnlIngresarProducto
            // 
            this.PnlIngresarProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PnlIngresarProducto.Controls.Add(this.PnlConsultarProducto);
            this.PnlIngresarProducto.Controls.Add(this.btnLimpiar);
            this.PnlIngresarProducto.Controls.Add(this.btnGuardar);
            this.PnlIngresarProducto.Controls.Add(this.txtCantidad);
            this.PnlIngresarProducto.Controls.Add(this.txtValor);
            this.PnlIngresarProducto.Controls.Add(this.txtDescripcion);
            this.PnlIngresarProducto.Controls.Add(this.txtCodigo);
            this.PnlIngresarProducto.Controls.Add(this.label4);
            this.PnlIngresarProducto.Controls.Add(this.label3);
            this.PnlIngresarProducto.Controls.Add(this.label2);
            this.PnlIngresarProducto.Controls.Add(this.Codigo);
            this.PnlIngresarProducto.Location = new System.Drawing.Point(12, 128);
            this.PnlIngresarProducto.Name = "PnlIngresarProducto";
            this.PnlIngresarProducto.Size = new System.Drawing.Size(763, 278);
            this.PnlIngresarProducto.TabIndex = 1;
            this.PnlIngresarProducto.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(427, 161);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(270, 161);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(402, 119);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(402, 92);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(402, 66);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(402, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(267, 44);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Código";
            // 
            // FrProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlIngresarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrProductos";
            this.Text = "Productos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PnlConsultarProducto.ResumeLayout(false);
            this.PnlConsultarProducto.PerformLayout();
            this.PnlModificarProducto.ResumeLayout(false);
            this.PnlModificarProducto.PerformLayout();
            this.PnlEliminar.ResumeLayout(false);
            this.PnlEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlIngresarProducto.ResumeLayout(false);
            this.PnlIngresarProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel PnlIngresarProducto;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlConsultarProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultarProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PnlModificarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxModificarProducto;
        private System.Windows.Forms.Button btnConsultarModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxConsultarProducto;
        private System.Windows.Forms.Panel PnlEliminar;
        private System.Windows.Forms.ComboBox cbxEliminar;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGuardarModificacion;
        private System.Windows.Forms.TextBox txtModificarValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModificarDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModificarProducto;
    }
}