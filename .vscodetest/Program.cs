using System;
namespace 类和对象
{
    #region
    //万物皆对象
    //用程序抽象对象
    //用此思想来编程
    #endregion

    #region 1.什么是类
    //具有相同特征
    //相同行为
    //一类事物的抽象
    //类是对象的模板
    //可以通过类创建出对象
    //类的关键词 class

    //封装的第一步
    #endregion

    #region 2.哪里申明
    //在namespace里面
    //class里面叫内部类
    #endregion

    #region 3.申明语法
    class 类名//可以加访问修饰符 public
    {
        //特征——成员变量
         //行为——成员方法
         //保护特征——成员属性

        //构造函数和析构函数
        //索引器
        //运算符重载
        //静态成员
    }
    #endregion

    #region 4.申明实例

    //帕斯卡命名法
    //同一个语句块中不同类不能重名
    class GeLeiNa
    {
        //特征——成员变量
        //行为——成员方法
        //保护特征——成员属性

        //构造函数和析构函数
        //索引器
        //运算符重载
        //静态成员
    }

    class QianNian
    {
        //特征——成员变量
        //行为——成员方法
        //保护特征——成员属性

        //构造函数和析构函数
        //索引器
        //运算符重载
        //静态成员
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {

            #region 什么是类（对象）
            //类的申明 和 类对象（变量）申明是两个概念
            //类的申明 类似 枚举 和 结构体的申明
            //类的申明相当于申明了一个自定义变量类型
            //而对象 是类创建出来的
            //
            //相当于 申明一个指定类型的变量
            //类创建对象的过程 一般称为实例化对象
            //类对象 都是引用类型的
            #endregion

            #region 实例化对象基本语法
            //类名 变量名;
            //类名 变量名 = null;(代表空)
            //类名 变量名 = new 类名（）;
            #endregion

            #region 实例
            GeLeiNa YiZhi;
            //引用类型 存在堆上 在栈上有空间 一个地址
            //地址为null 即无地址
            GeLeiNa YangNai = null;
            //形同上一句 无堆内存 

            GeLeiNa Qianxia = new GeLeiNa();//相当于一个格雷娜学生
            GeLeiNa G1 = new GeLeiNa(); 
            //有堆内存
            //虽然是来自同一个类的实例对象
            //但是信息各自独有
            //不会共享
            #endregion

        }
    }
}



//using System;
//namespace 类和对象
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}
//#region
//#endregion