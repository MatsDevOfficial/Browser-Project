using System;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace AIBrowser
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            // Zorg ervoor dat WebView2 correct wordt geladen.
            await WebView.EnsureCoreWebView2Async(null);
            WebView.Source = new Uri("https://www.google.com");
        }

        private void OnNavigateClick(object sender, RoutedEventArgs e)
        {
            // Navigeer naar de URL in de tekstbox.
            try
            {
                Uri targetUri = new Uri(UrlBox.Text);
                WebView.Source = targetUri;
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Voer een geldige URL in.");
            }
        }

        private void OnAIButtonClick(object sender, RoutedEventArgs e)
        {
            // AI is tijdelijk uitgeschakeld
            MessageBox.Show("De AI-functie is momenteel uitgeschakeld. Deze kan later worden geactiveerd.");
        }
    }
}
