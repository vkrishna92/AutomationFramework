using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.SupportLibrary;

namespace AutomationFramework.TestData.TestDataClass
{
    class TestDataManager
    {
        public static string[][] getTestData(string fileName)
        {
            string[][] toArray = null;
            int col = 0;
            int row = 0;
            using (StreamReader sr = new StreamReader(ProjectPath.getProjectPath() + @"TestData\TestData\"+fileName))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] temp = str.Split(';').ToArray();
                    col = temp.Length;
                    row++;

                }
            }
            toArray = new string[row][];
            using (StreamReader sr = new StreamReader(ProjectPath.getProjectPath() + @"TestData\TestData\"+fileName))
            {

               
                for (int i = 0; i < row; i++)
                {
                    string[] temp = new string[col];
                    toArray[i] = new string[col];
                    temp=sr.ReadLine().Split(';').ToArray();
                    for (int j = 0; j < col; j++)
                    {
                        toArray[i][j] =  temp[j];
                    }
                }
            }

            return toArray;
        }
    }
}
