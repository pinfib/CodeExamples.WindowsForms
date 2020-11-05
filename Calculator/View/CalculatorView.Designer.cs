namespace Calculator.View
{
    partial class CalculatorView
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelMemoryData = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCurrentMemory = new System.Windows.Forms.Label();
            this.flowLayoutPanelOperation = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.textBoxData = new Calculator.View.CalculatorDataTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClearTextBox = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonMemoryCleare = new System.Windows.Forms.Button();
            this.buttonMemoryRead = new System.Windows.Forms.Button();
            this.buttonMemoryAddition = new System.Windows.Forms.Button();
            this.buttonMemorySubtraction = new System.Windows.Forms.Button();
            this.buttonMemorySave = new System.Windows.Forms.Button();
            this.flowLayoutPanelUnaryOperations = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.calculatorButton1 = new Calculator.View.CalculatorButton();
            this.calculatorButton2 = new Calculator.View.CalculatorButton();
            this.calculatorButton3 = new Calculator.View.CalculatorButton();
            this.calculatorButton4 = new Calculator.View.CalculatorButton();
            this.calculatorButton5 = new Calculator.View.CalculatorButton();
            this.calculatorButton6 = new Calculator.View.CalculatorButton();
            this.calculatorButton7 = new Calculator.View.CalculatorButton();
            this.calculatorButton8 = new Calculator.View.CalculatorButton();
            this.calculatorButton9 = new Calculator.View.CalculatorButton();
            this.buttonDecimalSeparator = new Calculator.View.CalculatorButton();
            this.calculatorButton11 = new Calculator.View.CalculatorButton();
            this.buttonResult = new Calculator.View.CalculatorButton();
            this.flowLayoutPanelBinaryOperations = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanelData.SuspendLayout();
            this.flowLayoutPanelMemoryData.SuspendLayout();
            this.flowLayoutPanelOperation.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(226, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // tableLayoutPanelData
            // 
            this.tableLayoutPanelData.ColumnCount = 2;
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelData.Controls.Add(this.flowLayoutPanelMemoryData, 1, 0);
            this.tableLayoutPanelData.Controls.Add(this.flowLayoutPanelOperation, 0, 0);
            this.tableLayoutPanelData.Controls.Add(this.textBoxData, 0, 1);
            this.tableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelData.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 2;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelData.Size = new System.Drawing.Size(226, 76);
            this.tableLayoutPanelData.TabIndex = 2;
            // 
            // flowLayoutPanelMemoryData
            // 
            this.flowLayoutPanelMemoryData.Controls.Add(this.label3);
            this.flowLayoutPanelMemoryData.Controls.Add(this.labelCurrentMemory);
            this.flowLayoutPanelMemoryData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMemoryData.Location = new System.Drawing.Point(100, 0);
            this.flowLayoutPanelMemoryData.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelMemoryData.Name = "flowLayoutPanelMemoryData";
            this.flowLayoutPanelMemoryData.Size = new System.Drawing.Size(126, 20);
            this.flowLayoutPanelMemoryData.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Память:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentMemory
            // 
            this.labelCurrentMemory.AutoSize = true;
            this.labelCurrentMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentMemory.Location = new System.Drawing.Point(54, 0);
            this.labelCurrentMemory.Name = "labelCurrentMemory";
            this.labelCurrentMemory.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentMemory.TabIndex = 3;
            this.labelCurrentMemory.Text = "0";
            this.labelCurrentMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelOperation
            // 
            this.flowLayoutPanelOperation.Controls.Add(this.label1);
            this.flowLayoutPanelOperation.Controls.Add(this.labelCurrentOperation);
            this.flowLayoutPanelOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOperation.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelOperation.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelOperation.Name = "flowLayoutPanelOperation";
            this.flowLayoutPanelOperation.Size = new System.Drawing.Size(100, 20);
            this.flowLayoutPanelOperation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Операция:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentOperation.Location = new System.Drawing.Point(68, 0);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelCurrentOperation.Size = new System.Drawing.Size(3, 13);
            this.labelCurrentOperation.TabIndex = 1;
            this.labelCurrentOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxData
            // 
            this.tableLayoutPanelData.SetColumnSpan(this.textBoxData, 2);
            this.textBoxData.DataIsResult = true;
            this.textBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxData.Location = new System.Drawing.Point(3, 34);
            this.textBoxData.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(220, 30);
            this.textBoxData.TabIndex = 0;
            this.textBoxData.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonClearTextBox);
            this.flowLayoutPanel1.Controls.Add(this.buttonClearAll);
            this.flowLayoutPanel1.Controls.Add(this.buttonMemoryCleare);
            this.flowLayoutPanel1.Controls.Add(this.buttonMemoryRead);
            this.flowLayoutPanel1.Controls.Add(this.buttonMemoryAddition);
            this.flowLayoutPanel1.Controls.Add(this.buttonMemorySubtraction);
            this.flowLayoutPanel1.Controls.Add(this.buttonMemorySave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 34);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonClearTextBox
            // 
            this.buttonClearTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearTextBox.Location = new System.Drawing.Point(2, 2);
            this.buttonClearTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClearTextBox.Name = "buttonClearTextBox";
            this.buttonClearTextBox.Size = new System.Drawing.Size(30, 30);
            this.buttonClearTextBox.TabIndex = 0;
            this.buttonClearTextBox.Text = "C";
            this.buttonClearTextBox.UseVisualStyleBackColor = false;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearAll.Location = new System.Drawing.Point(34, 2);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(30, 30);
            this.buttonClearAll.TabIndex = 1;
            this.buttonClearAll.Text = "CE";
            this.buttonClearAll.UseVisualStyleBackColor = false;
            // 
            // buttonMemoryCleare
            // 
            this.buttonMemoryCleare.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMemoryCleare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemoryCleare.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMemoryCleare.Location = new System.Drawing.Point(66, 2);
            this.buttonMemoryCleare.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMemoryCleare.Name = "buttonMemoryCleare";
            this.buttonMemoryCleare.Size = new System.Drawing.Size(30, 30);
            this.buttonMemoryCleare.TabIndex = 2;
            this.buttonMemoryCleare.Text = "MC";
            this.buttonMemoryCleare.UseVisualStyleBackColor = false;
            // 
            // buttonMemoryRead
            // 
            this.buttonMemoryRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMemoryRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemoryRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMemoryRead.Location = new System.Drawing.Point(98, 2);
            this.buttonMemoryRead.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMemoryRead.Name = "buttonMemoryRead";
            this.buttonMemoryRead.Size = new System.Drawing.Size(30, 30);
            this.buttonMemoryRead.TabIndex = 3;
            this.buttonMemoryRead.Text = "MR";
            this.buttonMemoryRead.UseVisualStyleBackColor = false;
            // 
            // buttonMemoryAddition
            // 
            this.buttonMemoryAddition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMemoryAddition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemoryAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMemoryAddition.Location = new System.Drawing.Point(130, 2);
            this.buttonMemoryAddition.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMemoryAddition.Name = "buttonMemoryAddition";
            this.buttonMemoryAddition.Size = new System.Drawing.Size(30, 30);
            this.buttonMemoryAddition.TabIndex = 4;
            this.buttonMemoryAddition.Text = "M+";
            this.buttonMemoryAddition.UseVisualStyleBackColor = false;
            // 
            // buttonMemorySubtraction
            // 
            this.buttonMemorySubtraction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMemorySubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemorySubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMemorySubtraction.Location = new System.Drawing.Point(162, 2);
            this.buttonMemorySubtraction.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMemorySubtraction.Name = "buttonMemorySubtraction";
            this.buttonMemorySubtraction.Size = new System.Drawing.Size(30, 30);
            this.buttonMemorySubtraction.TabIndex = 5;
            this.buttonMemorySubtraction.Text = "M-";
            this.buttonMemorySubtraction.UseVisualStyleBackColor = false;
            // 
            // buttonMemorySave
            // 
            this.buttonMemorySave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMemorySave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemorySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMemorySave.Location = new System.Drawing.Point(194, 2);
            this.buttonMemorySave.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMemorySave.Name = "buttonMemorySave";
            this.buttonMemorySave.Size = new System.Drawing.Size(30, 30);
            this.buttonMemorySave.TabIndex = 6;
            this.buttonMemorySave.Text = "MS";
            this.buttonMemorySave.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelUnaryOperations
            // 
            this.flowLayoutPanelUnaryOperations.AutoSize = true;
            this.flowLayoutPanelUnaryOperations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelUnaryOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUnaryOperations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelUnaryOperations.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelUnaryOperations.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelUnaryOperations.MaximumSize = new System.Drawing.Size(0, 177);
            this.flowLayoutPanelUnaryOperations.MinimumSize = new System.Drawing.Size(46, 177);
            this.flowLayoutPanelUnaryOperations.Name = "flowLayoutPanelUnaryOperations";
            this.flowLayoutPanelUnaryOperations.Size = new System.Drawing.Size(46, 177);
            this.flowLayoutPanelUnaryOperations.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.calculatorButton1);
            this.flowLayoutPanel3.Controls.Add(this.calculatorButton2);
            this.flowLayoutPanel3.Controls.Add(this.calculatorButton3);
            this.flowLayoutPanel3.Controls.Add(this.calculatorButton4);
            this.flowLayoutPanel3.Controls.Add(this.calculatorButton5);
            this.flowLayoutPanel3.Controls.Add(this.calculatorButton6);
            this.flowLayoutPanel3.Controls.Add(this.calculatorButton7);
            this.flowLayoutPanel3.Controls.Add(this.calculatorButton8);
            this.flowLayoutPanel3.Controls.Add(this.calculatorButton9);
            this.flowLayoutPanel3.Controls.Add(this.buttonDecimalSeparator);
            this.flowLayoutPanel3.Controls.Add(this.calculatorButton11);
            this.flowLayoutPanel3.Controls.Add(this.buttonResult);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(46, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(132, 177);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // calculatorButton1
            // 
            this.calculatorButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton1.Location = new System.Drawing.Point(2, 2);
            this.calculatorButton1.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorButton1.Name = "calculatorButton1";
            this.calculatorButton1.Size = new System.Drawing.Size(40, 40);
            this.calculatorButton1.TabIndex = 0;
            this.calculatorButton1.Text = "1";
            this.calculatorButton1.UseVisualStyleBackColor = true;
            this.calculatorButton1.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // calculatorButton2
            // 
            this.calculatorButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton2.Location = new System.Drawing.Point(46, 2);
            this.calculatorButton2.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorButton2.Name = "calculatorButton2";
            this.calculatorButton2.Size = new System.Drawing.Size(40, 40);
            this.calculatorButton2.TabIndex = 1;
            this.calculatorButton2.Text = "2";
            this.calculatorButton2.UseVisualStyleBackColor = true;
            this.calculatorButton2.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // calculatorButton3
            // 
            this.calculatorButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton3.Location = new System.Drawing.Point(90, 2);
            this.calculatorButton3.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorButton3.Name = "calculatorButton3";
            this.calculatorButton3.Size = new System.Drawing.Size(40, 40);
            this.calculatorButton3.TabIndex = 2;
            this.calculatorButton3.Text = "3";
            this.calculatorButton3.UseVisualStyleBackColor = true;
            this.calculatorButton3.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // calculatorButton4
            // 
            this.calculatorButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton4.Location = new System.Drawing.Point(2, 46);
            this.calculatorButton4.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorButton4.Name = "calculatorButton4";
            this.calculatorButton4.Size = new System.Drawing.Size(40, 40);
            this.calculatorButton4.TabIndex = 3;
            this.calculatorButton4.Text = "4";
            this.calculatorButton4.UseVisualStyleBackColor = true;
            this.calculatorButton4.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // calculatorButton5
            // 
            this.calculatorButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton5.Location = new System.Drawing.Point(46, 46);
            this.calculatorButton5.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorButton5.Name = "calculatorButton5";
            this.calculatorButton5.Size = new System.Drawing.Size(40, 40);
            this.calculatorButton5.TabIndex = 4;
            this.calculatorButton5.Text = "5";
            this.calculatorButton5.UseVisualStyleBackColor = true;
            this.calculatorButton5.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // calculatorButton6
            // 
            this.calculatorButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton6.Location = new System.Drawing.Point(90, 46);
            this.calculatorButton6.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorButton6.Name = "calculatorButton6";
            this.calculatorButton6.Size = new System.Drawing.Size(40, 40);
            this.calculatorButton6.TabIndex = 5;
            this.calculatorButton6.Text = "6";
            this.calculatorButton6.UseVisualStyleBackColor = true;
            this.calculatorButton6.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // calculatorButton7
            // 
            this.calculatorButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton7.Location = new System.Drawing.Point(2, 90);
            this.calculatorButton7.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorButton7.Name = "calculatorButton7";
            this.calculatorButton7.Size = new System.Drawing.Size(40, 40);
            this.calculatorButton7.TabIndex = 6;
            this.calculatorButton7.Text = "7";
            this.calculatorButton7.UseVisualStyleBackColor = true;
            this.calculatorButton7.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // calculatorButton8
            // 
            this.calculatorButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton8.Location = new System.Drawing.Point(46, 90);
            this.calculatorButton8.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorButton8.Name = "calculatorButton8";
            this.calculatorButton8.Size = new System.Drawing.Size(40, 40);
            this.calculatorButton8.TabIndex = 7;
            this.calculatorButton8.Text = "8";
            this.calculatorButton8.UseVisualStyleBackColor = true;
            this.calculatorButton8.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // calculatorButton9
            // 
            this.calculatorButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton9.Location = new System.Drawing.Point(90, 90);
            this.calculatorButton9.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorButton9.Name = "calculatorButton9";
            this.calculatorButton9.Size = new System.Drawing.Size(40, 40);
            this.calculatorButton9.TabIndex = 8;
            this.calculatorButton9.Text = "9";
            this.calculatorButton9.UseVisualStyleBackColor = true;
            this.calculatorButton9.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // buttonDecimalSeparator
            // 
            this.buttonDecimalSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecimalSeparator.Location = new System.Drawing.Point(2, 134);
            this.buttonDecimalSeparator.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDecimalSeparator.Name = "buttonDecimalSeparator";
            this.buttonDecimalSeparator.Size = new System.Drawing.Size(40, 40);
            this.buttonDecimalSeparator.TabIndex = 9;
            this.buttonDecimalSeparator.UseVisualStyleBackColor = true;
            this.buttonDecimalSeparator.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // calculatorButton11
            // 
            this.calculatorButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton11.Location = new System.Drawing.Point(46, 134);
            this.calculatorButton11.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorButton11.Name = "calculatorButton11";
            this.calculatorButton11.Size = new System.Drawing.Size(40, 40);
            this.calculatorButton11.TabIndex = 10;
            this.calculatorButton11.Text = "0";
            this.calculatorButton11.UseVisualStyleBackColor = true;
            this.calculatorButton11.Click += new System.EventHandler(this.SymbolAddition);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(90, 134);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(2);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(40, 40);
            this.buttonResult.TabIndex = 11;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelBinaryOperations
            // 
            this.flowLayoutPanelBinaryOperations.AutoSize = true;
            this.flowLayoutPanelBinaryOperations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelBinaryOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBinaryOperations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBinaryOperations.Location = new System.Drawing.Point(178, 0);
            this.flowLayoutPanelBinaryOperations.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelBinaryOperations.MaximumSize = new System.Drawing.Size(0, 177);
            this.flowLayoutPanelBinaryOperations.MinimumSize = new System.Drawing.Size(46, 177);
            this.flowLayoutPanelBinaryOperations.Name = "flowLayoutPanelBinaryOperations";
            this.flowLayoutPanelBinaryOperations.Size = new System.Drawing.Size(48, 177);
            this.flowLayoutPanelBinaryOperations.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelUnaryOperations, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelBinaryOperations, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 134);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 177);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // CalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(226, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelData);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(242, 350);
            this.Name = "CalculatorView";
            this.Text = "CalculatorView";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanelData.ResumeLayout(false);
            this.tableLayoutPanelData.PerformLayout();
            this.flowLayoutPanelMemoryData.ResumeLayout(false);
            this.flowLayoutPanelMemoryData.PerformLayout();
            this.flowLayoutPanelOperation.ResumeLayout(false);
            this.flowLayoutPanelOperation.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMemoryData;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label labelCurrentMemory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentOperation;
        private CalculatorDataTextBox textBoxData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private CalculatorButton calculatorButton1;
        private CalculatorButton calculatorButton2;
        private CalculatorButton calculatorButton3;
        private CalculatorButton calculatorButton4;
        private CalculatorButton calculatorButton5;
        private CalculatorButton calculatorButton6;
        private CalculatorButton calculatorButton7;
        private CalculatorButton calculatorButton8;
        private CalculatorButton calculatorButton9;
        private CalculatorButton buttonDecimalSeparator;
        private CalculatorButton calculatorButton11;
        internal CalculatorButton buttonResult;
        internal System.Windows.Forms.Button buttonClearTextBox;
        internal System.Windows.Forms.Button buttonClearAll;
        internal System.Windows.Forms.Button buttonMemoryCleare;
        internal System.Windows.Forms.Button buttonMemoryRead;
        internal System.Windows.Forms.Button buttonMemoryAddition;
        internal System.Windows.Forms.Button buttonMemorySubtraction;
        internal System.Windows.Forms.Button buttonMemorySave;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUnaryOperations;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBinaryOperations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}