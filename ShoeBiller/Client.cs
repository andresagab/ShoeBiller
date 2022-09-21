using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeBiller
{
    class Client
    {

        #region attributes

        // define data size in bytes
        public const uint dataSize = 185;
        // define default binary file name
        public const string binaryFileName = "clients.sbl";

        // nuip
        public string nuip;

        /// <summary>
        /// the nuip of client
        /// </summary>
        public string Nuip
        {
            get { return nuip; }
            set { nuip = value.PadRight(20, ' ').Substring(0, 20); }
        }

        // names
        public string names;

        public string Names
        {
            get { return names; }
            set { names = value.PadRight(40, ' ').Substring(0, 40); }
        }

        // surnames
        public string surnames;

        public string Surnames
        {
            get { return surnames; }
            set { surnames = value.PadRight(40, ' ').Substring(0, 40); }
        }

        // phone
        public string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value.PadRight(20, ' ').Substring(0, 20); }
        }

        // email
        public string email;

        public string Email
        {
            get { return email; }
            set { email = value.PadRight(60, ' ').Substring(0, 60); }
        }

        #endregion

        #region constructors

        /// <summary>
        /// default construct for a empty object
        /// </summary>
        public Client() { }

        /// <summary>
        /// create a Client object with init data
        /// </summary>
        /// <param name="data">string array with data for each attribute</param>
        public Client(string[] data)
        {
            // set attributes with received data
            Nuip = data[0];
            Names = data[1];
            Surnames = data[2];
            Phone = data[3];
            Email = data[4];
        }

        /// <summary>
        /// get data of attributes in array
        /// </summary>
        /// <returns></returns>
        public string[] dataAttributesToArray()
        {
            string[] data = new string[5];

            data[0] = Nuip;
            data[1] = Names;
            data[2] = Surnames;
            data[3] = Phone;
            data[4] = Email;

            return data;
        }

        #endregion

    }
}
