namespace lab5
{
    partial class Calculator
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
            this.window = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.memAddBtn = new System.Windows.Forms.Button();
            this.chngSignBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.memSubBtn = new System.Windows.Forms.Button();
            this.memStoreBtn = new System.Windows.Forms.Button();
            this.memRtnBtn = new System.Windows.Forms.Button();
            this.memClrBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.clearEBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.sqrRtBtn = new System.Windows.Forms.Button();
            this.percentBtn = new System.Windows.Forms.Button();
            this.oneDivX = new System.Windows.Forms.Button();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.decBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.inOut = new System.Windows.Forms.TextBox();
            this.calculation = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.convert = new System.Windows.Forms.Button();
            this.afterConv = new System.Windows.Forms.Label();
            this.toConv = new System.Windows.Forms.Label();
            this.toConvert = new System.Windows.Forms.TextBox();
            this.converted = new System.Windows.Forms.TextBox();
            this.celToFah = new System.Windows.Forms.RadioButton();
            this.fahToCel = new System.Windows.Forms.RadioButton();
            this.feetToInch = new System.Windows.Forms.RadioButton();
            this.inchToFeet = new System.Windows.Forms.RadioButton();
            this.poundToEuro = new System.Windows.Forms.RadioButton();
            this.euroToPound = new System.Windows.Forms.RadioButton();
            this.convClr = new System.Windows.Forms.Button();
            this.window.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // window
            // 
            this.window.Controls.Add(this.tabPage1);
            this.window.Controls.Add(this.tabPage2);
            this.window.Location = new System.Drawing.Point(13, 13);
            this.window.Name = "window";
            this.window.SelectedIndex = 0;
            this.window.Size = new System.Drawing.Size(420, 340);
            this.window.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.memAddBtn);
            this.tabPage1.Controls.Add(this.chngSignBtn);
            this.tabPage1.Controls.Add(this.divBtn);
            this.tabPage1.Controls.Add(this.multBtn);
            this.tabPage1.Controls.Add(this.subBtn);
            this.tabPage1.Controls.Add(this.memSubBtn);
            this.tabPage1.Controls.Add(this.memStoreBtn);
            this.tabPage1.Controls.Add(this.memRtnBtn);
            this.tabPage1.Controls.Add(this.memClrBtn);
            this.tabPage1.Controls.Add(this.delBtn);
            this.tabPage1.Controls.Add(this.clearEBtn);
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.sqrRtBtn);
            this.tabPage1.Controls.Add(this.percentBtn);
            this.tabPage1.Controls.Add(this.oneDivX);
            this.tabPage1.Controls.Add(this.equalsBtn);
            this.tabPage1.Controls.Add(this.nineBtn);
            this.tabPage1.Controls.Add(this.eightBtn);
            this.tabPage1.Controls.Add(this.sevenBtn);
            this.tabPage1.Controls.Add(this.sixBtn);
            this.tabPage1.Controls.Add(this.fiveBtn);
            this.tabPage1.Controls.Add(this.fourBtn);
            this.tabPage1.Controls.Add(this.threeBtn);
            this.tabPage1.Controls.Add(this.twoBtn);
            this.tabPage1.Controls.Add(this.oneBtn);
            this.tabPage1.Controls.Add(this.addBtn);
            this.tabPage1.Controls.Add(this.decBtn);
            this.tabPage1.Controls.Add(this.zeroBtn);
            this.tabPage1.Controls.Add(this.inOut);
            this.tabPage1.Controls.Add(this.calculation);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // memAddBtn
            // 
            this.memAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memAddBtn.Location = new System.Drawing.Point(249, 86);
            this.memAddBtn.Name = "memAddBtn";
            this.memAddBtn.Size = new System.Drawing.Size(75, 31);
            this.memAddBtn.TabIndex = 29;
            this.memAddBtn.Text = "M+";
            this.memAddBtn.UseVisualStyleBackColor = true;
            this.memAddBtn.Click += new System.EventHandler(this.memAddBtn_Click);
            // 
            // chngSignBtn
            // 
            this.chngSignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chngSignBtn.Location = new System.Drawing.Point(249, 123);
            this.chngSignBtn.Name = "chngSignBtn";
            this.chngSignBtn.Size = new System.Drawing.Size(75, 31);
            this.chngSignBtn.TabIndex = 28;
            this.chngSignBtn.Text = "+/-";
            this.chngSignBtn.UseVisualStyleBackColor = true;
            this.chngSignBtn.Click += new System.EventHandler(this.chngSignBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.Location = new System.Drawing.Point(249, 160);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(75, 31);
            this.divBtn.TabIndex = 27;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // multBtn
            // 
            this.multBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multBtn.Location = new System.Drawing.Point(249, 197);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(75, 31);
            this.multBtn.TabIndex = 26;
            this.multBtn.Text = "*";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.multBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.Location = new System.Drawing.Point(249, 234);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(75, 31);
            this.subBtn.TabIndex = 25;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // memSubBtn
            // 
            this.memSubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memSubBtn.Location = new System.Drawing.Point(330, 86);
            this.memSubBtn.Name = "memSubBtn";
            this.memSubBtn.Size = new System.Drawing.Size(75, 31);
            this.memSubBtn.TabIndex = 24;
            this.memSubBtn.Text = "M-";
            this.memSubBtn.UseVisualStyleBackColor = true;
            this.memSubBtn.Click += new System.EventHandler(this.memSubBtn_Click);
            // 
            // memStoreBtn
            // 
            this.memStoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memStoreBtn.Location = new System.Drawing.Point(168, 86);
            this.memStoreBtn.Name = "memStoreBtn";
            this.memStoreBtn.Size = new System.Drawing.Size(75, 31);
            this.memStoreBtn.TabIndex = 23;
            this.memStoreBtn.Text = "MS";
            this.memStoreBtn.UseVisualStyleBackColor = true;
            this.memStoreBtn.Click += new System.EventHandler(this.memStoreBtn_Click);
            // 
            // memRtnBtn
            // 
            this.memRtnBtn.Enabled = false;
            this.memRtnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memRtnBtn.Location = new System.Drawing.Point(87, 86);
            this.memRtnBtn.Name = "memRtnBtn";
            this.memRtnBtn.Size = new System.Drawing.Size(75, 31);
            this.memRtnBtn.TabIndex = 22;
            this.memRtnBtn.Text = "MR";
            this.memRtnBtn.UseVisualStyleBackColor = true;
            this.memRtnBtn.Click += new System.EventHandler(this.memRtnBtn_Click);
            // 
            // memClrBtn
            // 
            this.memClrBtn.Enabled = false;
            this.memClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memClrBtn.Location = new System.Drawing.Point(6, 86);
            this.memClrBtn.Name = "memClrBtn";
            this.memClrBtn.Size = new System.Drawing.Size(75, 31);
            this.memClrBtn.TabIndex = 21;
            this.memClrBtn.Text = "MC";
            this.memClrBtn.UseVisualStyleBackColor = true;
            this.memClrBtn.Click += new System.EventHandler(this.memClrBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(6, 123);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 31);
            this.delBtn.TabIndex = 20;
            this.delBtn.Text = "<-";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // clearEBtn
            // 
            this.clearEBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEBtn.Location = new System.Drawing.Point(87, 123);
            this.clearEBtn.Name = "clearEBtn";
            this.clearEBtn.Size = new System.Drawing.Size(75, 31);
            this.clearEBtn.TabIndex = 19;
            this.clearEBtn.Text = "CE";
            this.clearEBtn.UseVisualStyleBackColor = true;
            this.clearEBtn.Click += new System.EventHandler(this.clearEBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(168, 123);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 31);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // sqrRtBtn
            // 
            this.sqrRtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrRtBtn.Location = new System.Drawing.Point(330, 123);
            this.sqrRtBtn.Name = "sqrRtBtn";
            this.sqrRtBtn.Size = new System.Drawing.Size(75, 31);
            this.sqrRtBtn.TabIndex = 17;
            this.sqrRtBtn.Text = "√";
            this.sqrRtBtn.UseVisualStyleBackColor = true;
            this.sqrRtBtn.Click += new System.EventHandler(this.sqrRtBtn_Click);
            // 
            // percentBtn
            // 
            this.percentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentBtn.Location = new System.Drawing.Point(330, 160);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(75, 31);
            this.percentBtn.TabIndex = 16;
            this.percentBtn.Text = "%";
            this.percentBtn.UseVisualStyleBackColor = true;
            this.percentBtn.Click += new System.EventHandler(this.percentBtn_Click);
            // 
            // oneDivX
            // 
            this.oneDivX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDivX.Location = new System.Drawing.Point(330, 197);
            this.oneDivX.Name = "oneDivX";
            this.oneDivX.Size = new System.Drawing.Size(75, 31);
            this.oneDivX.TabIndex = 15;
            this.oneDivX.Text = "1/x";
            this.oneDivX.UseVisualStyleBackColor = true;
            this.oneDivX.Click += new System.EventHandler(this.oneDivX_Click);
            // 
            // equalsBtn
            // 
            this.equalsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsBtn.Location = new System.Drawing.Point(330, 234);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(75, 68);
            this.equalsBtn.TabIndex = 14;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = true;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.Location = new System.Drawing.Point(168, 160);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(75, 31);
            this.nineBtn.TabIndex = 13;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.Location = new System.Drawing.Point(87, 160);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(75, 31);
            this.eightBtn.TabIndex = 12;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.Location = new System.Drawing.Point(6, 160);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(75, 31);
            this.sevenBtn.TabIndex = 11;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.Location = new System.Drawing.Point(168, 197);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(75, 31);
            this.sixBtn.TabIndex = 10;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.Location = new System.Drawing.Point(87, 197);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(75, 31);
            this.fiveBtn.TabIndex = 9;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Location = new System.Drawing.Point(6, 197);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(75, 31);
            this.fourBtn.TabIndex = 8;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(168, 234);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(75, 31);
            this.threeBtn.TabIndex = 7;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(87, 234);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(75, 31);
            this.twoBtn.TabIndex = 6;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(6, 234);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(75, 31);
            this.oneBtn.TabIndex = 5;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(249, 271);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 31);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // decBtn
            // 
            this.decBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decBtn.Location = new System.Drawing.Point(168, 271);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(75, 31);
            this.decBtn.TabIndex = 3;
            this.decBtn.Text = ".";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.Location = new System.Drawing.Point(6, 271);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(156, 31);
            this.zeroBtn.TabIndex = 2;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // inOut
            // 
            this.inOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inOut.Location = new System.Drawing.Point(6, 46);
            this.inOut.Name = "inOut";
            this.inOut.ReadOnly = true;
            this.inOut.Size = new System.Drawing.Size(399, 34);
            this.inOut.TabIndex = 1;
            // 
            // calculation
            // 
            this.calculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculation.Location = new System.Drawing.Point(6, 6);
            this.calculation.Name = "calculation";
            this.calculation.ReadOnly = true;
            this.calculation.Size = new System.Drawing.Size(399, 34);
            this.calculation.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.convClr);
            this.tabPage2.Controls.Add(this.convert);
            this.tabPage2.Controls.Add(this.afterConv);
            this.tabPage2.Controls.Add(this.toConv);
            this.tabPage2.Controls.Add(this.toConvert);
            this.tabPage2.Controls.Add(this.converted);
            this.tabPage2.Controls.Add(this.celToFah);
            this.tabPage2.Controls.Add(this.fahToCel);
            this.tabPage2.Controls.Add(this.feetToInch);
            this.tabPage2.Controls.Add(this.inchToFeet);
            this.tabPage2.Controls.Add(this.poundToEuro);
            this.tabPage2.Controls.Add(this.euroToPound);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // convert
            // 
            this.convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.Location = new System.Drawing.Point(161, 50);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(90, 34);
            this.convert.TabIndex = 10;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // afterConv
            // 
            this.afterConv.AutoSize = true;
            this.afterConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterConv.Location = new System.Drawing.Point(252, 18);
            this.afterConv.Name = "afterConv";
            this.afterConv.Size = new System.Drawing.Size(83, 29);
            this.afterConv.TabIndex = 9;
            this.afterConv.Text = "Pound";
            // 
            // toConv
            // 
            this.toConv.AutoSize = true;
            this.toConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toConv.Location = new System.Drawing.Point(3, 18);
            this.toConv.Name = "toConv";
            this.toConv.Size = new System.Drawing.Size(64, 29);
            this.toConv.TabIndex = 8;
            this.toConv.Text = "Euro";
            // 
            // toConvert
            // 
            this.toConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toConvert.Location = new System.Drawing.Point(6, 50);
            this.toConvert.Name = "toConvert";
            this.toConvert.Size = new System.Drawing.Size(149, 34);
            this.toConvert.TabIndex = 7;
            // 
            // converted
            // 
            this.converted.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converted.Location = new System.Drawing.Point(257, 50);
            this.converted.Name = "converted";
            this.converted.ReadOnly = true;
            this.converted.Size = new System.Drawing.Size(149, 34);
            this.converted.TabIndex = 6;
            // 
            // celToFah
            // 
            this.celToFah.AutoSize = true;
            this.celToFah.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celToFah.Location = new System.Drawing.Point(257, 139);
            this.celToFah.Name = "celToFah";
            this.celToFah.Size = new System.Drawing.Size(114, 33);
            this.celToFah.TabIndex = 5;
            this.celToFah.TabStop = true;
            this.celToFah.Text = "Celsius";
            this.celToFah.UseVisualStyleBackColor = true;
            this.celToFah.CheckedChanged += new System.EventHandler(this.celToFah_CheckedChanged);
            // 
            // fahToCel
            // 
            this.fahToCel.AutoSize = true;
            this.fahToCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahToCel.Location = new System.Drawing.Point(257, 178);
            this.fahToCel.Name = "fahToCel";
            this.fahToCel.Size = new System.Drawing.Size(149, 33);
            this.fahToCel.TabIndex = 4;
            this.fahToCel.TabStop = true;
            this.fahToCel.Text = "Fahrenheit";
            this.fahToCel.UseVisualStyleBackColor = true;
            this.fahToCel.CheckedChanged += new System.EventHandler(this.fahToCel_CheckedChanged);
            // 
            // feetToInch
            // 
            this.feetToInch.AutoSize = true;
            this.feetToInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetToInch.Location = new System.Drawing.Point(131, 178);
            this.feetToInch.Name = "feetToInch";
            this.feetToInch.Size = new System.Drawing.Size(83, 33);
            this.feetToInch.TabIndex = 3;
            this.feetToInch.Text = "Feet";
            this.feetToInch.UseVisualStyleBackColor = true;
            this.feetToInch.CheckedChanged += new System.EventHandler(this.feetToInch_CheckedChanged);
            // 
            // inchToFeet
            // 
            this.inchToFeet.AutoSize = true;
            this.inchToFeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchToFeet.Location = new System.Drawing.Point(131, 139);
            this.inchToFeet.Name = "inchToFeet";
            this.inchToFeet.Size = new System.Drawing.Size(78, 33);
            this.inchToFeet.TabIndex = 2;
            this.inchToFeet.Text = "Inch";
            this.inchToFeet.UseVisualStyleBackColor = true;
            this.inchToFeet.CheckedChanged += new System.EventHandler(this.inchToFeet_CheckedChanged);
            // 
            // poundToEuro
            // 
            this.poundToEuro.AutoSize = true;
            this.poundToEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundToEuro.Location = new System.Drawing.Point(6, 178);
            this.poundToEuro.Name = "poundToEuro";
            this.poundToEuro.Size = new System.Drawing.Size(104, 33);
            this.poundToEuro.TabIndex = 1;
            this.poundToEuro.Text = "Pound";
            this.poundToEuro.UseVisualStyleBackColor = true;
            this.poundToEuro.CheckedChanged += new System.EventHandler(this.poundToEuro_CheckedChanged);
            // 
            // euroToPound
            // 
            this.euroToPound.AutoSize = true;
            this.euroToPound.Checked = true;
            this.euroToPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euroToPound.Location = new System.Drawing.Point(8, 139);
            this.euroToPound.Name = "euroToPound";
            this.euroToPound.Size = new System.Drawing.Size(85, 33);
            this.euroToPound.TabIndex = 0;
            this.euroToPound.TabStop = true;
            this.euroToPound.Text = "Euro";
            this.euroToPound.UseVisualStyleBackColor = true;
            this.euroToPound.CheckedChanged += new System.EventHandler(this.euroToPound_CheckedChanged);
            // 
            // convClr
            // 
            this.convClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convClr.Location = new System.Drawing.Point(161, 90);
            this.convClr.Name = "convClr";
            this.convClr.Size = new System.Drawing.Size(90, 34);
            this.convClr.TabIndex = 11;
            this.convClr.Text = "Clear";
            this.convClr.UseVisualStyleBackColor = true;
            this.convClr.Click += new System.EventHandler(this.convClr_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 363);
            this.Controls.Add(this.window);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.window.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl window;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox inOut;
        private System.Windows.Forms.TextBox calculation;
        private System.Windows.Forms.Button memAddBtn;
        private System.Windows.Forms.Button chngSignBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button memSubBtn;
        private System.Windows.Forms.Button memStoreBtn;
        private System.Windows.Forms.Button memRtnBtn;
        private System.Windows.Forms.Button memClrBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button clearEBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button sqrRtBtn;
        private System.Windows.Forms.Button percentBtn;
        private System.Windows.Forms.Button oneDivX;
        private System.Windows.Forms.Button equalsBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Label afterConv;
        private System.Windows.Forms.Label toConv;
        private System.Windows.Forms.TextBox toConvert;
        private System.Windows.Forms.TextBox converted;
        private System.Windows.Forms.RadioButton celToFah;
        private System.Windows.Forms.RadioButton fahToCel;
        private System.Windows.Forms.RadioButton feetToInch;
        private System.Windows.Forms.RadioButton inchToFeet;
        private System.Windows.Forms.RadioButton poundToEuro;
        private System.Windows.Forms.RadioButton euroToPound;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button convClr;
    }
}

