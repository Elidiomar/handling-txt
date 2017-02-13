using System;
using System.Windows.Forms;

namespace Gafanhoto
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnComer_Click(object sender, EventArgs e)
        {
            if (txtOpen.Text != "")
            {

                // EXECUTA O METODO "comerFolhas" E OBTEM O TOTAL DE FOLHAS COMIDAS
                int total = new Gafanhoto().comerFolhas(txtOpen.Text);

                // GERA MENSAGEM DE SUCESSO
                MessageBox.Show("O gafanhoto comeu " + total + " folhas com sucesso!");

                // FINALISA O PROGRAMA
                this.Close();

            }
            else
            {
                MessageBox.Show("ARQUIVO NÃO SELECIONADO!");
            }
           
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Arquivo de Texto (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Title = lblInfo.Text;
            DialogResult = openFileDialog.ShowDialog();
            txtOpen.Text = openFileDialog.FileName;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
