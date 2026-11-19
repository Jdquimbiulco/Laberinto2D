namespace WinAppLaberynth
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
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBeginnerAutomatic = new System.Windows.Forms.Button();
            this.btnBeginnerManual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.button1);
            this.grbMenu.Controls.Add(this.btnExit);
            this.grbMenu.Controls.Add(this.btnBeginnerAutomatic);
            this.grbMenu.Controls.Add(this.btnBeginnerManual);
            this.grbMenu.Location = new System.Drawing.Point(14, 17);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(427, 246);
            this.grbMenu.TabIndex = 0;
            this.grbMenu.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(396, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBeginnerAutomatic
            // 
            this.btnBeginnerAutomatic.Location = new System.Drawing.Point(16, 72);
            this.btnBeginnerAutomatic.Name = "btnBeginnerAutomatic";
            this.btnBeginnerAutomatic.Size = new System.Drawing.Size(396, 51);
            this.btnBeginnerAutomatic.TabIndex = 1;
            this.btnBeginnerAutomatic.Text = "Laberinto Nivel Principiante Automático (Regla de la Mano Derecha)";
            this.btnBeginnerAutomatic.UseVisualStyleBackColor = true;
            this.btnBeginnerAutomatic.Click += new System.EventHandler(this.btnBeginnerAutomatic_Click);
            // 
            // btnBeginnerManual
            // 
            this.btnBeginnerManual.Location = new System.Drawing.Point(16, 21);
            this.btnBeginnerManual.Name = "btnBeginnerManual";
            this.btnBeginnerManual.Size = new System.Drawing.Size(396, 45);
            this.btnBeginnerManual.TabIndex = 0;
            this.btnBeginnerManual.Text = "Laberinto Nivel Principiante Manual";
            this.btnBeginnerManual.UseVisualStyleBackColor = true;
            this.btnBeginnerManual.Click += new System.EventHandler(this.btnBeginnerManual_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Laberinto Nivel Principiante Automático (Regla de la Mano Izquierda)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 274);
            this.Controls.Add(this.grbMenu);
            this.Name = "frmMenu";
            this.Text = "Menú principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button btnBeginnerAutomatic;
        private System.Windows.Forms.Button btnBeginnerManual;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}