Class MainMenu
    Implements IMenu
    Sub intitialize() implements IMenu.Start
        Console.WriteLine(" Hello I'm miss kitty")
        dim repeat as Boolean = true
        Do While repeat
        Console.WriteLine("What shall I do?")
        Console.WriteLine("[0] MEOW")
        Console.Writeline("[1] Purr")
        Console.WriteLine("[2] Eat")
        Console.WriteLine("[x] Sleep")
        Dim input as string = Console.ReadLine()
        Select Case input
            Case "0"
                Console.WriteLine("Meow Meow Meow")
            Case "1"
                Console.WriteLine("Purr Purr Purr")
            Case "2"
                Console.WriteLine("Crunch Crunch Crunch")
            Case "x"
                Console.WriteLine("Zzzzzzzzzzzzzzz")
                repeat = false
        End Select
        Loop       

    End Sub
End  Class