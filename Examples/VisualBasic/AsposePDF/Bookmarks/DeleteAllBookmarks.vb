'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf

Namespace VisualBasic.AsposePdf.Bookmarks
    Public Class DeleteAllBookmarks
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            'open document
            Dim pdfDocument As New Document(dataDir & "DeleteAllBookmarks.pdf")

            'delete all bookmarks
            pdfDocument.Outlines.Delete()

            'save updated file
            pdfDocument.Save(dataDir & "DeleteAllBookmarks_out.pdf")

        End Sub
    End Class
End Namespace