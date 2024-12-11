<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SmartHomeControl
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SmartHomeControl))
        Me.GarageBtn = New System.Windows.Forms.Button()
        Me.LaundryBtn = New System.Windows.Forms.Button()
        Me.PoolBtn = New System.Windows.Forms.Button()
        Me.RelaxBtn = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Room1Btn = New System.Windows.Forms.Button()
        Me.Room2Btn = New System.Windows.Forms.Button()
        Me.Room3Btn = New System.Windows.Forms.Button()
        Me.LivingBtn = New System.Windows.Forms.Button()
        Me.KitchenBtn = New System.Windows.Forms.Button()
        Me.DoorBtn = New System.Windows.Forms.Button()
        Me.AllOnBtn = New System.Windows.Forms.Button()
        Me.AllOfBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GarageBtn
        '
        Me.GarageBtn.BackColor = System.Drawing.Color.Transparent
        Me.GarageBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.GarageBtn.FlatAppearance.BorderSize = 0
        Me.GarageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.GarageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.GarageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GarageBtn.Font = New System.Drawing.Font("Poppins", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GarageBtn.ForeColor = System.Drawing.Color.White
        Me.GarageBtn.Location = New System.Drawing.Point(80, 3)
        Me.GarageBtn.Name = "GarageBtn"
        Me.GarageBtn.Size = New System.Drawing.Size(257, 63)
        Me.GarageBtn.TabIndex = 0
        Me.GarageBtn.Text = "Cochera"
        Me.GarageBtn.UseVisualStyleBackColor = False
        '
        'LaundryBtn
        '
        Me.LaundryBtn.BackColor = System.Drawing.Color.Transparent
        Me.LaundryBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.LaundryBtn.FlatAppearance.BorderSize = 0
        Me.LaundryBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.LaundryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.LaundryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.LaundryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaundryBtn.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaundryBtn.ForeColor = System.Drawing.Color.White
        Me.LaundryBtn.Location = New System.Drawing.Point(391, 74)
        Me.LaundryBtn.Name = "LaundryBtn"
        Me.LaundryBtn.Size = New System.Drawing.Size(117, 29)
        Me.LaundryBtn.TabIndex = 1
        Me.LaundryBtn.Text = "Lavandería"
        Me.LaundryBtn.UseVisualStyleBackColor = False
        '
        'PoolBtn
        '
        Me.PoolBtn.BackColor = System.Drawing.Color.Transparent
        Me.PoolBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.PoolBtn.FlatAppearance.BorderSize = 0
        Me.PoolBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.PoolBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.PoolBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.PoolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PoolBtn.Font = New System.Drawing.Font("Poppins", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PoolBtn.ForeColor = System.Drawing.Color.White
        Me.PoolBtn.Location = New System.Drawing.Point(544, 189)
        Me.PoolBtn.Name = "PoolBtn"
        Me.PoolBtn.Size = New System.Drawing.Size(230, 60)
        Me.PoolBtn.TabIndex = 2
        Me.PoolBtn.Text = "Piscina"
        Me.PoolBtn.UseVisualStyleBackColor = False
        '
        'RelaxBtn
        '
        Me.RelaxBtn.BackColor = System.Drawing.Color.Transparent
        Me.RelaxBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.RelaxBtn.FlatAppearance.BorderSize = 0
        Me.RelaxBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.RelaxBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RelaxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RelaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RelaxBtn.Font = New System.Drawing.Font("Poppins", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RelaxBtn.ForeColor = System.Drawing.Color.White
        Me.RelaxBtn.Location = New System.Drawing.Point(558, 391)
        Me.RelaxBtn.Name = "RelaxBtn"
        Me.RelaxBtn.Size = New System.Drawing.Size(257, 60)
        Me.RelaxBtn.TabIndex = 3
        Me.RelaxBtn.Text = "Descanso"
        Me.RelaxBtn.UseVisualStyleBackColor = False
        '
        'Room1Btn
        '
        Me.Room1Btn.BackColor = System.Drawing.Color.Transparent
        Me.Room1Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Room1Btn.FlatAppearance.BorderSize = 0
        Me.Room1Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.Room1Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Room1Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Room1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room1Btn.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room1Btn.ForeColor = System.Drawing.Color.White
        Me.Room1Btn.Location = New System.Drawing.Point(100, 531)
        Me.Room1Btn.Name = "Room1Btn"
        Me.Room1Btn.Size = New System.Drawing.Size(108, 60)
        Me.Room1Btn.TabIndex = 4
        Me.Room1Btn.Text = "Habitación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1"
        Me.Room1Btn.UseVisualStyleBackColor = False
        '
        'Room2Btn
        '
        Me.Room2Btn.BackColor = System.Drawing.Color.Transparent
        Me.Room2Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Room2Btn.FlatAppearance.BorderSize = 0
        Me.Room2Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.Room2Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Room2Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Room2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room2Btn.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room2Btn.ForeColor = System.Drawing.Color.White
        Me.Room2Btn.Location = New System.Drawing.Point(238, 531)
        Me.Room2Btn.Name = "Room2Btn"
        Me.Room2Btn.Size = New System.Drawing.Size(108, 60)
        Me.Room2Btn.TabIndex = 5
        Me.Room2Btn.Text = "Habitación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2"
        Me.Room2Btn.UseVisualStyleBackColor = False
        '
        'Room3Btn
        '
        Me.Room3Btn.BackColor = System.Drawing.Color.Transparent
        Me.Room3Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Room3Btn.FlatAppearance.BorderSize = 0
        Me.Room3Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.Room3Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Room3Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Room3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room3Btn.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room3Btn.ForeColor = System.Drawing.Color.White
        Me.Room3Btn.Location = New System.Drawing.Point(381, 531)
        Me.Room3Btn.Name = "Room3Btn"
        Me.Room3Btn.Size = New System.Drawing.Size(108, 60)
        Me.Room3Btn.TabIndex = 6
        Me.Room3Btn.Text = "Habitación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3"
        Me.Room3Btn.UseVisualStyleBackColor = False
        '
        'LivingBtn
        '
        Me.LivingBtn.BackColor = System.Drawing.Color.Transparent
        Me.LivingBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.LivingBtn.FlatAppearance.BorderSize = 0
        Me.LivingBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.LivingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.LivingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.LivingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LivingBtn.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LivingBtn.ForeColor = System.Drawing.Color.White
        Me.LivingBtn.Location = New System.Drawing.Point(25, 236)
        Me.LivingBtn.Name = "LivingBtn"
        Me.LivingBtn.Size = New System.Drawing.Size(115, 89)
        Me.LivingBtn.TabIndex = 7
        Me.LivingBtn.Text = "Sala de estar"
        Me.LivingBtn.UseVisualStyleBackColor = False
        '
        'KitchenBtn
        '
        Me.KitchenBtn.BackColor = System.Drawing.Color.Transparent
        Me.KitchenBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.KitchenBtn.FlatAppearance.BorderSize = 0
        Me.KitchenBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.KitchenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.KitchenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.KitchenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KitchenBtn.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KitchenBtn.ForeColor = System.Drawing.Color.White
        Me.KitchenBtn.Location = New System.Drawing.Point(288, 218)
        Me.KitchenBtn.Name = "KitchenBtn"
        Me.KitchenBtn.Size = New System.Drawing.Size(108, 60)
        Me.KitchenBtn.TabIndex = 8
        Me.KitchenBtn.Text = "Cocina"
        Me.KitchenBtn.UseVisualStyleBackColor = False
        '
        'DoorBtn
        '
        Me.DoorBtn.BackColor = System.Drawing.Color.Transparent
        Me.DoorBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.DoorBtn.FlatAppearance.BorderSize = 0
        Me.DoorBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.DoorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.DoorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.DoorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DoorBtn.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoorBtn.ForeColor = System.Drawing.Color.White
        Me.DoorBtn.Location = New System.Drawing.Point(8, 543)
        Me.DoorBtn.Name = "DoorBtn"
        Me.DoorBtn.Size = New System.Drawing.Size(71, 37)
        Me.DoorBtn.TabIndex = 9
        Me.DoorBtn.Text = "Puerta"
        Me.DoorBtn.UseVisualStyleBackColor = False
        '
        'AllOnBtn
        '
        Me.AllOnBtn.Location = New System.Drawing.Point(521, 307)
        Me.AllOnBtn.Name = "AllOnBtn"
        Me.AllOnBtn.Size = New System.Drawing.Size(139, 29)
        Me.AllOnBtn.TabIndex = 10
        Me.AllOnBtn.Text = "Encender Todos"
        Me.AllOnBtn.UseVisualStyleBackColor = True
        '
        'AllOfBtn
        '
        Me.AllOfBtn.Location = New System.Drawing.Point(521, 339)
        Me.AllOfBtn.Name = "AllOfBtn"
        Me.AllOfBtn.Size = New System.Drawing.Size(139, 29)
        Me.AllOfBtn.TabIndex = 11
        Me.AllOfBtn.Text = "Apagar Todos"
        Me.AllOfBtn.UseVisualStyleBackColor = True
        '
        'SmartHomeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 603)
        Me.Controls.Add(Me.AllOfBtn)
        Me.Controls.Add(Me.AllOnBtn)
        Me.Controls.Add(Me.DoorBtn)
        Me.Controls.Add(Me.KitchenBtn)
        Me.Controls.Add(Me.LivingBtn)
        Me.Controls.Add(Me.Room3Btn)
        Me.Controls.Add(Me.Room2Btn)
        Me.Controls.Add(Me.Room1Btn)
        Me.Controls.Add(Me.RelaxBtn)
        Me.Controls.Add(Me.PoolBtn)
        Me.Controls.Add(Me.LaundryBtn)
        Me.Controls.Add(Me.GarageBtn)
        Me.Name = "SmartHomeControl"
        Me.Text = "CasaInteligente"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GarageBtn As Button
    Friend WithEvents LaundryBtn As Button
    Friend WithEvents PoolBtn As Button
    Friend WithEvents RelaxBtn As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Room1Btn As Button
    Friend WithEvents Room2Btn As Button
    Friend WithEvents Room3Btn As Button
    Friend WithEvents LivingBtn As Button
    Friend WithEvents KitchenBtn As Button
    Friend WithEvents DoorBtn As Button
    Friend WithEvents AllOnBtn As Button
    Friend WithEvents AllOfBtn As Button
End Class
