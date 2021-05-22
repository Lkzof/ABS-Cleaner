<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FPSBoostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CleanerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AntiMalwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Cleaner = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Booster = New System.Windows.Forms.Panel()
		Me.BoostBar = New System.Windows.Forms.ProgressBar()
		Me.ButtonBooster = New System.Windows.Forms.Button()
		Me.AntiMalware = New System.Windows.Forms.Panel()
		Me.ValorEscaneado = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ChecarVirus = New System.Windows.Forms.Button()
		Me.Escaneador = New System.Windows.Forms.Timer(Me.components)
		Me.Boosting = New System.Windows.Forms.Timer(Me.components)
		Me.labelUpdate = New System.Windows.Forms.Label()
		Me.MenuStrip1.SuspendLayout()
		Me.Cleaner.SuspendLayout()
		Me.Booster.SuspendLayout()
		Me.AntiMalware.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FPSBoostToolStripMenuItem, Me.CleanerToolStripMenuItem, Me.AntiMalwareToolStripMenuItem, Me.AjudaToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(820, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FPSBoostToolStripMenuItem
		'
		Me.FPSBoostToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.FPSBoostToolStripMenuItem.Name = "FPSBoostToolStripMenuItem"
		Me.FPSBoostToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
		Me.FPSBoostToolStripMenuItem.Text = "FPS Boost"
		'
		'CleanerToolStripMenuItem
		'
		Me.CleanerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.CleanerToolStripMenuItem.Name = "CleanerToolStripMenuItem"
		Me.CleanerToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
		Me.CleanerToolStripMenuItem.Text = "Cleaner"
		'
		'AntiMalwareToolStripMenuItem
		'
		Me.AntiMalwareToolStripMenuItem.ForeColor = System.Drawing.Color.Red
		Me.AntiMalwareToolStripMenuItem.Name = "AntiMalwareToolStripMenuItem"
		Me.AntiMalwareToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
		Me.AntiMalwareToolStripMenuItem.Text = "Anti-Malware"
		'
		'AjudaToolStripMenuItem
		'
		Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
		Me.AjudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
		Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
		Me.AjudaToolStripMenuItem.Text = "Ajuda"
		'
		'SobreToolStripMenuItem
		'
		Me.SobreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
		Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.SobreToolStripMenuItem.Text = "Sobre"
		'
		'Cleaner
		'
		Me.Cleaner.Controls.Add(Me.Label2)
		Me.Cleaner.Controls.Add(Me.Button3)
		Me.Cleaner.Controls.Add(Me.Button2)
		Me.Cleaner.Controls.Add(Me.Button1)
		Me.Cleaner.Location = New System.Drawing.Point(12, 40)
		Me.Cleaner.Name = "Cleaner"
		Me.Cleaner.Size = New System.Drawing.Size(809, 516)
		Me.Cleaner.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(23, 131)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(512, 25)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Exclua esses arquivos para obter desempenho:"
		'
		'Button3
		'
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.ForeColor = System.Drawing.Color.Aqua
		Me.Button3.Location = New System.Drawing.Point(583, 206)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(124, 81)
		Me.Button3.TabIndex = 2
		Me.Button3.Text = "Limpar %temp%"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.ForeColor = System.Drawing.Color.Aqua
		Me.Button2.Location = New System.Drawing.Point(301, 206)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(124, 81)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Limpar Prefetch"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.ForeColor = System.Drawing.Color.Aqua
		Me.Button1.Location = New System.Drawing.Point(28, 206)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(124, 81)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Limpar arquivos temporários"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Booster
		'
		Me.Booster.Controls.Add(Me.BoostBar)
		Me.Booster.Controls.Add(Me.ButtonBooster)
		Me.Booster.Location = New System.Drawing.Point(3, 27)
		Me.Booster.Name = "Booster"
		Me.Booster.Size = New System.Drawing.Size(809, 529)
		Me.Booster.TabIndex = 2
		'
		'BoostBar
		'
		Me.BoostBar.BackColor = System.Drawing.SystemColors.WindowFrame
		Me.BoostBar.Location = New System.Drawing.Point(173, 434)
		Me.BoostBar.Name = "BoostBar"
		Me.BoostBar.Size = New System.Drawing.Size(427, 47)
		Me.BoostBar.TabIndex = 1
		'
		'ButtonBooster
		'
		Me.ButtonBooster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonBooster.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonBooster.ForeColor = System.Drawing.SystemColors.Highlight
		Me.ButtonBooster.Location = New System.Drawing.Point(173, 150)
		Me.ButtonBooster.Name = "ButtonBooster"
		Me.ButtonBooster.Size = New System.Drawing.Size(427, 218)
		Me.ButtonBooster.TabIndex = 0
		Me.ButtonBooster.Text = "FPS Boost"
		Me.ButtonBooster.UseVisualStyleBackColor = True
		'
		'AntiMalware
		'
		Me.AntiMalware.Controls.Add(Me.ValorEscaneado)
		Me.AntiMalware.Controls.Add(Me.Label1)
		Me.AntiMalware.Controls.Add(Me.ChecarVirus)
		Me.AntiMalware.Location = New System.Drawing.Point(0, 27)
		Me.AntiMalware.Name = "AntiMalware"
		Me.AntiMalware.Size = New System.Drawing.Size(809, 484)
		Me.AntiMalware.TabIndex = 3
		'
		'ValorEscaneado
		'
		Me.ValorEscaneado.AutoSize = True
		Me.ValorEscaneado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ValorEscaneado.ForeColor = System.Drawing.Color.Red
		Me.ValorEscaneado.Location = New System.Drawing.Point(360, 286)
		Me.ValorEscaneado.Name = "ValorEscaneado"
		Me.ValorEscaneado.Size = New System.Drawing.Size(30, 31)
		Me.ValorEscaneado.TabIndex = 2
		Me.ValorEscaneado.Text = "0"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ScrollBar
		Me.Label1.Location = New System.Drawing.Point(292, 142)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(176, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Escanear virus em seu computador:"
		'
		'ChecarVirus
		'
		Me.ChecarVirus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ChecarVirus.ForeColor = System.Drawing.Color.Red
		Me.ChecarVirus.Location = New System.Drawing.Point(295, 184)
		Me.ChecarVirus.Name = "ChecarVirus"
		Me.ChecarVirus.Size = New System.Drawing.Size(180, 79)
		Me.ChecarVirus.TabIndex = 0
		Me.ChecarVirus.Text = "Escanear"
		Me.ChecarVirus.UseVisualStyleBackColor = True
		'
		'Escaneador
		'
		'
		'Boosting
		'
		'
		'labelUpdate
		'
		Me.labelUpdate.AutoSize = True
		Me.labelUpdate.BackColor = System.Drawing.SystemColors.WindowFrame
		Me.labelUpdate.ForeColor = System.Drawing.Color.Red
		Me.labelUpdate.Location = New System.Drawing.Point(479, 9)
		Me.labelUpdate.Name = "labelUpdate"
		Me.labelUpdate.Size = New System.Drawing.Size(329, 13)
		Me.labelUpdate.TabIndex = 4
		Me.labelUpdate.Text = "UMA ATUALIZAÇÃO ESTÁ DISPONIVEL, BAIXE-A EM: SITE.COM"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.WindowText
		Me.ClientSize = New System.Drawing.Size(820, 568)
		Me.Controls.Add(Me.labelUpdate)
		Me.Controls.Add(Me.Booster)
		Me.Controls.Add(Me.AntiMalware)
		Me.Controls.Add(Me.Cleaner)
		Me.Controls.Add(Me.MenuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Name = "Form1"
		Me.Text = "ABS Plus+"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.Cleaner.ResumeLayout(False)
		Me.Cleaner.PerformLayout()
		Me.Booster.ResumeLayout(False)
		Me.AntiMalware.ResumeLayout(False)
		Me.AntiMalware.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FPSBoostToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CleanerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AntiMalwareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Cleaner As Panel
    Friend WithEvents Booster As Panel
    Friend WithEvents AntiMalware As Panel
    Friend WithEvents ValorEscaneado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ChecarVirus As Button
    Friend WithEvents Escaneador As Timer
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonBooster As Button
    Friend WithEvents Boosting As Timer
    Friend WithEvents BoostBar As ProgressBar
    Friend WithEvents labelUpdate As Label
End Class
