using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    abstract class StringedInstrument : Instrument
    {
        private int numberOfStrings;
        abstract public string Sound();

        public void Instrument()
        {

        }

        public override void Play()
        {
            Console.WriteLine();
        }


    }
}
