using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace First_project.GlobalClasses
{
    internal class clsUtilties
    {
        public static string GenerateGuid()
        {
            Guid GuidID = Guid.NewGuid();   
            return GuidID.ToString();   
        }
        // this is crerat new File if not Exist
        public static bool CreateFileIfNotExist(string FilePath )
        {
            if(!Directory.Exists(FilePath)) 
            {
              try
                {
                    Directory.CreateDirectory(FilePath);
                    return true;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Canet Create Folder du to {ex.Message} ");
                    return false;
                
                }   
            
            }
            return true;

        }

        public static string ReplaceImageNameWithGUID(string SourceFile)
        {
            string FileName = SourceFile;   
            FileInfo info = new FileInfo(FileName); 
            string extn = info.Extension;   
            return GenerateGuid()+ extn;
        }
        // this funciton will Copy image to Project Images;
        public static bool CopyImageToProjectImages(ref string sourceFile)
        {

            string DestinationFolder = @"C:\DVLD-People-Image\"; //hjdhfjdh567643.png

            if (!CreateFileIfNotExist(DestinationFolder))
            {
                return false;
            }


            // the new destinationFile will be the DestinationFolder + the image after replacing the name
            string destinationFile = DestinationFolder + ReplaceImageNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
    }
}
