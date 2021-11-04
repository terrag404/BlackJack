using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BlackJack
{
    public class Utilities
    {
        public static void CreateLogFile(string logText)
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + Properties.Settings.Default.logDir))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + Properties.Settings.Default.logDir);
            string logFileName = Directory.GetCurrentDirectory() + "\\" + Properties.Settings.Default.logDir + "\\" + "gameLog.txt";
            File.WriteAllText(logFileName, logText);
        }

        public static void ReadLogs(TextBox statsBox)
        {
            string logFileName = Directory.GetCurrentDirectory() + "\\" + Properties.Settings.Default.logDir + "\\" + "gameLog.txt";
            int winCount = 0;
            int lossCount = 0;
            int drawCount = 0;
            if (File.Exists(logFileName))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(logFileName);
                string line = String.Empty;

                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("Win"))
                    {
                        string winString = StripNonNumeric(line);
                        winCount = Convert.ToInt32(winString);
                    }
                    if (line.Contains("Loss"))
                    {
                        string lossString = StripNonNumeric(line);
                        lossCount = Convert.ToInt32(lossString);
                    }
                    if (line.Contains("Draw"))
                    {
                        string drawString = StripNonNumeric(line);
                        drawCount = Convert.ToInt32(drawString);
                    }
                }
                statsBox.Text = "Win: " + winCount + Environment.NewLine + "Loss: " + lossCount + Environment.NewLine + "Draw: " + drawCount;
                file.Close();
            }
            else
            {
                statsBox.Text = "Win: " + winCount + Environment.NewLine + "Loss: " + lossCount + Environment.NewLine + "Draw: " + drawCount;
            }            
        }

        private static string StripNonNumeric(string input)
        {
            string output = Regex.Replace(input, @"[^0-9.]+", "");
            return output.Trim();
        }
    }
}
