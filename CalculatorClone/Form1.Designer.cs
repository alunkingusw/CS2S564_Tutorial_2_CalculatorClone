namespace CalculatorClone
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
            lblScreen = new Label();
            btnSeven = new Button();
            btnEight = new Button();
            btnThree = new Button();
            btnSix = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnNine = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnZero = new Button();
            btnDot = new Button();
            btnMul = new Button();
            btnPercent = new Button();
            btnSub = new Button();
            btnInvert = new Button();
            btnEqual = new Button();
            btnDiv = new Button();
            btnPlus = new Button();
            btnSqr = new Button();
            btnNegate = new Button();
            btnClear = new Button();
            btnClrE = new Button();
            btnMemClr = new Button();
            SuspendLayout();
            // 
            // lblScreen
            // 
            lblScreen.BorderStyle = BorderStyle.FixedSingle;
            lblScreen.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScreen.Location = new Point(19, 9);
            lblScreen.Name = "lblScreen";
            lblScreen.Size = new Size(254, 100);
            lblScreen.TabIndex = 0;
            lblScreen.Text = "0";
            lblScreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe UI", 12F);
            btnSeven.Location = new Point(19, 179);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(46, 46);
            btnSeven.TabIndex = 1;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnDigit_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe UI", 12F);
            btnEight.Location = new Point(71, 179);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(46, 46);
            btnEight.TabIndex = 2;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnDigit_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Segoe UI", 12F);
            btnThree.Location = new Point(123, 283);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(46, 46);
            btnThree.TabIndex = 3;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnDigit_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Segoe UI", 12F);
            btnSix.Location = new Point(123, 231);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(46, 46);
            btnSix.TabIndex = 4;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnDigit_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Segoe UI", 12F);
            btnTwo.Location = new Point(71, 283);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(46, 46);
            btnTwo.TabIndex = 5;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnDigit_Click;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Segoe UI", 12F);
            btnOne.Location = new Point(19, 283);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(46, 46);
            btnOne.TabIndex = 6;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnDigit_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Segoe UI", 12F);
            btnNine.Location = new Point(123, 179);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(46, 46);
            btnNine.TabIndex = 7;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnDigit_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Segoe UI", 12F);
            btnFive.Location = new Point(71, 231);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(46, 46);
            btnFive.TabIndex = 8;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnDigit_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Segoe UI", 12F);
            btnFour.Location = new Point(19, 231);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(46, 46);
            btnFour.TabIndex = 9;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnDigit_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 12F);
            btnZero.Location = new Point(19, 335);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(98, 46);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnDigit_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 15.75F);
            btnDot.Location = new Point(123, 335);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(46, 46);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Microsoft Sans Serif", 12F);
            btnMul.Location = new Point(175, 231);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(46, 46);
            btnMul.TabIndex = 17;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Microsoft Sans Serif", 12F);
            btnPercent.Location = new Point(227, 179);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(46, 46);
            btnPercent.TabIndex = 16;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Microsoft Sans Serif", 12F);
            btnSub.Location = new Point(175, 283);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(46, 46);
            btnSub.TabIndex = 15;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnInvert
            // 
            btnInvert.Font = new Font("Microsoft Sans Serif", 12F);
            btnInvert.Location = new Point(227, 231);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(46, 46);
            btnInvert.TabIndex = 14;
            btnInvert.Text = "1/x";
            btnInvert.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Microsoft Sans Serif", 12F);
            btnEqual.Location = new Point(227, 283);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(46, 98);
            btnEqual.TabIndex = 13;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Microsoft Sans Serif", 12F);
            btnDiv.Location = new Point(175, 179);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(46, 46);
            btnDiv.TabIndex = 12;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Microsoft Sans Serif", 12F);
            btnPlus.Location = new Point(175, 335);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(46, 46);
            btnPlus.TabIndex = 18;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnSqr
            // 
            btnSqr.Font = new Font("Microsoft Sans Serif", 12F);
            btnSqr.Location = new Point(227, 127);
            btnSqr.Name = "btnSqr";
            btnSqr.Size = new Size(46, 46);
            btnSqr.TabIndex = 19;
            btnSqr.Text = "√";
            btnSqr.UseVisualStyleBackColor = true;
            // 
            // btnNegate
            // 
            btnNegate.Font = new Font("Microsoft Sans Serif", 12F);
            btnNegate.Location = new Point(175, 127);
            btnNegate.Name = "btnNegate";
            btnNegate.Size = new Size(46, 46);
            btnNegate.TabIndex = 20;
            btnNegate.Text = "±";
            btnNegate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(123, 127);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(46, 46);
            btnClear.TabIndex = 21;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClrE
            // 
            btnClrE.Font = new Font("Segoe UI", 12F);
            btnClrE.Location = new Point(71, 127);
            btnClrE.Name = "btnClrE";
            btnClrE.Size = new Size(46, 46);
            btnClrE.TabIndex = 22;
            btnClrE.Text = "CE";
            btnClrE.UseVisualStyleBackColor = true;
            // 
            // btnMemClr
            // 
            btnMemClr.Font = new Font("Segoe UI", 12F);
            btnMemClr.Location = new Point(19, 127);
            btnMemClr.Name = "btnMemClr";
            btnMemClr.Size = new Size(46, 46);
            btnMemClr.TabIndex = 23;
            btnMemClr.Text = "MC";
            btnMemClr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 404);
            Controls.Add(btnMemClr);
            Controls.Add(btnClrE);
            Controls.Add(btnClear);
            Controls.Add(btnNegate);
            Controls.Add(btnSqr);
            Controls.Add(btnPlus);
            Controls.Add(btnMul);
            Controls.Add(btnPercent);
            Controls.Add(btnSub);
            Controls.Add(btnInvert);
            Controls.Add(btnEqual);
            Controls.Add(btnDiv);
            Controls.Add(btnDot);
            Controls.Add(btnZero);
            Controls.Add(btnFour);
            Controls.Add(btnFive);
            Controls.Add(btnNine);
            Controls.Add(btnOne);
            Controls.Add(btnTwo);
            Controls.Add(btnSix);
            Controls.Add(btnThree);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(lblScreen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblScreen;
        private Button btnSeven;
        private Button btnEight;
        private Button btnThree;
        private Button btnSix;
        private Button btnTwo;
        private Button btnOne;
        private Button btnNine;
        private Button btnFive;
        private Button btnFour;
        private Button btnZero;
        private Button btnDot;
        private Button btnMul;
        private Button btnPercent;
        private Button btnSub;
        private Button btnInvert;
        private Button btnEqual;
        private Button btnDiv;
        private Button btnPlus;
        private Button btnSqr;
        private Button btnNegate;
        private Button btnClear;
        private Button btnClrE;
        private Button btnMemClr;
    }
}
