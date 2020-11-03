Public Class camion
    Private mChapa As Int64
    Private mColor As String
    Private mAnio As Integer
    Private mVenta As Boolean
    Private estado As String

    Public Sub New()
        Me.mChapa = 0
        Me.mColor = "Sin Color"
    End Sub

    Public Sub New(ByVal chapa As Integer, ByVal color As String, ByVal venta As Boolean, ByVal Anio As Integer)
        Me.mChapa = chapa
        Me.mColor = color
        Me.mVenta = venta
        Me.mAnio = Anio


    End Sub

    Public Property Chapa As Integer
        Get
            Return mChapa
        End Get
        Set(ByVal value As Integer)
            If mChapa = Nothing Then
                Me.mChapa = value
            Else
                MsgBox("Ya existe una chapa")

            End If
        End Set
    End Property

    Public Property Color As String
        Get
            Return mColor
        End Get
        Set(ByVal value As String)
            Me.mColor = value
        End Set
    End Property

    Public Property Anio As Integer
        Get
            Return mAnio
        End Get
        Set(ByVal value As Integer)
            Me.mAnio = value
        End Set
    End Property

    Public Property Venta As Boolean
        Get
            Return mVenta
        End Get
        Set(ByVal value As Boolean)
            Me.mVenta = value
            If mVenta = True Then
                estado = "está a la venta"
            Else
                estado = "no está a la venta"
            End If
        End Set

    End Property

    Public Overrides Function ToString() As String
        Return "Este camion tiene la matricula: " & Me.Chapa & " , su color es: " & Me.mColor & " , " & Me.estado & " , y es del año: " & Me.mAnio
    End Function

    Public Sub revision()
        Dim momento = System.DateTime.Now
        Dim año = momento.Year
        If Me.Anio < año Then
            MsgBox("Le toca revision", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            MsgBox("El camion está al dia")
        End If
    End Sub
End Class
