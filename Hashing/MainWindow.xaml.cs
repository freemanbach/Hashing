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

namespace Hashing {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {
            load_shavalues();
  

        }
        private void load_shavalues() {
            shavalues.Items.Add("SHA-1");
            shavalues.Items.Add("SHA-224");
            shavalues.Items.Add("SHA-256");
            shavalues.Items.Add("SHA-384");
            shavalues.Items.Add("SHA-512");
            shavalues.Items.Add("SHA3-224");
            shavalues.Items.Add("SHA3-256");
            shavalues.Items.Add("SHA3-384");
            shavalues.Items.Add("SHA3-512");
            shavalues.Items.Add("SHAKE-128");
            shavalues.Items.Add("SHAKE-256");
            shavalues.Items.Add("cSHAKE-128");
            shavalues.Items.Add("cSHAKE-256");
            shavalues.Items.Add("TupleHash-128");
            shavalues.Items.Add("TupleHash-256");
            shavalues.Items.Add("ParallelHash-128");
            shavalues.Items.Add("ParallelHash-256");
        }

        private void shavalues_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e) {
            Environment.Exit(0);
        }
    }
}
