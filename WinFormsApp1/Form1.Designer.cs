namespace WinFormsApp1
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
            label4 = new Label();
            label5 = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtGenero = new TextBox();
            txtISBN = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(173, 25);
            label1.Name = "label1";
            label1.Size = new Size(88, 35);
            label1.TabIndex = 0;
            label1.Text = "Titulo ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(0, 25);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 1;
            label2.Text = "Autor ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(326, 30);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 2;
            label3.Text = "Genero ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(6, 111);
            label4.Name = "label4";
            label4.Size = new Size(57, 30);
            label4.TabIndex = 3;
            label4.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(134, 111);
            label5.Name = "label5";
            label5.Size = new Size(192, 30);
            label5.TabIndex = 4;
            label5.Text = "Data de Publicacao ";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(161, 58);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 5;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(0, 58);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 6;
            txtAutor.TextChanged += txtAutor_TextChanged;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(309, 58);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(100, 23);
            txtGenero.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(6, 144);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 8;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(86, 22);
            toolStripLabel1.Text = "Cadastro Livro ";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(52, 22);
            toolStripLabel2.Text = "Clientes ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(134, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(658, 309);
            button1.Name = "button1";
            button1.Size = new Size(142, 150);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(toolStrip1);
            Controls.Add(txtISBN);
            Controls.Add(txtGenero);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cadastro Livro ";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtGenero;
        private TextBox txtISBN;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private DateTimePicker dateTimePicker1;
        private ToolStripLabel toolStripLabel2;
        private Button button1;
    }
}