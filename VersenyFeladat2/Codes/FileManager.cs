using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace VersenyFeladat2.Codes
{
    class FileManager : IDisposable
    {

        #region Constructors

        public FileManager() { }

        #endregion

        #region Methods

        /// <summary>
        /// Fill the data with the loaded lines from the file
        /// 
        /// Be careful, becouse its override the data input!
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Load( ref string data )
        {
            data = "";

            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog()
                {
                    Filter = "CSV Files (*.csv)|*.csv",

                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    Multiselect = false,

                    RestoreDirectory = false
                };

                if (fileDialog.ShowDialog() != DialogResult.OK) return false; // If the user not clicked the OK button then the selection is failed!
                if (string.IsNullOrEmpty(fileDialog.FileName)) return false; // If the user is not select any file the selection if failed!

                using (FileStream fileStream = File.Open(fileDialog.FileName, FileMode.Open))
                {
                    using (StreamReader stream = new StreamReader(fileStream))
                    {
                        while (!stream.EndOfStream)
                        {
                            data += stream.ReadLine() + "\n";
                        }

                        stream.Close();
                    }
                    fileStream.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public void Dispose(){}

        #endregion
    }
}
