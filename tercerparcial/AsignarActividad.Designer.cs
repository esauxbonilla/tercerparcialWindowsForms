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
            this.gridviewAsignaciones = new System.Windows.Forms.DataGridView();
            this.txtactividadasignar = new System.Windows.Forms.TextBox();
            this.txtempleadoasignar = new System.Windows.Forms.TextBox();
            this.btnConsultarAsignaciones = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.comboBoxColaboradores = new System.Windows.Forms.ComboBox();
            this.comboBoxActividades = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewAsignaciones)).BeginInit();
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
            // gridviewAsignaciones
            // 
            this.gridviewAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewAsignaciones.Location = new System.Drawing.Point(46, 231);
            this.gridviewAsignaciones.Name = "gridviewAsignaciones";
            this.gridviewAsignaciones.Size = new System.Drawing.Size(742, 150);
            this.gridviewAsignaciones.TabIndex = 4;
            // 
            // txtactividadasignar
            // 
            this.txtactividadasignar.Location = new System.Drawing.Point(350, 142);
            this.txtactividadasignar.Name = "txtactividadasignar";
            this.txtactividadasignar.Size = new System.Drawing.Size(116, 20);
            this.txtactividadasignar.TabIndex = 5;
            // 
            // txtempleadoasignar
            // 
            this.txtempleadoasignar.Location = new System.Drawing.Point(350, 92);
            this.txtempleadoasignar.Name = "txtempleadoasignar";
            this.txtempleadoasignar.Size = new System.Drawing.Size(116, 20);
            this.txtempleadoasignar.TabIndex = 6;
            // 
            // btnConsultarAsignaciones
            // 
            this.btnConsultarAsignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAsignaciones.Location = new System.Drawing.Point(676, 169);
            this.btnConsultarAsignaciones.Name = "btnConsultarAsignaciones";
            this.btnConsultarAsignaciones.Size = new System.Drawing.Size(112, 47);
            this.btnConsultarAsignaciones.TabIndex = 7;
            this.btnConsultarAsignaciones.Text = "Consultar Asignadas";
            this.btnConsultarAsignaciones.UseVisualStyleBackColor = true;
            this.btnConsultarAsignaciones.Click += new System.EventHandler(this.btnConsultarAsignaciones_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(545, 169);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(112, 47);
            this.btnAsignar.TabIndex = 8;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // comboBoxColaboradores
            // 
            this.comboBoxColaboradores.FormattingEnabled = true;
            this.comboBoxColaboradores.Location = new System.Drawing.Point(163, 93);
            this.comboBoxColaboradores.Name = "comboBoxColaboradores";
            this.comboBoxColaboradores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColaboradores.TabIndex = 9;
            this.comboBoxColaboradores.SelectedIndexChanged += new System.EventHandler(this.comboBoxColaboradores_SelectedIndexChanged);
            // 
            // comboBoxActividades
            // 
            this.comboBoxActividades.FormattingEnabled = true;
            this.comboBoxActividades.Location = new System.Drawing.Point(163, 140);
            this.comboBoxActividades.Name = "comboBoxActividades";
            this.comboBoxActividades.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActividades.TabIndex = 10;
            // 
            // AsignarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 402);
            this.Controls.Add(this.comboBoxActividades);
            this.Controls.Add(this.comboBoxColaboradores);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnConsultarAsignaciones);
            this.Controls.Add(this.txtempleadoasignar);
            this.Controls.Add(this.txtactividadasignar);
            this.Controls.Add(this.gridviewAsignaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnvolverasignaractividad);
            this.Controls.Add(this.label1);
            this.Name = "AsignarActividad";
            this.Text = "AsignarActividad";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewAsignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvolverasignaractividad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridviewAsignaciones;
        private System.Windows.Forms.TextBox txtactividadasignar;
        private System.Windows.Forms.TextBox txtempleadoasignar;
        private System.Windows.Forms.Button btnConsultarAsignaciones;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.ComboBox comboBoxColaboradores;
        private System.Windows.Forms.ComboBox comboBoxActividades;
    }
}