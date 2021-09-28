<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCalculadora
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnDivisao = New System.Windows.Forms.RadioButton()
        Me.rbtnMultiplicacao = New System.Windows.Forms.RadioButton()
        Me.rbtnSubtracao = New System.Windows.Forms.RadioButton()
        Me.rbtnSoma = New System.Windows.Forms.RadioButton()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor 2:"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(119, 30)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 2
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(119, 68)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnDivisao)
        Me.GroupBox1.Controls.Add(Me.rbtnMultiplicacao)
        Me.GroupBox1.Controls.Add(Me.rbtnSubtracao)
        Me.GroupBox1.Controls.Add(Me.rbtnSoma)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operação:"
        '
        'rbtnDivisao
        '
        Me.rbtnDivisao.AutoSize = True
        Me.rbtnDivisao.Location = New System.Drawing.Point(102, 61)
        Me.rbtnDivisao.Name = "rbtnDivisao"
        Me.rbtnDivisao.Size = New System.Drawing.Size(60, 17)
        Me.rbtnDivisao.TabIndex = 3
        Me.rbtnDivisao.Text = "Divisão"
        Me.rbtnDivisao.UseVisualStyleBackColor = True
        '
        'rbtnMultiplicacao
        '
        Me.rbtnMultiplicacao.AutoSize = True
        Me.rbtnMultiplicacao.Location = New System.Drawing.Point(102, 28)
        Me.rbtnMultiplicacao.Name = "rbtnMultiplicacao"
        Me.rbtnMultiplicacao.Size = New System.Drawing.Size(87, 17)
        Me.rbtnMultiplicacao.TabIndex = 2
        Me.rbtnMultiplicacao.Text = "Multiplicação"
        Me.rbtnMultiplicacao.UseVisualStyleBackColor = True
        '
        'rbtnSubtracao
        '
        Me.rbtnSubtracao.AutoSize = True
        Me.rbtnSubtracao.Location = New System.Drawing.Point(11, 61)
        Me.rbtnSubtracao.Name = "rbtnSubtracao"
        Me.rbtnSubtracao.Size = New System.Drawing.Size(74, 17)
        Me.rbtnSubtracao.TabIndex = 1
        Me.rbtnSubtracao.Text = "Subtração"
        Me.rbtnSubtracao.UseVisualStyleBackColor = True
        '
        'rbtnSoma
        '
        Me.rbtnSoma.AutoSize = True
        Me.rbtnSoma.Checked = True
        Me.rbtnSoma.Location = New System.Drawing.Point(11, 28)
        Me.rbtnSoma.Name = "rbtnSoma"
        Me.rbtnSoma.Size = New System.Drawing.Size(52, 17)
        Me.rbtnSoma.TabIndex = 0
        Me.rbtnSoma.TabStop = True
        Me.rbtnSoma.Text = "Soma"
        Me.rbtnSoma.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(47, 234)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(85, 23)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(149, 234)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'formCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 287)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formCalculadora"
        Me.Text = "Calculadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtValor1 As System.Windows.Forms.TextBox
    Friend WithEvents txtValor2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnDivisao As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMultiplicacao As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSubtracao As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSoma As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button

End Class
