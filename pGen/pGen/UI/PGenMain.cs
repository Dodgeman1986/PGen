using pGen.UI;
using System;
using System.Windows.Forms;

namespace pGen
{
    public partial class PGenMain : Form
    {
        public PGenMain()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Settings frmSettings = new Settings();
                frmSettings.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Info frmInfo = new Info();
                frmInfo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
