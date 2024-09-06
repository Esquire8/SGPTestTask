namespace SGPProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            label1 = new Label();
            tbxName = new TextBox();
            lblBucketVolume = new Label();
            cbxBucketVolume = new ComboBox();
            lblCycleTime = new Label();
            tbxCycleTime = new TextBox();
            lblCountWorkingDays = new Label();
            tbxNumWorkingDays = new TextBox();
            lblCoeffUseful = new Label();
            tbxCoeffUseful = new TextBox();
            label2 = new Label();
            lblWorkVolume = new Label();
            tbxWorkVolume = new TextBox();
            btnUploadResult = new Button();
            btnCalculate = new Button();
            tbxResult = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            lblCoeffRule = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(58, 114);
            lblName.Name = "lblName";
            lblName.Size = new Size(116, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Наименование";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(58, 59);
            label1.Name = "label1";
            label1.Size = new Size(241, 28);
            label1.TabIndex = 2;
            label1.Text = "Параметры экскаватора";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(211, 114);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(159, 27);
            tbxName.TabIndex = 3;
            // 
            // lblBucketVolume
            // 
            lblBucketVolume.AutoSize = true;
            lblBucketVolume.Location = new Point(58, 170);
            lblBucketVolume.Name = "lblBucketVolume";
            lblBucketVolume.Size = new Size(136, 20);
            lblBucketVolume.TabIndex = 4;
            lblBucketVolume.Text = "Объем ковша (м³)";
            // 
            // cbxBucketVolume
            // 
            cbxBucketVolume.FormattingEnabled = true;
            cbxBucketVolume.Items.AddRange(new object[] { "1", "5", "10", "20", "50" });
            cbxBucketVolume.Location = new Point(211, 167);
            cbxBucketVolume.Name = "cbxBucketVolume";
            cbxBucketVolume.Size = new Size(159, 28);
            cbxBucketVolume.TabIndex = 5;
            cbxBucketVolume.KeyPress += cbxBucketVolume_KeyPress;
            // 
            // lblCycleTime
            // 
            lblCycleTime.AutoSize = true;
            lblCycleTime.Location = new Point(58, 227);
            lblCycleTime.Name = "lblCycleTime";
            lblCycleTime.Size = new Size(138, 20);
            lblCycleTime.TabIndex = 6;
            lblCycleTime.Text = "Время цикла (сек.)";
            // 
            // tbxCycleTime
            // 
            tbxCycleTime.Location = new Point(211, 224);
            tbxCycleTime.Name = "tbxCycleTime";
            tbxCycleTime.Size = new Size(159, 27);
            tbxCycleTime.TabIndex = 7;
            tbxCycleTime.KeyPress += tbxCycleTime_KeyPress;
            // 
            // lblCountWorkingDays
            // 
            lblCountWorkingDays.AutoSize = true;
            lblCountWorkingDays.Location = new Point(58, 270);
            lblCountWorkingDays.Name = "lblCountWorkingDays";
            lblCountWorkingDays.Size = new Size(125, 40);
            lblCountWorkingDays.TabIndex = 8;
            lblCountWorkingDays.Text = "Кол-во рабочих \r\nдней в году";
            // 
            // tbxNumWorkingDays
            // 
            tbxNumWorkingDays.Location = new Point(211, 283);
            tbxNumWorkingDays.Name = "tbxNumWorkingDays";
            tbxNumWorkingDays.Size = new Size(159, 27);
            tbxNumWorkingDays.TabIndex = 9;
            tbxNumWorkingDays.KeyPress += tbxNumWorkingDays_KeyPress;
            // 
            // lblCoeffUseful
            // 
            lblCoeffUseful.AutoSize = true;
            lblCoeffUseful.Location = new Point(57, 330);
            lblCoeffUseful.Name = "lblCoeffUseful";
            lblCoeffUseful.Size = new Size(139, 40);
            lblCoeffUseful.TabIndex = 10;
            lblCoeffUseful.Text = "Коэфф. полезного \r\nиспользования";
            // 
            // tbxCoeffUseful
            // 
            tbxCoeffUseful.Location = new Point(211, 339);
            tbxCoeffUseful.Name = "tbxCoeffUseful";
            tbxCoeffUseful.Size = new Size(159, 27);
            tbxCoeffUseful.TabIndex = 11;
            tbxCoeffUseful.KeyPress += tbxCoeffUseful_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(495, 59);
            label2.Name = "label2";
            label2.Size = new Size(331, 28);
            label2.TabIndex = 12;
            label2.Text = "Расчет количества оборудования\r\n";
            // 
            // lblWorkVolume
            // 
            lblWorkVolume.AutoSize = true;
            lblWorkVolume.Location = new Point(495, 114);
            lblWorkVolume.Name = "lblWorkVolume";
            lblWorkVolume.Size = new Size(133, 20);
            lblWorkVolume.TabIndex = 13;
            lblWorkVolume.Text = "Объем работ (м³)";
            // 
            // tbxWorkVolume
            // 
            tbxWorkVolume.Location = new Point(655, 111);
            tbxWorkVolume.Name = "tbxWorkVolume";
            tbxWorkVolume.Size = new Size(159, 27);
            tbxWorkVolume.TabIndex = 14;
            tbxWorkVolume.KeyPress += tbxWorkVolume_KeyPress;
            // 
            // btnUploadResult
            // 
            btnUploadResult.Cursor = Cursors.Hand;
            btnUploadResult.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnUploadResult.Location = new Point(730, 339);
            btnUploadResult.Name = "btnUploadResult";
            btnUploadResult.Size = new Size(194, 51);
            btnUploadResult.TabIndex = 15;
            btnUploadResult.Text = "Выгрузка в docx";
            btnUploadResult.UseVisualStyleBackColor = true;
            btnUploadResult.Click += btnUploadResult_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Khaki;
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCalculate.Location = new Point(495, 339);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(194, 51);
            btnCalculate.TabIndex = 16;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // tbxResult
            // 
            tbxResult.Location = new Point(495, 183);
            tbxResult.Multiline = true;
            tbxResult.Name = "tbxResult";
            tbxResult.ReadOnly = true;
            tbxResult.Size = new Size(429, 114);
            tbxResult.TabIndex = 17;
            // 
            // lblCoeffRule
            // 
            lblCoeffRule.AutoSize = true;
            lblCoeffRule.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCoeffRule.Location = new Point(211, 369);
            lblCoeffRule.Name = "lblCoeffRule";
            lblCoeffRule.Size = new Size(128, 17);
            lblCoeffRule.TabIndex = 18;
            lblCoeffRule.Text = "*дробная часть с \",\"";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(495, 160);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(78, 20);
            lblResult.TabIndex = 19;
            lblResult.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 516);
            Controls.Add(lblResult);
            Controls.Add(lblCoeffRule);
            Controls.Add(tbxResult);
            Controls.Add(btnCalculate);
            Controls.Add(btnUploadResult);
            Controls.Add(tbxWorkVolume);
            Controls.Add(lblWorkVolume);
            Controls.Add(label2);
            Controls.Add(tbxCoeffUseful);
            Controls.Add(lblCoeffUseful);
            Controls.Add(tbxNumWorkingDays);
            Controls.Add(lblCountWorkingDays);
            Controls.Add(tbxCycleTime);
            Controls.Add(lblCycleTime);
            Controls.Add(cbxBucketVolume);
            Controls.Add(lblBucketVolume);
            Controls.Add(tbxName);
            Controls.Add(label1);
            Controls.Add(lblName);
            Name = "Form1";
            ShowIcon = false;
            Text = "Расчет количества оборудования";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label label1;
        private Label lblBucketVolume;
        private ComboBox cbxBucketVolume;
        private Label lblCycleTime;
        private TextBox tbxCycleTime;
        private Label lblCountWorkingDays;
        private TextBox tbxNumWorkingDays;
        private Label lblCoeffUseful;
        private TextBox tbxCoeffUseful;
        private Label label2;
        private Label lblWorkVolume;
        private TextBox tbxWorkVolume;
        private Button btnUploadResult;
        private Button btnCalculate;
        private TextBox tbxResult;
        private TextBox tbxName;
        private SaveFileDialog saveFileDialog1;
        private Label lblCoeffRule;
        private Label lblResult;
    }
}
