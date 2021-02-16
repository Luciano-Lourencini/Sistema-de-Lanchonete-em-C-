using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            int ham=0,bat=0,refr=0,cerva=0,doce=0,total=0;
            int hamtot,battot,refrtot,cervatot,docetot;
            
            Console.WriteLine("########################");
            Console.WriteLine("## LANCHONETE DO BOB ##");
            Console.WriteLine("########################");
            do 
            {
                Console.WriteLine("\n\nOPÇÕES:\n 1- Hambúrguer R$8,00\n 2- Batata Frita R$12,00\n 3- Refigerante R$3,00\n 4- Cerveja R$5,00\n 5- Doce R$3,00\n 6- TOTAL\n 0- SAIR");
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine("ATÉ A PRÓXIMA!");
                        break;

                    case 1: 
                        Console.WriteLine("Hambúrguer adicionado!");
                        ham++;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 2:
                        Console.WriteLine("Batata Frita adicionada!");
                        bat++;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Refrigerante adicionado!");
                        refr++;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("Cerveja adicionada!");
                        cerva++;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("Doce adicionado!");
                        doce++;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        hamtot = (ham*8);
                        battot = (bat*12);
                        refrtot = (refr*3);
                        cervatot = (cerva*5);
                        docetot = (doce*3);
                        total = (hamtot + refrtot + battot + cervatot + docetot);
                        Console.WriteLine("-------TOTAL-------");
                        Console.WriteLine("HAMBÚRGUERES: {0} -- R${1},00",ham,hamtot);
                        Console.WriteLine("BATATAS FRITAS: {0} -- R${1},00",bat,battot);
                        Console.WriteLine("REFRIGERANTES: {0} -- R${1},00",refr,refrtot);
                        Console.WriteLine("CERVEJAS: {0} -- R${1},00",cerva,cervatot);
                        Console.WriteLine("DOCES: {0} -- R${1},00",doce,docetot);
                        Console.WriteLine("\n\n-----------------------");
                        Console.WriteLine("VALOR À PAGAR: R${0}",total);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            while (op!=0);
        }
    }
}