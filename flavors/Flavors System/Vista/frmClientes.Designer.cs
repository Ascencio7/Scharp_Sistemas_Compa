namespace Flavors_System.Vista
{
    partial class frmClientes
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
            this.cmbEstadoCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoClientes = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoClientes = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreClientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnElminarClientes = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizarClientes = new System.Windows.Forms.Button();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActivos = new System.Windows.Forms.Button();
            this.btnInactivos = new System.Windows.Forms.Button();
            this.txtBuscarClientes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtClientes = new System.Windows.Forms.DataGridView();
            this.txtIdClientes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administración de clientes:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbEstadoCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCorreoClientes);
            this.groupBox1.Controls.Add(this.txtDireccionCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefonoClientes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreClientes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cmbEstadoCliente
            // 
            this.cmbEstadoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstadoCliente.FormattingEnabled = true;
            this.cmbEstadoCliente.Location = new System.Drawing.Point(439, 27);
            this.cmbEstadoCliente.Name = "cmbEstadoCliente";
            this.cmbEstadoCliente.Size = new System.Drawing.Size(200, 25);
            this.cmbEstadoCliente.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(366, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado:";
            // 
            // txtCorreoClientes
            // 
            this.txtCorreoClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreoClientes.Location = new System.Drawing.Point(129, 70);
            this.txtCorreoClientes.Name = "txtCorreoClientes";
            this.txtCorreoClientes.Size = new System.Drawing.Size(167, 25);
            this.txtCorreoClientes.TabIndex = 14;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionCliente.Location = new System.Drawing.Point(439, 68);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(318, 68);
            this.txtDireccionCliente.TabIndex = 11;
            this.txtDireccionCliente.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(351, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección:";
            // 
            // txtTelefonoClientes
            // 
            this.txtTelefonoClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefonoClientes.Location = new System.Drawing.Point(130, 104);
            this.txtTelefonoClientes.Mask = "0000-0000";
            this.txtTelefonoClientes.Name = "txtTelefonoClientes";
            this.txtTelefonoClientes.Size = new System.Drawing.Size(166, 25);
            this.txtTelefonoClientes.TabIndex = 9;
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
            // txtNombreClientes
            // 
            this.txtNombreClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreClientes.Location = new System.Drawing.Point(129, 24);
            this.txtNombreClientes.Name = "txtNombreClientes";
            this.txtNombreClientes.Size = new System.Drawing.Size(167, 25);
            this.txtNombreClientes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(69, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo:";
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
            this.groupBox2.Controls.Add(this.btnElminarClientes);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnActualizarClientes);
            this.groupBox2.Controls.Add(this.btnAgregarClientes);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 75);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // btnElminarClientes
            // 
            this.btnElminarClientes.AccessibleDescription = "";
            this.btnElminarClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElminarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnElminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElminarClientes.Location = new System.Drawing.Point(253, 24);
            this.btnElminarClientes.Name = "btnElminarClientes";
            this.btnElminarClientes.Size = new System.Drawing.Size(140, 33);
            this.btnElminarClientes.TabIndex = 4;
            this.btnElminarClientes.Text = "Deshabilitar";
            this.btnElminarClientes.UseVisualStyleBackColor = false;
            this.btnElminarClientes.Click += new System.EventHandler(this.btnElminarClientes_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleDescription = "";
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(545, 24);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 33);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizarClientes
            // 
            this.btnActualizarClientes.AccessibleDescription = "";
            this.btnActualizarClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnActualizarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarClientes.Location = new System.Drawing.Point(399, 24);
            this.btnActualizarClientes.Name = "btnActualizarClientes";
            this.btnActualizarClientes.Size = new System.Drawing.Size(140, 33);
            this.btnActualizarClientes.TabIndex = 1;
            this.btnActualizarClientes.Text = "Actualizar";
            this.btnActualizarClientes.UseVisualStyleBackColor = false;
            this.btnActualizarClientes.Click += new System.EventHandler(this.btnActualizarClientes_Click);
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnAgregarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarClientes.Location = new System.Drawing.Point(107, 24);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(140, 33);
            this.btnAgregarClientes.TabIndex = 0;
            this.btnAgregarClientes.Text = "Agregar";
            this.btnAgregarClientes.UseVisualStyleBackColor = false;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnActivos);
            this.groupBox3.Controls.Add(this.btnInactivos);
            this.groupBox3.Controls.Add(this.txtBuscarClientes);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtClientes);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(18, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 210);
            this.groupBox3.TabIndex = 5;
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
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.Location = new System.Drawing.Point(179, 24);
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Size = new System.Drawing.Size(201, 25);
            this.txtBuscarClientes.TabIndex = 8;
            this.txtBuscarClientes.TextChanged += new System.EventHandler(this.txtBuscarClientes_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(63, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Buscar cliente:";
            // 
            // dtClientes
            // 
            this.dtClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtClientes.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClientes.Location = new System.Drawing.Point(64, 58);
            this.dtClientes.MultiSelect = false;
            this.dtClientes.Name = "dtClientes";
            this.dtClientes.ReadOnly = true;
            this.dtClientes.RowHeadersWidth = 51;
            this.dtClientes.Size = new System.Drawing.Size(664, 146);
            this.dtClientes.TabIndex = 0;
            this.dtClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtClientes_CellContentClick);
            // 
            // txtIdClientes
            // 
            this.txtIdClientes.Location = new System.Drawing.Point(706, 9);
            this.txtIdClientes.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdClientes.Name = "txtIdClientes";
            this.txtIdClientes.Size = new System.Drawing.Size(76, 20);
            this.txtIdClientes.TabIndex = 6;
            this.txtIdClientes.Visible = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(809, 506);
            this.Controls.Add(this.txtIdClientes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCorreoClientes;
        public System.Windows.Forms.RichTextBox txtDireccionCliente;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox txtTelefonoClientes;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombreClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstadoCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnElminarClientes;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.Button btnActualizarClientes;
        public System.Windows.Forms.Button btnAgregarClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnActivos;
        public System.Windows.Forms.Button btnInactivos;
        public System.Windows.Forms.TextBox txtBuscarClientes;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dtClientes;
        private System.Windows.Forms.TextBox txtIdClientes;
    }
}