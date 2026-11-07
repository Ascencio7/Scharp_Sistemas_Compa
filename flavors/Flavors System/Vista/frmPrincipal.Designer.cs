namespace Flavors_System
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnMesas);
            this.pnlMenu.Controls.Add(this.btnProductos);
            this.pnlMenu.Controls.Add(this.btnPedidos);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnEmpleados);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 539);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Flavors_System.Properties.Resources.logout;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 497);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 42);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Tag = "Cerrar sesión";
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesas.Image = global::Flavors_System.Properties.Resources.mesas;
            this.btnMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesas.Location = new System.Drawing.Point(0, 243);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(200, 42);
            this.btnMesas.TabIndex = 6;
            this.btnMesas.Tag = "Mesas";
            this.btnMesas.Text = "Mesas";
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = global::Flavors_System.Properties.Resources.restaurante;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 201);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 42);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Tag = "Productos";
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Image = global::Flavors_System.Properties.Resources.Pedidos;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(0, 159);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(200, 42);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Tag = "Pedidos";
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = global::Flavors_System.Properties.Resources.cliente;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 117);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 42);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Tag = "Clientes";
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = global::Flavors_System.Properties.Resources.empleados;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 75);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(200, 42);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Tag = "Empleados";
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Image = global::Flavors_System.Properties.Resources.users;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 33);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 42);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Tag = "Usuarios";
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.btnMenu);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 33);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.Image = global::Flavors_System.Properties.Resources.menuoscuro;
            this.btnMenu.Location = new System.Drawing.Point(165, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 33);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(7, 5);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(156, 23);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Flavors System";
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.pnlControles.Controls.Add(this.txtTipo);
            this.pnlControles.Controls.Add(this.txtID);
            this.pnlControles.Controls.Add(this.btnMinimizar);
            this.pnlControles.Controls.Add(this.btnMaximizar);
            this.pnlControles.Controls.Add(this.btnCerrar);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControles.Location = new System.Drawing.Point(200, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(809, 33);
            this.pnlControles.TabIndex = 1;
            this.pnlControles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControles_MouseDown);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(37, 5);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(25, 20);
            this.txtTipo.TabIndex = 12;
            this.txtTipo.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(25, 20);
            this.txtID.TabIndex = 11;
            this.txtID.Visible = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = global::Flavors_System.Properties.Resources.minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(704, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 33);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.Image = global::Flavors_System.Properties.Resources.maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(739, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 33);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = global::Flavors_System.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(774, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 33);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 33);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(809, 506);
            this.pnlContenedor.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 539);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        public System.Windows.Forms.TextBox txtTipo;
        public System.Windows.Forms.TextBox txtID;
    }
}

