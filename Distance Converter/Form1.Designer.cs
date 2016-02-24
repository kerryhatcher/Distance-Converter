namespace Distance_Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConverted = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelInputStatus = new System.Windows.Forms.Label();
            this.labelSelectionStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a distance to convert";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(172, 26);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(76, 20);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxFrom);
            this.groupBox1.Location = new System.Drawing.Point(34, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.listBoxFrom.Location = new System.Drawing.Point(6, 19);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(89, 95);
            this.listBoxFrom.TabIndex = 0;
            this.listBoxFrom.SelectedIndexChanged += new System.EventHandler(this.listBoxFrom_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxTo);
            this.groupBox2.Location = new System.Drawing.Point(145, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 127);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // listBoxTo
            // 
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.listBoxTo.Location = new System.Drawing.Point(6, 19);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(97, 95);
            this.listBoxTo.TabIndex = 1;
            this.listBoxTo.SelectedIndexChanged += new System.EventHandler(this.listBoxTo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted Distance";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxConverted
            // 
            this.textBoxConverted.Location = new System.Drawing.Point(138, 256);
            this.textBoxConverted.Name = "textBoxConverted";
            this.textBoxConverted.Size = new System.Drawing.Size(100, 20);
            this.textBoxConverted.TabIndex = 5;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Enabled = false;
            this.buttonConvert.Location = new System.Drawing.Point(34, 290);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 45);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelInputStatus
            // 
            this.labelInputStatus.AutoSize = true;
            this.labelInputStatus.Location = new System.Drawing.Point(169, 49);
            this.labelInputStatus.Name = "labelInputStatus";
            this.labelInputStatus.Size = new System.Drawing.Size(0, 13);
            this.labelInputStatus.TabIndex = 8;
            // 
            // labelSelectionStatus
            // 
            this.labelSelectionStatus.AutoSize = true;
            this.labelSelectionStatus.Location = new System.Drawing.Point(37, 228);
            this.labelSelectionStatus.Name = "labelSelectionStatus";
            this.labelSelectionStatus.Size = new System.Drawing.Size(0, 13);
            this.labelSelectionStatus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 366);
            this.Controls.Add(this.labelSelectionStatus);
            this.Controls.Add(this.labelInputStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxConverted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "distanceconverter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.TextBox textBoxConverted;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelInputStatus;
        private System.Windows.Forms.Label labelSelectionStatus;
    }
}

