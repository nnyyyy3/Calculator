namespace Calculator
{
    partial class Calculator
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
            resultField = new TextBox();
            resetBtn = new Button();
            zeroBtn = new Button();
            decBtn = new Button();
            equalBtn = new Button();
            mulBtn = new Button();
            threeBtn = new Button();
            twoBtn = new Button();
            oneBtn = new Button();
            subBtn = new Button();
            sixBtn = new Button();
            fiveBtn = new Button();
            fourBtn = new Button();
            addBtn = new Button();
            nineBtn = new Button();
            eightBtn = new Button();
            sevenBtn = new Button();
            divBtn = new Button();
            delBtn = new Button();
            SuspendLayout();
            // 
            // resultField
            // 
            resultField.BackColor = Color.PowderBlue;
            resultField.Font = new Font("Segoe UI", 15F);
            resultField.ForeColor = SystemColors.WindowText;
            resultField.Location = new Point(24, 12);
            resultField.Multiline = true;
            resultField.Name = "resultField";
            resultField.ReadOnly = true;
            resultField.Size = new Size(320, 127);
            resultField.TabIndex = 0;
            resultField.TextAlign = HorizontalAlignment.Right;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Plum;
            resetBtn.Font = new Font("Rubik SemiBold", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetBtn.Location = new Point(38, 154);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(119, 53);
            resetBtn.TabIndex = 1;
            resetBtn.Text = "C";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // zeroBtn
            // 
            zeroBtn.BackColor = Color.Thistle;
            zeroBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            zeroBtn.Location = new Point(98, 402);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(78, 53);
            zeroBtn.TabIndex = 2;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = false;
            zeroBtn.Click += zeroBtn_Click;
            // 
            // decBtn
            // 
            decBtn.BackColor = Color.Thistle;
            decBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            decBtn.Location = new Point(14, 402);
            decBtn.Name = "decBtn";
            decBtn.Size = new Size(78, 53);
            decBtn.TabIndex = 3;
            decBtn.Text = ".";
            decBtn.UseVisualStyleBackColor = false;
            decBtn.Click += decBtn_Click;
            // 
            // equalBtn
            // 
            equalBtn.BackColor = Color.Plum;
            equalBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            equalBtn.Location = new Point(182, 402);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(78, 53);
            equalBtn.TabIndex = 4;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = false;
            equalBtn.Click += equalBtn_Click;
            // 
            // mulBtn
            // 
            mulBtn.BackColor = Color.Plum;
            mulBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            mulBtn.Location = new Point(266, 343);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(78, 53);
            mulBtn.TabIndex = 8;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = false;
            mulBtn.Click += mulBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.BackColor = Color.Thistle;
            threeBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            threeBtn.Location = new Point(182, 343);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(78, 53);
            threeBtn.TabIndex = 7;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = false;
            threeBtn.Click += threeBtn_Click;
            // 
            // twoBtn
            // 
            twoBtn.BackColor = Color.Thistle;
            twoBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            twoBtn.Location = new Point(98, 343);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(78, 53);
            twoBtn.TabIndex = 6;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = false;
            twoBtn.Click += twoBtn_Click;
            // 
            // oneBtn
            // 
            oneBtn.BackColor = Color.Thistle;
            oneBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            oneBtn.Location = new Point(12, 343);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(78, 53);
            oneBtn.TabIndex = 5;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = false;
            oneBtn.Click += oneBtn_Click;
            // 
            // subBtn
            // 
            subBtn.BackColor = Color.Plum;
            subBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            subBtn.Location = new Point(266, 284);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(78, 53);
            subBtn.TabIndex = 12;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = false;
            subBtn.Click += subBtn_Click;
            // 
            // sixBtn
            // 
            sixBtn.BackColor = Color.Thistle;
            sixBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            sixBtn.Location = new Point(182, 284);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(78, 53);
            sixBtn.TabIndex = 11;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = false;
            sixBtn.Click += sixBtn_Click;
            // 
            // fiveBtn
            // 
            fiveBtn.BackColor = Color.Thistle;
            fiveBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            fiveBtn.Location = new Point(98, 284);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(78, 53);
            fiveBtn.TabIndex = 10;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = false;
            fiveBtn.Click += fiveBtn_Click;
            // 
            // fourBtn
            // 
            fourBtn.BackColor = Color.Thistle;
            fourBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            fourBtn.Location = new Point(12, 284);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(78, 53);
            fourBtn.TabIndex = 9;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = false;
            fourBtn.Click += fourBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Plum;
            addBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            addBtn.Location = new Point(266, 225);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(78, 53);
            addBtn.TabIndex = 16;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // nineBtn
            // 
            nineBtn.BackColor = Color.Thistle;
            nineBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            nineBtn.Location = new Point(182, 225);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(78, 53);
            nineBtn.TabIndex = 15;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = false;
            nineBtn.Click += nineBtn_Click;
            // 
            // eightBtn
            // 
            eightBtn.BackColor = Color.Thistle;
            eightBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            eightBtn.Location = new Point(98, 225);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(78, 53);
            eightBtn.TabIndex = 14;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = false;
            eightBtn.Click += eightBtn_Click;
            // 
            // sevenBtn
            // 
            sevenBtn.BackColor = Color.Thistle;
            sevenBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            sevenBtn.Location = new Point(12, 225);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(78, 53);
            sevenBtn.TabIndex = 13;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = false;
            sevenBtn.Click += sevenBtn_Click;
            // 
            // divBtn
            // 
            divBtn.BackColor = Color.Plum;
            divBtn.Font = new Font("Rubik SemiBold", 15.7499981F, FontStyle.Bold);
            divBtn.Location = new Point(266, 402);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(78, 53);
            divBtn.TabIndex = 17;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = false;
            divBtn.Click += divBtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.Plum;
            delBtn.Font = new Font("Rubik SemiBold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delBtn.Location = new Point(201, 154);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(119, 53);
            delBtn.TabIndex = 18;
            delBtn.Text = "Del";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += eraseBtn_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(366, 483);
            Controls.Add(delBtn);
            Controls.Add(divBtn);
            Controls.Add(addBtn);
            Controls.Add(nineBtn);
            Controls.Add(eightBtn);
            Controls.Add(sevenBtn);
            Controls.Add(subBtn);
            Controls.Add(sixBtn);
            Controls.Add(fiveBtn);
            Controls.Add(fourBtn);
            Controls.Add(mulBtn);
            Controls.Add(threeBtn);
            Controls.Add(twoBtn);
            Controls.Add(oneBtn);
            Controls.Add(equalBtn);
            Controls.Add(decBtn);
            Controls.Add(zeroBtn);
            Controls.Add(resetBtn);
            Controls.Add(resultField);
            Name = "Calculator";
            Text = "Calulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultField;
        private Button resetBtn;
        private Button zeroBtn;
        private Button decBtn;
        private Button equalBtn;
        private Button mulBtn;
        private Button threeBtn;
        private Button twoBtn;
        private Button oneBtn;
        private Button subBtn;
        private Button sixBtn;
        private Button fiveBtn;
        private Button fourBtn;
        private Button addBtn;
        private Button nineBtn;
        private Button eightBtn;
        private Button sevenBtn;
        private Button divBtn;
        private Button delBtn;
    }
}
