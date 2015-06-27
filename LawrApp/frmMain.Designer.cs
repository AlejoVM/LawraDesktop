namespace LawrApp
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.lblUserName = new MetroFramework.Controls.MetroLabel();
			this.lblUserType = new MetroFramework.Controls.MetroLabel();
			this.panelLogged = new System.Windows.Forms.Panel();
			this.btnLogOut = new System.Windows.Forms.Label();
			this.pbUserPicture = new System.Windows.Forms.PictureBox();
			this.menuOptions = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alumnoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.personalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alumnoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.personalToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.matriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.asistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alumnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aulaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.fichaPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile3 = new MetroFramework.Controls.MetroTile();
			this.tableTiles = new System.Windows.Forms.TableLayoutPanel();
			this.btnRegistrarAlumno = new MetroFramework.Controls.MetroTile();
			this.btnNewAcademyYear = new MetroFramework.Controls.MetroTile();
			this.metroTile5 = new MetroFramework.Controls.MetroTile();
			this.metroTile6 = new MetroFramework.Controls.MetroTile();
			this.metroTile7 = new MetroFramework.Controls.MetroTile();
			this.metroTile8 = new MetroFramework.Controls.MetroTile();
			this.metroTile9 = new MetroFramework.Controls.MetroTile();
			this.metroTile10 = new MetroFramework.Controls.MetroTile();
			this.metroTile11 = new MetroFramework.Controls.MetroTile();
			this.metroTile12 = new MetroFramework.Controls.MetroTile();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panelLoginIn = new System.Windows.Forms.Panel();
			this.btnLogin = new MetroFramework.Controls.MetroLink();
			this.label1 = new System.Windows.Forms.Label();
			this.panelTitles = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblLoadInfo = new MetroFramework.Controls.MetroLabel();
			this.pgsLoadDataDefault = new MetroFramework.Controls.MetroProgressSpinner();
			this.panelLogged.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
			this.menuOptions.SuspendLayout();
			this.tableTiles.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panelLoginIn.SuspendLayout();
			this.panelTitles.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblUserName
			// 
			this.lblUserName.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblUserName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblUserName.Location = new System.Drawing.Point(72, 3);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(245, 29);
			this.lblUserName.TabIndex = 2;
			this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblUserType
			// 
			this.lblUserType.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblUserType.Location = new System.Drawing.Point(72, 32);
			this.lblUserType.Name = "lblUserType";
			this.lblUserType.Size = new System.Drawing.Size(183, 17);
			this.lblUserType.TabIndex = 3;
			this.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelLogged
			// 
			this.panelLogged.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelLogged.Controls.Add(this.btnLogOut);
			this.panelLogged.Controls.Add(this.pbUserPicture);
			this.panelLogged.Controls.Add(this.lblUserType);
			this.panelLogged.Controls.Add(this.lblUserName);
			this.panelLogged.Enabled = false;
			this.panelLogged.Location = new System.Drawing.Point(3, 3);
			this.panelLogged.Name = "panelLogged";
			this.panelLogged.Size = new System.Drawing.Size(323, 74);
			this.panelLogged.TabIndex = 4;
			this.panelLogged.Visible = false;
			// 
			// btnLogOut
			// 
			this.btnLogOut.AutoSize = true;
			this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnLogOut.Location = new System.Drawing.Point(72, 54);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(81, 15);
			this.btnLogOut.TabIndex = 4;
			this.btnLogOut.Text = "Cerrar Sesión";
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// pbUserPicture
			// 
			this.pbUserPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.pbUserPicture.Location = new System.Drawing.Point(3, 3);
			this.pbUserPicture.Name = "pbUserPicture";
			this.pbUserPicture.Size = new System.Drawing.Size(63, 71);
			this.pbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbUserPicture.TabIndex = 1;
			this.pbUserPicture.TabStop = false;
			// 
			// menuOptions
			// 
			this.menuOptions.BackColor = System.Drawing.Color.White;
			this.menuOptions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
			this.menuOptions.Location = new System.Drawing.Point(20, 30);
			this.menuOptions.Name = "menuOptions";
			this.menuOptions.Size = new System.Drawing.Size(960, 28);
			this.menuOptions.TabIndex = 5;
			this.menuOptions.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.buscarToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// registrarToolStripMenuItem
			// 
			this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem2,
            this.personalToolStripMenuItem1});
			this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
			this.registrarToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.registrarToolStripMenuItem.Text = "Registrar";
			// 
			// alumnoToolStripMenuItem2
			// 
			this.alumnoToolStripMenuItem2.Name = "alumnoToolStripMenuItem2";
			this.alumnoToolStripMenuItem2.Size = new System.Drawing.Size(134, 24);
			this.alumnoToolStripMenuItem2.Text = "Alumno";
			// 
			// personalToolStripMenuItem1
			// 
			this.personalToolStripMenuItem1.Name = "personalToolStripMenuItem1";
			this.personalToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
			this.personalToolStripMenuItem1.Text = "Personal";
			// 
			// buscarToolStripMenuItem
			// 
			this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem3,
            this.personalToolStripMenuItem2});
			this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
			this.buscarToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.buscarToolStripMenuItem.Text = "Buscar";
			// 
			// alumnoToolStripMenuItem3
			// 
			this.alumnoToolStripMenuItem3.Name = "alumnoToolStripMenuItem3";
			this.alumnoToolStripMenuItem3.Size = new System.Drawing.Size(134, 24);
			this.alumnoToolStripMenuItem3.Text = "Alumno";
			// 
			// personalToolStripMenuItem2
			// 
			this.personalToolStripMenuItem2.Name = "personalToolStripMenuItem2";
			this.personalToolStripMenuItem2.Size = new System.Drawing.Size(134, 24);
			this.personalToolStripMenuItem2.Text = "Personal";
			// 
			// procesosToolStripMenuItem
			// 
			this.procesosToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculasToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.horariosToolStripMenuItem});
			this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
			this.procesosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
			this.procesosToolStripMenuItem.Size = new System.Drawing.Size(79, 32);
			this.procesosToolStripMenuItem.Text = "Procesos";
			// 
			// matriculasToolStripMenuItem
			// 
			this.matriculasToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.matriculasToolStripMenuItem.Name = "matriculasToolStripMenuItem";
			this.matriculasToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.matriculasToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
			this.matriculasToolStripMenuItem.Text = "Matriculas";
			// 
			// registrosToolStripMenuItem
			// 
			this.registrosToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.personalToolStripMenuItem});
			this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
			this.registrosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.registrosToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
			this.registrosToolStripMenuItem.Text = "Registros";
			// 
			// alumnosToolStripMenuItem
			// 
			this.alumnosToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
			this.alumnosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
			this.alumnosToolStripMenuItem.Text = "Alumnos";
			// 
			// personalToolStripMenuItem
			// 
			this.personalToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
			this.personalToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.personalToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
			this.personalToolStripMenuItem.Text = "Personal";
			// 
			// pagosToolStripMenuItem
			// 
			this.pagosToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.pagosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
			this.pagosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.pagosToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
			this.pagosToolStripMenuItem.Text = "Pagos";
			// 
			// horariosToolStripMenuItem
			// 
			this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
			this.horariosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.horariosToolStripMenuItem.Text = "Horarios";
			// 
			// reportesToolStripMenuItem
			// 
			this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notasToolStripMenuItem,
            this.asistenciasToolStripMenuItem,
            this.fichaPersonalToolStripMenuItem});
			this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
			this.reportesToolStripMenuItem.Text = "Reportes";
			// 
			// notasToolStripMenuItem
			// 
			this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.aulaToolStripMenuItem});
			this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
			this.notasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.notasToolStripMenuItem.Text = "Notas";
			// 
			// alumnoToolStripMenuItem
			// 
			this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
			this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.alumnoToolStripMenuItem.Text = "Alumno";
			// 
			// aulaToolStripMenuItem
			// 
			this.aulaToolStripMenuItem.Name = "aulaToolStripMenuItem";
			this.aulaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.aulaToolStripMenuItem.Text = "Aula";
			// 
			// asistenciasToolStripMenuItem
			// 
			this.asistenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem1,
            this.aulaToolStripMenuItem1});
			this.asistenciasToolStripMenuItem.Name = "asistenciasToolStripMenuItem";
			this.asistenciasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.asistenciasToolStripMenuItem.Text = "Asistencias";
			// 
			// alumnoToolStripMenuItem1
			// 
			this.alumnoToolStripMenuItem1.Name = "alumnoToolStripMenuItem1";
			this.alumnoToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
			this.alumnoToolStripMenuItem1.Text = "Alumno";
			// 
			// aulaToolStripMenuItem1
			// 
			this.aulaToolStripMenuItem1.Name = "aulaToolStripMenuItem1";
			this.aulaToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
			this.aulaToolStripMenuItem1.Text = "Aula";
			// 
			// fichaPersonalToolStripMenuItem
			// 
			this.fichaPersonalToolStripMenuItem.Name = "fichaPersonalToolStripMenuItem";
			this.fichaPersonalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.fichaPersonalToolStripMenuItem.Text = "Ficha Personal";
			// 
			// configuracionesToolStripMenuItem
			// 
			this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
			this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
			this.configuracionesToolStripMenuItem.Text = "Configuraciones";
			// 
			// metroTile2
			// 
			this.metroTile2.ActiveControl = null;
			this.metroTile2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile2.AutoSize = true;
			this.metroTile2.Location = new System.Drawing.Point(4, 250);
			this.metroTile2.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile2.MaximumSize = new System.Drawing.Size(150, 170);
			this.metroTile2.MinimumSize = new System.Drawing.Size(100, 120);
			this.metroTile2.Name = "metroTile2";
			this.metroTile2.Size = new System.Drawing.Size(110, 120);
			this.metroTile2.Style = MetroFramework.MetroColorStyle.Purple;
			this.metroTile2.TabIndex = 6;
			this.metroTile2.Text = "Registrar \r\nPersonal";
			this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile2.UseSelectable = true;
			this.metroTile2.UseStyleColors = true;
			this.metroTile2.UseTileImage = true;
			// 
			// metroTile3
			// 
			this.metroTile3.ActiveControl = null;
			this.metroTile3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile3.AutoSize = true;
			this.metroTile3.Location = new System.Drawing.Point(4, 127);
			this.metroTile3.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile3.MaximumSize = new System.Drawing.Size(150, 170);
			this.metroTile3.MinimumSize = new System.Drawing.Size(100, 120);
			this.metroTile3.Name = "metroTile3";
			this.metroTile3.Size = new System.Drawing.Size(110, 120);
			this.metroTile3.Style = MetroFramework.MetroColorStyle.Teal;
			this.metroTile3.TabIndex = 6;
			this.metroTile3.Text = "Pagos";
			this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile3.UseSelectable = true;
			this.metroTile3.UseStyleColors = true;
			this.metroTile3.UseTileImage = true;
			// 
			// tableTiles
			// 
			this.tableTiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableTiles.ColumnCount = 8;
			this.tableTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableTiles.Controls.Add(this.btnRegistrarAlumno, 1, 0);
			this.tableTiles.Controls.Add(this.btnNewAcademyYear, 0, 0);
			this.tableTiles.Controls.Add(this.metroTile2, 0, 2);
			this.tableTiles.Controls.Add(this.metroTile3, 0, 1);
			this.tableTiles.Controls.Add(this.metroTile5, 3, 0);
			this.tableTiles.Controls.Add(this.metroTile6, 3, 1);
			this.tableTiles.Controls.Add(this.metroTile7, 3, 2);
			this.tableTiles.Controls.Add(this.metroTile8, 6, 0);
			this.tableTiles.Controls.Add(this.metroTile9, 7, 0);
			this.tableTiles.Controls.Add(this.metroTile10, 6, 1);
			this.tableTiles.Controls.Add(this.metroTile11, 4, 0);
			this.tableTiles.Controls.Add(this.metroTile12, 4, 1);
			this.tableTiles.Location = new System.Drawing.Point(26, 185);
			this.tableTiles.Name = "tableTiles";
			this.tableTiles.RowCount = 3;
			this.tableTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableTiles.Size = new System.Drawing.Size(951, 371);
			this.tableTiles.TabIndex = 8;
			// 
			// btnRegistrarAlumno
			// 
			this.btnRegistrarAlumno.ActiveControl = null;
			this.btnRegistrarAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRegistrarAlumno.AutoSize = true;
			this.btnRegistrarAlumno.Location = new System.Drawing.Point(122, 4);
			this.btnRegistrarAlumno.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegistrarAlumno.MaximumSize = new System.Drawing.Size(150, 170);
			this.btnRegistrarAlumno.MinimumSize = new System.Drawing.Size(100, 120);
			this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
			this.btnRegistrarAlumno.Size = new System.Drawing.Size(110, 120);
			this.btnRegistrarAlumno.TabIndex = 6;
			this.btnRegistrarAlumno.Text = "Registrar \r\nAlumno";
			this.btnRegistrarAlumno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnRegistrarAlumno.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarAlumno.TileImage")));
			this.btnRegistrarAlumno.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnRegistrarAlumno.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
			this.btnRegistrarAlumno.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.btnRegistrarAlumno.UseSelectable = true;
			this.btnRegistrarAlumno.UseStyleColors = true;
			this.btnRegistrarAlumno.UseTileImage = true;
			this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
			// 
			// btnNewAcademyYear
			// 
			this.btnNewAcademyYear.ActiveControl = null;
			this.btnNewAcademyYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewAcademyYear.AutoSize = true;
			this.btnNewAcademyYear.Location = new System.Drawing.Point(4, 4);
			this.btnNewAcademyYear.Margin = new System.Windows.Forms.Padding(4);
			this.btnNewAcademyYear.MaximumSize = new System.Drawing.Size(150, 170);
			this.btnNewAcademyYear.MinimumSize = new System.Drawing.Size(100, 120);
			this.btnNewAcademyYear.Name = "btnNewAcademyYear";
			this.btnNewAcademyYear.Size = new System.Drawing.Size(110, 120);
			this.btnNewAcademyYear.TabIndex = 6;
			this.btnNewAcademyYear.Text = "Nuevo Año \r\nAcademico";
			this.btnNewAcademyYear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNewAcademyYear.TileImage = ((System.Drawing.Image)(resources.GetObject("btnNewAcademyYear.TileImage")));
			this.btnNewAcademyYear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNewAcademyYear.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
			this.btnNewAcademyYear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.btnNewAcademyYear.UseSelectable = true;
			this.btnNewAcademyYear.UseStyleColors = true;
			this.btnNewAcademyYear.UseTileImage = true;
			this.btnNewAcademyYear.Click += new System.EventHandler(this.btnNewAcademyYear_Click);
			// 
			// metroTile5
			// 
			this.metroTile5.ActiveControl = null;
			this.metroTile5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile5.AutoSize = true;
			this.metroTile5.Location = new System.Drawing.Point(358, 4);
			this.metroTile5.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile5.MaximumSize = new System.Drawing.Size(150, 170);
			this.metroTile5.MinimumSize = new System.Drawing.Size(100, 120);
			this.metroTile5.Name = "metroTile5";
			this.metroTile5.Size = new System.Drawing.Size(110, 120);
			this.metroTile5.TabIndex = 6;
			this.metroTile5.Text = "Notas de\r\nAlumno";
			this.metroTile5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile5.UseSelectable = true;
			this.metroTile5.UseStyleColors = true;
			this.metroTile5.UseTileImage = true;
			// 
			// metroTile6
			// 
			this.metroTile6.ActiveControl = null;
			this.metroTile6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile6.AutoSize = true;
			this.metroTile6.Location = new System.Drawing.Point(358, 127);
			this.metroTile6.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile6.MaximumSize = new System.Drawing.Size(150, 170);
			this.metroTile6.MinimumSize = new System.Drawing.Size(100, 120);
			this.metroTile6.Name = "metroTile6";
			this.metroTile6.Size = new System.Drawing.Size(110, 120);
			this.metroTile6.Style = MetroFramework.MetroColorStyle.Teal;
			this.metroTile6.TabIndex = 6;
			this.metroTile6.Text = "Asistencias\r\nde Alumno";
			this.metroTile6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile6.UseSelectable = true;
			this.metroTile6.UseStyleColors = true;
			this.metroTile6.UseTileImage = true;
			// 
			// metroTile7
			// 
			this.metroTile7.ActiveControl = null;
			this.metroTile7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile7.AutoSize = true;
			this.metroTile7.Location = new System.Drawing.Point(358, 250);
			this.metroTile7.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile7.MaximumSize = new System.Drawing.Size(150, 170);
			this.metroTile7.MinimumSize = new System.Drawing.Size(100, 120);
			this.metroTile7.Name = "metroTile7";
			this.metroTile7.Size = new System.Drawing.Size(110, 120);
			this.metroTile7.Style = MetroFramework.MetroColorStyle.Purple;
			this.metroTile7.TabIndex = 6;
			this.metroTile7.Text = "Imprimir \r\nFichas";
			this.metroTile7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile7.UseSelectable = true;
			this.metroTile7.UseStyleColors = true;
			this.metroTile7.UseTileImage = true;
			// 
			// metroTile8
			// 
			this.metroTile8.ActiveControl = null;
			this.metroTile8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile8.AutoSize = true;
			this.metroTile8.Location = new System.Drawing.Point(712, 4);
			this.metroTile8.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile8.MaximumSize = new System.Drawing.Size(150, 170);
			this.metroTile8.MinimumSize = new System.Drawing.Size(100, 120);
			this.metroTile8.Name = "metroTile8";
			this.metroTile8.Size = new System.Drawing.Size(110, 120);
			this.metroTile8.TabIndex = 6;
			this.metroTile8.Text = "Matriculas";
			this.metroTile8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile8.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile8.UseSelectable = true;
			this.metroTile8.UseStyleColors = true;
			this.metroTile8.UseTileImage = true;
			// 
			// metroTile9
			// 
			this.metroTile9.ActiveControl = null;
			this.metroTile9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile9.AutoSize = true;
			this.metroTile9.Location = new System.Drawing.Point(830, 4);
			this.metroTile9.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile9.MaximumSize = new System.Drawing.Size(150, 170);
			this.metroTile9.MinimumSize = new System.Drawing.Size(100, 120);
			this.metroTile9.Name = "metroTile9";
			this.metroTile9.Size = new System.Drawing.Size(117, 120);
			this.metroTile9.TabIndex = 6;
			this.metroTile9.Text = "Matriculas";
			this.metroTile9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile9.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile9.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile9.UseSelectable = true;
			this.metroTile9.UseStyleColors = true;
			this.metroTile9.UseTileImage = true;
			// 
			// metroTile10
			// 
			this.metroTile10.ActiveControl = null;
			this.metroTile10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile10.AutoSize = true;
			this.metroTile10.Location = new System.Drawing.Point(712, 127);
			this.metroTile10.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile10.MaximumSize = new System.Drawing.Size(150, 170);
			this.metroTile10.MinimumSize = new System.Drawing.Size(100, 120);
			this.metroTile10.Name = "metroTile10";
			this.metroTile10.Size = new System.Drawing.Size(110, 120);
			this.metroTile10.Style = MetroFramework.MetroColorStyle.Teal;
			this.metroTile10.TabIndex = 6;
			this.metroTile10.Text = "Matriculas";
			this.metroTile10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile10.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile10.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile10.UseSelectable = true;
			this.metroTile10.UseStyleColors = true;
			this.metroTile10.UseTileImage = true;
			// 
			// metroTile11
			// 
			this.metroTile11.ActiveControl = null;
			this.metroTile11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile11.AutoSize = true;
			this.metroTile11.Location = new System.Drawing.Point(476, 4);
			this.metroTile11.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile11.MaximumSize = new System.Drawing.Size(150, 170);
			this.metroTile11.MinimumSize = new System.Drawing.Size(100, 120);
			this.metroTile11.Name = "metroTile11";
			this.metroTile11.Size = new System.Drawing.Size(110, 120);
			this.metroTile11.TabIndex = 6;
			this.metroTile11.Text = "Notas de\r\nAula";
			this.metroTile11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile11.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile11.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile11.UseSelectable = true;
			this.metroTile11.UseStyleColors = true;
			this.metroTile11.UseTileImage = true;
			// 
			// metroTile12
			// 
			this.metroTile12.ActiveControl = null;
			this.metroTile12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile12.AutoSize = true;
			this.metroTile12.Location = new System.Drawing.Point(476, 127);
			this.metroTile12.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile12.MaximumSize = new System.Drawing.Size(150, 170);
			this.metroTile12.MinimumSize = new System.Drawing.Size(100, 120);
			this.metroTile12.Name = "metroTile12";
			this.metroTile12.Size = new System.Drawing.Size(110, 120);
			this.metroTile12.Style = MetroFramework.MetroColorStyle.Teal;
			this.metroTile12.TabIndex = 6;
			this.metroTile12.Text = "Asistencias\r\nde Aulas";
			this.metroTile12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile12.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile12.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile12.UseSelectable = true;
			this.metroTile12.UseStyleColors = true;
			this.metroTile12.UseTileImage = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panelLogged);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 65);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(954, 80);
			this.flowLayoutPanel1.TabIndex = 9;
			// 
			// panelLoginIn
			// 
			this.panelLoginIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panelLoginIn.Controls.Add(this.btnLogin);
			this.panelLoginIn.Enabled = false;
			this.panelLoginIn.Location = new System.Drawing.Point(451, 388);
			this.panelLoginIn.Name = "panelLoginIn";
			this.panelLoginIn.Size = new System.Drawing.Size(96, 32);
			this.panelLoginIn.TabIndex = 5;
			this.panelLoginIn.Visible = false;
			// 
			// btnLogin
			// 
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnLogin.Location = new System.Drawing.Point(0, 0);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(96, 32);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Iniciar Sesión";
			this.btnLogin.UseSelectable = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
			this.label1.Location = new System.Drawing.Point(3, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "Asistente de Procesos";
			// 
			// panelTitles
			// 
			this.panelTitles.Controls.Add(this.label1);
			this.panelTitles.Location = new System.Drawing.Point(30, 164);
			this.panelTitles.Name = "panelTitles";
			this.panelTitles.Size = new System.Drawing.Size(943, 18);
			this.panelTitles.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Enabled = false;
			this.pictureBox1.Image = global::LawrApp.Properties.Resources.dashboard_logout;
			this.pictureBox1.Location = new System.Drawing.Point(387, 168);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(226, 221);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// lblLoadInfo
			// 
			this.lblLoadInfo.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblLoadInfo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblLoadInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblLoadInfo.Location = new System.Drawing.Point(52, 561);
			this.lblLoadInfo.Name = "lblLoadInfo";
			this.lblLoadInfo.Size = new System.Drawing.Size(925, 19);
			this.lblLoadInfo.TabIndex = 13;
			// 
			// pgsLoadDataDefault
			// 
			this.pgsLoadDataDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pgsLoadDataDefault.Location = new System.Drawing.Point(30, 561);
			this.pgsLoadDataDefault.Maximum = 100;
			this.pgsLoadDataDefault.Name = "pgsLoadDataDefault";
			this.pgsLoadDataDefault.Size = new System.Drawing.Size(16, 16);
			this.pgsLoadDataDefault.Speed = 2F;
			this.pgsLoadDataDefault.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoadDataDefault.TabIndex = 14;
			this.pgsLoadDataDefault.UseSelectable = true;
			this.pgsLoadDataDefault.Value = 50;
			this.pgsLoadDataDefault.Visible = false;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(1000, 600);
			this.Controls.Add(this.pgsLoadDataDefault);
			this.Controls.Add(this.lblLoadInfo);
			this.Controls.Add(this.panelTitles);
			this.Controls.Add(this.tableTiles);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.menuOptions);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panelLoginIn);
			this.DisplayHeader = false;
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(1000, 600);
			this.Name = "frmMain";
			this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Imprimir Fichas";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.panelLogged.ResumeLayout(false);
			this.panelLogged.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
			this.menuOptions.ResumeLayout(false);
			this.menuOptions.PerformLayout();
			this.tableTiles.ResumeLayout(false);
			this.tableTiles.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panelLoginIn.ResumeLayout(false);
			this.panelTitles.ResumeLayout(false);
			this.panelTitles.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserPicture;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private MetroFramework.Controls.MetroLabel lblUserType;
        private System.Windows.Forms.Panel panelLogged;
        private System.Windows.Forms.MenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aulaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaPersonalToolStripMenuItem;
        private MetroFramework.Controls.MetroTile btnRegistrarAlumno;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile btnNewAcademyYear;
        private System.Windows.Forms.TableLayoutPanel tableTiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelLoginIn;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroTile metroTile10;
        private MetroFramework.Controls.MetroTile metroTile11;
        private MetroFramework.Controls.MetroTile metroTile12;
        private System.Windows.Forms.Label btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem2;
        private MetroFramework.Controls.MetroLink btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitles;
        private MetroFramework.Controls.MetroLabel lblLoadInfo;
        private MetroFramework.Controls.MetroProgressSpinner pgsLoadDataDefault;

    }
}

