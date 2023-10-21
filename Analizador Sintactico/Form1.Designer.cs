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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}