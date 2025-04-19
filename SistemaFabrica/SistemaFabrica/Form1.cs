using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SistemaFabrica.DAL;


namespace SistemaFabrica
{
    public partial class Form1 : Form
    {
      

        int idModelo = 0;
        int idImagen = 0;
       
        string accion = "nada";
        string codigo;
        Image foto;
        double precioKiloNapa = 10;
        double costoOperarioCorte = 3.125;


        bool cargar = false;
        DS_Modelo.tbl_ModeloDataTable modeloDT = new DS_Modelo.tbl_ModeloDataTable();
        DAL.DS_ModeloTableAdapters.tbl_ModeloTableAdapter modeloTA = new DAL.DS_ModeloTableAdapters.tbl_ModeloTableAdapter();

        DS_Modelo.tbl_Imagen_ModeloDataTable ImagenModeloDT = new DS_Modelo.tbl_Imagen_ModeloDataTable();
        DAL.DS_ModeloTableAdapters.tbl_Imagen_ModeloTableAdapter ImagenModeloTA = new DAL.DS_ModeloTableAdapters.tbl_Imagen_ModeloTableAdapter();

        DS_Modelo.tbl_Archivo_CorteDataTable tblArchivoCorteDT = new DS_Modelo.tbl_Archivo_CorteDataTable();
        DAL.DS_ModeloTableAdapters.tbl_Archivo_CorteTableAdapter tblArchivoCorteTA = new DAL.DS_ModeloTableAdapters.tbl_Archivo_CorteTableAdapter();

        DS_Modelo.View_ArchivoCorteDataTable ArchivosCorteDT = new DS_Modelo.View_ArchivoCorteDataTable();
        DAL.DS_ModeloTableAdapters.View_ArchivoCorteTableAdapter ArchivosCorteTA = new DAL.DS_ModeloTableAdapters.View_ArchivoCorteTableAdapter();

        DS_Modelo.tbl_Colores_TelasDataTable ColoresTelasDT = new DS_Modelo.tbl_Colores_TelasDataTable();
        DAL.DS_ModeloTableAdapters.tbl_Colores_TelasTableAdapter ColoresTelasTA = new DAL.DS_ModeloTableAdapters.tbl_Colores_TelasTableAdapter();

        DS_Modelo.tbl_Tipo_telaDataTable telaDT = new DS_Modelo.tbl_Tipo_telaDataTable();
        DAL.DS_ModeloTableAdapters.tbl_Tipo_telaTableAdapter telaTA = new DAL.DS_ModeloTableAdapters.tbl_Tipo_telaTableAdapter();
         
        public void bloquear()
        {
            txtNombre.Enabled = false;
            txtCodigo.Enabled = false;
            txtTamaño.Enabled = false;
            txtPeso.Enabled = false;
            txtPago.Enabled = false;
            txtCostoSR.Enabled = false;
            txtCostoTotal.Enabled = false;
            txtCostoUnidad.Enabled = false;
            txtPVMayor.Enabled = false;
            txtPVSR.Enabled = false;
            txtPVUnidad.Enabled = false;
            txtUtilidad.Enabled = false;
            txtCantidad.Enabled = false;
            txtVentaTotal.Enabled = false;
        }
        public void desbloquear()
        {
            txtNombre.Enabled = true;
            txtCodigo.Enabled = true;
            txtTamaño.Enabled = true;
            txtPeso.Enabled = true;
            txtPago.Enabled = true;
            txtCostoSR.Enabled = true;
            txtCostoTotal.Enabled = true;
            txtCostoUnidad.Enabled = true;
            txtPVMayor.Enabled = true;
            txtPVSR.Enabled = true;
            txtPVUnidad.Enabled = true;
            txtUtilidad.Enabled = true;
            txtCantidad.Enabled = true;
            txtVentaTotal.Enabled = true;
        }

        public void nuevo()
        {
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnNuevo.Visible = false;
            btnAceptar.Location = new Point(125, 4);
            btnCancelar.Location = new Point(228, 4);
        }

        public void modificar()
        {
            btnModificar.Visible = true;
            btnCancelar.Visible = true;
            btnEliminar.Visible = true;
            btnNuevo.Visible = false;
            btnAceptar.Visible = false;
            btnModificar.Location = new Point(125, 4);
            btnCancelar.Location = new Point(228, 4);
            btnEliminar.Location = new Point(331, 4);
        }

        public void reiniciar()
        {
            btnAceptar.Visible = false;
            btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnNuevo.Visible = true;
            btnNuevo.Location = new Point(125, 4);
            btnCancelar.Location = new Point(228, 4);
            limpiar();
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";
            codigo = "";
            txtTamaño.Text = "0";
            txtPeso.Text = "0.000";
            txtPago.Text = "0.00";
            txtCostoSR.Text = "0.00";
            txtCostoTotal.Text = "0.00";
            txtCostoUnidad.Text = "0.00";
            txtPVMayor.Text = "0.00";
            txtPVSR.Text = "0.00";
            txtPVUnidad.Text = "0.00";
            txtUtilidad.Text = "0.00";
            txtCantidad.Text = "0";
            txtImagen.Text = "";
            txtVentaTotal.Text = "0.00";
            pbxImagen.Image = null;
            txtCostoTela.Text = "0.00";
            txtCostoCorte.Text = "0.00";

            txtCostoCostura.Text = "0.00";
            txtCostoCostura_Und.Text = "0.00";
            txtCostoCorte_.Text = "0.00";
            txtCostoCorte_Und.Text = "0.00";
            txtCostoTelas.Text = "0.00";
            txtCostoTelas_Und.Text = "0.00";
            txtCostoNapa.Text = "0.00";
            txtCostoNapa_Und.Text = "0.00";



            dgvArchivosCorte.Rows.Clear();

            //codigo para las tablas
            // TODO: esta línea de código carga datos en la tabla 'dS_Modelo.tbl_Modelo' Puede moverla o quitarla según sea necesario.
            this.tbl_ModeloTableAdapter.Fill(this.dS_Modelo.tbl_Modelo);

        }

        public void limpiarArchivosCorte()
        {
            txtCorteNombre.Text = "";
            txtCodigoArchivo.Text = "";
            txtVelocidadArchivo.Text = "60";
            txtPotenciaArchivo.Text = "45";
            txtTamañoArchivo.Text = "";
            txtCantidadArchivo.Text = "";
            cbxTipoCorte.Text = "";
            cbxTelaArchivo.Text = "";
            cbxColorArchivo.Text = "";
            txtArchivoCorte.Text = "";
        }

        private bool Validar()
        {
            if (txtNombre.Text != "")
            {
                erpError.Clear();
                return true;
            }
            else
            {
                erpError.SetError(txtNombre, "DEBE INGRESAR UN NOMBRE");
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Modelo1.tbl_Colores_Telas' Puede moverla o quitarla según sea necesario.
            this.tbl_Colores_TelasTableAdapter.Fill(this.dS_Modelo1.tbl_Colores_Telas);
            // TODO: esta línea de código carga datos en la tabla 'dS_Modelo1.tbl_Tipo_tela' Puede moverla o quitarla según sea necesario.
            this.tbl_Tipo_telaTableAdapter.Fill(this.dS_Modelo1.tbl_Tipo_tela);
            
            Control.CheckForIllegalCrossThreadCalls = false;


            // TODO: esta línea de código carga datos en la tabla 'dS_Modelo.tbl_Modelo' Puede moverla o quitarla según sea necesario.
            this.tbl_ModeloTableAdapter.Fill(this.dS_Modelo.tbl_Modelo);

            bloquear();
            reiniciar();


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            desbloquear();
            nuevo();
            limpiar();
            accion = "nuevo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (accion == "nada")
            {
                this.Close();

            }
            else if (accion == "Modificar")
            {
                limpiar();
                bloquear();
                reiniciar();
                accion = "nada";
            }
            else if (accion == "nuevo")
            {
                limpiar();
                bloquear();
                reiniciar();
                accion = "nada";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                idModelo = decimal.ToInt32((decimal)modeloTA.InsertQuery(txtNombre.Text, txtCodigo.Text.ToUpper(), int.Parse(txtTamaño.Text),
                    double.Parse(txtCostoTotal.Text), double.Parse(txtCostoUnidad.Text), double.Parse(txtCostoSR.Text),
                    double.Parse(txtPVSR.Text), double.Parse(txtPVMayor.Text), double.Parse(txtPVUnidad.Text), double.Parse(txtUtilidad.Text),
                    double.Parse(txtPago.Text), double.Parse(txtPeso.Text), int.Parse(txtCantidad.Text), "ACTIVO"));

                tblArchivoCorteTA.DeleteQueryIdModelo(idModelo);
                for (int i = 0; i < dgvArchivosCorte.RowCount; i++)
                {
                    int idArchivo = int.Parse(dgvArchivosCorte.Rows[i].Cells["idArchivoCorteDataGridViewTextBoxColumn"].Value.ToString());
                    string NombreModelo = dgvArchivosCorte.Rows[i].Cells["nombreModeloDataGridViewTextBoxColumn"].Value.ToString();
                    string NombreArchivo = dgvArchivosCorte.Rows[i].Cells["nombreArchivoDataGridViewTextBoxColumn"].Value.ToString();
                    string codigo = dgvArchivosCorte.Rows[i].Cells["codigoDataGridViewTextBoxColumn1"].Value.ToString();
                    string tamaño = dgvArchivosCorte.Rows[i].Cells["tamañoDataGridViewTextBoxColumn1"].Value.ToString();
                    double cantidad = double.Parse(dgvArchivosCorte.Rows[i].Cells["cantidadDataGridViewTextBoxColumn1"].Value.ToString());
                    string tipoCorte = dgvArchivosCorte.Rows[i].Cells["tipoCorteDataGridViewTextBoxColumn1"].Value.ToString();
                    double velocidad = double.Parse(dgvArchivosCorte.Rows[i].Cells["velocidadDataGridViewTextBoxColumn"].Value.ToString());
                    double potencia = double.Parse(dgvArchivosCorte.Rows[i].Cells["potenciaDataGridViewTextBoxColumn"].Value.ToString());
                    int idColor = int.Parse(dgvArchivosCorte.Rows[i].Cells["idColorDataGridViewTextBoxColumn"].Value.ToString());
                    string nombreColor = dgvArchivosCorte.Rows[i].Cells["nombreColorTelaDataGridViewTextBoxColumn"].Value.ToString();
                    string codigoTela = dgvArchivosCorte.Rows[i].Cells["codigoTelaDataGridViewTextBoxColumn"].Value.ToString();
                    int idTipoTela = int.Parse(dgvArchivosCorte.Rows[i].Cells["idTipoTelaDataGridViewTextBoxColumn"].Value.ToString());
                    string NombreTela = dgvArchivosCorte.Rows[i].Cells["nombreTelaDataGridViewTextBoxColumn"].Value.ToString();
                    string ruta = dgvArchivosCorte.Rows[i].Cells["rutaDataGridViewTextBoxColumn"].Value.ToString();

                    tblArchivoCorteTA.InsertQuery(idModelo, NombreArchivo, codigo, tamaño, cantidad,tipoCorte, velocidad, potencia, idColor, idTipoTela, ruta, "ACTIVO");

                }
                try
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ImagenModeloTA.InsertQuery(txtImagen.Text, ms.GetBuffer(), "IMAGEN", idModelo);

                }
                catch (Exception)
                {

                }

                MessageBox.Show("Los datos fueron insertados correctamete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                limpiar();
                bloquear();
                reiniciar();
                accion = "nada";

            }
            else
            {
                MessageBox.Show("Los datos NO fueron insertados correctamete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                modeloTA.DeleteQuery(idModelo);
                MessageBox.Show("Se elimino correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                limpiar();
                bloquear();
                reiniciar();
                accion = "nada";
            }

            catch (Exception)
            {

                MessageBox.Show("Ocurrió un error al eliminar el registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    modeloTA.UpdateQuery(txtNombre.Text, txtCodigo.Text.ToUpper(), int.Parse(txtTamaño.Text),
                    double.Parse(txtCostoTotal.Text), double.Parse(txtCostoUnidad.Text), double.Parse(txtCostoSR.Text),
                    double.Parse(txtPVSR.Text), double.Parse(txtPVMayor.Text), double.Parse(txtPVUnidad.Text), double.Parse(txtUtilidad.Text),
                    double.Parse(txtPago.Text), double.Parse(txtPeso.Text), int.Parse(txtCantidad.Text), "ACTIVO", idModelo);


                    tblArchivoCorteTA.DeleteQueryIdModelo(idModelo);
                    for (int i = 0; i < dgvArchivosCorte.RowCount; i++)
                    {
                        int idArchivo = int.Parse(dgvArchivosCorte.Rows[i].Cells["idArchivoCorteDataGridViewTextBoxColumn"].Value.ToString());
                        string NombreModelo = dgvArchivosCorte.Rows[i].Cells["nombreModeloDataGridViewTextBoxColumn"].Value.ToString();
                        string NombreArchivo = dgvArchivosCorte.Rows[i].Cells["nombreArchivoDataGridViewTextBoxColumn"].Value.ToString();
                        string codigo = dgvArchivosCorte.Rows[i].Cells["codigoDataGridViewTextBoxColumn1"].Value.ToString();
                        string tamaño = dgvArchivosCorte.Rows[i].Cells["tamañoDataGridViewTextBoxColumn1"].Value.ToString();
                        double cantidad = double.Parse(dgvArchivosCorte.Rows[i].Cells["cantidadDataGridViewTextBoxColumn1"].Value.ToString());
                        string tipoCorte = dgvArchivosCorte.Rows[i].Cells["tipoCorteDataGridViewTextBoxColumn1"].Value.ToString();
                        double velocidad = double.Parse(dgvArchivosCorte.Rows[i].Cells["velocidadDataGridViewTextBoxColumn"].Value.ToString());
                        double potencia = double.Parse(dgvArchivosCorte.Rows[i].Cells["potenciaDataGridViewTextBoxColumn"].Value.ToString());
                        int idColor = int.Parse(dgvArchivosCorte.Rows[i].Cells["idColorDataGridViewTextBoxColumn"].Value.ToString());
                        string nombreColor = dgvArchivosCorte.Rows[i].Cells["nombreColorTelaDataGridViewTextBoxColumn"].Value.ToString();
                        string codigoTela = dgvArchivosCorte.Rows[i].Cells["codigoTelaDataGridViewTextBoxColumn"].Value.ToString();
                        int idTipoTela = int.Parse(dgvArchivosCorte.Rows[i].Cells["idTipoTelaDataGridViewTextBoxColumn"].Value.ToString());
                        string NombreTela = dgvArchivosCorte.Rows[i].Cells["nombreTelaDataGridViewTextBoxColumn"].Value.ToString();
                        string ruta = dgvArchivosCorte.Rows[i].Cells["rutaDataGridViewTextBoxColumn"].Value.ToString();

                        tblArchivoCorteTA.InsertQuery(idModelo, NombreArchivo, codigo, tamaño, cantidad, tipoCorte, velocidad, potencia, idColor, idTipoTela, ruta, "ACTIVO");

                    }


                    try
                    {
                        if (idImagen != 0)
                        {
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            // Se guarda la imagen en el buffer
                            foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            ImagenModeloTA.InsertQuery(txtImagen.Text, ms.GetBuffer(), "IMAGEN", idModelo);
                        }
                        else
                        {
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            // Se guarda la imagen en el buffer
                            foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            ImagenModeloTA.InsertQuery(txtImagen.Text, ms.GetBuffer(), "IMAGEN", idModelo);
                        }


                    }
                    catch (Exception)
                    {

                    }

                    MessageBox.Show("El producto se modificó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    limpiar();
                    bloquear();
                    reiniciar();
                    accion = "nada";

                }
                else
                {
                    MessageBox.Show("Debe llenar el campo obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrrió un Error al Modificar producto", "Mensaje");

            }
        }

        public void CalculoCostos()
        {
            int cantidad;
            double pagoCostura;
            double pesoRelleno;
            double costoRelleno;
            double costoUnidad;
            double costoTotal;
            double costoUnidadSinRelleno;
            double precioUnidad;
            double precioUnidadSinRelleno;
            double precioMayor;
            double VentaTotal;
            double Utilidad;

            double costoMateriales;
            double costoManoObra;

            try
            {
                cantidad = int.Parse(txtCantidad.Text);
                pagoCostura = double.Parse(txtPago.Text);
                pesoRelleno = double.Parse(txtPeso.Text);
                costoMateriales = double.Parse(txtCostoTela.Text);
                costoManoObra = double.Parse(txtCostoCorte.Text);

                if (pesoRelleno != 0)
                {
                    costoRelleno = (pesoRelleno / 1000) * precioKiloNapa;
                }
                else
                {
                    costoRelleno = 0;
                }
                
                costoTotal = (pagoCostura * cantidad)+(costoRelleno*cantidad)+ costoMateriales+ costoManoObra;

                costoUnidad = pagoCostura + costoRelleno + (costoMateriales/cantidad) + (costoManoObra/cantidad);
                costoUnidadSinRelleno = costoUnidad - costoRelleno;

                txtCostoCostura.Text = (pagoCostura * cantidad).ToString();
                txtCostoCostura_Und.Text = pagoCostura.ToString();
                txtCostoCorte_.Text = costoManoObra.ToString();
                txtCostoCorte_Und.Text = (costoManoObra/cantidad).ToString();
                txtCostoTelas.Text = costoMateriales.ToString();
                txtCostoTelas_Und.Text = (costoMateriales/cantidad).ToString();
                txtCostoNapa.Text = (costoRelleno * cantidad).ToString();
                txtCostoNapa_Und.Text = costoRelleno.ToString();

                txtCostoTotal.Text = costoTotal.ToString();
                txtCostoUnidad.Text = costoUnidad.ToString();
                txtCostoSR.Text = costoUnidadSinRelleno.ToString();
               
               


                if (double.Parse(txtPVUnidad.Text) == 0)
                {
                    precioUnidad = costoUnidad * 1.60;
                }
                else
                {
                    precioUnidad = double.Parse(txtPVUnidad.Text);
                }

                if (double.Parse(txtPVSR.Text) == 0)
                {
                    precioUnidadSinRelleno = precioUnidad - costoRelleno;
                }
                else
                {
                    precioUnidadSinRelleno = double.Parse(txtPVSR.Text);
                }

                if (double.Parse(txtPVMayor.Text) == 0)
                {
                    precioMayor = costoUnidad * 1.9;
                }
                else
                {
                    precioMayor = double.Parse(txtPVMayor.Text);
                }

                VentaTotal = precioMayor * cantidad;
                Utilidad = VentaTotal - costoTotal;

                
                txtPVMayor.Text = precioMayor.ToString();
                txtPVSR.Text = precioUnidadSinRelleno.ToString();
                txtPVUnidad.Text = precioUnidad.ToString();
                txtUtilidad.Text = Utilidad.ToString();
                txtVentaTotal.Text = VentaTotal.ToString();

                Dibujar_pastel(Utilidad, costoTotal);
            }
            catch (Exception)
            {

            }
        }

        private void Dibujar_pastel(double utilidad, double costo)
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("Utilidad");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Right;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "Utilidad";
            chart1.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "UtilidadSeries";
            chart1.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
            
            //Add some datapoints so the series. in this case you can pass the values to this method
            chart1.Series[seriesname].Points.AddXY("Utilidad", utilidad);
            chart1.Series[seriesname].Points.AddXY("Costo", costo);
            
        }

        private void calculoCosto_TextChanged(object sender, EventArgs e)
        {
            if (!cargar)
            {
                CalculoCostos();
            }

        }

        private void dgvListaModelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cargar = true;

                idModelo = int.Parse(dgvListaModelo.SelectedRows[0].Cells["idModeloDataGridViewTextBoxColumn"].Value.ToString());

                modeloDT = modeloTA.GetDataByIdModelo(idModelo);

                foreach (DS_Modelo.tbl_ModeloRow item in modeloDT)
                {
                    idModelo = item.id_Modelo;
                    txtNombre.Text = item.Nombre;
                    txtCodigo.Text = item.Codigo;
                    txtTamaño.Text = item.Tamaño.ToString();
                    txtPeso.Text = item.PesoGramos.ToString();
                    txtPago.Text = item.PagoCostura.ToString();

                    txtCostoSR.Text = item.Costo_unidad_SR.ToString();
                    txtCostoTotal.Text = item.Costo_Total.ToString();
                    txtCostoUnidad.Text = item.Costo_Unidad.ToString();
                    txtPVMayor.Text = item.Precio_Venta_Mayor.ToString();
                    txtPVSR.Text = item.Precio_Venta_SR.ToString();
                    txtPVUnidad.Text = item.Precio_Venta_Unidad.ToString();
                    txtUtilidad.Text = item.Utilidad.ToString();
                    txtCantidad.Text = item.Cantidad.ToString();
                    txtVentaTotal.Text = (item.Cantidad * item.Precio_Venta_Mayor).ToString();


                    Thread hiloImagen = new Thread(MetodoHiloImagen);
                    hiloImagen.Start();

                }

                ArchivosCorteDT = ArchivosCorteTA.GetDataById_Modelo(idModelo);
                foreach (var item in ArchivosCorteDT)
                {
                    dgvArchivosCorte.Rows.Add(item.id_Archivo_Corte, item.id_Modelo, item.NombreModelo, item.NombreArchivo,
                        item.Codigo, item.Tamaño, item.Cantidad, item.TipoCorte, item.Velocidad, item.Potencia, item.Id_Color, item.NombreColorTela,
                        item.CodigoTela, item.Id_Tipo_Tela, item.NombreTela, item.Ruta, item.Estado);

                    double precioTela = 0;
                    telaDT = telaTA.GetDataByIdTela(item.Id_Tipo_Tela);
                    foreach (var itemTela in telaDT)
                    {
                        precioTela = itemTela.Precio;
                    }

                    calcular_costos_tela(precioTela,double.Parse(item.Tamaño), item.Cantidad, item.TipoCorte);


                }


                // TODO: esta línea de código carga datos en la tabla 'dS_Modelo1.View_ArchivoCorte' Puede moverla o quitarla según sea necesario.
                this.view_ArchivoCorteTableAdapter.FillById_Modelo(this.dS_Modelo1.View_ArchivoCorte, idModelo);


                tbControles.SelectedTab = tbControles.Tabs[0];

                

                desbloquear();
                modificar();
                accion = "Modificar";
                cargar = false;
                CalculoCostos();
            }
            catch (Exception)
            {

            }
        }
        
        public void MetodoHiloImagen()
        {
            try
            {
                ImagenModeloDT = ImagenModeloTA.GetDataByid_Modelo(idModelo);
                if (ImagenModeloDT.Count > 0)
                {
                    byte[] imageBuffer = ImagenModeloDT[0].Imagen;
                    // Se crea un MemoryStream a partir de ese buffer
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                    // Se utiliza el MemoryStream para extraer la imagen
                    foto = Image.FromStream(ms);
                    pbxImagen.Image = foto;
                    txtImagen.Text = ImagenModeloDT[0].Ruta;
                }
                else
                {
                    txtImagen.Text = "";
                    pbxImagen.Image = null;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAbrirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAbrirFoto.Filter = "Archivos de Imagen (*.jpg)|*.jpg|Archivos de Imagen (*.png)|*.png|Archivos de Imagen (*.bmp)|*.bmp";
                if (ofdAbrirFoto.ShowDialog() == DialogResult.OK)
                {
                    txtImagen.Text = ofdAbrirFoto.FileName;
                    foto = Image.FromFile(ofdAbrirFoto.FileName);


                    int tamaño = foto.Size.Height * foto.Size.Width;

                    if (tamaño > 16000000)
                    {
                        MessageBox.Show("El tamaño del archivo no debe ser superior a 1.5Mb", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        foto = null;
                    }
                    else
                    {
                        pbxImagen.Image = Image.FromFile(ofdAbrirFoto.FileName);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void btnNuevoCorte_Click(object sender, EventArgs e)
        {
            limpiarArchivosCorte();
            gbxArchivosCorte.Visible = true;
            txtCorteNombre.Focus();
        }

        private void btnCerrarArchivosCorte_Click(object sender, EventArgs e)
        {
            gbxArchivosCorte.Visible = false;
        }

        public void calcular_costos_tela(double precioTela,double tamaño, double cantidad, string tipo)
        {
            try
            {
                double metraje = tamaño/100;
                double cortes = 0;
                cortes = cantidad * costoOperarioCorte;

                if (tipo == "Tandada")
                {
                    metraje = metraje * cantidad * 2;                    
                }
                else
                {
                    metraje = metraje * cantidad;
                }
                double costo = precioTela * metraje;
                txtCostoTela.Text = (double.Parse(txtCostoTela.Text) + costo).ToString();
               
                txtCostoCorte.Text = (double.Parse(txtCostoCorte.Text) + cortes).ToString();
               
            }
            catch (Exception)
            {
            }
       }


        private void btnAceptarArchivosCorte_Click(object sender, EventArgs e)
        {
            try
            {
                dgvArchivosCorte.Rows.Add("000", idModelo, txtNombre.Text, txtCorteNombre.Text,
                        txtCodigoArchivo.Text, txtTamañoArchivo.Text, txtCantidadArchivo.Text, cbxTipoCorte.Text, txtVelocidadArchivo.Text,
                        txtPotenciaArchivo.Text, cbxColorArchivo.SelectedValue, cbxColorArchivo.Text,
                        lblCodigoColor.Text, cbxTelaArchivo.SelectedValue, cbxTelaArchivo.Text, txtArchivoCorte.Text, 
                        "ACTIVO");

                double precioTela = 0;
                telaDT = telaTA.GetDataByIdTela(int.Parse(cbxTelaArchivo.SelectedValue.ToString()));
                foreach (var item in telaDT)
                {
                    precioTela = item.Precio;
                }

                calcular_costos_tela(precioTela, double.Parse(txtTamañoArchivo.Text), double.Parse(txtCantidadArchivo.Text), cbxTipoCorte.Text);

                limpiarArchivosCorte();
                gbxArchivosCorte.Visible = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSelectArchivoCorte_Click(object sender, EventArgs e)
        {
            try
            {
                ofdCorte.Filter = "Archivos de Corte (*.rld)|*.rld|Archivos de Corte (*.*)|*.*";
                if (ofdCorte.ShowDialog() == DialogResult.OK)
                {
                    txtArchivoCorte.Text = ofdCorte.FileName;
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbxColorArchivo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ColoresTelasDT = ColoresTelasTA.GetDataById_Color(int.Parse(cbxColorArchivo.SelectedValue.ToString()));
                foreach (var item in ColoresTelasDT)
                {
                    lblCodigoColor.Text = item.Codigo;
                }
            }
            catch (Exception )
            {

            }
        }

        private void cbxTelaArchivo_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
