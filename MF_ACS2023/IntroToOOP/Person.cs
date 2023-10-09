using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    //A class represents a real-life entity and consists of attributes (data) and methods (actions/behaviour)
    public class Person
    {
        //Attributes refer to data - should always be private!
        private string name;
        private string surname;
        private DateTime dateOfBirth;
        private float height;
        private float weight;

        //Methods refer to actions to be performed by an object.
        public string Speak(string speech) 
        {
            return speech;
        }
    }
}
