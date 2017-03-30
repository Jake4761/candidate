<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSearchID = New System.Windows.Forms.Label()
        Me.txtInputSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtHolidayID = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.dtpDoB = New System.Windows.Forms.DateTimePicker()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDoB = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSearchID
        '
        Me.lblSearchID.AutoSize = True
        Me.lblSearchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchID.Location = New System.Drawing.Point(14, 495)
        Me.lblSearchID.Name = "lblSearchID"
        Me.lblSearchID.Size = New System.Drawing.Size(312, 20)
        Me.lblSearchID.TabIndex = 41
        Me.lblSearchID.Text = "Please Enter The ID you want to search for"
        '
        'txtInputSearch
        '
        Me.txtInputSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputSearch.Location = New System.Drawing.Point(355, 492)
        Me.txtInputSearch.Name = "txtInputSearch"
        Me.txtInputSearch.Size = New System.Drawing.Size(133, 26)
        Me.txtInputSearch.TabIndex = 40
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(18, 384)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(514, 84)
        Me.btnSearch.TabIndex = 39
        Me.btnSearch.Text = "Search And Recieve"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtHolidayID
        '
        Me.txtHolidayID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHolidayID.Location = New System.Drawing.Point(330, 247)
        Me.txtHolidayID.Name = "txtHolidayID"
        Me.txtHolidayID.Size = New System.Drawing.Size(200, 26)
        Me.txtHolidayID.TabIndex = 38
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtAddress.Location = New System.Drawing.Point(330, 202)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 26)
        Me.txtAddress.TabIndex = 37
        '
        'dtpDoB
        '
        Me.dtpDoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpDoB.Location = New System.Drawing.Point(330, 164)
        Me.dtpDoB.Name = "dtpDoB"
        Me.dtpDoB.Size = New System.Drawing.Size(200, 26)
        Me.dtpDoB.TabIndex = 36
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPhone.Location = New System.Drawing.Point(330, 130)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 26)
        Me.txtPhone.TabIndex = 35
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblID.Location = New System.Drawing.Point(13, 250)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(82, 20)
        Me.lblID.TabIndex = 34
        Me.lblID.Text = "Holiday ID"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblAddress.Location = New System.Drawing.Point(14, 205)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 20)
        Me.lblAddress.TabIndex = 33
        Me.lblAddress.Text = "Address:"
        '
        'lblDoB
        '
        Me.lblDoB.AutoSize = True
        Me.lblDoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblDoB.Location = New System.Drawing.Point(13, 169)
        Me.lblDoB.Name = "lblDoB"
        Me.lblDoB.Size = New System.Drawing.Size(106, 20)
        Me.lblDoB.TabIndex = 32
        Me.lblDoB.Text = "Date Of Birth:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPhone.Location = New System.Drawing.Point(14, 133)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(119, 20)
        Me.lblPhone.TabIndex = 31
        Me.lblPhone.Text = "Phone Number:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(330, 93)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 26)
        Me.txtEmail.TabIndex = 30
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(330, 53)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(200, 26)
        Me.txtLastName.TabIndex = 29
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(330, 18)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(200, 26)
        Me.txtFirstName.TabIndex = 28
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(12, 93)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 20)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "Email :"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(12, 56)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(94, 20)
        Me.lblLastName.TabIndex = 26
        Me.lblLastName.Text = "Last Name :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 20)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "Name :"
        '
        'btnInput
        '
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Location = New System.Drawing.Point(16, 294)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(514, 84)
        Me.btnInput.TabIndex = 24
        Me.btnInput.Text = "INPUT"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 588)
        Me.Controls.Add(Me.lblSearchID)
        Me.Controls.Add(Me.txtInputSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtHolidayID)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.dtpDoB)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblDoB)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "Customers"
        Me.Text = "Customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSearchID As System.Windows.Forms.Label
    Friend WithEvents txtInputSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtHolidayID As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents dtpDoB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblDoB As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnInput As System.Windows.Forms.Button
End Class
