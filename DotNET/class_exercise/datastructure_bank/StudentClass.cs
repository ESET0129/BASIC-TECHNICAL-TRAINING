using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructure_bank
{
    
        public class Student_list
        {
            
            public string Name { get; set; }
            public int ID { get; set; }
            public double Percent { get; set; }

            // Constructor
            public Student_list(string name, int id, int percent)
            {
                Name = name;
                ID = id;
                Percent = percent;
            }
        }

    
}
