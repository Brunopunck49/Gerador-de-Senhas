namespace GeradorDeSenha
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
            senhaTexto = new Label();
            tamanhoSenhaTexto = new Label();
            tamanhoSenhaSlider = new TrackBar();
            copiarSenhaBotao = new Button();
            senhaGerar = new Button();
            ((System.ComponentModel.ISupportInitialize)tamanhoSenhaSlider).BeginInit();
            SuspendLayout();
            // 
            // senhaTexto
            // 
            senhaTexto.Font = new Font("Cascadia Mono", 24F, FontStyle.Regular, GraphicsUnit.Point);
            senhaTexto.Location = new Point(12, 104);
            senhaTexto.Name = "senhaTexto";
            senhaTexto.Size = new Size(783, 49);
            senhaTexto.TabIndex = 0;
            senhaTexto.Text = "Senha";
            senhaTexto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tamanhoSenhaTexto
            // 
            tamanhoSenhaTexto.Font = new Font("Cascadia Mono", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tamanhoSenhaTexto.Location = new Point(186, 211);
            tamanhoSenhaTexto.Name = "tamanhoSenhaTexto";
            tamanhoSenhaTexto.Size = new Size(430, 49);
            tamanhoSenhaTexto.TabIndex = 1;
            tamanhoSenhaTexto.Text = "Tamanho da Senha: 5";
            tamanhoSenhaTexto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tamanhoSenhaSlider
            // 
            tamanhoSenhaSlider.Location = new Point(186, 285);
            tamanhoSenhaSlider.Name = "tamanhoSenhaSlider";
            tamanhoSenhaSlider.Size = new Size(430, 45);
            tamanhoSenhaSlider.TabIndex = 2;
            tamanhoSenhaSlider.Scroll += tamanhoSenhaSlider_Scroll;
            // 
            // copiarSenhaBotao
            // 
            copiarSenhaBotao.BackColor = Color.FromArgb(224, 224, 224);
            copiarSenhaBotao.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            copiarSenhaBotao.Location = new Point(186, 336);
            copiarSenhaBotao.Name = "copiarSenhaBotao";
            copiarSenhaBotao.Size = new Size(430, 82);
            copiarSenhaBotao.TabIndex = 3;
            copiarSenhaBotao.Text = "Copiar Senha";
            copiarSenhaBotao.UseVisualStyleBackColor = false;
            copiarSenhaBotao.Click += copiarSenhaBotao_Click;
            // 
            // senhaGerar
            // 
            senhaGerar.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            senhaGerar.Location = new Point(186, 436);
            senhaGerar.Name = "senhaGerar";
            senhaGerar.Size = new Size(430, 59);
            senhaGerar.TabIndex = 4;
            senhaGerar.Text = "Gerar Nova Senha";
            senhaGerar.UseVisualStyleBackColor = true;
            senhaGerar.Click += senhaGerar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(807, 523);
            Controls.Add(senhaGerar);
            Controls.Add(copiarSenhaBotao);
            Controls.Add(tamanhoSenhaSlider);
            Controls.Add(tamanhoSenhaTexto);
            Controls.Add(senhaTexto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Gerador de Senhas";
            ((System.ComponentModel.ISupportInitialize)tamanhoSenhaSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label senhaTexto;
        private Label tamanhoSenhaTexto;
        private TrackBar tamanhoSenhaSlider;
        private Button copiarSenhaBotao;
        private Button senhaGerar;
    }
}