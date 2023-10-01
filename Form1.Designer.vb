<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtNewItem = New TextBox()
        btnAddItem = New Button()
        itemList = New ListBox()
        newItemLabel = New Label()
        btnDeleteItem = New Button()
        SuspendLayout()
        ' 
        ' txtNewItem
        ' 
        txtNewItem.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNewItem.Location = New Point(2, 28)
        txtNewItem.Name = "txtNewItem"
        txtNewItem.Size = New Size(186, 23)
        txtNewItem.TabIndex = 0
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddItem.Location = New Point(194, 27)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(83, 23)
        btnAddItem.TabIndex = 1
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' itemList
        ' 
        itemList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        itemList.BackColor = SystemColors.ActiveCaption
        itemList.FormattingEnabled = True
        itemList.ItemHeight = 15
        itemList.Location = New Point(2, 57)
        itemList.Name = "itemList"
        itemList.Size = New Size(372, 364)
        itemList.TabIndex = 2
        ' 
        ' newItemLabel
        ' 
        newItemLabel.AutoSize = True
        newItemLabel.BackColor = SystemColors.GradientActiveCaption
        newItemLabel.ForeColor = SystemColors.ControlText
        newItemLabel.Location = New Point(2, 9)
        newItemLabel.Name = "newItemLabel"
        newItemLabel.Size = New Size(58, 15)
        newItemLabel.TabIndex = 3
        newItemLabel.Text = "New Item"
        ' 
        ' btnDeleteItem
        ' 
        btnDeleteItem.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDeleteItem.Location = New Point(249, 427)
        btnDeleteItem.Name = "btnDeleteItem"
        btnDeleteItem.Size = New Size(123, 23)
        btnDeleteItem.TabIndex = 4
        btnDeleteItem.Text = "Delete Selected Item"
        btnDeleteItem.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(818, 450)
        Controls.Add(btnDeleteItem)
        Controls.Add(newItemLabel)
        Controls.Add(itemList)
        Controls.Add(btnAddItem)
        Controls.Add(txtNewItem)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNewItem As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents itemList As ListBox
    Friend WithEvents newItemLabel As Label
    Friend WithEvents btnDeleteItem As Button
End Class
