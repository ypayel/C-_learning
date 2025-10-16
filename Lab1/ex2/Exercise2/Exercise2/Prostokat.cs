using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Prostokat : IComparable
    {
        private int width;
        private int height;
        private int area;

        public Prostokat(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.area = this.height * this.width;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Prostokat otherProstokat = obj as Prostokat;
            if (otherProstokat != null)
                return this.area.CompareTo(otherProstokat.area);
            else
                throw new ArgumentException("Object is not a Prostokat");
        }

            public override string ToString()
        {
            return "Prostokat: " + width + "*" + height;
        }

    }

        
    }

