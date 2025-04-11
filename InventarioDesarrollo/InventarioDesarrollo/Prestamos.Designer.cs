
namespace InventarioDesarrollo
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.prestamos_data = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdHerramienta = new System.Windows.Forms.TextBox();
            this.txtUsuarioAsignado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.herramientasdb = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prestamos_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasdb)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamos_data
            // 
            this.prestamos_data.BackgroundColor = System.Drawing.Color.White;
            this.prestamos_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamos_data.Location = new System.Drawing.Point(44, 471);
            this.prestamos_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prestamos_data.Name = "prestamos_data";
            this.prestamos_data.RowHeadersWidth = 51;
            this.prestamos_data.RowTemplate.Height = 24;
            this.prestamos_data.Size = new System.Drawing.Size(928, 218);
            this.prestamos_data.TabIndex = 0;
            this.prestamos_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prestamos_data_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(37, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prestar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdHerramienta
            // 
            this.txtIdHerramienta.Location = new System.Drawing.Point(37, 37);
            this.txtIdHerramienta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdHerramienta.Name = "txtIdHerramienta";
            this.txtIdHerramienta.Size = new System.Drawing.Size(247, 22);
            this.txtIdHerramienta.TabIndex = 2;
            // 
            // txtUsuarioAsignado
            // 
            this.txtUsuarioAsignado.Location = new System.Drawing.Point(37, 117);
            this.txtUsuarioAsignado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioAsignado.Name = "txtUsuarioAsignado";
            this.txtUsuarioAsignado.Size = new System.Drawing.Size(247, 22);
            this.txtUsuarioAsignado.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(201)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdHerramienta);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtUsuarioAsignado);
            this.groupBox1.Location = new System.Drawing.Point(73, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(324, 335);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(123, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(37, 193);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(247, 22);
            this.txtCantidad.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(204, 231);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 82);
            this.button2.TabIndex = 6;
            this.button2.Text = "devolver";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(73, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOMBRE DEL PRESTADOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(91, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID DE HERRAMIENTA";
            // 
            // herramientasdb
            // 
            this.herramientasdb.BackgroundColor = System.Drawing.Color.White;
            this.herramientasdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.herramientasdb.Location = new System.Drawing.Point(460, 52);
            this.herramientasdb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.herramientasdb.Name = "herramientasdb";
            this.herramientasdb.RowHeadersWidth = 51;
            this.herramientasdb.RowTemplate.Height = 24;
            this.herramientasdb.Size = new System.Drawing.Size(487, 270);
            this.herramientasdb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(608, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "HERRAMIENTAS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1019, 732);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.herramientasdb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prestamos_data);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamos_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView prestamos_data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdHerramienta;
        private System.Windows.Forms.TextBox txtUsuarioAsignado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView herramientasdb;
        private System.Windows.Forms.Label label4;
    }
}