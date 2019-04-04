using System.Windows;
using DevExpress.Data.Filtering;

namespace How_to_Search_a_String_with_Spaces {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void TableView_SearchStringToFilterCriteria(object sender, DevExpress.Xpf.Grid.SearchStringToFilterCriteriaEventArgs e) {
            e.Filter = CriteriaOperator.Parse(string.Format("Contains([Name], '{0}')", e.SearchString));
        }
    }
}
