﻿using FakerDotNet.Fakers;

namespace FakerDotNet
{
    internal interface IFakerContainer
    {
        IAppFaker App { get; }
        IBeerFaker Beer { get; }
        IBookFaker Book { get; }
        IBooleanFaker Boolean { get; }
        IDateFaker Date { get; }
        IFakeFaker Fake { get; }
        INameFaker Name { get; }
        INumberFaker Number { get; }
        IRandomFaker Random { get; }
        ITimeFaker Time { get; }
    }

    internal class FakerContainer : IFakerContainer
    {
        public FakerContainer()
        {
            App = new AppFaker(this);
            Beer = new BeerFaker(this);
            Book = new BookFaker(this);
            Boolean = new BooleanFaker();
            Date = new DateFaker();
            Fake = new FakeFaker(this);
            Name = new NameFaker(this);
            Number = new NumberFaker();
            Random = new RandomFaker();
            Time = new TimeFaker();
        }

        public IAppFaker App { get; }
        public IBeerFaker Beer { get; }
        public IBookFaker Book { get; }
        public IBooleanFaker Boolean { get; }
        public IDateFaker Date { get; }
        public IFakeFaker Fake { get; }
        public INameFaker Name { get; }
        public INumberFaker Number { get; }
        public IRandomFaker Random { get; }
        public ITimeFaker Time { get; }
    }
}
