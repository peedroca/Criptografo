using Criptografo.ClassLibrary;
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
                string response = IntegrationCryptography.GetCryptography((eTypeCryptography)TypeComboBox.SelectedIndex, CryptTextBox.Text, KeyTextBox.Text);

                if(!string.IsNullOrEmpty(response))
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
                string response = IntegrationCryptography.GetDescryptography((eTypeCryptography)TypeComboBox.SelectedIndex, DescryotTextBox.Text, KeyTextBox.Text);

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

        private void TypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ClearScreen();
                var comboBox = ((ComboBox)sender);

                switch ((eTypeCryptography)comboBox.SelectedIndex)
                {
                    case eTypeCryptography.DES:
                        MessageBox.Show("Você está utilizando o algoritmo DESCrypt. Informe uma chave de 8 caractéres."
                            , Program.Name
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        break;
                    case eTypeCryptography.AES:
                        MessageBox.Show("Você está utilizando o algoritmo AESCrypt. Informe uma chave de 16 caractéres."
                            , Program.Name
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        break;
                    case eTypeCryptography.SHA256:
                        MessageBox.Show("Você está utilizando o algoritmo SHA256. Não é necessário utilizar uma chave."
                            , Program.Name
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);

                        KeyTextBox.Enabled = false;
                        break;
                    case eTypeCryptography.MD5:
                        MessageBox.Show("Você está utilizando o algoritmo MD5Crypt. Não é necessário utilizar uma chave."
                            , Program.Name
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);

                        KeyTextBox.Enabled = false;
                        break;
                }
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
                KeyTextBox.Enabled = true;

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
                TypeComboBox.DisplayMember = "Description";
                TypeComboBox.ValueMember = "Value";
                TypeComboBox.DataSource = Enum.GetValues(typeof(eTypeCryptography))
                    .Cast<Enum>()
                    .Select(value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    })
                    .ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}
