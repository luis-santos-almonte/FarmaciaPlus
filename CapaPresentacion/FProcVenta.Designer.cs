
namespace CapaPresentacion
{
    partial class FProcVenta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BBuscarEmpleado = new System.Windows.Forms.Button();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.TBEmpleado = new System.Windows.Forms.TextBox();
            this.TBVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BBuscarCliente = new System.Windows.Forms.Button();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBCLiente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBImporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BAgregar = new System.Windows.Forms.Button();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DGDetalle = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BCalculadora = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalle)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BBuscarEmpleado);
            this.groupBox1.Controls.Add(this.DTFecha);
            this.groupBox1.Controls.Add(this.TBEmpleado);
            this.groupBox1.Controls.Add(this.TBVenta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Venta";
            // 
            // BBuscarEmpleado
            // 
            this.BBuscarEmpleado.BackColor = System.Drawing.Color.Indigo;
            this.BBuscarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarEmpleado.ForeColor = System.Drawing.Color.Transparent;
            this.BBuscarEmpleado.Location = new System.Drawing.Point(667, 146);
            this.BBuscarEmpleado.Name = "BBuscarEmpleado";
            this.BBuscarEmpleado.Size = new System.Drawing.Size(54, 40);
            this.BBuscarEmpleado.TabIndex = 7;
            this.BBuscarEmpleado.Text = "...";
            this.BBuscarEmpleado.UseVisualStyleBackColor = false;
            // 
            // DTFecha
            // 
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTFecha.Location = new System.Drawing.Point(517, 71);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(204, 40);
            this.DTFecha.TabIndex = 5;
            this.DTFecha.Value = new System.DateTime(2022, 8, 5, 21, 16, 37, 0);
            // 
            // TBEmpleado
            // 
            this.TBEmpleado.Location = new System.Drawing.Point(164, 146);
            this.TBEmpleado.Name = "TBEmpleado";
            this.TBEmpleado.Size = new System.Drawing.Size(497, 40);
            this.TBEmpleado.TabIndex = 4;
            // 
            // TBVenta
            // 
            this.TBVenta.Location = new System.Drawing.Point(164, 71);
            this.TBVenta.Name = "TBVenta";
            this.TBVenta.Size = new System.Drawing.Size(172, 40);
            this.TBVenta.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Venta #";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BBuscarCliente);
            this.groupBox2.Controls.Add(this.TBApellido);
            this.groupBox2.Controls.Add(this.TBNombre);
            this.groupBox2.Controls.Add(this.TBCLiente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(761, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // BBuscarCliente
            // 
            this.BBuscarCliente.BackColor = System.Drawing.Color.Indigo;
            this.BBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.BBuscarCliente.Location = new System.Drawing.Point(521, 67);
            this.BBuscarCliente.Name = "BBuscarCliente";
            this.BBuscarCliente.Size = new System.Drawing.Size(54, 40);
            this.BBuscarCliente.TabIndex = 8;
            this.BBuscarCliente.Text = "...";
            this.BBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(161, 183);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(557, 40);
            this.TBApellido.TabIndex = 5;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(161, 130);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(557, 40);
            this.TBNombre.TabIndex = 4;
            // 
            // TBCLiente
            // 
            this.TBCLiente.Location = new System.Drawing.Point(161, 68);
            this.TBCLiente.Name = "TBCLiente";
            this.TBCLiente.Size = new System.Drawing.Size(354, 40);
            this.TBCLiente.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 33);
            this.label9.TabIndex = 2;
            this.label9.Text = "Apellidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 33);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBImporte);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.BAgregar);
            this.groupBox3.Controls.Add(this.TBPrecio);
            this.groupBox3.Controls.Add(this.TBCantidad);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.BBuscarProducto);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TBProducto);
            this.groupBox3.Controls.Add(this.TBCodigo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1492, 138);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mercancia";
            // 
            // TBImporte
            // 
            this.TBImporte.Location = new System.Drawing.Point(1116, 79);
            this.TBImporte.Name = "TBImporte";
            this.TBImporte.Size = new System.Drawing.Size(180, 40);
            this.TBImporte.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1137, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Importe";
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.Color.Indigo;
            this.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.BAgregar.Location = new System.Drawing.Point(1331, 76);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(155, 41);
            this.BAgregar.TabIndex = 13;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = false;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(930, 78);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.ReadOnly = true;
            this.TBPrecio.Size = new System.Drawing.Size(180, 40);
            this.TBPrecio.TabIndex = 12;
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(775, 78);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(129, 40);
            this.TBCantidad.TabIndex = 11;
            this.TBCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCantidad_KeyPress);
            this.TBCantidad.Leave += new System.EventHandler(this.TBCantidad_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(924, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 33);
            this.label13.TabIndex = 10;
            this.label13.Text = "Precio Venta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(769, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 33);
            this.label12.TabIndex = 9;
            this.label12.Text = "Cantidad";
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.BackColor = System.Drawing.Color.Indigo;
            this.BBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.BBuscarProducto.Location = new System.Drawing.Point(689, 78);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(54, 40);
            this.BBuscarProducto.TabIndex = 8;
            this.BBuscarProducto.Text = "...";
            this.BBuscarProducto.UseVisualStyleBackColor = false;
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(262, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 33);
            this.label11.TabIndex = 6;
            this.label11.Text = "Producto";
            // 
            // TBProducto
            // 
            this.TBProducto.Location = new System.Drawing.Point(268, 78);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.Size = new System.Drawing.Size(415, 40);
            this.TBProducto.TabIndex = 5;
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(32, 78);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(172, 40);
            this.TBCodigo.TabIndex = 4;
            this.TBCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "Código";
            // 
            // DGDetalle
            // 
            this.DGDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalle.Location = new System.Drawing.Point(12, 476);
            this.DGDetalle.Name = "DGDetalle";
            this.DGDetalle.Size = new System.Drawing.Size(1204, 280);
            this.DGDetalle.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.BCalculadora);
            this.panel2.Controls.Add(this.BSalir);
            this.panel2.Controls.Add(this.BCancelar);
            this.panel2.Controls.Add(this.BGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 762);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1516, 100);
            this.panel2.TabIndex = 16;
            // 
            // BCalculadora
            // 
            this.BCalculadora.BackColor = System.Drawing.Color.Indigo;
            this.BCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCalculadora.ForeColor = System.Drawing.Color.Transparent;
            this.BCalculadora.Location = new System.Drawing.Point(676, 11);
            this.BCalculadora.Name = "BCalculadora";
            this.BCalculadora.Size = new System.Drawing.Size(240, 77);
            this.BCalculadora.TabIndex = 4;
            this.BCalculadora.Text = "Calculadora";
            this.BCalculadora.UseVisualStyleBackColor = false;
            this.BCalculadora.Click += new System.EventHandler(this.BCalculadora_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Indigo;
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.Location = new System.Drawing.Point(1365, 11);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(114, 77);
            this.BSalir.TabIndex = 3;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Indigo;
            this.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.BCancelar.Location = new System.Drawing.Point(360, 11);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(240, 77);
            this.BCancelar.TabIndex = 2;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.Indigo;
            this.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.Location = new System.Drawing.Point(44, 11);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(240, 77);
            this.BGuardar.TabIndex = 1;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(840, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLE DE LA VENTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1259, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 33);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total";
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.ForeColor = System.Drawing.Color.Red;
            this.LTotal.Location = new System.Drawing.Point(1340, 602);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(85, 13);
            this.LTotal.TabIndex = 21;
            this.LTotal.Text = "_____________";
            // 
            // FProcVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 862);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGDetalle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FProcVenta";
            this.Text = "FProcVenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGDetalle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBEmpleado;
        private System.Windows.Forms.TextBox TBVenta;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBCLiente;
        private System.Windows.Forms.Button BBuscarEmpleado;
        private System.Windows.Forms.Button BBuscarCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBProducto;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BCalculadora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBImporte;
    }
}