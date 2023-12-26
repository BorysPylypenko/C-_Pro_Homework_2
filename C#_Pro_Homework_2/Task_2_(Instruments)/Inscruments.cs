using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_2.Task_2__Instruments_
{
    public class Violin : MusicInstruments
    {
        public Violin(string name, string characteristics) : base(name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Playing Violin sound.....");
        }

        public override void History()
        {
            Console.WriteLine("Some history of Violin");
        }

    }

    public class Cello : MusicInstruments
    {
        public Cello (string name, string characteristics) : base (name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Playing Cello sound....");
        }

        public override void History()
        {
            Console.WriteLine("Some history of Cello");
        }
    }

    public class Ukulele : MusicInstruments
    {
        public Ukulele (string name, string characteristics) : base (name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Playing Ukulele sound....");
        }
        public override void History()
        {
            Console.WriteLine("Some history of Ukulele");
        }
    }

    public class Trombone : MusicInstruments
    {
        public Trombone(string name, string characteristics) : base(name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Playing Trombone sound....");
        }
        public override void History()
        {
            Console.WriteLine("Some history of Trombone");
        }
    }
}
