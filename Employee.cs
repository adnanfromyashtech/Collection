using System;

namespace collectionsdemo
{
    internal class Employee 
    {
        public int id { get; set; }
        public string name { get; set; }


       
        public override string ToString()
      {
        return  $"Employee Id : {id} , Name : {name}";
      }
      
    }

}