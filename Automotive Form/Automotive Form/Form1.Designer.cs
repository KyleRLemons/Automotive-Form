namespace Automotive_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lubeJob = new System.Windows.Forms.CheckBox();
            this.oilChange = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transmissionFlush = new System.Windows.Forms.CheckBox();
            this.radiatorFlush = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tireRotation = new System.Windows.Forms.CheckBox();
            this.replaceMuffler = new System.Windows.Forms.CheckBox();
            this.inspector = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serviceLaborSumTextBox = new System.Windows.Forms.TextBox();
            this.partsSumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.taxOnPartsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalFeesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lubeJob);
            this.groupBox1.Controls.Add(this.oilChange);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // lubeJob
            // 
            this.lubeJob.AutoSize = true;
            this.lubeJob.Location = new System.Drawing.Point(43, 62);
            this.lubeJob.Name = "lubeJob";
            this.lubeJob.Size = new System.Drawing.Size(143, 21);
            this.lubeJob.TabIndex = 4;
            this.lubeJob.Text = "Lube job ($18.00)";
            this.lubeJob.UseVisualStyleBackColor = true;
            // 
            // oilChange
            // 
            this.oilChange.AutoSize = true;
            this.oilChange.Location = new System.Drawing.Point(43, 35);
            this.oilChange.Name = "oilChange";
            this.oilChange.Size = new System.Drawing.Size(156, 21);
            this.oilChange.TabIndex = 3;
            this.oilChange.Text = "Oil change ($26.00)";
            this.oilChange.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transmissionFlush);
            this.groupBox2.Controls.Add(this.radiatorFlush);
            this.groupBox2.Location = new System.Drawing.Point(293, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // transmissionFlush
            // 
            this.transmissionFlush.AutoSize = true;
            this.transmissionFlush.Location = new System.Drawing.Point(6, 62);
            this.transmissionFlush.Name = "transmissionFlush";
            this.transmissionFlush.Size = new System.Drawing.Size(206, 21);
            this.transmissionFlush.TabIndex = 5;
            this.transmissionFlush.Text = "Transmission flush ($80.00)";
            this.transmissionFlush.UseVisualStyleBackColor = true;
            // 
            // radiatorFlush
            // 
            this.radiatorFlush.AutoSize = true;
            this.radiatorFlush.Location = new System.Drawing.Point(6, 35);
            this.radiatorFlush.Name = "radiatorFlush";
            this.radiatorFlush.Size = new System.Drawing.Size(176, 21);
            this.radiatorFlush.TabIndex = 5;
            this.radiatorFlush.Text = "Radiator flush ($30.00)";
            this.radiatorFlush.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tireRotation);
            this.groupBox3.Controls.Add(this.replaceMuffler);
            this.groupBox3.Controls.Add(this.inspector);
            this.groupBox3.Location = new System.Drawing.Point(12, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 170);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc.";
            // 
            // tireRotation
            // 
            this.tireRotation.AutoSize = true;
            this.tireRotation.Location = new System.Drawing.Point(43, 89);
            this.tireRotation.Name = "tireRotation";
            this.tireRotation.Size = new System.Drawing.Size(165, 21);
            this.tireRotation.TabIndex = 5;
            this.tireRotation.Text = "Tire rotation ($20.00)";
            this.tireRotation.UseVisualStyleBackColor = true;
            // 
            // replaceMuffler
            // 
            this.replaceMuffler.AutoSize = true;
            this.replaceMuffler.Location = new System.Drawing.Point(43, 62);
            this.replaceMuffler.Name = "replaceMuffler";
            this.replaceMuffler.Size = new System.Drawing.Size(195, 21);
            this.replaceMuffler.TabIndex = 4;
            this.replaceMuffler.Text = "Replace muffler ($100.00)";
            this.replaceMuffler.UseVisualStyleBackColor = true;
            // 
            // inspector
            // 
            this.inspector.AutoSize = true;
            this.inspector.Location = new System.Drawing.Point(43, 35);
            this.inspector.Name = "inspector";
            this.inspector.Size = new System.Drawing.Size(146, 21);
            this.inspector.TabIndex = 3;
            this.inspector.Text = "Inspector ($15.00)";
            this.inspector.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.laborTextBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.partsTextBox);
            this.groupBox4.Location = new System.Drawing.Point(311, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 170);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts && Labor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Labor ($):";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(83, 87);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(100, 22);
            this.laborTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parts ($):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(79, 32);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 22);
            this.partsTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service && Labor:";
            // 
            // serviceLaborSumTextBox
            // 
            this.serviceLaborSumTextBox.Location = new System.Drawing.Point(125, 27);
            this.serviceLaborSumTextBox.Name = "serviceLaborSumTextBox";
            this.serviceLaborSumTextBox.Size = new System.Drawing.Size(100, 22);
            this.serviceLaborSumTextBox.TabIndex = 4;
            // 
            // partsSumTextBox
            // 
            this.partsSumTextBox.Location = new System.Drawing.Point(125, 55);
            this.partsSumTextBox.Name = "partsSumTextBox";
            this.partsSumTextBox.Size = new System.Drawing.Size(100, 22);
            this.partsSumTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parts:";
            // 
            // taxOnPartsTextBox
            // 
            this.taxOnPartsTextBox.Location = new System.Drawing.Point(125, 84);
            this.taxOnPartsTextBox.Name = "taxOnPartsTextBox";
            this.taxOnPartsTextBox.Size = new System.Drawing.Size(100, 22);
            this.taxOnPartsTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tax (on parts):";
            // 
            // totalFeesTextBox
            // 
            this.totalFeesTextBox.Location = new System.Drawing.Point(125, 113);
            this.totalFeesTextBox.Name = "totalFeesTextBox";
            this.totalFeesTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalFeesTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total fees:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.totalFeesTextBox);
            this.groupBox5.Controls.Add(this.serviceLaborSumTextBox);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.taxOnPartsTextBox);
            this.groupBox5.Controls.Add(this.partsSumTextBox);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(12, 304);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(275, 167);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(106, 492);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(131, 44);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(245, 492);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 44);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(382, 492);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 44);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(612, 548);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox lubeJob;
        private System.Windows.Forms.CheckBox oilChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox transmissionFlush;
        private System.Windows.Forms.CheckBox radiatorFlush;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox replaceMuffler;
        private System.Windows.Forms.CheckBox inspector;
        private System.Windows.Forms.CheckBox tireRotation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serviceLaborSumTextBox;
        private System.Windows.Forms.TextBox partsSumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox taxOnPartsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalFeesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

