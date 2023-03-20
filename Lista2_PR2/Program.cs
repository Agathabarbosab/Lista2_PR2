//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista2_PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            float mdumaduzia, maisdumaduzia, nl;

//            Console.WriteLine("Digite a quantidade de laranjas que serão compradas:");
//            nl = float.Parse(Console.ReadLine());

//            if (nl < 12)
//            {
//                mdumaduzia = nl * 0.35f;
//                Console.WriteLine("O valor a ser pago pagar é:" + mdumaduzia);
//            }

//            else
//            {
//                maisdumaduzia = nl * 0.28f;
//                Console.WriteLine("O Valor total a ser pago é:" + maisdumaduzia);
//            }
//        }
//    }
//}



//Exercicio2

//using System;

//float anodenascimento, idadeqtera;

//Console.WriteLine("Digite o seu ano de nascimento:");
//anodenascimento = float.Parse(Console.ReadLine());

//idadeqtera = anodenascimento - 2026;

//if (idadeqtera >= 16)
//{
//    Console.WriteLine("Você tera idade para votar na proxima eleição");

//}
//else
//{ 
//Console.WriteLine("Você não tera idade para votar");
//}







//Exercicio3

//using System;

//float med1, med2, med3;

//Console.WriteLine("Digite o valor do primeiro lado do triangulo:");
//med1 = float.Parse(Console.ReadLine());

//Console.WriteLine("Digite o valor do segundo lado do triangulo:");
//med2 = float.Parse(Console.ReadLine());

//Console.WriteLine("Digite o valor do terceiro lado do triangulo:");
//med3 = float.Parse(Console.ReadLine());


//if (med1 == med2 && == med3==med2 && med1==med3);
//{
// Console.WriteLine("O triangulo é equilatero:");
//}

//else if (med1!=med2 && med2!=med3 && med1!= med3);
//{
//    Console.WriteLine("O triangulo é escaleno");   
//}

//else
//{
//    Console.WriteLine("O triangulo é isósceles");
//}




//Exercicio4

//using System;

//float a, b, c, resp1;
//double raiz, x1, x2;

//Console.WriteLine("Digite um valor para a:");
//a = float.Parse(Console.ReadLine());

//Console.WriteLine("Digite um valor para b:");
//b = float.Parse(Console.ReadLine());

//Console.WriteLine("Digite um valor para c:");
//c = float.Parse(Console.ReadLine());

//resp1 = (b * b) - 4 * a * c;

//raiz = Math.Sqrt(resp1);

//x1 = (-b + raiz) / 2f * a;
//x2 = (-b - raiz) / 2f * a;

//Console.WriteLine("o valor de x1 é:" + x1);
//Console.WriteLine("o valor de x2 é:" + x2);





//Exercicio5

//using System;

//float nu;

//Console.WriteLine("Digite um valor:");
//nu = float.Parse(Console.ReadLine());

//if (nu % 3f == 0 && nu % 5f == 0)
//{
//    Console.WriteLine("O valor é divisivel por 3 e 5");
//}

//else if (nu % 3f == 0 )
//{
//    Console.WriteLine("O valor é divisivel apenas por 3");
//}


//else if (nu % 5f == 0 )
//{
//    Console.WriteLine("O valor é divisivel apenas por 5");
//}

//else
//{
//    Console.WriteLine("O valor não é divisivel por 3 e nem por 5");
//}




//Exercicio 6

//using System;
//using System.Security.AccessControl;

//float angulo1, angulo2, angulo3, modelot;

//Console.WriteLine("Digite o valor do primeiro ângulo:");
//angulo1 = float.Parse(Console.ReadLine());

//Console.WriteLine("Digite o valor do segundo ângulo:");
//angulo2 = float.Parse(Console.ReadLine());

//Console.WriteLine("Digite o valor do terceiro ângulo:");
//angulo3 = float.Parse(Console.ReadLine());

//if (angulo1 == 90° | angulo2 == 90° | angulo3 | 90°)

//    Console.WriteLine("o triângulo é um triângulo retângulo");

//else if (angulo1 > 90° && angulo2 > 90° && angulo3 > 90°)

//    Console.WriteLine(" O triângulo é obtusangulo");

//else 
//    Console.WriteLine("O triângulo é acutângolo");





//Exercicio7

//using System;

//float n1, n2, n3;

//Console.WriteLine("digite o primeiro valor:");
//n1 = float.Parse(Console.ReadLine());

//Console.WriteLine("digite o segundo valor:");
//n2 = float.Parse(Console.ReadLine());

//Console.WriteLine("digite o terceiro valor:");
//n3 = float.Parse(Console.ReadLine());






//Exercicio8

//using System;

//float ano, resto;

//Console.WriteLine("Digite o ano:");

//resto = ano % 4;

//if (resto == 0)
//    Console.WriteLine("o ano é bessexto");

//else
//    Console.WriteLine("O ano não é bissexto");














