namespace SenhaCores
{
    partial class GameView
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
            groupBox1 = new GroupBox();
            lTentativas = new Label();
            label3 = new Label();
            bJogar = new Button();
            comboCamp5 = new ComboBox();
            comboCamp4 = new ComboBox();
            comboCamp3 = new ComboBox();
            comboCamp2 = new ComboBox();
            comboCamp = new ComboBox();
            dataGridResultado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dataGridJogada = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            lResult = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            bReiniciar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResultado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridJogada).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lTentativas);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(bJogar);
            groupBox1.Controls.Add(comboCamp5);
            groupBox1.Controls.Add(comboCamp4);
            groupBox1.Controls.Add(comboCamp3);
            groupBox1.Controls.Add(comboCamp2);
            groupBox1.Controls.Add(comboCamp);
            groupBox1.Location = new Point(18, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(902, 60);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jogada";
            // 
            // lTentativas
            // 
            lTentativas.AutoSize = true;
            lTentativas.Location = new Point(821, 35);
            lTentativas.Name = "lTentativas";
            lTentativas.Size = new Size(30, 15);
            lTentativas.TabIndex = 7;
            lTentativas.Text = "0/10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(807, 19);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Tentativas";
            // 
            // bJogar
            // 
            bJogar.Location = new Point(647, 15);
            bJogar.Name = "bJogar";
            bJogar.Size = new Size(131, 35);
            bJogar.TabIndex = 1;
            bJogar.Text = "Jogar";
            bJogar.UseVisualStyleBackColor = true;
            bJogar.Click += Play;
            // 
            // comboCamp5
            // 
            comboCamp5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCamp5.FormattingEnabled = true;
            comboCamp5.Items.AddRange(new object[] { "Vermelho", "Verde", "Amarelo", "Azul", "Branco", "Preto", "Rosa", "Cinza" });
            comboCamp5.Location = new Point(510, 22);
            comboCamp5.Name = "comboCamp5";
            comboCamp5.Size = new Size(95, 23);
            comboCamp5.TabIndex = 2;
            // 
            // comboCamp4
            // 
            comboCamp4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCamp4.FormattingEnabled = true;
            comboCamp4.Items.AddRange(new object[] { "Vermelho", "Verde", "Amarelo", "Azul", "Branco", "Preto", "Rosa", "Cinza" });
            comboCamp4.Location = new Point(384, 22);
            comboCamp4.Name = "comboCamp4";
            comboCamp4.Size = new Size(95, 23);
            comboCamp4.TabIndex = 3;
            // 
            // comboCamp3
            // 
            comboCamp3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCamp3.FormattingEnabled = true;
            comboCamp3.Items.AddRange(new object[] { "Vermelho", "Verde", "Amarelo", "Azul", "Branco", "Preto", "Rosa", "Cinza" });
            comboCamp3.Location = new Point(258, 22);
            comboCamp3.Name = "comboCamp3";
            comboCamp3.Size = new Size(95, 23);
            comboCamp3.TabIndex = 4;
            // 
            // comboCamp2
            // 
            comboCamp2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCamp2.FormattingEnabled = true;
            comboCamp2.Items.AddRange(new object[] { "Vermelho", "Verde", "Amarelo", "Azul", "Branco", "Preto", "Rosa", "Cinza" });
            comboCamp2.Location = new Point(132, 22);
            comboCamp2.Name = "comboCamp2";
            comboCamp2.Size = new Size(95, 23);
            comboCamp2.TabIndex = 5;
            // 
            // comboCamp
            // 
            comboCamp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCamp.FormattingEnabled = true;
            comboCamp.Items.AddRange(new object[] { "Vermelho", "Verde", "Amarelo", "Azul", "Branco", "Preto", "Rosa", "Cinza" });
            comboCamp.Location = new Point(6, 22);
            comboCamp.Name = "comboCamp";
            comboCamp.Size = new Size(95, 23);
            comboCamp.TabIndex = 1;
            // 
            // dataGridResultado
            // 
            dataGridResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResultado.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridResultado.Location = new Point(472, 156);
            dataGridResultado.Name = "dataGridResultado";
            dataGridResultado.Size = new Size(448, 318);
            dataGridResultado.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Campo 1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Campo 2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Campo 3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Campo 4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Campo 5";
            Column5.Name = "Column5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 128);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Jogadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 128);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "Resultados";
            // 
            // dataGridJogada
            // 
            dataGridJogada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJogada.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridJogada.Location = new Point(18, 156);
            dataGridJogada.Name = "dataGridJogada";
            dataGridJogada.Size = new Size(448, 318);
            dataGridJogada.TabIndex = 5;
            dataGridJogada.CellDoubleClick += RecarregarInfo;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Campo 1";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Campo 2";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Campo 3";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Campo 4";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Campo 5";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // lResult
            // 
            lResult.AutoSize = true;
            lResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lResult.Location = new Point(18, 85);
            lResult.Name = "lResult";
            lResult.Size = new Size(0, 32);
            lResult.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(18, 480);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(529, 84);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manual de resultados";
            // 
            // label9
            // 
            label9.Location = new Point(284, 34);
            label9.Name = "label9";
            label9.Size = new Size(125, 45);
            label9.TabIndex = 12;
            label9.Text = "A cor não está presente na senha";
            // 
            // label8
            // 
            label8.Location = new Point(129, 35);
            label8.Name = "label8";
            label8.Size = new Size(149, 46);
            label8.TabIndex = 11;
            label8.Text = "A cor existe na senha, mas sua posição é incorreta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 45);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 8;
            label7.Text = "Cor está na correta.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(284, 19);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 10;
            label6.Text = "Vermelho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.AppWorkspace;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(129, 19);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 9;
            label5.Text = "Branco";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "Preto";
            // 
            // bReiniciar
            // 
            bReiniciar.Enabled = false;
            bReiniciar.Location = new Point(789, 506);
            bReiniciar.Name = "bReiniciar";
            bReiniciar.Size = new Size(131, 35);
            bReiniciar.TabIndex = 8;
            bReiniciar.Text = "Reiniciar";
            bReiniciar.UseVisualStyleBackColor = true;
            bReiniciar.Click += Restart;
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 576);
            Controls.Add(bReiniciar);
            Controls.Add(groupBox2);
            Controls.Add(lResult);
            Controls.Add(dataGridJogada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridResultado);
            Controls.Add(groupBox1);
            Name = "GameView";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResultado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridJogada).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboCamp;
        private Button bJogar;
        private ComboBox comboCamp5;
        private ComboBox comboCamp4;
        private ComboBox comboCamp3;
        private ComboBox comboCamp2;
        private DataGridView dataGridResultado;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dataGridJogada;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label lTentativas;
        private Label label3;
        private Label lResult;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label9;
        private Button bReiniciar;
    }
}
