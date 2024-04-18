Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class Laic
    Dim connectionString As String = "Data Source=KAPEL-SADIKI\KAPEL;Initial Catalog=cultedb;Integrated Security=True;Encrypt=False"
    Private Sub Laic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'CultedbDataSet.membre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.MembreTableAdapter.Fill(Me.CultedbDataSet.membre)
        Populate()
    End Sub



    Private Sub Enregistrer_btn_Click(sender As Object, e As EventArgs) Handles Enregistrer_btn.Click

        Dim sql As String = "INSERT INTO [membre] ([dateculte], [nom], [datenais], [adress], [sexe], [poste], [telephone]) VALUES (@dateculte, @nom, @datenais, @adress, @sexe, @poste, @telephone)"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@dateculte", dateculte.Value)
                    command.Parameters.AddWithValue("@nom", nom.Text)
                    command.Parameters.AddWithValue("@datenais", (datenais.Value).ToShortDateString)
                    command.Parameters.AddWithValue("@adress", adress.Text)
                    command.Parameters.AddWithValue("@sexe", sexe.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@poste", poste.Text)
                    command.Parameters.AddWithValue("@telephone", telephone.Text)
                    command.ExecuteNonQuery()
                    MsgBox("Le membre " & nom.Text & " est enregistré.")
                    connection.Close()
                    Populate()
                    Clear()
                End Using
            End Using
        Catch ex As SqlException
            MsgBox("Erreur lors de l'enregistrement du membre : " & ex.Message)
        End Try
    End Sub

    Private Sub Populate()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sql As String = "select * from membre"
            Dim adapter As New SqlDataAdapter(sql, connection)
            Dim builder As New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            LaicView.DataSource = ds.Tables(0)
            connection.Close()
        End Using
    End Sub
    Private Sub Clear()
        nom.Clear()
        dateculte.Value = Date.Now
        sexe.SelectedIndex = 0
        datenais.Value = Date.Now
        adress.Clear()
        poste.Clear()
        telephone.Clear()
    End Sub

    Public Sub LaicView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LaicView.CellMouseClick
        Dim row As DataGridViewRow = LaicView.Rows(e.RowIndex)
        dateculte.Value = row.Cells(1).Value.ToString
        nom.Text = row.Cells(2).Value.ToString
        datenais.Value = row.Cells(3).Value.ToString
        sexe.SelectedItem = row.Cells(4).Value.ToString
        telephone.Text = row.Cells(5).Value.ToString
        adress.Text = row.Cells(6).Value.ToString
        poste.Text = row.Cells(7).Value.ToString

        If nom.Text = "" Then
            keyBox = 0
        Else
            keyBox = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Effacer_btn_Click(sender As Object, e As EventArgs) Handles Effacer_btn.Click
        Clear()
    End Sub
    Dim keyBox = 0

    Private Sub Supprimer_btn_Click(sender As Object, e As EventArgs) Handles Supprimer_btn.Click

        Dim sql As String = "DELETE FROM membre WHERE id_membre = " & keyBox & ""

        If keyBox = 0 Then
            MsgBox("Information manquante")
        Else
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using command As New SqlCommand(sql, connection)
                        command.ExecuteNonQuery()
                        MsgBox("Membre supprimé")
                    End Using
                    connection.Close()
                    Populate()
                    Clear()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Modifier_btn_Click(sender As Object, e As EventArgs) Handles Modifier_btn.Click

        Dim sql As String = "UPDATE [membre] SET [nom] = @dateculte, [datenais] = @datenais, [adress] = @adress, [sexe] = @sexe, [poste] = @poste, [telephone] = @telephone where id_membre  = " & keyBox & ""

        If (nom.Text = "" Or adress.Text = "" Or telephone.Text = "" Or sexe.SelectedIndex = -1 Or poste.Text = "" Or dateculte.Value = Date.Now() Or datenais.Value = Date.Now() Or keyBox = 0) Then
            MsgBox("Information manquante")
        Else
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.AddWithValue("@dateculte", dateculte.Value)
                        command.Parameters.AddWithValue("@nom", nom.Text)
                        command.Parameters.AddWithValue("@datenais", (datenais.Value).ToShortDateString)
                        command.Parameters.AddWithValue("@adress", adress.Text)
                        command.Parameters.AddWithValue("@sexe", sexe.SelectedItem.ToString())
                        command.Parameters.AddWithValue("@poste", poste.Text)
                        command.Parameters.AddWithValue("@telephone", telephone.Text)
                        command.ExecuteNonQuery()
                        connection.Close()
                        MsgBox("Client mis à jour avec succès")
                    End Using
                    connection.Close()
                    Populate()
                    Clear()
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



End Class
