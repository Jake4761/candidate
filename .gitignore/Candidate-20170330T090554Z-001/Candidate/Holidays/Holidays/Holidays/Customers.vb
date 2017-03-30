Imports System.IO
Public Class Customers

    Private Structure CustomerData
        Dim FirstName As String
        Dim LastName As String
        Dim Email As String
        Dim Address As String
        Dim Phone As String
        Dim DOB As String
        Dim HolidayID As Integer
    End Structure





    Private Sub Customers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Dir$("customerdetails.txt") = "" Then
            Dim sw As New StreamWriter("customerdetails.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            sw.WriteLine("")
            sw.Close()
            MsgBox("A new file has been created", vbExclamation, "Warning!")
        End If
    End Sub







    Private Sub btnInput_Click(sender As System.Object, e As System.EventArgs) Handles btnInput.Click
        Dim FirstName As String = txtFirstName.Text
        Dim LastName As String = txtLastName.Text
        Dim Email As String = txtEmail.Text
        Dim Address As String = txtAddress.Text
        Dim Phone As String = txtPhone.Text
        Dim DOB As String = dtpDoB.Text
        Dim HolidayID As Integer = Val(txtHolidayID.Text)

        If Check(FirstName, 50, False, True) = False Or Check(LastName, 50, False, True) = False Or Check(Email, 50, True, False) = False Or Check(Address, 50, True, False) = False Or Check(Phone, 11, True, True) = False Or Check(DOB, 50, True, True) = False Or Check(HolidayID, 4, True, True) = False Then
            MsgBox("Please make corrections and try again")
        Else

            Dim IDUsed As Boolean = False
            Dim Check() As String = File.ReadAllLines(Dir$("customerdetails.txt"))
            For I = 0 To UBound(Check)

                If Val(Trim(Mid(Check(I), 1, 4))) = Val(txtHolidayID.Text) Then IDUsed = True


            Next I

            If IDUsed = False Then

                Dim CustomerDetails As New CustomerData

                Dim sw As New StreamWriter(Application.StartupPath & "\customerdetails.txt", True)
                CustomerDetails.FirstName = LSet(txtFirstName.Text, 50)
                CustomerDetails.LastName = LSet(txtLastName.Text, 50)
                CustomerDetails.Email = LSet(txtEmail.Text, 50)                'Filling the structure with data.
                CustomerDetails.Address = LSet(txtAddress.Text, 50)
                CustomerDetails.Phone = LSet(txtPhone.Text, 11)
                CustomerDetails.DOB = LSet(dtpDoB.Text, 50)
                CustomerDetails.HolidayID = LSet(Val(txtHolidayID.Text), 4)
                sw.WriteLine(CustomerDetails.HolidayID & CustomerDetails.LastName & CustomerDetails.Email & CustomerDetails.Address & CustomerDetails.Phone & CustomerDetails.DOB & CustomerDetails.FirstName)
                sw.Close()

                MsgBox("Saved")

            Else : MsgBox("Please choose a new session ID that one is taken")
            End If




            End If


    End Sub

    Private Function Check(ByVal Data As String, Length As Integer, Type As Boolean, DoIntCheck As Boolean)
        If Data.Length > Length Then
            Return False
            MsgBox("Please Change" & Data & "as it has too many character")
        ElseIf Data = "" Then
            Return (False)
            MsgBox("Please ensure all fields have been filled in")
        Else : Return True
        End If

        If DoIntCheck = True Then
            If IsNumeric(Data) = Type Then
                Return True

            Else : Return False
                MsgBox("Please ensure you are using the correct data type in " & Data)
            End If
        End If



    End Function





    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click

        Dim SearchValue As String = txtInputSearch.Text

        If Check(SearchValue, 4, True, True) = False Then
            MsgBox("Please ensure the search value is a 4 digit Session ID")
        Else
            Dim Found As Boolean
            Found = False
            Dim Customerdata() As String = File.ReadAllLines(Dir$("customerdetails.txt"))
            For I = 0 To UBound(Customerdata)
                If Trim(Mid(Customerdata(I), 1, 4)) = txtInputSearch.Text And Not txtInputSearch.Text = "" Then
                    Found = True
                End If


                If Found = True Then


                    txtHolidayID .Text = Trim(Mid(Customerdata(I), 1, 4))
                    txtLastName.Text = Trim(Mid(Customerdata(I), 5, 50))
                    txtEmail.Text = Trim(Mid(Customerdata(I), 55, 50))
                    txtAddress.Text = Trim(Mid(Customerdata(I), 105, 50))
                    txtPhone.Text = Trim(Mid(Customerdata(I), 155, 11))
                    dtpDoB.Text = Trim(Mid(Customerdata(I), 166, 50)) & " 11:00AM"
                    txtFirstName.Text = Trim(Mid(Customerdata(I), 216, 50))

                    MsgBox("SearchFound")
                    I = UBound(Customerdata)
                End If

            Next I

            If Found = False Then
                MsgBox("Search not found please ensure the value is correct")
            End If
        End If

    End Sub
End Class