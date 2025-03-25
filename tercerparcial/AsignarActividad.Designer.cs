namespace tercerparcial
{
    partial class AsignarActividad
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnvolverasignaractividad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridviewconsultaractividad = new System.Windows.Forms.DataGridView();
            this.txtactividadasignar = new System.Windows.Forms.TextBox();
            this.txtempleadoasignar = new System.Windows.Forms.TextBox();
            this.btnconsultarasignadas = new System.Windows.Forms.Button();
            this.btnasigmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewconsultaractividad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignar Actividad";
            // 
            // btnvolverasignaractividad
            // 
            this.btnvolverasignaractividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolverasignaractividad.Location = new System.Drawing.Point(676, 12);
            this.btnvolverasignaractividad.Name = "btnvolverasignaractividad";
            this.btnvolverasignaractividad.Size = new System.Drawing.Size(112, 40);
            this.btnvolverasignaractividad.TabIndex = 1;
            this.btnvolverasignaractividad.Text = "Vovler";
            this.btnvolverasignaractividad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Empleado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id Actividad";
            // 
            // gridviewconsultaractividad
            // 
            this.gridviewconsultaractividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewconsultaractividad.Location = new System.Drawing.Point(46, 231);
            this.gridviewconsultaractividad.Name = "gridviewconsultaractividad";
            this.gridviewconsultaractividad.Size = new System.Drawing.Size(742, 150);
            this.gridviewconsultaractividad.TabIndex = 4;
            // 
            // txtactividadasignar
            // 
            this.txtactividadasignar.Location = new System.Drawing.Point(195, 139);
            this.txtactividadasignar.Name = "txtactividadasignar";
            this.txtactividadasignar.Size = new System.Drawing.Size(116, 20);
            this.txtactividadasignar.TabIndex = 5;
            // 
            // txtempleadoasignar
            // 
            this.txtempleadoasignar.Location = new System.Drawing.Point(195, 92);
            this.txtempleadoasignar.Name = "txtempleadoasignar";
            this.txtempleadoasignar.Size = new System.Drawing.Size(116, 20);
            this.txtempleadoasignar.TabIndex = 6;
            // 
            // btnconsultarasignadas
            // 
            this.btnconsultarasignadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultarasignadas.Location = new System.Drawing.Point(676, 169);
            this.btnconsultarasignadas.Name = "btnconsultarasignadas";
            this.btnconsultarasignadas.Size = new System.Drawing.Size(112, 47);
            this.btnconsultarasignadas.TabIndex = 7;
            this.btnconsultarasignadas.Text = "Consultar Asignadas";
            this.btnconsultarasignadas.UseVisualStyleBackColor = true;
            // 
            // btnasigmar
            // 
            this.btnasigmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnasigmar.Location = new System.Drawing.Point(545, 169);
            this.btnasigmar.Name = "btnasigmar";
            this.btnasigmar.Size = new System.Drawing.Size(112, 47);
            this.btnasigmar.TabIndex = 8;
            this.btnasigmar.Text = "Asignar";
            this.btnasigmar.UseVisualStyleBackColor = true;
            // 
            // AsignarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 402);
            this.Controls.Add(this.btnasigmar);
            this.Controls.Add(this.btnconsultarasignadas);
            this.Controls.Add(this.txtempleadoasignar);
            this.Controls.Add(this.txtactividadasignar);
            this.Controls.Add(this.gridviewconsultaractividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnvolverasignaractividad);
            this.Controls.Add(this.label1);
            this.Name = "AsignarActividad";
            this.Text = "AsignarActividad";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewconsultaractividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvolverasignaractividad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridviewconsultaractividad;
        private System.Windows.Forms.TextBox txtactividadasignar;
        private System.Windows.Forms.TextBox txtempleadoasignar;
        private System.Windows.Forms.Button btnconsultarasignadas;
        private System.Windows.Forms.Button btnasigmar;
    }
}