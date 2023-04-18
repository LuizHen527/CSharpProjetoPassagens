// - metodo login	
// 	- senha = 123456;
// 	- do while (false)
// 		- Insira a senha
// 		- if (senha == senhaDigitada)
// 			- acesso permitido
// 			- true
// 		- else
// 			false

// -------------------------------------------------

// - Cadastrar Passagens

// - Method CadastrarPassagens(Nome, Origem, Destino, Data)
// 	- for(int i = 0; i < 5; i++)

// 		- Insira seu nome
// 		- Armazenar em um array [i]

// 		- Insira sua origem
// 		- Armazenar em um array [i]

// 		- Insira seu Destino
// 		- Armazenar em um array [i]

// 		- Insira sua Data
// 		- Armazenar em um array [i]

// - switch opcoes

// 	- Case '1'
// 	- Chamar Method CadastrarPassagens()
// 	- Break

// ----------------------------------------------------------------------------

// LISTAR PASSAGENS

// - Method MostrarPassagens()
// 	for(int i = 0; i < 5; i++)
// 		- Mostrar array de cada string [i]

// - switch
// 	- case '2'
// 	- Mostrar Method MostrarPassagens

static char Menu()
{
    Console.WriteLine($"");
    Console.WriteLine($@"Digite '1' para cadastrar passagens
       '2' para listar passagens
       '0' para Sair");

    return char.Parse(Console.ReadLine());
}

static bool login(int senha)
{
    int senhaValida = 123456;
    
    if (senha == senhaValida)
    {
        Console.WriteLine($"");
        Console.WriteLine($"Acesso permitido");
        Console.WriteLine($"");
        return true;
    }
    else
    {
        Console.WriteLine($"");
        Console.WriteLine($"Acesso negado");
        Console.WriteLine($"");
        return false;
    }
}

string[] nome = new string[1];
string[] origem = new string[1];
string[] destino = new string[1];
string[] dataVoo = new string[1];

static void CadastrarPassagens(string[] nome, string[] origem, string[] destino, string[] dataVoo)
{
    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine($"");
        Console.WriteLine($"Insira seu nome:");
        nome[i] = Console.ReadLine();

        Console.WriteLine($"");
        Console.WriteLine($"Insira sua origem:");
        origem[i] = Console.ReadLine();

        Console.WriteLine($"");
        Console.WriteLine($"Insira um destino");
        destino[i] = Console.ReadLine();
        
        Console.WriteLine($"");
        Console.WriteLine($"Insira a data que voce quer voar (dd/mm/aaaa):");
        dataVoo[i] = Console.ReadLine();

        Console.WriteLine($"");
        Console.WriteLine($"Passagem Cadastrada");
    }
}

static void MostrarPassagens(string[] nome, string[] origem, string[] destino, string[] dataVoo)
{
    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine($"Passagem numero {i+1}");
        
        Console.WriteLine($@"Nome: {nome[i]}");

        Console.WriteLine($@"Origem: {origem[i]}");

        Console.WriteLine($@"Destino: {destino[i]}");

        Console.WriteLine($@"Data do Voo: {dataVoo[i]}");
        
        Console.WriteLine($"");
        
    }
}


int senha;


do
{
    Console.WriteLine($"Insira a senha (ate 6 digitos):");
    senha = int.Parse(Console.ReadLine());
} while (login(senha) == false);

Console.WriteLine($"Bem vindo ao SENAI passagens aereas");

switch (Menu())
{
    case'1':
    CadastrarPassagens(nome, origem, destino, dataVoo);
    Menu();
    break;

    case '2':
    MostrarPassagens(nome, origem, destino, dataVoo);
    Menu();
    break;

    default:
    break;
}
