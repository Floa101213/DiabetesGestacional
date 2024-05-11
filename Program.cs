//Segundo a Sociedade Brasileira de Diabetes¹, a avaliação de Diabetes em grávidas é realizada através de um exame de glicemia comparado com a tabela abaixo:
Console.Clear();
 
int glicemia;
Console.WriteLine("---diabetes gestacional---");
 
Console.Write("\nglicemia em mg/dL: ");
 
glicemia = Convert.ToInt32(Console.ReadLine());
 
if (glicemia < 92)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n--reavaliar entre 24 e 28 semanas com TTOG 75g de glicose--");
    Console.ResetColor();
}
 
else if (glicemia >= 92 && glicemia < 126)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\nCompatível com Diabetes Gestacional");
    Console.ResetColor();
}
 
else
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\nDiabetes Mellitus na Gravidez");
    Console.ResetColor();
}