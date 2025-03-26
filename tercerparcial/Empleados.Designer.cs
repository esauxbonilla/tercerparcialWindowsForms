namespace tercerparcial
{
    partial class Empleados
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
            this.btnasignadascolaborador = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.btnentregar = new System.Windows.Forms.Button();
            this.btnvolvercolaborador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colaborador";
            // 
            // btnasignadascolaborador
            // 
            this.btnasignadascolaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnasignadascolaborador.Location = new System.Drawing.Point(19, 84);
            this.btnasignadascolaborador.Name = "btnasignadascolaborador";
            this.btnasignadascolaborador.Size = new System.Drawing.Size(95, 48);
            this.btnasignadascolaborador.TabIndex = 2;
            this.btnasignadascolaborador.Text = "Actividades Asignadas";
            this.btnasignadascolaborador.UseVisualStyleBackColor = true;
            this.btnasignadascolaborador.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(143, 84);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(547, 127);
            this.gridview.TabIndex = 3;
            // 
            // btnentregar
            // 
            this.btnentregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentregar.Location = new System.Drawing.Point(19, 163);
            this.btnentregar.Name = "btnentregar";
            this.btnentregar.Size = new System.Drawing.Size(95, 48);
            this.btnentregar.TabIndex = 4;
            this.btnentregar.Text = "Entregar Actividad";
            this.btnentregar.UseVisualStyleBackColor = true;
            // 
            // btnvolvercolaborador
            // 
            this.btnvolvercolaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolvercolaborador.Location = new System.Drawing.Point(598, 9);
            this.btnvolvercolaborador.Name = "btnvolvercolaborador";
            this.btnvolvercolaborador.Size = new System.Drawing.Size(92, 45);
            this.btnvolvercolaborador.TabIndex = 5;
            this.btnvolvercolaborador.Text = "Volver";
            this.btnvolvercolaborador.UseVisualStyleBackColor = true;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 241);
            this.Controls.Add(this.btnvolvercolaborador);
            this.Controls.Add(this.btnentregar);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.btnasignadascolaborador);
            this.Controls.Add(this.label1);
            this.Name = "Empleados";
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnasignadascolaborador;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button btnentregar;
        private System.Windows.Forms.Button btnvolvercolaborador;
    }
}