
namespace Propiedades_Condominio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CuotaDescendente = new System.Windows.Forms.RadioButton();
            this.CuotaAscendente = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cuotaaltaybaja = new System.Windows.Forms.RadioButton();
            this.propiedades = new System.Windows.Forms.RadioButton();
            this.Cuota_TotalAlta = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // CuotaDescendente
            // 
            this.CuotaDescendente.AutoSize = true;
            this.CuotaDescendente.Location = new System.Drawing.Point(21, 57);
            this.CuotaDescendente.Name = "CuotaDescendente";
            this.CuotaDescendente.Size = new System.Drawing.Size(178, 17);
            this.CuotaDescendente.TabIndex = 2;
            this.CuotaDescendente.TabStop = true;
            this.CuotaDescendente.Text = "Ordenar por cuota Descendente";
            this.CuotaDescendente.UseVisualStyleBackColor = true;
            this.CuotaDescendente.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CuotaAscendente
            // 
            this.CuotaAscendente.AutoSize = true;
            this.CuotaAscendente.Location = new System.Drawing.Point(21, 34);
            this.CuotaAscendente.Name = "CuotaAscendente";
            this.CuotaAscendente.Size = new System.Drawing.Size(186, 17);
            this.CuotaAscendente.TabIndex = 1;
            this.CuotaAscendente.TabStop = true;
            this.CuotaAscendente.Text = "Ordenar por cuota de Ascendente";
            this.CuotaAscendente.UseVisualStyleBackColor = true;
            this.CuotaAscendente.CheckedChanged += new System.EventHandler(this.CuotaAscendente_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cuota_TotalAlta);
            this.groupBox1.Controls.Add(this.Cuotaaltaybaja);
            this.groupBox1.Controls.Add(this.CuotaAscendente);
            this.groupBox1.Controls.Add(this.propiedades);
            this.groupBox1.Controls.Add(this.CuotaDescendente);
            this.groupBox1.Location = new System.Drawing.Point(428, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 169);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Cuotaaltaybaja
            // 
            this.Cuotaaltaybaja.AutoSize = true;
            this.Cuotaaltaybaja.Location = new System.Drawing.Point(21, 106);
            this.Cuotaaltaybaja.Name = "Cuotaaltaybaja";
            this.Cuotaaltaybaja.Size = new System.Drawing.Size(225, 17);
            this.Cuotaaltaybaja.TabIndex = 4;
            this.Cuotaaltaybaja.TabStop = true;
            this.Cuotaaltaybaja.Text = "Mostrar las 3 cuotas más altas y más bajas";
            this.Cuotaaltaybaja.UseVisualStyleBackColor = true;
            this.Cuotaaltaybaja.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // propiedades
            // 
            this.propiedades.AutoSize = true;
            this.propiedades.Location = new System.Drawing.Point(21, 83);
            this.propiedades.Name = "propiedades";
            this.propiedades.Size = new System.Drawing.Size(253, 17);
            this.propiedades.TabIndex = 3;
            this.propiedades.TabStop = true;
            this.propiedades.Text = "Mostrar el propietario que más propiedades tiene";
            this.propiedades.UseVisualStyleBackColor = true;
            this.propiedades.CheckedChanged += new System.EventHandler(this.propiedades_CheckedChanged);
            // 
            // Cuota_TotalAlta
            // 
            this.Cuota_TotalAlta.AutoSize = true;
            this.Cuota_TotalAlta.Location = new System.Drawing.Point(21, 129);
            this.Cuota_TotalAlta.Name = "Cuota_TotalAlta";
            this.Cuota_TotalAlta.Size = new System.Drawing.Size(318, 17);
            this.Cuota_TotalAlta.TabIndex = 5;
            this.Cuota_TotalAlta.TabStop = true;
            this.Cuota_TotalAlta.Text = "Mostrar Datos de la persona que paga la Cuota Total más Alta";
            this.Cuota_TotalAlta.UseVisualStyleBackColor = true;
            this.Cuota_TotalAlta.CheckedChanged += new System.EventHandler(this.Cuota_TotalAlta_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Control de pago de Propiedades";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton CuotaDescendente;
        private System.Windows.Forms.RadioButton CuotaAscendente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton propiedades;
        private System.Windows.Forms.RadioButton Cuotaaltaybaja;
        private System.Windows.Forms.RadioButton Cuota_TotalAlta;
    }
}

