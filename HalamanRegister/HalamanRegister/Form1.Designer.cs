namespace HalamanRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            USERNAME = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(261, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(261, 262);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(342, 317);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            // 
            // USERNAME
            // 
            USERNAME.ForeColor = SystemColors.ScrollBar;
            USERNAME.Location = new Point(261, 162);
            USERNAME.Name = "USERNAME";
            USERNAME.Size = new Size(253, 27);
            USERNAME.TabIndex = 3;
            USERNAME.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, -29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(261, 124);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 5;
            label1.Text = "Please register !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 165);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 6;
            label2.Text = "username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 216);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 7;
            label3.Text = "password :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 265);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 8;
            label4.Text = "Re-Enter Password :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(USERNAME);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox USERNAME;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
