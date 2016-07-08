Imports System.IO
Imports System.Media
Imports System.Text.RegularExpressions
Module MapSettingsCustomizer
    Sub Main(ByVal args As String())
        Console.Title = "osu! Map Settings Customizer 2.0"
        If (args.Length > 0) Then
            Dim mode As String = ""
            Dim name As String = ""
            Dim path As String = ""

            Dim fromHP As Double = 0
            Dim toHP As Double = 0

            Dim fromCS As Double = 0
            Dim toCS As Double = 0

            Dim fromAR As Double = 0
            Dim toAR As Double = 0

            Dim fromOD As Double = 0
            Dim toOD As Double = 0

            Dim newHP As Double = 0
            Dim newCS As Double = 0
            Dim newAR As Double = 0
            Dim newOD As Double = 0

            Dim relHP As Boolean = False
            Dim relCS As Boolean = False
            Dim relAR As Boolean = False
            Dim relOD As Boolean = False

            Dim oldMaps As Boolean = False
            Dim nextArg As String = ""
            For Each arg As String In args
                If (nextArg = "-create") Then
                    mode = "create"
                End If
                If (nextArg = "-update") Then
                    mode = "update"
                End If
                If (nextArg = "-delete") Then
                    mode = "delete"
                End If
                If (nextArg = "-name") Then
                    name = arg
                End If
                If (nextArg = "-path") Then
                    path = arg
                End If
                If (nextArg = "-fromHP") Then
                    fromHP = Convert.ToDouble(arg)
                End If
                If (nextArg = "-toHP") Then
                    toHP = Convert.ToDouble(arg)
                End If
                If (nextArg = "-fromCS") Then
                    fromCS = Convert.ToDouble(arg)
                End If
                If (nextArg = "-toCS") Then
                    toCS = Convert.ToDouble(arg)
                End If
                If (nextArg = "-fromAR") Then
                    fromAR = Convert.ToDouble(arg)
                End If
                If (nextArg = "-toAR") Then
                    toAR = Convert.ToDouble(arg)
                End If
                If (nextArg = "-fromOD") Then
                    fromOD = Convert.ToDouble(arg)
                End If
                If (nextArg = "-toOD") Then
                    toOD = Convert.ToDouble(arg)
                End If
                If (nextArg = "-newHP") Then
                    newHP = Convert.ToDouble(arg)
                End If
                If (nextArg = "-newCS") Then
                    newCS = Convert.ToDouble(arg)
                End If
                If (nextArg = "-newAR") Then
                    newAR = Convert.ToDouble(arg)
                End If
                If (nextArg = "-newOD") Then
                    newOD = Convert.ToDouble(arg)
                End If
                If (nextArg = "-relHP") Then
                    relHP = Convert.ToBoolean(arg)
                End If
                If (nextArg = "-relCS") Then
                    relCS = Convert.ToBoolean(arg)
                End If
                If (nextArg = "-relAR") Then
                    relAR = Convert.ToBoolean(arg)
                End If
                If (nextArg = "-relOD") Then
                    relOD = Convert.ToBoolean(arg)
                End If
                If (nextArg = "-oldMaps") Then
                    oldMaps = Convert.ToBoolean(arg)
                End If
                nextArg = arg
            Next
            Dim totalFiles As Integer = 0
            Dim completedFiles As Integer = 0
            Dim createdFiles As Integer = 0
            Dim deletedFiles As Integer = 0
            Dim failedFiles As Integer = 0
            Dim filesPercent As Double = 0
            Dim songFolders As String() = Directory.GetDirectories(path)
            For Each currentFolder As String In songFolders
                For Each currentFile As String In Directory.GetFiles(currentFolder)
                    If (currentFile.EndsWith(".osu")) And Not currentFile.EndsWith("__].osu") Then
                        If Not (File.Exists(currentFile.Replace("].osu", "__" & name & "__].osu"))) Then
                            totalFiles = totalFiles + 1
                            Console.Write("{0}Counting beatmaps: {1}", vbCr, totalFiles)
                            Application.DoEvents()
                        End If
                    End If
                Next
            Next
            Console.Clear()
            Select Case mode
                Case "create"
                    For Each currentFolder As String In songFolders
                        For Each currentFile As String In Directory.GetFiles(currentFolder)
                            If (currentFile.EndsWith(".osu")) And Not currentFile.EndsWith("__].osu") Then
                                If Not (File.Exists(currentFile.Replace("].osu", "__" & name & "__].osu"))) Then
                                    filesPercent = Math.Round((completedFiles / totalFiles * 100.0), 2)
                                    Console.Title = "Creating new beatmaps - " & completedFiles & "/" & totalFiles & " - " & filesPercent & "% complete."
                                    Application.DoEvents()
                                    Dim beatmapContents As String = File.ReadAllText(currentFile)
                                    Dim mapVersion As Integer = 0
                                    Dim oldHP As Double = 0
                                    Dim oldCS As Double = 0
                                    Dim oldAR As Double = 0
                                    Dim oldOD As Double = 0
                                    Dim customMap As Boolean = False
                                    Try
                                        mapVersion = Convert.ToInt32(Convert.ToString(Regex.Match(beatmapContents, "(?<=osu file format v)(\d+)")))
                                    Catch
                                    End Try
                                    Try
                                        oldHP = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldHP:)([ \d.]+)")))
                                        customMap = True
                                    Catch
                                        oldHP = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=HPDrainRate:)([ \d.]+)")))
                                    End Try
                                    Try
                                        oldCS = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldCS:)([ \d.]+)")))
                                        customMap = True
                                    Catch
                                        oldCS = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=CircleSize:)([ \d.]+)")))
                                    End Try
                                    Try
                                        oldAR = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldAR:)([ \d.]+)")))
                                        customMap = True
                                    Catch
                                        oldAR = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=ApproachRate:)([ \d.]+)")))
                                    End Try
                                    Try
                                        oldOD = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldOD:)([ \d.]+)")))
                                        customMap = True
                                    Catch
                                        oldOD = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=OverallDifficulty:)([ \d.]+)")))
                                    End Try
                                    If (fromHP <= oldHP And oldHP <= toHP) Then
                                        If (fromCS <= oldCS And oldCS <= toCS) Then
                                            If (mapVersion >= 8) Then
                                                If (fromAR <= oldAR And oldAR <= toAR) Then
                                                    If (fromOD <= oldOD And oldOD <= toOD) Then
                                                        If relHP = True Then
                                                            If newHP <> 0 Then
                                                                Dim tempHP As Double = newHP + oldHP
                                                                If tempHP > 10 Then
                                                                    tempHP = 10
                                                                End If
                                                                If tempHP < 0 Then
                                                                    tempHP = 0
                                                                End If
                                                                beatmapContents = beatmapContents.Replace("HPDrainRate:", "HPDrainRate:" & Convert.ToString(tempHP) & Environment.NewLine & "//OldHP:")
                                                            End If
                                                        Else
                                                            beatmapContents = beatmapContents.Replace("HPDrainRate:", "HPDrainRate:" & Convert.ToString(newHP) & Environment.NewLine & "//OldHP:")
                                                        End If

                                                        If relCS = True Then
                                                            If newCS <> 0 Then
                                                                Dim tempCS As Double = newCS + oldCS
                                                                If tempCS > 10 Then
                                                                    tempCS = 10
                                                                End If
                                                                If tempCS < 0 Then
                                                                    tempCS = 0
                                                                End If
                                                                beatmapContents = beatmapContents.Replace("CircleSize:", "CircleSize:" & Convert.ToString(tempCS) & Environment.NewLine & "//OldCS:")
                                                            End If
                                                        Else
                                                            beatmapContents = beatmapContents.Replace("CircleSize:", "CircleSize:" & Convert.ToString(newCS) & Environment.NewLine & "//OldCS:")
                                                        End If
                                                    End If
                                                    If relAR = True Then
                                                        If newAR <> 0 Then
                                                            Dim tempAR As Double = newAR + oldAR
                                                            If tempAR > 10 Then
                                                                tempAR = 10
                                                            End If
                                                            If tempAR < 0 Then
                                                                tempAR = 0
                                                            End If
                                                            beatmapContents = beatmapContents.Replace("ApproachRate:", "ApproachRate:" & Convert.ToString(tempAR) & Environment.NewLine & "//OldAR:")
                                                        End If
                                                    Else
                                                        beatmapContents = beatmapContents.Replace("ApproachRate:", "ApproachRate:" & Convert.ToString(newAR) & Environment.NewLine & "//OldAR:")
                                                    End If

                                                    If relOD = True Then
                                                        If newOD <> 0 Then
                                                            Dim tempOD As Double = newOD + oldOD
                                                            If tempOD > 10 Then
                                                                tempOD = 10
                                                            End If
                                                            If tempOD < 0 Then
                                                                tempOD = 0
                                                            End If
                                                            beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" & Convert.ToString(tempOD) & Environment.NewLine & "//OldOD:")
                                                        End If
                                                    Else
                                                        beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" & Convert.ToString(newOD) & Environment.NewLine & "//OldOD:")
                                                    End If
                                                End If
                                            Else
                                                If oldMaps = True Then
                                                    If (fromAR < oldOD And oldOD < toAR) Then           'treat OD as AR
                                                        If relAR = True Then                            'make relative adjustments based on AR
                                                            If newAR <> 0 Then
                                                                Dim tempOD As Double = newAR + oldOD
                                                                If tempOD > 10 Then
                                                                    tempOD = 10
                                                                End If
                                                                If tempOD < 0 Then
                                                                    tempOD = 0
                                                                End If
                                                                beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" & Convert.ToString(tempOD) & Environment.NewLine & "//OldOD:")
                                                            End If
                                                        Else
                                                            beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" & Convert.ToString(newAR) & Environment.NewLine & "//OldOD:") 'use AR value as new OD
                                                        End If
                                                    End If
                                                End If
                                            End If
                                            beatmapContents = beatmapContents.Replace("osu file format ", "osu file format v14" & Environment.NewLine & "//Old:")
                                            beatmapContents = beatmapContents.Replace("Version:", "Version:[" & name & "] ")
                                            beatmapContents = beatmapContents.Replace("BeatmapID:", "BeatmapID:-")
                                            Dim newFileName As String = currentFile.Replace("].osu", "__" & name & "__].osu")
                                            Try
                                                File.WriteAllText(newFileName, beatmapContents)
                                                Console.WriteLine(newFileName)
                                                createdFiles += 1
                                            Catch
                                                MessageBox.Show("This map's file path is too long. Move or rename it and try again." & Environment.NewLine & newFileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                Console.WriteLine("This map's file path is too long. Move or rename it and try again." & Environment.NewLine)
                                                Console.WriteLine(newFileName & Environment.NewLine)
                                                failedFiles += 1
                                            End Try
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    Next
                    Console.WriteLine("Done! " & createdFiles & " " & name & " copies were created. " & failedFiles & " failed.")
                    SystemSounds.Asterisk.Play()
                    MessageBox.Show("Done! " & createdFiles & " " & name & " copies were created. " & failedFiles & " failed.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Console.Title = "osu! Map Settings Customizer 2.0"
                Case "update"
                    For Each currentFolder As String In songFolders
                        For Each currentFile As String In Directory.GetFiles(currentFolder)
                            If (currentFile.EndsWith(".osu")) And Not currentFile.EndsWith("__].osu") Then
                                If Not (File.Exists(currentFile.Replace("].osu", "__" & name & "__].osu"))) Then
                                    filesPercent = Math.Round((completedFiles / totalFiles * 100), 2)
                                    Console.Title = "Creating new beatmaps - " & completedFiles & "/" & totalFiles & " - " & filesPercent & "% complete."
                                    Application.DoEvents()
                                    Dim beatmapContents As String = File.ReadAllText(currentFile)
                                    Dim mapVersion As Integer = 0
                                    Dim oldHP As Double = 0
                                    Dim oldCS As Double = 0
                                    Dim oldAR As Double = 0
                                    Dim oldOD As Double = 0
                                    Dim customMap As Boolean = False
                                    Try
                                        mapVersion = Convert.ToInt32(Convert.ToString(Regex.Match(beatmapContents, "(?<=osu file format v)(\d+)")))
                                    Catch
                                    End Try
                                    Try
                                        oldHP = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldHP:)([ \d.]+)")))
                                        customMap = True
                                    Catch
                                        oldHP = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=HPDrainRate:)([ \d.]+)")))
                                    End Try
                                    Try
                                        oldCS = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldCS:)([ \d.]+)")))
                                        customMap = True
                                    Catch
                                        oldCS = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=CircleSize:)([ \d.]+)")))
                                    End Try
                                    Try
                                        oldAR = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldAR:)([ \d.]+)")))
                                        customMap = True
                                    Catch
                                        oldAR = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=ApproachRate:)([ \d.]+)")))
                                    End Try
                                    Try
                                        oldOD = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldOD:)([ \d.]+)")))
                                        customMap = True
                                    Catch
                                        oldOD = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=OverallDifficulty:)([ \d.]+)")))
                                    End Try
                                    If (fromHP <= oldHP And oldHP <= toHP) Then
                                        If (fromCS <= oldCS And oldCS <= toCS) Then
                                            If (mapVersion >= 8) Then
                                                If (fromAR <= oldAR And oldAR <= toAR) Then
                                                    If (fromOD <= oldOD And oldOD <= toOD) Then
                                                        If relHP = True Then
                                                            If newHP <> 0 Then
                                                                Dim tempHP As Double = newHP + oldHP
                                                                If tempHP > 10 Then
                                                                    tempHP = 10
                                                                End If
                                                                If tempHP < 0 Then
                                                                    tempHP = 0
                                                                End If
                                                                beatmapContents = beatmapContents.Replace("HPDrainRate:", "HPDrainRate:" & Convert.ToString(tempHP) & Environment.NewLine & "//OldHP:")
                                                            End If
                                                        Else
                                                            beatmapContents = beatmapContents.Replace("HPDrainRate:", "HPDrainRate:" & Convert.ToString(newHP) & Environment.NewLine & "//OldHP:")
                                                        End If

                                                        If relCS = True Then
                                                            If newCS <> 0 Then
                                                                Dim tempCS As Double = newCS + oldCS
                                                                If tempCS > 10 Then
                                                                    tempCS = 10
                                                                End If
                                                                If tempCS < 0 Then
                                                                    tempCS = 0
                                                                End If
                                                                beatmapContents = beatmapContents.Replace("CircleSize:", "CircleSize:" & Convert.ToString(tempCS) & Environment.NewLine & "//OldCS:")
                                                            End If
                                                        Else
                                                            beatmapContents = beatmapContents.Replace("CircleSize:", "CircleSize:" & Convert.ToString(newCS) & Environment.NewLine & "//OldCS:")
                                                        End If
                                                    End If
                                                    If relAR = True Then
                                                        If newAR <> 0 Then
                                                            Dim tempAR As Double = newAR + oldAR
                                                            If tempAR > 10 Then
                                                                tempAR = 10
                                                            End If
                                                            If tempAR < 0 Then
                                                                tempAR = 0
                                                            End If
                                                            beatmapContents = beatmapContents.Replace("ApproachRate:", "ApproachRate:" & Convert.ToString(tempAR) & Environment.NewLine & "//OldAR:")
                                                        End If
                                                    Else
                                                        beatmapContents = beatmapContents.Replace("ApproachRate:", "ApproachRate:" & Convert.ToString(newAR) & Environment.NewLine & "//OldAR:")
                                                    End If

                                                    If relOD = True Then
                                                        If newOD <> 0 Then
                                                            Dim tempOD As Double = newOD + oldOD
                                                            If tempOD > 10 Then
                                                                tempOD = 10
                                                            End If
                                                            If tempOD < 0 Then
                                                                tempOD = 0
                                                            End If
                                                            beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" & Convert.ToString(tempOD) & Environment.NewLine & "//OldOD:")
                                                        End If
                                                    Else
                                                        beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" & Convert.ToString(newOD) & Environment.NewLine & "//OldOD:")
                                                    End If
                                                End If
                                            Else
                                                If oldMaps = True Then
                                                    If (fromAR < oldOD And oldOD < toAR) Then           'treat OD as AR
                                                        If relAR = True Then                            'make relative adjustments based on AR
                                                            If newAR <> 0 Then
                                                                Dim tempOD As Double = newAR + oldOD
                                                                If tempOD > 10 Then
                                                                    tempOD = 10
                                                                End If
                                                                If tempOD < 0 Then
                                                                    tempOD = 0
                                                                End If
                                                                beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" & Convert.ToString(tempOD) & Environment.NewLine & "//OldOD:")
                                                            End If
                                                        Else
                                                            beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" & Convert.ToString(newAR) & Environment.NewLine & "//OldOD:") 'use AR value as new OD
                                                        End If
                                                    End If
                                                End If
                                            End If
                                            beatmapContents = beatmapContents.Replace("osu file format ", "osu file format v14" & Environment.NewLine & "//Old:")
                                            beatmapContents = beatmapContents.Replace("Version:", "Version:[" & name & "] ")
                                            beatmapContents = beatmapContents.Replace("BeatmapID:", "BeatmapID:-")
                                            Dim newFileName As String = currentFile.Replace("].osu", "__" & name & "__].osu")
                                            Try
                                                File.WriteAllText(newFileName, beatmapContents)
                                                Console.WriteLine(newFileName)
                                                createdFiles += 1
                                            Catch
                                                MessageBox.Show("This map's file path is too long. Move or rename it and try again." & Environment.NewLine & newFileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                Console.WriteLine("This map's file path is too long. Move or rename it and try again." & Environment.NewLine)
                                                Console.WriteLine(newFileName & Environment.NewLine)
                                                failedFiles += 1
                                            End Try
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    Next
                    Console.WriteLine("Done! " & createdFiles & " " & name & " copies were created. " & failedFiles & " failed.")
                    SystemSounds.Asterisk.Play()
                    MessageBox.Show("Done! " & createdFiles & " " & name & " copies were created. " & failedFiles & " failed.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Console.Title = "osu! Map Settings Customizer 2.0"
                Case "delete"
                    For Each currentFolder As String In songFolders
                        For Each currentFile As String In Directory.GetFiles(currentFolder)
                            If (currentFile.EndsWith("__" & name & "__].osu")) Then
                                filesPercent = Math.Round((completedFiles / totalFiles * 100.0), 2)
                                Console.Title = "Deleting beatmaps - " & completedFiles & "/" & totalFiles & " - " & filesPercent & "% complete."
                                Application.DoEvents()
                                Try
                                    File.Delete(currentFile)
                                    Console.WriteLine(currentFile)
                                    completedFiles += 1
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Console.WriteLine(ex.Message)
                                    failedFiles += 1
                                End Try
                            End If
                        Next
                    Next
                    Console.WriteLine("Done! " & completedFiles & " " & name & " copies were deleted. " & failedFiles & " failed.")
                    SystemSounds.Asterisk.Play()
                    MessageBox.Show("Done! " & completedFiles & " " & name & " copies were deleted.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Console.Title = "osu! Map Settings Customizer 2.0"
            End Select
        Else
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MapSettingsCustomizerForm())
        End If
    End Sub
End Module