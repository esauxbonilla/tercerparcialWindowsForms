﻿namespace tercerparcial
{
    partial class CRUDColaborador
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
            this.btnvolverentregar = new System.Windows.Forms.Button();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gridviewactividades = new System.Windows.Forms.DataGridView();
            this.txtestadoentrega = new System.Windows.Forms.TextBox();
            this.txtnombreentrega = new System.Windows.Forms.TextBox();
            this.txtidactividadentrega = new System.Windows.Forms.TextBox();
            this.txtUrlArchivo = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewactividades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entregar Actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Actividad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Url Actividad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Actividad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado";
            // 
            // btnvolverentregar
            // 
            this.btnvolverentregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolverentregar.Location = new System.Drawing.Point(689, 15);
            this.btnvolverentregar.Name = "btnvolverentregar";
            this.btnvolverentregar.Size = new System.Drawing.Size(99, 50);
            this.btnvolverentregar.TabIndex = 5;
            this.btnvolverentregar.Text = "Volver";
            this.btnvolverentregar.UseVisualStyleBackColor = true;
            // 
            // btnEntregar
            // 
            this.btnEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregar.Location = new System.Drawing.Point(511, 288);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(99, 50);
            this.btnEntregar.TabIndex = 6;
            this.btnEntregar.Text = "Entregar";
            this.btnEntregar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(511, 344);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(99, 50);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // gridviewactividades
            // 
            this.gridviewactividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewactividades.Location = new System.Drawing.Point(29, 288);
            this.gridviewactividades.Name = "gridviewactividades";
            this.gridviewactividades.Size = new System.Drawing.Size(476, 162);
            this.gridviewactividades.TabIndex = 8;
            // 
            // txtestadoentrega
            // 
            this.txtestadoentrega.Location = new System.Drawing.Point(191, 192);
            this.txtestadoentrega.Name = "txtestadoentrega";
            this.txtestadoentrega.Size = new System.Drawing.Size(100, 20);
            this.txtestadoentrega.TabIndex = 9;
            // 
            // txtnombreentrega
            // 
            this.txtnombreentrega.Location = new System.Drawing.Point(191, 140);
            this.txtnombreentrega.Name = "txtnombreentrega";
            this.txtnombreentrega.Size = new System.Drawing.Size(100, 20);
            this.txtnombreentrega.TabIndex = 10;
            // 
            // txtidactividadentrega
            // 
            this.txtidactividadentrega.Location = new System.Drawing.Point(191, 93);
            this.txtidactividadentrega.Name = "txtidactividadentrega";
            this.txtidactividadentrega.Size = new System.Drawing.Size(100, 20);
            this.txtidactividadentrega.TabIndex = 11;
            // 
            // txtUrlArchivo
            // 
            this.txtUrlArchivo.Location = new System.Drawing.Point(191, 240);
            this.txtUrlArchivo.Name = "txtUrlArchivo";
            this.txtUrlArchivo.Size = new System.Drawing.Size(597, 20);
            this.txtUrlArchivo.TabIndex = 12;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(511, 400);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 50);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // CRUDColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtUrlArchivo);
            this.Controls.Add(this.txtidactividadentrega);
            this.Controls.Add(this.txtnombreentrega);
            this.Controls.Add(this.txtestadoentrega);
            this.Controls.Add(this.gridviewactividades);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.btnvolverentregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRUDColaborador";
            this.Text = "CRUDColaborador";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewactividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnvolverentregar;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView gridviewactividades;
        private System.Windows.Forms.TextBox txtestadoentrega;
        private System.Windows.Forms.TextBox txtnombreentrega;
        private System.Windows.Forms.TextBox txtidactividadentrega;
        private System.Windows.Forms.TextBox txtUrlArchivo;
        private System.Windows.Forms.Button btnModificar;
    }
}