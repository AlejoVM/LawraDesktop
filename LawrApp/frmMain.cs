﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

using Access;
using Objects.Tables;
using System.Threading;

namespace LawrApp
{
    public partial class frmMain : MetroForm, IFrmMain
    {
        //el formulario login modifica esta variable
        private Login _log = new Login();
        private PreLoadData _preload = new PreLoadData();
        private DataGeneral _data;
        private Thread _tr;

        public frmMain( DataGeneral dts )
        {
            _data = dts;
            InitializeComponent();
        }

        #region HILOS

        public void LoadDataDefault()
        {
            Thread.Sleep(200);
            CheckForIllegalCrossThreadCalls = false;

            this.lblLoadInfo.Text = "Cargando: Departamentos, Provincias, Distritos...";
            this._preload.ListUbigeo( _data );

            this.lblLoadInfo.Text = "Cargando: Tipos de Documentos...";
            this._preload.ListTipoDocumento( _data );

            this.lblLoadInfo.Text = "Cargando: Tipos de Parientes...";
            this._preload.ListTipoApoderado(_data);

            this.lblLoadInfo.Text = "";
            this.pgsLoadDataDefault.Visible = false;

            this.ControlsEnabled( true );
        }

        #endregion

        #region METODOS

        private void ControlsVisible( bool IsIt )
        {
            this.menuOptions.Visible = IsIt;
            this.panelLogged.Visible = IsIt;
            this.panelLoginIn.Visible = !IsIt;
            this.tableTiles.Visible = IsIt;
            this.panelTitles.Visible = IsIt;
        }

        private void ControlsEnabled( bool IsIt )
        {
            this.menuOptions.Enabled = IsIt;
            this.panelLogged.Enabled = IsIt;
            this.panelLoginIn.Enabled = !IsIt;
            this.tableTiles.Enabled = IsIt;
			this.panelTitles.Visible = IsIt;
        }

        public void ChangeOpacity(int Opacity)
        {
            this.Opacity = Opacity;
        }

        #endregion

        #region EVENTOS

        private void frmMain_Load( object sender, EventArgs e )
        {
            if ( this._log.TokenIsRegistered() )
            {
                this._tr = new Thread( new ThreadStart( this.LoadDataDefault ) );

                this.lblUserName.Text = this._log.UserFullName;
                this.lblUserType.Text = this._log.UserType;
                this.pbUserPicture.ImageLocation = this._log.LocationImage;

				this.ControlsVisible( true );
				this.ControlsEnabled( false );
				this.btnLogin.Enabled = false;
				this.pgsLoadDataDefault.Visible = false;

                this._tr.Start();
            }
            else
            {
				this.ControlsVisible( false );
				this.ControlsEnabled( false );
				this.btnLogin.Enabled = true;
				this.pgsLoadDataDefault.Visible = false;
            }
        }

        private void btnLogin_Click( object sender, EventArgs e )
        {
            frmLogIn frmlog = new frmLogIn( _data );
            frmlog.classLog = this._log;
            frmlog.Show();
            this.Close();
        }

        #endregion

        private void btnRegistrarAlumno_Click( object sender, EventArgs e )
        {
            Layouts.regAlumno.frmInitialMessage alumno = new Layouts.regAlumno.frmInitialMessage(_data);
            alumno.Show();
            this.Close();
        }

        private void btnLogOut_Click( object sender, EventArgs e )
        {
            DialogResult result = MetroMessageBox.Show( this, 
                "\nDeseas Realmente Cerrar Sesión? \n\n Pulsa OK para cerrar sesión...", 
                "Advertencia", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Exclamation );

            if ( result == DialogResult.Cancel )
                return;

            if( _log.SendLogOut() )
            {
                ControlsVisible(false);
            }
        }

        private void btnNewAcademyYear_Click( object sender, EventArgs e )
        {
            Layouts.prsApertura.frmInitialMessage frminitprs = new Layouts.prsApertura.frmInitialMessage( this._data );
            frminitprs.Show();
            this.Close();
        }
    }
}
