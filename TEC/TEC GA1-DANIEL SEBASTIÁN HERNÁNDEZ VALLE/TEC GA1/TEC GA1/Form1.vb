Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms
Public Class Form1
    Dim con As SqlConnection = New SqlConnection(My.Settings.CONEXION)
    Dim conexion As CONEXION = New CONEXION
    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim usuario As String
        Dim contraseña As String
        usuario = txt_Us.Text
        contraseña = txt_Contra.Text
        Dim verificar As String = " UPDATE ADMINISTRACION set ROL=ROL where USEER='" + txt_Us.Text + "' and CONTRASEÑA='" + txt_Contra.Text + "' and ROL='Administrador'"
        Dim verificar2 As String = "UPDATE ADMINISTRACION set ROL=ROL where USEER='" + txt_Us.Text + "' and CONTRASEÑA='" + txt_Contra.Text + "' and ROL='Secretaria'"
        Dim verificar3 As String = "UPDATE ADMINISTRACION set ROL=ROL where USEER='" + txt_Us.Text + "' and CONTRASEÑA='" + txt_Contra.Text + "' and ROL='Usuario'"
        If conexion.Verificacion(verificar) Then
            Me.Hide()
            MsgBox("Bienvenido, has ingresado como ADMINISTRADOR")
            ADMI.Show()
        Else
            If conexion.Verificacion(verificar2) Then
                Me.Hide()
                MsgBox("Bienvenido, has ingresado como SECRETARIA/O")
                SECRE.Show()
            Else
                If conexion.Verificacion(verificar3) Then
                    Me.Hide()
                    MsgBox("Bienvenido, has ingresado como USUARIO")
                    U_C.Show()
                Else
                    MsgBox("Ingrese su Usuario y Contraseña de nuevo")
                    txt_Contra.Text = ""
                    txt_Us.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click

        Close()
    End Sub
End Class
