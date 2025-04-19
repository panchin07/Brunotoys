namespace SistemaFabrica
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab1 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab2 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            this.ultraTabPageControl1 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.gbxArchivosCorte = new Infragistics.Win.Misc.UltraGroupBox();
            this.cbxTipoCorte = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblCodigoColor = new System.Windows.Forms.Label();
            this.btnCerrarArchivosCorte = new System.Windows.Forms.Button();
            this.btnAceptarArchivosCorte = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSelectArchivoCorte = new System.Windows.Forms.Button();
            this.txtArchivoCorte = new System.Windows.Forms.TextBox();
            this.cbxTelaArchivo = new System.Windows.Forms.ComboBox();
            this.tblTipotelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Modelo1 = new SistemaFabrica.DAL.DS_Modelo();
            this.label24 = new System.Windows.Forms.Label();
            this.cbxColorArchivo = new System.Windows.Forms.ComboBox();
            this.tblColoresTelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.txtPotenciaArchivo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVelocidadArchivo = new System.Windows.Forms.TextBox();
            this.txtCorteNombre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCantidadArchivo = new System.Windows.Forms.TextBox();
            this.txtCodigoArchivo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTamañoArchivo = new System.Windows.Forms.TextBox();
            this.ultraGroupBox4 = new Infragistics.Win.Misc.UltraGroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtCostoCorte = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dgvArchivosCorte = new System.Windows.Forms.DataGridView();
            this.idArchivoCorteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idModeloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreModeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArchivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamañoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCorteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColorTelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoTelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCostoTela = new System.Windows.Forms.TextBox();
            this.btnNuevoCorte = new System.Windows.Forms.Button();
            this.gbxCostos = new Infragistics.Win.Misc.UltraGroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVentaTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUtilidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCostoSR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPVUnidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPVMayor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPVSR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCostoUnidad = new System.Windows.Forms.TextBox();
            this.ultraGroupBox5 = new Infragistics.Win.Misc.UltraGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnAbrirFoto = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.ultraTabPageControl2 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarCategoria = new System.Windows.Forms.Label();
            this.dgvListaModelo = new System.Windows.Forms.DataGridView();
            this.idModeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamañoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costounidadSRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaSRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaMayorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoCosturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoGramosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Modelo = new SistemaFabrica.DAL.DS_Modelo();
            this.viewArchivoCorteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbControles = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
            this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdAbrirFoto = new System.Windows.Forms.OpenFileDialog();
            this.ofdCorte = new System.Windows.Forms.OpenFileDialog();
            this.tbl_ModeloTableAdapter = new SistemaFabrica.DAL.DS_ModeloTableAdapters.tbl_ModeloTableAdapter();
            this.view_ArchivoCorteTableAdapter = new SistemaFabrica.DAL.DS_ModeloTableAdapters.View_ArchivoCorteTableAdapter();
            this.tbl_Tipo_telaTableAdapter = new SistemaFabrica.DAL.DS_ModeloTableAdapters.tbl_Tipo_telaTableAdapter();
            this.tbl_Colores_TelasTableAdapter = new SistemaFabrica.DAL.DS_ModeloTableAdapters.tbl_Colores_TelasTableAdapter();
            this.label32 = new System.Windows.Forms.Label();
            this.txtCostoTelas = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtCostoCorte_ = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtCostoCostura = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtCostoNapa = new System.Windows.Forms.TextBox();
            this.txtCostoNapa_Und = new System.Windows.Forms.TextBox();
            this.txtCostoTelas_Und = new System.Windows.Forms.TextBox();
            this.txtCostoCorte_Und = new System.Windows.Forms.TextBox();
            this.txtCostoCostura_Und = new System.Windows.Forms.TextBox();
            this.cmsMenuCorte = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultraTabPageControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxArchivosCorte)).BeginInit();
            this.gbxArchivosCorte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipotelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Modelo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblColoresTelasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox4)).BeginInit();
            this.ultraGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivosCorte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxCostos)).BeginInit();
            this.gbxCostos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox5)).BeginInit();
            this.ultraGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.ultraTabPageControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblModeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArchivoCorteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbControles)).BeginInit();
            this.tbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.cmsMenuCorte.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraTabPageControl1
            // 
            this.ultraTabPageControl1.Controls.Add(this.ultraGroupBox1);
            this.ultraTabPageControl1.Location = new System.Drawing.Point(34, 2);
            this.ultraTabPageControl1.Name = "ultraTabPageControl1";
            this.ultraTabPageControl1.Size = new System.Drawing.Size(1113, 660);
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            this.ultraGroupBox1.Controls.Add(this.chart1);
            this.ultraGroupBox1.Controls.Add(this.gbxArchivosCorte);
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox4);
            this.ultraGroupBox1.Controls.Add(this.gbxCostos);
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox5);
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox3);
            this.ultraGroupBox1.Controls.Add(this.pnlBotones);
            this.ultraGroupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGroupBox1.Location = new System.Drawing.Point(4, 3);
            this.ultraGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(1105, 653);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.Text = "MODELOS";
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // gbxArchivosCorte
            // 
            this.gbxArchivosCorte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxArchivosCorte.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            this.gbxArchivosCorte.Controls.Add(this.cbxTipoCorte);
            this.gbxArchivosCorte.Controls.Add(this.label29);
            this.gbxArchivosCorte.Controls.Add(this.label28);
            this.gbxArchivosCorte.Controls.Add(this.label27);
            this.gbxArchivosCorte.Controls.Add(this.label26);
            this.gbxArchivosCorte.Controls.Add(this.lblCodigoColor);
            this.gbxArchivosCorte.Controls.Add(this.btnCerrarArchivosCorte);
            this.gbxArchivosCorte.Controls.Add(this.btnAceptarArchivosCorte);
            this.gbxArchivosCorte.Controls.Add(this.label25);
            this.gbxArchivosCorte.Controls.Add(this.btnSelectArchivoCorte);
            this.gbxArchivosCorte.Controls.Add(this.txtArchivoCorte);
            this.gbxArchivosCorte.Controls.Add(this.cbxTelaArchivo);
            this.gbxArchivosCorte.Controls.Add(this.label24);
            this.gbxArchivosCorte.Controls.Add(this.cbxColorArchivo);
            this.gbxArchivosCorte.Controls.Add(this.label17);
            this.gbxArchivosCorte.Controls.Add(this.txtPotenciaArchivo);
            this.gbxArchivosCorte.Controls.Add(this.label18);
            this.gbxArchivosCorte.Controls.Add(this.label19);
            this.gbxArchivosCorte.Controls.Add(this.txtVelocidadArchivo);
            this.gbxArchivosCorte.Controls.Add(this.txtCorteNombre);
            this.gbxArchivosCorte.Controls.Add(this.label20);
            this.gbxArchivosCorte.Controls.Add(this.label21);
            this.gbxArchivosCorte.Controls.Add(this.txtCantidadArchivo);
            this.gbxArchivosCorte.Controls.Add(this.txtCodigoArchivo);
            this.gbxArchivosCorte.Controls.Add(this.label22);
            this.gbxArchivosCorte.Controls.Add(this.label23);
            this.gbxArchivosCorte.Controls.Add(this.txtTamañoArchivo);
            this.gbxArchivosCorte.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArchivosCorte.Location = new System.Drawing.Point(236, 103);
            this.gbxArchivosCorte.Margin = new System.Windows.Forms.Padding(4);
            this.gbxArchivosCorte.Name = "gbxArchivosCorte";
            this.gbxArchivosCorte.Size = new System.Drawing.Size(327, 259);
            this.gbxArchivosCorte.TabIndex = 2;
            this.gbxArchivosCorte.Text = "DATOS ARCHIVO CORTE";
            this.gbxArchivosCorte.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            this.gbxArchivosCorte.Visible = false;
            // 
            // cbxTipoCorte
            // 
            this.cbxTipoCorte.FormattingEnabled = true;
            this.cbxTipoCorte.Items.AddRange(new object[] {
            "Tandada",
            "Capa"});
            this.cbxTipoCorte.Location = new System.Drawing.Point(168, 89);
            this.cbxTipoCorte.Name = "cbxTipoCorte";
            this.cbxTipoCorte.Size = new System.Drawing.Size(111, 23);
            this.cbxTipoCorte.TabIndex = 6;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(126, 93);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 14);
            this.label29.TabIndex = 65;
            this.label29.Text = "Tipo:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(129, 72);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(27, 14);
            this.label28.TabIndex = 64;
            this.label28.Text = "cm.";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(284, 72);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(16, 14);
            this.label27.TabIndex = 63;
            this.label27.Text = "%";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(284, 49);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 14);
            this.label26.TabIndex = 62;
            this.label26.Text = "mm/s";
            // 
            // lblCodigoColor
            // 
            this.lblCodigoColor.AutoSize = true;
            this.lblCodigoColor.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoColor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoColor.Location = new System.Drawing.Point(245, 142);
            this.lblCodigoColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoColor.Name = "lblCodigoColor";
            this.lblCodigoColor.Size = new System.Drawing.Size(13, 14);
            this.lblCodigoColor.TabIndex = 61;
            this.lblCodigoColor.Text = "#";
            // 
            // btnCerrarArchivosCorte
            // 
            this.btnCerrarArchivosCorte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCerrarArchivosCorte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarArchivosCorte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarArchivosCorte.Location = new System.Drawing.Point(168, 229);
            this.btnCerrarArchivosCorte.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarArchivosCorte.Name = "btnCerrarArchivosCorte";
            this.btnCerrarArchivosCorte.Size = new System.Drawing.Size(96, 24);
            this.btnCerrarArchivosCorte.TabIndex = 12;
            this.btnCerrarArchivosCorte.Text = "Cerrar";
            this.btnCerrarArchivosCorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarArchivosCorte.UseVisualStyleBackColor = false;
            this.btnCerrarArchivosCorte.Click += new System.EventHandler(this.btnCerrarArchivosCorte_Click);
            // 
            // btnAceptarArchivosCorte
            // 
            this.btnAceptarArchivosCorte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAceptarArchivosCorte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarArchivosCorte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarArchivosCorte.Location = new System.Drawing.Point(60, 229);
            this.btnAceptarArchivosCorte.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarArchivosCorte.Name = "btnAceptarArchivosCorte";
            this.btnAceptarArchivosCorte.Size = new System.Drawing.Size(96, 24);
            this.btnAceptarArchivosCorte.TabIndex = 11;
            this.btnAceptarArchivosCorte.Text = "Aceptar";
            this.btnAceptarArchivosCorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarArchivosCorte.UseVisualStyleBackColor = false;
            this.btnAceptarArchivosCorte.Click += new System.EventHandler(this.btnAceptarArchivosCorte_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(12, 174);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 15);
            this.label25.TabIndex = 58;
            this.label25.Text = "Archivo:";
            // 
            // btnSelectArchivoCorte
            // 
            this.btnSelectArchivoCorte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSelectArchivoCorte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectArchivoCorte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectArchivoCorte.Location = new System.Drawing.Point(73, 168);
            this.btnSelectArchivoCorte.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectArchivoCorte.Name = "btnSelectArchivoCorte";
            this.btnSelectArchivoCorte.Size = new System.Drawing.Size(168, 26);
            this.btnSelectArchivoCorte.TabIndex = 9;
            this.btnSelectArchivoCorte.Text = "Nuevo Archivo";
            this.btnSelectArchivoCorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectArchivoCorte.UseVisualStyleBackColor = false;
            this.btnSelectArchivoCorte.Click += new System.EventHandler(this.btnSelectArchivoCorte_Click);
            // 
            // txtArchivoCorte
            // 
            this.txtArchivoCorte.Location = new System.Drawing.Point(14, 198);
            this.txtArchivoCorte.Name = "txtArchivoCorte";
            this.txtArchivoCorte.Size = new System.Drawing.Size(306, 21);
            this.txtArchivoCorte.TabIndex = 10;
            // 
            // cbxTelaArchivo
            // 
            this.cbxTelaArchivo.DataSource = this.tblTipotelaBindingSource;
            this.cbxTelaArchivo.DisplayMember = "Nombre";
            this.cbxTelaArchivo.FormattingEnabled = true;
            this.cbxTelaArchivo.Location = new System.Drawing.Point(73, 114);
            this.cbxTelaArchivo.Name = "cbxTelaArchivo";
            this.cbxTelaArchivo.Size = new System.Drawing.Size(206, 23);
            this.cbxTelaArchivo.TabIndex = 7;
            this.cbxTelaArchivo.ValueMember = "id_Tipo_tela";
            this.cbxTelaArchivo.SelectedValueChanged += new System.EventHandler(this.cbxTelaArchivo_SelectedValueChanged);
            // 
            // tblTipotelaBindingSource
            // 
            this.tblTipotelaBindingSource.DataMember = "tbl_Tipo_tela";
            this.tblTipotelaBindingSource.DataSource = this.dS_Modelo1;
            // 
            // dS_Modelo1
            // 
            this.dS_Modelo1.DataSetName = "DS_Modelo";
            this.dS_Modelo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(31, 118);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 14);
            this.label24.TabIndex = 54;
            this.label24.Text = "Tela:";
            // 
            // cbxColorArchivo
            // 
            this.cbxColorArchivo.DataSource = this.tblColoresTelasBindingSource;
            this.cbxColorArchivo.DisplayMember = "Nombre";
            this.cbxColorArchivo.FormattingEnabled = true;
            this.cbxColorArchivo.Location = new System.Drawing.Point(73, 138);
            this.cbxColorArchivo.Name = "cbxColorArchivo";
            this.cbxColorArchivo.Size = new System.Drawing.Size(168, 23);
            this.cbxColorArchivo.TabIndex = 8;
            this.cbxColorArchivo.ValueMember = "Id_Color";
            this.cbxColorArchivo.SelectedValueChanged += new System.EventHandler(this.cbxColorArchivo_SelectedValueChanged);
            // 
            // tblColoresTelasBindingSource
            // 
            this.tblColoresTelasBindingSource.DataMember = "tbl_Colores_Telas";
            this.tblColoresTelasBindingSource.DataSource = this.dS_Modelo1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 142);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 14);
            this.label17.TabIndex = 51;
            this.label17.Text = "Color:";
            // 
            // txtPotenciaArchivo
            // 
            this.txtPotenciaArchivo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPotenciaArchivo.Location = new System.Drawing.Point(230, 69);
            this.txtPotenciaArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPotenciaArchivo.Name = "txtPotenciaArchivo";
            this.txtPotenciaArchivo.Size = new System.Drawing.Size(49, 20);
            this.txtPotenciaArchivo.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(165, 72);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 14);
            this.label18.TabIndex = 50;
            this.label18.Text = "Potencia:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(11, 26);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 14);
            this.label19.TabIndex = 0;
            this.label19.Text = "Nombre:";
            // 
            // txtVelocidadArchivo
            // 
            this.txtVelocidadArchivo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelocidadArchivo.Location = new System.Drawing.Point(230, 46);
            this.txtVelocidadArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVelocidadArchivo.Name = "txtVelocidadArchivo";
            this.txtVelocidadArchivo.Size = new System.Drawing.Size(49, 20);
            this.txtVelocidadArchivo.TabIndex = 2;
            // 
            // txtCorteNombre
            // 
            this.txtCorteNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorteNombre.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorteNombre.Location = new System.Drawing.Point(73, 23);
            this.txtCorteNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorteNombre.Name = "txtCorteNombre";
            this.txtCorteNombre.Size = new System.Drawing.Size(233, 20);
            this.txtCorteNombre.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(159, 49);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 14);
            this.label20.TabIndex = 48;
            this.label20.Text = "Velocidad:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 49);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 14);
            this.label21.TabIndex = 5;
            this.label21.Text = "Codigo:";
            // 
            // txtCantidadArchivo
            // 
            this.txtCantidadArchivo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadArchivo.Location = new System.Drawing.Point(73, 92);
            this.txtCantidadArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadArchivo.Name = "txtCantidadArchivo";
            this.txtCantidadArchivo.Size = new System.Drawing.Size(48, 20);
            this.txtCantidadArchivo.TabIndex = 5;
            // 
            // txtCodigoArchivo
            // 
            this.txtCodigoArchivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoArchivo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoArchivo.Location = new System.Drawing.Point(73, 46);
            this.txtCodigoArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoArchivo.MaxLength = 8;
            this.txtCodigoArchivo.Name = "txtCodigoArchivo";
            this.txtCodigoArchivo.Size = new System.Drawing.Size(83, 20);
            this.txtCodigoArchivo.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(7, 95);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 14);
            this.label22.TabIndex = 47;
            this.label22.Text = "Cantidad:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(12, 72);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 14);
            this.label23.TabIndex = 40;
            this.label23.Text = "Tamaño:";
            // 
            // txtTamañoArchivo
            // 
            this.txtTamañoArchivo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamañoArchivo.Location = new System.Drawing.Point(73, 69);
            this.txtTamañoArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTamañoArchivo.Name = "txtTamañoArchivo";
            this.txtTamañoArchivo.Size = new System.Drawing.Size(48, 20);
            this.txtTamañoArchivo.TabIndex = 3;
            // 
            // ultraGroupBox4
            // 
            this.ultraGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGroupBox4.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            this.ultraGroupBox4.Controls.Add(this.label31);
            this.ultraGroupBox4.Controls.Add(this.txtCostoCorte);
            this.ultraGroupBox4.Controls.Add(this.label30);
            this.ultraGroupBox4.Controls.Add(this.dgvArchivosCorte);
            this.ultraGroupBox4.Controls.Add(this.txtCostoTela);
            this.ultraGroupBox4.Controls.Add(this.btnNuevoCorte);
            this.ultraGroupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGroupBox4.Location = new System.Drawing.Point(6, 77);
            this.ultraGroupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.ultraGroupBox4.Name = "ultraGroupBox4";
            this.ultraGroupBox4.Size = new System.Drawing.Size(783, 231);
            this.ultraGroupBox4.TabIndex = 1;
            this.ultraGroupBox4.Text = "ARCHIVOS CORTE";
            this.ultraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(298, 31);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(77, 14);
            this.label31.TabIndex = 56;
            this.label31.Text = "Costo Corte:";
            // 
            // txtCostoCorte
            // 
            this.txtCostoCorte.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoCorte.Location = new System.Drawing.Point(381, 28);
            this.txtCostoCorte.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostoCorte.Name = "txtCostoCorte";
            this.txtCostoCorte.Size = new System.Drawing.Size(100, 20);
            this.txtCostoCorte.TabIndex = 55;
            this.txtCostoCorte.Text = "0.00";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(112, 31);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 14);
            this.label30.TabIndex = 54;
            this.label30.Text = "Costo Telas:";
            // 
            // dgvArchivosCorte
            // 
            this.dgvArchivosCorte.AllowUserToAddRows = false;
            this.dgvArchivosCorte.AllowUserToDeleteRows = false;
            this.dgvArchivosCorte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArchivosCorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivosCorte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArchivoCorteDataGridViewTextBoxColumn,
            this.idModeloDataGridViewTextBoxColumn1,
            this.nombreModeloDataGridViewTextBoxColumn,
            this.nombreArchivoDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn1,
            this.tamañoDataGridViewTextBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn1,
            this.tipoCorteDataGridViewTextBoxColumn1,
            this.velocidadDataGridViewTextBoxColumn,
            this.potenciaDataGridViewTextBoxColumn,
            this.idColorDataGridViewTextBoxColumn,
            this.nombreColorTelaDataGridViewTextBoxColumn,
            this.codigoTelaDataGridViewTextBoxColumn,
            this.idTipoTelaDataGridViewTextBoxColumn,
            this.nombreTelaDataGridViewTextBoxColumn,
            this.rutaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn1});
            this.dgvArchivosCorte.ContextMenuStrip = this.cmsMenuCorte;
            this.dgvArchivosCorte.Location = new System.Drawing.Point(6, 56);
            this.dgvArchivosCorte.Name = "dgvArchivosCorte";
            this.dgvArchivosCorte.ReadOnly = true;
            this.dgvArchivosCorte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchivosCorte.Size = new System.Drawing.Size(772, 170);
            this.dgvArchivosCorte.TabIndex = 1;
            // 
            // idArchivoCorteDataGridViewTextBoxColumn
            // 
            this.idArchivoCorteDataGridViewTextBoxColumn.DataPropertyName = "id_Archivo_Corte";
            this.idArchivoCorteDataGridViewTextBoxColumn.HeaderText = "id_Archivo_Corte";
            this.idArchivoCorteDataGridViewTextBoxColumn.Name = "idArchivoCorteDataGridViewTextBoxColumn";
            this.idArchivoCorteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArchivoCorteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idModeloDataGridViewTextBoxColumn1
            // 
            this.idModeloDataGridViewTextBoxColumn1.DataPropertyName = "id_Modelo";
            this.idModeloDataGridViewTextBoxColumn1.HeaderText = "id_Modelo";
            this.idModeloDataGridViewTextBoxColumn1.Name = "idModeloDataGridViewTextBoxColumn1";
            this.idModeloDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idModeloDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nombreModeloDataGridViewTextBoxColumn
            // 
            this.nombreModeloDataGridViewTextBoxColumn.DataPropertyName = "NombreModelo";
            this.nombreModeloDataGridViewTextBoxColumn.HeaderText = "NombreModelo";
            this.nombreModeloDataGridViewTextBoxColumn.Name = "nombreModeloDataGridViewTextBoxColumn";
            this.nombreModeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreModeloDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreArchivoDataGridViewTextBoxColumn
            // 
            this.nombreArchivoDataGridViewTextBoxColumn.DataPropertyName = "NombreArchivo";
            this.nombreArchivoDataGridViewTextBoxColumn.HeaderText = "NombreArchivo";
            this.nombreArchivoDataGridViewTextBoxColumn.Name = "nombreArchivoDataGridViewTextBoxColumn";
            this.nombreArchivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn1
            // 
            this.codigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.Name = "codigoDataGridViewTextBoxColumn1";
            this.codigoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn1.Width = 50;
            // 
            // tamañoDataGridViewTextBoxColumn1
            // 
            this.tamañoDataGridViewTextBoxColumn1.DataPropertyName = "Tamaño";
            this.tamañoDataGridViewTextBoxColumn1.HeaderText = "Tamaño";
            this.tamañoDataGridViewTextBoxColumn1.Name = "tamañoDataGridViewTextBoxColumn1";
            this.tamañoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tamañoDataGridViewTextBoxColumn1.Width = 50;
            // 
            // cantidadDataGridViewTextBoxColumn1
            // 
            this.cantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn1.Name = "cantidadDataGridViewTextBoxColumn1";
            this.cantidadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn1.Width = 50;
            // 
            // tipoCorteDataGridViewTextBoxColumn1
            // 
            this.tipoCorteDataGridViewTextBoxColumn1.DataPropertyName = "tipoCorte";
            this.tipoCorteDataGridViewTextBoxColumn1.HeaderText = "tipoCorte";
            this.tipoCorteDataGridViewTextBoxColumn1.Name = "tipoCorteDataGridViewTextBoxColumn1";
            this.tipoCorteDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tipoCorteDataGridViewTextBoxColumn1.Width = 70;
            // 
            // velocidadDataGridViewTextBoxColumn
            // 
            this.velocidadDataGridViewTextBoxColumn.DataPropertyName = "Velocidad";
            this.velocidadDataGridViewTextBoxColumn.HeaderText = "Velocidad";
            this.velocidadDataGridViewTextBoxColumn.Name = "velocidadDataGridViewTextBoxColumn";
            this.velocidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.velocidadDataGridViewTextBoxColumn.Width = 50;
            // 
            // potenciaDataGridViewTextBoxColumn
            // 
            this.potenciaDataGridViewTextBoxColumn.DataPropertyName = "Potencia";
            this.potenciaDataGridViewTextBoxColumn.HeaderText = "Potencia";
            this.potenciaDataGridViewTextBoxColumn.Name = "potenciaDataGridViewTextBoxColumn";
            this.potenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.potenciaDataGridViewTextBoxColumn.Width = 50;
            // 
            // idColorDataGridViewTextBoxColumn
            // 
            this.idColorDataGridViewTextBoxColumn.DataPropertyName = "Id_Color";
            this.idColorDataGridViewTextBoxColumn.HeaderText = "Id_Color";
            this.idColorDataGridViewTextBoxColumn.Name = "idColorDataGridViewTextBoxColumn";
            this.idColorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idColorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreColorTelaDataGridViewTextBoxColumn
            // 
            this.nombreColorTelaDataGridViewTextBoxColumn.DataPropertyName = "NombreColorTela";
            this.nombreColorTelaDataGridViewTextBoxColumn.HeaderText = "NombreColorTela";
            this.nombreColorTelaDataGridViewTextBoxColumn.Name = "nombreColorTelaDataGridViewTextBoxColumn";
            this.nombreColorTelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoTelaDataGridViewTextBoxColumn
            // 
            this.codigoTelaDataGridViewTextBoxColumn.DataPropertyName = "CodigoTela";
            this.codigoTelaDataGridViewTextBoxColumn.HeaderText = "CodigoTela";
            this.codigoTelaDataGridViewTextBoxColumn.Name = "codigoTelaDataGridViewTextBoxColumn";
            this.codigoTelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoTelaDataGridViewTextBoxColumn.Width = 50;
            // 
            // idTipoTelaDataGridViewTextBoxColumn
            // 
            this.idTipoTelaDataGridViewTextBoxColumn.DataPropertyName = "Id_Tipo_Tela";
            this.idTipoTelaDataGridViewTextBoxColumn.HeaderText = "Id_Tipo_Tela";
            this.idTipoTelaDataGridViewTextBoxColumn.Name = "idTipoTelaDataGridViewTextBoxColumn";
            this.idTipoTelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoTelaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreTelaDataGridViewTextBoxColumn
            // 
            this.nombreTelaDataGridViewTextBoxColumn.DataPropertyName = "NombreTela";
            this.nombreTelaDataGridViewTextBoxColumn.HeaderText = "NombreTela";
            this.nombreTelaDataGridViewTextBoxColumn.Name = "nombreTelaDataGridViewTextBoxColumn";
            this.nombreTelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutaDataGridViewTextBoxColumn
            // 
            this.rutaDataGridViewTextBoxColumn.DataPropertyName = "Ruta";
            this.rutaDataGridViewTextBoxColumn.HeaderText = "Ruta";
            this.rutaDataGridViewTextBoxColumn.Name = "rutaDataGridViewTextBoxColumn";
            this.rutaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn1
            // 
            this.estadoDataGridViewTextBoxColumn1.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn1.Name = "estadoDataGridViewTextBoxColumn1";
            this.estadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // txtCostoTela
            // 
            this.txtCostoTela.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTela.Location = new System.Drawing.Point(195, 28);
            this.txtCostoTela.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostoTela.Name = "txtCostoTela";
            this.txtCostoTela.Size = new System.Drawing.Size(100, 20);
            this.txtCostoTela.TabIndex = 53;
            this.txtCostoTela.Text = "0.00";
            // 
            // btnNuevoCorte
            // 
            this.btnNuevoCorte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevoCorte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoCorte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoCorte.Location = new System.Drawing.Point(6, 25);
            this.btnNuevoCorte.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoCorte.Name = "btnNuevoCorte";
            this.btnNuevoCorte.Size = new System.Drawing.Size(96, 24);
            this.btnNuevoCorte.TabIndex = 0;
            this.btnNuevoCorte.Text = "Nuevo";
            this.btnNuevoCorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCorte.UseVisualStyleBackColor = false;
            this.btnNuevoCorte.Click += new System.EventHandler(this.btnNuevoCorte_Click);
            // 
            // gbxCostos
            // 
            this.gbxCostos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCostos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            this.gbxCostos.Controls.Add(this.txtCostoNapa_Und);
            this.gbxCostos.Controls.Add(this.txtCostoTelas_Und);
            this.gbxCostos.Controls.Add(this.txtCostoCorte_Und);
            this.gbxCostos.Controls.Add(this.txtCostoCostura_Und);
            this.gbxCostos.Controls.Add(this.label35);
            this.gbxCostos.Controls.Add(this.txtCostoNapa);
            this.gbxCostos.Controls.Add(this.label32);
            this.gbxCostos.Controls.Add(this.txtPVSR);
            this.gbxCostos.Controls.Add(this.txtCostoUnidad);
            this.gbxCostos.Controls.Add(this.label7);
            this.gbxCostos.Controls.Add(this.label6);
            this.gbxCostos.Controls.Add(this.txtPVMayor);
            this.gbxCostos.Controls.Add(this.txtCostoTelas);
            this.gbxCostos.Controls.Add(this.label8);
            this.gbxCostos.Controls.Add(this.txtCostoSR);
            this.gbxCostos.Controls.Add(this.txtPVUnidad);
            this.gbxCostos.Controls.Add(this.label9);
            this.gbxCostos.Controls.Add(this.label33);
            this.gbxCostos.Controls.Add(this.label11);
            this.gbxCostos.Controls.Add(this.txtCostoCorte_);
            this.gbxCostos.Controls.Add(this.label34);
            this.gbxCostos.Controls.Add(this.txtCostoCostura);
            this.gbxCostos.Controls.Add(this.label15);
            this.gbxCostos.Controls.Add(this.txtVentaTotal);
            this.gbxCostos.Controls.Add(this.label13);
            this.gbxCostos.Controls.Add(this.txtCostoTotal);
            this.gbxCostos.Controls.Add(this.label12);
            this.gbxCostos.Controls.Add(this.txtUtilidad);
            this.gbxCostos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCostos.Location = new System.Drawing.Point(791, 359);
            this.gbxCostos.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCostos.Name = "gbxCostos";
            this.gbxCostos.Size = new System.Drawing.Size(308, 287);
            this.gbxCostos.TabIndex = 5;
            this.gbxCostos.Text = "COSTOS";
            this.gbxCostos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(484, 410);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(291, 166);
            this.chart1.TabIndex = 60;
            this.chart1.Text = "chart1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 263);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 14);
            this.label15.TabIndex = 59;
            this.label15.Text = "VENTA TOTAL:";
            // 
            // txtVentaTotal
            // 
            this.txtVentaTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaTotal.Location = new System.Drawing.Point(120, 260);
            this.txtVentaTotal.Name = "txtVentaTotal";
            this.txtVentaTotal.Size = new System.Drawing.Size(46, 20);
            this.txtVentaTotal.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 114);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 14);
            this.label13.TabIndex = 57;
            this.label13.Text = "Costo TOTAL:";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTotal.Location = new System.Drawing.Point(120, 111);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(46, 20);
            this.txtCostoTotal.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(197, 263);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 14);
            this.label12.TabIndex = 55;
            this.label12.Text = "Utilidad:";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidad.Location = new System.Drawing.Point(254, 260);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(46, 20);
            this.txtUtilidad.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 156);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 14);
            this.label11.TabIndex = 53;
            this.label11.Text = "Costo Unidad S/R:";
            // 
            // txtCostoSR
            // 
            this.txtCostoSR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoSR.Location = new System.Drawing.Point(120, 153);
            this.txtCostoSR.Name = "txtCostoSR";
            this.txtCostoSR.Size = new System.Drawing.Size(46, 20);
            this.txtCostoSR.TabIndex = 1;
            this.txtCostoSR.TextChanged += new System.EventHandler(this.calculoCosto_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 51;
            this.label9.Text = "PV. Unidad:";
            // 
            // txtPVUnidad
            // 
            this.txtPVUnidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPVUnidad.Location = new System.Drawing.Point(120, 179);
            this.txtPVUnidad.Name = "txtPVUnidad";
            this.txtPVUnidad.Size = new System.Drawing.Size(46, 20);
            this.txtPVUnidad.TabIndex = 2;
            this.txtPVUnidad.TextChanged += new System.EventHandler(this.calculoCosto_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 49;
            this.label8.Text = "PV. Mayor:";
            // 
            // txtPVMayor
            // 
            this.txtPVMayor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPVMayor.Location = new System.Drawing.Point(120, 200);
            this.txtPVMayor.Name = "txtPVMayor";
            this.txtPVMayor.Size = new System.Drawing.Size(46, 20);
            this.txtPVMayor.TabIndex = 3;
            this.txtPVMayor.TextChanged += new System.EventHandler(this.calculoCosto_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 14);
            this.label7.TabIndex = 47;
            this.label7.Text = "PV. Sin Rell.:";
            // 
            // txtPVSR
            // 
            this.txtPVSR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPVSR.Location = new System.Drawing.Point(120, 221);
            this.txtPVSR.Name = "txtPVSR";
            this.txtPVSR.Size = new System.Drawing.Size(46, 20);
            this.txtPVSR.TabIndex = 4;
            this.txtPVSR.TextChanged += new System.EventHandler(this.calculoCosto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 14);
            this.label6.TabIndex = 45;
            this.label6.Text = "Costo Unidad:";
            // 
            // txtCostoUnidad
            // 
            this.txtCostoUnidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnidad.Location = new System.Drawing.Point(120, 132);
            this.txtCostoUnidad.Name = "txtCostoUnidad";
            this.txtCostoUnidad.Size = new System.Drawing.Size(46, 20);
            this.txtCostoUnidad.TabIndex = 0;
            this.txtCostoUnidad.TextChanged += new System.EventHandler(this.calculoCosto_TextChanged);
            // 
            // ultraGroupBox5
            // 
            this.ultraGroupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGroupBox5.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            this.ultraGroupBox5.Controls.Add(this.label4);
            this.ultraGroupBox5.Controls.Add(this.pbxImagen);
            this.ultraGroupBox5.Controls.Add(this.btnAbrirFoto);
            this.ultraGroupBox5.Controls.Add(this.txtImagen);
            this.ultraGroupBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGroupBox5.Location = new System.Drawing.Point(791, 77);
            this.ultraGroupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.ultraGroupBox5.Name = "ultraGroupBox5";
            this.ultraGroupBox5.Size = new System.Drawing.Size(307, 279);
            this.ultraGroupBox5.TabIndex = 4;
            this.ultraGroupBox5.Text = "IMAGEN MODELO";
            this.ultraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Foto:";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(31, 82);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(238, 193);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 44;
            this.pbxImagen.TabStop = false;
            // 
            // btnAbrirFoto
            // 
            this.btnAbrirFoto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbrirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirFoto.Location = new System.Drawing.Point(53, 25);
            this.btnAbrirFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirFoto.Name = "btnAbrirFoto";
            this.btnAbrirFoto.Size = new System.Drawing.Size(168, 26);
            this.btnAbrirFoto.TabIndex = 0;
            this.btnAbrirFoto.Text = "Nueva Foto";
            this.btnAbrirFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirFoto.UseVisualStyleBackColor = false;
            this.btnAbrirFoto.Click += new System.EventHandler(this.btnAbrirFoto_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(8, 55);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(292, 21);
            this.txtImagen.TabIndex = 1;
            // 
            // ultraGroupBox3
            // 
            this.ultraGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGroupBox3.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            this.ultraGroupBox3.Controls.Add(this.label16);
            this.ultraGroupBox3.Controls.Add(this.txtCantidad);
            this.ultraGroupBox3.Controls.Add(this.label14);
            this.ultraGroupBox3.Controls.Add(this.label1);
            this.ultraGroupBox3.Controls.Add(this.txtPago);
            this.ultraGroupBox3.Controls.Add(this.txtNombre);
            this.ultraGroupBox3.Controls.Add(this.label5);
            this.ultraGroupBox3.Controls.Add(this.label3);
            this.ultraGroupBox3.Controls.Add(this.txtPeso);
            this.ultraGroupBox3.Controls.Add(this.txtCodigo);
            this.ultraGroupBox3.Controls.Add(this.label2);
            this.ultraGroupBox3.Controls.Add(this.label10);
            this.ultraGroupBox3.Controls.Add(this.txtTamaño);
            this.ultraGroupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGroupBox3.Location = new System.Drawing.Point(6, 25);
            this.ultraGroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(1092, 50);
            this.ultraGroupBox3.TabIndex = 0;
            this.ultraGroupBox3.Text = "DATOS MODELO";
            this.ultraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(720, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 14);
            this.label16.TabIndex = 52;
            this.label16.Text = "gr.";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(992, 23);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(47, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.TextChanged += new System.EventHandler(this.calculoCosto_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(926, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 14);
            this.label14.TabIndex = 50;
            this.label14.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(838, 24);
            this.txtPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(80, 20);
            this.txtPago.TabIndex = 4;
            this.txtPago.TextChanged += new System.EventHandler(this.calculoCosto_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(75, 24);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(786, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 48;
            this.label5.Text = "Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo:";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(675, 24);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(45, 20);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.TextChanged += new System.EventHandler(this.calculoCosto_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(381, 24);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 47;
            this.label2.Text = "Peso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(489, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 14);
            this.label10.TabIndex = 40;
            this.label10.Text = "Tamaño:";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamaño.Location = new System.Drawing.Point(550, 23);
            this.txtTamaño.Margin = new System.Windows.Forms.Padding(4);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(67, 20);
            this.txtTamaño.TabIndex = 2;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Location = new System.Drawing.Point(5, 594);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(528, 53);
            this.pnlBotones.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(4, 4);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 46);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(316, 4);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 46);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(212, 4);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 46);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Location = new System.Drawing.Point(108, 4);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 46);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(420, 4);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 46);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ultraTabPageControl2
            // 
            this.ultraTabPageControl2.Controls.Add(this.ultraGroupBox2);
            this.ultraTabPageControl2.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabPageControl2.Name = "ultraTabPageControl2";
            this.ultraTabPageControl2.Size = new System.Drawing.Size(1113, 660);
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            this.ultraGroupBox2.Controls.Add(this.btnBuscar);
            this.ultraGroupBox2.Controls.Add(this.txtBuscar);
            this.ultraGroupBox2.Controls.Add(this.lblBuscarCategoria);
            this.ultraGroupBox2.Controls.Add(this.dgvListaModelo);
            this.ultraGroupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.ultraGroupBox2.Location = new System.Drawing.Point(5, 4);
            this.ultraGroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(1108, 567);
            this.ultraGroupBox2.TabIndex = 0;
            this.ultraGroupBox2.Text = "BUSQUEDA";
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(560, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 31);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(157, 28);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(395, 22);
            this.txtBuscar.TabIndex = 0;
            // 
            // lblBuscarCategoria
            // 
            this.lblBuscarCategoria.AutoSize = true;
            this.lblBuscarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCategoria.Location = new System.Drawing.Point(9, 30);
            this.lblBuscarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(140, 18);
            this.lblBuscarCategoria.TabIndex = 53;
            this.lblBuscarCategoria.Text = "Buscar Producto:";
            // 
            // dgvListaModelo
            // 
            this.dgvListaModelo.AllowUserToAddRows = false;
            this.dgvListaModelo.AllowUserToDeleteRows = false;
            this.dgvListaModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaModelo.AutoGenerateColumns = false;
            this.dgvListaModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaModelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModeloDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.tamañoDataGridViewTextBoxColumn,
            this.costoTotalDataGridViewTextBoxColumn,
            this.costoUnidadDataGridViewTextBoxColumn,
            this.costounidadSRDataGridViewTextBoxColumn,
            this.precioVentaSRDataGridViewTextBoxColumn,
            this.precioVentaMayorDataGridViewTextBoxColumn,
            this.precioVentaUnidadDataGridViewTextBoxColumn,
            this.utilidadDataGridViewTextBoxColumn,
            this.pagoCosturaDataGridViewTextBoxColumn,
            this.pesoGramosDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvListaModelo.DataSource = this.tblModeloBindingSource;
            this.dgvListaModelo.Location = new System.Drawing.Point(7, 58);
            this.dgvListaModelo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaModelo.Name = "dgvListaModelo";
            this.dgvListaModelo.ReadOnly = true;
            this.dgvListaModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaModelo.Size = new System.Drawing.Size(1095, 499);
            this.dgvListaModelo.TabIndex = 2;
            this.dgvListaModelo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaModelo_CellClick);
            // 
            // idModeloDataGridViewTextBoxColumn
            // 
            this.idModeloDataGridViewTextBoxColumn.DataPropertyName = "id_Modelo";
            this.idModeloDataGridViewTextBoxColumn.HeaderText = "id_Modelo";
            this.idModeloDataGridViewTextBoxColumn.Name = "idModeloDataGridViewTextBoxColumn";
            this.idModeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idModeloDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamañoDataGridViewTextBoxColumn
            // 
            this.tamañoDataGridViewTextBoxColumn.DataPropertyName = "Tamaño";
            this.tamañoDataGridViewTextBoxColumn.HeaderText = "Tamaño";
            this.tamañoDataGridViewTextBoxColumn.Name = "tamañoDataGridViewTextBoxColumn";
            this.tamañoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoTotalDataGridViewTextBoxColumn
            // 
            this.costoTotalDataGridViewTextBoxColumn.DataPropertyName = "Costo_Total";
            this.costoTotalDataGridViewTextBoxColumn.HeaderText = "Costo_Total";
            this.costoTotalDataGridViewTextBoxColumn.Name = "costoTotalDataGridViewTextBoxColumn";
            this.costoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoUnidadDataGridViewTextBoxColumn
            // 
            this.costoUnidadDataGridViewTextBoxColumn.DataPropertyName = "Costo_Unidad";
            this.costoUnidadDataGridViewTextBoxColumn.HeaderText = "Costo_Unidad";
            this.costoUnidadDataGridViewTextBoxColumn.Name = "costoUnidadDataGridViewTextBoxColumn";
            this.costoUnidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costounidadSRDataGridViewTextBoxColumn
            // 
            this.costounidadSRDataGridViewTextBoxColumn.DataPropertyName = "Costo_unidad_SR";
            this.costounidadSRDataGridViewTextBoxColumn.HeaderText = "Costo_unidad_SR";
            this.costounidadSRDataGridViewTextBoxColumn.Name = "costounidadSRDataGridViewTextBoxColumn";
            this.costounidadSRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioVentaSRDataGridViewTextBoxColumn
            // 
            this.precioVentaSRDataGridViewTextBoxColumn.DataPropertyName = "Precio_Venta_SR";
            this.precioVentaSRDataGridViewTextBoxColumn.HeaderText = "Precio_Venta_SR";
            this.precioVentaSRDataGridViewTextBoxColumn.Name = "precioVentaSRDataGridViewTextBoxColumn";
            this.precioVentaSRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioVentaMayorDataGridViewTextBoxColumn
            // 
            this.precioVentaMayorDataGridViewTextBoxColumn.DataPropertyName = "Precio_Venta_Mayor";
            this.precioVentaMayorDataGridViewTextBoxColumn.HeaderText = "Precio_Venta_Mayor";
            this.precioVentaMayorDataGridViewTextBoxColumn.Name = "precioVentaMayorDataGridViewTextBoxColumn";
            this.precioVentaMayorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioVentaUnidadDataGridViewTextBoxColumn
            // 
            this.precioVentaUnidadDataGridViewTextBoxColumn.DataPropertyName = "Precio_Venta_Unidad";
            this.precioVentaUnidadDataGridViewTextBoxColumn.HeaderText = "Precio_Venta_Unidad";
            this.precioVentaUnidadDataGridViewTextBoxColumn.Name = "precioVentaUnidadDataGridViewTextBoxColumn";
            this.precioVentaUnidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilidadDataGridViewTextBoxColumn
            // 
            this.utilidadDataGridViewTextBoxColumn.DataPropertyName = "Utilidad";
            this.utilidadDataGridViewTextBoxColumn.HeaderText = "Utilidad";
            this.utilidadDataGridViewTextBoxColumn.Name = "utilidadDataGridViewTextBoxColumn";
            this.utilidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagoCosturaDataGridViewTextBoxColumn
            // 
            this.pagoCosturaDataGridViewTextBoxColumn.DataPropertyName = "PagoCostura";
            this.pagoCosturaDataGridViewTextBoxColumn.HeaderText = "PagoCostura";
            this.pagoCosturaDataGridViewTextBoxColumn.Name = "pagoCosturaDataGridViewTextBoxColumn";
            this.pagoCosturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoGramosDataGridViewTextBoxColumn
            // 
            this.pesoGramosDataGridViewTextBoxColumn.DataPropertyName = "PesoGramos";
            this.pesoGramosDataGridViewTextBoxColumn.HeaderText = "PesoGramos";
            this.pesoGramosDataGridViewTextBoxColumn.Name = "pesoGramosDataGridViewTextBoxColumn";
            this.pesoGramosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblModeloBindingSource
            // 
            this.tblModeloBindingSource.DataMember = "tbl_Modelo";
            this.tblModeloBindingSource.DataSource = this.dS_Modelo;
            // 
            // dS_Modelo
            // 
            this.dS_Modelo.DataSetName = "DS_Modelo";
            this.dS_Modelo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewArchivoCorteBindingSource
            // 
            this.viewArchivoCorteBindingSource.DataMember = "View_ArchivoCorte";
            this.viewArchivoCorteBindingSource.DataSource = this.dS_Modelo1;
            // 
            // tbControles
            // 
            this.tbControles.CloseButtonLocation = Infragistics.Win.UltraWinTabs.TabCloseButtonLocation.None;
            this.tbControles.Controls.Add(this.ultraTabSharedControlsPage1);
            this.tbControles.Controls.Add(this.ultraTabPageControl1);
            this.tbControles.Controls.Add(this.ultraTabPageControl2);
            this.tbControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControles.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControles.Location = new System.Drawing.Point(0, 0);
            this.tbControles.Name = "tbControles";
            this.tbControles.SharedControlsPage = this.ultraTabSharedControlsPage1;
            this.tbControles.Size = new System.Drawing.Size(1149, 664);
            this.tbControles.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003;
            this.tbControles.TabIndex = 0;
            this.tbControles.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop;
            ultraTab1.TabPage = this.ultraTabPageControl1;
            ultraTab1.Text = "MODELOS";
            ultraTab2.TabPage = this.ultraTabPageControl2;
            ultraTab2.Text = "BUSQUEDA";
            this.tbControles.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab1,
            ultraTab2});
            this.tbControles.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003;
            // 
            // ultraTabSharedControlsPage1
            // 
            this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
            this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(1113, 660);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // ofdAbrirFoto
            // 
            this.ofdAbrirFoto.FileName = "imagen";
            // 
            // ofdCorte
            // 
            this.ofdCorte.FileName = "ArchivoCorte";
            // 
            // tbl_ModeloTableAdapter
            // 
            this.tbl_ModeloTableAdapter.ClearBeforeFill = true;
            // 
            // view_ArchivoCorteTableAdapter
            // 
            this.view_ArchivoCorteTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Tipo_telaTableAdapter
            // 
            this.tbl_Tipo_telaTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Colores_TelasTableAdapter
            // 
            this.tbl_Colores_TelasTableAdapter.ClearBeforeFill = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(43, 25);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(75, 14);
            this.label32.TabIndex = 65;
            this.label32.Text = "Costo Telas:";
            // 
            // txtCostoTelas
            // 
            this.txtCostoTelas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTelas.Location = new System.Drawing.Point(120, 22);
            this.txtCostoTelas.Name = "txtCostoTelas";
            this.txtCostoTelas.Size = new System.Drawing.Size(46, 20);
            this.txtCostoTelas.TabIndex = 60;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(23, 46);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(95, 14);
            this.label33.TabIndex = 64;
            this.label33.Text = "Costo Cortador:";
            // 
            // txtCostoCorte_
            // 
            this.txtCostoCorte_.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoCorte_.Location = new System.Drawing.Point(120, 43);
            this.txtCostoCorte_.Name = "txtCostoCorte_";
            this.txtCostoCorte_.Size = new System.Drawing.Size(46, 20);
            this.txtCostoCorte_.TabIndex = 61;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(28, 67);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(90, 14);
            this.label34.TabIndex = 63;
            this.label34.Text = "Costo Costura:";
            // 
            // txtCostoCostura
            // 
            this.txtCostoCostura.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoCostura.Location = new System.Drawing.Point(120, 64);
            this.txtCostoCostura.Name = "txtCostoCostura";
            this.txtCostoCostura.Size = new System.Drawing.Size(46, 20);
            this.txtCostoCostura.TabIndex = 62;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(46, 88);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 14);
            this.label35.TabIndex = 67;
            this.label35.Text = "Costo Napa:";
            // 
            // txtCostoNapa
            // 
            this.txtCostoNapa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoNapa.Location = new System.Drawing.Point(120, 85);
            this.txtCostoNapa.Name = "txtCostoNapa";
            this.txtCostoNapa.Size = new System.Drawing.Size(46, 20);
            this.txtCostoNapa.TabIndex = 66;
            // 
            // txtCostoNapa_Und
            // 
            this.txtCostoNapa_Und.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoNapa_Und.Location = new System.Drawing.Point(172, 85);
            this.txtCostoNapa_Und.Name = "txtCostoNapa_Und";
            this.txtCostoNapa_Und.Size = new System.Drawing.Size(46, 20);
            this.txtCostoNapa_Und.TabIndex = 71;
            // 
            // txtCostoTelas_Und
            // 
            this.txtCostoTelas_Und.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTelas_Und.Location = new System.Drawing.Point(172, 22);
            this.txtCostoTelas_Und.Name = "txtCostoTelas_Und";
            this.txtCostoTelas_Und.Size = new System.Drawing.Size(46, 20);
            this.txtCostoTelas_Und.TabIndex = 68;
            // 
            // txtCostoCorte_Und
            // 
            this.txtCostoCorte_Und.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoCorte_Und.Location = new System.Drawing.Point(172, 43);
            this.txtCostoCorte_Und.Name = "txtCostoCorte_Und";
            this.txtCostoCorte_Und.Size = new System.Drawing.Size(46, 20);
            this.txtCostoCorte_Und.TabIndex = 69;
            // 
            // txtCostoCostura_Und
            // 
            this.txtCostoCostura_Und.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoCostura_Und.Location = new System.Drawing.Point(172, 64);
            this.txtCostoCostura_Und.Name = "txtCostoCostura_Und";
            this.txtCostoCostura_Und.Size = new System.Drawing.Size(46, 20);
            this.txtCostoCostura_Und.TabIndex = 70;
            // 
            // cmsMenuCorte
            // 
            this.cmsMenuCorte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cmsMenuCorte.Name = "cmsMenuCorte";
            this.cmsMenuCorte.Size = new System.Drawing.Size(126, 48);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 664);
            this.Controls.Add(this.tbControles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ultraTabPageControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxArchivosCorte)).EndInit();
            this.gbxArchivosCorte.ResumeLayout(false);
            this.gbxArchivosCorte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipotelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Modelo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblColoresTelasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox4)).EndInit();
            this.ultraGroupBox4.ResumeLayout(false);
            this.ultraGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivosCorte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxCostos)).EndInit();
            this.gbxCostos.ResumeLayout(false);
            this.gbxCostos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox5)).EndInit();
            this.ultraGroupBox5.ResumeLayout(false);
            this.ultraGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            this.ultraGroupBox3.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ultraTabPageControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ultraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblModeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArchivoCorteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbControles)).EndInit();
            this.tbControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.cmsMenuCorte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinTabControl.UltraTabControl tbControles;
        private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnAbrirFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl2;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscarCategoria;
        private System.Windows.Forms.DataGridView dgvListaModelo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox4;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvArchivosCorte;
        private System.Windows.Forms.Button btnNuevoCorte;
        private System.Windows.Forms.ErrorProvider erpError;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox5;
        private Infragistics.Win.Misc.UltraGroupBox gbxCostos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCostoUnidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCostoSR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPVUnidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPVMayor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPVSR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUtilidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
        private DAL.DS_Modelo dS_Modelo;
        private System.Windows.Forms.BindingSource tblModeloBindingSource;
        private DAL.DS_ModeloTableAdapters.tbl_ModeloTableAdapter tbl_ModeloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamañoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costounidadSRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaSRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaMayorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoCosturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoGramosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVentaTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog ofdAbrirFoto;
        private Infragistics.Win.Misc.UltraGroupBox gbxArchivosCorte;
        private System.Windows.Forms.TextBox txtPotenciaArchivo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtVelocidadArchivo;
        private System.Windows.Forms.TextBox txtCorteNombre;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCantidadArchivo;
        private System.Windows.Forms.TextBox txtCodigoArchivo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtTamañoArchivo;
        private System.Windows.Forms.OpenFileDialog ofdCorte;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxTelaArchivo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbxColorArchivo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnSelectArchivoCorte;
        private System.Windows.Forms.TextBox txtArchivoCorte;
        private System.Windows.Forms.Button btnCerrarArchivosCorte;
        private System.Windows.Forms.Button btnAceptarArchivosCorte;
        private DAL.DS_Modelo dS_Modelo1;
        private System.Windows.Forms.BindingSource viewArchivoCorteBindingSource;
        private DAL.DS_ModeloTableAdapters.View_ArchivoCorteTableAdapter view_ArchivoCorteTableAdapter;
        private System.Windows.Forms.BindingSource tblTipotelaBindingSource;
        private DAL.DS_ModeloTableAdapters.tbl_Tipo_telaTableAdapter tbl_Tipo_telaTableAdapter;
        private System.Windows.Forms.BindingSource tblColoresTelasBindingSource;
        private DAL.DS_ModeloTableAdapters.tbl_Colores_TelasTableAdapter tbl_Colores_TelasTableAdapter;
        private System.Windows.Forms.Label lblCodigoColor;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbxTipoCorte;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArchivoCorteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModeloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreModeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArchivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamañoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCorteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColorTelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoTelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtCostoTela;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtCostoCorte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtCostoTelas;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtCostoCorte_;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtCostoCostura;
        private System.Windows.Forms.TextBox txtCostoNapa_Und;
        private System.Windows.Forms.TextBox txtCostoTelas_Und;
        private System.Windows.Forms.TextBox txtCostoCorte_Und;
        private System.Windows.Forms.TextBox txtCostoCostura_Und;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtCostoNapa;
        private System.Windows.Forms.ContextMenuStrip cmsMenuCorte;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}

