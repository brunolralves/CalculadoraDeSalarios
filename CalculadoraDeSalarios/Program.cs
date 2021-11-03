
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
    int offense = int.Parse(Console.ReadLine());
    Console.Write("Deffense:");
    int deffense = int.Parse(Console.ReadLine());
    Console.Write("BodyBalance:");
    int bodyBalance = int.Parse(Console.ReadLine());
    Console.Write("Stamina:");
    int stamina = int.Parse(Console.ReadLine());
    Console.Write("Speed:");
    int speed = int.Parse(Console.ReadLine());
    Console.Write("Acceleration:");
    int acceleration = int.Parse(Console.ReadLine());
    Console.Write("Pass:");
    int pass = int.Parse(Console.ReadLine());
    Console.Write("Shoot Power:");
    int shootPower = int.Parse(Console.ReadLine());
    Console.Write("Shoot Acc.:");
    int shootAcc = int.Parse(Console.ReadLine());
    Console.Write("Jump:");
    int jump = int.Parse(Console.ReadLine());
    Console.Write("Head:");
    int head = int.Parse(Console.ReadLine());
    Console.Write("Technique:");
    int technique = int.Parse(Console.ReadLine());
    Console.Write("Dribble:");
    int dribble = int.Parse(Console.ReadLine());
    Console.Write("Curve:");
    int curve = int.Parse(Console.ReadLine());
    Console.Write("Aggresive:");
    int aggresive = int.Parse(Console.ReadLine());
    Console.Write("Response:");
    int response = int.Parse(Console.ReadLine());
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
        Console.WriteLine("Agora preciso saber a qual classe pertence o jogador - " +nome);
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

    } while (classNumber == 0);

    Player newPlayer = new(nome,offense,deffense,bodyBalance,stamina,speed,acceleration,pass,shootPower,shootAcc,jump,head,technique,dribble,curve, aggresive, response);


    newPlayer.CalcSalary(classNumber);




    bool verifyCondition = false;
    do
    {
        Console.WriteLine("Deseja inserir mais algum jogador? S/N");
        option = Console.ReadLine().ToUpper();
        if (option == "N")
        {
            keep = false;
            verifyCondition = false;
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

    Console.WriteLine(newPlayer);

  
}






