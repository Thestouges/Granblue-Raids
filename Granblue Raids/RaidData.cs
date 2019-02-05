using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granblue_Raids
{
    class RaidData
    {
        int id;
        string name;
        string jname;
        byte[] image;

        public RaidData(int id, string n, string j, byte[] i)
        {
            this.id = id;
            this.name = n;
            this.jname = j;
            this.image = i;
        }

        public string Name { get => name; set => name = value; }
        public string Jname { get => jname; set => jname = value; }
        public byte[] Image { get => image; set => image = value; }
        public int ID { get => id; set => id = value; }
    }
}