using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;

namespace Task_1
{
    class Program
    { 
        static int m,n;
        static int[] fr;
        static int[] to;
        static bool[] used;
        static void dfs(int v) { // поиск в глубину, закрашиваем вершину графа , в который зашли (deep first search)
            if (used[v]) return;
            used[v] = true;
            for (int i = 0; i < m; i++) if(fr[i] == v || to[i] == v){    
                if(to[i] != v) dfs(to[i]);
                if(fr[i] != v) dfs(fr[i]);
            }
        }

        static void Main(string[] args)
        {
            string[]  bufer;
            bufer = Console.ReadLine().Split(' '); // всё , что идёт до пробела в строке отправляется в массив
            n = int.Parse(bufer[0]);
            m = int.Parse(bufer[1]);
            fr = new int[m]; // массив первых реактивов в связи ( их номера)
            to = new int[m]; // массив вторых реактивов в связи ( их номера)
            for (int i = 0; i < m; i++) {
                bufer = Console.ReadLine().Split(' ');
                fr[i] = int.Parse(bufer[0]);
                to[i] = int.Parse(bufer[1]);
            }
            used = new bool[n + 1]; // массив посещенных вершин графа
            int cnt = 0; // количество компонент графа
            for(int i = 1; i <= n; i++) if (!used[i]) { // обходим граф
                cnt++;
                dfs(i);
            }

            long ans = 1; // изначальная опасность колбы
            for (int i = 1; i <= n - cnt; i++)
            { 
                ans *= 2;
            }
            Console.Write(ans);
            
        }
    }
}