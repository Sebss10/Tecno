Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms
Public Class CONEXION
    Public conexion As SqlConnection = New SqlConnection(My.Settings.CONEXION)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter = New SqlDataAdapter
    Public cmd As SqlCommand

    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)

    End Sub

    Function Verificacion(ByVal sql)
        conexion.Open()
        cmd = New SqlCommand(sql, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
