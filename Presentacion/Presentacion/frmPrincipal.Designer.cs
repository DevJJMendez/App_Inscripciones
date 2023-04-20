namespace Presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.ptbCandidatos = new System.Windows.Forms.PictureBox();
            this.ptbInscripciones = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCandidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo Principal";
            // 
            // ptbCandidatos
            // 
            this.ptbCandidatos.Image = ((System.Drawing.Image)(resources.GetObject("ptbCandidatos.Image")));
            this.ptbCandidatos.Location = new System.Drawing.Point(12, 73);
            this.ptbCandidatos.Name = "ptbCandidatos";
            this.ptbCandidatos.Size = new System.Drawing.Size(128, 128);
            this.ptbCandidatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbCandidatos.TabIndex = 1;
            this.ptbCandidatos.TabStop = false;
            this.ptbCandidatos.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptbInscripciones
            // 
            this.ptbInscripciones.Image = ((System.Drawing.Image)(resources.GetObject("ptbInscripciones.Image")));
            this.ptbInscripciones.Location = new System.Drawing.Point(165, 73);
            this.ptbInscripciones.Name = "ptbInscripciones";
            this.ptbInscripciones.Size = new System.Drawing.Size(128, 128);
            this.ptbInscripciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbInscripciones.TabIndex = 2;
            this.ptbInscripciones.TabStop = false;
            this.ptbInscripciones.Click += new System.EventHandler(this.ptbInscripciones_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(317, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pbxSalir
            // 
            this.pbxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalir.Image")));
            this.pbxSalir.Location = new System.Drawing.Point(467, 73);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(128, 128);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxSalir.TabIndex = 4;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "SENA - Colombia - 2023";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxSalir);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ptbInscripciones);
            this.Controls.Add(this.ptbCandidatos);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCandidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbCandidatos;
        private System.Windows.Forms.PictureBox ptbInscripciones;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.Label label2;
    }
}