namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxComboCalc = new System.Windows.Forms.GroupBox();
            this.ComboboxCalculator = new System.Windows.Forms.Button();
            this.comboBox1ComboCalc_Operator = new System.Windows.Forms.ComboBox();
            this.textBoxComboCalc_result = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_Oper1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRadioCal = new System.Windows.Forms.GroupBox();
            this.RdioboxCalculator = new System.Windows.Forms.Button();
            this.textBoxRadioCalc_result = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_Oper1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1RaioCalc_add = new System.Windows.Forms.RadioButton();
            this.comboBox1RaioCalc_sub = new System.Windows.Forms.RadioButton();
            this.groupBoxComboCalc.SuspendLayout();
            this.groupBoxRadioCal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComboCalc
            // 
            this.groupBoxComboCalc.Controls.Add(this.ComboboxCalculator);
            this.groupBoxComboCalc.Controls.Add(this.comboBox1ComboCalc_Operator);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_result);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Oper2);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Oper1);
            this.groupBoxComboCalc.Controls.Add(this.label4);
            this.groupBoxComboCalc.Controls.Add(this.label3);
            this.groupBoxComboCalc.Controls.Add(this.label2);
            this.groupBoxComboCalc.Controls.Add(this.label1);
            this.groupBoxComboCalc.Location = new System.Drawing.Point(27, 60);
            this.groupBoxComboCalc.Name = "groupBoxComboCalc";
            this.groupBoxComboCalc.Size = new System.Drawing.Size(795, 202);
            this.groupBoxComboCalc.TabIndex = 0;
            this.groupBoxComboCalc.TabStop = false;
            this.groupBoxComboCalc.Text = "ComboBox Calculator";
            this.groupBoxComboCalc.Enter += new System.EventHandler(this.groupBoxComboCalc_Enter);
            // 
            // ComboboxCalculator
            // 
            this.ComboboxCalculator.Location = new System.Drawing.Point(481, 105);
            this.ComboboxCalculator.Name = "ComboboxCalculator";
            this.ComboboxCalculator.Size = new System.Drawing.Size(101, 28);
            this.ComboboxCalculator.TabIndex = 8;
            this.ComboboxCalculator.Text = "Calculate";
            this.ComboboxCalculator.UseVisualStyleBackColor = true;
            this.ComboboxCalculator.Click += new System.EventHandler(this.ComboboxCalculator_Click_1);
            // 
            // comboBox1ComboCalc_Operator
            // 
            this.comboBox1ComboCalc_Operator.FormattingEnabled = true;
            this.comboBox1ComboCalc_Operator.Location = new System.Drawing.Point(181, 105);
            this.comboBox1ComboCalc_Operator.Name = "comboBox1ComboCalc_Operator";
            this.comboBox1ComboCalc_Operator.Size = new System.Drawing.Size(134, 26);
            this.comboBox1ComboCalc_Operator.TabIndex = 7;
            this.comboBox1ComboCalc_Operator.SelectedIndexChanged += new System.EventHandler(this.comboBox1ComboCalc_Operator_SelectedIndexChanged);
            // 
            // textBoxComboCalc_result
            // 
            this.textBoxComboCalc_result.Location = new System.Drawing.Point(598, 105);
            this.textBoxComboCalc_result.Name = "textBoxComboCalc_result";
            this.textBoxComboCalc_result.Size = new System.Drawing.Size(121, 28);
            this.textBoxComboCalc_result.TabIndex = 6;
            this.textBoxComboCalc_result.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxComboCalc_Oper2
            // 
            this.textBoxComboCalc_Oper2.Location = new System.Drawing.Point(334, 105);
            this.textBoxComboCalc_Oper2.Name = "textBoxComboCalc_Oper2";
            this.textBoxComboCalc_Oper2.Size = new System.Drawing.Size(121, 28);
            this.textBoxComboCalc_Oper2.TabIndex = 5;
            // 
            // textBoxComboCalc_Oper1
            // 
            this.textBoxComboCalc_Oper1.Location = new System.Drawing.Point(36, 105);
            this.textBoxComboCalc_Oper1.Name = "textBoxComboCalc_Oper1";
            this.textBoxComboCalc_Oper1.Size = new System.Drawing.Size(121, 28);
            this.textBoxComboCalc_Oper1.TabIndex = 4;
            this.textBoxComboCalc_Oper1.TextChanged += new System.EventHandler(this.textBoxComboCalc_Oper1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operand2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1";
            // 
            // groupBoxRadioCal
            // 
            this.groupBoxRadioCal.Controls.Add(this.comboBox1RaioCalc_sub);
            this.groupBoxRadioCal.Controls.Add(this.comboBox1RaioCalc_add);
            this.groupBoxRadioCal.Controls.Add(this.RdioboxCalculator);
            this.groupBoxRadioCal.Controls.Add(this.textBoxRadioCalc_result);
            this.groupBoxRadioCal.Controls.Add(this.textBoxRadioCalc_Oper2);
            this.groupBoxRadioCal.Controls.Add(this.textBoxRadioCalc_Oper1);
            this.groupBoxRadioCal.Controls.Add(this.label5);
            this.groupBoxRadioCal.Controls.Add(this.label6);
            this.groupBoxRadioCal.Controls.Add(this.label7);
            this.groupBoxRadioCal.Controls.Add(this.label8);
            this.groupBoxRadioCal.Location = new System.Drawing.Point(27, 335);
            this.groupBoxRadioCal.Name = "groupBoxRadioCal";
            this.groupBoxRadioCal.Size = new System.Drawing.Size(795, 202);
            this.groupBoxRadioCal.TabIndex = 9;
            this.groupBoxRadioCal.TabStop = false;
            this.groupBoxRadioCal.Text = "RadioBox Calculator";
            this.groupBoxRadioCal.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RdioboxCalculator
            // 
            this.RdioboxCalculator.Location = new System.Drawing.Point(466, 105);
            this.RdioboxCalculator.Name = "RdioboxCalculator";
            this.RdioboxCalculator.Size = new System.Drawing.Size(101, 28);
            this.RdioboxCalculator.TabIndex = 8;
            this.RdioboxCalculator.Text = "Calculate";
            this.RdioboxCalculator.UseVisualStyleBackColor = true;
            // 
            // textBoxRadioCalc_result
            // 
            this.textBoxRadioCalc_result.Location = new System.Drawing.Point(598, 105);
            this.textBoxRadioCalc_result.Name = "textBoxRadioCalc_result";
            this.textBoxRadioCalc_result.Size = new System.Drawing.Size(121, 28);
            this.textBoxRadioCalc_result.TabIndex = 6;
            // 
            // textBoxRadioCalc_Oper2
            // 
            this.textBoxRadioCalc_Oper2.Location = new System.Drawing.Point(312, 105);
            this.textBoxRadioCalc_Oper2.Name = "textBoxRadioCalc_Oper2";
            this.textBoxRadioCalc_Oper2.Size = new System.Drawing.Size(121, 28);
            this.textBoxRadioCalc_Oper2.TabIndex = 5;
            // 
            // textBoxRadioCalc_Oper1
            // 
            this.textBoxRadioCalc_Oper1.Location = new System.Drawing.Point(36, 105);
            this.textBoxRadioCalc_Oper1.Name = "textBoxRadioCalc_Oper1";
            this.textBoxRadioCalc_Oper1.Size = new System.Drawing.Size(121, 28);
            this.textBoxRadioCalc_Oper1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Operand2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Operator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Operand 1";
            // 
            // comboBox1RaioCalc_add
            // 
            this.comboBox1RaioCalc_add.AutoSize = true;
            this.comboBox1RaioCalc_add.Location = new System.Drawing.Point(217, 101);
            this.comboBox1RaioCalc_add.Name = "comboBox1RaioCalc_add";
            this.comboBox1RaioCalc_add.Size = new System.Drawing.Size(42, 22);
            this.comboBox1RaioCalc_add.TabIndex = 9;
            this.comboBox1RaioCalc_add.TabStop = true;
            this.comboBox1RaioCalc_add.Text = "+";
            this.comboBox1RaioCalc_add.UseVisualStyleBackColor = true;
            // 
            // comboBox1RaioCalc_sub
            // 
            this.comboBox1RaioCalc_sub.AutoSize = true;
            this.comboBox1RaioCalc_sub.Location = new System.Drawing.Point(217, 129);
            this.comboBox1RaioCalc_sub.Name = "comboBox1RaioCalc_sub";
            this.comboBox1RaioCalc_sub.Size = new System.Drawing.Size(42, 22);
            this.comboBox1RaioCalc_sub.TabIndex = 10;
            this.comboBox1RaioCalc_sub.TabStop = true;
            this.comboBox1RaioCalc_sub.Text = "-";
            this.comboBox1RaioCalc_sub.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 609);
            this.Controls.Add(this.groupBoxRadioCal);
            this.Controls.Add(this.groupBoxComboCalc);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxComboCalc.ResumeLayout(false);
            this.groupBoxComboCalc.PerformLayout();
            this.groupBoxRadioCal.ResumeLayout(false);
            this.groupBoxRadioCal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComboCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1ComboCalc_Operator;
        private System.Windows.Forms.TextBox textBoxComboCalc_result;
        private System.Windows.Forms.TextBox textBoxComboCalc_Oper2;
        private System.Windows.Forms.TextBox textBoxComboCalc_Oper1;
        private System.Windows.Forms.Button ComboboxCalculator;
        private System.Windows.Forms.GroupBox groupBoxRadioCal;
        private System.Windows.Forms.Button RdioboxCalculator;
        private System.Windows.Forms.TextBox textBoxRadioCalc_result;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Oper2;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Oper1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton comboBox1RaioCalc_sub;
        private System.Windows.Forms.RadioButton comboBox1RaioCalc_add;
    }
}

