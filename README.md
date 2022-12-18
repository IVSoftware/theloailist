[![screenshot][1]][1]

Your [code](https://stackoverflow.com/q/74843259/5438626) shows you are on the right track! Binding the `TheLoaiGrid.DataSource` to the `TheLoaiList` that's _good_ because you can change what's in the `DataGridView` by changing `TheLoaiList`. The next step you might want to try is making the _items_ in the list work the same way (using binding) so that when you do your loop, you can modify the _data_ not the `DataGridViewRow`:

    foreach (TheLoai theLoai in TheLoaiList)
    {
        theLoai.SoTuaSach = "10"; 
    }
***

For this to work, it requires a small change to the class that represents your row items. Suppose you  defined `TheLoaiList` this way:

    BindingList<TheLoai> TheLoaiList { get; } = new BindingList<TheLoai>();

Then here's an example of how to automatically notify the `DataGridView` when a property changes using `INotifyPropertyChanged`:

    // using System.Runtime.CompilerServices;
    class TheLoai : INotifyPropertyChanged
    {
        string _soTuaSach = string.Empty;
        public string SoTuaSach
        {
            get => _soTuaSach;
            set
            {
                if (!Equals(_soTuaSach, value))
                {
                    _soTuaSach = value;
                    OnPropertyChanged();
                }
            }
        }
        string _column2 = string.Empty;
        public string Column2
        {
            get => _column2;
            set
            {
                if (!Equals(_column2, value))
                {
                    _column2 = value;
                    OnPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


  [1]: https://i.stack.imgur.com/WGL6q.png