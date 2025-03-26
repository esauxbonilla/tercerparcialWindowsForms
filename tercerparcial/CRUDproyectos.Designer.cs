namespace tercerparcial
{
    partial class CRUDproyectos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdescripcionproyecto = new System.Windows.Forms.TextBox();
            this.txtestadoproyecto = new System.Windows.Forms.TextBox();
            this.txtfechaentregaproyecto = new System.Windows.Forms.TextBox();
            this.txtfechainicioproyecto = new System.Windows.Forms.TextBox();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.txtnombreproyecto = new System.Windows.Forms.TextBox();
            this.txtiddepartamento = new System.Windows.Forms.TextBox();
            this.txtidproyecto = new System.Windows.Forms.TextBox();
            this.btnregresarproyecto = new System.Windows.Forms.Button();
            this.btncrearproyecto = new System.Windows.Forms.Button();
            this.btnmodificarproyecto = new System.Windows.Forms.Button();
            this.btnconsultarproyecto = new System.Windows.Forms.Button();
            this.btneliminarproyecto = new System.Windows.Forms.Button();
            this.gridviewproyectos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewproyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acciones Proyectos";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Proyecto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Departamento";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Del Proyecto";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observaciones";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha  Inicio";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Entrega";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descripcion";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado Del Proyecto";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtdescripcionproyecto
            // 
            this.txtdescripcionproyecto.Location = new System.Drawing.Point(191, 499);
            this.txtdescripcionproyecto.Name = "txtdescripcionproyecto";
            this.txtdescripcionproyecto.Size = new System.Drawing.Size(554, 20);
            this.txtdescripcionproyecto.TabIndex = 9;
            // 
            // txtestadoproyecto
            // 
            this.txtestadoproyecto.Location = new System.Drawing.Point(223, 441);
            this.txtestadoproyecto.Name = "txtestadoproyecto";
            this.txtestadoproyecto.Size = new System.Drawing.Size(100, 20);
            this.txtestadoproyecto.TabIndex = 10;
            // 
            // txtfechaentregaproyecto
            // 
            this.txtfechaentregaproyecto.Location = new System.Drawing.Point(223, 380);
            this.txtfechaentregaproyecto.Name = "txtfechaentregaproyecto";
            this.txtfechaentregaproyecto.Size = new System.Drawing.Size(100, 20);
            this.txtfechaentregaproyecto.TabIndex = 11;
            // 
            // txtfechainicioproyecto
            // 
            this.txtfechainicioproyecto.Location = new System.Drawing.Point(223, 320);
            this.txtfechainicioproyecto.Name = "txtfechainicioproyecto";
            this.txtfechainicioproyecto.Size = new System.Drawing.Size(100, 20);
            this.txtfechainicioproyecto.TabIndex = 12;
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(223, 265);
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(522, 20);
            this.txtobservaciones.TabIndex = 13;
            // 
            // txtnombreproyecto
            // 
            this.txtnombreproyecto.Location = new System.Drawing.Point(223, 206);
            this.txtnombreproyecto.Name = "txtnombreproyecto";
            this.txtnombreproyecto.Size = new System.Drawing.Size(100, 20);
            this.txtnombreproyecto.TabIndex = 14;
            // 
            // txtiddepartamento
            // 
            this.txtiddepartamento.Location = new System.Drawing.Point(223, 153);
            this.txtiddepartamento.Name = "txtiddepartamento";
            this.txtiddepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtiddepartamento.TabIndex = 15;
            // 
            // txtidproyecto
            // 
            this.txtidproyecto.Location = new System.Drawing.Point(223, 93);
            this.txtidproyecto.Name = "txtidproyecto";
            this.txtidproyecto.Size = new System.Drawing.Size(100, 20);
            this.txtidproyecto.TabIndex = 16;
            // 
            // btnregresarproyecto
            // 
            this.btnregresarproyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresarproyecto.Location = new System.Drawing.Point(679, 12);
            this.btnregresarproyecto.Name = "btnregresarproyecto";
            this.btnregresarproyecto.Size = new System.Drawing.Size(109, 42);
            this.btnregresarproyecto.TabIndex = 17;
            this.btnregresarproyecto.Text = "Volver";
            this.btnregresarproyecto.UseVisualStyleBackColor = true;
            // 
            // btncrearproyecto
            // 
            this.btncrearproyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearproyecto.Location = new System.Drawing.Point(295, 536);
            this.btncrearproyecto.Name = "btncrearproyecto";
            this.btncrearproyecto.Size = new System.Drawing.Size(109, 42);
            this.btncrearproyecto.TabIndex = 18;
            this.btncrearproyecto.Text = "Crear Proyecto";
            this.btncrearproyecto.UseVisualStyleBackColor = true;
            // 
            // btnmodificarproyecto
            // 
            this.btnmodificarproyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarproyecto.Location = new System.Drawing.Point(667, 536);
            this.btnmodificarproyecto.Name = "btnmodificarproyecto";
            this.btnmodificarproyecto.Size = new System.Drawing.Size(109, 42);
            this.btnmodificarproyecto.TabIndex = 19;
            this.btnmodificarproyecto.Text = "Modificar proyecto";
            this.btnmodificarproyecto.UseVisualStyleBackColor = true;
            // 
            // btnconsultarproyecto
            // 
            this.btnconsultarproyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultarproyecto.Location = new System.Drawing.Point(537, 536);
            this.btnconsultarproyecto.Name = "btnconsultarproyecto";
            this.btnconsultarproyecto.Size = new System.Drawing.Size(109, 42);
            this.btnconsultarproyecto.TabIndex = 20;
            this.btnconsultarproyecto.Text = "Consultar Proyecto";
            this.btnconsultarproyecto.UseVisualStyleBackColor = true;
            // 
            // btneliminarproyecto
            // 
            this.btneliminarproyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarproyecto.Location = new System.Drawing.Point(419, 536);
            this.btneliminarproyecto.Name = "btneliminarproyecto";
            this.btneliminarproyecto.Size = new System.Drawing.Size(109, 42);
            this.btneliminarproyecto.TabIndex = 21;
            this.btneliminarproyecto.Text = "Eliminar Proyecto";
            this.btneliminarproyecto.UseVisualStyleBackColor = true;
            // 
            // gridviewproyectos
            // 
            this.gridviewproyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewproyectos.Location = new System.Drawing.Point(43, 594);
            this.gridviewproyectos.Name = "gridviewproyectos";
            this.gridviewproyectos.Size = new System.Drawing.Size(733, 210);
            this.gridviewproyectos.TabIndex = 22;
            // 
            // CRUDproyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 841);
            this.Controls.Add(this.gridviewproyectos);
            this.Controls.Add(this.btneliminarproyecto);
            this.Controls.Add(this.btnconsultarproyecto);
            this.Controls.Add(this.btnmodificarproyecto);
            this.Controls.Add(this.btncrearproyecto);
            this.Controls.Add(this.btnregresarproyecto);
            this.Controls.Add(this.txtidproyecto);
            this.Controls.Add(this.txtiddepartamento);
            this.Controls.Add(this.txtnombreproyecto);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.txtfechainicioproyecto);
            this.Controls.Add(this.txtfechaentregaproyecto);
            this.Controls.Add(this.txtestadoproyecto);
            this.Controls.Add(this.txtdescripcionproyecto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRUDproyectos";
            this.Text = "CRUDproyectos";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewproyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdescripcionproyecto;
        private System.Windows.Forms.TextBox txtestadoproyecto;
        private System.Windows.Forms.TextBox txtfechaentregaproyecto;
        private System.Windows.Forms.TextBox txtfechainicioproyecto;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.TextBox txtnombreproyecto;
        private System.Windows.Forms.TextBox txtiddepartamento;
        private System.Windows.Forms.TextBox txtidproyecto;
        private System.Windows.Forms.Button btnregresarproyecto;
        private System.Windows.Forms.Button btncrearproyecto;
        private System.Windows.Forms.Button btnmodificarproyecto;
        private System.Windows.Forms.Button btnconsultarproyecto;
        private System.Windows.Forms.Button btneliminarproyecto;
        private System.Windows.Forms.DataGridView gridviewproyectos;
    }
}