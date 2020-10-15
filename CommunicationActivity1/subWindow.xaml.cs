using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CommunicationActivity1
{
    /// <summary>
    /// Interaction logic for subWindow.xaml
    /// </summary>
    public partial class subWindow : Window
    {

        public subWindow(Program program)
        {
            InitializeComponent();
            Program program1 = program;

            txtName.Text = program1.Name;
            txtSID.Text = program1.Sid.ToString();
            cmbStatus.SelectedIndex = program.ProjectStatus;
        }

        private void btnCloase_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
