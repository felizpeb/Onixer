Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents pbStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnChangeDecrypt As System.Windows.Forms.Button
    Friend WithEvents txtDestinationDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtConPassDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtPassDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtFileToDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents btnBrowseDecrypt As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnChangeEncrypt As System.Windows.Forms.Button
    Friend WithEvents txtDestinationEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtConPassEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtPassEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtFileToEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseEncrypt As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pbStatus = New System.Windows.Forms.ProgressBar
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnChangeDecrypt = New System.Windows.Forms.Button
        Me.txtDestinationDecrypt = New System.Windows.Forms.TextBox
        Me.txtConPassDecrypt = New System.Windows.Forms.TextBox
        Me.txtPassDecrypt = New System.Windows.Forms.TextBox
        Me.txtFileToDecrypt = New System.Windows.Forms.TextBox
        Me.btnDecrypt = New System.Windows.Forms.Button
        Me.btnBrowseDecrypt = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnChangeEncrypt = New System.Windows.Forms.Button
        Me.txtDestinationEncrypt = New System.Windows.Forms.TextBox
        Me.txtConPassEncrypt = New System.Windows.Forms.TextBox
        Me.txtPassEncrypt = New System.Windows.Forms.TextBox
        Me.txtFileToEncrypt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnEncrypt = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnBrowseEncrypt = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbStatus
        '
        Me.pbStatus.ForeColor = System.Drawing.Color.Red
        Me.pbStatus.Location = New System.Drawing.Point(4, 154)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(410, 10)
        Me.pbStatus.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.btnChangeDecrypt)
        Me.TabPage2.Controls.Add(Me.txtDestinationDecrypt)
        Me.TabPage2.Controls.Add(Me.txtConPassDecrypt)
        Me.TabPage2.Controls.Add(Me.txtPassDecrypt)
        Me.TabPage2.Controls.Add(Me.txtFileToDecrypt)
        Me.TabPage2.Controls.Add(Me.btnDecrypt)
        Me.TabPage2.Controls.Add(Me.btnBrowseDecrypt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(406, 122)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decrypt File"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Confirme:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Senha:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Destino:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Arquivo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnChangeDecrypt
        '
        Me.btnChangeDecrypt.Enabled = False
        Me.btnChangeDecrypt.Location = New System.Drawing.Point(294, 32)
        Me.btnChangeDecrypt.Name = "btnChangeDecrypt"
        Me.btnChangeDecrypt.Size = New System.Drawing.Size(86, 20)
        Me.btnChangeDecrypt.TabIndex = 22
        Me.btnChangeDecrypt.Text = "Alterar"
        '
        'txtDestinationDecrypt
        '
        Me.txtDestinationDecrypt.Location = New System.Drawing.Point(104, 32)
        Me.txtDestinationDecrypt.Name = "txtDestinationDecrypt"
        Me.txtDestinationDecrypt.ReadOnly = True
        Me.txtDestinationDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtDestinationDecrypt.TabIndex = 21
        '
        'txtConPassDecrypt
        '
        Me.txtConPassDecrypt.Location = New System.Drawing.Point(104, 87)
        Me.txtConPassDecrypt.Name = "txtConPassDecrypt"
        Me.txtConPassDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtConPassDecrypt.TabIndex = 18
        '
        'txtPassDecrypt
        '
        Me.txtPassDecrypt.Location = New System.Drawing.Point(104, 63)
        Me.txtPassDecrypt.Name = "txtPassDecrypt"
        Me.txtPassDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtPassDecrypt.TabIndex = 17
        '
        'txtFileToDecrypt
        '
        Me.txtFileToDecrypt.Location = New System.Drawing.Point(104, 8)
        Me.txtFileToDecrypt.Name = "txtFileToDecrypt"
        Me.txtFileToDecrypt.ReadOnly = True
        Me.txtFileToDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtFileToDecrypt.TabIndex = 12
        Me.txtFileToDecrypt.Text = "Clique no Browser para carregar."
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Enabled = False
        Me.btnDecrypt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDecrypt.Location = New System.Drawing.Point(294, 87)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(102, 21)
        Me.btnDecrypt.TabIndex = 19
        Me.btnDecrypt.Text = "DECRYPT"
        '
        'btnBrowseDecrypt
        '
        Me.btnBrowseDecrypt.Location = New System.Drawing.Point(294, 8)
        Me.btnBrowseDecrypt.Name = "btnBrowseDecrypt"
        Me.btnBrowseDecrypt.Size = New System.Drawing.Size(86, 20)
        Me.btnBrowseDecrypt.TabIndex = 13
        Me.btnBrowseDecrypt.Text = "Browse"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.btnChangeEncrypt)
        Me.TabPage1.Controls.Add(Me.txtDestinationEncrypt)
        Me.TabPage1.Controls.Add(Me.txtConPassEncrypt)
        Me.TabPage1.Controls.Add(Me.txtPassEncrypt)
        Me.TabPage1.Controls.Add(Me.txtFileToEncrypt)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnEncrypt)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnBrowseEncrypt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(406, 122)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encrypt File"
        '
        'btnChangeEncrypt
        '
        Me.btnChangeEncrypt.Enabled = False
        Me.btnChangeEncrypt.Location = New System.Drawing.Point(294, 32)
        Me.btnChangeEncrypt.Name = "btnChangeEncrypt"
        Me.btnChangeEncrypt.Size = New System.Drawing.Size(86, 20)
        Me.btnChangeEncrypt.TabIndex = 11
        Me.btnChangeEncrypt.Text = "Alterar"
        '
        'txtDestinationEncrypt
        '
        Me.txtDestinationEncrypt.Location = New System.Drawing.Point(104, 32)
        Me.txtDestinationEncrypt.Name = "txtDestinationEncrypt"
        Me.txtDestinationEncrypt.ReadOnly = True
        Me.txtDestinationEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtDestinationEncrypt.TabIndex = 10
        '
        'txtConPassEncrypt
        '
        Me.txtConPassEncrypt.Location = New System.Drawing.Point(104, 87)
        Me.txtConPassEncrypt.Name = "txtConPassEncrypt"
        Me.txtConPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtConPassEncrypt.TabIndex = 7
        '
        'txtPassEncrypt
        '
        Me.txtPassEncrypt.Location = New System.Drawing.Point(104, 63)
        Me.txtPassEncrypt.Name = "txtPassEncrypt"
        Me.txtPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtPassEncrypt.TabIndex = 6
        '
        'txtFileToEncrypt
        '
        Me.txtFileToEncrypt.Location = New System.Drawing.Point(104, 8)
        Me.txtFileToEncrypt.Name = "txtFileToEncrypt"
        Me.txtFileToEncrypt.ReadOnly = True
        Me.txtFileToEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtFileToEncrypt.TabIndex = 1
        Me.txtFileToEncrypt.Text = "Clique no Browser para carregar."
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Destino:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Enabled = False
        Me.btnEncrypt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEncrypt.Location = New System.Drawing.Point(294, 87)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(102, 21)
        Me.btnEncrypt.TabIndex = 8
        Me.btnEncrypt.Text = "ENCRYPT"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Arquivo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-8, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Confirme:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBrowseEncrypt
        '
        Me.btnBrowseEncrypt.Location = New System.Drawing.Point(294, 8)
        Me.btnBrowseEncrypt.Name = "btnBrowseEncrypt"
        Me.btnBrowseEncrypt.Size = New System.Drawing.Size(86, 20)
        Me.btnBrowseEncrypt.TabIndex = 2
        Me.btnBrowseEncrypt.Text = "Browse"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(4, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(414, 148)
        Me.TabControl1.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(420, 173)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Opacity = 0.88
        Me.Text = "Criptografia Onixer"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "1. Global Variables "

    '*************************
    '** Global Variables
    '*************************

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream

#End Region


#Region "2. Create A Key "

    '*************************
    '** Create A Key
    '*************************

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function

#End Region


#Region "3. Create An IV "

    '*************************
    '** Create An IV
    '*************************

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of 
        'bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
        'of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'return the IV
    End Function

#End Region


#Region "4. Encrypt / Decrypt File "

    '****************************
    '** Encrypt/Decrypt File
    '****************************

    Private Enum CryptoAction
        'Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String, _
                                     ByVal strOutputFile As String, _
                                     ByVal bytKey() As Byte, _
                                     ByVal bytIV() As Byte, _
                                     ByVal Direction As CryptoAction)
        Try 'In case of errors.

            'Setup file streams to handle input and output.
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, _
                                               FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, _
                                                FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim ACryptoStream As CryptoStream
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            'Setup Progress Bar
            pbStatus.Value = 0
            pbStatus.Maximum = 100

            'Determine if ecryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    ACryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateEncryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    ACryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateDecryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)
            End Select

            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Write output file with the cryptostream.
                ACryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
                pbStatus.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
            End While

            'Close FileStreams and CryptoStream.
            ACryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            'If encrypting then delete the original unencrypted file.
            If Direction = CryptoAction.ActionEncrypt Then
                Dim fileOriginal As New FileInfo(strFileToEncrypt)
                fileOriginal.Delete()
            End If

            'If decrypting then delete the encrypted file.
            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                fileEncrypted.Delete()
            End If

            'Update the user when the file is done.
            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then
                MsgBox("Encryption Complete" + Wrap + Wrap + _
                        "Total bytes processed = " + _
                        lngBytesProcessed.ToString, _
                        MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.
                pbStatus.Value = 0
                txtFileToEncrypt.Text = "Click Browse to load file."
                txtPassEncrypt.Text = ""
                txtConPassEncrypt.Text = ""
                txtDestinationEncrypt.Text = ""
                btnChangeEncrypt.Enabled = False
                btnEncrypt.Enabled = False

            Else
                'Update the user when the file is done.
                MsgBox("Decryption Complete" + Wrap + Wrap + _
                       "Total bytes processed = " + _
                        lngBytesProcessed.ToString, _
                        MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.
                pbStatus.Value = 0
                txtFileToDecrypt.Text = "Click Browse to load file."
                txtPassDecrypt.Text = ""
                txtConPassDecrypt.Text = ""
                txtDestinationDecrypt.Text = ""
                btnChangeDecrypt.Enabled = False
                btnDecrypt.Enabled = False
            End If


            'Catch file not found error.
        Catch When Err.Number = 53 'if file not found
            MsgBox("Please check to make sure the path and filename" + _
                    "are correct and if the file exists.", _
                     MsgBoxStyle.Exclamation, "Invalid Path or Filename")

            'Catch all other errors. And delete partial files.
        Catch
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(txtDestinationDecrypt.Text)
                fileDelete.Delete()
                pbStatus.Value = 0
                txtPassDecrypt.Text = ""
                txtConPassDecrypt.Text = ""

                MsgBox("Please check to make sure that you entered the correct" + _
                        "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            Else
                Dim fileDelete As New FileInfo(txtDestinationEncrypt.Text)
                fileDelete.Delete()

                pbStatus.Value = 0
                txtPassEncrypt.Text = ""
                txtConPassEncrypt.Text = ""

                MsgBox("This file cannot be encrypted.", _
                        MsgBoxStyle.Exclamation, "Invalid File")

            End If

        End Try
    End Sub

#End Region


#Region "5. Browse / Change Button "

    '******************************
    '** Browse/Change Buttons
    '******************************

    Private Sub btnBrowseEncrypt_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) Handles btnBrowseEncrypt.Click

        'Setup the open dialog.
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to encrypt"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "All Files (*.*) | *.*"

        'Find out if the user chose a file.
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFileToEncrypt = OpenFileDialog.FileName
            txtFileToEncrypt.Text = strFileToEncrypt

            Dim iPosition As Integer = 0
            Dim i As Integer = 0

            'Get the position of the last "\" in the OpenFileDialog.FileName path.
            '-1 is when the character your searching for is not there.
            'IndexOf searches from left to right.
            While strFileToEncrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToEncrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            'Assign strOutputFile to the position after the last "\" in the path.
            'This position is the beginning of the file name.
            strOutputEncrypt = strFileToEncrypt.Substring(iPosition + 1)
            'Assign S the entire path, ending at the last "\".
            Dim S As String = strFileToEncrypt.Substring(0, iPosition + 1)
            'Replace the "." in the file extension with "_".
            strOutputEncrypt = strOutputEncrypt.Replace("."c, "_"c)
            'The final file name.  XXXXX.encrypt
            txtDestinationEncrypt.Text = S + strOutputEncrypt + ".encrypt"
            'Update buttons.
            btnEncrypt.Enabled = True
            btnChangeEncrypt.Enabled = True

        End If

    End Sub

    Private Sub btnBrowseDecrypt_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) Handles btnBrowseDecrypt.Click

        'Setup the open dialog.
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to decrypt"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "Encrypted Files (*.encrypt) | *.encrypt"

        'Find out if the user chose a file.
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFileToDecrypt = OpenFileDialog.FileName
            txtFileToDecrypt.Text = strFileToDecrypt
            Dim iPosition As Integer = 0
            Dim i As Integer = 0
            'Get the position of the last "\" in the OpenFileDialog.FileName path.
            '-1 is when the character your searching for is not there.
            'IndexOf searches from left to right.

            While strFileToDecrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToDecrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            'strOutputFile = the file path minus the last 8 characters (.encrypt)
            strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8)
            'Assign S the entire path, ending at the last "\".
            Dim S As String = strFileToDecrypt.Substring(0, iPosition + 1)
            'Assign strOutputFile to the position after the last "\" in the path.
            strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1))
            'Replace "_" with "."
            txtDestinationDecrypt.Text = S + strOutputDecrypt.Replace("_"c, "."c)
            'Update buttons
            btnDecrypt.Enabled = True
            btnChangeDecrypt.Enabled = True

        End If
    End Sub

    Private Sub btnChangeEncrypt_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) Handles btnChangeEncrypt.Click

        'Setup up folder browser.
        FolderBrowserDialog.Description = "Select a folder to place the encrypted file in."
        'If the user selected a folder assign the path to txtDestinationEncrypt.
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            txtDestinationEncrypt.Text = FolderBrowserDialog.SelectedPath + _
                                         "\" + strOutputEncrypt + ".encrypt"
        End If
    End Sub

    Private Sub btnChangeDecrypt_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) Handles btnChangeDecrypt.Click

        'Setup up folder browser.
        FolderBrowserDialog.Description = "Select a folder for to place the decrypted file in."
        'If the user selected a folder assign the path to txtDestinationDecrypt.
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            txtDestinationDecrypt.Text = FolderBrowserDialog.SelectedPath + _
                                         "\" + strOutputDecrypt.Replace("_"c, "."c)
        End If
    End Sub

#End Region


#Region "6. Encrypt / Decrypt Buttons "

    '******************************
    '** Encrypt/Decrypt Buttons
    '******************************

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) Handles btnEncrypt.Click

        'Make sure the password is correct.
        If txtConPassEncrypt.Text = txtPassEncrypt.Text Then
            'Declare variables for the key and iv.
            'The key needs to hold 256 bits and the iv 128 bits.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(txtPassEncrypt.Text)
            'Send the password to the CreateIV function.
            bytIV = CreateIV(txtPassEncrypt.Text)
            'Start the encryption.
            EncryptOrDecryptFile(strFileToEncrypt, txtDestinationEncrypt.Text, _
                                 bytKey, bytIV, CryptoAction.ActionEncrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            txtPassEncrypt.Text = ""
            txtConPassEncrypt.Text = ""
        End If
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) Handles btnDecrypt.Click

        'Make sure the password is correct.
        If txtConPassDecrypt.Text = txtPassDecrypt.Text Then
            'Declare variables for the key and iv.
            'The key needs to hold 256 bits and the iv 128 bits.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(txtPassDecrypt.Text)
            'Send the password to the CreateIV function.
            bytIV = CreateIV(txtPassDecrypt.Text)
            'Start the decryption.
            EncryptOrDecryptFile(strFileToDecrypt, txtDestinationDecrypt.Text, _
                                 bytKey, bytIV, CryptoAction.ActionDecrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            txtPassDecrypt.Text = ""
            txtConPassDecrypt.Text = ""
        End If
    End Sub

#End Region




    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub pbStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStatus.Click

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
