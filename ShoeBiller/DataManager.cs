using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShoeBiller
{
    class DataManager
    {

        #region attributes

        // private string pathMyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // define data path
        private string dataPath = Application.UserAppDataPath;
        // define class to save or open binary files
        FileStream file;
        FileStream fileBackup;
        BinaryReader binaryReader;
        BinaryWriter binaryWriter;
        // define FiloInfo object
        public FileInfo fileInfo;
        // define binary file to manage data
        private string binaryFile;
        private uint dataSize;

        #endregion

        /// <summary>
        /// when class is created
        /// </summary>
        /// <param name="binaryFile"></param>
        public DataManager(string binaryFile, uint dataSize)
        {

            // set attributes
            this.binaryFile = binaryFile;
            this.dataSize = dataSize;

            // call to create binary file if not exist
            createBinaryFile();

        }

        #region private functions

        /// <summary>
        /// create a binary file with name into binaryFile if this not exist
        /// </summary>
        private void createBinaryFile()
        {
            if (!File.Exists(dataPath + "\\" + binaryFile)) File.Create(dataPath+ "\\" + binaryFile).Close();
        }

        /// <summary>
        /// setup the file and the binaryReader to read data
        /// </summary>
        /// <param name="index"></param>
        private void initBinaryReader(uint index)
        {
            // setup file stream as open with read access
            file = new FileStream(dataPath + "\\" + binaryFile, FileMode.Open, FileAccess.Read);
            // set the stream read
            binaryReader = new BinaryReader(file, Encoding.Default);
            // set read position at position
            file.Position = index * dataSize;
        }


        #endregion

        #region public functions

        /// <summary>
        /// using FileInfo class and defined data size calculate the total saved records in binaryFile
        /// </summary>
        /// <returns></returns>
        public uint getTotalRecords()
        {
            fileInfo = new FileInfo(dataPath + "\\" + binaryFile);
            return (uint) fileInfo.Length / dataSize;
        }

        /// <summary>
        /// save a record with data of array
        /// </summary>
        /// <param name="index">-1 to new record or greater to edit a one record in this position</param>
        /// <param name="data">data to save</param>
        public void saveRecord(int index, string[] data)
        {
            // set communication channer in append mode with writting permissions
            if (index == -1)
                file = new FileStream(dataPath + "\\" + binaryFile, FileMode.Append, FileAccess.Write);
            else
            {
                file = new FileStream(dataPath + "\\" + binaryFile, FileMode.Open, FileAccess.Write);
                file.Position = index * dataSize;
            }
            // set stream writter
            binaryWriter = new BinaryWriter(file, Encoding.Default);
            // writte each element of data
            for (byte i = 0; i < data.Length; i++)
            {
                binaryWriter.Write(data[i]);
            }
            // close file and stream
            binaryWriter.Close();
            file.Close();
        }

        /// <summary>
        /// read a client data and get these values in a Client object
        /// </summary>
        /// <param name="index">position of record to read</param>
        /// <returns></returns>
        public Client readClient(uint index)
        {
            // define a client object to set loaded data
            Client client = new Client();

            // validate if binaryFile have records
            if (getTotalRecords() > 0)
            {
                // init a binary reader
                initBinaryReader(index);
                // set each attribute of client object reading file
                client.Nuip = binaryReader.ReadString();
                client.Names = binaryReader.ReadString();
                client.Surnames = binaryReader.ReadString();
                client.Phone = binaryReader.ReadString();
                client.Email = binaryReader.ReadString();
                // close file and binary reader
                binaryReader.Close();
                file.Close();
            }
            
            return client;
        }

        #endregion
    }
}
