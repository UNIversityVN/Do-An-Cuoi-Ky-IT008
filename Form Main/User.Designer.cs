namespace Form_Main
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            button1 = new Button();
            button_return = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(412, 284);
            button1.Name = "button1";
            button1.Size = new Size(137, 42);
            button1.TabIndex = 0;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = true;
            // 
            // button_return
            // 
            button_return.FlatAppearance.BorderSize = 0;
            button_return.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            button_return.FlatStyle = FlatStyle.Flat;
            button_return.Image = (Image)resources.GetObject("button_return.Image");
            button_return.Location = new Point(57, 66);
            button_return.Name = "button_return";
            button_return.Size = new Size(53, 60);
            button_return.TabIndex = 1;
            button_return.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(159, 284);
            button2.Name = "button2";
            button2.Size = new Size(192, 47);
            button2.TabIndex = 2;
            button2.Text = "Đổi mật khẩu";
            button2.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button_return);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            Text = "User";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button_return;
        private Button button2;
    }
}