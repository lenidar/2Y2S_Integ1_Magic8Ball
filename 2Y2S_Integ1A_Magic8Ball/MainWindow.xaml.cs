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

namespace _2Y2S_Integ1A_Magic8Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random _rnd = new Random();
        string[] _rollResults = new string[12];
        public MainWindow()
        {
            InitializeComponent();
            lblMessage.Content = "Click the button to roll a D12 wild magic surge";
            _rollResults[0] = "Roll on this table at the start of each of your turns for the next minute.";
            _rollResults[1] = "For the next minute, you can see any invisible creature within 60ft and not in total cover.";
            _rollResults[2] = "A modron chosen and controlled by the DM appears in an unoccupied space within 5 feet of you, then disappears 1 minute later.";
            _rollResults[3] = "You cast fireball as a 3rd-level spell centered on yourself.";
            _rollResults[4] = "You cast magic missile as a 5th-level spell.";
            _rollResults[5] = "You cast confusion centered on yourself.";
            _rollResults[6] = "For the next minute, you regain 5 hit points at the start of each of your turns.";
            _rollResults[7] = "You grow a long beard made of feathers that remains until you sneeze, at which point the feathers explode out from your face";
            _rollResults[8] = "You cast grease centered on yourself.";
            _rollResults[9] = "Creatures have disadvantage on saving throws against the next spell you cast in the next minute that involves a saving throw.";
            _rollResults[10] = "Your skin turns a vibrant shade of blue. A remove curse spell can end this effect.";
            _rollResults[11] = "Your skin turns a vibrant shade of colour. A remove curse spell of 5th level or higher can end this effect.";
        }

        private void btnRoll_Click(object sender, RoutedEventArgs e)
        {
            //lblMessage.Content = $"You rolled a {_rnd.Next(1,101)} on a d100";
            int roll = _rnd.Next(0, _rollResults.Length);
            lblMessage.Content = _rollResults[roll];
        }
    }
}
