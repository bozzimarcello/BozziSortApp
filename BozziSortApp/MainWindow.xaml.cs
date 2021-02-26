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

namespace BozziSortApp
{
    /// <summary>
    /// Bubble Sort DEMO from
    /// https://www.geeksforgeeks.org/bubble-sort/
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i] 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        private void btnOrdina_Click(object sender, RoutedEventArgs e)
        {
            bubbleSort(arr);

            lstElencoValori.Items.Clear();
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                lstElencoValori.Items.Add(arr[i]);
            }
        }

        private void btnVisualizza_Click(object sender, RoutedEventArgs e)
        {
            lstElencoValori.Items.Clear();
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                lstElencoValori.Items.Add(arr[i]);
            }
        }
    }
}
