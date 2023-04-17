// - metodo login	
// 	- senha = 123456;
// 	- do while (false)
// 		- Insira a senha
// 		- if (senha == senhaDigitada)
// 			- acesso permitido
// 			- true
// 		- else
// 			false

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


int senha;


do
{
    Console.WriteLine($"Insira a senha (ate 6 digitos):");
    senha = int.Parse(Console.ReadLine());
} while (login(senha) == false);

Console.WriteLine($"Bem vindo ao SENAI passagens aereas");
Console.WriteLine($@"Digite '1' para cadastrar passagens
       '2' para listar passagens
       '0' para Sair");

Console.ReadLine();


