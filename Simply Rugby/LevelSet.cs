

using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;

namespace SimplyRugby
{
    /// <summary>
    /// LevelSet contains information about the level set we can play. This
    /// level set information is stored in an XML file.
    /// </summary>
    public class LevelSet
    {
        // Collection of the levels in a XML level set
        private ArrayList levels = new ArrayList();
        
        private string filename = string.Empty;
		
		#region Properties
		
        public string Filename
        {
            get { return filename; }
        }
        
 
        #endregion
		
		
        public LevelSet(string aFilename)
        {
            filename = aFilename;
        }
        
        
        /// <summary>
        /// Constructor
        /// </summary>
        public LevelSet() {}
    }
}
