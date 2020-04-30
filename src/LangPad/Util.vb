﻿''' <summary>
''' Module containing various utility methods.
''' </summary>
Module Util
    ''' <summary>
    ''' Move an item of type T in a list from and old index to a new index.
    ''' </summary>
    ''' 
    ''' <typeparam name="T">The type of item in the list.</typeparam>
    ''' 
    ''' <param name="List">The list to modify.</param>
    ''' <param name="OldIndex">The old index.</param>
    ''' <param name="NewIndex">The new index.</param>
    Public Sub MoveItem(Of T)(List As IList, OldIndex As Integer, NewIndex As Integer)
        Dim Item As T = List(OldIndex)
        List.RemoveAt(OldIndex)
        List.Insert(NewIndex, Item)
    End Sub

    ''' <summary>
    ''' Get the number of words in a text.
    ''' </summary>
    ''' 
    ''' <param name="Text">The text to look through.</param>
    ''' 
    ''' <returns>The number of words.</returns>
    Public Function WordCount(Text As String) As Integer
        Return Text.Trim().Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries).Length
    End Function
End Module