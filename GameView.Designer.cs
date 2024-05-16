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
            label3 = new Label();
            lTentativas = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResultado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridJogada).BeginInit();
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
            groupBox1.Size = new Size(926, 60);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jogada";
            // 
            // bJogar
            // 
            bJogar.Location = new Point(626, 15);
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
            dataGridResultado.Location = new Point(496, 108);
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
            label1.Location = new Point(18, 90);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Jogadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 90);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "Resultados";
            // 
            // dataGridJogada
            // 
            dataGridJogada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJogada.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridJogada.Location = new Point(18, 108);
            dataGridJogada.Name = "dataGridJogada";
            dataGridJogada.Size = new Size(448, 318);
            dataGridJogada.TabIndex = 5;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(815, 15);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Tentativas";
            // 
            // lTentativas
            // 
            lTentativas.AutoSize = true;
            lTentativas.Location = new Point(830, 35);
            lTentativas.Name = "lTentativas";
            lTentativas.Size = new Size(30, 15);
            lTentativas.TabIndex = 7;
            lTentativas.Text = "0/10";
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 450);
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
    }
}
