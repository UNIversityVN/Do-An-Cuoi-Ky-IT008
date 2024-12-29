namespace Project___Review_RBT
{
    partial class RedBlackForm
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
            components = new System.ComponentModel.Container();
            panel_header = new Panel();
            label1 = new Label();
            panel_function = new Panel();
            button1 = new Button();
            label2 = new Label();
            button_insert = new Button();
            trackBar_speedanimation = new TrackBar();
            textBox_insert = new TextBox();
            button_find = new Button();
            textBox_find = new TextBox();
            button_delete = new Button();
            textBox_delete = new TextBox();
            panel_main = new Panel();
            Label_Explanation = new Label();
            Insert_RBT_Timer = new System.Windows.Forms.Timer(components);
            PathToNode_Timer = new System.Windows.Forms.Timer(components);
            Insert_BST_Timer = new System.Windows.Forms.Timer(components);
            Delay_PathToNode = new System.Windows.Forms.Timer(components);
            Delete_Node_Timer = new System.Windows.Forms.Timer(components);
            panel_header.SuspendLayout();
            panel_function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_speedanimation).BeginInit();
            panel_main.SuspendLayout();
            SuspendLayout();
            // 
            // panel_header
            // 
            panel_header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_header.BackColor = Color.Green;
            panel_header.BorderStyle = BorderStyle.Fixed3D;
            panel_header.Controls.Add(label1);
            panel_header.Location = new Point(1, 1);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1232, 47);
            panel_header.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(18, 6);
            label1.Name = "label1";
            label1.Size = new Size(360, 33);
            label1.TabIndex = 0;
            label1.Text = "REVIEW RED-BLACK TREE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_function
            // 
            panel_function.BackColor = Color.FromArgb(192, 255, 192);
            panel_function.BorderStyle = BorderStyle.Fixed3D;
            panel_function.Controls.Add(button1);
            panel_function.Controls.Add(label2);
            panel_function.Controls.Add(button_insert);
            panel_function.Controls.Add(trackBar_speedanimation);
            panel_function.Controls.Add(textBox_insert);
            panel_function.Controls.Add(button_find);
            panel_function.Controls.Add(textBox_find);
            panel_function.Controls.Add(button_delete);
            panel_function.Controls.Add(textBox_delete);
            panel_function.Location = new Point(1, 45);
            panel_function.Name = "panel_function";
            panel_function.Size = new Size(1232, 41);
            panel_function.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(797, 3);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 13;
            button1.Text = "Pause";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(881, 7);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 8;
            label2.Text = "Animation speed";
            // 
            // button_insert
            // 
            button_insert.BackColor = Color.White;
            button_insert.Location = new Point(4, 7);
            button_insert.Name = "button_insert";
            button_insert.Size = new Size(64, 27);
            button_insert.TabIndex = 9;
            button_insert.Text = "Insert";
            button_insert.UseVisualStyleBackColor = false;
            button_insert.Click += button_insert_Click;
            // 
            // trackBar_speedanimation
            // 
            trackBar_speedanimation.AutoSize = false;
            trackBar_speedanimation.BackColor = Color.FromArgb(255, 255, 128);
            trackBar_speedanimation.Location = new Point(1024, 3);
            trackBar_speedanimation.Maximum = 500;
            trackBar_speedanimation.Minimum = 10;
            trackBar_speedanimation.Name = "trackBar_speedanimation";
            trackBar_speedanimation.Size = new Size(206, 36);
            trackBar_speedanimation.TabIndex = 6;
            trackBar_speedanimation.TickFrequency = 20;
            trackBar_speedanimation.Value = 250;
            // 
            // textBox_insert
            // 
            textBox_insert.Location = new Point(73, 7);
            textBox_insert.Name = "textBox_insert";
            textBox_insert.Size = new Size(157, 27);
            textBox_insert.TabIndex = 6;
            // 
            // button_find
            // 
            button_find.BackColor = Color.White;
            button_find.Location = new Point(236, 6);
            button_find.Name = "button_find";
            button_find.Size = new Size(64, 27);
            button_find.TabIndex = 10;
            button_find.Text = "Find";
            button_find.UseVisualStyleBackColor = false;
            button_find.Click += button_find_Click;
            // 
            // textBox_find
            // 
            textBox_find.Location = new Point(306, 6);
            textBox_find.Name = "textBox_find";
            textBox_find.Size = new Size(157, 27);
            textBox_find.TabIndex = 8;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.White;
            button_delete.Location = new Point(469, 6);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(62, 27);
            button_delete.TabIndex = 11;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // textBox_delete
            // 
            textBox_delete.Location = new Point(537, 6);
            textBox_delete.Name = "textBox_delete";
            textBox_delete.Size = new Size(157, 27);
            textBox_delete.TabIndex = 7;
            // 
            // panel_main
            // 
            panel_main.BorderStyle = BorderStyle.Fixed3D;
            panel_main.Controls.Add(Label_Explanation);
            panel_main.Location = new Point(1, 87);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1232, 396);
            panel_main.TabIndex = 3;
            panel_main.Paint += panel_main_Paint;
            // 
            // Label_Explanation
            // 
            Label_Explanation.BackColor = SystemColors.Control;
            Label_Explanation.BorderStyle = BorderStyle.Fixed3D;
            Label_Explanation.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Explanation.Location = new Point(-2, 0);
            Label_Explanation.Name = "Label_Explanation";
            Label_Explanation.Size = new Size(270, 80);
            Label_Explanation.TabIndex = 0;
            Label_Explanation.Text = "Trạng thái của action";
            Label_Explanation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Insert_RBT_Timer
            // 
            Insert_RBT_Timer.Interval = 50;
            Insert_RBT_Timer.Tick += Insert_RBT_Timer_Tick;
            // 
            // PathToNode_Timer
            // 
            PathToNode_Timer.Interval = 50;
            PathToNode_Timer.Tick += PathToNode_Timer_Tick;
            // 
            // Insert_BST_Timer
            // 
            Insert_BST_Timer.Interval = 50;
            Insert_BST_Timer.Tick += Insert_BST_Timer_Tick;
            // 
            // Delay_PathToNode
            // 
            Delay_PathToNode.Interval = 1000;
            Delay_PathToNode.Tick += Delay_PathToNode_Tick;
            // 
            // Delete_Node_Timer
            // 
            Delete_Node_Timer.Interval = 50;
            Delete_Node_Timer.Tick += Delete_Node_Timer_Tick;
            // 
            // RedBlackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 485);
            Controls.Add(panel_main);
            Controls.Add(panel_function);
            Controls.Add(panel_header);
            DoubleBuffered = true;
            Name = "RedBlackForm";
            Text = "MÔ PHỎNG CÂY ĐỎ ĐEN";
            Load += Form1_Load;
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            panel_function.ResumeLayout(false);
            panel_function.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_speedanimation).EndInit();
            panel_main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_header;
        private Label label1;
        private Panel panel_function;
        private TextBox textBox2;
        private TextBox textBox_delete;
        private Label label4;
        private Label label6;
        private TextBox textBox_insert;
        private Label label3;
        private Panel panel_main;
        private Button button_delete;
        private Button button_find;
        private Button button_insert;
        private TextBox textBox_find;
        private TrackBar trackBar_speedanimation;
        private Label label2;
        private System.Windows.Forms.Timer Insert_RBT_Timer;
        private System.Windows.Forms.Timer PathToNode_Timer;
        private System.Windows.Forms.Timer Insert_BST_Timer;
        private Label Label_Explanation;
        private Button button1;
        private System.Windows.Forms.Timer Delay_PathToNode;
        private System.Windows.Forms.Timer Delete_Node_Timer;
    }
}
