namespace exRobozinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor maximo de X e Y(com espaço entre eles): ");
            string area = Console.ReadLine();

            string[] areaV = area.Split();
            int x = int.Parse(areaV[0]);
            int y = int.Parse(areaV[1]);
            string[,] array = new string[x,y];

            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine("Digite a posição de X, Y e direção onde esta apontado o robo 1(com espaço entre eles): ");
                string posicaoRobo = Console.ReadLine();

                string[] posicaoRoboV = posicaoRobo.Split();
                int xRobo = int.Parse(posicaoRoboV[0]);
                int yRobo = int.Parse(posicaoRoboV[1]);
                char faceI = char.Parse(posicaoRoboV[2]);

                Console.WriteLine("Digite o movimento q ele irá fazer(E, D, M): ");
                string movimento = Console.ReadLine();
                char[] movimentoV = movimento.ToCharArray();

                for (int i = 0; i < movimentoV.Length; i++)
                {
                    switch (movimentoV[i])
                    {
                        case 'E':
                            switch (faceI)
                            {
                                case 'N':
                                    faceI = 'O';
                                    break;

                                case 'S':
                                    faceI = 'L';
                                    break;

                                case 'L':
                                    faceI = 'N';
                                    break;

                                case 'O':
                                    faceI = 'S';
                                    break;
                            }
                            break;
                        case 'D':
                            switch (faceI)
                            {
                                case 'N':
                                    faceI = 'L';
                                    break;

                                case 'S':
                                    faceI = 'O';
                                    break;

                                case 'L':
                                    faceI = 'S';
                                    break;

                                case 'O':
                                    faceI = 'N';
                                    break;
                            }
                            break;
                        case 'M':
                            switch (faceI)
                            {
                                case 'N':
                                    if (yRobo == y)
                                    {
                                        Console.WriteLine("Limite atingido");
                                    }
                                    else
                                    {
                                        yRobo++;
                                    }
                                    break;

                                case 'S':
                                    if (y == 0)
                                        Console.WriteLine("Limite atingido");
                                    else
                                        yRobo--;
                                    break;

                                case 'O':
                                    if (x == 0)
                                    {
                                        Console.WriteLine("Limite atingido");
                                    }
                                    else
                                    {
                                        xRobo--;
                                    }
                                    break;

                                case 'L':
                                    if (xRobo == x)
                                    {
                                        Console.WriteLine("Limite atingido");
                                    }
                                    else
                                    {
                                        xRobo++;
                                    }
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Direção nao identificada");
                            break;
                    }
                }
                Console.WriteLine(xRobo + " " + yRobo + " " + faceI);
            }
         }
    }
}