using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WEEK3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            StackPanel spIDcard = new StackPanel();
            spIDcard.VerticalAlignment = VerticalAlignment.Top;
            spIDcard.Orientation = Orientation.Vertical;
            spIDcard.SetValue(Grid.ColumnProperty, 0);
            spIDcard.Margin = new Thickness(40, 0, 20, 0);

            TextBlock tblNew = new TextBlock();
            tblNew.Text = "Hello from C#";
            tblNew.Margin = new Thickness(5);
            spIDcard.Children.Add(tblNew);

            tblNew.Text = "It actually worked";
            tblNew.Margin = new Thickness(5);
            spIDcard.Children.Add(tblNew);

          
          
            this.InitializeComponent();
        }
    }

  
}
