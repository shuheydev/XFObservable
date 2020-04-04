using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFObservable.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddRemoveCollectionItem : ContentPage
    {
        private ObservableCollection<string> _myList;
        public ObservableCollection<string> MyList
        {
            get => _myList;
            set
            {
                _myList = value;
                OnPropertyChanged(nameof(MyList));
            }
        }
        public AddRemoveCollectionItem()
        {
            InitializeComponent();

            this.BindingContext = this;

            MyList = new ObservableCollection<string>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var selected = MyCollectionView.SelectedItem as string;

            if(selected != null)
            {

            }
            MyList.Add($"Added Items {MyList.Count + 1}");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            MyList.RemoveAt(MyList.Count - 1);
        }

        private void MyCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            MyList.Insert(3, $"Added Items {MyList.Count + 1}");
        }
    }
}