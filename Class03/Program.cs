// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//ハンズオン１

/*
int a = 500;
int b = 21412341;

int c = a * b;

Console.WriteLine(c);
*/

//ハンズオン２

/*
int h02 = 100;
int rest = h02 % 2;

if(rest == 0)
{
    Console.WriteLine("偶数です");
}
else
{
    Console.WriteLine("奇数です");
}
*/

//ハンズオン３

/*
string Answer = "5";

Console.WriteLine("文字当てゲーム：回答を入力してください。");  
string userAnswer = Console.ReadLine()??"";

while(userAnser != Answer)
{
    Console.WriteLine("不正解、もう一度入力してください。");
    userAnswer = Console.ReadLine() ?? "";    
}

Console.WriteLine("正解！");
*/

//ハンズオン５

/*
string Answer05 = "~";
string userAnswer05;

Console.WriteLine("文字当てゲーム：回答を入力してください。");

do
{
    userAnswer05 = Console.ReadLine(); ?? "";
}
while (userAnswer05 != Answer05);

Console.WriteLine("正解！");
*/


//ハンズオン４

/*
int loup = 1;
int sum = 0;

while(loup <= 100)
{
    sum += loup;
    loup++;
}

Console.WriteLine("合計は" + sum + "です。");
*/

//ハンズオン６

/*
int sum05 = 0;
for (int i = 1; i < 100; i++)
{
    sum05 += i;
}
Console.WriteLine("合計:" + sum05);
*/

//ハンズオン7

/*
float number = 3.14f;
float result = number * 300.5f;
Console.WriteLine(result);
*/

//ハンズオン８

/*
float number = 0f;
for (int i = 0; i<1000; i++)
{
    number += 0.001f;
}
Console.WriteLine(number);

float number2 = 10000f;
number2 += 0.0001f;
Console.WriteLine(number2);
*/

//ハンズオン９

/*
int number = 13;
bool numberIsOver0 = number >= 0;
bool numberIsUnder10 = number >= 10;

if(numberIsOver0 && numberIsUnder10)
{
    //0以上１０以下です
    Console.WriteLine(number + "は０以上１０以下です");
}

if(!numberIsOver0 || !numberIsUnder10)
{
    //0より小さいor１０より大きい
    Console.WriteLine(number + "は0より小さいor１０より大きい");
}
*/

//ハンズオン１０

/*
int temp1 = 1;
int temp2 = 1;

Console.WriteLine(1 + ";" + temp1);
Console.WriteLine(2 + ";" + temp2);

for (int i = 3; i <= 50; i++)
{
    int next = temp1 + temp2;
    Console.WriteLine(i + ":" + next);
    temp1 = temp2;
    temp2 = next;
}
*/