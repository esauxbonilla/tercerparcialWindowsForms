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
            this.gridview = new System.Windows.Forms.DataGridView();
            this.btnEntregarActividad = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnActividadesAsignadas = new System.Windows.Forms.Button();
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
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(143, 84);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(547, 127);
            this.gridview.TabIndex = 3;
            // 
            // btnEntregarActividad
            // 
            this.btnEntregarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregarActividad.Location = new System.Drawing.Point(19, 163);
            this.btnEntregarActividad.Name = "btnEntregarActividad";
            this.btnEntregarActividad.Size = new System.Drawing.Size(95, 48);
            this.btnEntregarActividad.TabIndex = 4;
            this.btnEntregarActividad.Text = "Entregar Actividad";
            this.btnEntregarActividad.UseVisualStyleBackColor = true;
            this.btnEntregarActividad.Click += new System.EventHandler(this.btnEntregarActividad_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(598, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 45);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnActividadesAsignadas
            // 
            this.btnActividadesAsignadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividadesAsignadas.Location = new System.Drawing.Point(19, 103);
            this.btnActividadesAsignadas.Name = "btnActividadesAsignadas";
            this.btnActividadesAsignadas.Size = new System.Drawing.Size(95, 54);
            this.btnActividadesAsignadas.TabIndex = 6;
            this.btnActividadesAsignadas.Text = "Actividades Asignadas";
            this.btnActividadesAsignadas.UseVisualStyleBackColor = true;
            this.btnActividadesAsignadas.Click += new System.EventHandler(this.btnActividadesAsignadas_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 241);
            this.Controls.Add(this.btnActividadesAsignadas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEntregarActividad);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.label1);
            this.Name = "Empleados";
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button btnEntregarActividad;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnActividadesAsignadas;
    }
}