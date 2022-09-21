 
void Zadacha10()
{
Console.WriteLine("Задача №10 ");
Random ran=new Random();
int num=ran.Next(100,1000);
Console.WriteLine(num);
int n=num/10%10;
Console.WriteLine(n);}


void Zadacha13()
{
Console.WriteLine("Задача № 13 ");
Console.WriteLine ("Ввведите число ");
int num=Convert.ToInt32(Console.ReadLine());
int i=2;
if (num<100) Console.WriteLine("Третьей цифры нет");
else 
{
    int d=num.ToString()[i]-'0';
Console.WriteLine(d);
}
}
    

void Zadacha15()
{
Console.WriteLine("Задача № 15 ");
Console.WriteLine(" Введите номер дня недели ");
int day=Convert.ToInt32(Console.ReadLine());
if (day==1) {
    Console.WriteLine(" Понедельник ");
}
if (day==2) {
    Console.WriteLine(" Вторник ");
}
if (day==3) {
    Console.WriteLine(" Среда ");
}
if (day==4) {
    Console.WriteLine(" Четверг ");
}
if (day==5) {
    Console.WriteLine(" Пятница ");
}if (day==6) {
    Console.WriteLine(" Суббота ");
}
if (day==7) {
    Console.WriteLine(" Воскресенье ");
}
if (day==6 || day==7) {
    Console.WriteLine(" Выходной день ");
}
}






Zadacha10();
Zadacha13();
Zadacha15();