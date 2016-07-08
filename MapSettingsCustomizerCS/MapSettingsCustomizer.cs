using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            Console.Title = "osu! Map Settings Customizer 2.0";
            if (args.Length > 0)
            {
                string mode = "";
                string name = "";
                string path = "";

                double fromHP = 0;
                double toHP = 0;

                double fromCS = 0;
                double toCS = 0;

                double fromAR = 0;
                double toAR = 0;

                double fromOD = 0;
                double toOD = 0;

                double newHP = 0;
                double newCS = 0;
                double newAR = 0;
                double newOD = 0;

                bool relHP = false;
                bool relCS = false;
                bool relAR = false;
                bool relOD = false;

                bool oldMaps = false;
                string nextArg = "";
                foreach (string arg in args)
                {
                    if (nextArg == "-create")
                    {
                        mode = "create";
                    }
                    if (nextArg == "-update")
                    {
                        mode = "update";
                    }
                    if (nextArg == "-delete")
                    {
                        mode = "delete";
                    }
                    if (nextArg == "-name")
                    {
                        name = arg;
                    }
                    if (nextArg == "-path")
                    {
                        path = arg;
                    }
                    if (nextArg == "-fromHP")
                    {
                        fromHP = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-toHP")
                    {
                        toHP = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-fromCS")
                    {
                        fromCS = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-toCS")
                    {
                        toCS = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-fromAR")
                    {
                        fromAR = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-toAR")
                    {
                        toAR = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-fromOD")
                    {
                        fromOD = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-toOD")
                    {
                        toOD = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-newHP")
                    {
                        newHP = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-newCS")
                    {
                        newCS = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-newAR")
                    {
                        newAR = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-newOD")
                    {
                        newOD = Convert.ToDouble(arg);
                    }
                    if (nextArg == "-relHP")
                    {
                        relHP = Convert.ToBoolean(arg);
                    }
                    if (nextArg == "-relCS")
                    {
                        relCS = Convert.ToBoolean(arg);
                    }
                    if (nextArg == "-relAR")
                    {
                        relAR = Convert.ToBoolean(arg);
                    }
                    if (nextArg == "-relOD")
                    {
                        relOD = Convert.ToBoolean(arg);
                    }
                    if (nextArg == "-oldMaps")
                    {
                        oldMaps = Convert.ToBoolean(arg);
                    }
                    nextArg = arg;
                }
                int totalFiles = 0;
                int completedFiles = 0;
                int createdFiles = 0;
                int deletedFiles = 0;
                int failedFiles = 0;
                double filesPercent = 0;
                string[] songFolders = Directory.GetDirectories(path);
                foreach (string currentFolder in songFolders)
                {
                    foreach (string currentFile in Directory.GetFiles(currentFolder))
                    {
                        if (currentFile.EndsWith(".osu") & !currentFile.EndsWith("__].osu"))
                        {
                            if (!File.Exists(currentFile.Replace("].osu", "__" + name + "__].osu")))
                            {
                                totalFiles = totalFiles + 1;
                                Console.Write("{0}Counting beatmaps: \r", totalFiles);
                                Application.DoEvents();
                            }
                        }
                    }
                }
                Console.Clear();
                switch (mode)
                {
                    case "create":
                        #region
                        foreach (string currentFolder in songFolders)
                        {
                            foreach (string currentFile in Directory.GetFiles(currentFolder))
                            {
                                if (currentFile.EndsWith(".osu") & !currentFile.EndsWith("__].osu"))
                                {
                                    if (!File.Exists(currentFile.Replace("].osu", "__" + name + "__].osu")))
                                    {
                                        filesPercent = Math.Round((completedFiles / totalFiles * 100.0), 2);
                                        Console.Title = "Creating new beatmaps - " + completedFiles + "/" + totalFiles + " - " + filesPercent + "% complete.";
                                        Application.DoEvents();
                                        string beatmapContents = File.ReadAllText(currentFile);
                                        int mapVersion = 0;
                                        double oldHP = 0;
                                        double oldCS = 0;
                                        double oldAR = 0;
                                        double oldOD = 0;
                                        bool customMap = false;
                                        try
                                        {
                                            mapVersion = Convert.ToInt32(Convert.ToString(Regex.Match(beatmapContents, "(?<=osu file format v)(\\d+)")));
                                        }
                                        catch
                                        {
                                        }
                                        try
                                        {
                                            oldHP = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldHP:)([ \\d.]+)")));
                                            customMap = true;
                                        }
                                        catch
                                        {
                                            oldHP = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=HPDrainRate:)([ \\d.]+)")));
                                        }
                                        try
                                        {
                                            oldCS = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldCS:)([ \\d.]+)")));
                                            customMap = true;
                                        }
                                        catch
                                        {
                                            oldCS = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=CircleSize:)([ \\d.]+)")));
                                        }
                                        try
                                        {
                                            oldAR = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldAR:)([ \\d.]+)")));
                                            customMap = true;
                                        }
                                        catch
                                        {
                                            oldAR = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=ApproachRate:)([ \\d.]+)")));
                                        }
                                        try
                                        {
                                            oldOD = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldOD:)([ \\d.]+)")));
                                            customMap = true;
                                        }
                                        catch
                                        {
                                            oldOD = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=OverallDifficulty:)([ \\d.]+)")));
                                        }
                                        if (fromHP <= oldHP & oldHP <= toHP)
                                        {
                                            if (fromCS <= oldCS & oldCS <= toCS)
                                            {
                                                if (mapVersion >= 8)
                                                {
                                                    if (fromAR <= oldAR & oldAR <= toAR)
                                                    {
                                                        if (fromOD <= oldOD & oldOD <= toOD)
                                                        {
                                                            if (relHP == true)
                                                            {
                                                                if (newHP != 0)
                                                                {
                                                                    double tempHP = newHP + oldHP;
                                                                    if (tempHP > 10)
                                                                    {
                                                                        tempHP = 10;
                                                                    }
                                                                    if (tempHP < 0)
                                                                    {
                                                                        tempHP = 0;
                                                                    }
                                                                    beatmapContents = beatmapContents.Replace("HPDrainRate:", "HPDrainRate:" + Convert.ToString(tempHP) + Environment.NewLine + "//OldHP:");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                beatmapContents = beatmapContents.Replace("HPDrainRate:", "HPDrainRate:" + Convert.ToString(newHP) + Environment.NewLine + "//OldHP:");
                                                            }

                                                            if (relCS == true)
                                                            {
                                                                if (newCS != 0)
                                                                {
                                                                    double tempCS = newCS + oldCS;
                                                                    if (tempCS > 10)
                                                                    {
                                                                        tempCS = 10;
                                                                    }
                                                                    if (tempCS < 0)
                                                                    {
                                                                        tempCS = 0;
                                                                    }
                                                                    beatmapContents = beatmapContents.Replace("CircleSize:", "CircleSize:" + Convert.ToString(tempCS) + Environment.NewLine + "//OldCS:");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                beatmapContents = beatmapContents.Replace("CircleSize:", "CircleSize:" + Convert.ToString(newCS) + Environment.NewLine + "//OldCS:");
                                                            }
                                                        }
                                                        if (relAR == true)
                                                        {
                                                            if (newAR != 0)
                                                            {
                                                                double tempAR = newAR + oldAR;
                                                                if (tempAR > 10)
                                                                {
                                                                    tempAR = 10;
                                                                }
                                                                if (tempAR < 0)
                                                                {
                                                                    tempAR = 0;
                                                                }
                                                                beatmapContents = beatmapContents.Replace("ApproachRate:", "ApproachRate:" + Convert.ToString(tempAR) + Environment.NewLine + "//OldAR:");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            beatmapContents = beatmapContents.Replace("ApproachRate:", "ApproachRate:" + Convert.ToString(newAR) + Environment.NewLine + "//OldAR:");
                                                        }

                                                        if (relOD == true)
                                                        {
                                                            if (newOD != 0)
                                                            {
                                                                double tempOD = newOD + oldOD;
                                                                if (tempOD > 10)
                                                                {
                                                                    tempOD = 10;
                                                                }
                                                                if (tempOD < 0)
                                                                {
                                                                    tempOD = 0;
                                                                }
                                                                beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" + Convert.ToString(tempOD) + Environment.NewLine + "//OldOD:");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" + Convert.ToString(newOD) + Environment.NewLine + "//OldOD:");
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (oldMaps == true)
                                                    {
                                                        //treat OD as AR
                                                        if (fromAR < oldOD & oldOD < toAR)
                                                        {
                                                            //make relative adjustments based on AR
                                                            if (relAR == true)
                                                            {
                                                                if (newAR != 0)
                                                                {
                                                                    double tempOD = newAR + oldOD;
                                                                    if (tempOD > 10)
                                                                    {
                                                                        tempOD = 10;
                                                                    }
                                                                    if (tempOD < 0)
                                                                    {
                                                                        tempOD = 0;
                                                                    }
                                                                    beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" + Convert.ToString(tempOD) + Environment.NewLine + "//OldOD:");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" + Convert.ToString(newAR) + Environment.NewLine + "//OldOD:");
                                                                //use AR value as new OD
                                                            }
                                                        }
                                                    }
                                                }
                                                beatmapContents = beatmapContents.Replace("osu file format ", "osu file format v14" + Environment.NewLine + "//Old:");
                                                beatmapContents = beatmapContents.Replace("Version:", "Version:[" + name + "] ");
                                                beatmapContents = beatmapContents.Replace("BeatmapID:", "BeatmapID:-");
                                                string newFileName = currentFile.Replace("].osu", "__" + name + "__].osu");
                                                try
                                                {
                                                    File.WriteAllText(newFileName, beatmapContents);
                                                    Console.WriteLine(newFileName);
                                                    createdFiles += 1;
                                                }
                                                catch
                                                {
                                                    MessageBox.Show("This map's file path is too long. Move or rename it and try again." + Environment.NewLine + newFileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    Console.WriteLine("This map's file path is too long. Move or rename it and try again." + Environment.NewLine);
                                                    Console.WriteLine(newFileName + Environment.NewLine);
                                                    failedFiles += 1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Console.WriteLine("Done! " + createdFiles + " " + name + " copies were created. " + failedFiles + " failed.");
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Done! " + createdFiles + " " + name + " copies were created. " + failedFiles + " failed.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Console.Title = "osu! Map Settings Customizer 2.0";
                        #endregion
                        break;
                    case "update":
                        #region
                        foreach (string currentFolder in songFolders)
                        {
                            foreach (string currentFile in Directory.GetFiles(currentFolder))
                            {
                                if (currentFile.EndsWith(".osu") & !currentFile.EndsWith("__].osu"))
                                {
                                    if (!File.Exists(currentFile.Replace("].osu", "__" + name + "__].osu")))
                                    {
                                        filesPercent = Math.Round((completedFiles / totalFiles * 100.00), 2);
                                        Console.Title = "Creating new beatmaps - " + completedFiles + "/" + totalFiles + " - " + filesPercent + "% complete.";
                                        Application.DoEvents();
                                        string beatmapContents = File.ReadAllText(currentFile);
                                        int mapVersion = 0;
                                        double oldHP = 0;
                                        double oldCS = 0;
                                        double oldAR = 0;
                                        double oldOD = 0;
                                        bool customMap = false;
                                        try
                                        {
                                            mapVersion = Convert.ToInt32(Convert.ToString(Regex.Match(beatmapContents, "(?<=osu file format v)(\\d+)")));
                                        }
                                        catch
                                        {
                                        }
                                        try
                                        {
                                            oldHP = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldHP:)([ \\d.]+)")));
                                            customMap = true;
                                        }
                                        catch
                                        {
                                            oldHP = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=HPDrainRate:)([ \\d.]+)")));
                                        }
                                        try
                                        {
                                            oldCS = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldCS:)([ \\d.]+)")));
                                            customMap = true;
                                        }
                                        catch
                                        {
                                            oldCS = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=CircleSize:)([ \\d.]+)")));
                                        }
                                        try
                                        {
                                            oldAR = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldAR:)([ \\d.]+)")));
                                            customMap = true;
                                        }
                                        catch
                                        {
                                            oldAR = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=ApproachRate:)([ \\d.]+)")));
                                        }
                                        try
                                        {
                                            oldOD = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=//OldOD:)([ \\d.]+)")));
                                            customMap = true;
                                        }
                                        catch
                                        {
                                            oldOD = Convert.ToDouble(Convert.ToString(Regex.Match(beatmapContents, "(?<=OverallDifficulty:)([ \\d.]+)")));
                                        }
                                        if (fromHP <= oldHP & oldHP <= toHP)
                                        {
                                            if (fromCS <= oldCS & oldCS <= toCS)
                                            {
                                                if (mapVersion >= 8)
                                                {
                                                    if (fromAR <= oldAR & oldAR <= toAR)
                                                    {
                                                        if (fromOD <= oldOD & oldOD <= toOD)
                                                        {
                                                            if (relHP == true)
                                                            {
                                                                if (newHP != 0)
                                                                {
                                                                    double tempHP = newHP + oldHP;
                                                                    if (tempHP > 10)
                                                                    {
                                                                        tempHP = 10;
                                                                    }
                                                                    if (tempHP < 0)
                                                                    {
                                                                        tempHP = 0;
                                                                    }
                                                                    beatmapContents = beatmapContents.Replace("HPDrainRate:", "HPDrainRate:" + Convert.ToString(tempHP) + Environment.NewLine + "//OldHP:");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                beatmapContents = beatmapContents.Replace("HPDrainRate:", "HPDrainRate:" + Convert.ToString(newHP) + Environment.NewLine + "//OldHP:");
                                                            }

                                                            if (relCS == true)
                                                            {
                                                                if (newCS != 0)
                                                                {
                                                                    double tempCS = newCS + oldCS;
                                                                    if (tempCS > 10)
                                                                    {
                                                                        tempCS = 10;
                                                                    }
                                                                    if (tempCS < 0)
                                                                    {
                                                                        tempCS = 0;
                                                                    }
                                                                    beatmapContents = beatmapContents.Replace("CircleSize:", "CircleSize:" + Convert.ToString(tempCS) + Environment.NewLine + "//OldCS:");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                beatmapContents = beatmapContents.Replace("CircleSize:", "CircleSize:" + Convert.ToString(newCS) + Environment.NewLine + "//OldCS:");
                                                            }
                                                        }
                                                        if (relAR == true)
                                                        {
                                                            if (newAR != 0)
                                                            {
                                                                double tempAR = newAR + oldAR;
                                                                if (tempAR > 10)
                                                                {
                                                                    tempAR = 10;
                                                                }
                                                                if (tempAR < 0)
                                                                {
                                                                    tempAR = 0;
                                                                }
                                                                beatmapContents = beatmapContents.Replace("ApproachRate:", "ApproachRate:" + Convert.ToString(tempAR) + Environment.NewLine + "//OldAR:");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            beatmapContents = beatmapContents.Replace("ApproachRate:", "ApproachRate:" + Convert.ToString(newAR) + Environment.NewLine + "//OldAR:");
                                                        }

                                                        if (relOD == true)
                                                        {
                                                            if (newOD != 0)
                                                            {
                                                                double tempOD = newOD + oldOD;
                                                                if (tempOD > 10)
                                                                {
                                                                    tempOD = 10;
                                                                }
                                                                if (tempOD < 0)
                                                                {
                                                                    tempOD = 0;
                                                                }
                                                                beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" + Convert.ToString(tempOD) + Environment.NewLine + "//OldOD:");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" + Convert.ToString(newOD) + Environment.NewLine + "//OldOD:");
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (oldMaps == true)
                                                    {
                                                        //treat OD as AR
                                                        if (fromAR < oldOD & oldOD < toAR)
                                                        {
                                                            //make relative adjustments based on AR
                                                            if (relAR == true)
                                                            {
                                                                if (newAR != 0)
                                                                {
                                                                    double tempOD = newAR + oldOD;
                                                                    if (tempOD > 10)
                                                                    {
                                                                        tempOD = 10;
                                                                    }
                                                                    if (tempOD < 0)
                                                                    {
                                                                        tempOD = 0;
                                                                    }
                                                                    beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" + Convert.ToString(tempOD) + Environment.NewLine + "//OldOD:");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                beatmapContents = beatmapContents.Replace("OverallDifficulty:", "OverallDifficulty:" + Convert.ToString(newAR) + Environment.NewLine + "//OldOD:");
                                                                //use AR value as new OD
                                                            }
                                                        }
                                                    }
                                                }
                                                beatmapContents = beatmapContents.Replace("osu file format ", "osu file format v14" + Environment.NewLine + "//Old:");
                                                beatmapContents = beatmapContents.Replace("Version:", "Version:[" + name + "] ");
                                                beatmapContents = beatmapContents.Replace("BeatmapID:", "BeatmapID:-");
                                                string newFileName = currentFile.Replace("].osu", "__" + name + "__].osu");
                                                try
                                                {
                                                    File.WriteAllText(newFileName, beatmapContents);
                                                    Console.WriteLine(newFileName);
                                                    createdFiles += 1;
                                                }
                                                catch
                                                {
                                                    MessageBox.Show("This map's file path is too long. Move or rename it and try again." + Environment.NewLine + newFileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    Console.WriteLine("This map's file path is too long. Move or rename it and try again." + Environment.NewLine);
                                                    Console.WriteLine(newFileName + Environment.NewLine);
                                                    failedFiles += 1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Console.WriteLine("Done! " + createdFiles + " " + name + " copies were created. " + failedFiles + " failed.");
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Done! " + createdFiles + " " + name + " copies were created. " + failedFiles + " failed.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Console.Title = "osu! Map Settings Customizer 2.0";
                        #endregion
                        break;
                    case "delete":
                        #region
                        foreach (string currentFolder in songFolders)
                        {
                            foreach (string currentFile in Directory.GetFiles(currentFolder))
                            {
                                if (currentFile.EndsWith("__" + name + "__].osu"))
                                {
                                    filesPercent = Math.Round((completedFiles / totalFiles * 100.00), 2);
                                    Console.Title = "Deleting beatmaps - " + completedFiles + "/" + totalFiles + " - " + filesPercent + "% complete.";
                                    Application.DoEvents();
                                    try
                                    {
                                        File.Delete(currentFile);
                                        Console.WriteLine(currentFile);
                                        completedFiles += 1;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        Console.WriteLine(ex.Message);
                                        failedFiles += 1;
                                    }
                                }
                            }
                        }

                        Console.WriteLine("Done! " + completedFiles + " " + name + " copies were deleted. " + failedFiles + " failed.");
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Done! " + completedFiles + " " + name + " copies were deleted.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Console.Title = "osu! Map Settings Customizer 2.0";
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
