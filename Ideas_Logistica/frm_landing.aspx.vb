Imports Ideas_Logistica_AD
Public Class frm_landing
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click

        Dim oMensaje As New cLanding

        If txtNombre.Text <> Nothing And txtApellido.Text <> Nothing And txtEmail.Text <> Nothing And txtTelefono.Text <> Nothing And txtMensaje.Value <> Nothing Then
            oMensaje.Agregar(txtNombre.Text, txtApellido.Text, txtEmail.Text, txtTelefono.Text, txtMensaje.Value)

        End If

    End Sub
End Class