using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theloailist
{
    public partial class MainForm : Form
    {
        public MainForm()=> InitializeComponent();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            TheLoaiGrid.AllowUserToAddRows = false;
            TheLoaiGrid.DataSource = TheLoaiList;

            // Add a few test items.
            TheLoaiList.Add(new TheLoai { SoTuaSach = "1", Column2 = "A", });
            TheLoaiList.Add(new TheLoai { SoTuaSach = "1", Column2 = "B", });
            TheLoaiList.Add(new TheLoai { SoTuaSach = "1", Column2 = "C", });

            #region F O R M A T    C O L U M N S
            foreach (DataGridViewColumn column in TheLoaiGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            #endregion F O R M A T    C O L U M N 

            buttonChangeValueTest.Click += onChangeValueTestClick;
        }

        int _testCount = 10;
        private void onChangeValueTestClick(object sender, EventArgs e)
        {
            // Now perform change the value on the Data not the DataGridView
            var testValue = _testCount++.ToString();
            foreach (TheLoai theLoai in TheLoaiList)
            {
                theLoai.SoTuaSach = testValue; 
            }
        }

        BindingList<TheLoai> TheLoaiList { get; } = new BindingList<TheLoai>();
    }

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
}
