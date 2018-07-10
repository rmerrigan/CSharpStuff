using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace NaughtyWords
{
    class NaughtyWordsLogic
    {
        static String path = "nWords.txt";
        static SpeechSynthesizer synth = new SpeechSynthesizer();
        static List<String> nWords = System.IO.File.ReadAllLines(path).ToList<String>();

        static void Main(string[] args)
        {
            loadPrompt();
            mainListLooper();

            Console.ReadKey();

        }

        private static void mainListLooper()
        {
            Random rnd = new Random();
            int num = rnd.Next(20, 25);

            for (int i = 0; i <= num; i++)
            {
                sayOneWord(nWords);
            }
        }

        static void rerunPrompt()
        {

        }

        static void sayOneWord(List<String> list)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, list.Count-1);
            String word = list.ElementAt(num);
            Console.WriteLine(word);
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
            synth.Speak(word);
            
        }

        static void loadPrompt()
        {
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
            Console.WriteLine("Wanna hear some naughty words?");
            synth.Speak("Wanna hear some naughty words?");
            Console.WriteLine("Here we go!");
            synth.Speak("Here we go!");
            
        }

    }
}
