using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        
            private int year;
            public int Year
            {
                get { return year; }
                set { year = value; }
            }

            private string make;
            public string Make
            {
                get { return make; }
                set { make = value; }
            }

            private string model;
            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            private string engineNoise;
            public string EngineNoise
            {
                get { return engineNoise; }
                set { engineNoise = value; }
            }

            private string honkNoise;
            public string HonkNoise
            {
                get { return honkNoise; }
                set { honkNoise = value; }
            }

            private bool isDriveable;
            public bool IsDriveable
            {
                get { return isDriveable; }
                set { isDriveable = value;}
            }
            
            public void MakeEngineNoise ()
                {
                    Console.WriteLine($"\nEngine - {EngineNoise}");  
                }
            
            public void MakeHonkNoise ()
                {
                    Console.WriteLine($"\nHorn - {honkNoise}"); 
                }

        }
    }

    //TODO

    //Create a seperate class file called Car
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property

