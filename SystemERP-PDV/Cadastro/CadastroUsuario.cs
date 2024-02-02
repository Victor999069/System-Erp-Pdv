using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemERP_PDV.Home;

namespace SystemERP_PDV
{
    public partial class Cadastro_Usuario : Form
    {
        public Cadastro_Usuario()
        {
            InitializeComponent();
        }

        #region Rotina limpeza de campos
        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txb_Bairro_Usuario.Clear();
            Txb_Cidade_Usuario.Clear();
            Txb_Email_Usuario.Clear();
            Txb_Nome_Usuario.Clear();
            Txb_NumCasa_Usuario.Clear();
            Txb_Rua_Usuario.Clear();
            Txb_Uf_Usuario.Clear();
            Cbx_Cargo_Usuario.SelectedIndex = -1;
            Cbx_EstaCivil_Usuario.SelectedIndex = -1;
            Cbx_Sexo_Usuario.SelectedIndex = -1;
            Cbx_TipoPessoa_Usuario.SelectedIndex = -1;
            Mtb_Cep_Usuario.Clear();
            Mtb_Cpf_Usuario.Clear();
            Mtb_Tel_Usuario.Clear();
        }
        #endregion

        #region
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeGeral viajar = new HomeGeral();

            viajar.Show();

            this.Hide();
        }
        #endregion
    }
}
