using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace MapSettingsCustomizer
{
    static class MapSettingsCustomizer
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Title = "osu! Map Settings Customizer 2.0";
            Console.Clear();
            if (args.Length > 0)
            {
                string mode = "";
                string name = "";
                string path = "";

                double fromHP = 0;
                double toHP = 10;

                double fromCS = 0;
                double toCS = 10;

                double fromOD = 0;
                double toOD = 10;

                double fromAR = 0;
                double toAR = 10;

                double oldHP = 0;
                double oldCS = 0;
                double oldOD = 0;
                double oldAR = 0;

                double newHP = 0;
                double newCS = 0;
                double newOD = 0;
                double newAR = 0;

                bool relHP = false;
                bool relCS = false;
                bool relOD = false;
                bool relAR = false;

                int mapVersion = 0;

                string prevArg = "";

                //split arg array into "-switch arg"
                foreach (string arg in args)
                {
                    switch (prevArg)
                    {
                        case "-create":
                            mode = "create";
                            break;
                        case "-update":
                            mode = "update";
                            break;
                        case "-delete":
                            mode = "delete";
                            break;
                        case "-name":
                            name = arg;
                            break;
                        case "-path":
                            path = arg;
                            break;
                        case "-fromHP":
                            fromHP = Convert.ToDouble(arg);
                            break;
                        case "-toHP":
                            toHP = Convert.ToDouble(arg);
                            break;
                        case "-fromCS":
                            fromCS = Convert.ToDouble(arg);
                            break;
                        case "-toCS":
                            toCS = Convert.ToDouble(arg);
                            break;
                        case "-fromOD":
                            fromOD = Convert.ToDouble(arg);
                            break;
                        case "-toOD":
                            toOD = Convert.ToDouble(arg);
                            break;
                        case "-fromAR":
                            fromAR = Convert.ToDouble(arg);
                            break;
                        case "-toAR":
                            toAR = Convert.ToDouble(arg);
                            break;
                        case "-newHP":
                            newHP = Convert.ToDouble(arg);
                            break;
                        case "-newCS":
                            newCS = Convert.ToDouble(arg);
                            break;
                        case "-newOD":
                            newOD = Convert.ToDouble(arg);
                            break;
                        case "-newAR":
                            newAR = Convert.ToDouble(arg);
                            break;
                        case "-relHP":
                            relHP = Convert.ToBoolean(arg);
                            break;
                        case "-relCS":
                            relCS = Convert.ToBoolean(arg);
                            break;
                        case "-relOD":
                            relOD = Convert.ToBoolean(arg);
                            break;
                        case "-relAR":
                            relAR = Convert.ToBoolean(arg);
                            break;
                        default:
                            break;
                    }
                    prevArg = arg;
                }
                List<string> originalBeatmaps = new List<string>();
                List<string> missingBeatmaps = new List<string>();
                List<string> matchingBeatmaps = new List<string>();
                List<string> nonMatchingBeatmaps = new List<string>();
                double originalFiles = 0;
                double missingFiles = 0;
                double matchingFiles = 0;
                double nonMatchingFiles = 0;
                double completedFiles = 0;
                double createdFiles = 0;
                double deletedFiles = 0;
                double failedFiles = 0;
                double filesPercent = 0;
                //Stopwatch timer = new Stopwatch();
                //timer.Start();
                Console.Title = "Counting Beatmaps";
                foreach (string currentFolder in Directory.GetDirectories(path))
                {
                    foreach (string currentFile in Directory.GetFiles(currentFolder))
                    {
                        if (currentFile.EndsWith(".osu"))
                        {
                            if (currentFile.EndsWith("__].osu"))
                            {
                                if (currentFile.EndsWith(name + "__].osu"))
                                {
                                    matchingBeatmaps.Add(currentFile);
                                    matchingFiles += 1;
                                }
                                else
                                {
                                    nonMatchingBeatmaps.Add(currentFile);
                                    nonMatchingFiles += 1;
                                }
                            }
                            else
                            {
                                originalBeatmaps.Add(currentFile);
                                originalFiles += 1;
                                if (!File.Exists(currentFile.Replace("].osu", "__" + name + "__].osu")))
                                {
                                    missingBeatmaps.Add(currentFile);
                                    missingFiles += 1;
                                }
                            }
                        }
                        Application.DoEvents();
                    }
                    Console.SetCursorPosition(0, 0);
                    Console.Write("Original beatmaps: {0}\r\nExisting [{1}] beatmaps: {2}\r\nMissing [{1}] beatmaps: {3}\r\nOther [custom] beatmaps: {4}", originalFiles, name, matchingFiles, missingFiles, nonMatchingFiles);
                }
                //timer.Stop();
                //Console.WriteLine("\r\nTime elapsed: {0}\r\n", timer.Elapsed);
                //timer.Reset();
                //timer.Start();
                switch (mode)
                {
                    case "create":
                        #region
                        Console.Title = "Creating beatmaps";
                        foreach (string currentBeatmap in missingBeatmaps)
                        {
                            string beatmapContents = File.ReadAllText(currentBeatmap);
                            try
                            {
                                mapVersion = Convert.ToInt32(Convert.ToString(Regex.Match(beatmapContents, "(?<=osu file format v)(\\d+)")));
                            }
                            catch
                            {
                                MessageBox.Show("This map's version header is missing:\r\n" + currentBeatmap, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //Console.WriteLine("This map's version header is missing:\r\n{0}", currentBeatmap);
                                failedFiles += 1;
                                continue;
                            }
                            //Leave this in case I decide to merge create and update.
                            //try
                            //{
                            //    oldHP = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldHP:)([ \\d.]+)")));
                            //    oldCS = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldCS:)([ \\d.]+)")));
                            //    oldOD = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldOD:)([ \\d.]+)")));
                            //    oldAR = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldAR:)([ \\d.]+)")));
                            //}
                            //catch { }
                            try
                            {
                                oldHP = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=HPDrainRate:)([ \\d.]+)")));
                                oldCS = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=CircleSize:)([ \\d.]+)")));
                                oldOD = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=OverallDifficulty:)([ \\d.]+)")));
                                if (mapVersion > 7)
                                {
                                    oldAR = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=ApproachRate:)([ \\d.]+)")));
                                }
                                else oldAR = oldOD; //The OD variable controls both OD and AR in old maps. We'll have to create a separate AR.
                            }
                            catch
                            {
                                MessageBox.Show("This map's difficulty header(s) are missing:\r\n" + currentBeatmap, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //Console.WriteLine("This map's difficulty header(s) are missing:\r\n{0}", currentBeatmap);
                                failedFiles += 1;
                                continue;
                            }
                            if (fromHP <= oldHP && oldHP <= toHP &
                                fromCS <= oldCS && oldCS <= toCS &
                                fromOD <= oldOD && oldOD <= toOD &
                                fromAR <= oldAR && oldAR <= toAR)
                            {
                                double tempHP = newHP;
                                double tempCS = newCS;
                                double tempOD = newOD;
                                double tempAR = newAR;
                                if (relHP == true)
                                {
                                    tempHP = newHP + oldHP; //Make relative changes
                                    if (tempHP > 10) { tempHP = 10; } //Clamp to 0-10
                                    if (tempHP < 0) { tempHP = 0; }
                                }
                                if (relCS == true)
                                {
                                    tempCS = newCS + oldCS;
                                    if (tempCS > 10) { tempCS = 10; } //You can still crank CS up to 10 if you want, but peppy hates you and you're probably a masochist.
                                    if (tempCS < 0) { tempCS = 0; }
                                }
                                if (relOD == true)
                                {
                                    tempOD = newOD + oldOD;
                                    if (tempOD > 10) { tempOD = 10; }
                                    if (tempOD < 0) { tempOD = 0; }
                                }
                                if (relAR == true)
                                {
                                    tempAR = newAR + oldAR;
                                    if (tempAR > 10) { tempAR = 10; }
                                    if (tempAR < 0) { tempAR = 0; }
                                }

                                if (tempHP != oldHP) { beatmapContents = beatmapContents.Replace("HPDrainRate:", "HPDrainRate:" + Convert.ToString(tempHP) + "\r\n//OldHP:"); }
                                if (tempCS != oldCS) { beatmapContents = beatmapContents.Replace("CircleSize:", "CircleSize:" + Convert.ToString(tempCS) + "\r\n//OldCS:"); }
                                if (tempOD != oldOD) { beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" + Convert.ToString(tempOD) + "\r\n//OldOD:"); }
                                if (tempAR != oldAR)
                                {
                                    if (mapVersion > 7) { beatmapContents = beatmapContents.Replace("ApproachRate:", "ApproachRate:" + Convert.ToString(tempAR) + "\r\n//OldAR:"); }
                                    else //Add a separate approach rate based on the previous OD
                                    { beatmapContents = beatmapContents.Replace("SliderMultiplier:", "ApproachRate:" + Convert.ToString(tempAR) + "\r\n//OldAR:" + oldAR + "\r\nSliderMultiplier:"); }
                                }

                                //Might need this later if something is horribly broken
                                //beatmapContents = beatmapContents.Replace("osu file format ", "osu file format v14" + "\r\n//OldFormat:");
                                beatmapContents = beatmapContents.Replace("Version:", "Version:[" + name + "] ");
                                beatmapContents = beatmapContents.Replace("BeatmapID:", "BeatmapID:-");
                                string newFileName = currentBeatmap.Replace("].osu", "__" + name + "__].osu");
                                try
                                {
                                    File.WriteAllText(newFileName, beatmapContents);
                                    //Console.WriteLine(newFileName);
                                    createdFiles += 1;
                                }
                                catch
                                {
                                    MessageBox.Show("This map's file path is too long. Move or rename it and try again.\r\n" + newFileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    //Console.WriteLine("This map's file path is too long:\r\n{0}\r\nMove or rename it and try again.", newFileName);
                                    failedFiles += 1;
                                }
                            }
                            completedFiles += 1;
                            filesPercent = completedFiles / missingFiles * 100.00;
                            Console.SetCursorPosition(0, 5);
                            Console.WriteLine("Creating new beatmaps - {0}/{1} - {2:00.00}% complete.", completedFiles, missingFiles, filesPercent);
                            Application.DoEvents();
                        }
                        Console.SetCursorPosition(0, 5);
                        Console.WriteLine("Creating new beatmaps - {0}/{1} - {2}% complete.           ", completedFiles, missingFiles, filesPercent);
                        Console.WriteLine("\r\nDone! {0} [{1}] copies were created. {2} failed.\r\n\r\nPress any key to continue...", createdFiles, name, failedFiles);
                        SystemSounds.Asterisk.Play();
                        //MessageBox.Show("Done! " + createdFiles + " " + name + " copies were created. " + failedFiles + " failed.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Console.Title = "osu! Map Settings Customizer 2.0";
                        Console.ReadKey();
                        #endregion
                        break;
                    case "update":
                        try
                        {
                            Console.WriteLine(Convert.ToDateTime("9001/0"));
                        }
                        catch
                        {
                            MessageBox.Show("I bet you thought you were clever running -update from the command line", "This feature is not yet implemented", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "delete":
                        #region
                        Console.Title = "Deleting beatmaps";
                        foreach (string currentBeatmap in matchingBeatmaps)
                        {
                            try
                            {
                                File.Delete(currentBeatmap);
                                //Console.WriteLine(currentBeatmap);
                                deletedFiles += 1;
                            }
                            catch
                            {
                                MessageBox.Show("This map could not be deleted.\r\n" + currentBeatmap, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //Console.WriteLine("This map could not be deleted:\r\n{0}", currentBeatmap);
                                failedFiles += 1;
                            }
                            completedFiles += 1;
                            filesPercent = completedFiles / matchingFiles * 100.00;
                            Console.SetCursorPosition(0, 5);
                            Console.WriteLine("Deleting beatmaps - {0}/{1} - {2:00.00}% complete.", completedFiles, matchingFiles, filesPercent);
                            Application.DoEvents();
                        }
                        Console.SetCursorPosition(0, 5);
                        Console.WriteLine("Deleting beatmaps - {0}/{1} - {2}% complete.           ", completedFiles, matchingFiles, filesPercent);
                        Console.WriteLine("\r\nDone! {0} [{1}] copies were deleted. {2} failed.\r\n\r\nPress any key to continue...", deletedFiles, name, failedFiles);
                        SystemSounds.Asterisk.Play();
                        //MessageBox.Show("Done! " + deletedFiles + " " + name + " copies were deleted. " + failedFiles + " failed.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Console.Title = "osu! Map Settings Customizer 2.0";
                        Console.ReadKey();
                        #endregion
                        break;
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MapSettingsCustomizerForm());
            }
        }
    }
}