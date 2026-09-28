namespace TrianguloInterfaz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textAltura = new TextBox();
            textBase = new TextBox();
            label4 = new Label();
            textResultado = new TextBox();
            botonArea = new Button();
            botonPerimetro = new Button();
            botónLimpiar = new Button();
            pictureBox1 = new PictureBox();
            botonCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 29);
            label1.Name = "label1";
            label1.Size = new Size(153, 38);
            label1.TabIndex = 0;
            label1.Text = "Triángulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 208);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Altura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 258);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 2;
            label3.Text = "Base:";
            // 
            // textAltura
            // 
            textAltura.Location = new Point(139, 205);
            textAltura.Name = "textAltura";
            textAltura.Size = new Size(150, 31);
            textAltura.TabIndex = 3;
            textAltura.TextChanged += textAltura_TextChanged;
            // 
            // textBase
            // 
            textBase.Location = new Point(139, 258);
            textBase.Name = "textBase";
            textBase.Size = new Size(150, 31);
            textBase.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 343);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 5;
            label4.Text = "Resultado:";
            // 
            // textResultado
            // 
            textResultado.Location = new Point(267, 337);
            textResultado.Name = "textResultado";
            textResultado.ReadOnly = true;
            textResultado.Size = new Size(150, 31);
            textResultado.TabIndex = 6;
            // 
            // botonArea
            // 
            botonArea.BackColor = Color.PowderBlue;
            botonArea.Location = new Point(457, 166);
            botonArea.Name = "botonArea";
            botonArea.Size = new Size(156, 67);
            botonArea.TabIndex = 7;
            botonArea.Text = "Calcula área";
            botonArea.UseVisualStyleBackColor = false;
            botonArea.Click += botonArea_Click;
            // 
            // botonPerimetro
            // 
            botonPerimetro.BackColor = Color.Violet;
            botonPerimetro.Location = new Point(462, 239);
            botonPerimetro.Name = "botonPerimetro";
            botonPerimetro.Size = new Size(151, 61);
            botonPerimetro.TabIndex = 8;
            botonPerimetro.Text = "Calcura perímetro";
            botonPerimetro.UseVisualStyleBackColor = false;
            botonPerimetro.Click += botonPerimetro_Click;
            // 
            // botónLimpiar
            // 
            botónLimpiar.BackColor = Color.Salmon;
            botónLimpiar.Location = new Point(454, 399);
            botónLimpiar.Name = "botónLimpiar";
            botónLimpiar.Size = new Size(112, 34);
            botónLimpiar.TabIndex = 9;
            botónLimpiar.Text = "Limpiar";
            botónLimpiar.UseVisualStyleBackColor = false;
            botónLimpiar.Click += botonLimpiar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // botonCerrar
            // 
            botonCerrar.BackColor = Color.Khaki;
            botonCerrar.Location = new Point(602, 399);
            botonCerrar.Name = "botonCerrar";
            botonCerrar.Size = new Size(112, 34);
            botonCerrar.TabIndex = 11;
            botonCerrar.Text = "Cerrar";
            botonCerrar.UseVisualStyleBackColor = false;
            botonCerrar.Click += botonCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1077, 450);
            Controls.Add(botonCerrar);
            Controls.Add(pictureBox1);
            Controls.Add(botónLimpiar);
            Controls.Add(botonPerimetro);
            Controls.Add(botonArea);
            Controls.Add(textResultado);
            Controls.Add(label4);
            Controls.Add(textBase);
            Controls.Add(textAltura);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textAltura;
        private TextBox textBase;
        private Label label4;
        private TextBox textResultado;
        private Button botonArea;
        private Button botonPerimetro;
        private Button botónLimpiar;
        private PictureBox pictureBox1;
        private Button botonCerrar;
    }
}
