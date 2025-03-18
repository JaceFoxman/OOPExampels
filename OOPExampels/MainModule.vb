Module MainModule

    Sub Main()
        'DoSomethingInMainModule()
        'DoSomethingInSecondModule()
        MsgBox(ExampleClass.SumOf(4, 3))

        Dim jimmy As New Animal
        Dim bob As New Mammal
        Dim lucky As New Dog
        Dim pepe As New Dog
        Dim goldee As New Fish
        Dim sparrow As New Bird

        jimmy.Move()
        Console.WriteLine(jimmy.skinType)
        bob.Move()
        Console.WriteLine(bob.skinType)
        lucky.Move()
        Console.WriteLine(lucky.skinType)
        Console.WriteLine(lucky.speak)

        pepe.movement = "shiver"
        pepe.skinType = "hairless rat"
        Console.WriteLine(pepe.speak)
        pepe.Move()

        goldee.Move()
        Console.WriteLine(goldee.skinType)
        Console.WriteLine(goldee.speak)

        sparrow.Move()
        Console.WriteLine(sparrow.skinType)
        Console.WriteLine(sparrow.speak)
    End Sub


    Sub DoSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub

End Module
