using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RPSSL;

public partial class MainWindow : Window
{
    enum RPSSL
    {
        Rock,
            Paper,
                Scissors,
                    Spock,
                        Lizard
    }

    private string[] Hands = ["Rock", "Paper", "Scissors", "Spock", "Lizard"];
    int score = 0;
    

    private Random n = new Random();
    public MainWindow()
    {
        InitializeComponent();
        OnButtonClick1();
        OnButtonClick2();
        OnButtonClick3();
        OnButtonClick4();
        OnButtonClick5();
    }

    

    private void OnButtonClick1(object? sender, RoutedEventArgs routedEventArgs)
    {
        string you =Convert.ToInt16("Rock") ;
        var Computer = Random.Shared.GetItems(Hands, 5);
       
        if (you==Computer )
            Console.WriteLine("Tie");
            else switch (score)
            {
                case Computer = "Paper": Console.WriteLine("You lose"); break;
                case Computer="Scissors": Console.WriteLine("You win"); break;
                case Computer="Spock": Console.WriteLine("You lose"); break;
                case Computer=4: Console.WriteLine("You Win"); break;
            }
    }
    private void OnButtonClick2(object? sender, RoutedEventArgs routedEventArgs)
    {
        RPSSL you = RPSSL.Paper;
        RPSSL Computer = n.Next();
        if (you==Computer) 
        Console.WriteLine("Tie");
        else
            switch (score)
            {
                case Computer=RPSSL.Rock: Console.WriteLine("You Win");
                case Computer=RPSSL.Scissors: Console.WriteLine("You Lose");
                case Computer=RPSSL.Spock: Console.WriteLine("You Win");
                case Computer=RPSSL.Lizard: Console.WriteLine("You Lose");
            }
    }
    private void OnButtonClick3(object? sender, RoutedEventArgs routedEventArgs)
    {
        RPSSL you = RPSSL.Scissors;
        RPSSL Computer = n.Next();
        if (you==Computer) 
        Console.WriteLine("Tie");
        else
            switch (score)
            {
                case RPSSL.Paper: Console.WriteLine("You Win");
                case RPSSL.Rock: Console.WriteLine("You Lose");
                case RPSSL.Spock: Console.WriteLine("You lose");
                case RPSSL.Lizard: Console.WriteLine("You Win");
            }
    }

    private void OnButtonClick4(object? sender, RoutedEventArgs routedEventArgs)
    {
        RPSSL you = RPSSL.Spock;
        RPSSL Computer = n.Next();
        if (you==Computer) 
        Console.WriteLine("Tie");
        else
            switch (score)
            {
                case RPSSL.Paper: Console.WriteLine("You lose");
                case RPSSL.Scissors: Console.WriteLine("You win");
                case RPSSL.Rock: Console.WriteLine("You Win");
                case RPSSL.Lizard: Console.WriteLine("You Lose");
            }
    }
    private void OnButtonClick5(object? sender, RoutedEventArgs routedEventArgs)
    {
        RPSSL you = RPSSL.Lizard;
        RPSSL Computer = n.Next();
        if (you==Computer)
        Console.WriteLine("Tie");
        else
            switch (score)
            {
                case Computer=1: Console.WriteLine("You Win");
                case Computer=2: Console.WriteLine("You lose");
                    break;
                case Computer=3: Console.WriteLine("You Win");
                    break;
                case Computer=0: Console.WriteLine("You Lose");
                    break;
            }
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}
