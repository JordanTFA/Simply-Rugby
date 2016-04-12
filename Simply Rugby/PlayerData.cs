using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.XPath;

namespace SimplyRugby
{
	public class PlayerData
	{
        // Declares all strings that will be used for the player's skills
        private string squad = string.Empty;
	    private string name = string.Empty;
        private string standard = string.Empty;
	    private string filename = string.Empty;
        private string spin = string.Empty;
        private string pop = string.Empty;
        private string front = string.Empty;
        private string rear = string.Empty;
        private string side = string.Empty;
        private string scrabble = string.Empty;
        private string drop = string.Empty;
        private string punt = string.Empty;
        private string grubber = string.Empty;
        private string goal = string.Empty;
        private string passingcomments = string.Empty;
        private string tacklingcomments = string.Empty;
        private string kickingcomments = string.Empty;

	
        #region Properties
        
        public string Name
        {
            get 
            { 
                return name; 
            }
        }

        public string Standard
        {
            get
            {
                return standard;
            }
        }

        public string Spin
        {
            get
            {
                return spin;
            }
        }
        public string Pop
        {
            get
            {
                return pop;
            }
        }
        public string Front
        {
            get
            {
                return front;
            }
        }
        public string Rear
        {
            get
            {
                return rear;
            }
        }
        public string Side
        {
            get
            {
                return side;
            }
        }
        public string Scrabble
        {
            get
            {
                return scrabble;
            }
        }
        public string Drop
        {
            get
            {
                return drop;
            }
        }
        public string Punt
        {
            get
            {
                return punt;
            }
        }
        public string Grubber
        {
            get
            {
                return grubber;
            }
        }
        public string Goal
        {
            get
            {
                return goal;
            }
        }

        public string PassingComments
        {
            get
            {
                return passingcomments;
            }
        }
        public string TacklingComments
        {
            get
            {
                return tacklingcomments;
            }
        }
        public string KickingComments
        {
            get
            {
                return kickingcomments;
            }
        }
        



		
		#endregion

        // Sets the name and squad to the selected player
		public PlayerData(string aName, string aRange)
		{
		    name = aName;
            squad = aRange;
		    
            // Gets path
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
            filename = path + "/players/" + "/" + squad + "/" + aName + ".xml";
		}
		
		

        public void CreatePlayer(LevelSet levelSet)
        {
            XmlDocument doc = new XmlDocument();
            XmlTextWriter writer = new XmlTextWriter(filename, null);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteProcessingInstruction("xml",
                "version='1.0' encoding='ISO-8859-1'");
            writer.WriteStartElement("players");
            writer.Close();
            doc.Load(filename);
            XmlNode root = doc.DocumentElement;

            XmlElement Username = doc.CreateElement("playerName");
            Username.InnerText = name;
            XmlElement levelSets = doc.CreateElement("levelSets");
            XmlElement nodePassing = doc.CreateElement("nodePassing");
			    XmlAttribute passing = doc.CreateAttribute("title");
			    passing.Value = "Passing";
			    nodePassing.Attributes.Append(passing);
			    XmlElement Standard = doc.CreateElement("Standard");
			    Standard.InnerText = "0";
			    XmlElement Spin = doc.CreateElement("Spin");
			    Spin.InnerText = "0";
			    XmlElement Pop = doc.CreateElement("Pop");
			    Pop.InnerText = "0";
                XmlElement PassingComments = doc.CreateElement("PassingComments");
                PassingComments.InnerText = "No Comments Available";
           XmlElement nodeTackling = doc.CreateElement("nodeTackling");
                XmlAttribute tackling = doc.CreateAttribute("title");
                tackling.Value = "Tackling";
                nodeTackling.Attributes.Append(tackling);
                XmlElement tfront = doc.CreateElement("front");
                tfront.InnerText = "0";
                XmlElement trear = doc.CreateElement("rear");
                trear.InnerText = "0";
                XmlElement tside = doc.CreateElement("side");
                tside.InnerText = "0";
                XmlElement tscrabble = doc.CreateElement("scrabble");
                tscrabble.InnerText = "0";
                XmlElement TacklingComments = doc.CreateElement("TacklingComments");
                TacklingComments.InnerText = "No Comments Available";
           XmlElement nodeKicking = doc.CreateElement("nodeKicking");
                XmlAttribute kicking = doc.CreateAttribute("title");
                kicking.Value = "Kicking";
                nodeKicking.Attributes.Append(kicking);
                XmlElement kdrop = doc.CreateElement("Drop");
                kdrop.InnerText = "0";
                XmlElement kpunt = doc.CreateElement("Punt");
                kpunt.InnerText = "0";
                XmlElement kgrubber = doc.CreateElement("Grubber");
                kgrubber.InnerText = "0";
                XmlElement kgoal = doc.CreateElement("Goal");
                kgoal.InnerText = "0";
                XmlElement KickingComments = doc.CreateElement("KickingComments");
                KickingComments.InnerText = "No Comments Available";
            nodePassing.AppendChild(Standard);
            nodePassing.AppendChild(Spin);
            nodePassing.AppendChild(Pop);
            nodePassing.AppendChild(PassingComments);
            levelSets.AppendChild(nodePassing);
            nodeTackling.AppendChild(tfront);
            nodeTackling.AppendChild(trear);
            nodeTackling.AppendChild(tside);
            nodeTackling.AppendChild(tscrabble);
            nodeTackling.AppendChild(TacklingComments);
            levelSets.AppendChild(nodeTackling);
            nodeKicking.AppendChild(kdrop);
            nodeKicking.AppendChild(kpunt);
            nodeKicking.AppendChild(kgrubber);
            nodeKicking.AppendChild(kgoal);
            nodeKicking.AppendChild(KickingComments);
            levelSets.AppendChild(nodeKicking);
            root.AppendChild(Username);
            root.AppendChild(levelSets);
            doc.Save(filename);
        }
        
		
		public void LoadPlayerInfo(LevelSet levelSet)
		{            
            //XmlDocument doc = new XmlDocument();
           // doc.Load(filename);

		}

		public void SaveLevel(string aStandard,
                                string kickdrop,
                                string passspin,
                                string passpop,
                                string passcomment,
                                string tacklingfront,
                                string tacklingrear,
                                string tacklingscrabble,
                                string tacklingside,
                                string tacklingcomments1,
                                string kickinggoal,
                                string kickinggrubber,
                                string kickingpunt,
                                string kickingcomment)
		{
            // Writes the new values to a variable in preperation to save to the xml document
            standard = aStandard;
            drop = kickdrop;
            spin = passspin;
            pop = passpop;
            passingcomments = passcomment;
            front = tacklingfront;
            rear = tacklingrear;
            scrabble = tacklingscrabble;
            side = tacklingside;
            tacklingcomments = tacklingcomments1;
            goal = kickinggoal;
            grubber = kickinggrubber;
            punt = kickingpunt;
            kickingcomments = kickingcomment;

            // Writes the new values to the xml document
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNode Standard = doc.SelectSingleNode("//Standard");
            Standard.InnerText = standard;
            XmlNode Spin = doc.SelectSingleNode("//Spin");
            Spin.InnerText = spin;
            XmlNode Pop = doc.SelectSingleNode("//Pop");
            Pop.InnerText = pop;
            XmlNode PassComments = doc.SelectSingleNode("//PassingComments");
            PassComments.InnerText = passcomment;
            XmlNode Front = doc.SelectSingleNode("//front");
            Front.InnerText = front;
            XmlNode Rear = doc.SelectSingleNode("//rear");
            Rear.InnerText = rear;
            XmlNode Side = doc.SelectSingleNode("//side");
            Side.InnerText = side;
            XmlNode Scrabble = doc.SelectSingleNode("//scrabble");
            Scrabble.InnerText = scrabble;
            XmlNode TacklingComments = doc.SelectSingleNode("//TacklingComments");
            TacklingComments.InnerText = tacklingcomments;
            XmlNode Drop = doc.SelectSingleNode("//Drop");
            Drop.InnerText = drop;
            XmlNode Punt = doc.SelectSingleNode("//Punt");
            Punt.InnerText = punt;
            XmlNode Grubber = doc.SelectSingleNode("//Grubber");
            Grubber.InnerText = grubber;
            XmlNode Goal = doc.SelectSingleNode("//Goal");
            Goal.InnerText = goal;
            XmlNode KickingComments = doc.SelectSingleNode("//KickingComments");
            KickingComments.InnerText = kickingcomment;
            doc.Save(filename);
		}


        public void LoadData()
        {
            // Loads the player's stats from an XML document
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNode Standard = doc.SelectSingleNode("//Standard");
            standard = Standard.InnerText;
            XmlNode Spin = doc.SelectSingleNode("//Spin");
            spin = Spin.InnerText;
            XmlNode Pop = doc.SelectSingleNode("//Pop");
            pop = Pop.InnerText;
            XmlNode PassComments = doc.SelectSingleNode("//PassingComments");
            passingcomments = PassComments.InnerText;
            XmlNode Front = doc.SelectSingleNode("//front");
            front = Front.InnerText;
            XmlNode Rear = doc.SelectSingleNode("//rear");
            rear = Rear.InnerText;
            XmlNode Side = doc.SelectSingleNode("//side");
            side = Side.InnerText;
            XmlNode Scrabble = doc.SelectSingleNode("//scrabble");
            scrabble = Scrabble.InnerText;
            XmlNode TacklingComments = doc.SelectSingleNode("//TacklingComments");
            tacklingcomments = TacklingComments.InnerText;
            XmlNode Drop = doc.SelectSingleNode("//Drop");
            drop = Drop.InnerText;
            XmlNode Punt = doc.SelectSingleNode("//Punt");
            punt = Punt.InnerText;
            XmlNode Grubber = doc.SelectSingleNode("//Grubber");
            grubber = Grubber.InnerText;
            XmlNode Goal = doc.SelectSingleNode("//Goal");
            goal = Goal.InnerText;
            XmlNode KickingComments = doc.SelectSingleNode("//KickingComments");
            kickingcomments = KickingComments.InnerText;
        }





        // Loads the Junior info from the file using an xml reader
        public static ArrayList JuniorPlayerList()
        {
            ArrayList playerNames = new ArrayList();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
            string [] fileEntries = Directory.GetFiles(path + "/players/Junior");
            foreach(string filename in fileEntries)
            {
                FileInfo fileInfo = new FileInfo(filename);
                if (fileInfo.Extension.Equals(".xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filename);
                    
                    XmlNode playerName = doc.SelectSingleNode("//playerName");
                    if (playerName != null)
                        playerNames.Add(playerName.InnerText);
                }
            }
		    
            return playerNames;
        }

        // Loads the NonPlayer info from the file using an xml reader
        public static ArrayList NonPlayerList()
        {
            ArrayList playerNames = new ArrayList();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
            string[] fileEntries = Directory.GetFiles(path + "/players/NonPlayer");
            foreach (string filename in fileEntries)
            {
                FileInfo fileInfo = new FileInfo(filename);
                if (fileInfo.Extension.Equals(".xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filename);

                    XmlNode playerName = doc.SelectSingleNode("//playerName");
                    if (playerName != null)
                        playerNames.Add(playerName.InnerText);
                }
            }

            return playerNames;
        }

        // Loads the Senior info from the file using an xml reader
        public static ArrayList SeniorPlayerList()
        {
            ArrayList playerNames = new ArrayList();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
            string[] fileEntries = Directory.GetFiles(path + "/players/Senior");
            foreach (string filename in fileEntries)
            {
                FileInfo fileInfo = new FileInfo(filename);
                if (fileInfo.Extension.Equals(".xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filename);

                    XmlNode playerName = doc.SelectSingleNode("//playerName");
                    if (playerName != null)
                        playerNames.Add(playerName.InnerText);
                }
            }

            return playerNames;
        }
    }
}
