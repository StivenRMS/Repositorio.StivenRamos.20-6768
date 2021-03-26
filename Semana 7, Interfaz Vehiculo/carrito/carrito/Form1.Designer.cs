
namespace carrito
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonBMW = new System.Windows.Forms.Button();
            this.buttonALTOTOTAL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonFreno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelNVel = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Carrito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(512, 128);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(10, 15);
            this.labelEstado.TabIndex = 1;
            this.labelEstado.Text = "l";
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.Transparent;
            this.buttonEncender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEncender.BackgroundImage")));
            this.buttonEncender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEncender.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEncender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonEncender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonEncender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncender.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEncender.Location = new System.Drawing.Point(794, 0);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(49, 34);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Visible = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAcelerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAcelerar.BackgroundImage")));
            this.buttonAcelerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAcelerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcelerar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAcelerar.Location = new System.Drawing.Point(341, 203);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(102, 146);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Visible = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEstadoVelocidad.ForeColor = System.Drawing.Color.Blue;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(296, 99);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(15, 21);
            this.labelEstadoVelocidad.TabIndex = 4;
            this.labelEstadoVelocidad.Text = "l";
            this.labelEstadoVelocidad.Visible = false;
            // 
            // buttonBMW
            // 
            this.buttonBMW.Location = new System.Drawing.Point(799, 61);
            this.buttonBMW.Name = "buttonBMW";
            this.buttonBMW.Size = new System.Drawing.Size(44, 23);
            this.buttonBMW.TabIndex = 5;
            this.buttonBMW.Text = "BMW";
            this.buttonBMW.UseVisualStyleBackColor = true;
            this.buttonBMW.Visible = false;
            this.buttonBMW.Click += new System.EventHandler(this.buttonBMW_Click);
            // 
            // buttonALTOTOTAL
            // 
            this.buttonALTOTOTAL.BackColor = System.Drawing.Color.Transparent;
            this.buttonALTOTOTAL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonALTOTOTAL.BackgroundImage")));
            this.buttonALTOTOTAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonALTOTOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonALTOTOTAL.ForeColor = System.Drawing.Color.Transparent;
            this.buttonALTOTOTAL.Location = new System.Drawing.Point(498, 296);
            this.buttonALTOTOTAL.Name = "buttonALTOTOTAL";
            this.buttonALTOTOTAL.Size = new System.Drawing.Size(117, 90);
            this.buttonALTOTOTAL.TabIndex = 6;
            this.buttonALTOTOTAL.UseVisualStyleBackColor = false;
            this.buttonALTOTOTAL.Visible = false;
            this.buttonALTOTOTAL.Click += new System.EventHandler(this.buttonALTOTOTAL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 203);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonFreno
            // 
            this.buttonFreno.BackColor = System.Drawing.Color.Transparent;
            this.buttonFreno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFreno.BackgroundImage")));
            this.buttonFreno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFreno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFreno.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFreno.Location = new System.Drawing.Point(232, 203);
            this.buttonFreno.Name = "buttonFreno";
            this.buttonFreno.Size = new System.Drawing.Size(103, 146);
            this.buttonFreno.TabIndex = 8;
            this.buttonFreno.UseVisualStyleBackColor = false;
            this.buttonFreno.Visible = false;
            this.buttonFreno.Click += new System.EventHandler(this.buttonFreno_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(480, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 87);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelNVel
            // 
            this.labelNVel.AutoSize = true;
            this.labelNVel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNVel.ForeColor = System.Drawing.Color.Red;
            this.labelNVel.Location = new System.Drawing.Point(273, 77);
            this.labelNVel.Name = "labelNVel";
            this.labelNVel.Size = new System.Drawing.Size(15, 21);
            this.labelNVel.TabIndex = 10;
            this.labelNVel.Text = "l";
            this.labelNVel.Visible = false;
            this.labelNVel.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPlay.Location = new System.Drawing.Point(672, 175);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(33, 19);
            this.buttonPlay.TabIndex = 11;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Visible = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop.BackgroundImage")));
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.Color.Transparent;
            this.stop.Location = new System.Drawing.Point(702, 175);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(33, 19);
            this.stop.TabIndex = 12;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(843, 388);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelNVel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonFreno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonALTOTOTAL);
            this.Controls.Add(this.buttonBMW);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonBMW;
        private System.Windows.Forms.Button buttonALTOTOTAL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonFreno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelNVel;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button stop;
    }
}

