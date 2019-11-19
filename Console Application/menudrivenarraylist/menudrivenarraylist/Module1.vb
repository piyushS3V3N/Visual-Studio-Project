Module Module1
    Dim al As ArrayList = New ArrayList
    Dim num As String
    Sub Main()
        Dim ch As Integer
        Do
            Console.WriteLine("Enter your choice : 1. Create a array list 2. Add an element 3. Insert 4. Remove 5. Remove At 6. Sort 7. Count 8. Reverse 9. Contains 10. Item")
            Console.WriteLine("Enter 0 to exit :)")
            ch = Console.ReadLine
            Select Case ch
                Case (1)
                    Initlist()
                Case (2)
                    addinlist()
                Case (3)
                    insertintolist()
                Case (4)
                    al.Remove(al.Capacity)
                Case (5)
                    Console.WriteLine("Enter the position at which you want to delete data :")
                    Dim pos As Integer = Console.ReadLine()
                    pos = pos - 1
                    al.RemoveAt(pos)
                Case (6)
                    Sortlist()
                Case (7)
                    Console.WriteLine(al.Count)
                Case (8)
                    al.Reverse()
                    displaylist()
                Case (9)
                    searchinarray()
                Case (10)
                    Console.WriteLine("Enter the location : ")
                    Dim pos As Integer = Console.ReadLine
                    pos = pos - 1
                    Console.WriteLine("Item : {0}", al.Item(pos))
                Case (0)
                    Console.WriteLine("Exiting !!")
                Case Else
                    Console.WriteLine("Error invalid choice entered")
            End Select
            Console.ReadKey()
            Console.Clear()
        Loop Until (ch = 0)
    End Sub
    Sub Initlist()
        al.Clear()
        Console.WriteLine("Enter some number to be entered in list : ")
        While (True)
            num = Console.ReadLine()
            If (num = "") Then
                Exit While
            Else
                al.Add(num)
            End If
        End While
        displaylist()
        Console.WriteLine("Done")

    End Sub
    Sub displaylist()
        Console.WriteLine("Capacity: {0} ", al.Capacity)
        Console.WriteLine("Count: {0}", al.Count)
        Console.Write("Content: ")

        For Each i In al
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()

    End Sub
    Sub addinlist()
        Console.WriteLine("Enter some number to be entered in list : ")
        While (True)
            num = Console.ReadLine()
            If (num = "") Then
                Exit While
            Else
                al.Add(num)
            End If
        End While
        displaylist()
        Console.WriteLine("Done")

    End Sub
    Sub Sortlist()
        al.Sort()
        Console.Write("Sorted Content: ")
        displaylist()
        Console.WriteLine("Done")

    End Sub
    Sub insertintolist()
        Dim loc As Integer
        Dim data As String
        Console.WriteLine("Enter the Location (From 0)")
        loc = Console.ReadLine
        Console.WriteLine("Enter the Data to be added : ")
        data = Console.ReadLine
        al.Insert(loc, data)
        displaylist()
        Console.WriteLine("Done")

    End Sub
    Sub searchinarray()
        Dim find As String
        Console.WriteLine("Enter the Item :")
        find = Console.ReadLine
        Console.WriteLine(al.Contains(find))
        Console.WriteLine("Done")

    End Sub
End Module
