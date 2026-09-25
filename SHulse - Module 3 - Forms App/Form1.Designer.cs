namespace SHulse___Module_3___Forms_App
{
    partial class frmGradeCalculator
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
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblGrade = new Label();
            txtGrade = new TextBox();
            btnAddGrade = new Button();
            lblEnteredGrades = new Label();
            lstGrades = new ListBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpResults = new GroupBox();
            lblLetterGradeResult = new Label();
            lblAverageResult = new Label();
            lblStudentResult = new Label();
            lblLetterGrade = new Label();
            lblAverageText = new Label();
            lblStudentText = new Label();
            lblStatusText = new Label();
            lblStatus = new Label();
            grpResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(27, 35);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(86, 15);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Name:";
            lblStudentName.Click += label1_Click;
            // 
            // txtStudentName
            // 
            txtStudentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentName.Location = new Point(137, 27);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(194, 23);
            txtStudentName.TabIndex = 0;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(27, 78);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(41, 15);
            lblGrade.TabIndex = 1;
            lblGrade.Text = "Grade:";
            // 
            // txtGrade
            // 
            txtGrade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGrade.Location = new Point(137, 75);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(92, 23);
            txtGrade.TabIndex = 1;
            txtGrade.KeyDown += txtGrade_KeyDown;
            // 
            // btnAddGrade
            // 
            btnAddGrade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddGrade.Location = new Point(256, 75);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(75, 23);
            btnAddGrade.TabIndex = 2;
            btnAddGrade.Text = "Add Grade";
            btnAddGrade.UseVisualStyleBackColor = true;
            btnAddGrade.Click += btnAddGrade_Click;
            // 
            // lblEnteredGrades
            // 
            lblEnteredGrades.AutoSize = true;
            lblEnteredGrades.Location = new Point(30, 126);
            lblEnteredGrades.Name = "lblEnteredGrades";
            lblEnteredGrades.Size = new Size(89, 15);
            lblEnteredGrades.TabIndex = 2;
            lblEnteredGrades.Text = "Entered Grades:";
            // 
            // lstGrades
            // 
            lstGrades.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstGrades.FormattingEnabled = true;
            lstGrades.Location = new Point(30, 165);
            lstGrades.Name = "lstGrades";
            lstGrades.Size = new Size(305, 64);
            lstGrades.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Anchor = AnchorStyles.Top;
            btnCalculate.Location = new Point(30, 252);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(105, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate Grade";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top;
            btnClear.Location = new Point(161, 252);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(68, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top;
            btnExit.Location = new Point(256, 252);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grpResults
            // 
            grpResults.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpResults.Controls.Add(lblLetterGradeResult);
            grpResults.Controls.Add(lblAverageResult);
            grpResults.Controls.Add(lblStudentResult);
            grpResults.Controls.Add(lblLetterGrade);
            grpResults.Controls.Add(lblAverageText);
            grpResults.Controls.Add(lblStudentText);
            grpResults.Location = new Point(30, 293);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(301, 127);
            grpResults.TabIndex = 3;
            grpResults.TabStop = false;
            grpResults.Text = "Results";
            // 
            // lblLetterGradeResult
            // 
            lblLetterGradeResult.AutoSize = true;
            lblLetterGradeResult.Location = new Point(131, 86);
            lblLetterGradeResult.Name = "lblLetterGradeResult";
            lblLetterGradeResult.Size = new Size(37, 15);
            lblLetterGradeResult.TabIndex = 5;
            lblLetterGradeResult.Text = "------";
            lblLetterGradeResult.Click += label1_Click_2;
            // 
            // lblAverageResult
            // 
            lblAverageResult.AutoSize = true;
            lblAverageResult.Location = new Point(131, 58);
            lblAverageResult.Name = "lblAverageResult";
            lblAverageResult.Size = new Size(37, 15);
            lblAverageResult.TabIndex = 4;
            lblAverageResult.Text = "------";
            lblAverageResult.Click += label1_Click_1;
            // 
            // lblStudentResult
            // 
            lblStudentResult.AutoSize = true;
            lblStudentResult.Location = new Point(131, 28);
            lblStudentResult.Name = "lblStudentResult";
            lblStudentResult.Size = new Size(37, 15);
            lblStudentResult.TabIndex = 3;
            lblStudentResult.Text = "------";
            // 
            // lblLetterGrade
            // 
            lblLetterGrade.AutoSize = true;
            lblLetterGrade.Location = new Point(15, 86);
            lblLetterGrade.Name = "lblLetterGrade";
            lblLetterGrade.Size = new Size(74, 15);
            lblLetterGrade.TabIndex = 2;
            lblLetterGrade.Text = "Letter Grade:";
            // 
            // lblAverageText
            // 
            lblAverageText.AutoSize = true;
            lblAverageText.Location = new Point(15, 58);
            lblAverageText.Name = "lblAverageText";
            lblAverageText.Size = new Size(81, 15);
            lblAverageText.TabIndex = 1;
            lblAverageText.Text = "Final Average:";
            // 
            // lblStudentText
            // 
            lblStudentText.AutoSize = true;
            lblStudentText.Location = new Point(15, 28);
            lblStudentText.Name = "lblStudentText";
            lblStudentText.Size = new Size(51, 15);
            lblStudentText.TabIndex = 0;
            lblStudentText.Text = "Student:";
            // 
            // lblStatusText
            // 
            lblStatusText.AutoSize = true;
            lblStatusText.Location = new Point(30, 440);
            lblStatusText.Name = "lblStatusText";
            lblStatusText.Size = new Size(42, 15);
            lblStatusText.TabIndex = 4;
            lblStatusText.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(81, 440);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Ready";
            // 
            // frmGradeCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(lblStatus);
            Controls.Add(lblStatusText);
            Controls.Add(grpResults);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lstGrades);
            Controls.Add(lblEnteredGrades);
            Controls.Add(btnAddGrade);
            Controls.Add(txtGrade);
            Controls.Add(lblGrade);
            Controls.Add(txtStudentName);
            Controls.Add(lblStudentName);
            MinimumSize = new Size(400, 550);
            Name = "frmGradeCalculator";
            Text = "Student Grade Calculator";
            Load += Form1_Load;
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private TextBox txtStudentName;
        private Label lblGrade;
        private TextBox txtGrade;
        private Button btnAddGrade;
        private Label lblEnteredGrades;
        private ListBox lstGrades;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private GroupBox grpResults;
        private Label lblStudentText;
        private Label lblAverageResult;
        private Label lblStudentResult;
        private Label lblLetterGrade;
        private Label lblAverageText;
        private Label lblLetterGradeResult;
        private Label lblStatusText;
        private Label lblStatus;
    }
}
