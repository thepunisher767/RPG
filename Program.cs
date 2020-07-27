using System;
using System.Collections.Generic;

namespace RPG
{
    class GameCharacter
    {
        protected string _name { get; set; }
        protected int _strength { get; set; }
        protected int _intel { get; set; }

        public GameCharacter(string name, int strength, int intel)
        {
            _name = name;
            _strength = strength;
            _intel = intel;
        }
        public virtual void Play()
        {
        }
    }

    class MagicUsingCharacter : GameCharacter
    {
        private int _magic { get; set; }

        public MagicUsingCharacter(string name, int strength, int intel, int magic) : base(name, strength, intel)
        {
            _magic = magic;
        }
        public override void Play()
        {
            Console.Write($"{_name} (int {_intel}, strength {_strength}, magic {_magic})");
        }
    }

    class Wizard : MagicUsingCharacter
    {
        private int _spellNumber { get; set; }

        public Wizard(string name, int strength, int intel, int magic, int spellNumber) : base(name, strength, intel, magic)
        {
            _spellNumber = spellNumber;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($" {_spellNumber} spells");
        }
    }

    class Warrior : GameCharacter
    {
        private string _weaponType { get; set; }

        public Warrior(string name, int strength, int intel, string weaponType) : base(name, strength, intel)
        {
            _weaponType = weaponType;
        }
        public override void Play()
        {
            Console.WriteLine($"{_name} (int {_intel}, strength {_strength}) {_weaponType}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World of Dev.Buildcraft!!!\n");
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(new Warrior("Frank \"SweetPeaches69\" Reynolds", 0, 99, "Toe Knife"));
            gameCharacters.Add(new Warrior("Mac", 45, 0, "Fists"));
            gameCharacters.Add(new Warrior("Charlie", 12, -10, "Gun"));
            gameCharacters.Add(new Wizard("Dee \"ZingingCutie23\" Reynolds", 2, 1, 4, 2));
            gameCharacters.Add(new Wizard("Dennis", 13, 99, 89, 9999));

            for (int i = 0; i < gameCharacters.Count; i++)
            {
                gameCharacters[i].Play();
            }
        }
    }
}
