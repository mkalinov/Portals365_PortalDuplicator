using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DMM365.Helper
{
    internal static class ReplaceIDHelper
    {

        const string patternDefault = "[a-fA-F0-9]{8}-([a-fA-F0-9]{4}-){3}[a-fA-F0-9]{12}";

        const string dictionaryPatternDefault = "<record id=\"([a-fA-F0-9]{8}-([a-fA-F0-9]{4}-){3}[a-fA-F0-9]{12})\">";


        internal static void replaceGuids(string sorceFilePath, string destinationFilePath, string regexPattern = "", string dictionaryRegexPattern = "")
        {
            if (!File.Exists(sorceFilePath)) throw new Exception("Source file not found");

            StreamReader sr = new StreamReader(sorceFilePath);
            string text = sr.ReadToEnd();
            sr.Close();

            string pattern = GlobalHelper.isValidString(regexPattern) ? regexPattern : patternDefault;
            string dpattern = GlobalHelper.isValidString(dictionaryRegexPattern) ? regexPattern : dictionaryPatternDefault;


            StringBuilder sbNew = new StringBuilder();

            Dictionary<string, string> dicGuid = new Dictionary<string, string>();


            foreach (Match m in Regex.Matches(text, dpattern))
            {
                string match = m.Groups[1].Value;
                if (!dicGuid.ContainsKey(match))
                {
                    string newGuid = String.Empty;
                    newGuid = Guid.NewGuid().ToString();
                    dicGuid.Add(match, newGuid);
                }
            }


            int lastStart = 0;
            foreach (Match m in Regex.Matches(text, pattern))
            {
                string match = m.Value;
                string newGuid = String.Empty;
                if (dicGuid.ContainsKey(match))
                {
                    newGuid = dicGuid[match];
                }
                else
                {
                    // do not replace this GUID is coming from outside!
                    newGuid = match;
                }
                sbNew.Append(text.Substring(lastStart, m.Index - lastStart));
                sbNew.Append(newGuid);
                lastStart = m.Index + m.Length;
            }

            sbNew.Append(text.Substring(lastStart));

            Encoding utf8withoutBOM = new UTF8Encoding(false);
            StreamWriter sw = new StreamWriter(destinationFilePath, false, utf8withoutBOM);
            sw.Write(sbNew.ToString());
            sw.Flush();
            sw.Close();

        }
    }
}
