using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv5Parte1e2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String sobrenome;
            String endereco;
            String bairro;
            String cidade;
            String estado;
            int qtsViagens;
            int qtsPlanejou;

            Console.WriteLine("Bem-Vindos ao Camila Turismos");
            Console.WriteLine("Aqui você encontra diversos passeios");
            Console.WriteLine("Informe seu primeiro nome ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe seu sobrenome ");
            sobrenome = Console.ReadLine();
            Console.WriteLine($"Olá, Sr(a). {nome + sobrenome}, vamos continuar o seu cadastro ");


            Console.WriteLine("---Informe seu endereço");
            endereco = Console.ReadLine();
            Console.WriteLine("---Bairro onde reside");
            bairro = Console.ReadLine();
            Console.WriteLine("---Cidade aonde mora");
            cidade = Console.ReadLine();
            Console.WriteLine("---Qual estado?");
            estado = Console.ReadLine();

            Console.WriteLine($"O Sr(a).{sobrenome} mora na cidade de {cidade}-{estado}, no endereço {endereco}, localizado no bairro {bairro}");


            Console.WriteLine("Quantas viagens foram feitas no ano passado");
            qtsViagens = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas viagens ela planejou");
            qtsPlanejou = int.Parse(Console.ReadLine());

            int viagensFeitas;
            int viagem = 10;

            Console.WriteLine($"Quantas viagens ja foram feitas? ");
            viagensFeitas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas viagens faltam para completar 10 viagens ao todo");
            Console.WriteLine($"Faltam {viagem - viagensFeitas} viagens");

            Console.WriteLine($"Media de viagens que são feitas{qtsViagens + viagensFeitas / 2}");

            Console.WriteLine("Quantos meses de intervalo entre cada viagem");
            Console.WriteLine($"O intervalo de cada viagem em meses desse ano e de: {12 / viagensFeitas}");

            Console.WriteLine($"Obrigado(a){nome + sobrenome}, o seu cadastro foi realizado com sucesso!");



            String cupom;
            Console.WriteLine("Digite seu cupom de desconto: ");
            cupom = Console.ReadLine();
            if (cupom == "Conradito10")
            {
                Console.WriteLine("Parabéns, você recebeu 10% de desconto na sua proxima viagem");
            }
            else
            {
                Console.WriteLine("Este cupom não exite");
            }

            String opn;

            Console.WriteLine("Você gostaria de receber promoções no seu e-mail?");
            Console.WriteLine("Digite Sim ou Não");
            opn = Console.ReadLine();
            if (opn == "sim")
            {
                Console.WriteLine($"Obrigado{nome} por se registrar, você receberá novos e-mails em breve.");
            }
            else
            {
                Console.WriteLine("Ok, você não receberá e-mails de promoções. ");
            }

            Console.WriteLine("Obrigado e volte sempre");




            Console.ReadKey();
        }
    }
    }
}
