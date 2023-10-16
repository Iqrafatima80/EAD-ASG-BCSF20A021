namespace BCSF20A021_EAD_ASG1
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
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Box1 = new CheckedListBox();
            label3 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            result = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 52);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 132);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // Box1
            // 
            Box1.FormattingEnabled = true;
            Box1.Items.AddRange(new object[] { "PF", "OOP", "DSA", "Web", "Database", "Algo", "AI" });
            Box1.Location = new Point(207, 192);
            Box1.Name = "Box1";
            Box1.Size = new Size(120, 94);
            Box1.TabIndex = 4;
            Box1.SelectedIndexChanged += Box1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 203);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Subjects";
            // 
            // button1
            // 
            button1.Location = new Point(252, 363);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(204, 311);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Pre-requisite Clear";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(551, 271);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Box1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private CheckedListBox Box1;
        private Label label3;
        private Button button1;
        private CheckBox checkBox1;
        private Label result;
    }
}