using System.Windows;

namespace FancyZonesEditor
{
    public partial class Sidebar : Window
    {
        private LayoutSwitcher _layoutSwitcher;

        public Sidebar(LayoutSwitcher layoutSwitcher)
        {
            InitializeComponent();
            _layoutSwitcher = layoutSwitcher;
        }

        private void Layout1_Click(object sender, RoutedEventArgs e)
        {
            _layoutSwitcher.OnLayoutSelected(/* Layout 1 Model */);
        }

        private void Layout2_Click(object sender, RoutedEventArgs e)
        {
            _layoutSwitcher.OnLayoutSelected(/* Layout 2 Model */);
        }

        private void Layout3_Click(object sender, RoutedEventArgs e)
        {
            _layoutSwitcher.OnLayoutSelected(/* Layout 3 Model */);
        }
    }
}
