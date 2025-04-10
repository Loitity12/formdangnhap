namespace WinFormsApp1
{
    partial class formquenmatkhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formquenmatkhau));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 119);
            label1.Name = "label1";
            label1.Size = new Size(631, 100);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 272);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 49);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(455, 272);
            button1.Name = "button1";
            button1.Size = new Size(188, 49);
            button1.TabIndex = 2;
            button1.Text = "Cấp lại mật khẩu mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 42);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 3;
            label2.Text = "Hệ thống quên mật khẩu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(49, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(696, 387);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // formquenmatkhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "formquenmatkhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formquenmatkhau";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private GroupBox groupBox1;
    }
}