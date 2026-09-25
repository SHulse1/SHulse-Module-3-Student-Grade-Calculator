namespace SHulse___Module_3___Forms_App
{
    public partial class frmGradeCalculator : Form
    {
        public frmGradeCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            double grade;

            if (double.TryParse(txtGrade.Text, out grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    lstGrades.Items.Add(grade);

                    lblStatus.Text = "Grade added successfully.";

                    txtGrade.Clear();
                    txtGrade.Focus();
                }
                else
                {
                    lblStatus.Text = "Enter a grade between 0 and 100.";
                }
            }
            else
            {
                lblStatus.Text = "Enter a valid number grade.";
            }
        }

        private void txtGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddGrade.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "")
            {
                lblStatus.Text = "Enter the student's name.";
                txtStudentName.Focus();
                return;
            }

            if (lstGrades.Items.Count == 0)
            {
                lblStatus.Text = "Add at least one grade.";
                txtGrade.Focus();
                return;
            }

            double finalAverage = CalculateAverage();

            string letterGrade = DetermineLetterGrade(finalAverage);

            DisplayResults(finalAverage, letterGrade);
        }

        private double CalculateAverage()
        {
            double total = 0;

            foreach (double grade in lstGrades.Items)
            {
                total = total + grade;
            }

            double average = total / lstGrades.Items.Count;

            return average;
        }

        private string DetermineLetterGrade(double average)
        {
            string letterGrade;

            if (average >= 90)
            {
                letterGrade = "A";
            }
            else if (average >= 80)
            {
                letterGrade = "B";
            }
            else if (average >= 70)
            {
                letterGrade = "C";
            }
            else if (average >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            return letterGrade;
        }

        private void DisplayResults(double average, string letterGrade)
        {
            lblStudentResult.Text = txtStudentName.Text;
            lblAverageResult.Text = average.ToString("F2");
            lblLetterGradeResult.Text = letterGrade;

            lblStatus.Text = "Grade calculated successfully.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtGrade.Clear();

            lstGrades.Items.Clear();

            lblStudentResult.Text = "------";
            lblAverageResult.Text = "------";
            lblLetterGradeResult.Text = "------";

            lblStatus.Text = "Ready";

            txtStudentName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
