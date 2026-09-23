namespace TP4 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblPrecio = new Label();
            lblKilometros = new Label();
            lblAnio = new Label();
            textPrecio = new TextBox();
            textKilometros = new TextBox();
            textAnio = new TextBox();
            textPatente = new TextBox();
            textModelo = new TextBox();
            textMarca = new TextBox();
            lblPatente = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            checkMoto = new CheckBox();
            checkAuto = new CheckBox();
            lblDetalle = new Label();
            textDetalle = new TextBox();
            lblTipo = new Label();
            btnCargar = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(794, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Carga de Vehiculos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCargar, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 78.125F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.875F));
            tableLayoutPanel2.Size = new Size(794, 399);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857094F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7142868F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7142868F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.Controls.Add(lblPrecio, 1, 6);
            tableLayoutPanel3.Controls.Add(lblKilometros, 1, 5);
            tableLayoutPanel3.Controls.Add(lblAnio, 1, 4);
            tableLayoutPanel3.Controls.Add(textPrecio, 2, 6);
            tableLayoutPanel3.Controls.Add(textKilometros, 2, 5);
            tableLayoutPanel3.Controls.Add(textAnio, 2, 4);
            tableLayoutPanel3.Controls.Add(textPatente, 2, 3);
            tableLayoutPanel3.Controls.Add(textModelo, 2, 2);
            tableLayoutPanel3.Controls.Add(textMarca, 2, 1);
            tableLayoutPanel3.Controls.Add(lblPatente, 1, 3);
            tableLayoutPanel3.Controls.Add(lblModelo, 1, 2);
            tableLayoutPanel3.Controls.Add(lblMarca, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel3.Controls.Add(lblDetalle, 1, 8);
            tableLayoutPanel3.Controls.Add(textDetalle, 2, 8);
            tableLayoutPanel3.Controls.Add(lblTipo, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 10;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel3.Size = new Size(788, 305);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(115, 188);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(275, 29);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKilometros
            // 
            lblKilometros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblKilometros.AutoSize = true;
            lblKilometros.Location = new Point(115, 159);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(275, 29);
            lblKilometros.TabIndex = 4;
            lblKilometros.Text = "Kilometros";
            lblKilometros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnio
            // 
            lblAnio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(115, 130);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(275, 29);
            lblAnio.TabIndex = 3;
            lblAnio.Text = "Año";
            lblAnio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textPrecio
            // 
            textPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textPrecio.Location = new Point(396, 191);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(275, 27);
            textPrecio.TabIndex = 15;
            // 
            // textKilometros
            // 
            textKilometros.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textKilometros.Location = new Point(396, 162);
            textKilometros.Name = "textKilometros";
            textKilometros.Size = new Size(275, 27);
            textKilometros.TabIndex = 14;
            // 
            // textAnio
            // 
            textAnio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textAnio.Location = new Point(396, 133);
            textAnio.Name = "textAnio";
            textAnio.Size = new Size(275, 27);
            textAnio.TabIndex = 13;
            // 
            // textPatente
            // 
            textPatente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textPatente.Location = new Point(396, 104);
            textPatente.Name = "textPatente";
            textPatente.Size = new Size(275, 27);
            textPatente.TabIndex = 12;
            // 
            // textModelo
            // 
            textModelo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textModelo.Location = new Point(396, 75);
            textModelo.Name = "textModelo";
            textModelo.Size = new Size(275, 27);
            textModelo.TabIndex = 11;
            // 
            // textMarca
            // 
            textMarca.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textMarca.Location = new Point(396, 46);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(275, 27);
            textMarca.TabIndex = 10;
            // 
            // lblPatente
            // 
            lblPatente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(115, 101);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(275, 29);
            lblPatente.TabIndex = 2;
            lblPatente.Text = "Patente";
            lblPatente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblModelo
            // 
            lblModelo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(115, 72);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(275, 29);
            lblModelo.TabIndex = 1;
            lblModelo.Text = "Modelo";
            lblModelo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMarca
            // 
            lblMarca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(115, 43);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(275, 29);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            lblMarca.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(checkMoto, 1, 0);
            tableLayoutPanel4.Controls.Add(checkAuto, 0, 0);
            tableLayoutPanel4.Location = new Point(396, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(275, 37);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // checkMoto
            // 
            checkMoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkMoto.AutoSize = true;
            checkMoto.Location = new Point(140, 3);
            checkMoto.Name = "checkMoto";
            checkMoto.Size = new Size(132, 31);
            checkMoto.TabIndex = 1;
            checkMoto.Text = "Moto";
            checkMoto.TextAlign = ContentAlignment.MiddleCenter;
            checkMoto.UseVisualStyleBackColor = true;
            checkMoto.CheckedChanged += checkMoto_CheckedChanged;
            // 
            // checkAuto
            // 
            checkAuto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkAuto.AutoSize = true;
            checkAuto.Location = new Point(3, 3);
            checkAuto.Name = "checkAuto";
            checkAuto.Size = new Size(131, 31);
            checkAuto.TabIndex = 2;
            checkAuto.Text = "Auto";
            checkAuto.TextAlign = ContentAlignment.MiddleCenter;
            checkAuto.UseVisualStyleBackColor = true;
            checkAuto.CheckedChanged += checkAuto_CheckedChanged;
            // 
            // lblDetalle
            // 
            lblDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDetalle.AutoSize = true;
            lblDetalle.Location = new Point(115, 246);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(275, 29);
            lblDetalle.TabIndex = 21;
            lblDetalle.Text = "Detalle";
            lblDetalle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textDetalle
            // 
            textDetalle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textDetalle.Location = new Point(396, 249);
            textDetalle.Name = "textDetalle";
            textDetalle.Size = new Size(275, 27);
            textDetalle.TabIndex = 22;
            // 
            // lblTipo
            // 
            lblTipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(115, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(275, 43);
            lblTipo.TabIndex = 23;
            lblTipo.Text = "Tipo de Vehiculo";
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.None;
            btnCargar.Location = new Point(316, 320);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(161, 70);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Concesionaria";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblPatente;
        private Label lblAnio;
        private Label lblKilometros;
        private Label lblPrecio;
        private Label label10;
        private Label label11;
        private TextBox textMarca;
        private TextBox textModelo;
        private TextBox textPatente;
        private TextBox textAnio;
        private TextBox textKilometros;
        private TextBox textPrecio;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox checkAuto;
        private CheckBox checkMoto;
        private Label lblDetalle;
        private TextBox textDetalle;
        private Button btnCargar;
        private Label lblTipo;
    }
}
