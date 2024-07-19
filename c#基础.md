# 复杂数据类型
![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354386496-1fb6174f-6018-426d-bff4-89fcc5d49f5d.png#averageHue=%23f0f0f0&from=url&id=nUpdj&originHeight=549&originWidth=570&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354386613-844eeb76-05f6-430b-b8aa-c5329606dedb.png#averageHue=%23f0f0f0&from=url&id=zfFgn&originHeight=445&originWidth=925&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354386687-b0a02dce-c8df-47c0-8911-a66cce37d1fd.png#averageHue=%23e5e5e5&from=url&id=JYdXo&originHeight=381&originWidth=1042&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)
## 枚举
### 1.基础概念
 **枚举是什么？**
>  一个被命名的整型常量集合
> 表示 状态 类型 等等


**申明枚举** 与 **申明枚举变量**完全不一样
**申明枚举 **：创建一个自定义的枚举类型
**申明枚举变量**：使用声明的枚举类型 创建一个枚举变量
### 2.在哪里声明
要放在**命名空间**里面——即**namespace **
**class struct **也可以
**不能放在函数语句中申明**
#### 例如：
```csharp
using System;
namespace lesson_1 
{
    enum E_自定义枚举类型
    {
        自定义枚举项名字,//枚举中 包裹的的 整形常量 第一个默认值0 下面累加
        自定义枚举项名字1,//1
        自定义枚举项名字2,//2
        自定义枚举项名字3 = 100,//100
        自定义枚举项名字4,//101     总是累加
    }

    enum E_MonsterType
    {
        Normal,
        boss,
    }
    enum E_PlayerType
    {
        main,//0
        other,//1
    }
}
```
### 3.使用
```csharp
E_PlayerType playerType = E_PlayerType.main;

//接近  int i =1；
//相当于后面的1是   int 1
```
申明枚举类型
自定义的枚举类型** 变量名 = 默认值；**（自定义的枚举类型.枚举项）
枚举和switch一起使用
#### 例如
```csharp
if(playerType == E_PlayerType.main)
{
    Console.WriteLine("playType");
}

//枚举和switch一起使用
E_MonsterType monsterType = E_MonsterType.boss;

switch(monsterType)
{
    case E_MonsterType.Normal:
        Console.WriteLine("Normal monster");
        break;
    case E_MonsterType.boss:
        Console.WriteLine("Boss monster");
        break;
}
```
### 4.类型转换
#### int互相转化
##### 例如
```csharp
int i =(int)monsterType;
Console.WriteLine(i);
//即输出枚举项序号

//int转枚举
playerType = 0;
```

#### 枚举和string相互转换
##### 例如
```csharp
string str =playerType.ToString();
Console.WriteLine(str);//打印出来是枚举项名字

//strint转枚举
playerType = (E_PlayerType)Enum.Parse(typeof(E_PlayerType),"main");
//Parse后的第一个参数 是我要转为哪个 枚举类型 第二个参数 是用于转换对应枚举项的字符串
//最后要加一个(目标类型)，因为转换之后是一个通用的类型
```
### 5.总结
枚举是面向对象的后台功能
使我们阅读过程更清晰
### 6.练习题
```csharp
using System;
namespace Progrom
{
    class lesson_text
    { 
    
        #region 
        enum QQtype
        {
            Online,
            leave,
        }
        static void Main(string[] args)
        {
            //QQtype type = QQtype.Online;
            int i = 1;//  1 自带 int 类型

            Console.WriteLine("请输入qq状态，0 Online 1 leave");
            try
            {
                int type = int.Parse(Console.ReadLine());
                QQtype qqtype = (QQtype)type;
                Console.WriteLine(qqtype);
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }

        }
        #endregion



        #region 
        enum caffee_type
        {
            L,
            M,
            S,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你要的 大杯0，中杯1，小杯2");
            int cafe=int.Parse(Console.ReadLine());
            caffee_type caffee_Type = (caffee_type)cafe;
            switch (caffee_Type)
            {
                case caffee_type.L:
                    Console.WriteLine("你的咖啡 L");
                    break; 
                case caffee_type.M:
                    Console.WriteLine("你的咖啡 M");
                    break;
                case caffee_type.S:
                    Console.WriteLine("你的咖啡 S");
                    break;
            }
        }
        #endregion
    }
}

```
## 三杠注释：可以使变量有注释提醒
![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354387204-464b35f8-3b1e-46fb-b71f-f4f6e3ff9b53.png#averageHue=%23384132&from=url&id=pcHVD&originHeight=79&originWidth=177&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354387271-13c5553b-2cfa-46fc-8c36-62241584bf85.png#averageHue=%23455d60&from=url&id=uXvaV&originHeight=63&originWidth=211&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354387337-6fb45270-83c2-4876-a20d-ba0a8f0f0f89.png#averageHue=%23282726&from=url&id=yZtGH&originHeight=375&originWidth=744&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)

## 数组
### &数组搬家&
数组搬家主要是改变数组**内部大小**
数组名为地址，就是说搬家是换了一个不同的地址指向一个大小不同的同一个空间
![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354387424-e63999b7-5dc4-47c7-adbc-74b2620b636c.png#averageHue=%233f3e38&from=url&id=cwUfo&originHeight=264&originWidth=396&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354387501-865f4b3f-0755-46b1-ac70-eaff9d672f25.png#averageHue=%233c3f35&from=url&id=oFCMu&originHeight=235&originWidth=381&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)
~~//函数搬家是指之前函数指向了新的数组地址，之前那个地址的数据变成垃圾了，系统会回收~~
![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354387567-c2f075e7-4b28-49a7-834a-4994457214b4.png#averageHue=%23272726&from=url&id=danhZ&originHeight=295&originWidth=496&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)
### 一维数组
#### 1.基本概念

- 存储一组**相同类型的集合**
- 一维 多维 交错
- 一般情况 数组就是一维数组
#### 2.申明
 变量类型[] 数组名;——只是申明了一个数组 没有开辟 空间

-  变量类型 可以是学过的 或者没学过的所有变量类型
```csharp
//变量类型[] 数组名 = new 变量类型[数组长度];
int[] arr2 = new int[5];  //开辟了空间 相当于5个数据类型 值默认为0 

//变量类型[] 数组名 = new 变量类型[数组长度]{内容1，内容2,.......};
int[] arr3 = new int[5] { 1,2,3,4,5};//长度和内容数量要一致

//变量类型[] 数组名 = new 变量类型[]{};
int[] arr4 = new int[] { 1, 2, 3, 4, 5 };

//变量类型[] 数组名 = {内容1，内容2,.......};
int[] arr5 ={ 1, 2, 3, 4, 5 };
//默认是int类型
//长度由数组决定

bool[] arr6 = { true, false };
```
#### 3.使用
##### 1.数组的长度
```csharp
int[] arr = new int[] {1 ,2 ,3 ,4 ,5 }; 
Console.WriteLine(arr7.Length);
```
##### 2.获取数组的元素
```csharp
//通过下标获取值
//不能越界
Console.WriteLine(arr7[0]);
```
##### 3.修改数组的元素
```csharp
 arr7[0] = 9;
```
##### 4.遍历数组 循环
```csharp
Console.WriteLine("*************************");
for (int i = 0; i < arr7.Length; i++)
{
    Console.WriteLine(arr7[i]); 
}
```
##### 5.增删除数组的元素——数组初始化以后不能直接增加减少数组长度
```csharp
Console.WriteLine("*************************");
//搬家
int[] arr72 = new int[6];
for (int i = 0;i < arr7.Length; i++)
{
    arr72[i] = arr7[i]; 
}
arr7 = arr72;//原有的数组指向新的数组
for (int i = 0; i < arr7.Length; i++)
{
    Console.WriteLine(arr7[i]);
}
            
```
##### 7.查找数组的元素
```csharp
for (int i = 0;i<arr7.Length ; i++)
{
    if (arr7[i] == 3)
    {
        Console.WriteLine("查找的元素在{0}号",i); 
    }
}
```

### **二维数组**
#### 1.基本概念
可以理解为两个下标（索引）
行  列
矩阵
int[2,3];
#### 2.声明的多种方式
```csharp
//变量类型[ , ]二维数组变量名；
int[,] arr;//申明后在后面初始化

//变量类型[ , ]二维数组变量名 = new 变量行[行,列]；
int[,] arr2 = new int[3,3];

//变量类型[ , ]二维数组变量名 = new 变量行[行,列]{ {} , {} }；
int[,] arr3 = new int[3, 3] { { 1, 2, 3 },
                              { 4, 5, 6 },
                              { 7, 8, 9 } };

//变量类型[ , ]二维数组变量名 = new 变量行[,]{ {you} , {you} }；
int[,] arr4 = new int[, ] { { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 } };

//变量类型[ , ]二维数组变量名 = new 变量行[,]{ {you} , {you} }；
int[,] arr5 = { { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 } };
```
#### 3.使用
##### 1.数组的长度
```csharp
int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
//我们要获取 行列分别是多少
//行
Console.WriteLine(array.GetLength(0));
//列
Console.WriteLine(array.GetLength(1));
```
##### 2.获取数组的元素
注意**别越界 **
第一个元素索引是**0 **最后一个是**length-1 **
##### 3.修改数组的元素
直接改就对啦
```csharp
array[1, 1] = 99;
Console.WriteLine(array[1, 1]);
```
##### 4.遍历数组 循环
```csharp
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        //i 行 0 1 
        //j 列 0 1 2  
        Console.Write(array[i, j]+"  ");
    }
    Console.WriteLine();
}
```
##### 5.增、删数组
```csharp
int[,] array2 = new int[3, 3];
for (int i = 0;i < array2.GetLength(0); i++)
{
    for(int j = 0;j < array2.GetLength(1); j++)
    {
        array2[i, j] = array[i, j];
    }
}
array = array2;
array2[2, 0] = 55;
array2[2, 1] = 44;
array2[2, 2] = 60;
```
### 交错数组（选修）
#### 1.基础概念
交错数组是数组的数组，每个维度的数量可以不同（也就是每行列数可以不同）
注意**不要越界访问**
例如：虽然打印出有两行三列，但如果第一行没有第三列，就不可以越界访问
#### 2.声明的方法
```csharp
//变量类型[][] 交错数组名；
int[][] arr1;

//变量类型[][] 交错数组名 = new 变量类型[行][不可填]；
int[][] arr2 = new int [3][];

//变量类型[][] 交错数组名 = new 变量类型[行][不可填]{一维数组1，一维数组2......}；
int[][] arr3 = new int[3][] { new int[] { 1,3},
                              new int[] { 1},
                              new int[] { 1,2,3}}; 


//变量类型[][] 交错数组名 = new 变量类型[行][不可填]{一维数组1，一维数组2......}；
int[][] arr4 = new int[][] { new int[] { 1,3},
                             new int[] { 1},
                             new int[] { 1,2,3}}; 


//变量类型[][] 交错数组名 = new 变量类型[行][不可填]{一维数组1，一维数组2......}；
int[][] arr5 = { new int[] { 1,3},
                 new int[] { 1},
                 new int[] { 1,2,3}};
```
#### 3.使用
##### 1.数组的长度
```csharp
int[][] array = { new int[]{ 1,2,3,4,5},
                  new int[]{ 2,9,11,33} };

Console.WriteLine(array.GetLength(0));
//或者
Console.WriteLine(array[0].Length);//获得某一行的长度
```
##### 2.获取数组元素和修改元素
```csharp
Console.WriteLine(array[1][2]);

 array[1][2] = 99;
```
##### 3.遍历数组 循环
```csharp
 for (int i = 0; i < array.GetLength(0); i++) 
  {
      for (int j = 0; j < array[i].Length; j++)
      {
          Console.Write(array[i][j] + "      ");
          Console.Write(array[i] + "  ");//数组类型
      }
      Console.WriteLine();
  }
```
# 值类型和引用类型
变量类型的复习
```csharp
//无符号整形
byte b = 1;
ushort us = 1;
uint ui = 1;
ulong ul = 1;

//有符号整形
sbyte sb = 1;
short s = 1;
int i = 1;
long l = 1;

//浮点数
float f = 1;
double d = 1;
decimal c = 1;

//特殊类型
bool boo = false;
string str = "1";
char ch = 'a';

//复炸数据类型
//enum
//数组
```
**引用类型**：string,数组，类
**值类型**：其他，结构体
## 使用和储存的区别
### 值类型
```csharp
int a = 10;
int[] arr = new int[] { 1, 2, 3, 4 };

int b = a;
int[] arr2 = arr;//申明了b=a  arr2 = arr

Console.WriteLine("a={0},b={1}", a, b);
Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);
Console.WriteLine("***********");
b = 20;
arr2[0] = 5;
Console.WriteLine("a={0},b={1}", a, b);
Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);
```

- **值类型      **在相互赋值是 把内容拷贝给对方 它变我不变
- **引用类型**   是指向同一个值 一起变

- **值类型** 栈空间 自动回收 小 快
- **引用类型** 堆空间 手动 大 慢

**注意！！！！**
> **数组名为地址**，改变是地址里面的值

![](c2.notes_files/微信图片_20240105114707.png#from=url&id=NuzyY&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)
![](c2.notes_files/微信图片_20240105115344.png#from=url&id=FShet&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)
### 特殊引用类型——string
字符串本质是地址，&str是取字符串的地址，就是地址的地址，取*是找地址对应的内容
string 在赋值时相当于新开一块——会产生 内存垃圾
> ![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354388805-214f2454-ffbe-4ac8-be92-de5a5e5ff0b3.png#averageHue=%233a4835&from=url&id=QpwH2&originHeight=191&originWidth=423&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)
> 结果str1还是123，str2是321

#### 示意图
![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354388922-2ada855e-dfda-4723-ad0e-ecbdf45a03e5.png#averageHue=%23e4e3e3&from=url&id=ApdwC&originHeight=517&originWidth=529&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)
这个方法让string非常方便 但是有一个小缺点 就是非常频繁的改变string重新赋值就会产生**内存垃圾**
![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354388988-6c53c461-5f0f-4e6b-82dd-3c3b0d198473.png#averageHue=%233a4834&from=url&id=GqP3l&originHeight=73&originWidth=515&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)

# 函数
## 1.基础概念
有名称的代码块
**封装**代码进行重复使用的一种机制
## 2.写在哪里
**class**语句 和 **struct**语句（结构体）
## 3.语法
```csharp
// 1        2         3
static   返回类型   函数名（参数类型 参数名1，参数类型 参数名2，.......）
{
    函数逻辑；
    ......
    return 返回值；（有返回类型才返回）
}
```

- static 其实非必须，但是学习 类 和 结构体 之前必须写
- 返回类型 可以说任意的类型（14种变量类型 + 复杂数据类型）  
- 关键字 void(没有返回值)
- 函数命名 帕斯卡命名法（首字母大写）
- 参数不是必须的 参数可以有多个 参数类型也可以任意 参数名驼峰命名法
- 返回值不是void 必须 return，同时 void 可以 return   (return 可以打断函数逻辑)

### 1.无参无返回值函数
```csharp
static void WuCanWuFan()
{
    Console.WriteLine("live boom the way ");
    return;//没有意义 可以省略
}
```
### 2.有参无返回值函数
```csharp
static void YouCanWuFan(string name)
{
    Console.WriteLine("说点什么吧—— {0}",name);
    return;//没有意义 可以省略
}

```
### 3.无参有返回值函数
```csharp
static string WuCanYouFan()
{
    return " 好吧，输出点什么给你看看  ";
}
```
### 4.有参有返回值函数
```csharp
static int Sum( int a,int b)
{
    return a + b; 
    //可以接表达式 只要有结果
}
```
### 5.有参有多返回值函数
```csharp
static int[] SumAvge(int a, int b)
{
    int sum = a+ b;
    int avge = sum / 2;
    //int[] arr ={ sum,avge}
    return new int[] { sum,avge} ;
    //如何返回
}
```
### 例如
```csharp
using System;
namespace lesson_6
{
    class Progrom
    {
        //1
        static int BiJiao(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        //2
        static float[] YuanMianJi(int a)
        {
            float V, S;
            V = 2 * a * 3.14f;
            S = a * a * 3.14f;
            return new float[] { V,S};
        }
        static void Main(string[] args)
        {
            int a = 10; int b = 50;
            a = BiJiao(a, b);

            float[] arr = YuanMianJi(a);
            Console.WriteLine("圆的面积为{0}，圆的周长为{1}",arr[0], arr[1]);
             
         
            //有返回值的函数 要么直接拿返回值用
            //要么拿变量 接受它的结果
            //Main是主函数的入口
        }
    }
}
```

## ref和out
### 1.使用ref和out原因
 可以解决 在函数内部改变外部传入的内容 里面变了 外面也会变
> ![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354389982-19e41a37-11bf-409d-8dbe-7dc27d10fa8f.png#averageHue=%23f0eee8&from=url&id=UbY4d&originHeight=141&originWidth=1013&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)

### 2.ref和out使用
参数的修饰符
当传入的值类型在内部修改时 或者引用类型参数在内部重新申明时
外部的值也发生变化
**ref将值类型转化为引用类型**
**加ref后即使函数void也会改变变量的值**
```csharp
static void ChangeValueRef(ref int value)
{
    value = 5;
}//ref

static void ChangeArrayRef(ref int[] arr)
{
    arr = new int[] { 111, 222, 333, 44 };
}

```
```csharp
static void ChangeValueOut(out int value)
{
    value = 545;
}


static void ChangeArrayOut(out int[] arr)
{
    arr = new int[] { 56, 87, 32 };
}

```
#### ref和out的区别

-  ref传入的变量必须初始化
-  out传入的变量必须在内部赋值

> 即新new了一个数组也会改变之前的值
> 本质应该是把变量在栈中地址直接传进去了。没用ref的话这一步被函数的形参给阻止了
> out语法和效果和ref一样


ref传入的变量必须初始化 但是在内部 可改可不改
out传入的变量不用初始化 但是在内部 必须修改该值(必须赋值)
![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354390403-b48a5535-cb63-4857-9e1f-945e50973d6a.png#averageHue=%23f1f0ec&from=url&id=YJxVF&originHeight=148&originWidth=1035&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354390469-c41f7726-c02b-4a81-b415-35419bebad7a.png#averageHue=%23f0eee9&from=url&id=Msgi7&originHeight=111&originWidth=830&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)
## 变长参数和参数默认值
### 关键字：params
```csharp
 static int Sum(params int[] arr)
 {
     int sum = 0;
     for (int i = 0;i<arr.Length ;i++)
     {
         sum += arr[i];
     }
     return sum;
 }
```
params int[] 意味着可以传入 n 个 int 参数
n可以等于0 传入的参数会存在arr数组里

注意 

1. params 后面必须为数组
2. 数组类型随意  
3. 函数参数可以有 别的参数 和 params 关键字修饰的参数
4. 函数参数中只能最多出现一个params关键字，
5. params关键字一定在最后一组参数  前面可以有n个其他参数
```csharp
 static void youli(string name,params string[] grils)
 {

 }//变长参数在最后即可
```
这里就可以传无限个数了，类似于动态数组
params最多出现一次并且在最后一组参数
### 参数默认值（即可选参数）
```csharp
static void Speak(string str = "nope")
{
    Console.WriteLine(str);
}
```

- 有参数默认值的参数 一般称为可选参数
- 当调用函数时可以不传入参数 不传会使用

注意：
支持多选参数默认值 每个参数都可以有默认值
如果混用可选参数 必须写在普通参数后面

### 总结
**params**

- 传n个参数
- 后面必须是数组 也就是类型统一
- 变长参数只能有一个 在最后

**参数默认值**

- 可以不传参数 传了用传入的 没有用
- 可选参数可以多个 也都在后面
### 例如
```csharp
using System;
namespace lesson_5使用和存储上的区别
{
    class Progrom
    {
        //1.求和和平均值
        //2.偶数和奇数和

        static int[] SumAvge(params int[]arr)
        {
            int Sum = 0, Avg = 0;
            for (int i = 0;i<arr.Length; i++)
            {
                Sum += arr[i];
            }
            Avg=Sum/arr.Length;
            return new int[] { Sum, Avg};
        }
        
        static int[] Sum12(params int[]arr)
        {
            int Sum1 = 0,Sum2 = 0;
            for (int i = 0; i < arr.Length - 1; i+=2)
            {
                Sum1 += arr[i];
                Sum2 += arr[i + 1];
            }
            return new int[] { Sum1, Sum2};
        }

        
        static void Main(string[] args)
        {
            SumAvge( 1, 2, 3, 4, 5, 6, 7 );
        }
    }
}
```
## 函数重载
### 基本概念
在同一语句块（**class struct**）
函数（方法）名相同 或者 参数的数量相同，但参数的类型或者顺序不同

命名一组功能相似的函数，减少函数名的使用，避免命名空间污染（？）
提升程序可读性
### 实列
重载和返回值无关 只和**参数类型，个数顺序**有关
调用时 程序会根据自己传入的参数类型判断使用哪一个重载

这是F12向上追寻WriteLine查到的重载结果
![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354391729-985627c9-09c7-4165-b7ed-9186e2d5bfbc.png#averageHue=%2345463b&from=url&id=vO6YZ&originHeight=509&originWidth=758&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)
#### 这是一个示例函数
> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721371347896-88f24741-c710-4385-ae77-0b270de0f986.png#averageHue=%231f1e1e&clientId=u8af37db3-353f-4&from=paste&height=94&id=u73b906e0&originHeight=141&originWidth=444&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=12977&status=done&style=none&taskId=ue4816a0d-ff75-4da8-8d9b-3158b90266f&title=&width=296)

##### 1.参数数量不同
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721371366303-0ace9de4-e831-43bf-a2dd-dff808632b35.png#averageHue=%231e1e1e&clientId=u8af37db3-353f-4&from=paste&height=112&id=u08efe327&originHeight=168&originWidth=750&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=25060&status=done&style=none&taskId=u73d0ab9e-436b-4f40-8cce-e8f00523f7b&title=&width=500)
##### 2.数量相同 类型不同
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721371425967-b92e2e63-b3d9-445a-a477-ae892fccf388.png#averageHue=%2320201f&clientId=u8af37db3-353f-4&from=paste&height=115&id=u97892047&originHeight=172&originWidth=515&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=18877&status=done&style=none&taskId=u3ed03f16-a0a9-48b8-8537-891cf81aa04&title=&width=343.3333333333333)
##### 3.数量相同 类型不同
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721371501912-b38b8af9-a3cc-474e-a138-7db0cb8641c2.png#averageHue=%231f1f1f&clientId=u8af37db3-353f-4&from=paste&height=107&id=ud275874e&originHeight=161&originWidth=430&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=16042&status=done&style=none&taskId=uf33e4cac-32fb-4d4e-a4a6-89417d90972&title=&width=286.6666666666667)
##### 4.数量相同 顺序不同
![](https://cdn.nlark.com/yuque/0/2024/png/42440971/1721354392094-4d80101b-c535-4348-b294-b2faf14d87ce.png#averageHue=%233b3a34&from=url&id=mbprQ&originHeight=159&originWidth=330&originalType=binary&ratio=1&rotation=0&showTitle=false&status=done&style=none&title=)
##### 5.ref 和 out
```csharp
 static float Calcsum(ref float a,out int b)//个人理解只要传入类型（对象）改变即可
 {
     b = 0;
     return a + b;
 }

 static float Calcsum(int a, int b,params int[] arr)//个人理解只要传入类型（对象）改变即可
 {
     b = 0;
     return a + b;
 }
```
ref和out 可以理解成 他们也是一种变量类型 所以可以用在重我中 但是 ref和out不能同时修饰
##### 6.变长参数params
```csharp
static float CalcSum(int a, int b, params int [] arr)
{
    return 1;
}
```
### 总结
> 同一个语句块中，函数名相同，参数数量、类型、顺序不同的函数 就称为我们的重载函数
> 注意:和返回值无关
> 作用:一般用来处理不同参数的同一类型的逻辑处理

## 递归函数
### 1.基本概念
就是自己调用自己
```csharp
static void Fun()
{
    int i = 0;
    if(i == 0)
        return;
    Fun();
}
```
一个正确的递归函数必须**有结束调用的条件,**条件必须可以达到

### 2.实例
```csharp
static void main(int a)
{
    Console.WriteLine(a);
    a++;
    if(a == 10)
        return ;
    main(a);
}   
```
# 结构体
> 即一种自定义类型 类似枚举要自己定义
> 类似数据和函数的集合


在结构体里 可以申明各种变量和方法
用来表现存在的数据集合 比如用结构体表现学生 动物 人类

### 访问修饰符
修饰结构体中的变量和方法
**public **公共的 可以被外部访问的
**private** 私有的 只能在内部使用的
不写默认 private

构造函数 没有返回值 函数名和结构体名相同 可以重载 快速初始化对象
不能直接初始化 只能在外部或者函数中赋值
**结构体中的函数不要static**
## 基本语法
直接写在 namespace
关键字 struct
```csharp
struct str
{
    第一部分 
    变量

    第二部分
    构造函数（可选）

    第三部分（一般都写）
    函数

    //帕斯卡命名法
}
```
## 实例展示
```csharp
struct Student //结构体最好不要中文命名
{
    //变量
    //不能直接初始化
    //变量类型里 可以写任意结构体 但是不能包括自己
    //Student s(错误)
    //年龄 学号 姓名
    public int age;
    public bool sex;
    public int number;
    public string name;

    //构造函数
    public Student(int age1, bool sex, int number, string name)
    {
    //新的关键词this
    //代表自己
    this.age = age;
    //相当于 age = age1;

    this.sex = sex; 
    this.number = number;
    this.name = name;
    }

    //构造函数可以重载
    public Student(int age)
    {
        this.age = age;
    }
    public void Speak()
    {
    //函数中可以自己使用结构体内部申明的变量
    Console.WriteLine("阿巴阿巴");
    Console.WriteLine("我的名字是{0}，我{1}岁", name, age);
    }
}//结构体构造函数的一种用法，相当于给s2初始化
```
### 构造函数
一般是为了方便初始化
#### 基本概念
没有返回值
函数名和结构体名相同

必须有参数，是因为
> 结构体声明时默认会有一个无参数的构造函数
> 如果你再写无参数的构造函数就相当于定义了两个重复的函数，会报错


如果声明了构造函数 那必须在其中对所有的变量数据初始化
构造函数**可以重载**
### 函数方法
用于表现这个数据结构的行为
在结构体中 目前**不要加static关键字**
### 结构体的调用
```csharp
class Progrom
{
    static void Main(string[] args)
    {
        //变量类型 变量名；
        Student s1;
        s1.age = 16;
        s1.sex = true;
        s1.number = 3;
        s1.name = "野乃美";
        s1.Speak();

        Student s2 = new Student(18, true, 2, "星野");


        Student s1 = new Student(14, true, 1, "爱丽丝");
        Student s2 = new Student(16, true, 2, "柚子");
        Student s3 = new Student(14, true, 3, "桃井");
        Student s4 = new Student(14, true, 4, "绿");
        s1.Speak();
    }
}
```


因为静态函数中不能访问非静态成员
[static](https://so.csdn.net/so/search?q=static&spm=1001.2101.3001.7020)(静态的)声明的方法和属性,不需要实例化就能被调用(公有/私有)
C#静态成员：
①静态成员属于类所有，非静态成员属于类的实例所有。 
②每创建一个类的实例，都会在内存中为非静态成员新分配一块存储；
C#静态方法 ：
1、C#静态方法属于类所有，类实例化前即可使用。 
2、非静态方法可以访问类中的任何成员，静态方法只能访问类中的静态成员。 
3、因为静态方法在类实例化前就可以使用，而类中的非静态变量必须在实例化之后才能分配内存



