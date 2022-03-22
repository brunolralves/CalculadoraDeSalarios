
using CalculadoraDeSalarios.Classes;


List<Player> listPlayers = new List<Player>();

Boolean keep = true;
string option = " ";
while (keep)
{
    Console.WriteLine("Para calcularmos o salario iremos precisar de alguns dados!");
    Console.WriteLine("Informe o nome do jogador");
    String nome = Console.ReadLine();

    
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("Agora vamos montar a arvore de atributos para definir o salario do jogador - " + nome);
    Console.WriteLine("Cada um dos atributos de receber um valor entre 12 e 19 pontos!");
    Console.WriteLine("Vamos la!");

    
    Console.Write("Offense:");
    int offense = Player.ValidarInput();
    Console.Write("Deffense:");
    int deffense = Player.ValidarInput();
    Console.Write("BodyBalance:");
    int bodyBalance = Player.ValidarInput();
    Console.Write("Stamina:");
    int stamina = Player.ValidarInput();
    Console.Write("Speed:");
    int speed = Player.ValidarInput();
    Console.Write("Acceleration:");
    int acceleration = Player.ValidarInput();
    Console.Write("Pass:");
    int pass = Player.ValidarInput();
    Console.Write("Shoot Power:");
    int shootPower = Player.ValidarInput();
    Console.Write("Shoot Acc.:");
    int shootAcc = Player.ValidarInput();
    Console.Write("Jump:");
    int jump = Player.ValidarInput();
    Console.Write("Head:");
    int head = Player.ValidarInput();
    Console.Write("Technique:");
    int technique = Player.ValidarInput();
    Console.Write("Dribble:");
    int dribble = Player.ValidarInput();
    Console.Write("Curve:");
    int curve = Player.ValidarInput();
    Console.Write("Aggresive:");
    int aggresive = Player.ValidarInput();
    Console.Write("Response:");
    int response = Player.ValidarInput();
    Console.Clear();

    Console.WriteLine();

    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Agora preciso saber a qual classe pertence o jogador - " + nome);
    Console.WriteLine();
    Console.WriteLine("Pressione a opção equivalente a classe do jogador!");

    int classNumber;
    do
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Agora preciso saber a qual classe pertence o jogador - " + nome);
        Console.WriteLine();
        Console.WriteLine("Pressione a opção equivalente a classe do jogador!");
        Console.WriteLine();
        Console.WriteLine("1 - Lenda ");
        Console.WriteLine("2 - Euro ");
        Console.WriteLine("3 - Fora do Eixo ");
        Console.WriteLine("4 - BR - A ");
        Console.WriteLine("5 - BR - B ");
        Console.WriteLine("6 - BR - C ");

        classNumber = int.Parse(Console.ReadLine());

        if (classNumber < 1 || classNumber > 6)
        {
            Console.WriteLine("Valor inserido invalido, vamos tentar novamente!");
            classNumber = 0;
        }
        Console.Clear();

    } while (classNumber == 0);

    Player newPlayer = new(nome, offense, deffense, bodyBalance, stamina, speed, acceleration, pass, shootPower, shootAcc, jump, head, technique, dribble, curve, aggresive, response);


    newPlayer.CalcSalary(classNumber);

    listPlayers.Add(newPlayer);


    bool verifyCondition = false;
    do
    {
        Console.WriteLine("Deseja inserir mais algum jogador? S/N");
        option = Console.ReadLine().ToUpper();
        if (option == "N")
        {
            keep = false;
            verifyCondition = false;
            double orçamento = 0;
            foreach (Player player in listPlayers)
            {
                Console.WriteLine(player);
                orçamento += player.PlayerSalary;
            }
            Console.WriteLine("O orçamento da sua equipe é de :" + orçamento);
            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadKey();
        }
        else if (option == "S")
        {
            keep = true;
            verifyCondition = false;
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Valor Invalido!!");
            verifyCondition = true;
        }

    } while (verifyCondition);

   

    
    
    
}






