Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms
Public Class SECRE
    Dim con As New SqlConnection(My.Settings.CONEXION)
    Dim sentencia, mensaje As String
    Sub Ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim da As New SqlDataAdapter("Select * from ADMINISTRACION where DPI = " + txt_DPI.Text + "", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)


    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Close()

    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        sentencia = "Insert ADMINISTRACION values ('" + txt_USEER.Text + "','" + txt_Contra.Text + "','" + txt_Rol.Text + "','" + txt_Nomb.Text + "','" + txt_Apll.Text + "','" + txt_DPI.Text + "')"
        mensaje = "Datos ingresados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from ADMINISTRACION", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class