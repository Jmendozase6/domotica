Imports System.IO.Ports

Public Class SmartHomeControl
    Private Sub CasaInteligente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With SerialPort1
                .PortName = "COM4" ' Ajusta según el puerto disponible
                .BaudRate = 9600 ' Cambia según las especificaciones de tu dispositivo
            End With
            SerialPort1.Open()
            TurnOffAllLights()
        Catch ex As Exception
            MessageBox.Show("Error al abrir el puerto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Led 1 '
    Private Sub GarageBtn_Click(sender As Object, e As EventArgs) Handles GarageBtn.Click
        If GarageBtn.ForeColor = Color.White Then
            GarageBtn.ForeColor = Color.Red
            SerialPort1.Write("a")
        Else
            GarageBtn.ForeColor = Color.White
            SerialPort1.Write("b")
        End If
    End Sub

    ' Led 2 '
    Private Sub LaundryBtn_Click(sender As Object, e As EventArgs) Handles LaundryBtn.Click
        If LaundryBtn.ForeColor = Color.White Then
            LaundryBtn.ForeColor = Color.Red
            SerialPort1.Write("c")
        Else
            LaundryBtn.ForeColor = Color.White
            SerialPort1.Write("d")
        End If
    End Sub

    ' Led 3 '
    Private Sub PoolBtn_Click(sender As Object, e As EventArgs) Handles PoolBtn.Click
        If PoolBtn.ForeColor = Color.White Then
            PoolBtn.ForeColor = Color.Red
            SerialPort1.Write("e")
        Else
            PoolBtn.ForeColor = Color.White
            SerialPort1.Write("f")
        End If
    End Sub

    ' Led 4 '
    Private Sub RelaxBtn_Click(sender As Object, e As EventArgs) Handles RelaxBtn.Click
        If RelaxBtn.ForeColor = Color.White Then
            RelaxBtn.ForeColor = Color.Red
            SerialPort1.Write("g")
        Else
            RelaxBtn.ForeColor = Color.White
            SerialPort1.Write("h")
        End If
    End Sub

    ' Led 5 '
    Private Sub Room1Btn_Click(sender As Object, e As EventArgs) Handles Room1Btn.Click
        If Room1Btn.ForeColor = Color.White Then
            Room1Btn.ForeColor = Color.Red
            SerialPort1.Write("i")
        Else
            Room1Btn.ForeColor = Color.White
            SerialPort1.Write("j")
        End If
    End Sub

    ' Led 6 '
    Private Sub Room2Btn_Click(sender As Object, e As EventArgs) Handles Room2Btn.Click
        If Room2Btn.ForeColor = Color.White Then
            Room2Btn.ForeColor = Color.Red
            SerialPort1.Write("k")
        Else
            Room2Btn.ForeColor = Color.White
            SerialPort1.Write("l")
        End If
    End Sub

    ' Led 7 '
    Private Sub Room3Btn_Click(sender As Object, e As EventArgs) Handles Room3Btn.Click
        If Room3Btn.ForeColor = Color.White Then
            Room3Btn.ForeColor = Color.Red
            SerialPort1.Write("m")
        Else
            Room3Btn.ForeColor = Color.White
            SerialPort1.Write("n")
        End If
    End Sub

    ' Led 8 '
    Private Sub LivingBtn_Click(sender As Object, e As EventArgs) Handles LivingBtn.Click
        If LivingBtn.ForeColor = Color.White Then
            LivingBtn.ForeColor = Color.Red
            SerialPort1.Write("o")
        Else
            LivingBtn.ForeColor = Color.White
            SerialPort1.Write("p")
        End If
    End Sub

    ' Led 9 '
    Private Sub KitchenBtn_Click(sender As Object, e As EventArgs) Handles KitchenBtn.Click
        If KitchenBtn.ForeColor = Color.White Then
            KitchenBtn.ForeColor = Color.Red
            SerialPort1.Write("q")
        Else
            KitchenBtn.ForeColor = Color.White
            SerialPort1.Write("r")
        End If
    End Sub

    ' Led 10 '
    Private Sub DoorBtn_Click(sender As Object, e As EventArgs) Handles DoorBtn.Click
        If DoorBtn.ForeColor = Color.White Then
            DoorBtn.ForeColor = Color.Red
            SerialPort1.Write("s")
        Else
            DoorBtn.ForeColor = Color.White
            SerialPort1.Write("t")
        End If
    End Sub

    ' Llamar a la función para encender todos los leds y el ventilador '
    Private Sub AllOnBtn_Click(sender As Object, e As EventArgs) Handles AllOnBtn.Click
        TurnOnAllLights()
    End Sub

    ' Llamar a la función para apagar todos los leds y el ventilador '
    Private Sub AllOfBtn_Click(sender As Object, e As EventArgs) Handles AllOfBtn.Click
        TurnOffAllLights()
    End Sub

    ' Encender todos los leds y el ventilador '
    Private Sub TurnOnAllLights()
        GarageBtn.ForeColor = Color.Red
        SerialPort1.Write("a")
        LaundryBtn.ForeColor = Color.Red
        SerialPort1.Write("c")
        PoolBtn.ForeColor = Color.Red
        SerialPort1.Write("e")
        RelaxBtn.ForeColor = Color.Red
        SerialPort1.Write("g")
        Room1Btn.ForeColor = Color.Red
        SerialPort1.Write("i")
        Room2Btn.ForeColor = Color.Red
        SerialPort1.Write("k")
        Room3Btn.ForeColor = Color.Red
        SerialPort1.Write("m")
        LivingBtn.ForeColor = Color.Red
        SerialPort1.Write("o")
        KitchenBtn.ForeColor = Color.Red
        SerialPort1.Write("q")
        DoorBtn.ForeColor = Color.Red
        SerialPort1.Write("s")
        AllOfBtn.Enabled = True
        AllOnBtn.Enabled = False
    End Sub

    ' Apagar todos los leds y el ventilador '
    Private Sub TurnOffAllLights()
        GarageBtn.ForeColor = Color.White
        SerialPort1.Write("b")
        LaundryBtn.ForeColor = Color.White
        SerialPort1.Write("d")
        PoolBtn.ForeColor = Color.White
        SerialPort1.Write("f")
        RelaxBtn.ForeColor = Color.White
        SerialPort1.Write("h")
        Room1Btn.ForeColor = Color.White
        SerialPort1.Write("j")
        Room2Btn.ForeColor = Color.White
        SerialPort1.Write("l")
        Room3Btn.ForeColor = Color.White
        SerialPort1.Write("n")
        LivingBtn.ForeColor = Color.White
        SerialPort1.Write("p")
        KitchenBtn.ForeColor = Color.White
        SerialPort1.Write("r")
        DoorBtn.ForeColor = Color.White
        SerialPort1.Write("t")
        AllOfBtn.Enabled = False
        AllOnBtn.Enabled = True
    End Sub

End Class