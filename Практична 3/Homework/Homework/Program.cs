using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicCard card1 = new FirstEletronicCard();
            card1 = new BankCard(card1); // 
            Console.WriteLine("Name: {0} ", card1.Name);
            Console.WriteLine("Code: {0} ", card1.GetInfoAboutCard());

            ElectronicCard card2 = new FirstEletronicCard();
            card2 = new StrahPolis(card2);// 
            Console.WriteLine("Name: {0} ", card2.Name);
            Console.WriteLine("Code: {0} ", card2.GetInfoAboutCard());

            ElectronicCard card3 = new SecondElectronicCard();
            card3 = new BankCard(card3);
            card3 = new StrahPolis(card3);// 
            Console.WriteLine("Name: {0} ", card3.Name);
            Console.WriteLine("Code: {0} ", card3.GetInfoAboutCard());

            Console.ReadLine();
        }
    }


    abstract class ElectronicCard
    {
        public ElectronicCard(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetInfoAboutCard();
    }

    class FirstEletronicCard : ElectronicCard
    {
        public FirstEletronicCard() : base("First Type of Electronic Card: ")
        { }
        public override int GetInfoAboutCard()
        {
            return 10012;
        }
    }
    class SecondElectronicCard : ElectronicCard
    {
        public SecondElectronicCard() : base("Second Type of Electronic Card: ")
        { }
        public override int GetInfoAboutCard()
        {
            return 10013;
        }
    }



    abstract class CardDecorator : ElectronicCard
    {
        protected ElectronicCard electronicCard;
        public CardDecorator(string n, ElectronicCard electronicCard) : base(n)
        {
            this.electronicCard = electronicCard;
        }
    }

    class BankCard : CardDecorator
    {
        public BankCard(ElectronicCard p)
            : base(p.Name + " з банківською карткою", p)
        { }

        public override int GetInfoAboutCard()
        {
            return electronicCard.GetInfoAboutCard() + 3345;
        }
    }

    class StrahPolis : CardDecorator
    {
        public StrahPolis(ElectronicCard p)
            : base(p.Name + " з страховим полісом", p)
        { }

        public override int GetInfoAboutCard()
        {
            return electronicCard.GetInfoAboutCard() + 4567;
        }
    }
}
