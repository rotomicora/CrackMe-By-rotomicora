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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneGradientButton1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 54);
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
            this.siticoneBorderlessForm1.DragEndTransparencyValue = 0.8D;
            this.siticoneBorderlessForm1.DragStartTransparencyValue = 0.7D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.ShadowColor = System.Drawing.Color.Indigo;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "CrackMe - By rotomicora#0001";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Indigo;
            this.status.Location = new System.Drawing.Point(148, 371);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(12, 18);
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
            this.siticoneControlBox1.Location = new System.Drawing.Point(317, 5);
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
            this.siticoneControlBox2.Location = new System.Drawing.Point(274, 5);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.PressedColor = System.Drawing.Color.Gray;
            this.siticoneControlBox2.Size = new System.Drawing.Size(37, 31);
            this.siticoneControlBox2.TabIndex = 13;
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.Animated = true;
            this.siticoneGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.BorderColor = System.Drawing.Color.Indigo;
            this.siticoneGradientButton1.BorderRadius = 6;
            this.siticoneGradientButton1.BorderThickness = 1;
            this.siticoneGradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.Indigo;
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.siticoneGradientButton1.FocusedColor = System.Drawing.Color.Fuchsia;
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.Black;
            this.siticoneGradientButton1.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.siticoneGradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneGradientButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.IndicateFocus = true;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(98, 303);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.PressedColor = System.Drawing.Color.Indigo;
            this.siticoneGradientButton1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneGradientButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneGradientButton1.TabIndex = 16;
            this.siticoneGradientButton1.Text = "Login";
            this.siticoneGradientButton1.UseTransparentBackground = true;
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Animated = true;
            this.siticoneTextBox1.BorderColor = System.Drawing.Color.Indigo;
            this.siticoneTextBox1.BorderRadius = 6;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Arial Black", 9F);
            this.siticoneTextBox1.ForeColor = System.Drawing.Color.Indigo;
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Location = new System.Drawing.Point(70, 259);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(229, 29);
            this.siticoneTextBox1.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.siticoneTextBox1.TabIndex = 17;
            this.siticoneTextBox1.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(167, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "KEY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(366, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneTextBox1);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrackMe ! By fran_afp_#0001";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
    }
}

