using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1//可以是中文 
{
    //命名空间  代码块//命名空间--工具包
    //面向对象相关内容 这里写//函数--工具

    internal class Program   
        //面向对象相关内容 这里写
        //类 代码块
    {
        static void Main(string[] args)
        {
            //函数代码块 所有的代码写在这里
            //在控制台打出你好世界
            Console.WriteLine("你好世界");
            //双引号以内内容可以是任何形式；
           
            Console.WriteLine("唐老狮");//自带'\n';
            //Console.Write("加油");
            //Write无换行，WriteLine换行；

            Console.ReadLine();
            //等待'\n'，空括号；
             Console.ReadKey();
            //一个字符
             Console.WriteLine("");
            //自带'\n';
          Console.Read();
            //读一个字符，返回ASCLL值；
             Console.Write("你好，我喜欢你");
        }
    }
}
