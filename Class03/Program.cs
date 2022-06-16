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

string Answer05 = "~";
string userAnswer05;

Console.WriteLine("文字当てゲーム：回答を入力してください。");

do
{
    userAnswer05 = Console.ReadLine(); ?? "";
}
while (userAnswer05 != Answer05);

Console.WriteLine("正解！");


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

