namespace Calculator
{
    public partial class Calculator : Form
    {
        private char? currentOperation = null;
        private double currentValue = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            appendNum(zeroBtn.Text);
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            appendNum(oneBtn.Text);
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            appendNum(twoBtn.Text);
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            appendNum(threeBtn.Text);
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            appendNum(fourBtn.Text);
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            appendNum(fiveBtn.Text);
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            appendNum(sixBtn.Text);
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            appendNum(sevenBtn.Text);
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            appendNum(eightBtn.Text);
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            appendNum(nineBtn.Text);
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            if (!resultField.Text.Contains("."))
                resultField.Text += ".";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            computeAnswer();
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            operations('/');
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            operations('*');
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            operations('-');
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            operations('+');
        }

        private void eraseBtn_Click(object sender, EventArgs e)
        {
            if (resultField.Text.Length > 0)
                resultField.Text = resultField.Text.Substring(0, resultField.Text.Length - 1);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resultField.Text = "";
            currentOperation = null;
            currentValue = 0;
        }

        private void appendNum(string number)
        {
            resultField.Text += number;
        }

        private void operations(char operation)
        {
            if (currentOperation != null)
                computeAnswer();

            currentValue = double.Parse(resultField.Text);
            currentOperation = operation;
            resultField.Text = "";
        }


        private void computeAnswer()
        {
            double newValue = double.Parse(resultField.Text);
            switch (currentOperation)
            {
                case '+': currentValue += newValue; 
                break;

                case '-': currentValue -= newValue;
                break;

                case '*': currentValue *= newValue;
                break;

                case '/': currentValue /=newValue;
                break;
            }
            resultField.Text = currentValue.ToString();
            currentOperation = null;
        }
    }
}

