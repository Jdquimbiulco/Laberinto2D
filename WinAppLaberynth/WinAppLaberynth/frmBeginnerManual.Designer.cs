namespace WinAppLaberynth
{
    partial class frmBeginnerManual
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeginnerManual));
            this.picCheese = new System.Windows.Forms.PictureBox();
            this.picWalker = new System.Windows.Forms.PictureBox();
            this.picMouse = new System.Windows.Forms.PictureBox();
            this.picLaberynth = new System.Windows.Forms.PictureBox();
            this.txtData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaberynth)).BeginInit();
            this.SuspendLayout();
            // 
            // picCheese
            // 
            this.picCheese.Image = global::WinAppLaberynth.Properties.Resources.ima_queso;
            this.picCheese.Location = new System.Drawing.Point(528, 498);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(75, 75);
            this.picCheese.TabIndex = 15;
            this.picCheese.TabStop = false;
            // 
            // picWalker
            // 
            this.picWalker.Image = ((System.Drawing.Image)(resources.GetObject("picWalker.Image")));
            this.picWalker.Location = new System.Drawing.Point(192, 43);
            this.picWalker.Name = "picWalker";
            this.picWalker.Size = new System.Drawing.Size(25, 25);
            this.picWalker.TabIndex = 14;
            this.picWalker.TabStop = false;
            this.picWalker.Click += new System.EventHandler(this.picWalker_Click);
            // 
            // picMouse
            // 
            this.picMouse.Image = global::WinAppLaberynth.Properties.Resources.raton_perez;
            this.picMouse.Location = new System.Drawing.Point(62, 13);
            this.picMouse.Name = "picMouse";
            this.picMouse.Size = new System.Drawing.Size(75, 105);
            this.picMouse.TabIndex = 13;
            this.picMouse.TabStop = false;
            // 
            // picLaberynth
            // 
            this.picLaberynth.Image = global::WinAppLaberynth.Properties.Resources.Laberinto1;
            this.picLaberynth.Location = new System.Drawing.Point(141, 17);
            this.picLaberynth.Name = "picLaberynth";
            this.picLaberynth.Size = new System.Drawing.Size(475, 475);
            this.picLaberynth.TabIndex = 12;
            this.picLaberynth.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(717, 119);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(236, 214);
            this.txtData.TabIndex = 16;
            // 
            // frmBeginnerManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 585);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.picCheese);
            this.Controls.Add(this.picWalker);
            this.Controls.Add(this.picMouse);
            this.Controls.Add(this.picLaberynth);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBeginnerManual";
            this.Text = "Laberinto Principiante";
            this.Load += new System.EventHandler(this.frmLaberynth_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLaberynth_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaberynth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.PictureBox picWalker;
        private System.Windows.Forms.PictureBox picMouse;
        private System.Windows.Forms.PictureBox picLaberynth;
        private System.Windows.Forms.TextBox txtData;
    }
}

