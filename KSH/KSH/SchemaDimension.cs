﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSH
{
    class SchemaDimension
    {
        public static int countOfNodes          = 0;
        public static int resistors             = 0;
        public static int capacitors            = 0;
        public static int inductances           = 0;
        public static int ITUN                  = 0;
        public static int INUN                  = 0;
        public static int ITUT                  = 0;
        public static int INUT                  = 0;
        public static int BP_transistors        = 0;
        public static int UP_transistors        = 0;
        public static int oper_boosters         = 0;
        public static int transformers          = 0;
        public static int id_oper_boosters      = 0;
        public static int id_transformers       = 0;

        public static int[,] resistorsN      = new int[resistors, 2];
        public static float[] resistorsValue = new float[resistors];
        public static void updateArrays()
        {
            resistorsN      = new int[resistors, 2];
            resistorsValue  = new float[resistors];
        }   
    }
}
