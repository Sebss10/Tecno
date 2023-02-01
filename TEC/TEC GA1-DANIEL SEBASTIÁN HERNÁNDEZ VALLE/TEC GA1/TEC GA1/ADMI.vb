Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms

Public Class ADMI
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

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sentencia = "Delete from ADMINISTRACION where DPI = " + txt_DPI.Text + ""
        mensaje = "Datos eliminados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from ADMINISTRACION ", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
            Me.DataGridView1.Columns("CONTRASEÑA").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        sentencia = "Update ADMINISTRACION set USEER = '" + txt_USEER.Text + "', CONTRASEÑA = '" + txt_Contra.Text + "',ROL = '" + txt_Rol.Text + "',NOMBRE= '" + txt_Nom.Text + "',APELLIDO = '" + txt_Apell.Text + "',DPI ='" + txt_DPI.Text + "' where DPI ='" + txt_DPI.Text + "'"
        mensaje = "Datos actualizados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from ADMINISTRACION", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim da As New SqlDataAdapter("Select * from ADMINISTRACION where DPI = " + txt_DPI.Text + "", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Dim da As New SqlDataAdapter("Select * from ADMINISTRACION ", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        sentencia = "Insert ADMINISTRACION values ('" + txt_USEER.Text + "','" + txt_Contra.Text + "','" + txt_Rol.Text + "','" + txt_Nom.Text + "','" + txt_Apell.Text + "','" + txt_DPI.Text + "')"
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