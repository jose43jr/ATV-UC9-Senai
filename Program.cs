using plantaoUC9.Classes;

 

string? opcao;

 

do

{

    Console.Clear();

 

    Console.WriteLine(@"

    1 - Cadastrar PJ

    2 - Listar Pj

    0 - Sair    

    ");

 

    opcao = Console.ReadLine();

 

    PessoaJuridica metodosPj = new PessoaJuridica();

 

    switch (opcao)

    {

        case "0":

            break;

        case "1":

            PessoaJuridica pj = new PessoaJuridica();

 

            Console.WriteLine("Digite o nome da PJ: ");

            pj.Nome = Console.ReadLine();

 

            Console.WriteLine("Informe o rendimento: ");

            pj.Rendimento = float.Parse(Console.ReadLine());

 

            Console.WriteLine("Informe o CNPJ: ");

            pj.Cnpj = Console.ReadLine();

 

            metodosPj.Inserir(pj);

 

            Console.WriteLine("Cadastro realizado com sucesso!");

            Console.WriteLine("Pressione a tecla ENTER para continuar");

            Console.ReadLine();

            break;

        case "2":

            Console.WriteLine("Digite o nome do arquivo que deseja ler: ");

            string nomeArquivo = Console.ReadLine();

 

            PessoaJuridica pessoaJuridica = metodosPj.Ler(nomeArquivo);

 

            Console.WriteLine(@$"

            Nome: {pessoaJuridica.Nome}

            Rendimento: {pessoaJuridica.Rendimento}

            CNPJ: {pessoaJuridica.Cnpj}

            ");

            Console.ReadLine();

            break;

        default:

            Console.WriteLine("Opção Inválida!");

            Console.WriteLine("Pressione a tecla ENTER para continuar");

            Console.ReadLine();

            break;

    }

 

} while (opcao != "0");