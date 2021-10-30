using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace mvvm_test
{
    class ItemViewModel
    {
        public ObservableCollection<ToDoItem> Items { set; get; }
        public ItemViewModel()
        {
            Items = new ObservableCollection<ToDoItem>();
            Items.Add(new ToDoItem("Пример"));
        }

        public string TextOfNewItem { set; get; }

        public ICommand AddNewToDoCommand => new Command(AddItem);
        public ICommand RemoveToDoCommand => new Command(RemoveItem);
        void AddItem()
        {
            if (TextOfNewItem == "") return;

            Items.Add(new ToDoItem(TextOfNewItem));    
        }

        void RemoveItem(object o)
        {
            Items.Remove(o as ToDoItem);
        }

    }
}
