using System;

namespace GuessWho
{
    public class Characters
    {
        public Characters(string name, bool hat, bool glasses, bool male, string hairColor, bool facialHair, string eyeColor, bool earrings)
        {
            this.name = name;
            this.hat = hat;
            this.glasses = glasses;
            this.male = male;
            this.hairColor = hairColor;
            this.facialHair = facialHair;
            this.eyeColor = eyeColor;
            this.earrings = earrings;
        }
        public string name;
        public bool hat;
        public bool glasses;
        public bool male;
        public string hairColor;
        public bool facialHair;
        public string eyeColor;
        public bool earrings;

    }
}
