namespace Example
{
    partial class Example10
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
            bt0 = new Button();
            btMul = new Button();
            btPlus = new Button();
            bt3 = new Button();
            bt2 = new Button();
            bt1 = new Button();
            btDot = new Button();
            btEquals = new Button();
            tbDisplay = new TextBox();
            SuspendLayout();
            // 
            // bt0
            // 
            bt0.Location = new Point(35, 62);
            bt0.Name = "bt0";
            bt0.Size = new Size(42, 34);
            bt0.TabIndex = 1;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // btMul
            // 
            btMul.Location = new Point(83, 100);
            btMul.Name = "btMul";
            btMul.Size = new Size(42, 34);
            btMul.TabIndex = 2;
            btMul.Text = "*";
            btMul.UseVisualStyleBackColor = true;
            btMul.Click += btMul_Click;
            // 
            // btPlus
            // 
            btPlus.Location = new Point(35, 100);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(42, 34);
            btPlus.TabIndex = 3;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(179, 62);
            bt3.Name = "bt3";
            bt3.Size = new Size(42, 34);
            bt3.TabIndex = 4;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(131, 62);
            bt2.Name = "bt2";
            bt2.Size = new Size(42, 34);
            bt2.TabIndex = 5;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(83, 62);
            bt1.Name = "bt1";
            bt1.Size = new Size(42, 34);
            bt1.TabIndex = 6;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // btDot
            // 
            btDot.Location = new Point(131, 100);
            btDot.Name = "btDot";
            btDot.Size = new Size(42, 34);
            btDot.TabIndex = 7;
            btDot.Text = ".";
            btDot.UseVisualStyleBackColor = true;
            btDot.Click += btDot_Click;
            // 
            // btEquals
            // 
            btEquals.Location = new Point(179, 100);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(42, 34);
            btEquals.TabIndex = 8;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = true;
            btEquals.Click += btEquals_Click;
            // 
            // tbDisplay
            // 
            tbDisplay.Font = new Font("Segoe UI", 20F);
            tbDisplay.Location = new Point(35, 12);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(186, 43);
            tbDisplay.TabIndex = 9;
            tbDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // Example10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 166);
            Controls.Add(tbDisplay);
            Controls.Add(btEquals);
            Controls.Add(btDot);
            Controls.Add(bt1);
            Controls.Add(bt2);
            Controls.Add(bt3);
            Controls.Add(btPlus);
            Controls.Add(btMul);
            Controls.Add(bt0);
            Name = "Example10";
            Text = "Example10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button bt0;
        private Button btMul;
        private Button btPlus;
        private Button bt3;
        private Button bt2;
        private Button bt1;
        private Button btDot;
        private Button btEquals;
        private TextBox tbDisplay;
    }
}