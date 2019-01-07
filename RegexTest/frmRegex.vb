Public Class frmRegex

    Public ListasRegexDescr() As String = {"([^ ]+) *", "parametros separados por espaço "" """, _
    "(?<dia>\d{1,2})/(?<mes>\d{1,2})/(?<ano>\d{2,4})(?<compl>$|.*)", "obtém grupos nominais. acesso através de match.group(""dia"")", _
    "\<[pP]\>[^\>]*\<\/[pP]\>", "para pegar tag e conteúdo entre tags", _
    "[-+]?([0-9]*\.[0-9]+|[0-9]+)", "sinal opcional, numérico e decimal", _
    "(palavra1|palavra2|palavra3)(?:\W+\w+){1,6}?\W+(palavra1|palavra2|palavra3)", "uma palavra perto da outra não importando a ordem", _
    "^(?!.*(svn|cvs|nvs|mvc)).*$", "Isto irá corresponder ao texto se ele não contiver um svn, cvs, nvs ou mvc.", _
    "([0-9.]+) ?(px|PX)?", "quebra tipo de ponto ex:""300px""", _
    "([^:]*):([^;]*)(;|$)", "separa atributos de css em param(1) e conteudo(2)", _
    "(\w+)", "busca de palavras na expressão", _
    "(?<=( #|@|\?))(?=\w+)\w+\b", "obtém parâmetros num sql ", _
    "^(?[^@]+)@(?.+)$", "email", _
    "^-?\d+(\.\d{2})?$", "valor", _
    ".", "qualquer caracter", _
    "[abc0-9]", "naquela posição qualquer destes 0-9 ex intervalo", _
    "[^abc]", "nenhum destes caract", _
    "^", "início da linha", _
    "$", "final da linha", _
    "|", "ou, expressão condicional", _
    "?", "inexiste ou existência de apenas um", _
    "\d", "dígito ", _
    "\D", "não dígito ", _
    "\w", "palavra", _
    "\W", "não palavra", _
    "[:@\?]\w+", "obtem parâmetros de sql", _
    "*", "repete nenhuma ou mais vezes", _
    "+", "repete uma ou mais vezes", _
    "{n}", "repete n vezes", _
    "{n,}", "repete no mínimo n vezes", _
    "{n,m}", "repete entre n e m vezes ", _
    "[[:alnum:]]", "caracteres alfanuméricos", _
    "[[:alpha:]]", "caracteres alfabéticos", _
    "[[:blank:]]", "caracteres de espaço", _
    "[[:cntrl:]]", "caracteres de controle", _
    "[[:digit:]]", "0 through 9, or [0-9]", _
    "[[:graph:]]", "[[:punct:]] + [[:upper:]] + [[:lower:]] + [[:digit:]]", _
    "[[:lower:]]", "lowercase alphabetic characters", _
    "[[:print:]]", "caracteres imprimíveis", _
    "[[:punct:]]", "cacacteres de pontuação", _
    "[[:space:]]", "caracteres não imprimíveis", _
    "[[:upper:]]", "caracteres alfabéticos maiúsculos", _
    "[[:xdigit:]]", "caracteres hexadecimais", _
    "\xff", "FF representa o código ASCII do caracter", _
    "\n", "nova linha ou código 10 ASCII", _
    "\r", "código 13, ASCII é claro", _
    "\r\n", "CRLF do DOS", _
    "\t", "código TAB ou 9 ASCII", _
    "(?:...)", "ignorar este grupo na numeração", _
    "(?<g1>...)", "definir nome para o grupo", _
    "|", "condicional", _
    "^", "início", _
    "[abc]", "opções de caracter", _
    "[^abd]", "nenhum destes caracteres", _
    "(?<=...)XXX", "precedido por", _
    "(?<!...)XXX", "não precedido por", _
    "\r", "retorno de carro cod 13 ASCII", _
    "\n", "nova linha cod 10 ASCII", _
    "<.*>", "captura mais genérica buscando primeiro ""<"" e último "">""", _
    "<.*?>", "busca menos genérica buscando primeiro ""<"" e próximo "">""", _
    "\b(td|table|tr)\b", "buscar por palavras ao invés de letras", _
    "\1", "considera primeiro grupo encontrado", _
    "\k<tag>", "considera grupo capturado com este nome", _
    "(?is)", "spam para ignorar maiúsculas e minúsculas e linha simples", _
    "(?im)", "spam para ignorar maiúsculas e minúsculas e muitas linhas", _
    "(?-i-s-m)", "desabilitar spams ignore-case, single-line e multi-line", _
    "COD: Dim r As New System.Text.RegularExpressions.Regex(""(( |\t){1,}"" & i.Key & "" {0,}= {0,}\"""").*(\"""")"")", "exemplo de comando em asp.net para replace", _
    "COD: Texto = r.Replace(Texto, ""$1\ "" & i.Value & ""\ $3"")", "exemplo de replace fazendo uso de grupo (ex.:$1 e $3)", _
    "COD: ? regex.Match(""<td style='test;um;dois'>conteudo teste</td>"",""<(?<tag>.*?)(?: (?<atribs>.*?))?>(?<conteudo>.*?)</\1>"").Value", "Resultado: ""<td style='test;um;dois'>conteudo teste</td>""", _
    "COD: ? regex.Match(""<td style='test;um;dois'>conteudo teste</td>"",""<(?<tag>.*?)(?: (?<atribs>.*?))?>(?<conteudo>.*?)</\<tag>>"").Value", "Resultado: ""<td style='test;um;dois'>conteudo teste</td>"""}

    Private Sub frmRegex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstMatches.Items.Clear()
        Try
            For Z As Integer = 0 To ListasRegexDescr.Count - 1 Step 2
                System.Diagnostics.Debug.Print(ListasRegexDescr(Z))
                lstMatches.Items.Add(ListasRegexDescr(Z) & " => " & ListasRegexDescr(Z + 1))
            Next

            For Z As Integer = 0 To ListasRegexDescr.Count - 1 Step 2
                System.Diagnostics.Debug.Print(ListasRegexDescr(Z + 1))
            Next

        Catch
        End Try
    End Sub

    Private Sub lstMatches_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMatches.SelectedIndexChanged
        txtMasc.Text = Split(lstMatches.SelectedItem, " => ")(0)
    End Sub

    Private Sub txtMasc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMasc.TextChanged
        Muda()
    End Sub

    Private Sub txtTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTxt.TextChanged
        Muda()
    End Sub


    Function Texto() As String
        Try
            Return txtTxt.Text
        Catch
        End Try
        Return ""
    End Function

    Sub Muda()
        lstResult.Items.Clear()

        If rdoTipo.Checked Then
            Try
                Dim Reg As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(Texto, txtMasc.Text)
                For z As Integer = 0 To Reg.Groups.Count - 1
                    lstResult.Items.Add(Reg.Groups(z).Value)
                Next
            Catch ex As Exception
            End Try

        ElseIf rdoTipo2.Checked Then
            Try
                For Each LINHA As String In Split(Replace(Texto, vbCrLf, Chr(10)), Chr(10))
                    If System.Text.RegularExpressions.Regex.Match(LINHA, txtMasc.Text).Success Then
                        lstResult.Items.Add(LINHA)
                    End If
                Next
            Catch
            End Try
        ElseIf rdoTipo3.Checked Then
            Try
                For Each Reg As System.Text.RegularExpressions.Match In System.Text.RegularExpressions.Regex.Matches(Texto, txtMasc.Text)
                    lstResult.Items.Add(Reg.Groups(0).Value)
                Next
            Catch
            End Try
        End If

        lstSplit.Items.Clear()
        If chkSplit.Checked Then
            Try
                For Each Item As String In System.Text.RegularExpressions.Regex.Split(Texto, txtMasc.Text)
                    lstSplit.Items.Add(Item)
                Next
            Catch
            End Try
        End If
    End Sub

    Private Sub chkArquivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Muda()
    End Sub

    Private Sub chkSplit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSplit.CheckedChanged
        Muda()
    End Sub

    Private Sub rdoTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoTipo.CheckedChanged
        Muda()
    End Sub

    Private Sub txtTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Muda()
    End Sub

    Private Sub btnCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopia.Click
        On Error Resume Next
        Dim Ret As String = ""
        For Each Linha As String In lstResult.Items
            Ret &= IIf(Ret <> "", vbCrLf, "") & Linha
        Next
        Clipboard.Clear()
        Clipboard.SetText(Ret)
    End Sub
End Class