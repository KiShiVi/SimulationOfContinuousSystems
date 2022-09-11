using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSH
{
    class SchemaDimension
    {
        public static List<String> resistorParameters   = new List<String> { "n+", "n-", "Сопротивление (КОм)" };
        public static List<String> capacitorParameters  = new List<String> { "n+", "n-", "Емкость(Ф)" };
        public static List<String> inductanceParameters = new List<String> { "n+", "n-", "Индуктивность(Гн)" };

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

        public static int[,] resistorsN             = new int[resistors, 2];
        public static float[] resistorsValue        = new float[resistors];
        public static int[,] capacitorsN            = new int[resistors, 2];
        public static float[] capacitorsValue       = new float[resistors];
        public static int[,] inductorN              = new int[resistors, 2];
        public static float[] inductorValue         = new float[resistors];

        public static void updateArrays()
        {
            resistorsN          = new int[resistors, 2];
            resistorsValue      = new float[resistors];
            capacitorsN         = new int[capacitors, 2];
            capacitorsValue     = new float[capacitors];
            inductorN           = new int[inductances, 2];
            inductorValue       = new float[inductances];
        }   
        public static void fillParametersFromFile(String file)
        {
            if (File.Exists(Directory.GetCurrentDirectory()     + '\\' + file + ".txt"))
                File.Delete(Directory.GetCurrentDirectory()     + '\\' + file + ".txt");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", countOfNodes    .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", resistors       .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", capacitors      .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", inductances     .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", ITUN            .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", INUN            .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", ITUT            .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", INUT            .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", BP_transistors  .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", UP_transistors  .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", oper_boosters   .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", transformers    .ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", id_oper_boosters.ToString() + "\n");
            File.AppendAllText(Directory.GetCurrentDirectory()  + '\\' + file + ".txt", id_transformers .ToString() + "\n");

            for(int value = 0; value < resistors; ++value)
                File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", resistorsN[value, 0].ToString() + " ");

            File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", "\n");

            for (int value = 0; value < resistors; ++value)
                File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", resistorsN[value, 1].ToString() + " ");

            File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", "\n");

            foreach (float value in resistorsValue)
                File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", value.ToString() + " ");

            File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", "\n");



            for (int value = 0; value < capacitors; ++value)
                File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", capacitorsN[value, 0].ToString() + " ");

            File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", "\n");

            for (int value = 0; value < capacitors; ++value)
                File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", capacitorsN[value, 1].ToString() + " ");

            File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", "\n");

            foreach (float value in capacitorsValue)
                File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", value.ToString() + " ");

            File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", "\n");



            for (int value = 0; value < inductances; ++value)
                File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", inductorN[value, 0].ToString() + " ");

            File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", "\n");

            for (int value = 0; value < inductances; ++value)
                File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", inductorN[value, 1].ToString() + " ");

            File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", "\n");

            foreach (float value in inductorValue)
                File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", value.ToString() + " ");

            File.AppendAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt", "\n");

            String[] aaaa = File.ReadAllText(Directory.GetCurrentDirectory() + '\\' + file + ".txt").Split('\n');
            //countOfNodes = Int32.Parse(aaaa[0]);
            float a = float.Parse(aaaa[14].Split(' ')[0]);
            MessageBox.Show(a.ToString());
        }
    }
}
