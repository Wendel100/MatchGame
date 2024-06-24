using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }
        public void SetUpGame()
        {
            List<string> animaEmoji = new List<string>()
            {
                "🦁","🦁",
                "🐴","🐴",
                "🐼","🐼",
                "🐷","🐷",
            };
            Random random = new Random();
            foreach (TextBlock textBlock in MainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animaEmoji.Count);
                string nextEmoji =animaEmoji[index];
                textBlock.Text = nextEmoji;
                animaEmoji.RemoveAt(index);
            }
        }
    }
}
