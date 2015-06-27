namespace LawrApp.Layouts.regAlumno
{
    partial class frmFindSchool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchSchool = new MetroFramework.Controls.MetroTextBox();
            this.dgvListSchool = new MetroFramework.Controls.MetroGrid();
            this.btnadd = new MetroFramework.Controls.MetroButton();
            this.btnbuscar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchSchool
            // 
            this.txtSearchSchool.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchSchool.Lines = new string[0];
            this.txtSearchSchool.Location = new System.Drawing.Point(30, 95);
            this.txtSearchSchool.MaxLength = 32767;
            this.txtSearchSchool.Name = "txtSearchSchool";
            this.txtSearchSchool.PasswordChar = '\0';
            this.txtSearchSchool.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchSchool.SelectedText = "";
            this.txtSearchSchool.Size = new System.Drawing.Size(459, 29);
            this.txtSearchSchool.TabIndex = 0;
            this.txtSearchSchool.UseSelectable = true;
            this.txtSearchSchool.TextChanged += new System.EventHandler(this.txtSearchSchool_TextChanged);
            // 
            // dgvListSchool
            // 
            this.dgvListSchool.AllowUserToAddRows = false;
            this.dgvListSchool.AllowUserToDeleteRows = false;
            this.dgvListSchool.AllowUserToResizeRows = false;
            this.dgvListSchool.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSchool.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListSchool.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListSchool.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListSchool.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListSchool.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListSchool.ColumnHeadersHeight = 30;
            this.dgvListSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListSchool.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListSchool.EnableHeadersVisualStyles = false;
            this.dgvListSchool.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListSchool.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListSchool.Location = new System.Drawing.Point(30, 130);
            this.dgvListSchool.Name = "dgvListSchool";
            this.dgvListSchool.ReadOnly = true;
            this.dgvListSchool.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSchool.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListSchool.RowHeadersVisible = false;
            this.dgvListSchool.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListSchool.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListSchool.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSchool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSchool.Size = new System.Drawing.Size(540, 207);
            this.dgvListSchool.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvListSchool.TabIndex = 1;
            this.dgvListSchool.UseCustomBackColor = true;
            this.dgvListSchool.UseCustomForeColor = true;
            this.dgvListSchool.UseStyleColors = true;
            this.dgvListSchool.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSchool_CellDoubleClick);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(495, 343);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Agregar";
            this.btnadd.UseSelectable = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(495, 95);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 29);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseSelectable = true;
            // 
            // frmFindSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvListSchool);
            this.Controls.Add(this.txtSearchSchool);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFindSchool";
            this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Buscar Colegios";
            this.Load += new System.EventHandler(this.frmFindSchool_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFindSchool_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSchool)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtSearchSchool;
        private MetroFramework.Controls.MetroGrid dgvListSchool;
        private MetroFramework.Controls.MetroButton btnadd;
        private MetroFramework.Controls.MetroButton btnbuscar;
    }
}