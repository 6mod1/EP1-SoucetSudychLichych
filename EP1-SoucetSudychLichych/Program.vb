Imports System


Module Program
    Sub Main(args As String())
        Dim vstup As String
        Dim soucet As Integer = 0
        Dim cislo As Integer

        Do
            Console.WriteLine("Zadej číslo: ")
            vstup = Console.ReadLine

            If vstup > 0 Then
                If vstup < 10 Then
                    If Integer.TryParse(vstup, cislo) Then
                        For i = 1 To cislo
                            soucet = soucet + i
                        Next
                        Console.WriteLine($"Součet od 1 do {cislo} je {soucet}")
                    Else
                        Console.WriteLine("Chyba musíte zadat jen celá čísla")
                    End If
                Else
                    Console.WriteLine("Zadali jste moc velkou hodnotu.")
                End If
            Else
                Console.WriteLine("Nelze počítat se zápornými čísly")
            End If
        Loop



    End Sub
End Module
