using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Philip Boyle - G00325728@gmit.ie

namespace PB_Simple_Calculator
{
    
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

       
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }


        private void number_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += (string)((Button)sender).Content;
        }//digit


        private void operation(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "")
            {
                Display.Text += (string)((Button)sender).Content;
            }
            else
            {
                Display.Text += " " + (string)((Button)sender).Content + " ";
            }
        }//operation

        private void Display_TextChanged(object sender, TextChangedEventArgs e)
        {

        }//display

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = ("");
        }//clear

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            String[] equation = Display.Text.Split();

            double num1 = double.Parse(equation[0]);
            double num2 = double.Parse(equation[2]);

            if (equation[1] == "+")
            {
                Display.Text = (num1 + num2).ToString();
            }//add
            else if (equation[1] == "-")
            {
                Display.Text = (num1 - num2).ToString();
            }//subtract
            else if (equation[1] == "/")
            {
                if (num2 == 0.0)
                {
                    Display.Text = "Math Error";
                }
                Display.Text = (num1 / num2).ToString();
            }//divide
            else if (equation[1] == "x")
            {
                Display.Text = (num1 * num2).ToString();

            }//multiply

        }//equals
    }
}
