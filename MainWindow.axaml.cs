using Avalonia.Controls;
using System;
namespace AvaloniaApplication1;
    public partial class MainWindow : Window
    {
        enum rpssl { Rock,
            Paper,
            Scissors,
            Spock,
            Lizard 
        }
        Random n = new Random();

        int ps = 0, cs = 0, ties = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Play(rpssl you)
        {
            rpssl computer = (rpssl)n.Next(0, 5);
            int result = Resolve(you, computer);

            if (result == 1) { ps++; r.Text = "You win"; }
            else if (result == -1) { cs++; r.Text = "You lose"; }
            else { ties++; r.Text = "Tie"; }

            s.Text = $"Score: You {ps} Computer {cs} (Ties: {ties})";
        }

        private int Resolve(rpssl you, rpssl computer)
        {
            if (you == computer) return 0;

            switch (you)
            {
                case rpssl.Rock: return (computer == rpssl.Scissors || computer == rpssl.Lizard) ? 1 : -1;
                case rpssl.Paper: return (computer == rpssl.Rock || computer == rpssl.Spock) ? 1 : -1;
                case rpssl.Scissors: return (computer == rpssl.Paper || computer == rpssl.Lizard) ? 1 : -1;
                case rpssl.Spock: return (computer == rpssl.Scissors || computer == rpssl.Rock) ? 1 : -1;
                case rpssl.Lizard: return (computer == rpssl.Paper || computer == rpssl.Spock) ? 1 : -1;
            }
            return 0;
        }
    }
