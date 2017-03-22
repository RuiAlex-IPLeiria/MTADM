using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monstros_Terra_ADM
{
    public partial class AddArmaForm : Form
    {

        public MTADMMenu MainForm;

        //public AddArmaForm ArmaForm;

        public AddArmaForm()
        {
            InitializeComponent();
            btnInserir.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nome = txtBoxNomeArma.Text;
            string descrição = txtBoxDescriçãoAtaque.Text;
            int ataque = (int)upDwnAtaqueArma.Value;
            int defesa = (int)upDwnDefesaArma.Value;
            if (nome.Length>0)
            {
                Arma arma = new Arma(nome, descrição, ataque, defesa);
                MainForm.inserirArma(arma);
                    MessageBox.Show("Arma inserida com sucesso!", "Adicionar Arma");
            }
            else
            {
                txtBoxNomeArma.BackColor = Color.DarkRed;
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AddArmaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Dispose();
        }

        private void txtBoxNomeArma_Enter(object sender, EventArgs e)
        {
            txtBoxNomeArma.BackColor = Color.White;
        }
    }
}
