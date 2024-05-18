 double AguasContinentais = 10;
 double AguasMarinhas = 15;
 
 decimal MultaBase = 1000;
 decimal MultaExcesso = 20;
Console.Clear();
Console.WriteLine("--- Pesca Amadora ---\n");
 
Console.Write("Peso (em kg)...: ");
double pesoPescado = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Águas [c]ontinentais ou [m]arinhas? ");
string localPesca = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();
 
Console.WriteLine();
 
if (localPesca != "C" && localPesca != "M")
{
    Console.WriteLine("Local não reconhecido.");
    return;
}
 
if (localPesca == "C" && pesoPescado <= AguasContinentais ||
    localPesca == "M" && pesoPescado <= AguasMarinhas)
{
    Console.WriteLine("Pescaria dentro dos limites legais.");
    return;
}
 
double pesoPermitido = localPesca == "C" ? AguasContinentais : AguasMarinhas;
double pesoExcesso = pesoPescado - pesoPermitido;
decimal multa = MultaBase + MultaExcesso * Convert.ToDecimal(pesoExcesso);
 
Console.WriteLine($"Pescaria excede os limites legais em {pesoExcesso}kg.\nSujeito a multa de {multa:C}.");