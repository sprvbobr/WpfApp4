using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class ClassBook
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int strani  { get; set; }
        public int Money { get; set; }
        public string After { get; set; }
        public string genre { get; set; }
        public int Howmanychildrentheauthorate { get; set; }

        public ClassBook (string n,string t,int s,int m , string a ,string g,int h)
        {
            Name = n;
            Title = t;
            Money = s;
            After = a;
            genre = g;
            Howmanychildrentheauthorate = h;

                

        }
        public ClassBook()
        {

        }
        public override string ToString()
        {
            return $"названия {Name} Автор   {After} заголовок  {Title} {genre} {Money} {strani}";
        }



    }







    }

