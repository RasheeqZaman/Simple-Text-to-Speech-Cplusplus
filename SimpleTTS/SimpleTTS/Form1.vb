Imports System.Speech
Imports System.Speech.Synthesis


Public Class Form1

    Dim speaker As New SpeechSynthesizer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        speaker.SpeakAsync(RichTextBox1.Text)
        Label1.Text = RichTextBox1.Text
    End Sub
End Class
