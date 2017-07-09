<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarShow
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
        Me.lblClassicCarShow = New System.Windows.Forms.Label()
        Me.lblTotalValueForInsurance = New System.Windows.Forms.Label()
        Me.btnComputeInventory = New System.Windows.Forms.Button()
        Me.lblClassicCarInventory = New System.Windows.Forms.Label()
        Me.lblTotalCarsInShow = New System.Windows.Forms.Label()
        Me.lblTotalValueOfCars = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClassicCarShow
        '
        Me.lblClassicCarShow.AutoSize = True
        Me.lblClassicCarShow.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassicCarShow.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblClassicCarShow.Location = New System.Drawing.Point(10, 36)
        Me.lblClassicCarShow.Name = "lblClassicCarShow"
        Me.lblClassicCarShow.Size = New System.Drawing.Size(246, 32)
        Me.lblClassicCarShow.TabIndex = 0
        Me.lblClassicCarShow.Text = "Classic Car Show"
        '
        'lblTotalValueForInsurance
        '
        Me.lblTotalValueForInsurance.AutoSize = True
        Me.lblTotalValueForInsurance.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValueForInsurance.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTotalValueForInsurance.Location = New System.Drawing.Point(13, 70)
        Me.lblTotalValueForInsurance.Name = "lblTotalValueForInsurance"
        Me.lblTotalValueForInsurance.Size = New System.Drawing.Size(218, 22)
        Me.lblTotalValueForInsurance.TabIndex = 1
        Me.lblTotalValueForInsurance.Text = "Total Value for Insurance"
        '
        'btnComputeInventory
        '
        Me.btnComputeInventory.BackColor = System.Drawing.Color.DarkBlue
        Me.btnComputeInventory.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeInventory.ForeColor = System.Drawing.Color.White
        Me.btnComputeInventory.Location = New System.Drawing.Point(279, 48)
        Me.btnComputeInventory.Name = "btnComputeInventory"
        Me.btnComputeInventory.Size = New System.Drawing.Size(223, 44)
        Me.btnComputeInventory.TabIndex = 2
        Me.btnComputeInventory.Text = "Compute Inventory"
        Me.btnComputeInventory.UseVisualStyleBackColor = False
        '
        'lblClassicCarInventory
        '
        Me.lblClassicCarInventory.AutoSize = True
        Me.lblClassicCarInventory.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassicCarInventory.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblClassicCarInventory.Location = New System.Drawing.Point(133, 114)
        Me.lblClassicCarInventory.Name = "lblClassicCarInventory"
        Me.lblClassicCarInventory.Size = New System.Drawing.Size(254, 28)
        Me.lblClassicCarInventory.TabIndex = 3
        Me.lblClassicCarInventory.Text = "Classic Car Inventory"
        '
        'lblTotalCarsInShow
        '
        Me.lblTotalCarsInShow.AutoSize = True
        Me.lblTotalCarsInShow.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCarsInShow.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTotalCarsInShow.Location = New System.Drawing.Point(16, 168)
        Me.lblTotalCarsInShow.Name = "lblTotalCarsInShow"
        Me.lblTotalCarsInShow.Size = New System.Drawing.Size(0, 22)
        Me.lblTotalCarsInShow.TabIndex = 4
        Me.lblTotalCarsInShow.Visible = False
        '
        'lblTotalValueOfCars
        '
        Me.lblTotalValueOfCars.AutoSize = True
        Me.lblTotalValueOfCars.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValueOfCars.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTotalValueOfCars.Location = New System.Drawing.Point(254, 168)
        Me.lblTotalValueOfCars.Name = "lblTotalValueOfCars"
        Me.lblTotalValueOfCars.Size = New System.Drawing.Size(0, 22)
        Me.lblTotalValueOfCars.TabIndex = 5
        Me.lblTotalValueOfCars.Visible = False
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.ForeColor = System.Drawing.Color.DarkBlue
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 22
        Me.lstDisplay.Location = New System.Drawing.Point(20, 195)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(219, 246)
        Me.lstDisplay.TabIndex = 6
        Me.lstDisplay.Visible = False
        '
        'picPicture
        '
        Me.picPicture.Image = Global.CarShow.My.Resources.Resources.Car
        Me.picPicture.Location = New System.Drawing.Point(259, 195)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(279, 244)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPicture.TabIndex = 7
        Me.picPicture.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'frmCarShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 456)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lblTotalValueOfCars)
        Me.Controls.Add(Me.lblTotalCarsInShow)
        Me.Controls.Add(Me.lblClassicCarInventory)
        Me.Controls.Add(Me.btnComputeInventory)
        Me.Controls.Add(Me.lblTotalValueForInsurance)
        Me.Controls.Add(Me.lblClassicCarShow)
        Me.Controls.Add(Me.picPicture)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCarShow"
        Me.Text = " Classic Car Show"
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClassicCarShow As System.Windows.Forms.Label
    Friend WithEvents lblTotalValueForInsurance As System.Windows.Forms.Label
    Friend WithEvents btnComputeInventory As System.Windows.Forms.Button
    Friend WithEvents lblClassicCarInventory As System.Windows.Forms.Label
    Friend WithEvents lblTotalCarsInShow As System.Windows.Forms.Label
    Friend WithEvents lblTotalValueOfCars As System.Windows.Forms.Label
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents picPicture As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
