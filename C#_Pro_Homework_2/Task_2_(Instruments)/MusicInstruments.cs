using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_2.Task_2__Instruments_
{
    public class MusicInstruments
    {
        public string Name {  get; set; }
        public string Characteristics { get; set; }

        public MusicInstruments(string name, string characteristics) 
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Playing some sound.....");
        } 

        public void Show()
        {
            Console.WriteLine($"Musical Instrument: {Name}");
        }

        public void Desk()
        {
            Console.WriteLine($"Characteristics: {Characteristics}");
        }

        public virtual void History()
        {
            Console.WriteLine("Some history of instrument... ");
        }
    }
}
