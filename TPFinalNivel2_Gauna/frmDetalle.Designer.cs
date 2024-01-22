namespace winform_app
{
    partial class frmDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalle));
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigoMostrar = new System.Windows.Forms.Label();
            this.lblNombreMostrar = new System.Windows.Forms.Label();
            this.lblDescripcionMostrar = new System.Windows.Forms.Label();
            this.lblPrecioMostrar = new System.Windows.Forms.Label();
            this.lblCategoriaMostrar = new System.Windows.Forms.Label();
            this.lblMarcaMostrar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusDetalle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeMuestraArticulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxArticuloDetalle = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(57, 338);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 16);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(57, 296);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 16);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(57, 258);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(57, 216);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 16);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(57, 174);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigo.Location = new System.Drawing.Point(57, 132);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCodigoMostrar
            // 
            this.lblCodigoMostrar.AutoSize = true;
            this.lblCodigoMostrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMostrar.Location = new System.Drawing.Point(129, 132);
            this.lblCodigoMostrar.Name = "lblCodigoMostrar";
            this.lblCodigoMostrar.Size = new System.Drawing.Size(0, 16);
            this.lblCodigoMostrar.TabIndex = 1;
            // 
            // lblNombreMostrar
            // 
            this.lblNombreMostrar.AutoSize = true;
            this.lblNombreMostrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMostrar.Location = new System.Drawing.Point(129, 174);
            this.lblNombreMostrar.Name = "lblNombreMostrar";
            this.lblNombreMostrar.Size = new System.Drawing.Size(0, 16);
            this.lblNombreMostrar.TabIndex = 3;
            // 
            // lblDescripcionMostrar
            // 
            this.lblDescripcionMostrar.AutoSize = true;
            this.lblDescripcionMostrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMostrar.Location = new System.Drawing.Point(141, 216);
            this.lblDescripcionMostrar.Name = "lblDescripcionMostrar";
            this.lblDescripcionMostrar.Size = new System.Drawing.Size(0, 16);
            this.lblDescripcionMostrar.TabIndex = 5;
            // 
            // lblPrecioMostrar
            // 
            this.lblPrecioMostrar.AutoSize = true;
            this.lblPrecioMostrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMostrar.Location = new System.Drawing.Point(129, 258);
            this.lblPrecioMostrar.Name = "lblPrecioMostrar";
            this.lblPrecioMostrar.Size = new System.Drawing.Size(0, 16);
            this.lblPrecioMostrar.TabIndex = 7;
            // 
            // lblCategoriaMostrar
            // 
            this.lblCategoriaMostrar.AutoSize = true;
            this.lblCategoriaMostrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaMostrar.Location = new System.Drawing.Point(129, 296);
            this.lblCategoriaMostrar.Name = "lblCategoriaMostrar";
            this.lblCategoriaMostrar.Size = new System.Drawing.Size(0, 16);
            this.lblCategoriaMostrar.TabIndex = 9;
            // 
            // lblMarcaMostrar
            // 
            this.lblMarcaMostrar.AutoSize = true;
            this.lblMarcaMostrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaMostrar.Location = new System.Drawing.Point(129, 338);
            this.lblMarcaMostrar.Name = "lblMarcaMostrar";
            this.lblMarcaMostrar.Size = new System.Drawing.Size(0, 16);
            this.lblMarcaMostrar.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(245, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusDetalle});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(590, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusDetalle
            // 
            this.toolStripStatusDetalle.Name = "toolStripStatusDetalle";
            this.toolStripStatusDetalle.Size = new System.Drawing.Size(144, 17);
            this.toolStripStatusDetalle.Text = "Viendo detalle del artículo";
            // 
            // lblSeMuestraArticulo
            // 
            this.lblSeMuestraArticulo.AutoSize = true;
            this.lblSeMuestraArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeMuestraArticulo.Location = new System.Drawing.Point(171, 35);
            this.lblSeMuestraArticulo.Name = "lblSeMuestraArticulo";
            this.lblSeMuestraArticulo.Size = new System.Drawing.Size(78, 24);
            this.lblSeMuestraArticulo.TabIndex = 41;
            this.lblSeMuestraArticulo.Text = "labelcita";
            this.lblSeMuestraArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Viendo artículo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxArticuloDetalle
            // 
            this.pbxArticuloDetalle.Location = new System.Drawing.Point(339, 132);
            this.pbxArticuloDetalle.Name = "pbxArticuloDetalle";
            this.pbxArticuloDetalle.Size = new System.Drawing.Size(222, 206);
            this.pbxArticuloDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticuloDetalle.TabIndex = 31;
            this.pbxArticuloDetalle.TabStop = false;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeMuestraArticulo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMarcaMostrar);
            this.Controls.Add(this.lblCategoriaMostrar);
            this.Controls.Add(this.lblPrecioMostrar);
            this.Controls.Add(this.lblDescripcionMostrar);
            this.Controls.Add(this.lblNombreMostrar);
            this.Controls.Add(this.lblCodigoMostrar);
            this.Controls.Add(this.pbxArticuloDetalle);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(606, 489);
            this.MinimumSize = new System.Drawing.Size(606, 489);
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del Artículo";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxArticuloDetalle;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigoMostrar;
        private System.Windows.Forms.Label lblNombreMostrar;
        private System.Windows.Forms.Label lblDescripcionMostrar;
        private System.Windows.Forms.Label lblPrecioMostrar;
        private System.Windows.Forms.Label lblCategoriaMostrar;
        private System.Windows.Forms.Label lblMarcaMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDetalle;
        private System.Windows.Forms.Label lblSeMuestraArticulo;
        private System.Windows.Forms.Label label1;
    }
}