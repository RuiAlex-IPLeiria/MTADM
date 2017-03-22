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
        public List<Arma> armas;
        public List<Raça> raças;
        public SortedList<string, Personagem> personagens;

        public MTADMMenu()

        {
            InitializeComponent();
            armas = new List<Arma>();
            raças = new List<Raça>();
            personagens = new SortedList<string,Personagem>();
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
        public void inserirPersonagem(Personagem personagem)
        {
            try
            {
                personagens.Add(personagem.NomeCompleto, personagem);
            }
            catch (Exception)
            {
                MessageBox.Show(null,"Esse nome já existe!", "Erro ao Adicionar Personagem",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            refreshDados();
        }
        public void inserirRaça(Raça raça)
        {
            raças.Add(raça);
            refreshDados();
        }

        public void inserirArma(Arma arma)
        {
            armas.Add(arma);
            refreshDados();
        }
        
        private void refreshDados()
        {
            lbArmas.Items.Clear();
            lbRaças.Items.Clear();
            lbPersonagens.Items.Clear();
            lbArmas.Items.AddRange(armas.ToArray());
            lbRaças.Items.AddRange(raças.ToArray());
            foreach (var item in personagens)
            {
                lbPersonagens.Items.Add(item.Value);
            }
            
            //for (int i = 0; i < armas.Count; i++)
            //{
                
            //}
        }

        //Remover o item selecionado
        private void removeItem(ListBox listBox)
        {
            int index;
            if (lbArmas.SelectedIndex != -1)
            {
                index = lbArmas.SelectedIndex;
                armas.RemoveAt(index);
            }
            if (listBox.SelectedIndices.Count > 0)
            {
                if (listBox.Items.Count > 0)
                {
                    listBox.Items.Remove(listBox.Items[listBox.SelectedIndex]);
                }
            }
            refreshDados();
        }

        private void btn_sair(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
