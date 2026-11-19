namespace WinAppLaberynth
{
    partial class frmBeginnerAutomaticRight
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeginnerAutomaticRight));
            this.txtData = new System.Windows.Forms.TextBox();
            this.picCheese = new System.Windows.Forms.PictureBox();
            this.picWalker = new System.Windows.Forms.PictureBox();
            this.picMouse = new System.Windows.Forms.PictureBox();
            this.picLaberynth = new System.Windows.Forms.PictureBox();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.tmrBeginner = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaberynth)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(691, 132);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(236, 214);
            this.txtData.TabIndex = 21;
            // 
            // picCheese
            // 
            this.picCheese.Image = global::WinAppLaberynth.Properties.Resources.ima_queso;
            this.picCheese.Location = new System.Drawing.Point(528, 498);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(75, 75);
            this.picCheese.TabIndex = 20;
            this.picCheese.TabStop = false;
            // 
            // picWalker
            // 
            this.picWalker.Image = ((System.Drawing.Image)(resources.GetObject("picWalker.Image")));
            this.picWalker.Location = new System.Drawing.Point(192, 43);
            this.picWalker.Name = "picWalker";
            this.picWalker.Size = new System.Drawing.Size(25, 25);
            this.picWalker.TabIndex = 19;
            this.picWalker.TabStop = false;
            // 
            // picMouse
            // 
            this.picMouse.Image = global::WinAppLaberynth.Properties.Resources.raton_perez;
            this.picMouse.Location = new System.Drawing.Point(62, 13);
            this.picMouse.Name = "picMouse";
            this.picMouse.Size = new System.Drawing.Size(75, 105);
            this.picMouse.TabIndex = 18;
            this.picMouse.TabStop = false;
            // 
            // picLaberynth
            // 
            this.picLaberynth.Image = global::WinAppLaberynth.Properties.Resources.Laberinto1;
            this.picLaberynth.Location = new System.Drawing.Point(141, 17);
            this.picLaberynth.Name = "picLaberynth";
            this.picLaberynth.Size = new System.Drawing.Size(475, 475);
            this.picLaberynth.TabIndex = 17;
            this.picLaberynth.TabStop = false;
            // 
            // txtDirection
            // 
            this.txtDirection.Location = new System.Drawing.Point(13, 243);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(100, 20);
            this.txtDirection.TabIndex = 24;
            this.txtDirection.Visible = false;
            this.txtDirection.TextChanged += new System.EventHandler(this.txtDirection_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(20, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 42);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(20, 132);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(90, 42);
            this.btnSolve.TabIndex = 22;
            this.btnSolve.Text = "Resolver";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // tmrBeginner
            // 
            this.tmrBeginner.Interval = 50;
            this.tmrBeginner.Tick += new System.EventHandler(this.tmrBeginner_Tick);
            // 
            // frmBeginnerAutomatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 585);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.picCheese);
            this.Controls.Add(this.picWalker);
            this.Controls.Add(this.picMouse);
            this.Controls.Add(this.picLaberynth);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBeginnerAutomatic";
            this.Text = "Laberinto Principiante";
            this.Load += new System.EventHandler(this.frmBeginnerAutomatic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaberynth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.PictureBox picWalker;
        private System.Windows.Forms.PictureBox picMouse;
        private System.Windows.Forms.PictureBox picLaberynth;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Timer tmrBeginner;
    }
}