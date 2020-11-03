Public Class Menu
    Dim camion1 As New camion()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("La clase camion se inicializó")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtChapa.Text <> "" Then
            camion1.Chapa = txtChapa.Text
        Else
            MsgBox("Deben completarse todos los campos")
        End If

        If txtColor.Text <> "" Then
            camion1.Color = txtColor.Text
        Else
            MsgBox("Deben completarse todos los campos")
        End If

        If txtAnio.Text <> "" Then
            camion1.Anio = txtAnio.Text
        Else
            MsgBox("Deben completarse todos los campos")
        End If

        If chkVenta.Checked Then
            camion1.Venta = True
        Else
            camion1.Venta = False
        End If
        MsgBox(camion1.ToString)
    End Sub

    Private Sub btnRevision_Click(sender As Object, e As EventArgs) Handles btnRevision.Click
        camion1.revision()
    End Sub
End Class
