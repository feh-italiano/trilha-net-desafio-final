using NewTalents;

int op, val1 = 0, val2 = 0;
Calculadora calc = new Calculadora();
Menu menu = new Menu();
do
{
    Console.WriteLine(menu.MenuInicial());
    op = Convert.ToInt32(Console.ReadLine());

    while (op < 1 || op > 6)
    {
        Console.WriteLine(menu.OpcaoInvalida());
        op = Convert.ToInt32(Console.ReadLine());
    }

    if (op >= 1 && op <= 4)
    {
        Console.WriteLine("Valor 1 => ");
        val1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Valor 2 => ");
        val2 = Convert.ToInt32(Console.ReadLine());
    }

    switch (op)
    {
        case 1:
            calc.Somar(val1, val2);
            Console.WriteLine(calc.historicoCalculadora.Last() + "\n");
            break;
        case 2:
            calc.Subtrair(val1, val2);
            Console.WriteLine(calc.historicoCalculadora.Last() + "\n");
            break;
        case 3:
            calc.Multiplicar(val1, val2);
            Console.WriteLine(calc.historicoCalculadora.Last() + "\n");
            break;
        case 4:
            calc.Dividir(val1, val2);
            Console.WriteLine(calc.historicoCalculadora.Last() + "\n");
            break;
        case 5:
            List<string> historico = calc.Historico();
            foreach (var hist in historico)
                Console.WriteLine(hist);
            break;
        case 6:
            break;
    }
} while (op != 6);