using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatClassWork0417.Moduls
{
    internal class Book
    {
		private string _name;
		string _author;
		static int Count = 0;
		public int _id;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}
        public int Id { get; set; }

        public Book(string name,string author)
        {
            Name=name;
			Author=author;
			Count++;
			Id=Count;
        }

    }
}
