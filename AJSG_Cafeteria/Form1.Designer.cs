namespace AJSG_Cafeteria
{
    public partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCrear = new Button();
            btnDelete = new Button();
            pictureBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txBxId = new TextBox();
            txBxNombre = new TextBox();
            txBxPrecio = new TextBox();
            txBxCalidad = new TextBox();
            btnMod = new Button();
            label6 = new Label();
            txBxDonutsRegistr = new TextBox();
            btnCargar = new Button();
            btnGuardar = new Button();
            btnAnt = new Button();
            btnSig = new Button();
            label5 = new Label();
            chBxStock = new CheckBox();
            btnImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(203, 454);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += button3_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(328, 454);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(491, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(238, 229);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 67);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 5;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 107);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 147);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 187);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Calidad:";
            // 
            // txBxId
            // 
            txBxId.Location = new Point(172, 64);
            txBxId.Name = "txBxId";
            txBxId.Size = new Size(125, 27);
            txBxId.TabIndex = 11;
            // 
            // txBxNombre
            // 
            txBxNombre.Location = new Point(172, 104);
            txBxNombre.Name = "txBxNombre";
            txBxNombre.Size = new Size(125, 27);
            txBxNombre.TabIndex = 12;
            // 
            // txBxPrecio
            // 
            txBxPrecio.Location = new Point(172, 144);
            txBxPrecio.Name = "txBxPrecio";
            txBxPrecio.Size = new Size(125, 27);
            txBxPrecio.TabIndex = 13;
            // 
            // txBxCalidad
            // 
            txBxCalidad.Location = new Point(172, 184);
            txBxCalidad.Name = "txBxCalidad";
            txBxCalidad.Size = new Size(125, 27);
            txBxCalidad.TabIndex = 14;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(449, 454);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(94, 29);
            btnMod.TabIndex = 16;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 294);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 17;
            label6.Text = "Donuts registrados:";
            // 
            // txBxDonutsRegistr
            // 
            txBxDonutsRegistr.Location = new Point(390, 291);
            txBxDonutsRegistr.Name = "txBxDonutsRegistr";
            txBxDonutsRegistr.Size = new Size(125, 27);
            txBxDonutsRegistr.TabIndex = 18;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(635, 380);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 19;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(635, 454);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAnt
            // 
            btnAnt.BackColor = SystemColors.ControlLight;
            btnAnt.Location = new Point(247, 380);
            btnAnt.Name = "btnAnt";
            btnAnt.Size = new Size(94, 29);
            btnAnt.TabIndex = 23;
            btnAnt.Text = "Anterior";
            btnAnt.UseVisualStyleBackColor = false;
            btnAnt.Click += btnAnt_Click;
            // 
            // btnSig
            // 
            btnSig.Location = new Point(390, 380);
            btnSig.Name = "btnSig";
            btnSig.Size = new Size(94, 29);
            btnSig.TabIndex = 24;
            btnSig.Text = "Siguiente";
            btnSig.UseVisualStyleBackColor = true;
            btnSig.Click += btnSig_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 229);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 9;
            label5.Text = "In stock:";
            // 
            // chBxStock
            // 
            chBxStock.AutoSize = true;
            chBxStock.ForeColor = Color.Black;
            chBxStock.Location = new Point(172, 232);
            chBxStock.Name = "chBxStock";
            chBxStock.Size = new Size(18, 17);
            chBxStock.TabIndex = 25;
            chBxStock.UseVisualStyleBackColor = true;
            // 
            // btnImagen
            // 
            btnImagen.Location = new Point(390, 220);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(94, 29);
            btnImagen.TabIndex = 26;
            btnImagen.Text = "FileChooser";
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += btnImagen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(btnImagen);
            Controls.Add(chBxStock);
            Controls.Add(btnSig);
            Controls.Add(btnAnt);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargar);
            Controls.Add(txBxDonutsRegistr);
            Controls.Add(label6);
            Controls.Add(btnMod);
            Controls.Add(txBxCalidad);
            Controls.Add(txBxPrecio);
            Controls.Add(txBxNombre);
            Controls.Add(txBxId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Controls.Add(btnDelete);
            Controls.Add(btnCrear);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCrear;
        private Button btnDelete;
        private PictureBox pictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txBxId;
        private TextBox txBxNombre;
        private TextBox txBxPrecio;
        private TextBox txBxCalidad;
        private Button btnMod;
        private Label label6;
        private TextBox txBxDonutsRegistr;
        private Button btnCargar;
        private Button btnGuardar;
        private Button btnAnt;
        private Button btnSig;
        private Label label5;
        private CheckBox chBxStock;
        private Button btnImagen;
    }
}
