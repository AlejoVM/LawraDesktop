using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace LawrApp.Layouts.regAlumno
{
    public partial class frmFindSchool : MetroForm
    {
        private DataTable _data;

        public delegate void _getDataSchool(string Nombre, int idScool, string tipo);
        public event _getDataSchool send;

        public frmFindSchool( DataTable dt )
        {
            this._data = dt;
            InitializeComponent();
        }

        private void frmFindSchool_Load( object sender, EventArgs e )
        {
            this.dgvListSchool.DataSource = this._data;
            this.dgvListSchool.Columns[0].Width = 50;
            this.dgvListSchool.Columns[2].Width = 150;

            this.txtSearchSchool.Focus();
        }

        private void txtSearchSchool_TextChanged(object sender, EventArgs e)
        {
           this._data.DefaultView.RowFilter = (" Name + ' ' + Type Like  '%" + this.txtSearchSchool.Text + "%'");
            this.dgvListSchool.DataSource =  this._data.DefaultView; 
        }

        private void dgvListSchool_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idcolegio           = Convert.ToInt32( dgvListSchool[0, e.RowIndex].Value);
            string nombreColegio    = dgvListSchool[1, e.RowIndex].Value.ToString();
            string tipoColegio      = dgvListSchool[2, e.RowIndex].Value.ToString();

            send(nombreColegio, idcolegio, tipoColegio);

            this.Close();
        }

        private void frmFindSchool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) 
            {
                if (dgvListSchool.SelectedRows.Count == 1) 
                {
                    int idcolegio           = Convert.ToInt32(this.dgvListSchool.CurrentRow.Cells[0].Value);
                    string nombreColegio    = this.dgvListSchool.CurrentRow.Cells[1].Value.ToString();
                    string tipoColegio      = this.dgvListSchool.CurrentRow.Cells[2].Value.ToString();

                    send(nombreColegio, idcolegio, tipoColegio);

                    this.Close();
                }
            
            }
        }


    }
}

