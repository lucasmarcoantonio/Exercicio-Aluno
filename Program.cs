using System;

namespace Exercicio_Aluno___Fabricio
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[50];
            int qtd = 0;
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("***** MENU *****");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("1 - CADASTRAR ALUNO");
                Console.WriteLine("2 - EXIBIR ALUNOS");
                Console.WriteLine("3 - EXIBIR APROVADOS");
                Console.WriteLine("4 - EXIBIR REPROVADOS");
                Console.WriteLine("5 - EDITAR ALUNOS");
                Console.WriteLine("6 - ORDENAR POR NOTA");
                Console.WriteLine("7 - EXCLUIR ALUNOS");
                Console.WriteLine("\nEscolha uma opcao: ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Pressione qualquer tecla para sair...");
                        Console.ReadKey();
                        break;


                    case 1:
                        string NomeAluno, RA, Idade;
                        float Nota1, Nota2, media;
                        Console.WriteLine("***** CADASTRAR ALUNOS *****");
                        Console.WriteLine("Entre com o Nome: ");
                        NomeAluno = Console.ReadLine();
                        NomeAluno = NomeAluno.ToUpper();
                        Console.WriteLine("Entre com o RA: ");
                        RA = Console.ReadLine();
                        RA = RA.ToUpper();
                        Console.WriteLine("Entre com a Idade: ");
                        Idade = Console.ReadLine();
                        Console.WriteLine("Entre com a Nota da B1: ");
                        Nota1 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Entre com a Nota da B2: ");
                        Nota2 = Convert.ToSingle(Console.ReadLine());

                        media = (Nota1 + Nota2) / 2;


                        Aluno aluno = new Aluno();


                        aluno.NomeAluno = NomeAluno;
                        aluno.RA = RA;
                        aluno.Idade = Convert.ToInt32(Idade);
                        aluno.Nota1 = Nota1;
                        aluno.Nota2 = Nota2;                        
                        aluno.Media = media;



                       
                        alunos[qtd] = aluno;
                        qtd++;
                        break;

                    case 2:
                        Console.Clear();
                    
                        Console.WriteLine("***** ALUNOS CADASTRADOS *****");


                        for (int x = 0; x < qtd; x++)
                        {
                            Console.WriteLine("\n\t ID ALUNO: " + x );
                            Console.WriteLine("Aluno: {0}\tRA: {1}\tIdade: {2}\tNota B1: {3}\tNota B2: {4}\tMedia: {5}",
                                alunos[x].NomeAluno, alunos[x].RA, alunos[x].Idade, alunos[x].Nota1, alunos[x].Nota2, alunos[x].Media);
                        }
                        Console.WriteLine("Pressione uma tecla para voltar ao menu");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("***** ALUNOS APROVADOS *****");


                        for (int x = 0; x < qtd; x++)
                        {
                            
                            if (alunos[x].Media >= 5)
                            {
                                alunos[x].Status();
                            }
                        }

                        Console.WriteLine("Pressione uma tecla para voltar ao menu");
                        Console.ReadKey();
                        break;


                    case 4:
                        Console.Clear();
                        Console.WriteLine("***** ALUNOS REPROVADOS *****");

                        for (int x = 0; x < qtd; x++)
                        {
                            if (alunos[x].Media < 5)
                            {
                                alunos[x].Status();
                            }
                        }
                        Console.WriteLine("Pressione uma tecla para voltar ao menu");
                        Console.ReadKey();
                        break;

                    case 5:

                        string NomeEditar;
                        string RAEditar;
                        int IdadeEditar;
                        float Nota1Editar;
                        float Nota2Editar;
                        int localArray;

                        Console.Clear();
                        Console.WriteLine("***** EDITAR ALUNOS *****");
                        Console.WriteLine("Entre com o RA do aluno que deseja alterar: ");
                        string raPesquisar = Console.ReadLine();
                        raPesquisar = raPesquisar.ToUpper();

                        localArray = PesquisarAluno(raPesquisar);
                        Console.ReadKey();

                        //condição editar aluno s/n
                        //condição nao encontrar o aluno qtd +1 
                        if (localArray == qtd + 1)
                        {
                            Console.WriteLine("Aluno não encontrado, tente novamente...");
                            break;
                        }
                        else
                        {
                            string opcao;

                            Console.WriteLine("Editar aluno s/n ?");
                            opcao = Console.ReadLine();
                            opcao = opcao.ToUpper();

                            if ( opcao == "s" || opcao == "S") {


                                Console.WriteLine("Entre com o Nome: ");
                                NomeEditar = Console.ReadLine();
                                NomeEditar = NomeEditar.ToUpper();

                                Console.WriteLine("Entre com o RA: ");
                                RAEditar = Console.ReadLine();
                                RAEditar = RAEditar.ToUpper();

                                Console.WriteLine("Entre com a Idade: ");
                                IdadeEditar = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Entre com a Nota da B1: ");
                                Nota1Editar = float.Parse(Console.ReadLine());
                                Console.WriteLine("Entre com a Nota da B2: ");
                                Nota2Editar = float.Parse(Console.ReadLine());

                                float mediaEditar = (Nota1Editar + Nota2Editar) / 2;

                                Aluno alunoEditar = new Aluno();

                                alunoEditar.NomeAluno = NomeEditar;
                                alunoEditar.RA = RAEditar;
                                alunoEditar.Idade = Convert.ToInt32(IdadeEditar);
                                alunoEditar.Nota1 = (Nota1Editar);
                                alunoEditar.Nota2 = (Nota2Editar);
                                alunoEditar.Media = (mediaEditar);
                                alunos[localArray] = alunoEditar;


                                Console.WriteLine("aluno alterado com sucesso! Pressione qualquer tecla para voltar ao menu");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Cancelando....");
                                Console.ReadKey();
                                break;
                            }
                        }
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("***** ORDENAR ALUNOS *****");


                        for (int x = 0; x < qtd; x++)
                        {
                            ordenar();             
                                alunos[x].Status();
                           
                        }



                        Console.WriteLine("aluno removido com sucesso! Pressione qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("***** EXCLUIR ALUNOS *****");
                        Console.WriteLine("Entre com o ID do aluno que deseja excluir: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        int aux;
                        for (int x = id; x < qtd; x++)
                        {
                            aux = x + 1;
                            alunos[x] = alunos[aux];
                        }
                        qtd = qtd - 1;
                        Console.WriteLine("aluno removido com sucesso! Pressione qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Opcao invalida, pressione qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);

             int PesquisarAluno(string raEditar)
            {
                int aux = qtd +1;
                for (int x = 0; x <= qtd; x++)
                {
                    if (alunos[x] != null && raEditar.Equals(alunos[x].RA))
                    {
                        alunos[x].Status();
                        aux = x;
                    }
                }
                return (aux);
            }


             void ordenar()
            {
                Aluno AlunoAux = new Aluno();

                int x, y;              
                
                for (x = 0; x <= qtd; x++)
                {
                    if(alunos[x] != null ) 
                    { 
                        for (y = 0; y <= qtd; y++)
                        {
                            if (alunos[y] != null && alunos[x].Media > alunos[y].Media)
                            { 
                                AlunoAux = alunos[x];
                                alunos[x] = alunos[y];
                                alunos[y] = AlunoAux;
                                

                            }
                        }

                    }
                    
                }
                
            }
        }
    }
}
