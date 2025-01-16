namespace ProgettoTPS_sistema_prenotazione_sale_chirurgiche_
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 1;
            label1.Text = "NOME CHIRURGICO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria Math", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 2);
            label2.Name = "label2";
            label2.Size = new Size(253, 73);
            label2.TabIndex = 3;
            label2.Text = "SI PREGA DI SCEGLIERE UNA SALA";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria Math", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(462, -4);
            label3.Name = "label3";
            label3.Size = new Size(163, 84);
            label3.TabIndex = 4;
            label3.Text = "NOME PAZIENTE ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(478, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria Math", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(218, 270);
            button1.Name = "button1";
            button1.Size = new Size(346, 55);
            button1.TabIndex = 6;
            button1.Text = "MOSTRA LA PRIMA DATA DISPONIBILE ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Cambria Math", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(218, 331);
            button2.Name = "button2";
            button2.Size = new Size(346, 53);
            button2.TabIndex = 7;
            button2.Text = "MOSTRA UN'ALTRA DATA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(311, 213);
            button3.Name = "button3";
            button3.Size = new Size(161, 51);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Cambria Math", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(300, 390);
            button4.Name = "button4";
            button4.Size = new Size(182, 64);
            button4.TabIndex = 9;
            button4.Text = "PRENOTA SALA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria Math", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(641, 2);
            label4.Name = "label4";
            label4.Size = new Size(164, 73);
            label4.TabIndex = 10;
            label4.Text = "GRADO DI URGENZA";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Cambria Math", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(674, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 69);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "seleziona il grado ";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Cambria Math", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(270, 63);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 69);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "seleziona una sala";
            // 
            // button5
            // 
            button5.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(300, 460);
            button5.Name = "button5";
            button5.Size = new Size(171, 44);
            button5.TabIndex = 13;
            button5.Text = "CAMBIA UTENTE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(807, 541);
            Controls.Add(button5);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button5;
    }
}
