using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace GameLibrary
{
    class GameFactory
    {
        StreamWriter sw;
        XmlSerializer serial;
        List<Games> gameList;
        const string GAME_FILENAME = @"..\..\gameslab.xml";

        public void CreateGameList()
        {
            gameList = new List<Games>();
            Games G = new Games("Yankees", "Red Sox", 11, 2);
            gameList.Add(G);
            G = new Games("Dodgers", "Marlins", 3, 5);
            gameList.Add(G);
            G = new Games("Rangers", "Giants", 4, 1);
            gameList.Add(G);
            G = new Games("Mets", "Braves", 6, 2);
            gameList.Add(G);
            G = new Games("Angels", "Cardinals", 1, 2);
            gameList.Add(G);
            G = new Games("Twins", "Brewers", 3, 9);
        }

        public void SerializeGames()
        { 
            serial = new XmlSerializer(gameList.GetType());
            sw = new StreamWriter(GAME_FILENAME);
            serial.Serialize(sw, gameList);
            sw.Close();
        }

        public List<Games> ReadGamesList(out string finalMessage)
        {
            try
            {
                gameList = new List<Games>();
                StreamReader sr = new StreamReader(GAME_FILENAME);
                serial = new XmlSerializer(gameList.GetType());
                gameList = (List<Games>)serial.Deserialize(sr);
                sr.Close();
                finalMessage = "Success";
                return gameList;

            }
            catch (Exception ex)
            {
                finalMessage = "Exception thrown: " + ex.Message;
                return null;
            }
        }
    }
}
