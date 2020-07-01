using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Calculator : Form
    {
        double a = 0;
        double b = 0;
        double calcNum = 0;
        char op = ' ';
        double mem = 0;
        double tempMem = 0;
        double memAdd = 0;
        double memSub = 0;
        double sign = 0;
        double divX = 0;
        double perc = 0;
        double percOfA = 0;
        double sqrt = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "0";
                return;
            }
            inOut.Text += "0";
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "1";
                return;
            }
            inOut.Text += "1";
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "2";
                return;
            }
            inOut.Text += "2";
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "3";
                return;
            }
            inOut.Text += "3";
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "4";
                return;
            }
            inOut.Text += "4";
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "5";
                return;
            }
            inOut.Text += "5";
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "6";
                return;
            }
            inOut.Text += "6";
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "7";
                return;
            }
            inOut.Text += "7";
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "8";
                return;
            }
            inOut.Text += "8";
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "9";
                return;
            }
            inOut.Text += "9";
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "";
                return;
            }
            inOut.Text = inOut.Text.Substring(0, (inOut.Text.Length - 1));
        }

        private void clearEBtn_Click(object sender, EventArgs e)
        {
            inOut.Text = "";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inOut.Text = "";
            calculation.Text = "";
            a = 0;
            b = 0;
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "Divide by zero error")
            {
                inOut.Text = "0.";
                return;
            }
            else if (inOut.Text == "")
            {
                inOut.Text = "0.";
                return;
            }
            inOut.Text += ".";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (calculation.Text == "" && inOut.Text != "")
            {
                op = '+';
                calculation.Text = inOut.Text;
                a = Convert.ToDouble(inOut.Text);
                inOut.Text = "";
                return;
            }
            else if (inOut.Text == "")
            {
                return;
            }
            else if (a != 0)
            {
                b = Convert.ToDouble(inOut.Text);
                if (op == '+')
                {
                    calcNum = a + b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '-')
                {
                    calcNum = a - b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '*')
                {
                    calcNum = a * b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '/')
                {
                    if (b == 0)
                    {
                        inOut.Text = "Divide by zero error";
                        calculation.Text = "";
                        a = 0;
                        b = 0;
                        op = ' ';
                        return;
                    }
                    calcNum = a / b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                op = '+';
                return;
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (calculation.Text == "" && inOut.Text != "")
            {
                op = '-';
                calculation.Text = inOut.Text;
                a = Convert.ToDouble(inOut.Text);
                inOut.Text = "";
                return;
            }
            else if (inOut.Text == "")
            {
                return;
            }
            else if (a != 0)
            {
                b = Convert.ToDouble(inOut.Text);
                if (op == '+')
                {
                    calcNum = a + b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '-')
                {
                    calcNum = a - b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '*')
                {
                    calcNum = a * b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '/')
                {
                    if (b == 0)
                    {
                        inOut.Text = "Divide by zero error";
                        calculation.Text = "";
                        a = 0;
                        b = 0;
                        op = ' ';
                        calculation.Text = Convert.ToString(calcNum);
                        a = calcNum;
                        return;
                    }
                    calcNum = a / b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                op = '-';
                return;
            }
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            if (calculation.Text == "" && inOut.Text != "")
            {
                op = '*';
                calculation.Text = inOut.Text;
                a = Convert.ToDouble(inOut.Text);
                inOut.Text = "";
                return;
            }
            else if (inOut.Text == "")
            {
                return;
            }
            else if (a != 0)
            {
                b = Convert.ToDouble(inOut.Text);
                if (op == '+')
                {
                    calcNum = a + b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '-')
                {
                    calcNum = a - b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '*')
                {
                    calcNum = a * b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '/')
                {
                    if (b == 0)
                    {
                        inOut.Text = "Divide by zero error";
                        calculation.Text = "";
                        a = 0;
                        b = 0;
                        op = ' ';
                        return;
                    }
                    calcNum = a / b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                op = '*';
                return;
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if (calculation.Text == "" && inOut.Text != "")
            {
                op = '/';
                a = Convert.ToDouble(inOut.Text);
                calculation.Text = inOut.Text;
                inOut.Text = "";
                return;
            }
            else if (inOut.Text == "")
            {
                return;
            }
            else if (a != 0)
            {
                b = Convert.ToDouble(inOut.Text);
                if (op == '+')
                {
                    calcNum = a + b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '-')
                {
                    calcNum = a - b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '*')
                {
                    calcNum = a * b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                else if (op == '/')
                {
                    if (b == 0)
                    {
                        inOut.Text = "Divide by zero error";
                        calculation.Text = "";
                        a = 0;
                        b = 0;
                        op = ' ';
                        return;
                    }
                    calcNum = a / b;
                    calculation.Text = Convert.ToString(calcNum);
                    a = calcNum;
                    inOut.Text = "";
                }
                op = '/';
                return;
            }
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "")
            {
                return;
            }
            b = Convert.ToDouble(inOut.Text);
            if (op == '+')
            {
                calcNum = a + b;
            }
            else if (op == '-')
            {
                calcNum = a - b;
            }
            else if (op == '*')
            {
                calcNum = a * b;
            }
            else if (op == '/')
            {
                if (b == 0)
                {
                    inOut.Text = "Divide by zero error";
                    calculation.Text = "";
                    a = 0;
                    b = 0;
                    op = ' ';
                    return;
                }
                calcNum = a / b;
            }
            a = calcNum;
            calculation.Text = Convert.ToString(calcNum);
            inOut.Text = "";
        }

        private void chngSignBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "")
            {
                return;
            }
            sign = Convert.ToDouble(inOut.Text);
            sign = sign * -1;
            inOut.Text = Convert.ToString(sign);
        }

        private void oneDivX_Click(object sender, EventArgs e)
        {
            divX = Convert.ToDouble(inOut.Text);
            divX = 1 / divX;
            inOut.Text = Convert.ToString(divX);
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                inOut.Text = "";
                return;
            }
            perc = Convert.ToDouble(inOut.Text);
            percOfA = a / 100 * perc;
            inOut.Text = Convert.ToString(percOfA);
        }

        private void sqrRtBtn_Click(object sender, EventArgs e)
        {
            sqrt = Convert.ToDouble(inOut.Text);
            sqrt = Math.Sqrt(sqrt);
            a = sqrt;
            inOut.Text = Convert.ToString(a);
        }

        private void memStoreBtn_Click(object sender, EventArgs e)
        {
            if (inOut.Text == "" && calculation.Text == "")
            {
                return;
            }
            else if (inOut.Text == "" && calculation.Text != "")
            {
                tempMem = Convert.ToDouble(calculation.Text);
                mem = tempMem;
                memRtnBtn.Enabled = true;
                memClrBtn.Enabled = true;
                a = 0;
                b = 0;
                calculation.Text = "";
                return;
            }
            tempMem = Convert.ToDouble(inOut.Text);
            inOut.Text = "";
            mem = tempMem;
            memRtnBtn.Enabled = true;
            memClrBtn.Enabled = true;
        }

        private void memRtnBtn_Click(object sender, EventArgs e)
        {
            inOut.Text = Convert.ToString(mem);
        }

        private void memClrBtn_Click(object sender, EventArgs e)
        {
            mem = 0;
            memRtnBtn.Enabled = false;
            memClrBtn.Enabled = false;
            inOut.Text = "";
        }

        private void memAddBtn_Click(object sender, EventArgs e)
        {
            if (mem == 0)
            {
                return;
            }
            else if (inOut.Text == "")
            {
                return;
            }
            memAdd = Convert.ToDouble(inOut.Text);
            mem += memAdd;
            inOut.Text = "";
        }

        private void memSubBtn_Click(object sender, EventArgs e)
        {
            if (mem == 0)
            {
                return;
            }
            else if (inOut.Text == "")
            {
                return;
            }
            memSub = Convert.ToDouble(inOut.Text);
            mem -= memSub;
            inOut.Text = "";
        }

        private void euroToPound_CheckedChanged(object sender, EventArgs e)
        {
            if (euroToPound.Checked == true)
            {
                toConv.Text = "Euro";
                afterConv.Text = "Pound";
                toConvert.Text = "";
                converted.Text = "";
            }
        }

        private void poundToEuro_CheckedChanged(object sender, EventArgs e)
        {
            if (poundToEuro.Checked == true)
            {
                toConv.Text = "Pound";
                afterConv.Text = "Euro";
                toConvert.Text = "";
                converted.Text = "";
            }
        }

        private void inchToFeet_CheckedChanged(object sender, EventArgs e)
        {
            if (inchToFeet.Checked == true)
            {
                toConv.Text = "Inch";
                afterConv.Text = "Feet";
                toConvert.Text = "";
                converted.Text = "";
            }
        }

        private void feetToInch_CheckedChanged(object sender, EventArgs e)
        {
            if (feetToInch.Checked == true)
            {
                toConv.Text = "Feet";
                afterConv.Text = "Inch";
                toConvert.Text = "";
                converted.Text = "";
            }
        }

        private void celToFah_CheckedChanged(object sender, EventArgs e)
        {
            if (celToFah.Checked == true)
            {
                toConv.Text = "Celsius";
                afterConv.Text = "Fahrenheit";
                toConvert.Text = "";
                converted.Text = "";
            }
        }

        private void fahToCel_CheckedChanged(object sender, EventArgs e)
        {
            if (fahToCel.Checked == true)
            {
                toConv.Text = "Fahrenheit";
                afterConv.Text = "Celsius";
                toConvert.Text = "";
                converted.Text = "";
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            int count = 0;
            int minusC = 0;
            int decC = 0;
            double euro = 0;
            double pound = 0;
            double inch = 0;
            double feet = 0;
            double celsius = 0;
            double fahrenheit = 0;
            if (euroToPound.Checked == true)
            {
                for (int index = 0; index < toConvert.Text.Length; index++)
                {
                    if (toConvert.Text[index] >= '0' && toConvert.Text[index] <= '9')
                    {
                        count++;
                    }
                    else if (toConvert.Text[index] == '.' && decC < 2)
                    {
                        count++;
                        decC++;
                    }
                    else if (toConvert.Text[0] == '-' && minusC < 2)
                    {
                        count++;
                        minusC++;
                    }
                }
                if (count != toConvert.Text.Length)
                {
                    toConvert.Text = "";
                    return;
                }
                euro = Convert.ToDouble(toConvert.Text);
                pound = euro * 0.79;
                converted.Text = Convert.ToString(pound);
            }
            else if (poundToEuro.Checked == true)
            {
                for (int index = 0; index < toConvert.Text.Length; index++)
                {
                    if (toConvert.Text[index] >= '0' && toConvert.Text[index] <= '9')
                    {
                        count++;
                    }
                    else if (toConvert.Text[index] == '.' && decC < 2)
                    {
                        count++;
                        decC++;
                    }
                    else if (toConvert.Text[0] == '-' && minusC < 2)
                    {
                        count++;
                        minusC++;
                    }
                }
                if (count != toConvert.Text.Length)
                {
                    toConvert.Text = "";
                    return;
                }
                pound = Convert.ToDouble(toConvert.Text);
                euro = (pound / 79) * 100;
                converted.Text = Convert.ToString(euro);
            }
            else if (inchToFeet.Checked == true)
            {
                for (int index = 0; index < toConvert.Text.Length; index++)
                {
                    if (toConvert.Text[index] >= '0' && toConvert.Text[index] <= '9')
                    {
                        count++;
                    }
                    else if (toConvert.Text[index] == '.' && decC < 2)
                    {
                        count++;
                        decC++;
                    }
                    else if (toConvert.Text[0] == '-' && minusC < 2)
                    {
                        count++;
                        minusC++;
                    }
                }
                if (count != toConvert.Text.Length)
                {
                    toConvert.Text = "";
                    return;
                }
                inch = Convert.ToDouble(toConvert.Text);
                feet = inch / 12;
                converted.Text = Convert.ToString(feet);
            }
            else if (feetToInch.Checked == true)
            {
                for (int index = 0; index < toConvert.Text.Length; index++)
                {
                    if (toConvert.Text[index] >= '0' && toConvert.Text[index] <= '9')
                    {
                        count++;
                    }
                    else if (toConvert.Text[index] == '.' && decC < 2)
                    {
                        count++;
                        decC++;
                    }
                    else if (toConvert.Text[0] == '-' && minusC < 2)
                    {
                        count++;
                        minusC++;
                    }
                }
                if (count != toConvert.Text.Length)
                {
                    toConvert.Text = "";
                    return;
                }
                feet = Convert.ToDouble(toConvert.Text);
                inch = feet * 12;
                converted.Text = Convert.ToString(inch);
            }
            else if (celToFah.Checked == true)
            {
                for (int index = 0; index < toConvert.Text.Length; index++)
                {
                    if (toConvert.Text[index] >= '0' && toConvert.Text[index] <= '9')
                    {
                        count++;
                    }
                    else if (toConvert.Text[index] == '.' && decC < 2)
                    {
                        count++;
                        decC++;
                    }
                    else if (toConvert.Text[0] == '-' && minusC < 2)
                    {
                        count++;
                        minusC++;
                    }
                }
                if (count != toConvert.Text.Length)
                {
                    toConvert.Text = "";
                    return;
                }
                celsius = Convert.ToDouble(toConvert.Text);
                fahrenheit = ((celsius * 9 / 5) + 32);
                converted.Text = Convert.ToString(fahrenheit);
            }
            else if (fahToCel.Checked == true)
            {
                for (int index = 0; index < toConvert.Text.Length; index++)
                {
                    if (toConvert.Text[index] >= '0' && toConvert.Text[index] <= '9')
                    {
                        count++;
                    }
                    else if (toConvert.Text[index] == '.' && decC < 2)
                    {
                        count++;
                        decC++;
                    }
                    else if (toConvert.Text[0] == '-' && minusC < 2)
                    {
                        count++;
                        minusC++;
                    }
                }
                if (count != toConvert.Text.Length)
                {
                    toConvert.Text = "";
                    return;
                }
                fahrenheit = Convert.ToDouble(toConvert.Text);
                celsius = ((fahrenheit - 32) * 5 / 9);
                converted.Text = Convert.ToString(celsius);
            }
        }

        private void convClr_Click(object sender, EventArgs e)
        {
            toConvert.Text = "";
            converted.Text = "";
        }
    }
}