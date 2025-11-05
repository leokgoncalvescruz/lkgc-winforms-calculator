using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exemplo.Classes
{
    internal class Operacoes
    {
        double x, y;
        public Operacoes()
        {
            x = 0; y = 0;
        }

        //Getters e Setters

        public void setXFromInput(double x)
        {
            this.x = x;
        }
        public double getX()
        {
            return this.x;
        }
        public void setYFromInput(double y)
        {
            this.y = y;
        }
        public double getY()
        {
            return this.y;
        }

        //Operações
        public double soma()
        {
            return this.x + this.y;
        }

        public double sub()
        {
            return this.x - this.y;
        }

        public double mult()
        {
            return this.x * this.y;
        }

        public double div()
        {
            if (this.y == 0)
            {
                return 0;
            }
            return this.x / this.y;
        }

        public double xaoq()
        {
            return this.x * this.x;
        }

        public double raizx()
        {
            return Math.Sqrt(this.x);
        }

        public double porcentagem()
        {
            return this.x / 100 * this.y;
        }

        public string binario(double n)
        {
            int x = (int)n;
            if (x==0)
                return "0";
            string result = "";

            while (x > 0)
            {
                int rest = x % 2;
                result = rest + result;
                x /= 2;
            }
            return result;
        }


        

        public double xelevy()
        {
           return Math.Pow(this.x, this.y);
        }

    }
}