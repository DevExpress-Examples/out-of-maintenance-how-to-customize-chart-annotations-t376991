Imports System.Windows

Namespace MarsTemperature
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    Public Class AnnotationContent
        Public Property Text() As String
        Public Property ImageSource() As String
    End Class
End Namespace
