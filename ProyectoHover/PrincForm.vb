Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input
Imports System.IO.Ports

Public Class PrincForm

    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Short

    Dim dir As Integer
    Dim acc As Integer

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

            sp.Write("888")
            Me.TrackBar1.Value = 40
            Me.TrackBar2.Value = 30
            Me.Timer1.Start()
            GamePad.SetVibration(PlayerIndex.One, 1, 1)
            System.Threading.Thread.Sleep(300)
            GamePad.SetVibration(PlayerIndex.One, 0, 0)



        End If
    End Sub

    Private Sub apagar()
        If sp.IsOpen = True Then
            Me.Timer1.Stop()
            sp.Write("999")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        actualizaVals()
        seteaPuerto()
        If sp.IsOpen = False Then sp.Open()
        Button1.Enabled = False


    End Sub

    Private Sub seteaPuerto()

        sp.BaudRate = 57600
        sp.PortName = ComboBox1.SelectedItem.ToString
        sp.DataBits = 8
        sp.Parity = Parity.None
        sp.StopBits = StopBits.One
        sp.Handshake = Handshake.None

        AddHandler sp.DataReceived, AddressOf sp_DataReceived



    End Sub

    Private Sub escribeVals()
        If sp.IsOpen = True Then
            sp.Write(TrackBar1.Value.ToString + "," + TrackBar2.Value.ToString + "," + TrackBar3.Value.ToString)
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

        If GamePad.GetState(PlayerIndex.One).IsConnected = True Then Label2.Text = "Conectado"

        If GamePad.GetState(PlayerIndex.One).Triggers.Right.ToString = "1" Then If TrackBar1.Value < 180 Then TrackBar1.Value += 10
        If GamePad.GetState(PlayerIndex.One).Triggers.Left.ToString = "1" Then If TrackBar1.Value > 0 Then TrackBar1.Value -= 10

        dir = GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.X.ToString("0.000") * 90 + 90
        acc = Math.Sqrt(Math.Pow((((GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.Y.ToString("0.000") * 90 + 90) - 90) * 2), 2))
        GamePad.GetState(PlayerIndex.One).Triggers.Right.ToString()

        TrackBar2.Value = acc
        TrackBar3.Value = dir

        Label1.Text = dir.ToString + acc.ToString

        If sp.IsOpen = True Then
            escribeVals()
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
End Class