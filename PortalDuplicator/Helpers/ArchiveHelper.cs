using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace DMM365.Helper
{
    internal static class ArchiveHelper
    {
        internal static bool isFileInZipArchive(string sourceZipFilePath, string fileName)
        {
            using (ZipArchive archive = ZipFile.OpenRead(@sourceZipFilePath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.Equals(fileName, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        internal static void CreateZipFromDirectory(string sourceFolder, string destinationZipFilePath)
        {
            ZipFile.CreateFromDirectory(sourceFolder, @destinationZipFilePath);
        }


        internal static void ExtractZipToDirectory(string sourceZipFilePath, string destinationFolder)
        {
            ZipFile.ExtractToDirectory(@sourceZipFilePath, destinationFolder);
        }


        internal static void ExtractZipContentByFileName(string sourceZipFilePath, string fileName, string destinationFilePath)
        {
            using (ZipArchive archive = ZipFile.OpenRead(@sourceZipFilePath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.Equals(fileName, StringComparison.OrdinalIgnoreCase))
                    {
                        entry.ExtractToFile(destinationFilePath, true);
                    }
                }
            }
        }

        internal static void addFileToExistingZip(string sourceZipFilePath, string fileToAddPath)
        {
            using (FileStream zipToOpen = new FileStream(@sourceZipFilePath, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.CreateEntryFromFile(@sourceZipFilePath, Path.GetFileName(fileToAddPath));
                }
            }
        }


        internal static void createZipFromFile(string sourceFilePath, string destinationZipFilePath)
        {
            using (var archive = ZipFile.Open(destinationZipFilePath, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(@sourceFilePath, Path.GetFileName(sourceFilePath));
            }
        }



    }
}
