namespace RSA
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
            inputE = new TextBox();
            inputN = new TextBox();
            label2 = new Label();
            label1 = new Label();
            inputQ = new TextBox();
            inputD = new TextBox();
            inputP = new TextBox();
            CalculateNbutton = new Button();
            GenerateRandom = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            buttonEncrypt = new Button();
            DecryptedText = new TextBox();
            EncryptedText = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            buttonDecrypt = new Button();
            TextInput = new TextBox();
            label10 = new Label();
            label11 = new Label();
            ValidNnotnum = new Label();
            ValidEnotnum = new Label();
            ValidPnotnum = new Label();
            ValidQnotnum = new Label();
            ValidDnotnum = new Label();
            ValidPnotcommonnum = new Label();
            ValidQnotcommonnum = new Label();
            CalculateD = new Button();
            label12 = new Label();
            label13 = new Label();
            ValidMutualycommon = new Label();
            label9 = new Label();
            label14 = new Label();
            label15 = new Label();
            ChooseFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            EncryptFile = new Button();
            saveFileDialog1 = new SaveFileDialog();
            DecryptFile = new Button();
            SuspendLayout();
            // 
            // inputE
            // 
            inputE.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            inputE.Location = new Point(55, 127);
            inputE.Name = "inputE";
            inputE.Size = new Size(270, 32);
            inputE.TabIndex = 11;
            inputE.TextChanged += inputE_TextChanged;
            // 
            // inputN
            // 
            inputN.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            inputN.Location = new Point(55, 63);
            inputN.Name = "inputN";
            inputN.Size = new Size(270, 32);
            inputN.TabIndex = 10;
            inputN.TextChanged += inputN_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 130);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 9;
            label2.Text = "e =";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 66);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 8;
            label1.Text = "n =";
            // 
            // inputQ
            // 
            inputQ.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            inputQ.Location = new Point(385, 63);
            inputQ.Name = "inputQ";
            inputQ.Size = new Size(270, 32);
            inputQ.TabIndex = 21;
            inputQ.TextChanged += inputQ_TextChanged;
            // 
            // inputD
            // 
            inputD.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            inputD.Location = new Point(385, 191);
            inputD.Name = "inputD";
            inputD.Size = new Size(270, 32);
            inputD.TabIndex = 20;
            inputD.TextChanged += inputD_TextChanged;
            // 
            // inputP
            // 
            inputP.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            inputP.Location = new Point(385, 127);
            inputP.Name = "inputP";
            inputP.Size = new Size(270, 32);
            inputP.TabIndex = 19;
            inputP.TextChanged += inputP_TextChanged;
            // 
            // CalculateNbutton
            // 
            CalculateNbutton.Enabled = false;
            CalculateNbutton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CalculateNbutton.Location = new Point(57, 191);
            CalculateNbutton.Name = "CalculateNbutton";
            CalculateNbutton.Size = new Size(270, 32);
            CalculateNbutton.TabIndex = 17;
            CalculateNbutton.Text = "Вычислить n";
            CalculateNbutton.UseVisualStyleBackColor = true;
            CalculateNbutton.Click += CalculateNbutton_Click;
            // 
            // GenerateRandom
            // 
            GenerateRandom.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            GenerateRandom.Location = new Point(57, 255);
            GenerateRandom.Name = "GenerateRandom";
            GenerateRandom.Size = new Size(270, 32);
            GenerateRandom.TabIndex = 13;
            GenerateRandom.Text = "Создать случайные числа";
            GenerateRandom.UseVisualStyleBackColor = true;
            GenerateRandom.Click += GenerateRandom_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(340, 195);
            label5.Name = "label5";
            label5.Size = new Size(41, 25);
            label5.TabIndex = 13;
            label5.Text = "d =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(340, 130);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 12;
            label4.Text = "p =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(340, 66);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 11;
            label3.Text = "q =";
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Enabled = false;
            buttonEncrypt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEncrypt.Location = new Point(482, 364);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(180, 32);
            buttonEncrypt.TabIndex = 1;
            buttonEncrypt.Text = "Зашифровать текст";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // DecryptedText
            // 
            DecryptedText.Enabled = false;
            DecryptedText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DecryptedText.Location = new Point(10, 594);
            DecryptedText.Multiline = true;
            DecryptedText.Name = "DecryptedText";
            DecryptedText.ReadOnly = true;
            DecryptedText.ScrollBars = ScrollBars.Vertical;
            DecryptedText.Size = new Size(456, 100);
            DecryptedText.TabIndex = 17;
            // 
            // EncryptedText
            // 
            EncryptedText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EncryptedText.Location = new Point(10, 464);
            EncryptedText.Multiline = true;
            EncryptedText.Name = "EncryptedText";
            EncryptedText.ScrollBars = ScrollBars.Vertical;
            EncryptedText.Size = new Size(454, 100);
            EncryptedText.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 434);
            label8.Name = "label8";
            label8.Size = new Size(308, 25);
            label8.TabIndex = 15;
            label8.Text = "Ваш текст в зашифрованном виде";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 564);
            label7.Name = "label7";
            label7.Size = new Size(218, 25);
            label7.TabIndex = 14;
            label7.Text = "Расшифрованный текст";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 300);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 13;
            label6.Text = "Ваш текст";
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Enabled = false;
            buttonDecrypt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecrypt.Location = new Point(482, 496);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(180, 32);
            buttonDecrypt.TabIndex = 3;
            buttonDecrypt.Text = "Расшифровать текст";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // TextInput
            // 
            TextInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextInput.Location = new Point(10, 330);
            TextInput.Multiline = true;
            TextInput.Name = "TextInput";
            TextInput.ScrollBars = ScrollBars.Vertical;
            TextInput.Size = new Size(453, 100);
            TextInput.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(10, 10);
            label10.Name = "label10";
            label10.Size = new Size(219, 25);
            label10.TabIndex = 22;
            label10.Text = "Числа открытого ключа";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(340, 9);
            label11.Name = "label11";
            label11.Size = new Size(218, 25);
            label11.TabIndex = 23;
            label11.Text = "Числа закрытого ключа";
            // 
            // ValidNnotnum
            // 
            ValidNnotnum.AutoSize = true;
            ValidNnotnum.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ValidNnotnum.ForeColor = Color.Red;
            ValidNnotnum.Location = new Point(80, 35);
            ValidNnotnum.Name = "ValidNnotnum";
            ValidNnotnum.Size = new Size(229, 25);
            ValidNnotnum.TabIndex = 24;
            ValidNnotnum.Text = "Введите целое число > 1";
            ValidNnotnum.Visible = false;
            // 
            // ValidEnotnum
            // 
            ValidEnotnum.AutoSize = true;
            ValidEnotnum.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ValidEnotnum.ForeColor = Color.Red;
            ValidEnotnum.Location = new Point(80, 98);
            ValidEnotnum.Name = "ValidEnotnum";
            ValidEnotnum.Size = new Size(229, 25);
            ValidEnotnum.TabIndex = 25;
            ValidEnotnum.Text = "Введите целое число > 1";
            ValidEnotnum.Visible = false;
            // 
            // ValidPnotnum
            // 
            ValidPnotnum.AutoSize = true;
            ValidPnotnum.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ValidPnotnum.ForeColor = Color.Red;
            ValidPnotnum.Location = new Point(405, 98);
            ValidPnotnum.Name = "ValidPnotnum";
            ValidPnotnum.Size = new Size(229, 25);
            ValidPnotnum.TabIndex = 26;
            ValidPnotnum.Text = "Введите целое число > 1";
            ValidPnotnum.Visible = false;
            // 
            // ValidQnotnum
            // 
            ValidQnotnum.AutoSize = true;
            ValidQnotnum.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ValidQnotnum.ForeColor = Color.Red;
            ValidQnotnum.Location = new Point(405, 34);
            ValidQnotnum.Name = "ValidQnotnum";
            ValidQnotnum.Size = new Size(229, 25);
            ValidQnotnum.TabIndex = 27;
            ValidQnotnum.Text = "Введите целое число > 1";
            ValidQnotnum.Visible = false;
            // 
            // ValidDnotnum
            // 
            ValidDnotnum.AutoSize = true;
            ValidDnotnum.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ValidDnotnum.ForeColor = Color.Red;
            ValidDnotnum.Location = new Point(405, 162);
            ValidDnotnum.Name = "ValidDnotnum";
            ValidDnotnum.Size = new Size(229, 25);
            ValidDnotnum.TabIndex = 28;
            ValidDnotnum.Text = "Введите целое число > 1";
            ValidDnotnum.Visible = false;
            // 
            // ValidPnotcommonnum
            // 
            ValidPnotcommonnum.AutoSize = true;
            ValidPnotcommonnum.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ValidPnotcommonnum.ForeColor = Color.Red;
            ValidPnotcommonnum.Location = new Point(395, 99);
            ValidPnotcommonnum.Name = "ValidPnotcommonnum";
            ValidPnotcommonnum.Size = new Size(244, 25);
            ValidPnotcommonnum.TabIndex = 31;
            ValidPnotcommonnum.Text = "Введено не простое число";
            ValidPnotcommonnum.Visible = false;
            ValidPnotcommonnum.Click += ValidPnotcommonnum_Click;
            // 
            // ValidQnotcommonnum
            // 
            ValidQnotcommonnum.AutoSize = true;
            ValidQnotcommonnum.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ValidQnotcommonnum.ForeColor = Color.Red;
            ValidQnotcommonnum.Location = new Point(395, 34);
            ValidQnotcommonnum.Name = "ValidQnotcommonnum";
            ValidQnotcommonnum.Size = new Size(244, 25);
            ValidQnotcommonnum.TabIndex = 32;
            ValidQnotcommonnum.Text = "Введено не простое число";
            ValidQnotcommonnum.Visible = false;
            // 
            // CalculateD
            // 
            CalculateD.Enabled = false;
            CalculateD.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CalculateD.Location = new Point(390, 255);
            CalculateD.Name = "CalculateD";
            CalculateD.Size = new Size(270, 32);
            CalculateD.TabIndex = 34;
            CalculateD.Text = "Вычислить d";
            CalculateD.UseVisualStyleBackColor = true;
            CalculateD.Click += CalculateD_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(109, 162);
            label12.Name = "label12";
            label12.Size = new Size(170, 25);
            label12.TabIndex = 35;
            label12.Text = "Необходимо p и q";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(426, 226);
            label13.Name = "label13";
            label13.Size = new Size(189, 25);
            label13.TabIndex = 36;
            label13.Text = "Необходимо p, q и e";
            // 
            // ValidMutualycommon
            // 
            ValidMutualycommon.AutoSize = true;
            ValidMutualycommon.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ValidMutualycommon.ForeColor = Color.Red;
            ValidMutualycommon.Location = new Point(58, 99);
            ValidMutualycommon.Name = "ValidMutualycommon";
            ValidMutualycommon.Size = new Size(260, 25);
            ValidMutualycommon.TabIndex = 37;
            ValidMutualycommon.Text = "НОД (e, ф(n)) =1 и 2<e<ф(n) ";
            ValidMutualycommon.Visible = false;
            ValidMutualycommon.Click += ValidMutualycommon_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(485, 311);
            label9.Name = "label9";
            label9.Size = new Size(180, 50);
            label9.TabIndex = 38;
            label9.Text = "Требуются числа открытого ключа";
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(482, 443);
            label14.Name = "label14";
            label14.Size = new Size(180, 50);
            label14.TabIndex = 39;
            label14.Text = "Требуются числа закрытого ключа";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(50, 227);
            label15.Name = "label15";
            label15.Size = new Size(286, 25);
            label15.TabIndex = 40;
            label15.Text = "Может занять несколько минут";
            // 
            // ChooseFile
            // 
            ChooseFile.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseFile.Location = new Point(482, 586);
            ChooseFile.Name = "ChooseFile";
            ChooseFile.Size = new Size(180, 32);
            ChooseFile.TabIndex = 41;
            ChooseFile.Text = "Выбрать файл";
            ChooseFile.UseVisualStyleBackColor = true;
            ChooseFile.Click += ChooseFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // EncryptFile
            // 
            EncryptFile.Enabled = false;
            EncryptFile.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EncryptFile.Location = new Point(482, 624);
            EncryptFile.Name = "EncryptFile";
            EncryptFile.Size = new Size(180, 32);
            EncryptFile.TabIndex = 0;
            EncryptFile.Text = "Зашифровать файл";
            EncryptFile.UseVisualStyleBackColor = true;
            EncryptFile.Click += EncryptFile_Click;
            // 
            // DecryptFile
            // 
            DecryptFile.Enabled = false;
            DecryptFile.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DecryptFile.Location = new Point(482, 662);
            DecryptFile.Name = "DecryptFile";
            DecryptFile.Size = new Size(180, 32);
            DecryptFile.TabIndex = 42;
            DecryptFile.Text = "Расшифровать файл";
            DecryptFile.UseVisualStyleBackColor = true;
            DecryptFile.Click += DecryptFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 701);
            Controls.Add(DecryptFile);
            Controls.Add(EncryptFile);
            Controls.Add(ChooseFile);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(ValidMutualycommon);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(CalculateD);
            Controls.Add(ValidQnotcommonnum);
            Controls.Add(ValidPnotcommonnum);
            Controls.Add(ValidDnotnum);
            Controls.Add(ValidQnotnum);
            Controls.Add(ValidPnotnum);
            Controls.Add(ValidEnotnum);
            Controls.Add(ValidNnotnum);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(inputN);
            Controls.Add(inputE);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(inputP);
            Controls.Add(inputD);
            Controls.Add(inputQ);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(EncryptedText);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(CalculateNbutton);
            Controls.Add(buttonEncrypt);
            Controls.Add(GenerateRandom);
            Controls.Add(DecryptedText);
            Controls.Add(buttonDecrypt);
            Controls.Add(TextInput);
            MaximizeBox = false;
            MaximumSize = new Size(690, 740);
            MinimizeBox = false;
            MinimumSize = new Size(690, 740);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Шифровка по алгоритму RSA";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonEncrypt;
        private Button buttonDecrypt;
        private TextBox TextInput;
        private Button GenerateRandom;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button CalculateNbutton;
        private TextBox DecryptedText;
        private TextBox EncryptedText;
        private TextBox inputE;
        private TextBox inputN;
        private TextBox inputQ;
        private TextBox inputD;
        private TextBox inputP;
        private Label label10;
        private Label label11;
        private Label ValidNnotnum;
        private Label ValidEnotnum;
        private Label ValidPnotnum;
        private Label ValidQnotnum;
        private Label ValidDnotnum;
        private Label ValidPnotcommonnum;
        private Label ValidQnotcommonnum;
        private Button CalculateD;
        private Label label12;
        private Label label13;
        private Label ValidMutualycommon;
        private Label label9;
        private Label label14;
        private Label label15;
        private Button ChooseFile;
        private OpenFileDialog openFileDialog1;
        private Button EncryptFile;
        private SaveFileDialog saveFileDialog1;
        private Button DecryptFile;
    }
}