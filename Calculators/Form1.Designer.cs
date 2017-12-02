namespace Calculators
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCalc = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.Basicpanel1 = new System.Windows.Forms.Panel();
            this.buttonSecondFunction = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.Scientificpanel1 = new System.Windows.Forms.Panel();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonCube = new System.Windows.Forms.Button();
            this.buttonFacto = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonLin = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Basicpanel1.SuspendLayout();
            this.Scientificpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCalc
            // 
            this.labelCalc.AutoSize = true;
            this.labelCalc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalc.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCalc.Location = new System.Drawing.Point(9, 29);
            this.labelCalc.Name = "labelCalc";
            this.labelCalc.Size = new System.Drawing.Size(0, 12);
            this.labelCalc.TabIndex = 5;
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.Location = new System.Drawing.Point(8, 49);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(201, 20);
            this.textResult.TabIndex = 4;
            this.textResult.Text = "0";
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(215, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.basicToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.basicToolStripMenuItem.Text = "Scientific";
            this.basicToolStripMenuItem.Click += new System.EventHandler(this.basicToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Number_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(155, 82);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "×";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(108, 76);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "9";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Number_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(54, 76);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Number_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(3, 112);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 30);
            this.button8.TabIndex = 5;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Number_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(155, 112);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 30);
            this.button7.TabIndex = 6;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(108, 112);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 30);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Number_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(54, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "5";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Number_Click);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(3, 148);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 30);
            this.button12.TabIndex = 9;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Number_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(155, 148);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 30);
            this.button11.TabIndex = 10;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(108, 148);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 30);
            this.button10.TabIndex = 11;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Number_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(54, 148);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 30);
            this.button9.TabIndex = 12;
            this.button9.Text = "2";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Number_Click);
            // 
            // button16
            // 
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(3, 184);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(40, 30);
            this.button16.TabIndex = 13;
            this.button16.Text = "±";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Number_Click);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(155, 184);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 30);
            this.button15.TabIndex = 14;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(108, 184);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 30);
            this.button14.TabIndex = 15;
            this.button14.Text = ".";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Number_Click);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(54, 184);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 30);
            this.button13.TabIndex = 16;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Number_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.FlatAppearance.BorderSize = 0;
            this.buttonClearEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonClearEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEntry.Location = new System.Drawing.Point(3, 40);
            this.buttonClearEntry.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(40, 30);
            this.buttonClearEntry.TabIndex = 17;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = true;
            this.buttonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // button19
            // 
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(155, 39);
            this.button19.Margin = new System.Windows.Forms.Padding(0);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(40, 30);
            this.button19.TabIndex = 18;
            this.button19.Text = "÷";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(108, 40);
            this.button18.Margin = new System.Windows.Forms.Padding(0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(40, 30);
            this.button18.TabIndex = 19;
            this.button18.Text = "<=";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(54, 40);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(40, 30);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button17
            // 
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(60, 195);
            this.button17.Margin = new System.Windows.Forms.Padding(0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(40, 30);
            this.button17.TabIndex = 24;
            this.button17.Text = "C";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(114, 195);
            this.button20.Margin = new System.Windows.Forms.Padding(0);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 30);
            this.button20.TabIndex = 23;
            this.button20.Text = "<=";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(165, 195);
            this.button21.Margin = new System.Windows.Forms.Padding(0);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(40, 30);
            this.button21.TabIndex = 22;
            this.button21.Text = "/";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(9, 195);
            this.button22.Margin = new System.Windows.Forms.Padding(0);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(40, 30);
            this.button22.TabIndex = 21;
            this.button22.Text = "CE";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // Basicpanel1
            // 
            this.Basicpanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Basicpanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Basicpanel1.Controls.Add(this.buttonSecondFunction);
            this.Basicpanel1.Controls.Add(this.button23);
            this.Basicpanel1.Controls.Add(this.button24);
            this.Basicpanel1.Controls.Add(this.button26);
            this.Basicpanel1.Controls.Add(this.button10);
            this.Basicpanel1.Controls.Add(this.button1);
            this.Basicpanel1.Controls.Add(this.button14);
            this.Basicpanel1.Controls.Add(this.button2);
            this.Basicpanel1.Controls.Add(this.button9);
            this.Basicpanel1.Controls.Add(this.buttonClear);
            this.Basicpanel1.Controls.Add(this.button12);
            this.Basicpanel1.Controls.Add(this.button8);
            this.Basicpanel1.Controls.Add(this.button18);
            this.Basicpanel1.Controls.Add(this.button13);
            this.Basicpanel1.Controls.Add(this.button4);
            this.Basicpanel1.Controls.Add(this.button19);
            this.Basicpanel1.Controls.Add(this.button3);
            this.Basicpanel1.Controls.Add(this.button15);
            this.Basicpanel1.Controls.Add(this.button16);
            this.Basicpanel1.Controls.Add(this.button7);
            this.Basicpanel1.Controls.Add(this.button11);
            this.Basicpanel1.Controls.Add(this.button5);
            this.Basicpanel1.Controls.Add(this.button6);
            this.Basicpanel1.Controls.Add(this.buttonClearEntry);
            this.Basicpanel1.Location = new System.Drawing.Point(8, 164);
            this.Basicpanel1.Name = "Basicpanel1";
            this.Basicpanel1.Size = new System.Drawing.Size(199, 225);
            this.Basicpanel1.TabIndex = 25;
            // 
            // buttonSecondFunction
            // 
            this.buttonSecondFunction.FlatAppearance.BorderSize = 0;
            this.buttonSecondFunction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonSecondFunction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonSecondFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecondFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSecondFunction.Location = new System.Drawing.Point(4, 10);
            this.buttonSecondFunction.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSecondFunction.Name = "buttonSecondFunction";
            this.buttonSecondFunction.Size = new System.Drawing.Size(40, 30);
            this.buttonSecondFunction.TabIndex = 25;
            this.buttonSecondFunction.Text = "2nd";
            this.buttonSecondFunction.UseVisualStyleBackColor = true;
            this.buttonSecondFunction.Click += new System.EventHandler(this.buttonSecondFunction_Click);
            // 
            // button23
            // 
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(109, 10);
            this.button23.Margin = new System.Windows.Forms.Padding(0);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(40, 30);
            this.button23.TabIndex = 24;
            this.button23.Text = "x²";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.OtherOperation);
            // 
            // button24
            // 
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(155, 10);
            this.button24.Margin = new System.Windows.Forms.Padding(0);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(39, 30);
            this.button24.TabIndex = 23;
            this.button24.Text = "¹/x";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.OtherOperation);
            // 
            // button26
            // 
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(55, 10);
            this.button26.Margin = new System.Windows.Forms.Padding(0);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(40, 30);
            this.button26.TabIndex = 21;
            this.button26.Text = "√";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.OtherOperation);
            // 
            // Scientificpanel1
            // 
            this.Scientificpanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scientificpanel1.Controls.Add(this.buttonTan);
            this.Scientificpanel1.Controls.Add(this.buttonCube);
            this.Scientificpanel1.Controls.Add(this.buttonFacto);
            this.Scientificpanel1.Controls.Add(this.buttonLog);
            this.Scientificpanel1.Controls.Add(this.buttonCos);
            this.Scientificpanel1.Controls.Add(this.buttonLin);
            this.Scientificpanel1.Controls.Add(this.buttonSin);
            this.Scientificpanel1.Controls.Add(this.buttonPower);
            this.Scientificpanel1.Location = new System.Drawing.Point(8, 73);
            this.Scientificpanel1.Name = "Scientificpanel1";
            this.Scientificpanel1.Size = new System.Drawing.Size(201, 86);
            this.Scientificpanel1.TabIndex = 26;
            // 
            // buttonTan
            // 
            this.buttonTan.FlatAppearance.BorderSize = 0;
            this.buttonTan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonTan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTan.Location = new System.Drawing.Point(109, 10);
            this.buttonTan.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(40, 30);
            this.buttonTan.TabIndex = 27;
            this.buttonTan.Text = "tan";
            this.buttonTan.UseVisualStyleBackColor = true;
            this.buttonTan.Click += new System.EventHandler(this.OtherOperation);
            // 
            // buttonCube
            // 
            this.buttonCube.FlatAppearance.BorderSize = 0;
            this.buttonCube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonCube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonCube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCube.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCube.Location = new System.Drawing.Point(55, 46);
            this.buttonCube.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCube.Name = "buttonCube";
            this.buttonCube.Size = new System.Drawing.Size(40, 30);
            this.buttonCube.TabIndex = 32;
            this.buttonCube.Text = "x³";
            this.buttonCube.UseVisualStyleBackColor = true;
            this.buttonCube.Click += new System.EventHandler(this.OtherOperation);
            // 
            // buttonFacto
            // 
            this.buttonFacto.FlatAppearance.BorderSize = 0;
            this.buttonFacto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonFacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonFacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacto.Location = new System.Drawing.Point(109, 46);
            this.buttonFacto.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFacto.Name = "buttonFacto";
            this.buttonFacto.Size = new System.Drawing.Size(40, 30);
            this.buttonFacto.TabIndex = 31;
            this.buttonFacto.Text = "n!";
            this.buttonFacto.UseVisualStyleBackColor = true;
            this.buttonFacto.Click += new System.EventHandler(this.OtherOperation);
            // 
            // buttonLog
            // 
            this.buttonLog.FlatAppearance.BorderSize = 0;
            this.buttonLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.Location = new System.Drawing.Point(160, 10);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(40, 30);
            this.buttonLog.TabIndex = 26;
            this.buttonLog.Text = "log10";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.OtherOperation);
            // 
            // buttonCos
            // 
            this.buttonCos.FlatAppearance.BorderSize = 0;
            this.buttonCos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonCos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCos.Location = new System.Drawing.Point(55, 10);
            this.buttonCos.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(40, 30);
            this.buttonCos.TabIndex = 28;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new System.EventHandler(this.OtherOperation);
            // 
            // buttonLin
            // 
            this.buttonLin.FlatAppearance.BorderSize = 0;
            this.buttonLin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonLin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonLin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLin.Location = new System.Drawing.Point(4, 46);
            this.buttonLin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLin.Name = "buttonLin";
            this.buttonLin.Size = new System.Drawing.Size(40, 30);
            this.buttonLin.TabIndex = 29;
            this.buttonLin.Text = "In";
            this.buttonLin.UseVisualStyleBackColor = true;
            this.buttonLin.Click += new System.EventHandler(this.OtherOperation);
            // 
            // buttonSin
            // 
            this.buttonSin.FlatAppearance.BorderSize = 0;
            this.buttonSin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonSin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSin.Location = new System.Drawing.Point(4, 10);
            this.buttonSin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(45, 30);
            this.buttonSin.TabIndex = 25;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.OtherOperation);
            // 
            // buttonPower
            // 
            this.buttonPower.FlatAppearance.BorderSize = 0;
            this.buttonPower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonPower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPower.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPower.Location = new System.Drawing.Point(160, 46);
            this.buttonPower.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(40, 30);
            this.buttonPower.TabIndex = 30;
            this.buttonPower.Text = "^";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 398);
            this.Controls.Add(this.Scientificpanel1);
            this.Controls.Add(this.Basicpanel1);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.labelCalc);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Basicpanel1.ResumeLayout(false);
            this.Scientificpanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCalc;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Panel Basicpanel1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Panel Scientificpanel1;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonCube;
        private System.Windows.Forms.Button buttonFacto;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonLin;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonSecondFunction;
        private System.Windows.Forms.Button button3;
    }
}

