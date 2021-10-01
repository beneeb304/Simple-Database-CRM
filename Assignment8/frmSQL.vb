Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frmSQL
    '------------------------------------------------------------
    '-                File Name : frmSQL.vb                     - 
    '-                Part of Project: Assignment8              -
    '------------------------------------------------------------
    '-                Written By: Benjamin R. Neeb              -
    '-                Written On: March 21, 2021                -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the all code for the application. All -
    '- database and user interaction are done here. 
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- The purpose of this program is to connect with and use a -
    '- SQL Server database. The user can manage customers and   -
    '- their past orders through a GUI while interacting with a -
    '- database running in the background.                      -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- DBAdaptCustomers:    SqlDataAdapter for customers        -
    '-                      database.                           -
    '- DBAdaptOrderedItems: SqlDataAdapter for ordered items    -
    '-                      database.                           -
    '- strConnection:       String used to connect to the       -
    '-                      database.                           -
    '- dsCustomers:         DataSet for customers database      -
    '- strDBPath:           String to map where the database is -
    '-                      in executable.                      -
    '- intOpFlag:           Integer used to determine operation -
    '- dsOrderedItems:      DataSet for ordered items database  -
    '------------------------------------------------------------

    '---------------------------------------------------------------------------------------
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '---------------------------------------------------------------------------------------

    'Table names
    Dim dsCustomers As New DataSet
    Dim dsOrderedItems As New DataSet

    'Path to database in executable
    Dim strDBPath As String = My.Application.Info.DirectoryPath & "\Assignment8DB.mdf"

    'This is the full connection string
    Dim strConnection As String = "SERVER=(localdb)\MSSQLLocalDB;DATABASE=Assignment8DB;Integrated Security=SSPI;AttachDbFileName=" & strDBPath

    'Data adapters
    Dim DBAdaptCustomers As SqlDataAdapter
    Dim DBAdaptOrderedItems As SqlDataAdapter

    Dim intOpFlag As Integer = 0

    '---------------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Private Sub frmSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-            Subprogram Name: frmSQL_Load                  -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called on form load. This sub calls a -
        '- SQL command to initially populate the SqlDataAdapters    -
        '- with data.                                               -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- strSQLCommand    - String for the SQL command            -
        '------------------------------------------------------------


        'Create SQL command to get all from customers table
        Dim strSQLCommand As String = "SELECT * FROM Customers"
        DBAdaptCustomers = New SqlDataAdapter(strSQLCommand, strCONNECTION)
        DBAdaptCustomers.Fill(dsCustomers, "Customers")

        'Set controls to show first customer
        btnFirst_Click(sender, e)
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnFirst_Click               -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called on btnFirst click event. It    -
        '- sets the binding context and get's the ordered items for -
        '- the current customer.                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- (None)                                                   -
        '------------------------------------------------------------

        'Set Data Bindings as needed
        SetDataBindings()

        'Set binding to first element
        BindingContext(dsCustomers, "Customers").Position = 0

        'Call SetOrderedItems to show all ordered items for showing customer
        SetOrderedItems(txtID.Text)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnPrevious_Click            -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called on btnPrevious click event. It -
        '- sets the binding context and get's the ordered items for -
        '- the current customer.                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- (None)                                                   -
        '------------------------------------------------------------

        'Set Data Bindings as needed
        SetDataBindings()

        'Set binding to previous element
        BindingContext(dsCustomers, "Customers").Position = (BindingContext(dsCustomers, "Customers").Position - 1)

        'Call SetOrderedItems to show all ordered items for showing customer
        SetOrderedItems(txtID.Text)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnNext_Click                -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called on btnNext click event. It     -
        '- sets the binding context and get's the ordered items for -
        '- the current customer.                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- (None)                                                   -
        '------------------------------------------------------------

        'Set Data Bindings as needed
        SetDataBindings()

        'Set binding to previous element
        BindingContext(dsCustomers, "Customers").Position = (BindingContext(dsCustomers, "Customers").Position + 1)

        'Call SetOrderedItems to show all ordered items for showing customer
        SetOrderedItems(txtID.Text)
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnLast_Click                -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called on btnLast click event. It     -
        '- sets the binding context and get's the ordered items for -
        '- the current customer.                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- (None)                                                   -
        '------------------------------------------------------------

        'Set Data Bindings as needed
        SetDataBindings()

        'Set binding to last element
        BindingContext(dsCustomers, "Customers").Position = dsCustomers.Tables("Customers").Rows.Count - 1

        'Call SetOrderedItems to show all ordered items for showing customer
        SetOrderedItems(txtID.Text)
    End Sub

    Private Sub SetDataBindings()
        '------------------------------------------------------------
        '-            Subprogram Name: SetDataBindings              -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is used to create databindings and       -
        '- disable textboxes. 
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- txt:         TextBox used to assign properties.          -
        '------------------------------------------------------------

        If txtAddress.DataBindings.Count = 0 Then
            'Create data bindings
            txtFName.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.FirstName"))
            txtLName.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.LastName"))
            txtAddress.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.StreetAddress"))
            txtCity.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.City"))
            txtState.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.State"))
            txtZip.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.ZipCode"))

            If txtID.DataBindings.Count = 0 Then
                txtID.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.TUID"))
            End If

            'Disable each textbox
            For Each ctrl As Control In grpCustomerInfo.Controls
                If ctrl.GetType() Is GetType(TextBox) Then
                    'Get textbox
                    Dim txt As TextBox = ctrl

                    'Disable textbox
                    txt.Enabled = False
                End If
            Next
        End If
    End Sub

    Private Sub SetOrderedItems(strID As String)
        '------------------------------------------------------------
        '-            Subprogram Name: SetOrderedItems              -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is a simple overloaded sub. It takes the -
        '- parameter (as a String) and attempts to typecast it to   -
        '- an integer.                                              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- strID:       String for ID passed as a string.           -
        '------------------------------------------------------------
        '- (None)                                                   -
        '------------------------------------------------------------

        'simple overload sub

        Dim intID As Integer

        'if strID is an int, pass it as one
        If Integer.TryParse(strID, intID) Then
            intID = CInt(strID)

            SetOrderedItems(intID)
        End If
    End Sub

    Private Sub SetOrderedItems(intID As Integer)
        '------------------------------------------------------------
        '-            Subprogram Name: SetOrderedItems              -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine sets the ordered items for the currently -
        '- displayed customer by sending an SQL command and setting -
        '- the response into the datagridview.                      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- intID:       Integer for ID passed as a integer.         -
        '------------------------------------------------------------
        '- arrData:             String Array used to set items into -
        '-                      the datagridview.                   -
        '- strSQLCommand:       String for the SQL command sent.    -
        '------------------------------------------------------------

        'Clear the datasource
        dsOrderedItems.Clear()

        'Set dgv equal to datasource (now empty)
        dgvOrderedItems.DataSource = dsOrderedItems

        'Set the dgv equal to Nothing so we can add rows to it
        dgvOrderedItems.DataSource = Nothing

        'Create SQL command to get all from customers table
        Dim strSQLCommand As String = "SELECT * FROM OrderedItems WHERE CustomerID = " & intID
        DBAdaptOrderedItems = New SqlDataAdapter(strSQLCommand, strCONNECTION)
        DBAdaptOrderedItems.Fill(dsOrderedItems, "OrderedItems")

        For i As Integer = 0 To dsOrderedItems.Tables("OrderedItems").Rows.Count - 1
            'Create string array for data
            Dim arrData(5) As String

            'Set ItemNumber, ItemName, Quantity, and ItemPrice
            For j As Integer = 2 To 5
                arrData(j - 2) = dsOrderedItems.Tables("OrderedItems").Rows(i)(j).ToString()
            Next

            'Set Total
            If IsNumeric(arrData(2)) And IsNumeric(arrData(3)) Then
                arrData(4) = CInt(arrData(2)) * CSng(arrData(3))
            Else
                arrData(4) = "Cannot calculate"
            End If

            'Add to dgv
            dgvOrderedItems.Rows.Add(arrData)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnAdd_Click                 -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called on btnAdd click event. This    -
        '- allows the user to add a customer to the customer table  -
        '- in the database.                                         -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- txt:             TextBox to be enabled.                  -
        '------------------------------------------------------------

        'Set flag
        intOpFlag = 1

        'Show buttons
        HideEnableButtons(True)

        'Enable and empty textboxes
        For Each ctrl As Control In grpCustomerInfo.Controls
            If ctrl.GetType() Is GetType(TextBox) Then
                'Get textbox
                Dim txt As TextBox = ctrl

                'Enable
                txt.Enabled = True

                'Empty
                txt.Text = ""

                'Clear data binding
                txt.DataBindings.Clear()
            End If
        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnDelete_Click              -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called on btnDelete click event. This -
        '- allows the user to delete a customer from the customer   -
        '- table in the database.                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- result:          MessageBox response from user.          -
        '- strSQLCommand:   String for SQL command to be used on    -
        '-                  several different operations.           -
        '------------------------------------------------------------

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete customer " & txtID.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            'Create SQL command to delete customer
            Dim strSQLCommand As String = "DELETE FROM dbo.Customers WHERE TUID = " & txtID.Text

            'Execute SQL command
            DBAdaptCustomers = New SqlDataAdapter(strSQLCommand, strCONNECTION)
            DBAdaptCustomers.Fill(dsCustomers, "Customers")

            'Also delete that customer's ordered items
            strSQLCommand = "DELETE FROM dbo.OrderedItems WHERE CustomerID= " & txtID.Text
            DBAdaptOrderedItems = New SqlDataAdapter(strSQLCommand, strCONNECTION)
            DBAdaptOrderedItems.Fill(dsOrderedItems, "OrderedItems")

            'Create SQL command to refresh all from customers table
            dsCustomers.Clear()
            strSQLCommand = "SELECT * FROM Customers"
            DBAdaptCustomers = New SqlDataAdapter(strSQLCommand, strCONNECTION)
            DBAdaptCustomers.Fill(dsCustomers, "Customers")

            'Since we deleted a customer, refresh the ordered items
            dsOrderedItems.Clear()
            strSQLCommand = "SELECT * FROM OrderedItems"
            DBAdaptOrderedItems = New SqlDataAdapter(strSQLCommand, strCONNECTION)
            DBAdaptOrderedItems.Fill(dsOrderedItems, "OrderedItems")

            'Return view to current customer
            SetDataBindings()
            BindingContext(dsCustomers, "Customers").Position = BindingContext(dsCustomers, "Customers").Position
            SetOrderedItems(txtID.Text)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnUpdate_Click              -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called on btnUpdate click event. This -
        '- allows the user to update a customer already in the      -
        '- customer table in the database.                          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 -
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- txt:             TextBox to be enabled.                  -
        '------------------------------------------------------------

        'Set flag
        intOpFlag = 2

        'Show buttons
        HideEnableButtons(True)

        'Enable textboxes
        For Each ctrl As Control In grpCustomerInfo.Controls
            If ctrl.GetType() Is GetType(TextBox) Then
                'Get textbox
                Dim txt As TextBox = ctrl

                'Don't modify primary key
                If txt.Name <> txtID.Name Then
                    'Enable
                    txt.Enabled = True

                    'Clear data binding
                    txt.DataBindings.Clear()
                End If
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnSave_Click                -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called on btnSave click event. This   -
        '- allows the user to commit his database changes. The user -
        '- must press btnSave after both an addition and update.    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- intPos:              Integer used to place the user back -
        '-                      at an appropriate index after his   -
        '-                      operation.                          -
        '- strSQLCommand:       String for SQL command to be        -
        '-                      executed                            -
        '------------------------------------------------------------

        'Clear error provider
        ErrorProvider1.Clear()

        'Create String for SQL command
        Dim strSQLCommand As String = ""

        Dim intPos As Integer

        Select Case intOpFlag
            Case 1
                'Create SQL command to insert new customer
                strSQLCommand = "INSERT INTO dbo.Customers (TUID, FirstName, LastName, StreetAddress, City, State, ZipCode) VALUES ("
                strSQLCommand &= txtID.Text & ","
                strSQLCommand &= "N'" & txtFName.Text.Trim & "',"
                strSQLCommand &= "N'" & txtLName.Text.Trim & "',"
                strSQLCommand &= "N'" & txtAddress.Text.Trim & "',"
                strSQLCommand &= "N'" & txtCity.Text.Trim & "',"
                strSQLCommand &= "N'" & txtState.Text.Trim & "',"
                strSQLCommand &= "N'" & txtZip.Text.Trim & "')"

                'Take user to last item in customers table
                intPos = BindingContext(dsCustomers, "Customers").Count
            Case 2
                'Create SQL command to update customer
                strSQLCommand = "UPDATE dbo.Customers SET "
                strSQLCommand &= "FirstName = '" & txtFName.Text.Trim & "',"
                strSQLCommand &= "LastName = '" & txtLName.Text.Trim & "',"
                strSQLCommand &= "StreetAddress = '" & txtAddress.Text.Trim & "',"
                strSQLCommand &= "City = '" & txtCity.Text.Trim & "',"
                strSQLCommand &= "State = '" & txtState.Text.Trim & "',"
                strSQLCommand &= "ZipCode = '" & txtZip.Text.Trim & "'"
                strSQLCommand &= "WHERE TUID = " & txtID.Text

                'Keep user at current position
                intPos = BindingContext(dsCustomers, "Customers").Position
        End Select

        'Execute SQL command
        Try
            DBAdaptCustomers = New SqlDataAdapter(strSQLCommand, strCONNECTION)
            DBAdaptCustomers.Fill(dsCustomers, "Customers")
        Catch ex As Exception
            ErrorProvider1.SetError(txtID, "Error occurred; ensure unique ID and string sizes.")
        End Try

        'Create SQL command to refresh all from customers table
        dsCustomers.Clear()
        strSQLCommand = "SELECT * FROM Customers"
        DBAdaptCustomers = New SqlDataAdapter(strSQLCommand, strCONNECTION)
        DBAdaptCustomers.Fill(dsCustomers, "Customers")

        'Return view to current customer
        SetDataBindings()
        BindingContext(dsCustomers, "Customers").Position = intPos
        SetOrderedItems(txtID.Text)

        'Set flag
        intOpFlag = 0

        'Hide buttons
        HideEnableButtons(False)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnCancel_Click              -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called on btnCancel click event. This -
        '- allows the user to cancel his current operation.         -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clear error provider
        ErrorProvider1.Clear()

        'Return view to current customer
        SetDataBindings()
        BindingContext(dsCustomers, "Customers").Position = BindingContext(dsCustomers, "Customers").Position
        SetOrderedItems(txtID.Text)

        'Set flag
        intOpFlag = 0

        'Hide buttons
        HideEnableButtons(False)
    End Sub

    Private Sub HideEnableButtons(blnHide As Boolean)
        '------------------------------------------------------------
        '-            Subprogram Name: HideEnableButtons            -
        '------------------------------------------------------------
        '-                Written By: Benjamin R. Neeb              -
        '-                Written On: March 21, 2021                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is used to hide/show and disable/enable  -
        '- buttons. It also the clears error provider and empties   -
        '- the datagridview when appropriate.                       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- blnHide:         Boolean used to determine if we need to -
        '-                  hide/enable or show/disable.            -
        '------------------------------------------------------------
        '- (None)                                                   -
        '------------------------------------------------------------

        If blnHide Then

            'Clear error provider
            ErrorProvider1.Clear()

            'Clear the datasource
            dsOrderedItems.Clear()

            'Set dgv equal to datasource (now empty)
            dgvOrderedItems.DataSource = dsOrderedItems

            'Set the dgv equal to Nothing so we can add rows to it
            dgvOrderedItems.DataSource = Nothing

            'Show buttons
            btnSave.Visible = True
            btnCancel.Visible = True

            'Disable buttons
            btnAdd.Enabled = False
            btnDelete.Enabled = False
            btnUpdate.Enabled = False
            btnFirst.Enabled = False
            btnNext.Enabled = False
            btnPrevious.Enabled = False
            btnLast.Enabled = False
        Else
            'Hide buttons
            btnSave.Visible = False
            btnCancel.Visible = False

            'Enable buttons
            btnAdd.Enabled = True
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
            btnFirst.Enabled = True
            btnNext.Enabled = True
            btnPrevious.Enabled = True
            btnLast.Enabled = True
        End If
    End Sub
End Class
