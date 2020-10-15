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

namespace CommunicationActivity1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Generate a list for storing the projects generated
        static List<Program> list = new List<Program>();

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            string inputName;
            double inputSID;

            if (txtName.Text.Trim() != string.Empty)
            {
                inputName = txtName.Text.Trim();

                if (Double.TryParse(txtSID.Text.Trim(), out inputSID))
                {
                    int selectedProjectStatus;
                    selectedProjectStatus = cmbStatus.SelectedIndex;

                    list.Add(new Program(inputName, inputSID, selectedProjectStatus));

                        //clears the list diaplay
                        lsbOutputDisplay.Items.Clear();

                        //loops through the list and outputs the objects created
                        for (int i = 0; i < list.Count; i++)
                        {
                            lsbOutputDisplay.Items.Add(list[i].Name);
                        }
                    
                }
                else
                {
                    MessageBox.Show("Please enter your SID");
                    txtSID.Focus();
                    txtSID.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter your Name");
                txtName.Focus();
                txtName.SelectAll();
            }
        }

        private void lsbOutputDisplay_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            subWindow newWindow = new subWindow(list[lsbOutputDisplay.SelectedIndex]);
            newWindow.Show();
        }
    }
}
