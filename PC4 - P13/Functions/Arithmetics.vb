Namespace UIP
    Module Arithmetics
        Public Function GetAddition(a As Integer, b As Integer) As Integer
            Return a + b
        End Function

        Public Function GetSubtraction(a As Integer, b As Integer) As Integer
            Return a - b
        End Function

        Public Function GetMultiplication(a As Integer, b As Integer) As Integer
            Return a * b
        End Function

        Public Function GetDivision(a As Integer, b As Integer) As Single
            Return a / b
        End Function

        Public Function GetModulus(a As Integer, b As Integer) As Integer
            Dim result As Integer = 0

            Try
                result = a Mod b
            Catch ex As DivideByZeroException
                result = a Mod 1
            End Try

            Return result
        End Function
    End Module
End Namespace
