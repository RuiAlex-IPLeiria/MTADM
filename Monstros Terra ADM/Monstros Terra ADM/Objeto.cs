using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstros_Terra_ADM
{
    public class Objeto
    {
        private string nome;         private string descrição;

        public string Nome  //String com o nome do objeto, obrigatório
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Descricao //String com a descrição, opcional        {
            get { return descrição; }
            set { descrição = value; }
        }
        public Objeto(string nome, string descrição)
        {
            Nome = nome;
            Descricao = descrição;
        }

        public Objeto(string nome)
        {
            Nome = nome;
        }
    }
}
