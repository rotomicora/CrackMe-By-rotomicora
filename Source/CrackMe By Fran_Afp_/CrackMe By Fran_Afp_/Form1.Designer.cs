namespace CrackMe_By_Fran_Afp_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.BorderRadius = 20;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.DragEndTransparencyValue = 0.9D;
            this.siticoneBorderlessForm1.DragStartTransparencyValue = 0.8D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CrackMe! By fran_afp_#0001";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 307);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(10, 13);
            this.status.TabIndex = 5;
            this.status.Text = " ";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 12;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(313, 9);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.PressedColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.Size = new System.Drawing.Size(37, 31);
            this.siticoneControlBox1.TabIndex = 12;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 12;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(270, 9);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.PressedColor = System.Drawing.Color.Gray;
            this.siticoneControlBox2.Size = new System.Drawing.Size(37, 31);
            this.siticoneControlBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(362, 329);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CrackMe ! By fran_afp_#0001";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
    }
}

