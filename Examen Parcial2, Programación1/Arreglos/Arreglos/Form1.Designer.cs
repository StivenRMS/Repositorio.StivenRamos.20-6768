
namespace Arreglos
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonNames = new System.Windows.Forms.Button();
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.listBoxSumaExaamenes = new System.Windows.Forms.ListBox();
            this.labelMejorPro = new System.Windows.Forms.Label();
            this.listBoxParcial1 = new System.Windows.Forms.ListBox();
            this.listBoxParcial2 = new System.Windows.Forms.ListBox();
            this.listBoxParcial3 = new System.Windows.Forms.ListBox();
            this.listBoxSección = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PGA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.PGB = new System.Windows.Forms.Button();
            this.PGC = new System.Windows.Forms.Button();
            this.PGD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonArreglo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonArreglo.Location = new System.Drawing.Point(678, 105);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(98, 38);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Mejor Promedio";
            this.buttonArreglo.UseVisualStyleBackColor = false;
            this.buttonArreglo.Visible = false;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(12, 228);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(41, 173);
            this.listBoxResultado.TabIndex = 1;
            this.listBoxResultado.Visible = false;
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonCargar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCargar.Location = new System.Drawing.Point(202, 125);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(433, 38);
            this.buttonCargar.TabIndex = 3;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonNames
            // 
            this.buttonNames.BackColor = System.Drawing.Color.Red;
            this.buttonNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNames.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonNames.Location = new System.Drawing.Point(12, 407);
            this.buttonNames.Name = "buttonNames";
            this.buttonNames.Size = new System.Drawing.Size(167, 42);
            this.buttonNames.TabIndex = 4;
            this.buttonNames.Text = "Procesar";
            this.buttonNames.UseVisualStyleBackColor = false;
            this.buttonNames.Visible = false;
            this.buttonNames.Click += new System.EventHandler(this.buttonNames_Click);
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.Location = new System.Drawing.Point(58, 228);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(281, 173);
            this.listBoxNombres.TabIndex = 5;
            this.listBoxNombres.Visible = false;
            // 
            // listBoxSumaExaamenes
            // 
            this.listBoxSumaExaamenes.FormattingEnabled = true;
            this.listBoxSumaExaamenes.Location = new System.Drawing.Point(558, 228);
            this.listBoxSumaExaamenes.Name = "listBoxSumaExaamenes";
            this.listBoxSumaExaamenes.Size = new System.Drawing.Size(77, 173);
            this.listBoxSumaExaamenes.TabIndex = 6;
            this.listBoxSumaExaamenes.Visible = false;
            this.listBoxSumaExaamenes.SelectedIndexChanged += new System.EventHandler(this.listBoxSumaExaamenes_SelectedIndexChanged);
            // 
            // labelMejorPro
            // 
            this.labelMejorPro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMejorPro.Location = new System.Drawing.Point(676, 146);
            this.labelMejorPro.Name = "labelMejorPro";
            this.labelMejorPro.Size = new System.Drawing.Size(100, 44);
            this.labelMejorPro.TabIndex = 7;
            this.labelMejorPro.Text = "l";
            this.labelMejorPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMejorPro.Visible = false;
            // 
            // listBoxParcial1
            // 
            this.listBoxParcial1.FormattingEnabled = true;
            this.listBoxParcial1.Location = new System.Drawing.Point(345, 228);
            this.listBoxParcial1.Name = "listBoxParcial1";
            this.listBoxParcial1.Size = new System.Drawing.Size(65, 173);
            this.listBoxParcial1.TabIndex = 8;
            this.listBoxParcial1.Visible = false;
            // 
            // listBoxParcial2
            // 
            this.listBoxParcial2.FormattingEnabled = true;
            this.listBoxParcial2.Location = new System.Drawing.Point(416, 228);
            this.listBoxParcial2.Name = "listBoxParcial2";
            this.listBoxParcial2.Size = new System.Drawing.Size(65, 173);
            this.listBoxParcial2.TabIndex = 9;
            this.listBoxParcial2.Visible = false;
            // 
            // listBoxParcial3
            // 
            this.listBoxParcial3.FormattingEnabled = true;
            this.listBoxParcial3.Location = new System.Drawing.Point(487, 228);
            this.listBoxParcial3.Name = "listBoxParcial3";
            this.listBoxParcial3.Size = new System.Drawing.Size(65, 173);
            this.listBoxParcial3.TabIndex = 10;
            this.listBoxParcial3.Visible = false;
            // 
            // listBoxSección
            // 
            this.listBoxSección.FormattingEnabled = true;
            this.listBoxSección.Location = new System.Drawing.Point(654, 228);
            this.listBoxSección.Name = "listBoxSección";
            this.listBoxSección.Size = new System.Drawing.Size(65, 173);
            this.listBoxSección.TabIndex = 11;
            this.listBoxSección.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "No.";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Alumnos";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Parcial 1";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Parcial 2";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(487, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Parcial 3";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(558, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Par.";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(654, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Seccion";
            this.label7.Visible = false;
            // 
            // PGA
            // 
            this.PGA.BackColor = System.Drawing.SystemColors.WindowText;
            this.PGA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PGA.Location = new System.Drawing.Point(12, 38);
            this.PGA.Name = "PGA";
            this.PGA.Size = new System.Drawing.Size(98, 38);
            this.PGA.TabIndex = 19;
            this.PGA.Text = "Sección A";
            this.PGA.UseVisualStyleBackColor = false;
            this.PGA.Visible = false;
            this.PGA.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Navy;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(116, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Promedio General";
            this.label8.Visible = false;
            // 
            // PGB
            // 
            this.PGB.BackColor = System.Drawing.SystemColors.WindowText;
            this.PGB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PGB.Location = new System.Drawing.Point(119, 38);
            this.PGB.Name = "PGB";
            this.PGB.Size = new System.Drawing.Size(98, 38);
            this.PGB.TabIndex = 21;
            this.PGB.Text = "Sección B";
            this.PGB.UseVisualStyleBackColor = false;
            this.PGB.Visible = false;
            this.PGB.Click += new System.EventHandler(this.PGB_Click);
            // 
            // PGC
            // 
            this.PGC.BackColor = System.Drawing.SystemColors.WindowText;
            this.PGC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PGC.Location = new System.Drawing.Point(223, 38);
            this.PGC.Name = "PGC";
            this.PGC.Size = new System.Drawing.Size(98, 38);
            this.PGC.TabIndex = 22;
            this.PGC.Text = "Sección C";
            this.PGC.UseVisualStyleBackColor = false;
            this.PGC.Visible = false;
            this.PGC.Click += new System.EventHandler(this.PGC_Click);
            // 
            // PGD
            // 
            this.PGD.BackColor = System.Drawing.SystemColors.WindowText;
            this.PGD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PGD.Location = new System.Drawing.Point(327, 38);
            this.PGD.Name = "PGD";
            this.PGD.Size = new System.Drawing.Size(98, 38);
            this.PGD.TabIndex = 23;
            this.PGD.Text = "Sección D";
            this.PGD.UseVisualStyleBackColor = false;
            this.PGD.Visible = false;
            this.PGD.Click += new System.EventHandler(this.PGD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.PGD);
            this.Controls.Add(this.PGC);
            this.Controls.Add(this.PGB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PGA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSección);
            this.Controls.Add(this.listBoxParcial3);
            this.Controls.Add(this.listBoxParcial2);
            this.Controls.Add(this.listBoxParcial1);
            this.Controls.Add(this.labelMejorPro);
            this.Controls.Add(this.listBoxSumaExaamenes);
            this.Controls.Add(this.listBoxNombres);
            this.Controls.Add(this.buttonNames);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonNames;
        private System.Windows.Forms.ListBox listBoxNombres;
        private System.Windows.Forms.ListBox listBoxSumaExaamenes;
        private System.Windows.Forms.Label labelMejorPro;
        private System.Windows.Forms.ListBox listBoxParcial1;
        private System.Windows.Forms.ListBox listBoxParcial2;
        private System.Windows.Forms.ListBox listBoxParcial3;
        private System.Windows.Forms.ListBox listBoxSección;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button PGA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button PGB;
        private System.Windows.Forms.Button PGC;
        private System.Windows.Forms.Button PGD;
    }
}

