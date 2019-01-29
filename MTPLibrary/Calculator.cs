using System;
using System.Collections.Generic;
using System.Text;

namespace MTPLibrary
{
    public class Calculator
    {
        private int _x = 0;

        private int _sum = 0;

        private List<int> _list;

        private Boolean _abs = true;

        public Calculator(Boolean abs)
        {
            _abs = abs;
            _list = new List<int>();
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public string GetInput(int n)
        {
            if (_abs)
            {
                n = Math.Abs(n);
            }
            _x = n;

            _list.Add(n);

            string x = SumAll(_sum, _x).ToString();

            return x;
        }

        private int SumAll(int x, int y)
        {
            _sum = x +y;
            return _sum;
        }

        public string GetHistory()
        {
            string result = "";

            foreach (var item in _list)
            {
                result += item + "+";
            }

            return result;
        }
    }
}
