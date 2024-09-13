namespace DemoOO
{
    partial class FormCreatCustomers
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            labelName = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Anna";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Anna@mail.com";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 257);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "0046728533222";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(84, 74);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            labelName.Click += labelName_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(84, 144);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            labelEmail.Click += label2_Click;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(84, 224);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(50, 20);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Phone";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(128, 311);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(165, 33);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Spara en ny kund";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // FormCreatCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 411);
            Controls.Add(buttonSave);
            Controls.Add(labelPhone);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormCreatCustomers";
            Text = "Spara en nhy kund";
            Load += FormCreatCustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelName;
        private Label labelEmail;
        private Label labelPhone;
        private Button buttonSave;
    }
}
