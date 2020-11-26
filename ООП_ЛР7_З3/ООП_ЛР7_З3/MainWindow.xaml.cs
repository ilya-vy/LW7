using System.Collections.Generic;
using System.Windows;

namespace ООП_ЛР7_З3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        } 
        private void Search(object sender, RoutedEventArgs e)
        {
            string searchString = searchBox.Text;
            List<Article> newArticles = new List<Article>();
            newArticles = Store.article;
            newArticles = newArticles.FindAll(x => x.Name.Contains(searchBox.Text));
            LoadArticle(newArticles);
        }
        public void LoadArticle(List<Article> article)
        {
            goodsList.Items.Clear();
            for (int i = 0; i < article.Count; i++) goodsList.Items.Add(article[i]);
        }
        private void AddProduct(object sender, RoutedEventArgs e)
        {
            Store.article.Add(new Article(textBox1.Text, textBox2.Text, textBox3.Text));
            LoadArticle(Store.article);
        }
    }
}
