Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms
Public Class U_C
    Dim con As New SqlConnection(My.Settings.CONEXION)
    Dim sentencia, mensaje As String
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Close()

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim da As New SqlDataAdapter("Select * from ADMINISTRACION where DPI = " + txt_DPI.Text + "", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
        Me.DataGridView1.Columns("CONTRASEÑA").Visible = False
    End Sub
End Class