
namespace Exemplo
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
            inputTextX = new TextBox();
            btnSoma = new Button();
            labelTitle = new Label();
            labelOutput = new Label();
            inputTextY = new TextBox();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnXaoq = new Button();
            btnRaiz = new Button();
            btnPorcentagem = new Button();
            btnBinario = new Button();
            btnXelevy = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(61, 77);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(191, 31);
            inputTextX.TabIndex = 1;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.FromArgb(255, 127, 84);
            btnSoma.Cursor = Cursors.Hand;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSoma.ForeColor = SystemColors.ButtonFace;
            btnSoma.ImageAlign = ContentAlignment.TopCenter;
            btnSoma.Location = new Point(60, 171);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(60, 44);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(12, 9);
            labelTitle.MaximumSize = new Size(300, 65);
            labelTitle.MinimumSize = new Size(300, 65);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Calculator";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.FromArgb(40, 42, 54);
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(394, 15);
            labelOutput.MaximumSize = new Size(400, 350);
            labelOutput.MinimumSize = new Size(400, 350);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10);
            labelOutput.Size = new Size(400, 350);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "...";
            labelOutput.TextAlign = ContentAlignment.TopRight;
            labelOutput.Visible = false;
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(61, 114);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(191, 31);
            inputTextY.TabIndex = 2;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.FromArgb(255, 127, 84);
            btnSubtracao.Cursor = Cursors.Hand;
            btnSubtracao.FlatStyle = FlatStyle.Flat;
            btnSubtracao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubtracao.ForeColor = SystemColors.ButtonFace;
            btnSubtracao.Location = new Point(126, 171);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(60, 44);
            btnSubtracao.TabIndex = 5;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.FromArgb(255, 127, 84);
            btnMultiplicacao.Cursor = Cursors.Hand;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMultiplicacao.ForeColor = SystemColors.ButtonFace;
            btnMultiplicacao.Location = new Point(192, 171);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(60, 44);
            btnMultiplicacao.TabIndex = 6;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.FromArgb(255, 127, 84);
            btnDivisao.Cursor = Cursors.Hand;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDivisao.ForeColor = SystemColors.ButtonFace;
            btnDivisao.Location = new Point(60, 243);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(60, 44);
            btnDivisao.TabIndex = 7;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnXaoq
            // 
            btnXaoq.BackColor = Color.FromArgb(255, 127, 84);
            btnXaoq.Cursor = Cursors.Hand;
            btnXaoq.FlatStyle = FlatStyle.Flat;
            btnXaoq.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXaoq.ForeColor = SystemColors.ButtonFace;
            btnXaoq.Location = new Point(126, 243);
            btnXaoq.Name = "btnXaoq";
            btnXaoq.Size = new Size(60, 44);
            btnXaoq.TabIndex = 12;
            btnXaoq.Text = "X²";
            btnXaoq.UseVisualStyleBackColor = false;
            btnXaoq.Click += btnAoQ_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.FromArgb(255, 127, 84);
            btnRaiz.Cursor = Cursors.Hand;
            btnRaiz.FlatStyle = FlatStyle.Flat;
            btnRaiz.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRaiz.ForeColor = SystemColors.ButtonFace;
            btnRaiz.Location = new Point(192, 243);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(60, 44);
            btnRaiz.TabIndex = 13;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = Color.FromArgb(255, 127, 84);
            btnPorcentagem.Cursor = Cursors.Hand;
            btnPorcentagem.FlatStyle = FlatStyle.Flat;
            btnPorcentagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPorcentagem.ForeColor = SystemColors.ButtonFace;
            btnPorcentagem.Location = new Point(60, 321);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(60, 44);
            btnPorcentagem.TabIndex = 14;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // btnBinario
            // 
            btnBinario.BackColor = Color.FromArgb(255, 127, 84);
            btnBinario.Cursor = Cursors.Hand;
            btnBinario.FlatStyle = FlatStyle.Flat;
            btnBinario.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            btnBinario.ForeColor = SystemColors.ButtonFace;
            btnBinario.Location = new Point(126, 321);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(60, 44);
            btnBinario.TabIndex = 15;
            btnBinario.Text = "010101";
            btnBinario.UseVisualStyleBackColor = false;
            btnBinario.Click += btnBinario_Click;
            // 
            // btnXelevy
            // 
            btnXelevy.BackColor = Color.FromArgb(255, 127, 84);
            btnXelevy.Cursor = Cursors.Hand;
            btnXelevy.FlatStyle = FlatStyle.Flat;
            btnXelevy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXelevy.ForeColor = SystemColors.ButtonFace;
            btnXelevy.Location = new Point(192, 321);
            btnXelevy.Name = "btnXelevy";
            btnXelevy.Size = new Size(60, 44);
            btnXelevy.TabIndex = 16;
            btnXelevy.Text = "x^y";
            btnXelevy.UseVisualStyleBackColor = false;
            btnXelevy.Click += btnXelevy_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.FromArgb(40, 42, 54);
            labelResult.Font = new Font("Segoe UI", 30F);
            labelResult.ForeColor = Color.FromArgb(255, 127, 84);
            labelResult.Location = new Point(394, 145);
            labelResult.MaximumSize = new Size(400, 70);
            labelResult.MinimumSize = new Size(400, 70);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(400, 70);
            labelResult.TabIndex = 17;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            labelResult.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 83, 102);
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(btnXelevy);
            Controls.Add(btnBinario);
            Controls.Add(btnPorcentagem);
            Controls.Add(btnRaiz);
            Controls.Add(btnXaoq);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(inputTextY);
            Controls.Add(labelOutput);
            Controls.Add(labelTitle);
            Controls.Add(btnSoma);
            Controls.Add(inputTextX);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox inputTextX;
        private Button btnSoma;
        private Label labelTitle;
        private Label labelOutput;
        private TextBox inputTextY;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnXaoq;
        private Button btnRaiz;
        private Button btnPorcentagem;
        private Button btnBinario;
        private Button btnXelevy;
        private Label labelResult;
    }
}
