
namespace JosueRivera
{
    partial class Primer_Formulario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodotiempotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.periodotiempoCB = new System.Windows.Forms.ComboBox();
            this.tasatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidadtx = new System.Windows.Forms.TextBox();
            this.cantidadtxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fechatxt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.columna2,
            this.Columna3,
            this.Columna4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(403, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 464);
            this.dataGridView1.TabIndex = 42;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // columna2
            // 
            this.columna2.HeaderText = "Interes";
            this.columna2.Name = "columna2";
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "Capital";
            this.Columna3.Name = "Columna3";
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "Total Acumulado";
            this.Columna4.Name = "Columna4";
            // 
            // periodotiempotxt
            // 
            this.periodotiempotxt.Location = new System.Drawing.Point(109, 168);
            this.periodotiempotxt.Name = "periodotiempotxt";
            this.periodotiempotxt.Size = new System.Drawing.Size(147, 20);
            this.periodotiempotxt.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Dias/Meses/Años:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Periodo de tiempo:";
            // 
            // periodotiempoCB
            // 
            this.periodotiempoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodotiempoCB.FormattingEnabled = true;
            this.periodotiempoCB.Items.AddRange(new object[] {
            "Diario",
            "Mensual",
            "Anual"});
            this.periodotiempoCB.Location = new System.Drawing.Point(109, 134);
            this.periodotiempoCB.Name = "periodotiempoCB";
            this.periodotiempoCB.Size = new System.Drawing.Size(147, 21);
            this.periodotiempoCB.TabIndex = 38;
            // 
            // tasatxt
            // 
            this.tasatxt.Location = new System.Drawing.Point(109, 96);
            this.tasatxt.Name = "tasatxt";
            this.tasatxt.Size = new System.Drawing.Size(147, 20);
            this.tasatxt.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tasa de Interes:";
            // 
            // cantidadtx
            // 
            this.cantidadtx.Location = new System.Drawing.Point(109, 61);
            this.cantidadtx.Name = "cantidadtx";
            this.cantidadtx.Size = new System.Drawing.Size(147, 20);
            this.cantidadtx.TabIndex = 35;
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.AutoSize = true;
            this.cantidadtxt.Location = new System.Drawing.Point(51, 64);
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(52, 13);
            this.cantidadtxt.TabIndex = 34;
            this.cantidadtxt.Text = "Cantidad:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechatxt
            // 
            this.fechatxt.Location = new System.Drawing.Point(53, 21);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.Size = new System.Drawing.Size(200, 20);
            this.fechatxt.TabIndex = 32;
            // 
            // Primer_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 464);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.periodotiempotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.periodotiempoCB);
            this.Controls.Add(this.tasatxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidadtx);
            this.Controls.Add(this.cantidadtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fechatxt);
            this.Name = "Primer_Formulario";
            this.Text = "Primer_Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna4;
        private System.Windows.Forms.TextBox periodotiempotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox periodotiempoCB;
        private System.Windows.Forms.TextBox tasatxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantidadtx;
        private System.Windows.Forms.Label cantidadtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fechatxt;
    }
}