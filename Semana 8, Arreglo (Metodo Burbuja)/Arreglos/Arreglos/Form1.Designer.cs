
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.buttonDatos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.labelp1 = new System.Windows.Forms.Label();
            this.labelp2 = new System.Windows.Forms.Label();
            this.labelp3 = new System.Windows.Forms.Label();
            this.listBoxPromedio = new System.Windows.Forms.ListBox();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.listBoxOrdenado = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArreglo.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonArreglo.Location = new System.Drawing.Point(433, 143);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(89, 39);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Promedios";
            this.buttonArreglo.UseVisualStyleBackColor = false;
            this.buttonArreglo.Visible = false;
            this.buttonArreglo.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(126, 44);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(396, 95);
            this.listBoxResultado.TabIndex = 1;
            this.listBoxResultado.Visible = false;
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCargarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarArchivo.Location = new System.Drawing.Point(163, 143);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(596, 135);
            this.buttonCargarArchivo.TabIndex = 3;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = false;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // buttonDatos
            // 
            this.buttonDatos.BackColor = System.Drawing.Color.Black;
            this.buttonDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatos.ForeColor = System.Drawing.Color.White;
            this.buttonDatos.Location = new System.Drawing.Point(12, 45);
            this.buttonDatos.Name = "buttonDatos";
            this.buttonDatos.Size = new System.Drawing.Size(89, 63);
            this.buttonDatos.TabIndex = 4;
            this.buttonDatos.Text = "Datos";
            this.buttonDatos.UseVisualStyleBackColor = false;
            this.buttonDatos.Visible = false;
            this.buttonDatos.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(528, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(87, 95);
            this.listBox1.TabIndex = 5;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(621, 45);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(87, 95);
            this.listBox2.TabIndex = 6;
            this.listBox2.Visible = false;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(714, 45);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(87, 95);
            this.listBox3.TabIndex = 7;
            this.listBox3.Visible = false;
            // 
            // labelp1
            // 
            this.labelp1.BackColor = System.Drawing.Color.Gray;
            this.labelp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelp1.Location = new System.Drawing.Point(528, 151);
            this.labelp1.Name = "labelp1";
            this.labelp1.Size = new System.Drawing.Size(87, 31);
            this.labelp1.TabIndex = 8;
            this.labelp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelp1.Visible = false;
            this.labelp1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelp2
            // 
            this.labelp2.BackColor = System.Drawing.Color.Gray;
            this.labelp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelp2.Location = new System.Drawing.Point(621, 151);
            this.labelp2.Name = "labelp2";
            this.labelp2.Size = new System.Drawing.Size(87, 31);
            this.labelp2.TabIndex = 9;
            this.labelp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelp2.Visible = false;
            // 
            // labelp3
            // 
            this.labelp3.BackColor = System.Drawing.Color.Gray;
            this.labelp3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelp3.Location = new System.Drawing.Point(714, 151);
            this.labelp3.Name = "labelp3";
            this.labelp3.Size = new System.Drawing.Size(87, 31);
            this.labelp3.TabIndex = 10;
            this.labelp3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelp3.Visible = false;
            // 
            // listBoxPromedio
            // 
            this.listBoxPromedio.FormattingEnabled = true;
            this.listBoxPromedio.Location = new System.Drawing.Point(807, 58);
            this.listBoxPromedio.Name = "listBoxPromedio";
            this.listBoxPromedio.Size = new System.Drawing.Size(87, 82);
            this.listBoxPromedio.TabIndex = 11;
            this.listBoxPromedio.Visible = false;
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrdenar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonOrdenar.Location = new System.Drawing.Point(237, 252);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(346, 61);
            this.buttonOrdenar.TabIndex = 12;
            this.buttonOrdenar.Text = "Ordenar Nombres";
            this.buttonOrdenar.UseVisualStyleBackColor = false;
            this.buttonOrdenar.Visible = false;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // listBoxOrdenado
            // 
            this.listBoxOrdenado.FormattingEnabled = true;
            this.listBoxOrdenado.Location = new System.Drawing.Point(12, 319);
            this.listBoxOrdenado.Name = "listBoxOrdenado";
            this.listBoxOrdenado.Size = new System.Drawing.Size(801, 95);
            this.listBoxOrdenado.TabIndex = 13;
            this.listBoxOrdenado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Promedio";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxOrdenado);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.listBoxPromedio);
            this.Controls.Add(this.labelp3);
            this.Controls.Add(this.labelp2);
            this.Controls.Add(this.labelp1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDatos);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.Button buttonDatos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label labelp1;
        private System.Windows.Forms.Label labelp2;
        private System.Windows.Forms.Label labelp3;
        private System.Windows.Forms.ListBox listBoxPromedio;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.ListBox listBoxOrdenado;
        private System.Windows.Forms.Label label1;
    }
}

