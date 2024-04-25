using System.Text;

namespace LogSearch
{
    public partial class frmSearchLog : Form
    {
        public frmSearchLog()
        {
            InitializeComponent();
        }

        public void ChooseFolder()
        {
            if (fbdDirectory.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbdDirectory.SelectedPath;
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = String.Empty;
            string[]? files = null;
            try
            {
                files = Directory.GetFiles(txtPath.Text);
                searchString = txtString.Text;

                foreach (string arq in files)
                {
                    GetStringToFile(arq, searchString);
                }
                btnExport.Enabled = true;
                btnClear.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($" {ex.Message} , {ex.StackTrace}");
            }
        }

        public void GetStringToFile(string path, string search)
        {
            String line = String.Empty;
            StreamReader? sr = null;
            int count = 0;
            try
            {
                sr = new StreamReader(path);
                line = sr.ReadLine();

                count++;
                rhTxt.Text += $"{path} \n";
                while (line != null)
                {
                    if (line.Contains(search))
                    {
                        rhTxt.Text += $"{count} {line} \n";
                    }

                    line = sr.ReadLine();
                    count++;
                }
                rhTxt.Text += "\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show($" {ex.Message} , {ex.StackTrace}");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rhTxt.Text = "";
            txtPath.Text = "";
            txtString.Text = "";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("C:\\search\\Test1.txt", true);
                streamWriter.Write(rhTxt.Text);
                streamWriter.Close();
                MessageBox.Show("Exportado com sucesso! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error {ex.Message} {ex.StackTrace}");
            }
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtString.Text))
            {
                btnSearch.Enabled = true;
            } 
            else
            {
                btnSearch.Enabled = false;
            }
        }
    }
}
