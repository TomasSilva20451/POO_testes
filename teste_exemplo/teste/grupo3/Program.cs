namespace grupo3;

class Program
{
    static void Main()
    {
        Museu museu = new Museu();

        Pessoa pessoa1 = new Pessoa("João", new DateTime(1990, 5, 15), "Lisboa");
        Pessoa pessoa2 = new Pessoa("Maria", new DateTime(1985, 8, 25), "Porto");

        museu.VisitaMuseu(pessoa1, new DateTime(2023, 7, 10));
        museu.VisitaMuseu(pessoa2, new DateTime(2023, 6, 5));
        museu.VisitaMuseu(pessoa1, new DateTime(2023, 8, 20));

        if (museu.PodeVisitar(pessoa1))
        {
            Console.WriteLine($"{pessoa1.Nome} pode visitar o museu.");
        }
        else
        {
            Console.WriteLine($"{pessoa1.Nome} não pode visitar o museu este ano.");
        }

        museu.GuardarEmFicheiro("pessoas.txt");
    }
}