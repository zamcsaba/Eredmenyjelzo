namespace Eredmenyjelzo.Client.Forms
{
    partial class frmMenu
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
            this.btnRopi = new System.Windows.Forms.Button();
            this.btnKosar = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnFoci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRopi
            // 
            this.btnRopi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRopi.Location = new System.Drawing.Point(13, 13);
            this.btnRopi.Name = "btnRopi";
            this.btnRopi.Size = new System.Drawing.Size(95, 36);
            this.btnRopi.TabIndex = 0;
            this.btnRopi.Text = "Röplabda";
            this.btnRopi.UseVisualStyleBackColor = true;
            this.btnRopi.Click += new System.EventHandler(this.btnRopi_Click);
            // 
            // btnKosar
            // 
            this.btnKosar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKosar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKosar.Location = new System.Drawing.Point(122, 13);
            this.btnKosar.Name = "btnKosar";
            this.btnKosar.Size = new System.Drawing.Size(95, 36);
            this.btnKosar.TabIndex = 1;
            this.btnKosar.Text = "Kosárlabda";
            this.btnKosar.UseVisualStyleBackColor = true;
            this.btnKosar.Click += new System.EventHandler(this.btnKosar_Click);
            // 
            // btnOther
            // 
            this.btnOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(122, 61);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(95, 36);
            this.btnOther.TabIndex = 3;
            this.btnOther.Text = "Egyéb";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnFoci
            // 
            this.btnFoci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoci.Location = new System.Drawing.Point(13, 61);
            this.btnFoci.Name = "btnFoci";
            this.btnFoci.Size = new System.Drawing.Size(95, 36);
            this.btnFoci.TabIndex = 2;
            this.btnFoci.Text = "Foci";
            this.btnFoci.UseVisualStyleBackColor = true;
            this.btnFoci.Click += new System.EventHandler(this.btnFoci_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 111);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnFoci);
            this.Controls.Add(this.btnKosar);
            this.Controls.Add(this.btnRopi);
            this.Name = "frmMenu";
            this.Text = "Főmenü";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRopi;
        private System.Windows.Forms.Button btnKosar;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnFoci;
    }
}

