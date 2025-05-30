<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.rdo8InchCake = New System.Windows.Forms.RadioButton()
        Me.rdoTieredCake = New System.Windows.Forms.RadioButton()
        Me.rdoSpecialtyCake = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOccassion = New System.Windows.Forms.Label()
        Me.txtOccassion = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblCustomisation = New System.Windows.Forms.Label()
        Me.txtCustomisation = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdo8InchCake
        '
        Me.rdo8InchCake.AutoSize = True
        Me.rdo8InchCake.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo8InchCake.Location = New System.Drawing.Point(78, 25)
        Me.rdo8InchCake.Name = "rdo8InchCake"
        Me.rdo8InchCake.Size = New System.Drawing.Size(129, 22)
        Me.rdo8InchCake.TabIndex = 0
        Me.rdo8InchCake.TabStop = True
        Me.rdo8InchCake.Text = "8-inch Cake"
        Me.rdo8InchCake.UseVisualStyleBackColor = True
        '
        'rdoTieredCake
        '
        Me.rdoTieredCake.AutoSize = True
        Me.rdoTieredCake.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoTieredCake.Location = New System.Drawing.Point(78, 53)
        Me.rdoTieredCake.Name = "rdoTieredCake"
        Me.rdoTieredCake.Size = New System.Drawing.Size(129, 22)
        Me.rdoTieredCake.TabIndex = 1
        Me.rdoTieredCake.TabStop = True
        Me.rdoTieredCake.Text = "Tiered Cake"
        Me.rdoTieredCake.UseVisualStyleBackColor = True
        '
        'rdoSpecialtyCake
        '
        Me.rdoSpecialtyCake.AutoSize = True
        Me.rdoSpecialtyCake.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSpecialtyCake.Location = New System.Drawing.Point(78, 81)
        Me.rdoSpecialtyCake.Name = "rdoSpecialtyCake"
        Me.rdoSpecialtyCake.Size = New System.Drawing.Size(150, 22)
        Me.rdoSpecialtyCake.TabIndex = 2
        Me.rdoSpecialtyCake.TabStop = True
        Me.rdoSpecialtyCake.Text = "Specialty Cake"
        Me.rdoSpecialtyCake.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Pink
        Me.GroupBox1.Controls.Add(Me.rdo8InchCake)
        Me.GroupBox1.Controls.Add(Me.rdoSpecialtyCake)
        Me.GroupBox1.Controls.Add(Me.rdoTieredCake)
        Me.GroupBox1.Location = New System.Drawing.Point(263, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 120)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Your Delight"
        '
        'lblOccassion
        '
        Me.lblOccassion.AutoSize = True
        Me.lblOccassion.Location = New System.Drawing.Point(191, 41)
        Me.lblOccassion.Name = "lblOccassion"
        Me.lblOccassion.Size = New System.Drawing.Size(140, 20)
        Me.lblOccassion.TabIndex = 5
        Me.lblOccassion.Text = "Occassion Details:"
        '
        'txtOccassion
        '
        Me.txtOccassion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtOccassion.Location = New System.Drawing.Point(373, 38)
        Me.txtOccassion.Name = "txtOccassion"
        Me.txtOccassion.Size = New System.Drawing.Size(188, 26)
        Me.txtOccassion.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(181, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(130, 56)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Pink
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(317, 357)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(130, 56)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnFinish
        '
        Me.btnFinish.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFinish.Location = New System.Drawing.Point(453, 357)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(130, 56)
        Me.btnFinish.TabIndex = 11
        Me.btnFinish.Text = "FINISH ORDER"
        Me.btnFinish.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.CakesNMore.My.Resources.Resources.JAKIORAMOUR_removebg_preview
        Me.PictureBox4.Location = New System.Drawing.Point(598, -7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(154, 197)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CakesNMore.My.Resources.Resources.download__2__removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(-69, -7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CakesNMore.My.Resources.Resources.marie_antoinette_party_aesthetic_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(-28, 251)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CakesNMore.My.Resources.Resources.download__3__removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(555, 208)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(197, 195)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'lblCustomisation
        '
        Me.lblCustomisation.AutoSize = True
        Me.lblCustomisation.Location = New System.Drawing.Point(191, 83)
        Me.lblCustomisation.Name = "lblCustomisation"
        Me.lblCustomisation.Size = New System.Drawing.Size(179, 20)
        Me.lblCustomisation.TabIndex = 16
        Me.lblCustomisation.Text = "Customisation Request:"
        '
        'txtCustomisation
        '
        Me.txtCustomisation.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtCustomisation.Location = New System.Drawing.Point(373, 80)
        Me.txtCustomisation.Name = "txtCustomisation"
        Me.txtCustomisation.Size = New System.Drawing.Size(188, 96)
        Me.txtCustomisation.TabIndex = 17
        Me.txtCustomisation.Text = ""
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtCustomisation)
        Me.Controls.Add(Me.lblCustomisation)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtOccassion)
        Me.Controls.Add(Me.lblOccassion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Form2"
        Me.Text = " Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdo8InchCake As RadioButton
    Friend WithEvents rdoTieredCake As RadioButton
    Friend WithEvents rdoSpecialtyCake As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblOccassion As Label
    Friend WithEvents txtOccassion As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblCustomisation As Label
    Friend WithEvents txtCustomisation As RichTextBox
End Class
