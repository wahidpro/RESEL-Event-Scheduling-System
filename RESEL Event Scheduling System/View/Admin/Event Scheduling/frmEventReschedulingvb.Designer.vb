﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventReschedulingvb
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblGoal = New System.Windows.Forms.Label()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.lblActCode = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.IDSchedule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDVenue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenueName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OldID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Crimson
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(627, 558)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(129, 38)
        Me.btnCancel.TabIndex = 60
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUnit.Location = New System.Drawing.Point(255, 309)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(354, 21)
        Me.lblUnit.TabIndex = 59
        Me.lblUnit.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNo.Location = New System.Drawing.Point(255, 271)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(76, 21)
        Me.lblNo.TabIndex = 58
        Me.lblNo.Text = "11111111111"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblType.Location = New System.Drawing.Point(255, 225)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(354, 21)
        Me.lblType.TabIndex = 57
        Me.lblType.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        '
        'lblGoal
        '
        Me.lblGoal.AutoSize = True
        Me.lblGoal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblGoal.Location = New System.Drawing.Point(255, 171)
        Me.lblGoal.Name = "lblGoal"
        Me.lblGoal.Size = New System.Drawing.Size(354, 21)
        Me.lblGoal.TabIndex = 56
        Me.lblGoal.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventName.Location = New System.Drawing.Point(255, 130)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(354, 21)
        Me.lblEventName.TabIndex = 55
        Me.lblEventName.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        '
        'lblActCode
        '
        Me.lblActCode.AutoSize = True
        Me.lblActCode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblActCode.Location = New System.Drawing.Point(255, 93)
        Me.lblActCode.Name = "lblActCode"
        Me.lblActCode.Size = New System.Drawing.Size(354, 21)
        Me.lblActCode.TabIndex = 54
        Me.lblActCode.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(95, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 21)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "# of Participants:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(98, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 21)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Type:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(95, 171)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 21)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "Goal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(98, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 21)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Unit:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(95, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Activity Code:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(95, 130)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(121, 21)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "Name of Event:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(0, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(764, 39)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "Event Rescheduling"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 71)
        Me.Panel1.TabIndex = 47
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToDeleteRows = False
        Me.dgvSchedule.AllowUserToResizeColumns = False
        Me.dgvSchedule.AllowUserToResizeRows = False
        Me.dgvSchedule.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSchedule.ColumnHeadersHeight = 30
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSchedule, Me.IDVenue, Me.VenueName, Me._Date, Me.TimeEnd, Me.Stat, Me.Column1, Me.Action, Me.OldID})
        Me.dgvSchedule.Location = New System.Drawing.Point(12, 356)
        Me.dgvSchedule.MultiSelect = False
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.ReadOnly = True
        Me.dgvSchedule.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvSchedule.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSchedule.Size = New System.Drawing.Size(744, 198)
        Me.dgvSchedule.TabIndex = 61
        '
        'IDSchedule
        '
        Me.IDSchedule.HeaderText = "IDSchedule"
        Me.IDSchedule.Name = "IDSchedule"
        Me.IDSchedule.ReadOnly = True
        Me.IDSchedule.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IDSchedule.Visible = False
        '
        'IDVenue
        '
        Me.IDVenue.HeaderText = "IDVenue"
        Me.IDVenue.Name = "IDVenue"
        Me.IDVenue.ReadOnly = True
        Me.IDVenue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IDVenue.Visible = False
        Me.IDVenue.Width = 50
        '
        'VenueName
        '
        Me.VenueName.HeaderText = "Name of Venue"
        Me.VenueName.Name = "VenueName"
        Me.VenueName.ReadOnly = True
        Me.VenueName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.VenueName.Width = 200
        '
        '_Date
        '
        Me._Date.HeaderText = "Schedule"
        Me._Date.Name = "_Date"
        Me._Date.ReadOnly = True
        Me._Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._Date.Width = 180
        '
        'TimeEnd
        '
        Me.TimeEnd.HeaderText = "From"
        Me.TimeEnd.Name = "TimeEnd"
        Me.TimeEnd.ReadOnly = True
        Me.TimeEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TimeEnd.Width = 80
        '
        'Stat
        '
        Me.Stat.HeaderText = "To"
        Me.Stat.Name = "Stat"
        Me.Stat.ReadOnly = True
        Me.Stat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Stat.Width = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "Status"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Action
        '
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        Me.Action.Text = "Reschedule"
        Me.Action.UseColumnTextForButtonValue = True
        '
        'OldID
        '
        Me.OldID.HeaderText = "OldID"
        Me.OldID.Name = "OldID"
        Me.OldID.ReadOnly = True
        Me.OldID.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Crimson
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(492, 559)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(129, 38)
        Me.btnUpdate.TabIndex = 62
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.Location = New System.Drawing.Point(652, 332)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(73, 21)
        Me.lblStatus.TabIndex = 63
        Me.lblStatus.Text = "Prioority"
        '
        'frmEventReschedulingvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 608)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvSchedule)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblNo)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblGoal)
        Me.Controls.Add(Me.lblEventName)
        Me.Controls.Add(Me.lblActCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEventReschedulingvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblNo As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblGoal As Label
    Friend WithEvents lblEventName As Label
    Friend WithEvents lblActCode As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents IDSchedule As DataGridViewTextBoxColumn
    Friend WithEvents IDVenue As DataGridViewTextBoxColumn
    Friend WithEvents VenueName As DataGridViewTextBoxColumn
    Friend WithEvents _Date As DataGridViewTextBoxColumn
    Friend WithEvents TimeEnd As DataGridViewTextBoxColumn
    Friend WithEvents Stat As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewButtonColumn
    Friend WithEvents OldID As DataGridViewTextBoxColumn
    Friend WithEvents lblStatus As Label
End Class
