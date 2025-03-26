namespace tercerparcial
{
    partial class EncargadoDepartamento
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
            this.btncrearactividad = new System.Windows.Forms.Button();
            this.btnconsultarentregas = new System.Windows.Forms.Button();
            this.btnasignaractividad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridviewencargado = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAccionesProyecto = new System.Windows.Forms.Button();
            this.parcial3DataSet1 = new tercerparcial.parcial3DataSet();
            this.btnvolverencargado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewencargado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcial3DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encargado De Departamento";
            // 
            // btncrearactividad
            // 
            this.btncrearactividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearactividad.Location = new System.Drawing.Point(33, 140);
            this.btncrearactividad.Name = "btncrearactividad";
            this.btncrearactividad.Size = new System.Drawing.Size(119, 44);
            this.btncrearactividad.TabIndex = 1;
            this.btncrearactividad.Text = "Acciones Actividad";
            this.btncrearactividad.UseVisualStyleBackColor = true;
            this.btncrearactividad.Click += new System.EventHandler(this.btncrearactividad_Click);
            // 
            // btnconsultarentregas
            // 
            this.btnconsultarentregas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultarentregas.Location = new System.Drawing.Point(423, 140);
            this.btnconsultarentregas.Name = "btnconsultarentregas";
            this.btnconsultarentregas.Size = new System.Drawing.Size(119, 45);
            this.btnconsultarentregas.TabIndex = 2;
            this.btnconsultarentregas.Text = "Consultar Entregas";
            this.btnconsultarentregas.UseVisualStyleBackColor = true;
            this.btnconsultarentregas.Click += new System.EventHandler(this.btnconsultarentregas_Click);
            // 
            // btnasignaractividad
            // 
            this.btnasignaractividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnasignaractividad.Location = new System.Drawing.Point(33, 202);
            this.btnasignaractividad.Name = "btnasignaractividad";
            this.btnasignaractividad.Size = new System.Drawing.Size(119, 46);
            this.btnasignaractividad.TabIndex = 3;
            this.btnasignaractividad.Text = "Asignar Actividad";
            this.btnasignaractividad.UseVisualStyleBackColor = true;
            this.btnasignaractividad.Click += new System.EventHandler(this.btnasignaractividad_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Actividades";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entregas";
            // 
            // gridviewencargado
            // 
            this.gridviewencargado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewencargado.Location = new System.Drawing.Point(569, 140);
            this.gridviewencargado.Name = "gridviewencargado";
            this.gridviewencargado.Size = new System.Drawing.Size(627, 108);
            this.gridviewencargado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Proyectos";
            // 
            // btnAccionesProyecto
            // 
            this.btnAccionesProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccionesProyecto.Location = new System.Drawing.Point(224, 140);
            this.btnAccionesProyecto.Name = "btnAccionesProyecto";
            this.btnAccionesProyecto.Size = new System.Drawing.Size(119, 45);
            this.btnAccionesProyecto.TabIndex = 12;
            this.btnAccionesProyecto.Text = "Acciones proyecto";
            this.btnAccionesProyecto.UseVisualStyleBackColor = true;
            this.btnAccionesProyecto.Click += new System.EventHandler(this.btnAccionesProyecto_Click);
            // 
            // parcial3DataSet1
            // 
            this.parcial3DataSet1.DataSetName = "parcial3DataSet";
            this.parcial3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnvolverencargado
            // 
            this.btnvolverencargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolverencargado.Location = new System.Drawing.Point(1102, 14);
            this.btnvolverencargado.Name = "btnvolverencargado";
            this.btnvolverencargado.Size = new System.Drawing.Size(94, 42);
            this.btnvolverencargado.TabIndex = 14;
            this.btnvolverencargado.Text = "Volver";
            this.btnvolverencargado.UseVisualStyleBackColor = true;
            // 
            // EncargadoDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 292);
            this.Controls.Add(this.btnvolverencargado);
            this.Controls.Add(this.btnAccionesProyecto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridviewencargado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnasignaractividad);
            this.Controls.Add(this.btnconsultarentregas);
            this.Controls.Add(this.btncrearactividad);
            this.Controls.Add(this.label1);
            this.Name = "EncargadoDepartamento";
            this.Text = "EncargadoDepartamento";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewencargado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcial3DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncrearactividad;
        private System.Windows.Forms.Button btnconsultarentregas;
        private System.Windows.Forms.Button btnasignaractividad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridviewencargado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAccionesProyecto;
        private parcial3DataSet parcial3DataSet1;
        private System.Windows.Forms.Button btnvolverencargado;
    }
}