using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Notepad_
{
    class Log
    {
        // Array for file versions.
        public string[] fileversions { get; set; }
        // Array for all files.
        public string[] allfiles { get; set; }
        /// <summary>
        /// Designer to determine the name of the directory.
        /// </summary>
        /// <param name="filename"></param>
        public Log(string filename)
        {
            if (filename != null)
            {
                string directoryname = Path.Combine(Environment.GetFolderPath
                                (Environment.SpecialFolder.LocalApplicationData),
                                System.Reflection.Assembly.GetEntryAssembly().GetName().Name,
                                "backup", filename.ToUpper().GetHashCode().ToString());
            }
        }
        /// <summary>
        /// A method that defines all versions of the file.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="directoryname"></param>
        /// <returns></returns>
        public string[] GetFileVersions(string filename,string directoryname)
        {
           
                if (Directory.Exists(directoryname))
                {

                    allfiles = Directory.GetFiles(directoryname);

                    
                }
            return allfiles;
        }

    }
}
