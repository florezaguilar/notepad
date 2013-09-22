using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;




namespace WpfApplication1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool a = false;
        public static int b;
        
        

        public MainWindow()
        {

            InitializeComponent();
            
            
        }


        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
            NroLineas.Content = (textBox1.Text.Length);

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MenNuevo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.InitialDirectory = "c:\\";
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            Nullable<bool> result = file.ShowDialog();

            if (result == true)
            {

                System.IO.StreamReader sr = new System.IO.StreamReader(file.FileName);
                textBox1.Text = Convert.ToString(sr.ReadToEnd());
                sr.Close();
            }

        }

        private void MenSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenGuardar_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".text";
            save.Filter = "Text documents (.txt)|*.txt";
            save.InitialDirectory = "c:\\";
            Nullable<bool> result = save.ShowDialog();
            if (result == true)
            {
                StreamWriter escrito = File.CreateText(save.FileName);
                String contenido = textBox1.Text;
                escrito.Write(contenido.ToString());
                
                escrito.Flush();
                escrito.Close();

            }

        }

        private void MenBarr_Click(object sender, RoutedEventArgs e)
        {
            MenBarr.IsCheckable = true;
            if (MenBarr.IsChecked == true)
            {
                statusBar1.Visibility = Visibility.Visible;
            }
            else
                statusBar1.Visibility = Visibility.Hidden;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }



    }



}

