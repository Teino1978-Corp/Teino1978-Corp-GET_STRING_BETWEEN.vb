  Function GET_STRING_BETWEEN(ByVal start As String, ByVal parent As String, ByVal [end] As String)
        Dim output As String
        output = parent.Substring(parent.IndexOf(start) _
                                                , (parent.IndexOf([end]) _
                                                   - parent.IndexOf(start)) _
                                                   ).Replace(start, "").Replace([end], "")
        output = start & output & [end]
        Return output
    End Function