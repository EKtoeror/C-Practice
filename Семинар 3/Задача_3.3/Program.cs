// находит координаты двух точек и находит расстояние между ними в 2д пространстве

Console.WriteLine("Введите координаты двух точек:  ");
string x01 = Console.ReadLine() ?? "";
string y01 = Console.ReadLine() ?? "";

string x02 = Console.ReadLine() ?? "";
string y02 = Console.ReadLine() ?? "";

int x1 = Convert.ToInt32(x01);
int y1 = Convert.ToInt32(y01);

int x2 = Convert.ToInt32(x02);
int y2 = Convert.ToInt32(y02);

double result = Math.Sqrt((Math.Pow((x2-x1),2))+(Math.Pow((y2-y1),2)));
//double result = ((x2-x1)^2)^(1/2)+((y2-y1)^2)^(1/2); считает неправильно

Console.WriteLine($"Растояние между точками {result}");