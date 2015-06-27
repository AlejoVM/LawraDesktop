using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LawrApp.Layouts.regAlumno
{
    public partial class frmInitialMessage : MetroForm
    {
        private DataGeneral _data;

        public frmInitialMessage( DataGeneral dts )
        {
            this._data = dts;
            InitializeComponent();
        }

        private void btnMessageContinue_Click( object sender, EventArgs e )
        {
            frmPrsRegisterStudent rgStudent = new frmPrsRegisterStudent( this._data );
            rgStudent.Show();
            this.Close();
        }
    }
}
