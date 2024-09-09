using System;

namespace collectionsdemo
{
    internal class Students: IComparable<Students>
    {
        public int id { get; set; }
        public string name { get; set; }

        public int CompareTo(Students s)
        {
            return this.name.CompareTo(s.name);
        }

       
        public override string ToString()
      {
        return  $"Id : {id} , Name : {name}";
      }
      

        
    }

}