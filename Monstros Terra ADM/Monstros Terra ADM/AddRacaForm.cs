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
    public partial class AddRacaForm : Form
    {
        public MTADMMenu MainForm;
        public AddRacaForm()
        {
            InitializeComponent();
            btnInserir.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nome = txtBoxNomeRaça.Text;
            string descrição = txtBoxDescriçãoRaça.Text;
            int mana = (int)upDwnManaRaça.Value;    
            int estamina = (int)upDwnEstaminaRaça.Value;  
            int força = (int)upDwnForçaRaça.Value;  
            int inteligência = (int)upDwnInteligênciaRaça.Value;
            int destreza = (int)upDwnDestrezRaça.Value;

            Raça raça = new Raça(nome, descrição, mana, estamina, força, inteligência, destreza);
            MainForm.inserirRaça(raça);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AddRacaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Dispose();
        }
    }
}
