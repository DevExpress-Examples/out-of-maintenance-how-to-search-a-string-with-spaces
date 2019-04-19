Imports System.Windows
Imports DevExpress.Data.Filtering

Namespace How_to_Search_a_String_with_Spaces
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub TableView_SearchStringToFilterCriteria(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.SearchStringToFilterCriteriaEventArgs)
			e.Filter = CriteriaOperator.Parse(String.Format("Contains([Name], '{0}')", e.SearchString))
		End Sub
	End Class
End Namespace
