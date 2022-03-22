namespace CalculadoraDeSalarios.Classes
{
    internal class Player
    {
        public String Nome { get; set; }
        public int Offense { get; set; }
        public int Deffense { get; set; }
        public int BodyBalance { get; set; }
        public int Stamina { get; set; }
        public int Speed { get; set; }
        public int Acceleration { get; set; }
        public int Pass { get; set; }
        public int ShootPower { get; set; }
        public int ShootAcc { get; set; }
        public int Jump { get; set; }
        public int Head { get; set; }
        public int Technique { get; set; }
        public int Dribble { get; set; }
        public int Curve { get; set; }
        public int Aggresive { get; set; }
        public int Response { get; set; }
        public Double PlayerSalary { get; set; }
        public String PlayerClass { get; set; }





        public Player()
        {

        }

        public Player(string nome, int offense, int deffense, int bodyBalance, int stamina, int speed, int acceleration, int pass, int shootPower, int shootAcc, int jump, int head, int technique, int dribble, int curve, int aggresive, int response)
        {
            
            Nome = nome;
            Offense = offense;
            Deffense = deffense;
            BodyBalance = bodyBalance;
            Stamina = stamina;
            Speed = speed;
            Acceleration = acceleration;
            Pass = pass;
            ShootPower = shootPower;
            ShootAcc = shootAcc;
            Jump = jump;
            Head = head;
            Technique = technique;
            Dribble = dribble;
            Curve = curve;
            Aggresive = aggresive;
            Response = response;
        }


        private int CalcKey()
        {
            int key;

            key = (Offense
                  + Deffense
                  + BodyBalance
                  + Stamina
                  + Speed
                  + Acceleration
                  + Pass
                  + ShootPower
                  + ShootAcc
                  + Jump
                  + Head
                  + Technique
                  + Dribble
                  + Curve
                  + Aggresive
                  + Response);

            return key;
        }

        int key;
        public void CalcSalary(int playerClass)
        {
            double salary;
            double tax = 0;
            key = CalcKey();

            switch (playerClass)
            {
                //Lendas = 2
                case 1:
                    tax = 2;
                    PlayerClass = "Lendas";
                    break;
                //Euro = 1.5
                case 2:
                    tax = 1.5;
                    PlayerClass = "Euro";
                    break;
                //Fora do eixo = 1.5
                case 3:
                    tax = 1.5;
                    PlayerClass = "Fora do eixo";
                    break;
                // BR A = 1(Salario puro)
                case 4:
                    tax = 1;
                    PlayerClass = "BR A";
                    break;
                // BR B = 0.8
                case 5:
                    tax = 0.8;
                    PlayerClass = "BR B";
                    break;
                // BR C = 0.8
                case 6:
                    tax = 0.8;
                    PlayerClass = "C";
                    break;

                default:
                    break;
            }

            salary = (((key - 192) * 50) / 112) * tax;


            PlayerSalary = salary;
        }

        public static int ValidarInput()
        {
            string input = Console.ReadLine();

            if (input != "")
            {
                return Convert.ToInt16(input);
            }
            else
            {
              return 0;
            }
            
        }

        public override string ToString()
        {
            return "Salario do Jogador "
                  + Nome
                  + ": "
                  + PlayerSalary
                  + " Classe: "
                  + PlayerClass

                  ;
        }


    }
}
