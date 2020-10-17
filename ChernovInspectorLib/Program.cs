using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace ChernovInspectorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp.GetInspector();
            FunctionInsp.GetСarInspection();
            FunctionInsp.GetWorker();
            FunctionInsp.SetInspector();
            FunctionInsp.GetInspector();
            FunctionInsp.AddWorker();
            FunctionInsp.GetWorker();

            ///Вывод случайного госномера 
            Random rand = new Random();
            int a = rand.Next(9);
            int count = 0;

            Random randb = new Random();
            int b = rand.Next(9);
            int countb = 0;

            Random randc = new Random();
            int c = rand.Next(9);
            int countc = 0;

            Random rnd = new Random();
            char[] symbol = new char[12] { 'В', 'Е', 'К', 'М', 'Н', 'О', 'Р', 'С', 'Т', 'У', 'Х', 'А' };
            string x = (symbol[1]).ToString();

            Random rndy = new Random();
            char[] symboly = new char[12] { 'В', 'Е', 'К', 'М', 'Н', 'О', 'Р', 'С', 'Т', 'У', 'Х', 'А' };
            string y = (symbol[2]).ToString();

            Random rndz = new Random();
            char[] symbolz = new char[12] { 'В', 'Е', 'К', 'М', 'Н', 'О', 'Р', 'С', 'Т', 'У', 'Х', 'А' };
            string z = (symbol[10]).ToString();

            FunctionInsp.GenerateNumber(x,a,b,c,y,z,75);
            Console.ReadLine();

        }
    }
}