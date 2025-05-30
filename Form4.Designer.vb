<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnSubmitOrder = New System.Windows.Forms.Button()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtCount8 = New System.Windows.Forms.TextBox()
        Me.txtCountTiered = New System.Windows.Forms.TextBox()
        Me.txtCountSpecialty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPriceSpecialty = New System.Windows.Forms.TextBox()
        Me.txtPriceTiered = New System.Windows.Forms.TextBox()
        Me.txtPrice8 = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmitOrder
        '
        Me.btnSubmitOrder.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnSubmitOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubmitOrder.Location = New System.Drawing.Point(404, 335)
        Me.btnSubmitOrder.Name = "btnSubmitOrder"
        Me.btnSubmitOrder.Size = New System.Drawing.Size(130, 56)
        Me.btnSubmitOrder.TabIndex = 14
        Me.btnSubmitOrder.Text = "SUBMIT ORDER"
        Me.btnSubmitOrder.UseVisualStyleBackColor = False
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.BackColor = System.Drawing.Color.Pink
        Me.btnCalculateTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateTotal.Location = New System.Drawing.Point(233, 335)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(130, 56)
        Me.btnCalculateTotal.TabIndex = 13
        Me.btnCalculateTotal.Text = "CALCULATE TOTAL"
        Me.btnCalculateTotal.UseVisualStyleBackColor = False
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPrice.Font = New System.Drawing.Font("Lucida Fax", 8.0!)
        Me.lblTotalPrice.Location = New System.Drawing.Point(198, 279)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(366, 39)
        Me.lblTotalPrice.TabIndex = 12
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(172, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 31)
        Me.lblName.TabIndex = 15
        '
        'txtCount8
        '
        Me.txtCount8.Location = New System.Drawing.Point(198, 108)
        Me.txtCount8.Name = "txtCount8"
        Me.txtCount8.Size = New System.Drawing.Size(40, 26)
        Me.txtCount8.TabIndex = 16
        '
        'txtCountTiered
        '
        Me.txtCountTiered.Location = New System.Drawing.Point(198, 154)
        Me.txtCountTiered.Name = "txtCountTiered"
        Me.txtCountTiered.Size = New System.Drawing.Size(40, 26)
        Me.txtCountTiered.TabIndex = 17
        '
        'txtCountSpecialty
        '
        Me.txtCountSpecialty.Location = New System.Drawing.Point(198, 200)
        Me.txtCountSpecialty.Name = "txtCountSpecialty"
        Me.txtCountSpecialty.Size = New System.Drawing.Size(40, 26)
        Me.txtCountSpecialty.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "8-inch Cake           $75"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tiered Cake         $300"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Specialty Cake    $500"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "10% Tax"
        '
        'txtPriceSpecialty
        '
        Me.txtPriceSpecialty.Location = New System.Drawing.Point(466, 197)
        Me.txtPriceSpecialty.Name = "txtPriceSpecialty"
        Me.txtPriceSpecialty.Size = New System.Drawing.Size(68, 26)
        Me.txtPriceSpecialty.TabIndex = 25
        '
        'txtPriceTiered
        '
        Me.txtPriceTiered.Location = New System.Drawing.Point(466, 151)
        Me.txtPriceTiered.Name = "txtPriceTiered"
        Me.txtPriceTiered.Size = New System.Drawing.Size(68, 26)
        Me.txtPriceTiered.TabIndex = 24
        '
        'txtPrice8
        '
        Me.txtPrice8.Location = New System.Drawing.Point(466, 105)
        Me.txtPrice8.Name = "txtPrice8"
        Me.txtPrice8.Size = New System.Drawing.Size(68, 26)
        Me.txtPrice8.TabIndex = 23
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(466, 243)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(68, 26)
        Me.txtTax.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CakesNMore.My.Resources.Resources.download__6__removebg_preview1
        Me.PictureBox1.Location = New System.Drawing.Point(64, 340)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CakesNMore.My.Resources.Resources.af4277eb_1e04_4796_a8e5_ca64c58f798b_removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(683, 279)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 174)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CakesNMore.My.Resources.Resources.My_amazing_Marie_Antoinette_inspired_wedding_cake_made_at_the_Bellagio__Las_Vegas__removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(525, 200)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(169, 202)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.CakesNMore.My.Resources.Resources.download__6__removebg_preview1
        Me.PictureBox4.Location = New System.Drawing.Point(29, 230)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(163, 113)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.CakesNMore.My.Resources.Resources.download__6__removebg_preview1
        Me.PictureBox5.Location = New System.Drawing.Point(51, 123)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(163, 113)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.CakesNMore.My.Resources.Resources.download__6__removebg_preview1
        Me.PictureBox6.Location = New System.Drawing.Point(-4, -2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(170, 130)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 34
        Me.PictureBox6.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtPriceSpecialty)
        Me.Controls.Add(Me.txtPriceTiered)
        Me.Controls.Add(Me.txtPrice8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCountSpecialty)
        Me.Controls.Add(Me.txtCountTiered)
        Me.Controls.Add(Me.txtCount8)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSubmitOrder)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "Form4"
        Me.Text = "Summary"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmitOrder As Button
    Friend WithEvents btnCalculateTotal As Button
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtCount8 As TextBox
    Friend WithEvents txtCountTiered As TextBox
    Friend WithEvents txtCountSpecialty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPriceSpecialty As TextBox
    Friend WithEvents txtPriceTiered As TextBox
    Friend WithEvents txtPrice8 As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
