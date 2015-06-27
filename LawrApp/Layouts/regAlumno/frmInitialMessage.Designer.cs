namespace LawrApp.Layouts.regAlumno
{
    partial class frmInitialMessage
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
            this.btnMessageContinue = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnMessageContinue
            // 
            this.btnMessageContinue.Location = new System.Drawing.Point(398, 389);
            this.btnMessageContinue.Name = "btnMessageContinue";
            this.btnMessageContinue.Size = new System.Drawing.Size(97, 36);
            this.btnMessageContinue.TabIndex = 3;
            this.btnMessageContinue.Text = "Continuar";
            this.btnMessageContinue.UseSelectable = true;
            this.btnMessageContinue.Click += new System.EventHandler(this.btnMessageContinue_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(30, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(465, 260);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Bievenido al asistente de procesos, para el registro del alumno";
            this.metroLabel1.WrapToLine = true;
            // 
            // frmInitialMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 459);
            this.Controls.Add(this.btnMessageContinue);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 459);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(525, 459);
            this.Name = "frmInitialMessage";
            this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Registrar Alumno";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnMessageContinue;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}