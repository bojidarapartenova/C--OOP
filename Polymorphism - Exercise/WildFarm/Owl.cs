using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight,  wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override bool IsEating(string food)
        {
            if(food=="Meat") return true;
            else return false;
        }

        public override string ToString()
        {
            StringBuilder result=new StringBuilder();
            result.Append(GetType().Name);
            result.Append(base.ToString());
            return result.ToString();
        }
    }
}
