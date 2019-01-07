<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegex
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
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.txtTxt = New System.Windows.Forms.TextBox()
        Me.txtMasc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSplit = New System.Windows.Forms.ListBox()
        Me.lstMatches = New System.Windows.Forms.ListBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkSplit = New System.Windows.Forms.CheckBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdoTipo3 = New System.Windows.Forms.RadioButton()
        Me.btnCopia = New System.Windows.Forms.Button()
        Me.rdoTipo2 = New System.Windows.Forms.RadioButton()
        Me.rdoTipo = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstResult
        '
        Me.lstResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.HorizontalScrollbar = True
        Me.lstResult.Location = New System.Drawing.Point(3, 39)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(805, 76)
        Me.lstResult.TabIndex = 0
        Me.lstResult.Tag = "redimx:true"
        '
        'txtTxt
        '
        Me.txtTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTxt.Location = New System.Drawing.Point(3, 16)
        Me.txtTxt.Multiline = True
        Me.txtTxt.Name = "txtTxt"
        Me.txtTxt.Size = New System.Drawing.Size(565, 119)
        Me.txtTxt.TabIndex = 1
        '
        'txtMasc
        '
        Me.txtMasc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMasc.Location = New System.Drawing.Point(3, 16)
        Me.txtMasc.Multiline = True
        Me.txtMasc.Name = "txtMasc"
        Me.txtMasc.Size = New System.Drawing.Size(565, 59)
        Me.txtMasc.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1476, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Texto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1477, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Máscara"
        '
        'lstSplit
        '
        Me.lstSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSplit.FormattingEnabled = True
        Me.lstSplit.Location = New System.Drawing.Point(3, 35)
        Me.lstSplit.Name = "lstSplit"
        Me.lstSplit.Size = New System.Drawing.Size(230, 182)
        Me.lstSplit.TabIndex = 0
        Me.lstSplit.Tag = "redimx:true"
        '
        'lstMatches
        '
        Me.lstMatches.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMatches.FormattingEnabled = True
        Me.lstMatches.Location = New System.Drawing.Point(3, 16)
        Me.lstMatches.Name = "lstMatches"
        Me.lstMatches.Size = New System.Drawing.Size(805, 93)
        Me.lstMatches.TabIndex = 4
        Me.lstMatches.Tag = "redim:true"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(811, 458)
        Me.SplitContainer1.SplitterDistance = 220
        Me.SplitContainer1.TabIndex = 6
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer3.Size = New System.Drawing.Size(811, 220)
        Me.SplitContainer3.SplitterDistance = 571
        Me.SplitContainer3.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer4.Size = New System.Drawing.Size(571, 220)
        Me.SplitContainer4.SplitterDistance = 138
        Me.SplitContainer4.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTxt)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(571, 138)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Texto"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtMasc)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(571, 78)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Máscara"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lstSplit)
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(236, 220)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Split"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkSplit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 19)
        Me.Panel1.TabIndex = 0
        '
        'chkSplit
        '
        Me.chkSplit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSplit.AutoSize = True
        Me.chkSplit.Location = New System.Drawing.Point(163, 1)
        Me.chkSplit.Name = "chkSplit"
        Me.chkSplit.Size = New System.Drawing.Size(50, 17)
        Me.chkSplit.TabIndex = 4
        Me.chkSplit.Text = "Ativo"
        Me.chkSplit.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(811, 234)
        Me.SplitContainer2.SplitterDistance = 118
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstResult)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdoTipo3)
        Me.Panel2.Controls.Add(Me.btnCopia)
        Me.Panel2.Controls.Add(Me.rdoTipo2)
        Me.Panel2.Controls.Add(Me.rdoTipo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 23)
        Me.Panel2.TabIndex = 1
        '
        'rdoTipo3
        '
        Me.rdoTipo3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoTipo3.AutoSize = True
        Me.rdoTipo3.Location = New System.Drawing.Point(568, 4)
        Me.rdoTipo3.Name = "rdoTipo3"
        Me.rdoTipo3.Size = New System.Drawing.Size(66, 17)
        Me.rdoTipo3.TabIndex = 2
        Me.rdoTipo3.Text = "Matches"
        Me.rdoTipo3.UseVisualStyleBackColor = True
        '
        'btnCopia
        '
        Me.btnCopia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopia.Location = New System.Drawing.Point(698, 0)
        Me.btnCopia.Name = "btnCopia"
        Me.btnCopia.Size = New System.Drawing.Size(65, 21)
        Me.btnCopia.TabIndex = 1
        Me.btnCopia.Text = "Copiar"
        Me.btnCopia.UseVisualStyleBackColor = True
        '
        'rdoTipo2
        '
        Me.rdoTipo2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoTipo2.AutoSize = True
        Me.rdoTipo2.Location = New System.Drawing.Point(472, 4)
        Me.rdoTipo2.Name = "rdoTipo2"
        Me.rdoTipo2.Size = New System.Drawing.Size(79, 17)
        Me.rdoTipo2.TabIndex = 0
        Me.rdoTipo2.Text = "Cada Linha"
        Me.rdoTipo2.UseVisualStyleBackColor = True
        '
        'rdoTipo
        '
        Me.rdoTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoTipo.AutoSize = True
        Me.rdoTipo.Checked = True
        Me.rdoTipo.Location = New System.Drawing.Point(388, 4)
        Me.rdoTipo.Name = "rdoTipo"
        Me.rdoTipo.Size = New System.Drawing.Size(67, 17)
        Me.rdoTipo.TabIndex = 0
        Me.rdoTipo.TabStop = True
        Me.rdoTipo.Text = "No Todo"
        Me.rdoTipo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstMatches)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(811, 112)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Matches"
        '
        'frmRegex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 458)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRegex"
        Me.Text = "Regex Teste"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
    Friend WithEvents txtTxt As System.Windows.Forms.TextBox
    Friend WithEvents txtMasc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstSplit As System.Windows.Forms.ListBox
    Friend WithEvents lstMatches As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents chkSplit As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rdoTipo2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTipo As System.Windows.Forms.RadioButton
    Friend WithEvents btnCopia As System.Windows.Forms.Button
    Friend WithEvents rdoTipo3 As System.Windows.Forms.RadioButton
End Class
