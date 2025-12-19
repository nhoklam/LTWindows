namespace Example
{
    partial class Example11
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
            txtDisplay = new TextBox();
            btnMC = new Button();
            btnMR = new Button();
            btnMS = new Button();
            btnMPlus = new Button();
            btnMMinus = new Button();
            btnBack = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnSign = new Button();
            btnSqrt = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDiv = new Button();
            btnPercent = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMul = new Button();
            btnInverse = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSub = new Button();
            btnEquals = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(14, 14);
            txtDisplay.Margin = new Padding(4, 3, 4, 3);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(319, 38);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btnMC
            // 
            btnMC.Location = new Point(14, 75);
            btnMC.Margin = new Padding(4, 3, 4, 3);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(47, 37);
            btnMC.TabIndex = 1;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            btnMC.Click += Button_Click;
            // 
            // btnMR
            // 
            btnMR.Location = new Point(79, 75);
            btnMR.Margin = new Padding(4, 3, 4, 3);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(47, 37);
            btnMR.TabIndex = 2;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            btnMR.Click += Button_Click;
            // 
            // btnMS
            // 
            btnMS.Location = new Point(145, 75);
            btnMS.Margin = new Padding(4, 3, 4, 3);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(47, 37);
            btnMS.TabIndex = 3;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            btnMS.Click += Button_Click;
            // 
            // btnMPlus
            // 
            btnMPlus.Location = new Point(210, 75);
            btnMPlus.Margin = new Padding(4, 3, 4, 3);
            btnMPlus.Name = "btnMPlus";
            btnMPlus.Size = new Size(47, 37);
            btnMPlus.TabIndex = 4;
            btnMPlus.Text = "M+";
            btnMPlus.UseVisualStyleBackColor = true;
            btnMPlus.Click += Button_Click;
            // 
            // btnMMinus
            // 
            btnMMinus.Location = new Point(275, 75);
            btnMMinus.Margin = new Padding(4, 3, 4, 3);
            btnMMinus.Name = "btnMMinus";
            btnMMinus.Size = new Size(47, 37);
            btnMMinus.TabIndex = 5;
            btnMMinus.Text = "M-";
            btnMMinus.UseVisualStyleBackColor = true;
            btnMMinus.Click += Button_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 128);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(47, 37);
            btnBack.TabIndex = 6;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += Button_Click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(79, 128);
            btnCE.Margin = new Padding(4, 3, 4, 3);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(47, 37);
            btnCE.TabIndex = 7;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += Button_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(145, 128);
            btnC.Margin = new Padding(4, 3, 4, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(47, 37);
            btnC.TabIndex = 8;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += Button_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(210, 128);
            btnSign.Margin = new Padding(4, 3, 4, 3);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(47, 37);
            btnSign.TabIndex = 9;
            btnSign.Text = "±";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += Button_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(275, 128);
            btnSqrt.Margin = new Padding(4, 3, 4, 3);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(47, 37);
            btnSqrt.TabIndex = 10;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += Button_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(14, 181);
            btn7.Margin = new Padding(4, 3, 4, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(47, 37);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Button_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(79, 181);
            btn8.Margin = new Padding(4, 3, 4, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(47, 37);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Button_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(145, 181);
            btn9.Margin = new Padding(4, 3, 4, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(47, 37);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Button_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(210, 181);
            btnDiv.Margin = new Padding(4, 3, 4, 3);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(47, 37);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += Button_Click;
            // 
            // btnPercent
            // 
            btnPercent.Location = new Point(275, 181);
            btnPercent.Margin = new Padding(4, 3, 4, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(47, 37);
            btnPercent.TabIndex = 15;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += Button_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(14, 234);
            btn4.Margin = new Padding(4, 3, 4, 3);
            btn4.Name = "btn4";
            btn4.Size = new Size(47, 37);
            btn4.TabIndex = 16;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Button_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(79, 234);
            btn5.Margin = new Padding(4, 3, 4, 3);
            btn5.Name = "btn5";
            btn5.Size = new Size(47, 37);
            btn5.TabIndex = 17;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Button_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(145, 234);
            btn6.Margin = new Padding(4, 3, 4, 3);
            btn6.Name = "btn6";
            btn6.Size = new Size(47, 37);
            btn6.TabIndex = 18;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Button_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(210, 234);
            btnMul.Margin = new Padding(4, 3, 4, 3);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(47, 37);
            btnMul.TabIndex = 19;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += Button_Click;
            // 
            // btnInverse
            // 
            btnInverse.Location = new Point(275, 234);
            btnInverse.Margin = new Padding(4, 3, 4, 3);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(47, 37);
            btnInverse.TabIndex = 20;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = true;
            btnInverse.Click += Button_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(14, 287);
            btn1.Margin = new Padding(4, 3, 4, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(47, 37);
            btn1.TabIndex = 21;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Button_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(79, 287);
            btn2.Margin = new Padding(4, 3, 4, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(47, 37);
            btn2.TabIndex = 22;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Button_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(145, 287);
            btn3.Margin = new Padding(4, 3, 4, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(47, 37);
            btn3.TabIndex = 23;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Button_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(210, 287);
            btnSub.Margin = new Padding(4, 3, 4, 3);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(47, 37);
            btnSub.TabIndex = 24;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += Button_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(275, 287);
            btnEquals.Margin = new Padding(4, 3, 4, 3);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(47, 90);
            btnEquals.TabIndex = 25;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += Button_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(14, 340);
            btn0.Margin = new Padding(4, 3, 4, 3);
            btn0.Name = "btn0";
            btn0.Size = new Size(113, 37);
            btn0.TabIndex = 26;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Button_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(145, 340);
            btnDot.Margin = new Padding(4, 3, 4, 3);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(47, 37);
            btnDot.TabIndex = 27;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += Button_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(210, 340);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(47, 37);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Button_Click;
            // 
            // Example11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 401);
            Controls.Add(btnAdd);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnEquals);
            Controls.Add(btnSub);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnInverse);
            Controls.Add(btnMul);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnPercent);
            Controls.Add(btnDiv);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnSqrt);
            Controls.Add(btnSign);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnBack);
            Controls.Add(btnMMinus);
            Controls.Add(btnMPlus);
            Controls.Add(btnMS);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Example11";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Calculator";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnAdd;
    }
}