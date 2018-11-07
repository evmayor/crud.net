

'Curso_id	int
'Curso_nombre	nvarchar
'Curso_creditos	int
'Curso_codicion	int

Public Class Curso
    Private Cursoid As Integer
    Private Cursonombre As String
    Private Cursocreditos As Integer
    Private Cursocodicion As Integer


    Public Property Curso_id() As Integer
        Get
            Return Cursoid
        End Get
        Set(value As Integer)
            Cursoid = value
        End Set
    End Property

    Public Property Curso_nombre() As String
        Get
            Return Cursonombre
        End Get
        Set(value As String)
            Cursonombre = value
        End Set
    End Property

    Public Property Curso_creditos() As Integer
        Get
            Return Cursocreditos
        End Get
        Set(value As Integer)
            Cursocreditos = value
        End Set
    End Property

    Public Property Curso_codicion As Integer
        Get
            Return Cursocodicion
        End Get
        Set(value As Integer)
            Cursocodicion = value
        End Set
    End Property


End Class
