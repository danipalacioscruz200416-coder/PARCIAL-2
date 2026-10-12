namespace TiendaParcial
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.butproducto = new System.Windows.Forms.Button();
            this.butelimiar = new System.Windows.Forms.Button();
            this.butprecio = new System.Windows.Forms.Button();
            this.butexistencia = new System.Windows.Forms.Button();
            this.butcategoria = new System.Windows.Forms.Button();
            this.butlimpiar = new System.Windows.Forms.Button();
            this.butguardar = new System.Windows.Forms.Button();
            this.butconsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.butrestablecer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(696, 89);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(197, 22);
            this.txtproducto.TabIndex = 0;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(696, 146);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(197, 22);
            this.txtcategoria.TabIndex = 0;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(696, 210);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(197, 22);
            this.txtprecio.TabIndex = 2;
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(696, 282);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(197, 22);
            this.txtexistencia.TabIndex = 3;
            // 
            // butproducto
            // 
            this.butproducto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.butproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butproducto.Location = new System.Drawing.Point(501, 83);
            this.butproducto.Name = "butproducto";
            this.butproducto.Size = new System.Drawing.Size(144, 35);
            this.butproducto.TabIndex = 4;
            this.butproducto.Text = " producto";
            this.butproducto.UseVisualStyleBackColor = false;
            // 
            // butelimiar
            // 
            this.butelimiar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.butelimiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butelimiar.Location = new System.Drawing.Point(676, 356);
            this.butelimiar.Name = "butelimiar";
            this.butelimiar.Size = new System.Drawing.Size(131, 36);
            this.butelimiar.TabIndex = 5;
            this.butelimiar.Text = "eliminar";
            this.butelimiar.UseVisualStyleBackColor = false;
            this.butelimiar.Click += new System.EventHandler(this.butelimiar_Click);
            // 
            // butprecio
            // 
            this.butprecio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.butprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butprecio.Location = new System.Drawing.Point(501, 197);
            this.butprecio.Name = "butprecio";
            this.butprecio.Size = new System.Drawing.Size(144, 35);
            this.butprecio.TabIndex = 6;
            this.butprecio.Text = "precio";
            this.butprecio.UseVisualStyleBackColor = false;
            // 
            // butexistencia
            // 
            this.butexistencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.butexistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butexistencia.Location = new System.Drawing.Point(501, 258);
            this.butexistencia.Name = "butexistencia";
            this.butexistencia.Size = new System.Drawing.Size(144, 35);
            this.butexistencia.TabIndex = 7;
            this.butexistencia.Text = "existencial";
            this.butexistencia.UseVisualStyleBackColor = false;
            // 
            // butcategoria
            // 
            this.butcategoria.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.butcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcategoria.Location = new System.Drawing.Point(501, 134);
            this.butcategoria.Name = "butcategoria";
            this.butcategoria.Size = new System.Drawing.Size(144, 38);
            this.butcategoria.TabIndex = 8;
            this.butcategoria.Text = "categoria";
            this.butcategoria.UseVisualStyleBackColor = false;
            // 
            // butlimpiar
            // 
            this.butlimpiar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.butlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlimpiar.Location = new System.Drawing.Point(506, 356);
            this.butlimpiar.Name = "butlimpiar";
            this.butlimpiar.Size = new System.Drawing.Size(130, 36);
            this.butlimpiar.TabIndex = 10;
            this.butlimpiar.Text = "limpiar";
            this.butlimpiar.UseVisualStyleBackColor = false;
            this.butlimpiar.Click += new System.EventHandler(this.butlimpiar_Click);
            // 
            // butguardar
            // 
            this.butguardar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.butguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butguardar.Location = new System.Drawing.Point(188, 356);
            this.butguardar.Name = "butguardar";
            this.butguardar.Size = new System.Drawing.Size(133, 39);
            this.butguardar.TabIndex = 11;
            this.butguardar.Text = "guardar";
            this.butguardar.UseVisualStyleBackColor = false;
            this.butguardar.Click += new System.EventHandler(this.butguardar_Click);
            // 
            // butconsultar
            // 
            this.butconsultar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.butconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butconsultar.Location = new System.Drawing.Point(349, 356);
            this.butconsultar.Name = "butconsultar";
            this.butconsultar.Size = new System.Drawing.Size(133, 39);
            this.butconsultar.TabIndex = 12;
            this.butconsultar.Text = "consultar ";
            this.butconsultar.UseVisualStyleBackColor = false;
            this.butconsultar.Click += new System.EventHandler(this.butconsultar_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(26, 89);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 241);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "registro de tecnologia JD";
            // 
            // butrestablecer
            // 
            this.butrestablecer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.butrestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butrestablecer.Location = new System.Drawing.Point(12, 357);
            this.butrestablecer.Name = "butrestablecer";
            this.butrestablecer.Size = new System.Drawing.Size(160, 36);
            this.butrestablecer.TabIndex = 15;
            this.butrestablecer.Text = "restablecer";
            this.butrestablecer.UseVisualStyleBackColor = false;
            this.butrestablecer.Click += new System.EventHandler(this.butrestablecer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 456);
            this.Controls.Add(this.butrestablecer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butconsultar);
            this.Controls.Add(this.butguardar);
            this.Controls.Add(this.butlimpiar);
            this.Controls.Add(this.butcategoria);
            this.Controls.Add(this.butexistencia);
            this.Controls.Add(this.butprecio);
            this.Controls.Add(this.butelimiar);
            this.Controls.Add(this.butproducto);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtproducto);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.Button butproducto;
        private System.Windows.Forms.Button butelimiar;
        private System.Windows.Forms.Button butprecio;
        private System.Windows.Forms.Button butexistencia;
        private System.Windows.Forms.Button butcategoria;
        private System.Windows.Forms.Button butlimpiar;
        private System.Windows.Forms.Button butguardar;
        private System.Windows.Forms.Button butconsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butrestablecer;
    }
}
