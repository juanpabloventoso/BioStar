namespace BioStarCSharp
{
    partial class frmTomarHuella
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
            this.label12 = new System.Windows.Forms.Label();
            this.edtDedo2Checksum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edtDedos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.edtDedo1Checksum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Dedo 2:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Visible = false;
            // 
            // edtDedo2Checksum
            // 
            this.edtDedo2Checksum.Location = new System.Drawing.Point(183, 144);
            this.edtDedo2Checksum.Name = "edtDedo2Checksum";
            this.edtDedo2Checksum.ReadOnly = true;
            this.edtDedo2Checksum.Size = new System.Drawing.Size(213, 21);
            this.edtDedo2Checksum.TabIndex = 48;
            this.edtDedo2Checksum.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Dedo 1:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Visible = false;
            // 
            // edtDedos
            // 
            this.edtDedos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDedos.Location = new System.Drawing.Point(134, 28);
            this.edtDedos.Name = "edtDedos";
            this.edtDedos.Size = new System.Drawing.Size(44, 21);
            this.edtDedos.TabIndex = 46;
            this.edtDedos.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Dedos:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtDedo1Checksum
            // 
            this.edtDedo1Checksum.Location = new System.Drawing.Point(183, 106);
            this.edtDedo1Checksum.Name = "edtDedo1Checksum";
            this.edtDedo1Checksum.ReadOnly = true;
            this.edtDedo1Checksum.Size = new System.Drawing.Size(213, 21);
            this.edtDedo1Checksum.TabIndex = 44;
            this.edtDedo1Checksum.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Tomar huellas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(291, 181);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 23);
            this.btnAceptar.TabIndex = 50;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // frmTomarHuella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 229);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.edtDedo2Checksum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.edtDedos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.edtDedo1Checksum);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTomarHuella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huellas digitales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox edtDedo2Checksum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edtDedos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtDedo1Checksum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
    }
}