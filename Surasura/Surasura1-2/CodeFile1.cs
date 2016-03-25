using System.Windows;
using System.Windows.Controls;


class Program
{
    public static void Main()
    {
        var button = new Button { Content = "Click" };
        button.Click += (sender, e) => MessageBox.Show("みなさま、はじめまして");

        var win = new Window
        {
            Width = 100,
            Height = 50,
            Content = button,

        };

        var app = new Application();
        app.Run(win);
    }
}