namespace Win.SMF
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Configuracion = new System.Windows.Forms.Button();
            this.Reportes = new System.Windows.Forms.Button();
            this.Facturacion = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.CerrarCloseForm = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.panelEscritorio.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.Configuracion);
            this.panelMenu.Controls.Add(this.Reportes);
            this.panelMenu.Controls.Add(this.Facturacion);
            this.panelMenu.Controls.Add(this.Clientes);
            this.panelMenu.Controls.Add(this.Productos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 463);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Configuracion
            // 
            this.Configuracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.Configuracion.FlatAppearance.BorderSize = 0;
            this.Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Configuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configuracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Configuracion.Image = global::Win.SMF.Properties.Resources.settings;
            this.Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Configuracion.Location = new System.Drawing.Point(0, 280);
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Configuracion.Size = new System.Drawing.Size(220, 50);
            this.Configuracion.TabIndex = 5;
            this.Configuracion.Text = "  Configuracion";
            this.Configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Configuracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Configuracion.UseVisualStyleBackColor = true;
            this.Configuracion.Click += new System.EventHandler(this.Configuracion_Click);
            // 
            // Reportes
            // 
            this.Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reportes.FlatAppearance.BorderSize = 0;
            this.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.Reportes.Image = global::Win.SMF.Properties.Resources.bar_chart;
            this.Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.Location = new System.Drawing.Point(0, 230);
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Reportes.Size = new System.Drawing.Size(220, 50);
            this.Reportes.TabIndex = 4;
            this.Reportes.Text = "  Reportes";
            this.Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportes.UseVisualStyleBackColor = true;
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // Facturacion
            // 
            this.Facturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.Facturacion.FlatAppearance.BorderSize = 0;
            this.Facturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Facturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facturacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Facturacion.Image = global::Win.SMF.Properties.Resources.shopping_list;
            this.Facturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Facturacion.Location = new System.Drawing.Point(0, 180);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Facturacion.Size = new System.Drawing.Size(220, 50);
            this.Facturacion.TabIndex = 3;
            this.Facturacion.Text = "  Facturacion";
            this.Facturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Facturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Facturacion.UseVisualStyleBackColor = true;
            this.Facturacion.Click += new System.EventHandler(this.Facturacion_Click);
            // 
            // Clientes
            // 
            this.Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Clientes.FlatAppearance.BorderSize = 0;
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.Clientes.Image = global::Win.SMF.Properties.Resources.value__1_;
            this.Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.Location = new System.Drawing.Point(0, 130);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Clientes.Size = new System.Drawing.Size(220, 50);
            this.Clientes.TabIndex = 2;
            this.Clientes.Text = "  Clientes";
            this.Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Productos
            // 
            this.Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Productos.FlatAppearance.BorderSize = 0;
            this.Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.ForeColor = System.Drawing.Color.Gainsboro;
            this.Productos.Image = global::Win.SMF.Properties.Resources.shopping_cart__1_;
            this.Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productos.Location = new System.Drawing.Point(0, 80);
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Productos.Size = new System.Drawing.Size(220, 50);
            this.Productos.TabIndex = 1;
            this.Productos.Text = "   Productos";
            this.Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Productos.UseVisualStyleBackColor = true;
            this.Productos.Click += new System.EventHandler(this.Productos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Maestro";
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelBarraTitulo.Controls.Add(this.CerrarCloseForm);
            this.panelBarraTitulo.Controls.Add(this.Titulo);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1038, 80);
            this.panelBarraTitulo.TabIndex = 1;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo_Paint);
            // 
            // CerrarCloseForm
            // 
            this.CerrarCloseForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.CerrarCloseForm.FlatAppearance.BorderSize = 0;
            this.CerrarCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarCloseForm.Image = global::Win.SMF.Properties.Resources.cross_out__2_;
            this.CerrarCloseForm.Location = new System.Drawing.Point(0, 0);
            this.CerrarCloseForm.Name = "CerrarCloseForm";
            this.CerrarCloseForm.Size = new System.Drawing.Size(75, 80);
            this.CerrarCloseForm.TabIndex = 1;
            this.CerrarCloseForm.UseVisualStyleBackColor = true;
            this.CerrarCloseForm.Click += new System.EventHandler(this.CerrarCloseForm_Click);
            // 
            // Titulo
            // 
            this.Titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(469, 30);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(85, 27);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "INICIO";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.Controls.Add(this.labelFecha);
            this.panelEscritorio.Controls.Add(this.labelHora);
            this.panelEscritorio.Controls.Add(this.statusStrip1);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(220, 80);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(1038, 383);
            this.panelEscritorio.TabIndex = 2;
            this.panelEscritorio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEscritorio_Paint);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.Teal;
            this.labelFecha.Location = new System.Drawing.Point(415, 89);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(90, 31);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.Teal;
            this.labelHora.Location = new System.Drawing.Point(477, 29);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(107, 46);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "Hora";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1038, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 463);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button Configuracion;
        private System.Windows.Forms.Button Reportes;
        private System.Windows.Forms.Button Facturacion;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Button CerrarCloseForm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timer1;
    }
}