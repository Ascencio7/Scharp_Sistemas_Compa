namespace Flavors_System.Vista
{
    partial class frmEmpleados
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
            this.label6 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActivos = new System.Windows.Forms.Button();
            this.btnInactivos = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtEmpleados = new System.Windows.Forms.DataGridView();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administración de empleados";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDui);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(336, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtFecha.Location = new System.Drawing.Point(479, 104);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(249, 25);
            this.dtFecha.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(410, 24);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(318, 68);
            this.txtDireccion.TabIndex = 11;
            this.txtDireccion.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(336, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefono.Location = new System.Drawing.Point(130, 104);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(166, 25);
            this.txtTelefono.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(60, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teléfono:";
            // 
            // txtDui
            // 
            this.txtDui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDui.Location = new System.Drawing.Point(130, 67);
            this.txtDui.Mask = "00000000-0";
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(166, 25);
            this.txtDui.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(129, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 25);
            this.txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(87, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "DUI:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(63, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnCrear);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleDescription = "";
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(547, 24);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 33);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleDescription = "";
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(410, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 33);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Deshabilitar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleDescription = "";
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(264, 24);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 33);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Location = new System.Drawing.Point(118, 24);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(140, 33);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Agregar";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnActivos);
            this.groupBox3.Controls.Add(this.btnInactivos);
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtEmpleados);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(18, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 210);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // btnActivos
            // 
            this.btnActivos.AccessibleDescription = "";
            this.btnActivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActivos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivos.Location = new System.Drawing.Point(524, 19);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Size = new System.Drawing.Size(99, 33);
            this.btnActivos.TabIndex = 9;
            this.btnActivos.Text = "Activos";
            this.btnActivos.UseVisualStyleBackColor = false;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            // 
            // btnInactivos
            // 
            this.btnInactivos.AccessibleDescription = "";
            this.btnInactivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInactivos.BackColor = System.Drawing.Color.IndianRed;
            this.btnInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactivos.Location = new System.Drawing.Point(629, 19);
            this.btnInactivos.Name = "btnInactivos";
            this.btnInactivos.Size = new System.Drawing.Size(99, 33);
            this.btnInactivos.TabIndex = 4;
            this.btnInactivos.Text = "Inactivos";
            this.btnInactivos.UseVisualStyleBackColor = false;
            this.btnInactivos.Click += new System.EventHandler(this.btnInactivos_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(179, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(201, 25);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(63, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Buscar empleado:";
            // 
            // dtEmpleados
            // 
            this.dtEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.dtEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEmpleados.Location = new System.Drawing.Point(64, 58);
            this.dtEmpleados.MultiSelect = false;
            this.dtEmpleados.Name = "dtEmpleados";
            this.dtEmpleados.ReadOnly = true;
            this.dtEmpleados.Size = new System.Drawing.Size(664, 146);
            this.dtEmpleados.TabIndex = 0;
            this.dtEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEmpleados_CellContentClick);
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDEmpleado.Location = new System.Drawing.Point(768, 9);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(29, 20);
            this.txtIDEmpleado.TabIndex = 14;
            this.txtIDEmpleado.Visible = false;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 506);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.RichTextBox txtDireccion;
        public System.Windows.Forms.MaskedTextBox txtTelefono;
        public System.Windows.Forms.MaskedTextBox txtDui;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Button btnCrear;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.DataGridView dtEmpleados;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.TextBox txtIDEmpleado;
        public System.Windows.Forms.Button btnActivos;
        public System.Windows.Forms.Button btnInactivos;
    }
}