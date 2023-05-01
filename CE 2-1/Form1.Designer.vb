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
        Me.numberOfTimesText = New System.Windows.Forms.TextBox()
        Me.moviesGamesText = New System.Windows.Forms.TextBox()
        Me.numberOfTimesLabel = New System.Windows.Forms.Label()
        Me.movieButton = New System.Windows.Forms.Button()
        Me.moviesGamesLabel = New System.Windows.Forms.Label()
        Me.clicksLabel = New System.Windows.Forms.Label()
        Me.clicksText = New System.Windows.Forms.TextBox()
        Me.gameButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'numberOfTimesText
        '
        Me.numberOfTimesText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberOfTimesText.Location = New System.Drawing.Point(295, 44)
        Me.numberOfTimesText.Multiline = True
        Me.numberOfTimesText.Name = "numberOfTimesText"
        Me.numberOfTimesText.Size = New System.Drawing.Size(167, 35)
        Me.numberOfTimesText.TabIndex = 0
        '
        'moviesGamesText
        '
        Me.moviesGamesText.Location = New System.Drawing.Point(295, 96)
        Me.moviesGamesText.Multiline = True
        Me.moviesGamesText.Name = "moviesGamesText"
        Me.moviesGamesText.ReadOnly = True
        Me.moviesGamesText.Size = New System.Drawing.Size(262, 190)
        Me.moviesGamesText.TabIndex = 1
        '
        'numberOfTimesLabel
        '
        Me.numberOfTimesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberOfTimesLabel.Location = New System.Drawing.Point(79, 44)
        Me.numberOfTimesLabel.Name = "numberOfTimesLabel"
        Me.numberOfTimesLabel.Size = New System.Drawing.Size(210, 35)
        Me.numberOfTimesLabel.TabIndex = 2
        Me.numberOfTimesLabel.Text = "Number of Times:"
        '
        'movieButton
        '
        Me.movieButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movieButton.Location = New System.Drawing.Point(84, 354)
        Me.movieButton.Name = "movieButton"
        Me.movieButton.Size = New System.Drawing.Size(229, 39)
        Me.movieButton.TabIndex = 6
        Me.movieButton.Text = "Movies"
        Me.movieButton.UseVisualStyleBackColor = True
        '
        'moviesGamesLabel
        '
        Me.moviesGamesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moviesGamesLabel.Location = New System.Drawing.Point(79, 96)
        Me.moviesGamesLabel.Name = "moviesGamesLabel"
        Me.moviesGamesLabel.Size = New System.Drawing.Size(210, 35)
        Me.moviesGamesLabel.TabIndex = 8
        Me.moviesGamesLabel.Text = "Movies/Games:"
        '
        'clicksLabel
        '
        Me.clicksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clicksLabel.Location = New System.Drawing.Point(79, 291)
        Me.clicksLabel.Name = "clicksLabel"
        Me.clicksLabel.Size = New System.Drawing.Size(210, 35)
        Me.clicksLabel.TabIndex = 9
        Me.clicksLabel.Text = "Number of Clicks:"
        '
        'clicksText
        '
        Me.clicksText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clicksText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clicksText.Location = New System.Drawing.Point(295, 291)
        Me.clicksText.Multiline = True
        Me.clicksText.Name = "clicksText"
        Me.clicksText.ReadOnly = True
        Me.clicksText.Size = New System.Drawing.Size(262, 35)
        Me.clicksText.TabIndex = 10
        '
        'gameButton
        '
        Me.gameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameButton.Location = New System.Drawing.Point(328, 354)
        Me.gameButton.Name = "gameButton"
        Me.gameButton.Size = New System.Drawing.Size(229, 39)
        Me.gameButton.TabIndex = 11
        Me.gameButton.Text = "Games"
        Me.gameButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gameButton)
        Me.Controls.Add(Me.clicksText)
        Me.Controls.Add(Me.clicksLabel)
        Me.Controls.Add(Me.moviesGamesLabel)
        Me.Controls.Add(Me.movieButton)
        Me.Controls.Add(Me.numberOfTimesLabel)
        Me.Controls.Add(Me.moviesGamesText)
        Me.Controls.Add(Me.numberOfTimesText)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numberOfTimesText As TextBox
    Friend WithEvents moviesGamesText As TextBox
    Friend WithEvents numberOfTimesLabel As Label
    Friend WithEvents movieButton As Button
    Friend WithEvents moviesGamesLabel As Label
    Friend WithEvents clicksLabel As Label
    Friend WithEvents clicksText As TextBox
    Friend WithEvents gameButton As Button
End Class
