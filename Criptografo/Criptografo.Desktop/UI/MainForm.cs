using Criptografo.ClassLibrary;
using Criptografo.ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografo.Desktop.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboTypeCrypt();
                ClearScreen();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error.Message}"
                    , Program.Name
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void CryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string response = IntegrationCryptography.GetCryptography((TypeComboBox.SelectedItem as Cryptography).TypeCryptography, CryptTextBox.Text, KeyTextBox.Text);

                if (!string.IsNullOrEmpty(response))
                    DescryotTextBox.Text = response;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error.Message}"
                    , Program.Name
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void DescryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string response = IntegrationCryptography.GetDescryptography((TypeComboBox.SelectedItem as Cryptography).TypeCryptography, DescryotTextBox.Text, KeyTextBox.Text);

                if (!string.IsNullOrEmpty(response))
                    CryptTextBox.Text = response;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error.Message}"
                    , Program.Name
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void CryptTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                QuantityCryptLabel.Text = $"Caractéres: {CryptTextBox.Text?.Length}";
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error.Message}"
                    , Program.Name
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                QuantityKeyLabel.Text = $"Caractéres: {KeyTextBox.Text?.Length}";
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error.Message}"
                    , Program.Name
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void DescryotTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                QuantityDescryptLabel.Text = $"Caractéres: {DescryotTextBox.Text?.Length}";
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error.Message}"
                    , Program.Name
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Private Methods

        private void ClearScreen()
        {
            try
            {
                KeyTextBox.Text = string.Empty;
                DescryotTextBox.Text = string.Empty;
                CryptTextBox.Text = string.Empty;
                CryptTextBox.Focus();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void LoadComboTypeCrypt()
        {
            try
            {
                TypeComboBox.DisplayMember = "Name";
                TypeComboBox.ValueMember = "TypeCryptography";
                TypeComboBox.DataSource = IntegrationCryptography.GetCryptographies();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        private void GenerateRSAKeyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IntegrationCryptography.MakeRSAKeys)
                    MessageBox.Show($"Novas chaves geradas com sucesso em .\\crypt"
                        , Program.Name
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error.Message}"
                    , Program.Name
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void GenerateAESKeyButton_Click(object sender, EventArgs e)
        {
            try
            {
                KeyTextBox.Text = IntegrationCryptography.GenerateAESKey();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error.Message}"
                    , Program.Name
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void GenerateDESKeyButton_Click(object sender, EventArgs e)
        {
            try
            {
                KeyTextBox.Text = IntegrationCryptography.GenerateDESKey();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error.Message}"
                    , Program.Name
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cript = (((ComboBox)sender).SelectedItem as Cryptography);

                KeyTextBox.Enabled = cript.HasKey;

                if (!cript.HasKey)
                    KeyTextBox.Text = string.Empty;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error.Message}"
                    , Program.Name
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }
    }
}
