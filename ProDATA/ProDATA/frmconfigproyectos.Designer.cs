namespace ProDATA
{
    partial class frmconfigproyectos
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
            System.Windows.Forms.Label idproyectoLabel;
            System.Windows.Forms.Label proyectoLabel;
            System.Windows.Forms.Label fechainicioLabel;
            System.Windows.Forms.Label descripciónLabel;
            this.prodataDataSet = new ProDATA.ProdataDataSet();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoTableAdapter = new ProDATA.ProdataDataSetTableAdapters.ProyectoTableAdapter();
            this.tableAdapterManager = new ProDATA.ProdataDataSetTableAdapters.TableAdapterManager();
            this.fechainicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripciónTextBox = new System.Windows.Forms.TextBox();
            this.proyectoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldescriptivo = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.proyectoTextBox = new System.Windows.Forms.TextBox();
            this.idproyectoTextBox = new System.Windows.Forms.TextBox();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            idproyectoLabel = new System.Windows.Forms.Label();
            proyectoLabel = new System.Windows.Forms.Label();
            fechainicioLabel = new System.Windows.Forms.Label();
            descripciónLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idproyectoLabel
            // 
            idproyectoLabel.AutoSize = true;
            idproyectoLabel.Location = new System.Drawing.Point(15, 51);
            idproyectoLabel.Name = "idproyectoLabel";
            idproyectoLabel.Size = new System.Drawing.Size(63, 13);
            idproyectoLabel.TabIndex = 1;
            idproyectoLabel.Text = "ID Proyecto";
            // 
            // proyectoLabel
            // 
            proyectoLabel.AutoSize = true;
            proyectoLabel.Location = new System.Drawing.Point(15, 77);
            proyectoLabel.Name = "proyectoLabel";
            proyectoLabel.Size = new System.Drawing.Size(52, 13);
            proyectoLabel.TabIndex = 3;
            proyectoLabel.Text = "Proyecto:";
            // 
            // fechainicioLabel
            // 
            fechainicioLabel.AutoSize = true;
            fechainicioLabel.Location = new System.Drawing.Point(15, 104);
            fechainicioLabel.Name = "fechainicioLabel";
            fechainicioLabel.Size = new System.Drawing.Size(64, 13);
            fechainicioLabel.TabIndex = 5;
            fechainicioLabel.Text = "Fecha inicio";
            // 
            // descripciónLabel
            // 
            descripciónLabel.AutoSize = true;
            descripciónLabel.Location = new System.Drawing.Point(15, 129);
            descripciónLabel.Name = "descripciónLabel";
            descripciónLabel.Size = new System.Drawing.Size(66, 13);
            descripciónLabel.TabIndex = 7;
            descripciónLabel.Text = "Descripción:";
            // 
            // prodataDataSet
            // 
            this.prodataDataSet.DataSetName = "ProdataDataSet";
            this.prodataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "Proyecto";
            this.proyectoBindingSource.DataSource = this.prodataDataSet;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.equipoTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.ProyectoTableAdapter = this.proyectoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProDATA.ProdataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fechainicioDateTimePicker
            // 
            this.fechainicioDateTimePicker.Location = new System.Drawing.Point(87, 100);
            this.fechainicioDateTimePicker.Name = "fechainicioDateTimePicker";
            this.fechainicioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechainicioDateTimePicker.TabIndex = 6;
            // 
            // descripciónTextBox
            // 
            this.descripciónTextBox.Location = new System.Drawing.Point(87, 126);
            this.descripciónTextBox.Multiline = true;
            this.descripciónTextBox.Name = "descripciónTextBox";
            this.descripciónTextBox.Size = new System.Drawing.Size(342, 72);
            this.descripciónTextBox.TabIndex = 8;
            // 
            // proyectoDataGridView
            // 
            this.proyectoDataGridView.AllowUserToAddRows = false;
            this.proyectoDataGridView.AllowUserToDeleteRows = false;
            this.proyectoDataGridView.AllowUserToOrderColumns = true;
            this.proyectoDataGridView.AutoGenerateColumns = false;
            this.proyectoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proyectoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.proyectoDataGridView.DataSource = this.proyectoBindingSource;
            this.proyectoDataGridView.Location = new System.Drawing.Point(82, 284);
            this.proyectoDataGridView.Name = "proyectoDataGridView";
            this.proyectoDataGridView.ReadOnly = true;
            this.proyectoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.proyectoDataGridView.Size = new System.Drawing.Size(443, 220);
            this.proyectoDataGridView.TabIndex = 9;
            this.proyectoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proyectoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Idproyecto";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Proyecto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Proyecto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Proyecto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fechainicio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha inicio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripción";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lbldescriptivo
            // 
            this.lbldescriptivo.AutoSize = true;
            this.lbldescriptivo.Location = new System.Drawing.Point(84, 19);
            this.lbldescriptivo.Name = "lbldescriptivo";
            this.lbldescriptivo.Size = new System.Drawing.Size(183, 13);
            this.lbldescriptivo.TabIndex = 10;
            this.lbldescriptivo.Text = "Menu de configuración de proyectos.";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(193, 254);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 11;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(82, 510);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(178, 510);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actuaizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(87, 257);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(450, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(450, 114);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 17;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(450, 153);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProDATA.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(548, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Location = new System.Drawing.Point(545, 19);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(38, 13);
            this.lbltiempo.TabIndex = 20;
            this.lbltiempo.Text = "tiempo";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // proyectoTextBox
            // 
            this.proyectoTextBox.Location = new System.Drawing.Point(87, 74);
            this.proyectoTextBox.Name = "proyectoTextBox";
            this.proyectoTextBox.Size = new System.Drawing.Size(200, 20);
            this.proyectoTextBox.TabIndex = 4;
            // 
            // idproyectoTextBox
            // 
            this.idproyectoTextBox.Location = new System.Drawing.Point(87, 48);
            this.idproyectoTextBox.Name = "idproyectoTextBox";
            this.idproyectoTextBox.ReadOnly = true;
            this.idproyectoTextBox.Size = new System.Drawing.Size(47, 20);
            this.idproyectoTextBox.TabIndex = 2;
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(274, 254);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(80, 23);
            this.btnLimpiarBusqueda.TabIndex = 21;
            this.btnLimpiarBusqueda.Text = "Bor. Busq";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = true;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Buscar en Cuadro";
            // 
            // frmconfigproyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiarBusqueda);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.lbldescriptivo);
            this.Controls.Add(this.proyectoDataGridView);
            this.Controls.Add(idproyectoLabel);
            this.Controls.Add(this.idproyectoTextBox);
            this.Controls.Add(proyectoLabel);
            this.Controls.Add(this.proyectoTextBox);
            this.Controls.Add(fechainicioLabel);
            this.Controls.Add(this.fechainicioDateTimePicker);
            this.Controls.Add(descripciónLabel);
            this.Controls.Add(this.descripciónTextBox);
            this.Name = "frmconfigproyectos";
            this.Text = "frmconfigproyectos";
            this.Load += new System.EventHandler(this.frmconfigproyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProdataDataSet prodataDataSet;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private ProdataDataSetTableAdapters.ProyectoTableAdapter proyectoTableAdapter;
        private ProdataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fechainicioDateTimePicker;
        private System.Windows.Forms.TextBox descripciónTextBox;
        private System.Windows.Forms.DataGridView proyectoDataGridView;
        private System.Windows.Forms.Label lbldescriptivo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox proyectoTextBox;
        private System.Windows.Forms.TextBox idproyectoTextBox;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.Label label1;
    }
}