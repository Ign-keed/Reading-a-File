using System;
using System.IO;
using System.Windows.Forms;

namespace StudentRecordApp
{
    public partial class FrmRegistration : Form
    {
        public static readonly string RecordsFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "StudentRecords");

        public static readonly string RecordsFile = Path.Combine(RecordsFolder, "students.txt");

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            cboProgram.Items.AddRange(new object[] {
                "BS Information Technology", "BS Computer Science",
                "BS Business Administration", "BS Hospitality Management",
                "BS Tourism Management" });
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtStudentNo.Text.Trim() == "" || txtLastName.Text.Trim() == "" ||
                txtFirstName.Text.Trim() == "" || cboProgram.SelectedIndex < 0 ||
                cboGender.SelectedIndex < 0 || txtAge.Text.Trim() == "" ||
                txtContactNo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all required fields.", "Registration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age;
            if (!int.TryParse(txtAge.Text.Trim(), out age) || age <= 0)
            {
                MessageBox.Show("Age must be a valid number.", "Registration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            Directory.CreateDirectory(RecordsFolder);

            string record =
                "Student No.: " + txtStudentNo.Text.Trim() + Environment.NewLine +
                "Full Name: " + txtLastName.Text.Trim() + ", " + txtFirstName.Text.Trim() + ", " + txtMI.Text.Trim() + Environment.NewLine +
                "Program: " + cboProgram.Text + Environment.NewLine +
                "Gender: " + cboGender.Text + Environment.NewLine +
                "Age: " + age + Environment.NewLine +
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd") + Environment.NewLine +
                "Contact No.: " + txtContactNo.Text.Trim() + Environment.NewLine +
                Environment.NewLine;

            File.WriteAllText(RecordsFile, record);

            MessageBox.Show("Successfully Registered!", "Registration",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmRecord = new FrmStudentRecord(this);
            this.Hide();
            frmRecord.Show();
        }

        private void ClearFields()
        {
            txtStudentNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMI.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
            cboProgram.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
            dtpBirthday.Value = DateTime.Now;
            txtStudentNo.Focus();
        }
    }
}