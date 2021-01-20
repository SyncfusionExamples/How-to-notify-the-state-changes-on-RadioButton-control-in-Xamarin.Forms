using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RadioButton_Event
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RadioButton_StateChanged(object sender, StateChangedEventArgs e)
        {
            if (e.IsChecked.HasValue && e.IsChecked.Value)
            {
                (sender as SfRadioButton).Text = "Checked State";
            }
            else if (e.IsChecked.HasValue && !e.IsChecked.Value)
            {
                (sender as SfRadioButton).Text = "Unchecked State";
            }

        }

    }
}
