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

        public void Start()
        {
            Console.Title = "Cybersecurity Awareness Bot";
            PlayGreeting();
            ShowAsciiArt();
            GetUserName();
            ChatLoop();
        }

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

        private void GetUserName()
        {
            Console.Write("Enter your name: ");
            UserName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(UserName))
            {
                UserName = "User";
            }

            TypeText($"\nHello {UserName}! Welcome to Cybersecurity Awareness Bot.\n");
        }

        //main chat loop where the user can ask questions and get responses
        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    TypeText("Please enter something.");
                    continue;
                }

                if (input.Contains("exit"))
                {
                    TypeText("Goodbye! Stay safe online!");
                    break;
                }

                Respond(input);
            }
        }

        private void Respond(string input)
        {

            switch (input)
            {
                case var s when s.Contains("how are you"):
                    TypeText("I'm just a bot, but I'm here to keep you safe online! 😊");
                    break;
                case var s when s.Contains("purpose"):
                    TypeText("My purpose is to educate you about cybersecurity and keep you safe online.");
                    break;

                case var s when s.Contains("ask"):
                    TypeText("You can ask me about:\n- Password safety\n- Phishing\n- Safe browsing");
                    break;

                case var s when s.Contains("password"):
                    TypeText("Use strong passwords with letters, numbers, and symbols. Never share them!");
                    break;

                case var s when s.Contains("phishing"):
                    TypeText("Be careful of fake emails asking for personal info. Always verify the sender.");
                    break;

                case var s when s.Contains("safe browsing"):
                    TypeText("Only visit secure websites (https) and avoid clicking suspicious links.");
                    break;
                default:
                    TypeText("I didn’t understand that. Try asking about cybersecurity topics.");
                    break;
            }

        }

        private void TypeText(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }
    }
}
