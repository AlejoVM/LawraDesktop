namespace LawrApp.Layouts.regAlumno
{
	partial class frmFindAlumno
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvalumnos = new System.Windows.Forms.DataGridView();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtsearch = new MetroFramework.Controls.MetroTextBox();
			this.btncerrar = new MetroFramework.Controls.MetroButton();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.colAlumnoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colnivelMinAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colnivelMaxage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pgsLoad);
			this.panel1.Controls.Add(this.metroButton3);
			this.panel1.Controls.Add(this.btncerrar);
			this.panel1.Controls.Add(this.txtsearch);
			this.panel1.Controls.Add(this.metroLabel1);
			this.panel1.Controls.Add(this.metroButton1);
			this.panel1.Controls.Add(this.dgvalumnos);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(20, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(760, 420);
			this.panel1.TabIndex = 6;
			// 
			// dgvalumnos
			// 
			this.dgvalumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvalumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvalumnos.BackgroundColor = System.Drawing.Color.White;
			this.dgvalumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvalumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvalumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvalumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvalumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlumnoId,
            this.dataGridViewTextBoxColumn3,
            this.colnivelMinAge,
            this.colnivelMaxage});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvalumnos.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvalumnos.EnableHeadersVisualStyles = false;
			this.dgvalumnos.Location = new System.Drawing.Point(3, 70);
			this.dgvalumnos.MultiSelect = false;
			this.dgvalumnos.Name = "dgvalumnos";
			this.dgvalumnos.RowHeadersVisible = false;
			this.dgvalumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvalumnos.Size = new System.Drawing.Size(754, 306);
			this.dgvalumnos.StandardTab = true;
			this.dgvalumnos.TabIndex = 6;
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(672, 34);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(85, 30);
			this.metroButton1.TabIndex = 7;
			this.metroButton1.Text = "Buscar";
			this.metroButton1.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 12);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(47, 19);
			this.metroLabel1.TabIndex = 8;
			this.metroLabel1.Text = "Buscar";
			// 
			// txtsearch
			// 
			this.txtsearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
			this.txtsearch.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.txtsearch.Lines = new string[0];
			this.txtsearch.Location = new System.Drawing.Point(3, 34);
			this.txtsearch.MaxLength = 32767;
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.PasswordChar = '\0';
			this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtsearch.SelectedText = "";
			this.txtsearch.Size = new System.Drawing.Size(663, 30);
			this.txtsearch.TabIndex = 9;
			this.txtsearch.UseSelectable = true;
			// 
			// btncerrar
			// 
			this.btncerrar.Location = new System.Drawing.Point(581, 382);
			this.btncerrar.Name = "btncerrar";
			this.btncerrar.Size = new System.Drawing.Size(85, 35);
			this.btncerrar.TabIndex = 10;
			this.btncerrar.Text = "Cerrar";
			this.btncerrar.UseSelectable = true;
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(672, 382);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(85, 35);
			this.metroButton3.TabIndex = 11;
			this.metroButton3.Text = "Matricular";
			this.metroButton3.UseSelectable = true;
			// 
			// colAlumnoId
			// 
			this.colAlumnoId.HeaderText = "Id";
			this.colAlumnoId.Name = "colAlumnoId";
			this.colAlumnoId.ReadOnly = true;
			this.colAlumnoId.Visible = false;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.FillWeight = 50F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Key";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// colnivelMinAge
			// 
			this.colnivelMinAge.HeaderText = "Nombre del Alumno";
			this.colnivelMinAge.MaxInputLength = 2;
			this.colnivelMinAge.Name = "colnivelMinAge";
			this.colnivelMinAge.ReadOnly = true;
			// 
			// colnivelMaxage
			// 
			this.colnivelMaxage.FillWeight = 50F;
			this.colnivelMaxage.HeaderText = "Ult. Actualización";
			this.colnivelMaxage.MaxInputLength = 2;
			this.colnivelMaxage.Name = "colnivelMaxage";
			this.colnivelMaxage.ReadOnly = true;
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(3, 401);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(16, 16);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoad.TabIndex = 12;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			// 
			// frmFindAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 500);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "frmFindAlumno";
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Buscar Alumno";
			this.Load += new System.EventHandler(this.frmFindAlumno_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroTextBox txtsearch;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton metroButton1;
		private System.Windows.Forms.DataGridView dgvalumnos;
		private MetroFramework.Controls.MetroButton metroButton3;
		private MetroFramework.Controls.MetroButton btncerrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAlumnoId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn colnivelMinAge;
		private System.Windows.Forms.DataGridViewTextBoxColumn colnivelMaxage;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;

	}
}