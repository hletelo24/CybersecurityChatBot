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
    }
}
