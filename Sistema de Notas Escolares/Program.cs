using System;

class URI {

    static void Main(string[] args) {
        // Escolher a matéria na qual deseja ver sua média final.
        Console.WriteLine("Lingua Portuguesa (Digite 1)");
        Console.WriteLine("Matemática (Digite 2)");
        Console.WriteLine("Ciências (Digite 3)");
        Console.WriteLine("História (Digite 4)");
        Console.WriteLine("Geografia (Digite 5)");
        double notas = double.Parse(Console.ReadLine());

        // Matéria Lingua Portuguesa
        if (notas == 1) {
            Console.WriteLine("Informe a primeira nota de 0 a 10: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota de 0 a 10: ");
            double nota2 = double.Parse(Console.ReadLine());
            double MF = (nota1 + nota2) / 2;
            Console.WriteLine("Sua média final Lingua Portuguesa é :" + MF);

        // Matéria Matemática
        } else if (notas == 2) {
            Console.WriteLine("Informe a primeira nota de 0 a 10: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota de 0 a 10: ");
            double nota2 = double.Parse(Console.ReadLine());
            double MF = (nota1 + nota2) / 2;
            Console.WriteLine("Sua média final em matemática é :" + MF);

        // Matéria Ciências
        } else if (notas == 3) {
            Console.WriteLine("Informe a primeira nota de 0 a 10: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota de 0 a 10: ");
            double nota2 = double.Parse(Console.ReadLine());
            double MF = (nota1 + nota2) / 2;
            Console.WriteLine("Sua média final em Ciências é :" + MF);

        // Matéria História
        } else if (notas == 4) {
            Console.WriteLine("Informe a primeira nota de 0 a 10: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota de 0 a 10: ");
            double nota2 = double.Parse(Console.ReadLine());
            double MF = (nota1 + nota2) / 2;
            Console.WriteLine("Sua média final em História é :" + MF);

        // Matéria Geografia
        } else if (notas == 5) {
            Console.WriteLine("Informe a primeira nota de 0 a 10: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota de 0 a 10: ");
            double nota2 = double.Parse(Console.ReadLine());
            double MF = (nota1 + nota2) / 2;
            Console.WriteLine("Sua média final em Geografia é :" + MF);

        // Opção Inválida
        } else {
            Console.WriteLine("Opção inválida");
        }
    }

}