using System;

//Tarefa 4: 
//Em Algoritmos e Programação Estruturada, temos a busca pela facilitação da compreensão de programas através do número restrito de mecanismos de controle da execução de programas. Faça um programa na linguagem C, utilizando qualquer compilador, em que peça como entrada, seu nome, endereço e telefone, por fim, exiba esses dados na tela.


class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu endereço:");
        string endereco = Console.ReadLine();

        Console.WriteLine("Digite seu número de telefone:");
        string telefone = Console.ReadLine();

        Console.WriteLine("\nDados informados:");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Endereço: " + endereco);
        Console.WriteLine("Telefone: " + telefone);

        Console.WriteLine("\nPressione Enter para sair.");
        Console.ReadLine();
    }
}
