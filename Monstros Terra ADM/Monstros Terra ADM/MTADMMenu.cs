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
    public partial class MTADMMenu : Form 
    {

        public MTADMMenu FormPrincipal;
        

        public MTADMMenu()

        {
            InitializeComponent();
        }

        private void btnAddPersonagem_Click(object sender, EventArgs e)
        {
            AddPersonagemForm addPersonagem = new AddPersonagemForm();

            string[] armas = new string[lbArmas.Items.Count];
            for (int indexArmas = 0; indexArmas < lbArmas.Items.Count; indexArmas++)
            {
                armas[indexArmas] = lbArmas.Items[indexArmas].ToString();
            }
            string[] raças = new string[lbRaças.Items.Count];
            for (int indexRaças = 0; indexRaças < lbRaças.Items.Count; indexRaças++)
            {
                raças[indexRaças] = lbRaças.Items[indexRaças].ToString();
            }

            addPersonagem.carregarItens(raças, armas);

            addPersonagem.MainForm = this;
            addPersonagem.Show();
        }

        private void btnAddRaca_Click(object sender, EventArgs e)
        {
            AddRacaForm addRaca = new AddRacaForm();
            addRaca.MainForm = this;
            addRaca.Show();
        }

        private void btnAddArma_Click(object sender, EventArgs e)
        {
            AddArmaForm addArma = new AddArmaForm();
            addArma.MainForm = this;
            addArma.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            removeItem(lbPersonagens);
            removeItem(lbRaças);
            removeItem(lbArmas);
        }
        public void inserirPersonagem (string personagem)
        {
            lbPersonagens.Items.Add(personagem);
        }
        public void inserirRaça(string raça)
        {
            lbRaças.Items.Add(raça);
        }
        public void inserirArma(string arma)
        {
            lbArmas.Items.Add(arma);
        }
        //Remover o item selecionado
        private void removeItem(ListBox listBox)
        {
            if (listBox.SelectedIndices.Count > 0)
            {
                if (listBox.Items.Count > 0)
                {
                    listBox.Items.Remove(listBox.Items[listBox.SelectedIndex]);
                }
            }
        }
        
    }
}
