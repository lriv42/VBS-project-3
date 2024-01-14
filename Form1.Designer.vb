<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstRates = New System.Windows.Forms.ListBox()
        Me.lstYears = New System.Windows.Forms.ListBox()
        Me.txtAmtFinanced = New System.Windows.Forms.TextBox()
        Me.lblMonthPayment = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstRates
        '
        Me.lstRates.FormattingEnabled = True
        Me.lstRates.ItemHeight = 16
        Me.lstRates.Location = New System.Drawing.Point(255, 52)
        Me.lstRates.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstRates.Name = "lstRates"
        Me.lstRates.Size = New System.Drawing.Size(167, 196)
        Me.lstRates.TabIndex = 1
        '
        'lstYears
        '
        Me.lstYears.FormattingEnabled = True
        Me.lstYears.ItemHeight = 16
        Me.lstYears.Location = New System.Drawing.Point(481, 52)
        Me.lstYears.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstYears.Name = "lstYears"
        Me.lstYears.Size = New System.Drawing.Size(148, 196)
        Me.lstYears.TabIndex = 2
        '
        'txtAmtFinanced
        '
        Me.txtAmtFinanced.Location = New System.Drawing.Point(80, 52)
        Me.txtAmtFinanced.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmtFinanced.Name = "txtAmtFinanced"
        Me.txtAmtFinanced.Size = New System.Drawing.Size(131, 22)
        Me.txtAmtFinanced.TabIndex = 0
        '
        'lblMonthPayment
        '
        Me.lblMonthPayment.AutoSize = True
        Me.lblMonthPayment.BackColor = System.Drawing.SystemColors.Info
        Me.lblMonthPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthPayment.Location = New System.Drawing.Point(251, 330)
        Me.lblMonthPayment.MinimumSize = New System.Drawing.Size(387, 62)
        Me.lblMonthPayment.Name = "lblMonthPayment"
        Me.lblMonthPayment.Size = New System.Drawing.Size(387, 62)
        Me.lblMonthPayment.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.SystemColors.Info
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(80, 116)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(108, 47)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "C&alculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Firebrick
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(80, 202)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 47)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Ex&it"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Principle Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 332)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 58)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Your Monthly " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Payment is:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(252, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 34)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Interest Rate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Percentage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(481, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Year Length of Loan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblMonthPayment)
        Me.Controls.Add(Me.txtAmtFinanced)
        Me.Controls.Add(Me.lstYears)
        Me.Controls.Add(Me.lstRates)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Loan Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRates As ListBox
    Friend WithEvents lstYears As ListBox
    Friend WithEvents txtAmtFinanced As TextBox
    Friend WithEvents lblMonthPayment As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
