namespace Analizador_Sintactico
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
            txtbCodigo = new TextBox();
            btnAnalizar = new Button();
            lvLexico = new ListView();
            Token = new ColumnHeader();
            Lexema = new ColumnHeader();
            Número = new ColumnHeader();
            lvSintactico = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtbCodigo
            // 
            txtbCodigo.Location = new Point(12, 37);
            txtbCodigo.Multiline = true;
            txtbCodigo.Name = "txtbCodigo";
            txtbCodigo.Size = new Size(397, 401);
            txtbCodigo.TabIndex = 0;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Location = new Point(425, 37);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(112, 23);
            btnAnalizar.TabIndex = 1;
            btnAnalizar.Text = "Analizar";
            btnAnalizar.UseVisualStyleBackColor = true;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // lvLexico
            // 
            lvLexico.Columns.AddRange(new ColumnHeader[] { Token, Lexema, Número });
            lvLexico.Location = new Point(425, 81);
            lvLexico.Name = "lvLexico";
            lvLexico.Size = new Size(363, 130);
            lvLexico.TabIndex = 2;
            lvLexico.UseCompatibleStateImageBehavior = false;
            lvLexico.View = View.Details;
            // 
            // Token
            // 
            Token.Text = "Token";
            Token.Width = 120;
            // 
            // Lexema
            // 
            Lexema.Text = "Lexema";
            Lexema.Width = 120;
            // 
            // Número
            // 
            Número.Text = "Número";
            Número.Width = 120;
            // 
            // lvSintactico
            // 
            lvSintactico.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvSintactico.Location = new Point(425, 308);
            lvSintactico.Name = "lvSintactico";
            lvSintactico.Size = new Size(363, 130);
            lvSintactico.TabIndex = 3;
            lvSintactico.UseCompatibleStateImageBehavior = false;
            lvSintactico.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Token";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Lexema";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Número";
            columnHeader3.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(568, 63);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "Lexico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(568, 290);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Sintactico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 19);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Codigo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvSintactico);
            Controls.Add(lvLexico);
            Controls.Add(btnAnalizar);
            Controls.Add(txtbCodigo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbCodigo;
        private Button btnAnalizar;
        private ListView lvLexico;
        private ColumnHeader Token;
        private ColumnHeader Lexema;
        private ColumnHeader Número;
        private ListView lvSintactico;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}