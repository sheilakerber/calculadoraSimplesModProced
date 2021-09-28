Public Class formCalculadora

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ' valida dados de entrada
        ' obs: radio buttons nao validados, pois "soma" eh configurado como default
        If (txtValor1.Text = Nothing Or Not IsNumeric(txtValor1.Text) Or txtValor2.Text = Nothing Or Not IsNumeric(txtValor2.Text)) Then
            MsgBox("Algum valor não foi preenchido ou não é um valor válido.", MsgBoxStyle.Critical, "Verifique seus dados!")
            Exit Sub
        End If

        ' guardar os dois valores do calculo
        Dim valor1 As Integer = txtValor1.Text
        Dim valor2 As Integer = txtValor2.Text

        ' operacao soma
        If (rbtnSoma.Checked) Then
            MsgBox("Resultado: " & modCalcular.soma(valor1, valor2))        ' calculo utilizando o modulo modCalcular e funcao soma(valor1, valor2)
            modLimparCampos.limparcampos()                                  ' limpando os campos utilizando procedimento e modulo
        End If

        ' operacao subtracao
        If (rbtnSubtracao.Checked) Then
            MsgBox("Resultado: " & modCalcular.subtrair(valor1, valor2))    ' calculo utilizando o modulo modCalcular e funcao subtrair(valor1, valor2)
            modLimparCampos.limparcampos()                                  ' limpando os campos utilizando procedimento e modulo
            Exit Sub
        End If

        ' operacao multiplicacao
        If (rbtnMultiplicacao.Checked) Then
            MsgBox("Resultado: " & modCalcular.multiplicar(valor1, valor2)) ' calculo utilizando o modulo modCalcular e funcao multiplicar(valor1, valor2)
            modLimparCampos.limparcampos()                                  ' limpando os campos utilizando procedimento e modulo
            Exit Sub
        End If

        ' operacao divisao
        If (rbtnDivisao.Checked) Then
            MsgBox("Resultado: " & modCalcular.dividir(valor1, valor2))     ' calculo utilizando o modulo modCalcular e funcao dividir(valor1, valor2)
            modLimparCampos.limparcampos()                                  ' limpando os campos utilizando procedimento e modulo
            Exit Sub
        End If
        Exit Sub
    End Sub

    ' cancela/limpa os valores inseridos
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        modLimparCampos.limparcampos()              ' limpando os campos utilizando procedimento e modulo
        Exit Sub
    End Sub
End Class
