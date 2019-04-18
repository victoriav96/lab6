Option Strict On
'@author: Victoria Valdron
'@date: 18-04-2019
'@filename: Victoria_FinalProject.sln (used from lab 5)
'@course: NETD2201-05
'@description: The purpose of this lab was to create a basic text editor that
'can provide basic function (save,copy,paste,cut,etc). The Final project consists of
'making the original text editor into a MDI text editor.


Imports System.IO
Imports System.Drawing.Text




Public Class frmTextEdit

    Private docNum As Integer = 0
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click


        Application.Exit()


    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim saveFile As New SaveFileDialog
        Dim saveAs As String

        saveFile.ShowDialog()
        saveAs = saveFile.FileName
        Dim stringWrite As New StreamWriter(saveAs)
        stringWrite.Write(txtInput.Text)
        stringWrite.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFile As New OpenFileDialog
        Dim fileLocate As String
        openFile.ShowDialog()
        fileLocate = openFile.FileName

        Dim stringRead As New StreamReader(fileLocate)
        txtInput.Text = stringRead.ReadToEnd()
        stringRead.Close()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveFile As New SaveFileDialog
        Dim saveAs As String

        saveFile.ShowDialog()
        saveAs = saveFile.FileName
        Dim stringWrite As New StreamWriter(saveAs)
        stringWrite.Write(txtInput.Text)
        stringWrite.Close()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

        Clipboard.SetText(txtInput.Text)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click

        If Clipboard.ContainsText = True Then

            txtInput.Text = Clipboard.GetText

        Else


            txtInput.Clear()

        End If



    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click

        Clipboard.SetText(txtInput.Text)
        txtInput.Clear()

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        Dim docForm As New Form2()

        docForm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This program is a text editor, you can input text into the box below. You can also copy/cut or paste, save your files, or create/open new files.")
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AverageUnitsByEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AverageUnitsByEmployeeToolStripMenuItem.Click

        'couldn't figure out how to properly open the file using the openfiledialog. alot of it kept telling me that option strict being on was in
        'the way.
        Dim Lab3 As Double

        Lab3 = Shell("C:\Users\victo\Desktop\CPRGM\Semester 2\NETD\Victoria_Lab5\Victoria_Lab3\Lab3\Form1.txt", vbNormalFocus)
    End Sub


End Class
