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
    public partial class AddPersonagemForm : Form
    { 
        public MTADMMenu MainForm;

        public AddPersonagemForm()
        {
            InitializeComponent();
            btnInserir.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nome = txtBoxNomePersonagem.Text;
            int vida = (int)upDwnVidaPersonagem.Value;
            int mana = (int)upDwnManaPersonagem.Value;
            int estamina = (int)upDwnEstaminaPersonagem.Value;
            int moral = (int)upDwnMoralPersonagem.Value;
            int força = (int)upDwnForçaPersonagem.Value;
            int inteligência = (int)upDwnInteligênciaPersonagem.Value;
            int destreza = (int)upDwnDestrezPersonagem.Value;
            string género;
            if (radBtnMasculino.Checked)
            {
                género = "Masculino";
            }
            else
            {
                género = "Feminino";
            }

            Raça raça;//= cBoxRaçaPersonagem.Text;
            Arma arma1;//= cBoxArma1Personagem.Text;
            Arma arma2;//= cBoxArma2Personagem.Text;

            if (!(txtBoxNomePersonagem.Text.Length > 0) || txtBoxNomePersonagem.Text == null)
            {
                MessageBox.Show("Preencha o campo Nome");
            }
            Personagem personagem = new Personagem(nome, mana, estamina, moral, força, inteligência,
                destreza, género);
            MainForm.inserirPersonagem(personagem);
        }

        private void AddPersonagemForm_Load(object sender, EventArgs e)
        {
            
        }

        public void carregarItens(string[] raças, string[] armas)
        {
            cBoxRaçaPersonagem.Items.AddRange(raças);
            cBoxArma1Personagem.Items.AddRange(armas);
            cBoxArma2Personagem.Items.AddRange(armas);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AddPersonagemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Dispose();
        }
    }
}
