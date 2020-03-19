namespace modbusTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SerialSortCheckbox = new System.Windows.Forms.CheckBox();
            this.SerialConnectBtn = new System.Windows.Forms.Button();
            this.SerialCloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.SpeedComboBox = new System.Windows.Forms.ComboBox();
            this.SerialComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimerStopBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.TimerStartBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CrCcheckBox = new System.Windows.Forms.CheckBox();
            this.TextDataBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GetTextBox = new System.Windows.Forms.TextBox();
            this.PutTextBox = new System.Windows.Forms.TextBox();
            this.DataTextComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialSortCheckbox
            // 
            this.SerialSortCheckbox.AutoSize = true;
            this.SerialSortCheckbox.Location = new System.Drawing.Point(8, 31);
            this.SerialSortCheckbox.Name = "SerialSortCheckbox";
            this.SerialSortCheckbox.Size = new System.Drawing.Size(72, 16);
            this.SerialSortCheckbox.TabIndex = 0;
            this.SerialSortCheckbox.Text = "程式塞選";
            this.SerialSortCheckbox.UseVisualStyleBackColor = true;
            this.SerialSortCheckbox.CheckedChanged += new System.EventHandler(this.SerialSortCheckbox_CheckedChanged);
            // 
            // SerialConnectBtn
            // 
            this.SerialConnectBtn.Location = new System.Drawing.Point(236, 71);
            this.SerialConnectBtn.Name = "SerialConnectBtn";
            this.SerialConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.SerialConnectBtn.TabIndex = 2;
            this.SerialConnectBtn.Text = "連結";
            this.SerialConnectBtn.UseVisualStyleBackColor = true;
            this.SerialConnectBtn.Click += new System.EventHandler(this.SerialConnectBtn_Click);
            // 
            // SerialCloseBtn
            // 
            this.SerialCloseBtn.Location = new System.Drawing.Point(317, 71);
            this.SerialCloseBtn.Name = "SerialCloseBtn";
            this.SerialCloseBtn.Size = new System.Drawing.Size(75, 23);
            this.SerialCloseBtn.TabIndex = 3;
            this.SerialCloseBtn.Text = "關閉";
            this.SerialCloseBtn.UseVisualStyleBackColor = true;
            this.SerialCloseBtn.Click += new System.EventHandler(this.SerialCloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "通訊埠";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "校驗元";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "通訊速度";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StopBitsComboBox);
            this.groupBox1.Controls.Add(this.DataBitsComboBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SerialSortCheckbox);
            this.groupBox1.Controls.Add(this.SerialConnectBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SerialCloseBtn);
            this.groupBox1.Controls.Add(this.ParityComboBox);
            this.groupBox1.Controls.Add(this.SpeedComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SerialComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通訊設定";
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitsComboBox.FormattingEnabled = true;
            this.StopBitsComboBox.Location = new System.Drawing.Point(272, 47);
            this.StopBitsComboBox.Name = "StopBitsComboBox";
            this.StopBitsComboBox.Size = new System.Drawing.Size(121, 20);
            this.StopBitsComboBox.TabIndex = 22;
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Location = new System.Drawing.Point(272, 21);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(121, 20);
            this.DataBitsComboBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "停止位元";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "資料長度";
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(86, 73);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(121, 20);
            this.ParityComboBox.TabIndex = 19;
            // 
            // SpeedComboBox
            // 
            this.SpeedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeedComboBox.FormattingEnabled = true;
            this.SpeedComboBox.Location = new System.Drawing.Point(86, 47);
            this.SpeedComboBox.Name = "SpeedComboBox";
            this.SpeedComboBox.Size = new System.Drawing.Size(121, 20);
            this.SpeedComboBox.TabIndex = 18;
            // 
            // SerialComboBox
            // 
            this.SerialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialComboBox.FormattingEnabled = true;
            this.SerialComboBox.Location = new System.Drawing.Point(86, 21);
            this.SerialComboBox.Name = "SerialComboBox";
            this.SerialComboBox.Size = new System.Drawing.Size(121, 20);
            this.SerialComboBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TimerStopBtn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.IntervalTextBox);
            this.groupBox2.Controls.Add(this.TimerStartBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 47);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "時間設定";
            // 
            // TimerStopBtn
            // 
            this.TimerStopBtn.Location = new System.Drawing.Point(317, 14);
            this.TimerStopBtn.Name = "TimerStopBtn";
            this.TimerStopBtn.Size = new System.Drawing.Size(75, 23);
            this.TimerStopBtn.TabIndex = 14;
            this.TimerStopBtn.Text = "停止";
            this.TimerStopBtn.UseVisualStyleBackColor = true;
            this.TimerStopBtn.Click += new System.EventHandler(this.TimerStopBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "ms";
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(44, 16);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(139, 22);
            this.IntervalTextBox.TabIndex = 1;
            this.IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TimerStartBtn
            // 
            this.TimerStartBtn.Location = new System.Drawing.Point(236, 14);
            this.TimerStartBtn.Name = "TimerStartBtn";
            this.TimerStartBtn.Size = new System.Drawing.Size(75, 23);
            this.TimerStartBtn.TabIndex = 13;
            this.TimerStartBtn.Text = "啟動";
            this.TimerStartBtn.UseVisualStyleBackColor = true;
            this.TimerStartBtn.Click += new System.EventHandler(this.TimerStartBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "間隔";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "輸入資料";
            // 
            // CrCcheckBox
            // 
            this.CrCcheckBox.AutoSize = true;
            this.CrCcheckBox.Location = new System.Drawing.Point(79, 231);
            this.CrCcheckBox.Name = "CrCcheckBox";
            this.CrCcheckBox.Size = new System.Drawing.Size(96, 16);
            this.CrCcheckBox.TabIndex = 13;
            this.CrCcheckBox.Text = "自動填入CRC";
            this.CrCcheckBox.UseVisualStyleBackColor = true;
            // 
            // TextDataBtn
            // 
            this.TextDataBtn.Location = new System.Drawing.Point(181, 227);
            this.TextDataBtn.Name = "TextDataBtn";
            this.TextDataBtn.Size = new System.Drawing.Size(75, 23);
            this.TextDataBtn.TabIndex = 15;
            this.TextDataBtn.Text = "傳送";
            this.TextDataBtn.UseVisualStyleBackColor = true;
            this.TextDataBtn.Click += new System.EventHandler(this.TextDataBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(262, 227);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.Text = "清除";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GetTextBox
            // 
            this.GetTextBox.Location = new System.Drawing.Point(218, 256);
            this.GetTextBox.Multiline = true;
            this.GetTextBox.Name = "GetTextBox";
            this.GetTextBox.ReadOnly = true;
            this.GetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GetTextBox.Size = new System.Drawing.Size(193, 208);
            this.GetTextBox.TabIndex = 21;
            // 
            // PutTextBox
            // 
            this.PutTextBox.Location = new System.Drawing.Point(12, 256);
            this.PutTextBox.Multiline = true;
            this.PutTextBox.Name = "PutTextBox";
            this.PutTextBox.ReadOnly = true;
            this.PutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PutTextBox.Size = new System.Drawing.Size(193, 208);
            this.PutTextBox.TabIndex = 22;
            // 
            // DataTextComboBox
            // 
            this.DataTextComboBox.FormattingEnabled = true;
            this.DataTextComboBox.Location = new System.Drawing.Point(12, 199);
            this.DataTextComboBox.Name = "DataTextComboBox";
            this.DataTextComboBox.Size = new System.Drawing.Size(399, 20);
            this.DataTextComboBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 469);
            this.Controls.Add(this.DataTextComboBox);
            this.Controls.Add(this.PutTextBox);
            this.Controls.Add(this.GetTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.TextDataBtn);
            this.Controls.Add(this.CrCcheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "modbusTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SerialSortCheckbox;
        private System.Windows.Forms.Button SerialConnectBtn;
        private System.Windows.Forms.Button SerialCloseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TimerStopBtn;
        private System.Windows.Forms.Button TimerStartBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CrCcheckBox;
        private System.Windows.Forms.Button TextDataBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.ComboBox SpeedComboBox;
        private System.Windows.Forms.ComboBox SerialComboBox;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox GetTextBox;
        private System.Windows.Forms.TextBox PutTextBox;
        private System.Windows.Forms.ComboBox DataTextComboBox;
    }
}

