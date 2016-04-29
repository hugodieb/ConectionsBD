<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAccess = New System.Windows.Forms.ToolStripButton()
        Me.btnMYSQL = New System.Windows.Forms.ToolStripButton()
        Me.btnSQLServer = New System.Windows.Forms.ToolStripButton()
        Me.dgvBD = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvBD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.dgvBD)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 301)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAccess, Me.btnMYSQL, Me.btnSQLServer})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(582, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAccess
        '
        Me.btnAccess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAccess.Image = CType(resources.GetObject("btnAccess.Image"), System.Drawing.Image)
        Me.btnAccess.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAccess.Name = "btnAccess"
        Me.btnAccess.Size = New System.Drawing.Size(47, 22)
        Me.btnAccess.Text = "Access"
        '
        'btnMYSQL
        '
        Me.btnMYSQL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnMYSQL.Image = CType(resources.GetObject("btnMYSQL.Image"), System.Drawing.Image)
        Me.btnMYSQL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMYSQL.Name = "btnMYSQL"
        Me.btnMYSQL.Size = New System.Drawing.Size(50, 22)
        Me.btnMYSQL.Text = "MYSQL"
        '
        'btnSQLServer
        '
        Me.btnSQLServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSQLServer.Image = CType(resources.GetObject("btnSQLServer.Image"), System.Drawing.Image)
        Me.btnSQLServer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSQLServer.Name = "btnSQLServer"
        Me.btnSQLServer.Size = New System.Drawing.Size(64, 22)
        Me.btnSQLServer.Text = "SQLServer"
        '
        'dgvBD
        '
        Me.dgvBD.AllowUserToAddRows = False
        Me.dgvBD.AllowUserToDeleteRows = False
        Me.dgvBD.BackgroundColor = System.Drawing.Color.White
        Me.dgvBD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBD.Location = New System.Drawing.Point(12, 44)
        Me.dgvBD.Name = "dgvBD"
        Me.dgvBD.ReadOnly = True
        Me.dgvBD.Size = New System.Drawing.Size(564, 232)
        Me.dgvBD.TabIndex = 0
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 301)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banco de Dados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvBD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvBD As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAccess As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMYSQL As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSQLServer As System.Windows.Forms.ToolStripButton

End Class
