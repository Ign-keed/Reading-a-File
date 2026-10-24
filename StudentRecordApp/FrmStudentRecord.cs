using System;
using System.IO;
using System.Windows.Forms;

namespace StudentRecordApp
{
    public partial class FrmStudentRecord : Form
    {
        private Form frmRegistration;
        string path;

        public FrmStudentRecord(Form registrationForm)
        {
            InitializeComponent();
            frmRegistration = registrationForm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStudentRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmRegistration != null && !frmRegistration.IsDisposed)
            {
                frmRegistration.Show();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvShowText.Items.Clear();
        }

        private void DisplayToList()
        {
            Directory.CreateDirectory(FrmRegistration.RecordsFolder);

            openFileDialog1.InitialDirectory = FrmRegistration.RecordsFolder;
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            path = openFileDialog1.FileName;

            lvShowText.Items.Clear();

            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }
            }
        }
    }
}
