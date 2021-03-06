namespace Win.SMF
{
    partial class FormClientes
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label identidadLabel;
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label rtnLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label tClienteIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.listaClientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaClientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.identidadTextBox = new System.Windows.Forms.TextBox();
            this.nombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.rtnTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaTClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tClienteIdComboBox = new System.Windows.Forms.ComboBox();
            activoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            identidadLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            rtnLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            tClienteIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingNavigator)).BeginInit();
            this.listaClientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(190, 432);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(190, 128);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 3;
            codigoLabel.Text = "Codigo:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Location = new System.Drawing.Point(190, 390);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(97, 13);
            correoElectronicoLabel.TabIndex = 5;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(190, 239);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 7;
            direccionLabel.Text = "Direccion:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(190, 91);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id:";
            // 
            // identidadLabel
            // 
            identidadLabel.AutoSize = true;
            identidadLabel.Location = new System.Drawing.Point(190, 278);
            identidadLabel.Name = "identidadLabel";
            identidadLabel.Size = new System.Drawing.Size(54, 13);
            identidadLabel.TabIndex = 13;
            identidadLabel.Text = "Identidad:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Location = new System.Drawing.Point(190, 200);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(94, 13);
            nombreCompletoLabel.TabIndex = 15;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // rtnLabel
            // 
            rtnLabel.AutoSize = true;
            rtnLabel.Location = new System.Drawing.Point(190, 316);
            rtnLabel.Name = "rtnLabel";
            rtnLabel.Size = new System.Drawing.Size(27, 13);
            rtnLabel.TabIndex = 17;
            rtnLabel.Text = "Rtn:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(190, 351);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 19;
            telefonoLabel.Text = "Telefono:";
            // 
            // tClienteIdLabel
            // 
            tClienteIdLabel.AutoSize = true;
            tClienteIdLabel.Location = new System.Drawing.Point(190, 163);
            tClienteIdLabel.Name = "tClienteIdLabel";
            tClienteIdLabel.Size = new System.Drawing.Size(78, 13);
            tClienteIdLabel.TabIndex = 23;
            tClienteIdLabel.Text = "Tipo de Cliente";
            // 
            // listaClientesBindingNavigator
            // 
            this.listaClientesBindingNavigator.AddNewItem = null;
            this.listaClientesBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaClientesBindingNavigator.BindingSource = this.listaClientesBindingSource;
            this.listaClientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaClientesBindingNavigator.DeleteItem = null;
            this.listaClientesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.listaClientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaClientesBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaClientesBindingNavigator.Location = new System.Drawing.Point(293, 9);
            this.listaClientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaClientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaClientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaClientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaClientesBindingNavigator.Name = "listaClientesBindingNavigator";
            this.listaClientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaClientesBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.listaClientesBindingNavigator.TabIndex = 0;
            this.listaClientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataSource = typeof(BL.SMF.Cliente);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaClientesBindingNavigatorSaveItem
            // 
            this.listaClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaClientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaClientesBindingNavigatorSaveItem.Image")));
            this.listaClientesBindingNavigatorSaveItem.Name = "listaClientesBindingNavigatorSaveItem";
            this.listaClientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaClientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaClientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaClientesBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaClientesBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(293, 427);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(293, 125);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(283, 20);
            this.codigoTextBox.TabIndex = 4;
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "CorreoElectronico", true));
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(293, 387);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(283, 20);
            this.correoElectronicoTextBox.TabIndex = 6;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(293, 236);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(283, 20);
            this.direccionTextBox.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(293, 88);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(283, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // identidadTextBox
            // 
            this.identidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Identidad", true));
            this.identidadTextBox.Location = new System.Drawing.Point(293, 275);
            this.identidadTextBox.Name = "identidadTextBox";
            this.identidadTextBox.Size = new System.Drawing.Size(283, 20);
            this.identidadTextBox.TabIndex = 14;
            // 
            // nombreCompletoTextBox
            // 
            this.nombreCompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "NombreCompleto", true));
            this.nombreCompletoTextBox.Location = new System.Drawing.Point(293, 197);
            this.nombreCompletoTextBox.Name = "nombreCompletoTextBox";
            this.nombreCompletoTextBox.Size = new System.Drawing.Size(283, 20);
            this.nombreCompletoTextBox.TabIndex = 16;
            // 
            // rtnTextBox
            // 
            this.rtnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Rtn", true));
            this.rtnTextBox.Location = new System.Drawing.Point(293, 313);
            this.rtnTextBox.Name = "rtnTextBox";
            this.rtnTextBox.Size = new System.Drawing.Size(283, 20);
            this.rtnTextBox.TabIndex = 18;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(293, 348);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(283, 20);
            this.telefonoTextBox.TabIndex = 20;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaClientesBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(621, 91);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(262, 273);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 21;
            this.fotoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "agregar foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(808, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Remover foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg, png |*.jpg; *.png";
            // 
            // listaTClientesBindingSource
            // 
            this.listaTClientesBindingSource.DataSource = typeof(BL.SMF.TCliente);
            // 
            // tClienteIdComboBox
            // 
            this.tClienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaClientesBindingSource, "TClienteId", true));
            this.tClienteIdComboBox.DataSource = this.listaTClientesBindingSource;
            this.tClienteIdComboBox.DisplayMember = "Condicion";
            this.tClienteIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tClienteIdComboBox.FormattingEnabled = true;
            this.tClienteIdComboBox.Location = new System.Drawing.Point(293, 160);
            this.tClienteIdComboBox.Name = "tClienteIdComboBox";
            this.tClienteIdComboBox.Size = new System.Drawing.Size(283, 21);
            this.tClienteIdComboBox.TabIndex = 24;
            this.tClienteIdComboBox.ValueMember = "Id";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 704);
            this.Controls.Add(tClienteIdLabel);
            this.Controls.Add(this.tClienteIdComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(correoElectronicoLabel);
            this.Controls.Add(this.correoElectronicoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(identidadLabel);
            this.Controls.Add(this.identidadTextBox);
            this.Controls.Add(nombreCompletoLabel);
            this.Controls.Add(this.nombreCompletoTextBox);
            this.Controls.Add(rtnLabel);
            this.Controls.Add(this.rtnTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.listaClientesBindingNavigator);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingNavigator)).EndInit();
            this.listaClientesBindingNavigator.ResumeLayout(false);
            this.listaClientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaClientesBindingSource;
        private System.Windows.Forms.BindingNavigator listaClientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaClientesBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox correoElectronicoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox identidadTextBox;
        private System.Windows.Forms.TextBox nombreCompletoTextBox;
        private System.Windows.Forms.TextBox rtnTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaTClientesBindingSource;
        private System.Windows.Forms.ComboBox tClienteIdComboBox;
    }
}