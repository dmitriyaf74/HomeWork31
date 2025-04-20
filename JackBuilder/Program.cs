using JackBuilder.Classes;

namespace JackBuilder
{
    internal class Program
    {
        static void ShowPoem(Part lp)
        {
            foreach (var str in lp.Poem)
            {
                Console.WriteLine(str);
            }
        }


        static void Main(string[] args)
        {
            var lp = new List<Part>
                (
                    [
                    new Part1([" ", "Вот дом,", "Который построил Джек."]),
                    new Part2(["А это пшеница,", "Которая в темном чулане хранится", "В доме,"]),
                    new Part3(["А это веселая птица-синица,", "Которая часто ворует пшеницу,"]),
                    new Part4(["Вот кот,", "Который пугает и ловит синицу,"]),
                    new Part5(["Вот пес без хвоста,", "Который за шиворот треплет кота,"]),
                    new Part6(["А это корова безрогая,", "Лягнувшая старого пса без хвоста,"]),
                    new Part7(["А это старушка, седая и строгая,", "Которая доит корову безрогую,", "Лягнувшую старого пса без хвоста,"]),
                    new Part8(["А это ленивый и толстый пастух,", "Который бранится с коровницей строгою,"]),
                    new Part9(["Вот два петуха,", "Которые будят того пастуха,"]),
                    ]
                );

            //Console.WriteLine(lp[1].AddPart(lp[0].Poem).Poem);
            for (int i = 1; i < lp.Count; i++)
            {
                lp[i].AddPart(lp[i - 1].Poem);
            }

            ShowPoem(lp[lp.Count - 1]);
            //Проверка:
            /*for (int i = 1; i < lp.Count; i++) 
            {
                ShowPoem(lp[i]);
                Console.WriteLine("----------------------------------------");
            }*/

        }
    }
}
