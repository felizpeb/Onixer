Imports System.IO
Public Class Form1
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtNomeArquivo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.txtNomeArquivo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton9 = New System.Windows.Forms.RadioButton
        Me.txtSenhas = New System.Windows.Forms.TextBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.RadioButton8 = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Yellow
        Me.ComboBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.ComboBox1.Location = New System.Drawing.Point(229, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(52, 23)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "00"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(166, 128)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(111, 24)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "Letras (Ma/Me)"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(7, 230)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(190, 26)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Números + Letras (Ma/Me)"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(7, 284)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(253, 20)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.Text = "Letras (Ma/Me) + Números + Símbolos"
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(7, 168)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(81, 20)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.Text = "Números"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(5, 594)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 22)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "GERAR AS SENHAS"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(23, 399)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Salvar"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(5, 428)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(14, 42)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "L"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(233, 594)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 22)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "SAIR"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(207, 399)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Abrir"
        '
        'txtNomeArquivo
        '
        Me.txtNomeArquivo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeArquivo.ForeColor = System.Drawing.Color.Blue
        Me.txtNomeArquivo.Location = New System.Drawing.Point(5, 370)
        Me.txtNomeArquivo.Name = "txtNomeArquivo"
        Me.txtNomeArquivo.Size = New System.Drawing.Size(276, 23)
        Me.txtNomeArquivo.TabIndex = 15
        Me.txtNomeArquivo.Text = "C:\Users\NomePC\Desktop\Senha.txt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "CAMINHO DO DIRETÓRIO"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(5, 622)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(285, 22)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "SOBRE"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(267, 428)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(14, 42)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "C"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.txtSenhas)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.txtNomeArquivo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 485)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " ONIXER SECURITY PASS (v4.0)"
        '
        'RadioButton9
        '
        Me.RadioButton9.Checked = True
        Me.RadioButton9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton9.Location = New System.Drawing.Point(166, 151)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(111, 16)
        Me.RadioButton9.TabIndex = 46
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Nenhum"
        '
        'txtSenhas
        '
        Me.txtSenhas.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenhas.ForeColor = System.Drawing.Color.Black
        Me.txtSenhas.Location = New System.Drawing.Point(22, 428)
        Me.txtSenhas.Multiline = True
        Me.txtSenhas.Name = "txtSenhas"
        Me.txtSenhas.Size = New System.Drawing.Size(242, 42)
        Me.txtSenhas.TabIndex = 45
        Me.txtSenhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Fuchsia
        Me.Button9.Location = New System.Drawing.Point(209, 166)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(69, 22)
        Me.Button9.TabIndex = 44
        Me.Button9.Text = " AJUDA? "
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Red
        Me.Button8.Location = New System.Drawing.Point(89, 399)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(111, 23)
        Me.Button8.TabIndex = 43
        Me.Button8.Text = "CRIPTOGRAFAR"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(5, 66)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(276, 42)
        Me.TextBox2.TabIndex = 42
        Me.TextBox2.Text = "ESCREVA AQUI SUA DESCRIÇÃO OU DEIXE EM BRANCO... "
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(70, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "QUANTIDADE DE CARACTERES"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(83, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 22)
        Me.TextBox1.TabIndex = 40
        Me.TextBox1.Text = "exemplo@email.com"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "EMAIL/CONTA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(121, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "EXTREMO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(203, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "SEGURO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(208, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "FORTE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(207, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "MÉDIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(34, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "FRACO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(268, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "---------------------------------------------------------------------------------" & _
            "------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(9, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(268, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "---------------------------------------------------------------------------------" & _
            "------"
        '
        'RadioButton8
        '
        Me.RadioButton8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.Location = New System.Drawing.Point(7, 212)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(163, 24)
        Me.RadioButton8.TabIndex = 28
        Me.RadioButton8.Text = "Letras (Me) + Números"
        '
        'RadioButton7
        '
        Me.RadioButton7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(7, 194)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(163, 24)
        Me.RadioButton7.TabIndex = 27
        Me.RadioButton7.Text = "Letras (Ma) + Números"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(9, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "---------------------------------------------------------------------------------" & _
            "------"
        '
        'RadioButton6
        '
        Me.RadioButton6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(7, 149)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(95, 20)
        Me.RadioButton6.TabIndex = 25
        Me.RadioButton6.Text = "Letras (Me)"
        '
        'RadioButton5
        '
        Me.RadioButton5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(7, 130)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(95, 20)
        Me.RadioButton5.TabIndex = 24
        Me.RadioButton5.Text = "Letras (Ma)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "VERIFICAÇÃO"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Crimson
        Me.ProgressBar1.ForeColor = System.Drawing.Color.HotPink
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 329)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(263, 10)
        Me.ProgressBar1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "---------------------------------------------------------------------------------" & _
            "------"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(111, 594)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "4.0 GLOBAL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.ghfgg
        Me.PictureBox1.Location = New System.Drawing.Point(-10, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 97)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(295, 648)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Opacity = 0.88
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Onixer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim ch, x, y, z As Integer
    Dim _senha, _simbolo As String


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ch = 6
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ch = 7
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ch = 8
        ElseIf ComboBox1.SelectedIndex = 3 Then
            ch = 9
        ElseIf ComboBox1.SelectedIndex = 4 Then
            ch = 10
        ElseIf ComboBox1.SelectedIndex = 5 Then
            ch = 11
        ElseIf ComboBox1.SelectedIndex = 6 Then
            ch = 12
        ElseIf ComboBox1.SelectedIndex = 7 Then
            ch = 13
        ElseIf ComboBox1.SelectedIndex = 8 Then
            ch = 14
        ElseIf ComboBox1.SelectedIndex = 9 Then
            ch = 15
        ElseIf ComboBox1.SelectedIndex = 10 Then
            ch = 16
        ElseIf ComboBox1.SelectedIndex = 11 Then
            ch = 17
        ElseIf ComboBox1.SelectedIndex = 12 Then
            ch = 18
        ElseIf ComboBox1.SelectedIndex = 13 Then
            ch = 19
        ElseIf ComboBox1.SelectedIndex = 14 Then
            ch = 20
        ElseIf ComboBox1.SelectedIndex = 15 Then
            ch = 21
        ElseIf ComboBox1.SelectedIndex = 16 Then
            ch = 22
        ElseIf ComboBox1.SelectedIndex = 17 Then
            ch = 23
        ElseIf ComboBox1.SelectedIndex = 18 Then
            ch = 24
        ElseIf ComboBox1.SelectedIndex = 19 Then
            ch = 25
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ch = 0 Then
            MessageBox.Show("Você tem que selecionar o No de Caracteres antes de Continuar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim rg As New System.Random

            If RadioButton1.Checked = True Then
                x = 0
                y = 52
            ElseIf RadioButton2.Checked = True Then
                x = 0
                y = 62
            ElseIf RadioButton3.Checked = True Then
                x = 0
                y = 72
            ElseIf RadioButton4.Checked = True Then
                x = 52
                y = 62
            ElseIf RadioButton5.Checked = True Then
                x = 0
                y = 25
            ElseIf RadioButton6.Checked = True Then
                x = 26
                y = 51
            ElseIf RadioButton7.Checked = True Then
                x = 73
                y = 108
            ElseIf RadioButton8.Checked = True Then
                x = 26
                y = 61
            ElseIf RadioButton9.Checked = True Then
                x = 109
                y = 109
            End If

            Do Until z = ch
                z += 1
                Dim rn As Integer = rg.Next(x, y)
                If rn = 0 Then
                    _simbolo = "A"
                ElseIf rn = 1 Then
                    _simbolo = "B"
                ElseIf rn = 2 Then
                    _simbolo = "C"
                ElseIf rn = 3 Then
                    _simbolo = "D"
                ElseIf rn = 4 Then
                    _simbolo = "E"
                ElseIf rn = 5 Then
                    _simbolo = "F"
                ElseIf rn = 6 Then
                    _simbolo = "G"
                ElseIf rn = 7 Then
                    _simbolo = "H"
                ElseIf rn = 8 Then
                    _simbolo = "I"
                ElseIf rn = 9 Then
                    _simbolo = "J"
                ElseIf rn = 10 Then
                    _simbolo = "K"
                ElseIf rn = 11 Then
                    _simbolo = "L"
                ElseIf rn = 12 Then
                    _simbolo = "M"
                ElseIf rn = 13 Then
                    _simbolo = "N"
                ElseIf rn = 14 Then
                    _simbolo = "O"
                ElseIf rn = 15 Then
                    _simbolo = "P"
                ElseIf rn = 16 Then
                    _simbolo = "Q"
                ElseIf rn = 17 Then
                    _simbolo = "R"
                ElseIf rn = 18 Then
                    _simbolo = "S"
                ElseIf rn = 19 Then
                    _simbolo = "T"
                ElseIf rn = 20 Then
                    _simbolo = "U"
                ElseIf rn = 21 Then
                    _simbolo = "V"
                ElseIf rn = 22 Then
                    _simbolo = "W"
                ElseIf rn = 23 Then
                    _simbolo = "X"
                ElseIf rn = 24 Then
                    _simbolo = "Y"
                ElseIf rn = 25 Then
                    _simbolo = "Z"
                ElseIf rn = 26 Then
                    _simbolo = "a"
                ElseIf rn = 27 Then
                    _simbolo = "b"
                ElseIf rn = 28 Then
                    _simbolo = "c"
                ElseIf rn = 29 Then
                    _simbolo = "d"
                ElseIf rn = 30 Then
                    _simbolo = "e"
                ElseIf rn = 31 Then
                    _simbolo = "f"
                ElseIf rn = 32 Then
                    _simbolo = "g"
                ElseIf rn = 33 Then
                    _simbolo = "h"
                ElseIf rn = 34 Then
                    _simbolo = "i"
                ElseIf rn = 35 Then
                    _simbolo = "j"
                ElseIf rn = 36 Then
                    _simbolo = "k"
                ElseIf rn = 37 Then
                    _simbolo = "l"
                ElseIf rn = 38 Then
                    _simbolo = "m"
                ElseIf rn = 39 Then
                    _simbolo = "n"
                ElseIf rn = 40 Then
                    _simbolo = "o"
                ElseIf rn = 41 Then
                    _simbolo = "p"
                ElseIf rn = 42 Then
                    _simbolo = "q"
                ElseIf rn = 43 Then
                    _simbolo = "r"
                ElseIf rn = 44 Then
                    _simbolo = "s"
                ElseIf rn = 45 Then
                    _simbolo = "t"
                ElseIf rn = 46 Then
                    _simbolo = "u"
                ElseIf rn = 47 Then
                    _simbolo = "v"
                ElseIf rn = 48 Then
                    _simbolo = "w"
                ElseIf rn = 49 Then
                    _simbolo = "x"
                ElseIf rn = 50 Then
                    _simbolo = "y"
                ElseIf rn = 51 Then
                    _simbolo = "z"
                ElseIf rn = 52 Then
                    _simbolo = "0"
                ElseIf rn = 53 Then
                    _simbolo = "1"
                ElseIf rn = 54 Then
                    _simbolo = "2"
                ElseIf rn = 55 Then
                    _simbolo = "3"
                ElseIf rn = 56 Then
                    _simbolo = "4"
                ElseIf rn = 57 Then
                    _simbolo = "5"
                ElseIf rn = 58 Then
                    _simbolo = "6"
                ElseIf rn = 59 Then
                    _simbolo = "7"
                ElseIf rn = 60 Then
                    _simbolo = "8"
                ElseIf rn = 61 Then
                    _simbolo = "9"
                ElseIf rn = 62 Then
                    _simbolo = "!"
                ElseIf rn = 63 Then
                    _simbolo = "@"
                ElseIf rn = 64 Then
                    _simbolo = "#"
                ElseIf rn = 65 Then
                    _simbolo = "$"
                ElseIf rn = 66 Then
                    _simbolo = "%"
                ElseIf rn = 67 Then
                    _simbolo = "&"
                ElseIf rn = 68 Then
                    _simbolo = "*"
                ElseIf rn = 69 Then
                    _simbolo = "/"
                ElseIf rn = 70 Then
                    _simbolo = "?"
                ElseIf rn = 71 Then
                    _simbolo = "<"
                ElseIf rn = 72 Then
                    _simbolo = ">"
                ElseIf rn = 73 Then
                    _simbolo = "A"
                ElseIf rn = 74 Then
                    _simbolo = "B"
                ElseIf rn = 75 Then
                    _simbolo = "C"
                ElseIf rn = 76 Then
                    _simbolo = "D"
                ElseIf rn = 77 Then
                    _simbolo = "E"
                ElseIf rn = 78 Then
                    _simbolo = "F"
                ElseIf rn = 79 Then
                    _simbolo = "G"
                ElseIf rn = 80 Then
                    _simbolo = "H"
                ElseIf rn = 81 Then
                    _simbolo = "I"
                ElseIf rn = 82 Then
                    _simbolo = "J"
                ElseIf rn = 83 Then
                    _simbolo = "K"
                ElseIf rn = 84 Then
                    _simbolo = "L"
                ElseIf rn = 85 Then
                    _simbolo = "M"
                ElseIf rn = 86 Then
                    _simbolo = "N"
                ElseIf rn = 87 Then
                    _simbolo = "O"
                ElseIf rn = 88 Then
                    _simbolo = "P"
                ElseIf rn = 89 Then
                    _simbolo = "Q"
                ElseIf rn = 90 Then
                    _simbolo = "R"
                ElseIf rn = 91 Then
                    _simbolo = "S"
                ElseIf rn = 92 Then
                    _simbolo = "T"
                ElseIf rn = 93 Then
                    _simbolo = "U"
                ElseIf rn = 94 Then
                    _simbolo = "V"
                ElseIf rn = 95 Then
                    _simbolo = "W"
                ElseIf rn = 96 Then
                    _simbolo = "X"
                ElseIf rn = 97 Then
                    _simbolo = "Y"
                ElseIf rn = 98 Then
                    _simbolo = "Z"
                ElseIf rn = 99 Then
                    _simbolo = "0"
                ElseIf rn = 100 Then
                    _simbolo = "1"
                ElseIf rn = 101 Then
                    _simbolo = "2"
                ElseIf rn = 102 Then
                    _simbolo = "3"
                ElseIf rn = 103 Then
                    _simbolo = "4"
                ElseIf rn = 104 Then
                    _simbolo = "5"
                ElseIf rn = 105 Then
                    _simbolo = "6"
                ElseIf rn = 106 Then
                    _simbolo = "7"
                ElseIf rn = 107 Then
                    _simbolo = "8"
                ElseIf rn = 108 Then
                    _simbolo = "9"
                ElseIf rn = 109 Then
                    _simbolo = ""
                End If
                txtSenhas.Text = _simbolo + txtSenhas.Text
            Loop
            z = 0
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtSenhas.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'SALVANDO O ARQUIVO
        Dim path As String = ""

        If Not String.IsNullOrEmpty(txtNomeArquivo.Text) Then
            path = txtNomeArquivo.Text
        Else
            MessageBox.Show("Informe o nome e local do arquivo de senhas.")
        End If

        Try
            Dim stream As New FileStream(path, FileMode.Append, FileAccess.Write)
            Dim write As New StreamWriter(stream)
            write.WriteLine("* ------------------------ ONIXER ------------------------ *")
            write.WriteLine(Date.Now)
            write.WriteLine(" ")
            write.WriteLine(("Conta: ") & TextBox1.Text)
            write.WriteLine(" ")
            write.WriteLine(("Senha: ") & txtSenhas.Text)
            write.WriteLine(" ")
            write.WriteLine(("Descrição: ") & TextBox2.Text)
            write.WriteLine("* -------------------------------------------------------- *")
            write.WriteLine(vbNewLine)
            write.Close()
            MessageBox.Show("Foi salvo um arquivo em :  " & path, "Arquivo Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSenhas.Clear()
        Catch ex As Exception
            MessageBox.Show("Erro : " + ex.Message)
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Dim fluxoTexto As IO.StreamReader = Nothing
        If IO.File.Exists(txtNomeArquivo.Text) Then
            Try
                fluxoTexto = New IO.StreamReader(txtNomeArquivo.Text)
                txtSenhas.Text = fluxoTexto.ReadToEnd
            Catch ex As Exception
                MessageBox.Show("Erro : " + ex.Message)
            Finally
                fluxoTexto.Close()
            End Try
        Else
            MessageBox.Show("Arquivo não existe")
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Timer1.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Increment(4)
    End Sub


    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        Timer1.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Increment(25)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        frmMain.Show()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form3.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Timer1.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Increment(5)

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Timer1.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Increment(2)
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        Timer1.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Increment(30)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Timer1.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Increment(50)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Timer1.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Increment(100)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Timer1.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Increment(40)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        My.Computer.Clipboard.SetText(txtSenhas.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form2.Show()

    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        Timer1.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Increment(0)
    End Sub
End Class
