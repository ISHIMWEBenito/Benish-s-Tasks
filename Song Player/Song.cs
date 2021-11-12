using System;

namespace Task3b
{
    abstract class Song
    {
        string author, title;

        protected Song(string author, string title)
        {
            this.author = author;
            this.title = title;
        }

        virtual public void Play()
        {
            Console.WriteLine(author + " " + title);
        }
    }

    class Rock : Song
    {
        const string rockSound = "rockSound";
        public Rock(string author, string title) : base(author, title) { }
        override public void Play()
        {
            base.Play();
            Console.WriteLine(rockSound);
        }
    }

    class Pop : Song
    {
        const string popSound = "popSound";
        public Pop(string author, string title) : base(author, title) { }
        override public void Play()
        {
            base.Play();
            Console.WriteLine(popSound);
        }
    }

    class AlternativeRock : Rock
    {
        const string alternativeRockSound = "alternativeRockSound";
        public AlternativeRock(string author, string title) : base(author, title) { }
        override public void Play()
        {
            base.Play();
            Console.WriteLine(alternativeRockSound);
        }
    }

    class HeavyMetalRock : Rock
    {
        const string heavyMetalRockSound = "heavyMetalRockSound";
        public HeavyMetalRock(string author, string title) : base(author, title) { }
        override public void Play()
        {
            base.Play();
            Console.WriteLine(heavyMetalRockSound);
        }
    }

    class IndieAlternativeRock : AlternativeRock
    {
        const string indieAlternativeRockSound = "indieAlternativeRockSound";
        public IndieAlternativeRock(string author, string title) : base(author, title) { }
        override public void Play()
        {
            base.Play();
            Console.WriteLine(indieAlternativeRockSound);
        }
    }
}
