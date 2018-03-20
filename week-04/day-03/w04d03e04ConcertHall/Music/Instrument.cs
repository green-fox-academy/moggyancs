using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    abstract class Instrument
    {
        protected string name;
        abstract public void Play();
    }
}
