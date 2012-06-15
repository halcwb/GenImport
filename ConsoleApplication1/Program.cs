using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.DomainModel.GStandard.Interfaces;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<INaam> lijst = new List<INaam>();
            Console.WriteLine("press key");
            Console.ReadKey();
            for(int i = 0; i < 100000; i++)
            {
                INaam naam = new Naam{ 
                    MutKod =  MutKod.NoChanges, 
                   NmEtiket  = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" ,
                    NmNaam = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                    NmNm40 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                    NmNr = i
                };
                lijst.Add( naam );
            }
            Console.WriteLine("done!");
            Console.ReadKey();
        }
    }
}
