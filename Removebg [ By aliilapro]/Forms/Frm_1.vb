Imports System.IO
Imports System.Net.Http
Imports System.Threading

Public Class Frm_1
    Public imageInfo As String() = {"", ""}
    Public Sub New()
        InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False
        txtLocal.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    End Sub
    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim o As New OpenFileDialog
        o.Filter = "Image Files|*.jpg"
        If o.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            imageInfo(0) = Path.GetFileNameWithoutExtension(o.FileName)
            imageInfo(1) = o.FileName
            btn_browse.Enabled = False
            Dim T As New Thread(New ThreadStart(AddressOf aliilapro))
            T.Start()
        End If
    End Sub
    Public Sub aliilapro()
        On Error Resume Next
        Using X As New HttpClient
            Dim content As New MultipartFormDataContent
            content.Headers.Add("X-Api-Key", txt_api.Text)
            content.Add(New ByteArrayContent(File.ReadAllBytes(imageInfo(1))), "image_file", "file.jpg")
            content.Add(New StringContent("auto"), "size")
            Dim result As HttpResponseMessage = X.PostAsync("https://api.remove.bg/v1.0/removebg", content).Result
            If result.IsSuccessStatusCode Then
                Dim File As New FileStream(txtLocal.Text & "\" & imageInfo(0) & ".png", FileMode.Create, FileAccess.Write, FileShare.None)
                result.Content.CopyToAsync(File).ContinueWith(Sub() File.Close())
                Dim Out As String = txtLocal.Text & "\" & imageInfo(0) & ".png"
                Poriginal.Image = Image.FromFile(imageInfo(1))
                Pfinished.Image = Image.FromFile(Out)
                btn_browse.Enabled = True
            Else
                MsgBox(result.Content.ReadAsStringAsync.Result)
                btn_browse.Enabled = True
                Exit Sub
            End If
        End Using
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim I As New FolderBrowserDialog
        I.ShowNewFolderButton = True
        I.RootFolder = Environment.SpecialFolder.Desktop
        I.Description = "Save images"
        If I.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtLocal.Text = I.SelectedPath
        End If
    End Sub

    Private Sub hideme_CheckedChanged(sender As Object, e As EventArgs) Handles hideme.CheckedChanged
        If hideme.Checked = True Then
            txt_api.PasswordChar = "0"
        Else
            txt_api.PasswordChar = ""
        End If
    End Sub
End Class