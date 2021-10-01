<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSQL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvOrderedItems = New System.Windows.Forms.DataGridView()
        Me.ItemNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpCustomerInfo.SuspendLayout()
        CType(Me.dgvOrderedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCustomerInfo
        '
        Me.grpCustomerInfo.Controls.Add(Me.btnSave)
        Me.grpCustomerInfo.Controls.Add(Me.btnCancel)
        Me.grpCustomerInfo.Controls.Add(Me.btnUpdate)
        Me.grpCustomerInfo.Controls.Add(Me.btnDelete)
        Me.grpCustomerInfo.Controls.Add(Me.btnAdd)
        Me.grpCustomerInfo.Controls.Add(Me.btnLast)
        Me.grpCustomerInfo.Controls.Add(Me.btnNext)
        Me.grpCustomerInfo.Controls.Add(Me.btnPrevious)
        Me.grpCustomerInfo.Controls.Add(Me.btnFirst)
        Me.grpCustomerInfo.Controls.Add(Me.txtZip)
        Me.grpCustomerInfo.Controls.Add(Me.txtState)
        Me.grpCustomerInfo.Controls.Add(Me.txtCity)
        Me.grpCustomerInfo.Controls.Add(Me.txtID)
        Me.grpCustomerInfo.Controls.Add(Me.Label3)
        Me.grpCustomerInfo.Controls.Add(Me.txtAddress)
        Me.grpCustomerInfo.Controls.Add(Me.txtLName)
        Me.grpCustomerInfo.Controls.Add(Me.txtFName)
        Me.grpCustomerInfo.Controls.Add(Me.Label2)
        Me.grpCustomerInfo.Controls.Add(Me.Label1)
        Me.grpCustomerInfo.Location = New System.Drawing.Point(12, 12)
        Me.grpCustomerInfo.Name = "grpCustomerInfo"
        Me.grpCustomerInfo.Size = New System.Drawing.Size(575, 205)
        Me.grpCustomerInfo.TabIndex = 0
        Me.grpCustomerInfo.TabStop = False
        Me.grpCustomerInfo.Text = "Customer Info"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(148, 160)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(126, 25)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(280, 160)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(126, 25)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(324, 110)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 44)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(236, 110)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 44)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(148, 110)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 44)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(523, 110)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(38, 44)
        Me.btnLast.TabIndex = 13
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(479, 110)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(38, 44)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(50, 110)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(38, 44)
        Me.btnPrevious.TabIndex = 11
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(6, 110)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(38, 44)
        Me.btnFirst.TabIndex = 1
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtZip
        '
        Me.txtZip.Enabled = False
        Me.txtZip.Location = New System.Drawing.Point(278, 74)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(117, 20)
        Me.txtZip.TabIndex = 10
        '
        'txtState
        '
        Me.txtState.Enabled = False
        Me.txtState.Location = New System.Drawing.Point(236, 74)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(36, 20)
        Me.txtState.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Enabled = False
        Me.txtCity.Location = New System.Drawing.Point(71, 74)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(159, 20)
        Me.txtCity.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(479, 23)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(77, 20)
        Me.txtID.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID Number:"
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(71, 48)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(324, 20)
        Me.txtAddress.TabIndex = 5
        '
        'txtLName
        '
        Me.txtLName.Enabled = False
        Me.txtLName.Location = New System.Drawing.Point(236, 23)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(159, 20)
        Me.txtLName.TabIndex = 4
        '
        'txtFName
        '
        Me.txtFName.Enabled = False
        Me.txtFName.Location = New System.Drawing.Point(71, 23)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(159, 20)
        Me.txtFName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'dgvOrderedItems
        '
        Me.dgvOrderedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderedItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemNumber, Me.ItemName, Me.Quantity, Me.ItemPrice, Me.Total})
        Me.dgvOrderedItems.Location = New System.Drawing.Point(12, 223)
        Me.dgvOrderedItems.Name = "dgvOrderedItems"
        Me.dgvOrderedItems.Size = New System.Drawing.Size(575, 215)
        Me.dgvOrderedItems.TabIndex = 23
        '
        'ItemNumber
        '
        Me.ItemNumber.HeaderText = "ItemNumber"
        Me.ItemNumber.Name = "ItemNumber"
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "ItemName"
        Me.ItemName.Name = "ItemName"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'ItemPrice
        '
        Me.ItemPrice.HeaderText = "ItemPrice"
        Me.ItemPrice.Name = "ItemPrice"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 450)
        Me.Controls.Add(Me.dgvOrderedItems)
        Me.Controls.Add(Me.grpCustomerInfo)
        Me.Name = "frmSQL"
        Me.Text = " "
        Me.grpCustomerInfo.ResumeLayout(False)
        Me.grpCustomerInfo.PerformLayout()
        CType(Me.dgvOrderedItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCustomerInfo As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dgvOrderedItems As DataGridView
    Friend WithEvents ItemNumber As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents ItemPrice As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
