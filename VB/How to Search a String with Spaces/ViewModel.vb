Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace How_to_Search_a_String_with_Spaces
	Public Class ViewModel
		Private _items As ObservableCollection(Of Item)
		Public ReadOnly Property Items() As IEnumerable(Of Item)
			Get
				Return _items
			End Get
		End Property

		Public Sub New()
			_items = New ObservableCollection(Of Item)()
			For i As Integer = 0 To 99
				_items.Add(New Item(i))
			Next i
		End Sub
	End Class

	Public Class Item
		Implements INotifyPropertyChanged

		Private Shared ReadOnly rnd As New Random()
		Private Shared ReadOnly Names() As String = { "Alex", "Robert", "Anna", "Kate" }
		Private Shared ReadOnly Surnames() As String = { "Mercer", "Black", "White", "John" }

		Public Sub New()
		End Sub

		Public Sub New(ByVal id As Integer)
			MyBase.New()
			Me.Id = id
			Name = String.Format("{0} {1}", Names(rnd.Next(Names.Length)), Surnames(rnd.Next(Surnames.Length)))
		End Sub

		Private _id As Integer
		Public Property Id() As Integer
			Get
				Return _id
			End Get
			Set(ByVal value As Integer)
				_id = value
				OnPropertyChanged("Id")
			End Set
		End Property

		Private _name As String
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set(ByVal value As String)
				_name = value
				OnPropertyChanged("Name")
			End Set
		End Property

		Private Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
	End Class
End Namespace
