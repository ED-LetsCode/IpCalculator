using IpCalculatorLibrary;
using System.Windows.Forms;

namespace IpCalculatorWinForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CalculateIP.Hide();
            SaveFile.Hide();
            UserInput.Text = "192.168.0.1/24";
        }

        private IPCalculator _ipCalculator;

        private void CalculateIP_Click(object sender, EventArgs e)
        {
            _ipCalculator = new IPCalculator(UserInput.Text);
            SaveFile.Show();

            SubnetMask.Text = _ipCalculator.SubnetMask;
            SubnetMask.TextAlign = HorizontalAlignment.Center;
            HostParts.Text = _ipCalculator.HostParts.ToString();
            HostParts.TextAlign = HorizontalAlignment.Center;
            NetworkAdress.Text = _ipCalculator.NetworkAdress;
            NetworkAdress.TextAlign = HorizontalAlignment.Center;
            BroadcastAdress.Text = _ipCalculator.BroadcastAdress;
            BroadcastAdress.TextAlign = HorizontalAlignment.Center;
            FirstHost.Text = _ipCalculator.FirstHost;
            FirstHost.TextAlign = HorizontalAlignment.Center;
            LastHost.Text = _ipCalculator.LastHost;
            LastHost.TextAlign = HorizontalAlignment.Center;

        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            if (!IPCalculator.CheckIfIpIsValid(UserInput.Text))
            {
                CalculateIP.Hide();
                SaveFile.Hide();
                UserInput.BackColor = Color.Red;
                return;
            }
            UserInput.BackColor = Color.Green;
            CalculateIP.Show();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            using SaveFileDialog safeFileDialog = new SaveFileDialog();
            safeFileDialog.Title = "Save Text Files";
            safeFileDialog.CheckPathExists = true;
            safeFileDialog.DefaultExt = "txt";
            safeFileDialog.Filter = "Text files (*.txt)|*.txt";
            safeFileDialog.FilterIndex = 1;
            safeFileDialog.RestoreDirectory = true;

            if (safeFileDialog.ShowDialog() == DialogResult.OK)
            {
                _ipCalculator.CreateAndWriteFile(safeFileDialog.FileName);
            }
        }
    }
}