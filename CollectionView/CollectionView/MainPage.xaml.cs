using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CollectionView
{
    public class Animal
    {
        public string name;
    };

    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Animal> collections;

        public MainPage()
        {
            InitializeComponent();

            collections = new ObservableCollection<Animal>
            {
                new Animal{ name = "this" },
                new Animal{ name = "that" },
                new Animal{ name = "something" }
            };

            collectionview.ItemsSource = collections;
            collectionview.ItemTemplate = new DataTemplate(() =>
            {
                var textCell = new TextCell();
                textCell.SetBinding(TextCell.TextProperty, "name");
                textCell.SetBinding(TextCell.DetailProperty, "some details goes here");
                return textCell;
            });
        }
    }
}
