using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace How_to_Search_a_String_with_Spaces {
    public class ViewModel {
        ObservableCollection<Item> _items;
        public IEnumerable<Item> Items { get { return _items; } }

        public ViewModel() {
            _items = new ObservableCollection<Item>();
            for(int i = 0; i < 100; i++)
                _items.Add(new Item(i));
        }
    }

    public class Item : INotifyPropertyChanged {
        static readonly Random rnd = new Random();
        static readonly string[] Names = { "Alex", "Robert", "Anna", "Kate" };
        static readonly string[] Surnames = { "Mercer", "Black", "White", "John" };    

        public Item() { }

        public Item(int id) : base() {
            Id = id;
            Name = string.Format("{0} {1}", Names[rnd.Next(Names.Length)], Surnames[rnd.Next(Surnames.Length)]);   
        }

        int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged("Id"); } }

        string _name;
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged("Name"); } } 

        void OnPropertyChanged(string propertyName) {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
