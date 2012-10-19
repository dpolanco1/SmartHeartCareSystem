namespace WindowsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navbarImageListLarge = new System.Windows.Forms.ImageList();
            this.navbarImageList = new System.Windows.Forms.ImageList();
            this.barManager = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.menuArchivo = new DevExpress.XtraBars.BarSubItem();
            this.iNew = new DevExpress.XtraBars.BarButtonItem();
            this.iOpen = new DevExpress.XtraBars.BarButtonItem();
            this.iClose = new DevExpress.XtraBars.BarButtonItem();
            this.iSave = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.menuConfiguracion = new DevExpress.XtraBars.BarSubItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.menuNumeracion = new DevExpress.XtraBars.BarSubItem();
            this.menuReportes = new DevExpress.XtraBars.BarSubItem();
            this.menuAyuda = new DevExpress.XtraBars.BarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.grupoMantenimientos = new DevExpress.XtraNavBar.NavBarGroup();
            this.ItemPacientes = new DevExpress.XtraNavBar.NavBarItem();
            this.itemEmpleados = new DevExpress.XtraNavBar.NavBarItem();
            this.grupoMail = new DevExpress.XtraNavBar.NavBarGroup();
            this.inboxItem = new DevExpress.XtraNavBar.NavBarItem();
            this.outboxItem = new DevExpress.XtraNavBar.NavBarItem();
            this.draftsItem = new DevExpress.XtraNavBar.NavBarItem();
            this.trashItem = new DevExpress.XtraNavBar.NavBarItem();
            this.grupoOrganizador = new DevExpress.XtraNavBar.NavBarGroup();
            this.calendarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.tasksItem = new DevExpress.XtraNavBar.NavBarItem();
            this.grupoActividades = new DevExpress.XtraNavBar.NavBarGroup();
            this.itemHistorialClinico = new DevExpress.XtraNavBar.NavBarItem();
            this.itemConsultas = new DevExpress.XtraNavBar.NavBarItem();
            this.itemRecetario = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarImageListLarge
            // 
            this.navbarImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageListLarge.ImageStream")));
            this.navbarImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageListLarge.Images.SetKeyName(0, "Mail_32x32.png");
            this.navbarImageListLarge.Images.SetKeyName(1, "Organizer_32x32.png");
            // 
            // navbarImageList
            // 
            this.navbarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageList.ImageStream")));
            this.navbarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageList.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageList.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageList.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageList.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.menuArchivo,
            this.barButtonItem2,
            this.iOpen,
            this.iClose,
            this.iNew,
            this.iSave,
            this.iSaveAs,
            this.iExit,
            this.menuConfiguracion,
            this.iAbout,
            this.menuNumeracion,
            this.menuReportes,
            this.menuAyuda});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 15;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menuArchivo),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuConfiguracion),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuNumeracion),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuReportes),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuAyuda)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // menuArchivo
            // 
            this.menuArchivo.Caption = "&Archivo";
            this.menuArchivo.Id = 0;
            this.menuArchivo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOpen),
            new DevExpress.XtraBars.LinkPersistInfo(this.iClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSaveAs),
            new DevExpress.XtraBars.LinkPersistInfo(this.iExit)});
            this.menuArchivo.Name = "menuArchivo";
            // 
            // iNew
            // 
            this.iNew.Caption = "&New";
            this.iNew.Id = 6;
            this.iNew.Name = "iNew";
            // 
            // iOpen
            // 
            this.iOpen.Caption = "&Open";
            this.iOpen.Id = 4;
            this.iOpen.Name = "iOpen";
            // 
            // iClose
            // 
            this.iClose.Caption = "&Close";
            this.iClose.Id = 5;
            this.iClose.Name = "iClose";
            // 
            // iSave
            // 
            this.iSave.Caption = "&Save";
            this.iSave.Id = 7;
            this.iSave.Name = "iSave";
            // 
            // iSaveAs
            // 
            this.iSaveAs.Caption = "Save &As";
            this.iSaveAs.Id = 8;
            this.iSaveAs.Name = "iSaveAs";
            // 
            // iExit
            // 
            this.iExit.Caption = "E&xit";
            this.iExit.Id = 9;
            this.iExit.Name = "iExit";
            // 
            // menuConfiguracion
            // 
            this.menuConfiguracion.Caption = "&Configuración";
            this.menuConfiguracion.Id = 10;
            this.menuConfiguracion.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iAbout)});
            this.menuConfiguracion.Name = "menuConfiguracion";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "&About";
            this.iAbout.Id = 11;
            this.iAbout.Name = "iAbout";
            // 
            // menuNumeracion
            // 
            this.menuNumeracion.Caption = "&Numeración";
            this.menuNumeracion.Id = 12;
            this.menuNumeracion.Name = "menuNumeracion";
            // 
            // menuReportes
            // 
            this.menuReportes.Caption = "&Reportes";
            this.menuReportes.Id = 13;
            this.menuReportes.Name = "menuReportes";
            // 
            // menuAyuda
            // 
            this.menuAyuda.Caption = "&Ayuda";
            this.menuAyuda.Id = 14;
            this.menuAyuda.Name = "menuAyuda";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1019, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 677);
            this.barDockControlBottom.Size = new System.Drawing.Size(1019, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 655);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1019, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 655);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Open";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.grupoActividades;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.grupoMail,
            this.grupoOrganizador,
            this.grupoMantenimientos,
            this.grupoActividades});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.inboxItem,
            this.outboxItem,
            this.draftsItem,
            this.trashItem,
            this.calendarItem,
            this.tasksItem,
            this.ItemPacientes,
            this.itemEmpleados,
            this.itemHistorialClinico,
            this.itemConsultas,
            this.itemRecetario});
            this.navBarControl.LargeImages = this.navbarImageListLarge;
            this.navBarControl.Location = new System.Drawing.Point(0, 22);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 322;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(169, 655);
            this.navBarControl.SmallImages = this.navbarImageList;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 5;
            this.navBarControl.Text = "navBarControl1";
            // 
            // grupoMantenimientos
            // 
            this.grupoMantenimientos.Caption = "Mantenimientos";
            this.grupoMantenimientos.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemPacientes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemEmpleados)});
            this.grupoMantenimientos.LargeImageIndex = 1;
            this.grupoMantenimientos.Name = "grupoMantenimientos";
            // 
            // ItemPacientes
            // 
            this.ItemPacientes.Caption = "Pacientes";
            this.ItemPacientes.Name = "ItemPacientes";
            this.ItemPacientes.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemPacientes_LinkPressed);
            // 
            // itemEmpleados
            // 
            this.itemEmpleados.Caption = "Empleados";
            this.itemEmpleados.Name = "itemEmpleados";
            // 
            // grupoMail
            // 
            this.grupoMail.Caption = "Mail";
            this.grupoMail.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.inboxItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.outboxItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.draftsItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.trashItem)});
            this.grupoMail.LargeImageIndex = 0;
            this.grupoMail.Name = "grupoMail";
            // 
            // inboxItem
            // 
            this.inboxItem.Caption = "Inbox";
            this.inboxItem.Name = "inboxItem";
            this.inboxItem.SmallImageIndex = 0;
            // 
            // outboxItem
            // 
            this.outboxItem.Caption = "Outbox";
            this.outboxItem.Name = "outboxItem";
            this.outboxItem.SmallImageIndex = 1;
            // 
            // draftsItem
            // 
            this.draftsItem.Caption = "Drafts";
            this.draftsItem.Name = "draftsItem";
            this.draftsItem.SmallImageIndex = 2;
            // 
            // trashItem
            // 
            this.trashItem.Caption = "Trash";
            this.trashItem.Name = "trashItem";
            this.trashItem.SmallImageIndex = 3;
            // 
            // grupoOrganizador
            // 
            this.grupoOrganizador.Caption = "Organizador";
            this.grupoOrganizador.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.calendarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.tasksItem)});
            this.grupoOrganizador.LargeImageIndex = 1;
            this.grupoOrganizador.Name = "grupoOrganizador";
            // 
            // calendarItem
            // 
            this.calendarItem.Caption = "Calendar";
            this.calendarItem.Name = "calendarItem";
            this.calendarItem.SmallImageIndex = 4;
            // 
            // tasksItem
            // 
            this.tasksItem.Caption = "Tasks";
            this.tasksItem.Name = "tasksItem";
            this.tasksItem.SmallImageIndex = 5;
            // 
            // grupoActividades
            // 
            this.grupoActividades.Caption = "Actividades";
            this.grupoActividades.Expanded = true;
            this.grupoActividades.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemHistorialClinico),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemConsultas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemRecetario)});
            this.grupoActividades.LargeImageIndex = 1;
            this.grupoActividades.Name = "grupoActividades";
            // 
            // itemHistorialClinico
            // 
            this.itemHistorialClinico.Caption = "Historial Clinico";
            this.itemHistorialClinico.Name = "itemHistorialClinico";
            this.itemHistorialClinico.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itemHistorialClinico_LinkClicked);
            // 
            // itemConsultas
            // 
            this.itemConsultas.Caption = "Consultas";
            this.itemConsultas.Name = "itemConsultas";
            // 
            // itemRecetario
            // 
            this.itemRecetario.Caption = "Recetario Médico";
            this.itemRecetario.Name = "itemRecetario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 677);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Sistema de Gestión Médica Inteligente ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem menuArchivo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem iOpen;
        private DevExpress.XtraBars.BarButtonItem iClose;
        private DevExpress.XtraBars.BarButtonItem iNew;
        private DevExpress.XtraBars.BarButtonItem iSave;
        private DevExpress.XtraBars.BarButtonItem iSaveAs;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarSubItem menuConfiguracion;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private System.Windows.Forms.ImageList navbarImageList;
        private System.Windows.Forms.ImageList navbarImageListLarge;
        private DevExpress.XtraBars.BarSubItem menuNumeracion;
        private DevExpress.XtraBars.BarSubItem menuReportes;
        private DevExpress.XtraBars.BarSubItem menuAyuda;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup grupoActividades;
        private DevExpress.XtraNavBar.NavBarItem itemHistorialClinico;
        private DevExpress.XtraNavBar.NavBarItem itemConsultas;
        private DevExpress.XtraNavBar.NavBarItem itemRecetario;
        private DevExpress.XtraNavBar.NavBarGroup grupoMail;
        private DevExpress.XtraNavBar.NavBarItem inboxItem;
        private DevExpress.XtraNavBar.NavBarItem outboxItem;
        private DevExpress.XtraNavBar.NavBarItem draftsItem;
        private DevExpress.XtraNavBar.NavBarItem trashItem;
        private DevExpress.XtraNavBar.NavBarGroup grupoOrganizador;
        private DevExpress.XtraNavBar.NavBarItem calendarItem;
        private DevExpress.XtraNavBar.NavBarItem tasksItem;
        private DevExpress.XtraNavBar.NavBarGroup grupoMantenimientos;
        private DevExpress.XtraNavBar.NavBarItem ItemPacientes;
        private DevExpress.XtraNavBar.NavBarItem itemEmpleados;

    }
}
