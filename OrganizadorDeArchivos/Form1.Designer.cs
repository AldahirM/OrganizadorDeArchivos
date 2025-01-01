namespace OrganizadorDeArchivos
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
            Attrib = new Button();
            btnOrdenar = new Button();
            listBox1 = new ListBox();
            btnSeleccionar = new Button();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Attrib
            // 
            Attrib.BackColor = Color.Snow;
            Attrib.Font = new Font("Showcard Gothic", 9.75F);
            Attrib.Location = new Point(12, 178);
            Attrib.Name = "Attrib";
            Attrib.Size = new Size(150, 42);
            Attrib.TabIndex = 8;
            Attrib.Text = "Ejecutar Attrib";
            Attrib.UseVisualStyleBackColor = false;
            Attrib.Click += Attrib_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.Snow;
            btnOrdenar.Font = new Font("Showcard Gothic", 9.75F);
            btnOrdenar.Location = new Point(12, 103);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(150, 43);
            btnOrdenar.TabIndex = 7;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.MintCream;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(168, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(387, 334);
            listBox1.TabIndex = 6;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.Snow;
            btnSeleccionar.Font = new Font("Showcard Gothic", 9.75F);
            btnSeleccionar.Location = new Point(12, 35);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(150, 44);
            btnSeleccionar.TabIndex = 5;
            btnSeleccionar.Text = "Seleccionar Ruta";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.MintCream;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(168, 416);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(387, 109);
            listBox2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(210, 7);
            label1.Name = "label1";
            label1.Size = new Size(299, 27);
            label1.TabIndex = 10;
            label1.Text = "ARCHIVOS ENCONTRADOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 386);
            label2.Name = "label2";
            label2.Size = new Size(406, 27);
            label2.TabIndex = 11;
            label2.Text = "ARCHIVOS CAMBIADOS DE NOMBRE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(573, 554);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(Attrib);
            Controls.Add(btnOrdenar);
            Controls.Add(listBox1);
            Controls.Add(btnSeleccionar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Attrib;
        private Button btnOrdenar;
        private ListBox listBox1;
        private Button btnSeleccionar;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
    }
}
