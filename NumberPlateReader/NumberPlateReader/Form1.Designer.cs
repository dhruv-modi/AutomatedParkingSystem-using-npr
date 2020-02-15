namespace NumberPlateReader
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.axVideoOCXTools1 = new AxVIDEOOCXTOOLSLib.AxVideoOCXTools();
            this.axVideoOCX1 = new AxVIDEOOCXLib.AxVideoOCX();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoOCXTools1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoOCX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number :";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "text1";
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(251, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 53);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(520, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(440, 46);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Select a Plot";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Plot    :";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(76, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 55);
            this.button4.TabIndex = 9;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(182, 391);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 55);
            this.button6.TabIndex = 10;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7.BackColor = System.Drawing.Color.SkyBlue;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(394, 391);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 55);
            this.button7.TabIndex = 12;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button8.BackColor = System.Drawing.Color.SkyBlue;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(288, 391);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 55);
            this.button8.TabIndex = 11;
            this.button8.Text = "3";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button9.BackColor = System.Drawing.Color.SkyBlue;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(818, 391);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 55);
            this.button9.TabIndex = 16;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button10.BackColor = System.Drawing.Color.SkyBlue;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(712, 391);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 55);
            this.button10.TabIndex = 15;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button11.BackColor = System.Drawing.Color.SkyBlue;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(606, 391);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 55);
            this.button11.TabIndex = 14;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button12.BackColor = System.Drawing.Color.SkyBlue;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(500, 391);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 55);
            this.button12.TabIndex = 13;
            this.button12.Text = "5";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button13.BackColor = System.Drawing.Color.SkyBlue;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(1029, 391);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 55);
            this.button13.TabIndex = 18;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button14.BackColor = System.Drawing.Color.SkyBlue;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(923, 391);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 55);
            this.button14.TabIndex = 17;
            this.button14.Text = "9";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button15.BackColor = System.Drawing.Color.SkyBlue;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(1086, 452);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 59);
            this.button15.TabIndex = 28;
            this.button15.Text = "P";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button16.BackColor = System.Drawing.Color.SkyBlue;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(980, 452);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 59);
            this.button16.TabIndex = 27;
            this.button16.Text = "O";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button17.BackColor = System.Drawing.Color.SkyBlue;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(875, 452);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 59);
            this.button17.TabIndex = 26;
            this.button17.Text = "I";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button18.BackColor = System.Drawing.Color.SkyBlue;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(769, 452);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 59);
            this.button18.TabIndex = 25;
            this.button18.Text = "U";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button19.BackColor = System.Drawing.Color.SkyBlue;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(663, 452);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 59);
            this.button19.TabIndex = 24;
            this.button19.Text = "Y";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button20.BackColor = System.Drawing.Color.SkyBlue;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(557, 452);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 59);
            this.button20.TabIndex = 23;
            this.button20.Text = "T";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button21.BackColor = System.Drawing.Color.SkyBlue;
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(451, 452);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(100, 59);
            this.button21.TabIndex = 22;
            this.button21.Text = "R";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button22.BackColor = System.Drawing.Color.SkyBlue;
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(345, 452);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(100, 59);
            this.button22.TabIndex = 21;
            this.button22.Text = "E";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button23.BackColor = System.Drawing.Color.SkyBlue;
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(239, 452);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 59);
            this.button23.TabIndex = 20;
            this.button23.Text = "W";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button24.BackColor = System.Drawing.Color.SkyBlue;
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(133, 452);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(100, 59);
            this.button24.TabIndex = 19;
            this.button24.Text = "Q";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button26
            // 
            this.button26.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button26.BackColor = System.Drawing.Color.SkyBlue;
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(1043, 517);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(100, 59);
            this.button26.TabIndex = 37;
            this.button26.Text = "L";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button27.BackColor = System.Drawing.Color.SkyBlue;
            this.button27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(937, 517);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(100, 59);
            this.button27.TabIndex = 36;
            this.button27.Text = "K";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button28.BackColor = System.Drawing.Color.SkyBlue;
            this.button28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(831, 517);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(100, 59);
            this.button28.TabIndex = 35;
            this.button28.Text = "J";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button29.BackColor = System.Drawing.Color.SkyBlue;
            this.button29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(725, 517);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(100, 59);
            this.button29.TabIndex = 34;
            this.button29.Text = "H";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button30.BackColor = System.Drawing.Color.SkyBlue;
            this.button30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(619, 517);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(100, 59);
            this.button30.TabIndex = 33;
            this.button30.Text = "G";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button31.BackColor = System.Drawing.Color.SkyBlue;
            this.button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(513, 517);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(100, 59);
            this.button31.TabIndex = 32;
            this.button31.Text = "F";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button32.BackColor = System.Drawing.Color.SkyBlue;
            this.button32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(407, 517);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(100, 59);
            this.button32.TabIndex = 31;
            this.button32.Text = "D";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button33.BackColor = System.Drawing.Color.SkyBlue;
            this.button33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(301, 517);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(100, 59);
            this.button33.TabIndex = 30;
            this.button33.Text = "S";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button34.BackColor = System.Drawing.Color.SkyBlue;
            this.button34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.Location = new System.Drawing.Point(195, 517);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(100, 59);
            this.button34.TabIndex = 29;
            this.button34.Text = "A";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button36
            // 
            this.button36.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button36.BackColor = System.Drawing.Color.SkyBlue;
            this.button36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.Location = new System.Drawing.Point(937, 582);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(100, 59);
            this.button36.TabIndex = 44;
            this.button36.Text = "M";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button37.BackColor = System.Drawing.Color.SkyBlue;
            this.button37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.Location = new System.Drawing.Point(831, 582);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(100, 59);
            this.button37.TabIndex = 43;
            this.button37.Text = "N";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button38.BackColor = System.Drawing.Color.SkyBlue;
            this.button38.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.Location = new System.Drawing.Point(725, 582);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(100, 59);
            this.button38.TabIndex = 42;
            this.button38.Text = "B";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button39.BackColor = System.Drawing.Color.SkyBlue;
            this.button39.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.Location = new System.Drawing.Point(619, 582);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(100, 59);
            this.button39.TabIndex = 41;
            this.button39.Text = "V";
            this.button39.UseVisualStyleBackColor = false;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button40
            // 
            this.button40.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button40.BackColor = System.Drawing.Color.SkyBlue;
            this.button40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.Location = new System.Drawing.Point(513, 582);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(100, 59);
            this.button40.TabIndex = 40;
            this.button40.Text = "C";
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button41.BackColor = System.Drawing.Color.SkyBlue;
            this.button41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button41.Location = new System.Drawing.Point(407, 582);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(100, 59);
            this.button41.TabIndex = 39;
            this.button41.Text = "X";
            this.button41.UseVisualStyleBackColor = false;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button42.BackColor = System.Drawing.Color.SkyBlue;
            this.button42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button42.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.Location = new System.Drawing.Point(301, 582);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(100, 59);
            this.button42.TabIndex = 38;
            this.button42.Text = "Z";
            this.button42.UseVisualStyleBackColor = false;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Image = global::NumberPlateReader.Properties.Resources.logout3;
            this.button3.Location = new System.Drawing.Point(1273, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 87);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button35
            // 
            this.button35.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button35.BackColor = System.Drawing.Color.SkyBlue;
            this.button35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.Location = new System.Drawing.Point(1135, 391);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(141, 55);
            this.button35.TabIndex = 46;
            this.button35.Text = "Delete";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.BackColor = System.Drawing.SystemColors.InfoText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(-433, 656);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2167, 95);
            this.label3.TabIndex = 47;
            this.label3.Text = "Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.Lime;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(844, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 67);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "VIP";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.Color.BlueViolet;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(667, 10);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(171, 67);
            this.checkBox2.TabIndex = 49;
            this.checkBox2.Text = "Entry";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(1098, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 31);
            this.label4.TabIndex = 50;
            this.label4.Text = "Logged in as";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(1097, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 51;
            this.label5.Text = "123456789";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // axVideoOCXTools1
            // 
            this.axVideoOCXTools1.Enabled = true;
            this.axVideoOCXTools1.Location = new System.Drawing.Point(942, 105);
            this.axVideoOCXTools1.Name = "axVideoOCXTools1";
            this.axVideoOCXTools1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoOCXTools1.OcxState")));
            this.axVideoOCXTools1.Size = new System.Drawing.Size(32, 32);
            this.axVideoOCXTools1.TabIndex = 53;
            // 
            // axVideoOCX1
            // 
            this.axVideoOCX1.Enabled = true;
            this.axVideoOCX1.Location = new System.Drawing.Point(980, 105);
            this.axVideoOCX1.Name = "axVideoOCX1";
            this.axVideoOCX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoOCX1.OcxState")));
            this.axVideoOCX1.Size = new System.Drawing.Size(378, 213);
            this.axVideoOCX1.TabIndex = 54;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher2.Path = "C:\\dhruv_tut\\NumberPlateReader\\NumberPlateReader\\bin\\Release\\output";
            this.fileSystemWatcher2.SynchronizingObject = this;
            this.fileSystemWatcher2.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher2_Changed);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.BackColor = System.Drawing.Color.Black;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox3.Location = new System.Drawing.Point(1351, 726);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(19, 25);
            this.checkBox3.TabIndex = 55;
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(1256, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.axVideoOCXTools1);
            this.Controls.Add(this.axVideoOCX1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoOCXTools1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoOCX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private AxVIDEOOCXLib.AxVideoOCX axVideoOCX1;
        private AxVIDEOOCXTOOLSLib.AxVideoOCXTools axVideoOCXTools1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label6;
    }
}

