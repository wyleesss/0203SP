namespace _0203SP
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
            label1 = new Label();
            startPosUpDown = new NumericUpDown();
            startPosChar = new Label();
            button1 = new Button();
            button2 = new Button();
            endPosChar = new Label();
            endPosUpDown = new NumericUpDown();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            startButton = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)startPosUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endPosUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(73, 22);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "start position:";
            // 
            // startPosUpDown
            // 
            startPosUpDown.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            startPosUpDown.Location = new Point(125, 53);
            startPosUpDown.Maximum = new decimal(new int[] { 33, 0, 0, 0 });
            startPosUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            startPosUpDown.Name = "startPosUpDown";
            startPosUpDown.Size = new Size(61, 31);
            startPosUpDown.TabIndex = 2;
            startPosUpDown.TextAlign = HorizontalAlignment.Center;
            startPosUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            startPosUpDown.ValueChanged += startPosUpDown_ValueChanged;
            startPosUpDown.KeyPress += startPosUpDown_KeyPress;
            startPosUpDown.KeyUp += startPosUpDown_KeyUp;
            startPosUpDown.Validated += startPosUpDown_Validated;
            // 
            // startPosChar
            // 
            startPosChar.BackColor = SystemColors.Control;
            startPosChar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            startPosChar.Location = new Point(91, 55);
            startPosChar.Name = "startPosChar";
            startPosChar.Size = new Size(22, 22);
            startPosChar.TabIndex = 4;
            startPosChar.Text = "А";
            startPosChar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(61, 17);
            button1.Name = "button1";
            button1.Size = new Size(151, 77);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(84, 50);
            button2.Name = "button2";
            button2.Size = new Size(37, 36);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            // 
            // endPosChar
            // 
            endPosChar.BackColor = SystemColors.Control;
            endPosChar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            endPosChar.Location = new Point(262, 55);
            endPosChar.Name = "endPosChar";
            endPosChar.Size = new Size(22, 22);
            endPosChar.TabIndex = 10;
            endPosChar.Text = "Я";
            endPosChar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endPosUpDown
            // 
            endPosUpDown.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            endPosUpDown.Location = new Point(296, 53);
            endPosUpDown.Maximum = new decimal(new int[] { 33, 0, 0, 0 });
            endPosUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            endPosUpDown.Name = "endPosUpDown";
            endPosUpDown.Size = new Size(61, 31);
            endPosUpDown.TabIndex = 9;
            endPosUpDown.TextAlign = HorizontalAlignment.Center;
            endPosUpDown.Value = new decimal(new int[] { 33, 0, 0, 0 });
            endPosUpDown.ValueChanged += endPosUpDown_ValueChanged;
            endPosUpDown.KeyPress += endPosUpDown_KeyPress;
            endPosUpDown.KeyUp += endPosUpDown_KeyUp;
            endPosUpDown.Validated += endPosUpDown_Validated;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(247, 22);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 8;
            label4.Text = "end position:";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Location = new Point(255, 50);
            button3.Name = "button3";
            button3.Size = new Size(37, 36);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(232, 17);
            button4.Name = "button4";
            button4.Size = new Size(151, 77);
            button4.TabIndex = 11;
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(46, 159);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(353, 140);
            textBox1.TabIndex = 13;
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.ScrollBar;
            startButton.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(84, 102);
            startButton.Name = "startButton";
            startButton.Size = new Size(273, 47);
            startButton.TabIndex = 14;
            startButton.Text = "GENERATE";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ScrollBar;
            button5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(367, 282);
            button5.Name = "button5";
            button5.Size = new Size(61, 28);
            button5.TabIndex = 15;
            button5.Text = "clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 317);
            Controls.Add(button5);
            Controls.Add(startButton);
            Controls.Add(textBox1);
            Controls.Add(endPosChar);
            Controls.Add(endPosUpDown);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(startPosChar);
            Controls.Add(startPosUpDown);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(465, 364);
            MinimumSize = new Size(465, 364);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Systems Programming";
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)startPosUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)endPosUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown startPosUpDown;
        private Label startPosChar;
        private Button button1;
        private Button button2;
        private Label endPosChar;
        private NumericUpDown endPosUpDown;
        private Label label4;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Button startButton;
        private Button button5;
    }
}