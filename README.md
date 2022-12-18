Binding the `TheLoaiGrid.DataSource` to the `TheLoaiList` that's _good_ because you can change what's in the `DataGridView` by changing `TheLoaiList`.

NEXT: The _items_ in the list can work the same way. Suppose you  defined `TheLoaiList` this way:

    BindingList<TheLoai> TheLoaiList { get; } = new BindingList<TheLoai>();

Then here's an example of how to notify the `DataGridView` when a property changes using `INotifyPropertyChanged`:

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

***

Now, when you do your loop, change the _data_ not the `DataGridViewRow`:

    // Now perform change the value on the Data not the DataGridView
    var testValue = _testCount++.ToString();
    foreach (TheLoai theLoai in TheLoaiList)
    {
        theLoai.SoTuaSach = testValue; 
    }

***

Here's a minimal working [sample](https://github.com/IVSoftware/theloailist.git) if you want to try this out.

[![screenshot][1]][1]


  [1]: https://i.stack.imgur.com/is7jg.png