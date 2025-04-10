
namespace InventarioDesarrollo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Bt_bORRAR = new System.Windows.Forms.Button();
            this.Grafica = new System.Windows.Forms.Button();
            this.EXCEL = new System.Windows.Forms.Button();
            this.Prestamo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 139);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1341, 606);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(5, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 124);
            this.button1.TabIndex = 6;
            this.button1.Text = "AGREGAR HERRAMIENTAS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(567, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(504, 15);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(5, 268);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 161);
            this.button3.TabIndex = 9;
            this.button3.Text = "ACTUALIZAR HERRAMIENTAS";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Bt_bORRAR
            // 
            this.Bt_bORRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_bORRAR.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Bt_bORRAR.Image = ((System.Drawing.Image)(resources.GetObject("Bt_bORRAR.Image")));
            this.Bt_bORRAR.Location = new System.Drawing.Point(5, 434);
            this.Bt_bORRAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_bORRAR.Name = "Bt_bORRAR";
            this.Bt_bORRAR.Size = new System.Drawing.Size(153, 151);
            this.Bt_bORRAR.TabIndex = 10;
            this.Bt_bORRAR.Text = "BORRAR DATO";
            this.Bt_bORRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bt_bORRAR.UseVisualStyleBackColor = true;
            this.Bt_bORRAR.Click += new System.EventHandler(this.Bt_bORRAR_Click);
            // 
            // Grafica
            // 
            this.Grafica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Grafica.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Grafica.Image = ((System.Drawing.Image)(resources.GetObject("Grafica.Image")));
            this.Grafica.Location = new System.Drawing.Point(5, 591);
            this.Grafica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grafica.Name = "Grafica";
            this.Grafica.Size = new System.Drawing.Size(153, 154);
            this.Grafica.TabIndex = 11;
            this.Grafica.Text = "GAFICA";
            this.Grafica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Grafica.UseVisualStyleBackColor = true;
            this.Grafica.Click += new System.EventHandler(this.Grafica_Click);
            // 
            // EXCEL
            // 
            this.EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EXCEL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.EXCEL.Image = ((System.Drawing.Image)(resources.GetObject("EXCEL.Image")));
            this.EXCEL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EXCEL.Location = new System.Drawing.Point(5, 750);
            this.EXCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EXCEL.Name = "EXCEL";
            this.EXCEL.Size = new System.Drawing.Size(153, 144);
            this.EXCEL.TabIndex = 12;
            this.EXCEL.Text = "CREAR EXEL";
            this.EXCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EXCEL.UseVisualStyleBackColor = true;
            this.EXCEL.Click += new System.EventHandler(this.EXCEL_Click);
            // 
            // Prestamo
            // 
            this.Prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Prestamo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Prestamo.Image = ((System.Drawing.Image)(resources.GetObject("Prestamo.Image")));
            this.Prestamo.Location = new System.Drawing.Point(164, 750);
            this.Prestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.Size = new System.Drawing.Size(153, 144);
            this.Prestamo.TabIndex = 13;
            this.Prestamo.Text = "PRESTAMOS";
            this.Prestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Prestamo.UseVisualStyleBackColor = true;
            this.Prestamo.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1372, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(33, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 62);
            this.button4.TabIndex = 16;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(1545, 975);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Prestamo);
            this.Controls.Add(this.EXCEL);
            this.Controls.Add(this.Grafica);
            this.Controls.Add(this.Bt_bORRAR);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invenatrio de herramientas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Bt_bORRAR;
        private System.Windows.Forms.Button Grafica;
        private System.Windows.Forms.Button EXCEL;
        private System.Windows.Forms.Button Prestamo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
    }
}

