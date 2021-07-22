using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        //  private int id{ get; set; }
        //ctr r+e; 
        private int id;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        private string name;
    }
}
