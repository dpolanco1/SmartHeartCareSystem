namespace aPresentationLayer
{
    partial class Frm_Recetario
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.btnEnviar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.tabPrincipalRecetario = new DevExpress.XtraTab.XtraTabControl();
            this.tbpRecetario = new DevExpress.XtraTab.XtraTabPage();
            this.tbpListaRecetarios = new DevExpress.XtraTab.XtraTabPage();
            this.grpReceta = new DevExpress.XtraEditors.GroupControl();
            this.memoeditIndicacion = new DevExpress.XtraEditors.MemoEdit();
            this.lblIndicación = new DevExpress.XtraEditors.LabelControl();
            this.grpDatos = new DevExpress.XtraEditors.GroupControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.lblDireccion = new DevExpress.XtraEditors.LabelControl();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.txtEdad = new DevExpress.XtraEditors.TextEdit();
            this.lblEdad = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblBuscar = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.lblApellidos = new DevExpress.XtraEditors.LabelControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.dateFecha = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPrincipalRecetario)).BeginInit();
            this.tabPrincipalRecetario.SuspendLayout();
            this.tbpRecetario.SuspendLayout();
            this.tbpListaRecetarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpReceta)).BeginInit();
            this.grpReceta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoeditIndicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDatos)).BeginInit();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEditar,
            this.btnCancelar,
            this.btnImprimir,
            this.btnEnviar,
            this.btnEliminar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGuardar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEnviar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminar)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "&Nuevo";
            this.btnNuevo.Glyph = global::aPresentationLayer.Properties.Resources.add;
            this.btnNuevo.Id = 0;
            this.btnNuevo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(794, 69);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Size = new System.Drawing.Size(794, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 69);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 472);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(794, 69);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 472);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "&Guardar";
            this.btnGuardar.Glyph = global::aPresentationLayer.Properties.Resources.save;
            this.btnGuardar.Id = 1;
            this.btnGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "&Editar";
            this.btnEditar.Glyph = global::aPresentationLayer.Properties.Resources.Edit;
            this.btnEditar.Id = 2;
            this.btnEditar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Caption = "&Cancelar";
            this.btnCancelar.Glyph = global::aPresentationLayer.Properties.Resources.Cancel;
            this.btnCancelar.Id = 3;
            this.btnCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "&Imprimir";
            this.btnImprimir.Glyph = global::aPresentationLayer.Properties.Resources.Imprimir;
            this.btnImprimir.Id = 4;
            this.btnImprimir.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Caption = "&Enviar";
            this.btnEnviar.Glyph = global::aPresentationLayer.Properties.Resources.send;
            this.btnEnviar.Id = 5;
            this.btnEnviar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "&Eliminar";
            this.btnEliminar.Glyph = global::aPresentationLayer.Properties.Resources.Delete;
            this.btnEliminar.Id = 6;
            this.btnEliminar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // tabPrincipalRecetario
            // 
            this.tabPrincipalRecetario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipalRecetario.Location = new System.Drawing.Point(0, 69);
            this.tabPrincipalRecetario.Name = "tabPrincipalRecetario";
            this.tabPrincipalRecetario.SelectedTabPage = this.tbpRecetario;
            this.tabPrincipalRecetario.Size = new System.Drawing.Size(794, 472);
            this.tabPrincipalRecetario.TabIndex = 4;
            this.tabPrincipalRecetario.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbpRecetario,
            this.tbpListaRecetarios});
            // 
            // tbpRecetario
            // 
            this.tbpRecetario.Controls.Add(this.grpReceta);
            this.tbpRecetario.Controls.Add(this.grpDatos);
            this.tbpRecetario.Name = "tbpRecetario";
            this.tbpRecetario.Size = new System.Drawing.Size(788, 446);
            this.tbpRecetario.Text = "Recetario Médico";
            // 
            // tbpListaRecetarios
            // 
            this.tbpListaRecetarios.Controls.Add(this.gridControl1);
            this.tbpListaRecetarios.Name = "tbpListaRecetarios";
            this.tbpListaRecetarios.Size = new System.Drawing.Size(788, 446);
            this.tbpListaRecetarios.Text = "Lista de Recetarios";
            // 
            // grpReceta
            // 
            this.grpReceta.Controls.Add(this.memoeditIndicacion);
            this.grpReceta.Controls.Add(this.lblIndicación);
            this.grpReceta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReceta.Location = new System.Drawing.Point(0, 190);
            this.grpReceta.Name = "grpReceta";
            this.grpReceta.Size = new System.Drawing.Size(788, 256);
            this.grpReceta.TabIndex = 3;
            this.grpReceta.Text = "Datos de la Receta:";
            // 
            // memoeditIndicacion
            // 
            this.memoeditIndicacion.Location = new System.Drawing.Point(11, 57);
            this.memoeditIndicacion.Name = "memoeditIndicacion";
            this.memoeditIndicacion.Size = new System.Drawing.Size(741, 189);
            this.memoeditIndicacion.TabIndex = 54;
            // 
            // lblIndicación
            // 
            this.lblIndicación.Location = new System.Drawing.Point(11, 38);
            this.lblIndicación.Name = "lblIndicación";
            this.lblIndicación.Size = new System.Drawing.Size(52, 13);
            this.lblIndicación.TabIndex = 53;
            this.lblIndicación.Text = "Indicación:";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.memoEdit1);
            this.grpDatos.Controls.Add(this.lblDireccion);
            this.grpDatos.Controls.Add(this.lblFecha);
            this.grpDatos.Controls.Add(this.txtEdad);
            this.grpDatos.Controls.Add(this.lblEdad);
            this.grpDatos.Controls.Add(this.searchLookUpEdit1);
            this.grpDatos.Controls.Add(this.lblBuscar);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtApellidos);
            this.grpDatos.Controls.Add(this.lblApellidos);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.dateFecha);
            this.grpDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDatos.Location = new System.Drawing.Point(0, 0);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(788, 190);
            this.grpDatos.TabIndex = 2;
            this.grpDatos.Text = "Datos del Paciente:";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(11, 132);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(741, 42);
            this.memoEdit1.TabIndex = 53;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(11, 113);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(47, 13);
            this.lblDireccion.TabIndex = 52;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(548, 36);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 50;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(548, 87);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(87, 20);
            this.txtEdad.TabIndex = 49;
            // 
            // lblEdad
            // 
            this.lblEdad.Location = new System.Drawing.Point(548, 68);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(28, 13);
            this.lblEdad.TabIndex = 48;
            this.lblEdad.Text = "Edad:";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(53, 33);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(360, 20);
            this.searchLookUpEdit1.TabIndex = 47;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Location = new System.Drawing.Point(11, 36);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(36, 13);
            this.lblBuscar.TabIndex = 46;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(11, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 20);
            this.txtNombre.TabIndex = 45;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(274, 87);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(254, 20);
            this.txtApellidos.TabIndex = 7;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Location = new System.Drawing.Point(274, 68);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(46, 13);
            this.lblApellidos.TabIndex = 6;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(11, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres:";
            // 
            // dateFecha
            // 
            this.dateFecha.EditValue = null;
            this.dateFecha.Location = new System.Drawing.Point(582, 33);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFecha.Properties.Mask.EditMask = "";
            this.dateFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dateFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateFecha.Size = new System.Drawing.Size(170, 20);
            this.dateFecha.TabIndex = 51;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(788, 446);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Frm_Recetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 564);
            this.Controls.Add(this.tabPrincipalRecetario);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_Recetario";
            this.Text = "Recetario Médico";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPrincipalRecetario)).EndInit();
            this.tabPrincipalRecetario.ResumeLayout(false);
            this.tbpRecetario.ResumeLayout(false);
            this.tbpListaRecetarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpReceta)).EndInit();
            this.grpReceta.ResumeLayout(false);
            this.grpReceta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoeditIndicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDatos)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.BarButtonItem btnEnviar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraTab.XtraTabControl tabPrincipalRecetario;
        private DevExpress.XtraTab.XtraTabPage tbpRecetario;
        private DevExpress.XtraEditors.GroupControl grpReceta;
        private DevExpress.XtraEditors.MemoEdit memoeditIndicacion;
        private DevExpress.XtraEditors.LabelControl lblIndicación;
        private DevExpress.XtraEditors.GroupControl grpDatos;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.LabelControl lblDireccion;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.TextEdit txtEdad;
        private DevExpress.XtraEditors.LabelControl lblEdad;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblBuscar;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private DevExpress.XtraEditors.LabelControl lblApellidos;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.DateEdit dateFecha;
        private DevExpress.XtraTab.XtraTabPage tbpListaRecetarios;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}