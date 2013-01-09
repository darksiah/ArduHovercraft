Imports System.IO.Ports


Public Class PrincForm

    Dim sp As SerialPort = New SerialPort

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        actualizaVals()
        ' escribeVals()
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.ValueChanged
        actualizaVals()
        'escribeVals()
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.ValueChanged
        actualizaVals()
        'escribeVals()
    End Sub

    Private Sub actualizaVals()

        ValPrinc.Text = TrackBar1.Value
        ValTro.Text = TrackBar2.Value
        Valdire.Text = TrackBar3.Value

    End Sub

    Private Sub encender()
        If sp.IsOpen = True Then
            sp.WriteLine("888")
        End If
    End Sub

    Private Sub apagar()
        If sp.IsOpen = True Then
            sp.WriteLine("999")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        actualizaVals()
        seteaPuerto()
        If sp.IsOpen = False Then sp.Open()
        Button1.Enabled = False


    End Sub

    Private Sub seteaPuerto()

        sp.BaudRate = 9600
        sp.PortName = ComboBox1.SelectedItem.ToString
        sp.DataBits = 8
        sp.Parity = Parity.None
        sp.StopBits = StopBits.One
        sp.Handshake = Handshake.None

        AddHandler sp.DataReceived, AddressOf sp_DataReceived
        Timer1.Start()



    End Sub

    Private Sub escribeVals()
        If sp.IsOpen = True Then
            sp.WriteLine(TrackBar1.Value.ToString + "," + TrackBar2.Value.ToString + "," + TrackBar3.Value.ToString)
        End If
    End Sub

    Private Sub listarPuertos()

        For Each puerto As String In System.IO.Ports.SerialPort.GetPortNames
            ComboBox1.Items.Add(puerto)
        Next

    End Sub


    Private Sub PrincForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Me.TrackBar3.Value = 90
        Me.TrackBar1.Focus()
        listarPuertos()
        ComboBox1.SelectedIndex = 0



    End Sub

    Private Sub sp_DataReceived(sender As Object, e As SerialDataReceivedEventArgs)

        TextBox1.AppendText(sp.ReadExisting())

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sp.IsOpen = True Then
            escribeVals()
            Label1.Text = TrackBar1.Value.ToString + "," + TrackBar2.Value.ToString + "," + TrackBar3.Value.ToString + ","
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        sp.Close()
        Button1.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox1.Text = ""

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        apagar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        encender()
    End Sub


    Private Sub PrincForm_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.W Then
            If TrackBar2.Value < 180 Then TrackBar2.Value += 10
        End If

        If e.KeyCode = Windows.Forms.Keys.S Then
            If TrackBar2.Value > 0 Then TrackBar2.Value -= 10
        End If

        If e.KeyCode = Windows.Forms.Keys.D Then
            If TrackBar3.Value < 180 Then TrackBar3.Value += 10
        End If

        If e.KeyCode = Windows.Forms.Keys.A Then
            If TrackBar3.Value > 0 Then TrackBar3.Value -= 10

        End If

        If e.KeyCode = Windows.Forms.Keys.F5 Then
            TrackBar1.Value = 20

        End If

        If e.KeyCode = Windows.Forms.Keys.F6 Then
            TrackBar1.Value = 40

        End If

        If e.KeyCode = Windows.Forms.Keys.F7 Then
            TrackBar1.Value = 60

        End If

        If e.KeyCode = Windows.Forms.Keys.F8 Then
            TrackBar1.Value = 80

        End If

        If e.KeyCode = Windows.Forms.Keys.F9 Then
            TrackBar1.Value = 100
        End If

        If e.KeyCode = Windows.Forms.Keys.F12 Then
            encender()
        End If

        If e.KeyCode = Windows.Forms.Keys.F11 Then
            apagar()
        End If

    End Sub

    Private Sub PrincForm_KeyUp(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        If e.KeyCode = Windows.Forms.Keys.W Then
            TrackBar2.Value = 0
        End If

        If e.KeyCode = Windows.Forms.Keys.S Then
            TrackBar2.Value = 0
        End If

        If e.KeyCode = Windows.Forms.Keys.D Then
            TrackBar3.Value = 90
        End If

        If e.KeyCode = Windows.Forms.Keys.A Then
            TrackBar3.Value = 90
        End If
    End Sub
End Class