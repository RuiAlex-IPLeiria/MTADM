using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstros_Terra_ADM
{
    public class Personagem
    {
        //Variáveis
        private string nomeCompleto;    //String que represente ao nome completo da personagem,obrigatório para a criação da personagem
        private int vida;               //Valor inteiro, nunca negativo
        private int moral;              //Valor inteiro, aceita valores negativos
        private string género;          //M - Masculino ou F - Feminino
        private Raça raça;              //Raça a que esta personagem pertence
        private Arma armaPrincipal;     //Arma que esta personagem tem na mão dominante (principal)
        private Arma armaSecundária;    //Arma detida na mão secundária (ex.: escudo)
        //------- O MESMO QUE NA RAÇA
        private int mana;           //Valor inteiro, nunca negativo
        private int estamina;       //Valor inteiro, nunca negativo
        private int força;          //Valor inteiro, mínimo 10
        private int inteligência;   //Valor inteiro, mínimo 25
        private int destreza;       //Valor inteiro, mínimo 10

        //Propriedades {get;set;}
        public string NomeCompleto
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                if (!(value.Length > 0) || value != " " || value != null)
                {
                    nomeCompleto = value;
                }
                else
                {
                    Console.WriteLine("Erro no nome da Personagem");
                }
            }
        }
        public int Vida
        {
            get
            {
                return vida;
            }
            set
            {
                if (value < 0)
                {
                    // Valor definido para 0 se o valor inserido for negativo
                    Console.WriteLine("Erro: Vida - Valor negativo, " + value);
                    vida = 0;
                }
                else
                {
                    vida = value;
                }
            }
        }
        public int Moral
        {
            get
            {
                return moral;
            }
            set
            {
                moral = value;
            }
        }
        public string Género
        {
            get
            {
                return género;
            }
            set
            {
                if (value.Equals("Masculino") || value.Equals("Feminino"))
                {
                    género = value;
                }
                else
                {
                    Console.WriteLine("Género da personagem não definido");
                    género = "Sem género";
                }
            }
        }
        public Raça Raça
        {
            get { return raça; }
            set { raça = value; }
        }
        public Arma ArmaPrincipal
        {
            get { return armaPrincipal; }
            set { armaPrincipal = value; }
        }

        public Arma ArmaSecundária
        {
            get { return armaSecundária; }
            set { armaSecundária = value; }
        }
        //------ O MESMO QUE NA RAÇA
        public int Mana
        {
            get { return mana; }
            set
            {
                if (value < 0)
                {
                    // Valor definido para 0 se o valor inserido for negativo
                    Console.WriteLine("Erro: Mana - Valor negativo, " + value);
                    mana = 0;
                }
                else
                {
                    mana = value;
                }
            }
        }

        public int Estamina
        {
            get { return estamina; }
            set
            {
                if (value < 0)
                {
                    // Valor definido para 0 se o valor inserido for negativo
                    Console.WriteLine("Erro: Estamina - Valor negativo, " + value);
                    estamina = 0;
                }
                else
                {
                    estamina = value;
                }
            }
        }

        public int Força
        {
            get { return força; }
            set
            {
                if (value < 10)
                {
                    // Valor definido para 10 se o valor inserido for menor do que 10
                    Console.WriteLine("Erro: Força - Valor inferior a 10, " + value);
                    força = 10;
                }
                else
                {
                    força = value;
                }
            }
        }

        public int Inteligência
        {
            get { return inteligência; }
            set
            {
                if (value < 25)
                {
                    // Valor definido para 10 se o valor inserido for menor do que 25
                    Console.WriteLine("Erro: Inteligência - Valor inferior a 25, " + value);
                    inteligência = 25;
                }
                else
                {
                    inteligência = value;
                }
            }
        }

        public int Destreza
        {
            get { return destreza; }
            set
            {
                if (value < 10)
                {
                    // Valor definido para 10 se o valor inserido for negativo
                    Console.WriteLine("Erro: Destreza - Valor inferior a 10, " + value);
                    destreza = 10;
                }
                else
                {
                    destreza = value;
                }
            }
        }

        //Construtores
        public Personagem(string nome, int mana, int estamina, int moral, int força, int inteligência,
            int destreza, string género, Raça raça, Arma armaPrincipal, Arma armaSecundária)
        {
            NomeCompleto = nome;
            Vida = vida;
            Moral = moral;
            Género = género;
            ArmaPrincipal = armaPrincipal;
            ArmaSecundária = armaSecundária;
            //--- O MESMO QUE NA RAÇA
            Mana = mana;
            Estamina = estamina;
            Força = força;
            Inteligência = inteligência;
            Destreza = destreza;
        }

        public Personagem(string nome, int mana, int estamina, int moral, int força, int inteligência,
            int destreza, string género):this (nome,mana,estamina,moral,força,inteligência,destreza,género,null,null,null)
        {
        }
        //Metodos
        public override string ToString()
        {
            return NomeCompleto;
        }
    }
}
