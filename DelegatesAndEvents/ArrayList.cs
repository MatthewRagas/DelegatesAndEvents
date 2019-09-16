using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    class ArrayList
    {
        private int[] _numList = new int[4];

        public ArrayList()
        {
            _numList[0] = 1;
            _numList[1] = 2;
            _numList[2] = 3;
            _numList[3] = 4;
        }

        public int[] Add(int[] array, int value)
        {
           _numList = new int[array.Length + 1];         

           for(int i = 0; i < array.Length; i++)
            {
                _numList[i] = array[i];
            }

            _numList[array.Length] = value;

            for(int i = 0; i < _numList.Length; i++)
            {
                Console.WriteLine(_numList[i]);
            }

            return _numList;
        }
    }
}
