// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_CORD = 0;
const int Y_CORD = 1;
const int lINE_1 = 1;
const int lINE_2 = 2;

double[] lineData1 = InputLineData(lINE_1);
double[] lineData2 = InputLineData(lINE_2);

if(ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y = {lineData1[COEFFICIENT]} * x + {lineData1[CONSTANT]} и y = {lineData2[COEFFICIENT]} * x + {lineData2[CONSTANT]} ");
    Console.WriteLine($" имеет координаты ({coord[X_CORD]}, {coord[Y_CORD]})");
}

double Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)//
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_CORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    Console.WriteLine($"({lineData1[CONSTANT]} - {lineData2[CONSTANT]}) / ({lineData2[COEFFICIENT]} - {lineData1[COEFFICIENT]})");
    coord[Y_CORD] = lineData1[COEFFICIENT] * coord[X_CORD] + lineData1[CONSTANT];// изначально было так coord[Y_CORD] = lineData1[CONSTANT] * coord[X_CORD] + lineData1[CONSTANT]
    //Console.WriteLine($"{lineData1[COEFFICIENT]} * {coord[X_CORD]} + {lineData1[CONSTANT]}");
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if(lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if(lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают!");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны!");
            return false;
        }
    }
    return true;
}









// double GetDot(double k1, double b1, double k2, double b2)
// {
//     double x = 0, y1, y2;
//     x = 0.1;
//     do
//     {
//         x -= 0.1;
//         y1 = k1 * x + b1;
//         y2 = k2 * x + b2;
//     }
//     while (y1 != y2);
//     Console.WriteLine(y1);
//     return x;
// }

// double getX = GetDot(k1, b1, k2, b2);
// Console.WriteLine(getX);

