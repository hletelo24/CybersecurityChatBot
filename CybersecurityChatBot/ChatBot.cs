using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityChatBot
{
    internal class ChatBot
    {
        public string UserName { get; set; }

        private void PlayGreeting()
        {
            try
            {
                //Use of SoundPlayer to play a greeting audio file
                SoundPlayer player = new SoundPlayer("repos\\CyberSecurityChatbot\\greeting.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Audio file missing");
            }
        }

        //method to display ASCII art of the chatbot
        private void ShowAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;


            Console.WriteLine(@"

  /$$$$$$            /$$                                  /$$$$$$                                          /$$   /$$              
 /$$__  $$          | $$                                 /$$__  $$                                        |__/  | $$              
| $$  \__/ /$$   /$$| $$$$$$$   /$$$$$$   /$$$$$$       | $$  \__/  /$$$$$$   /$$$$$$$ /$$   /$$  /$$$$$$  /$$ /$$$$$$   /$$   /$$
| $$      | $$  | $$| $$__  $$ /$$__  $$ /$$__  $$      |  $$$$$$  /$$__  $$ /$$_____/| $$  | $$ /$$__  $$| $$|_  $$_/  | $$  | $$
| $$      | $$  | $$| $$  \ $$| $$$$$$$$| $$  \__/       \____  $$| $$$$$$$$| $$      | $$  | $$| $$  \__/| $$  | $$    | $$  | $$
| $$    $$| $$  | $$| $$  | $$| $$_____/| $$             /$$  \ $$| $$_____/| $$      | $$  | $$| $$      | $$  | $$ /$$| $$  | $$
|  $$$$$$/|  $$$$$$$| $$$$$$$/|  $$$$$$$| $$            |  $$$$$$/|  $$$$$$$|  $$$$$$$|  $$$$$$/| $$      | $$  |  $$$$/|  $$$$$$$
 \______/  \____  $$|_______/  \_______/|__/             \______/  \_______/ \_______/ \______/ |__/      |__/   \___/   \____  $$
           /$$  | $$                                                                                                     /$$  | $$
          |  $$$$$$/                                                                                                    |  $$$$$$/
           \______/                                                                                                      \______/ 
            
            Awareness Bot
");
            Console.ResetColor();
        }
    }
}
