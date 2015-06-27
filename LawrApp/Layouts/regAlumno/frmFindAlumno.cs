using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;
using System.Threading;
using Registers;

namespace LawrApp.Layouts.regAlumno
{
	public partial class frmFindAlumno : MetroForm
	{
		private DataGeneral _data;
		private Thread tr;
		private Alumnos alum = new Alumnos();

		void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;
			this.alum.ListStudents( _data );
			dgvalumnos.DataSource = this._data.Tables["liststudents"];
		}

		public frmFindAlumno( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		private void frmFindAlumno_Load( object sender, EventArgs e )
		{
			this.tr = new Thread( new ThreadStart( LoadData ) );
			this.tr.Start();
			this.txtsearch.Focus();
		}
	}
}
