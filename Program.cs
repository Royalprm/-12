using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_12
{
    internal class Program
    {
		public static void Main()
		{
			try
			{
				Console.Write("Введите радиус окружности: ");
				double Radius = Convert.ToDouble(Console.ReadLine());
				if (Radius <= 0)
				{
					Console.Write("Радиус должен быть задан действительным числом.");
					return;
				}
				Console.Write("Введите координату Х точки: ");
				double positionX = Math.Abs(Convert.ToDouble(Console.ReadLine()));
				Console.Write("Введите координату Y точки: ");
				double positionY = Math.Abs(Convert.ToDouble(Console.ReadLine()));
				Circle.GetСircumference(Radius);
				Circle.GetSquare(Radius);
				Circle.GetPosition(Radius, positionX, positionY);
			}
			catch (FormatException)
			{
				Console.WriteLine("Неверный формат ввода.");
				return;
			}
			Console.WriteLine();
			Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
			Console.ReadKey();
		}

		static class Circle
		{
			public static void GetСircumference(double Radius)
			{
				double Сircumference = Math.PI * 2 * Radius;
				Console.WriteLine("Длина окружности равна {0:f2}", Сircumference);
			}
			public static void GetSquare(double Radius)
			{
				double Square = Math.PI * Math.Pow(Radius, 2.0);
				Console.WriteLine("Площадь круга равна {0:f2}", Square);
			}
			public static void GetPosition(double Radius, double positionX, double positionY)
			{
				if (positionX <= Radius && positionY <= Radius)
				{
					Console.WriteLine("Точка с координатами ({0},{1}) принадлежит кругу с радиусом {2}", positionX, positionY, Radius);
				}
				else
				{
					Console.WriteLine("Точка с координатами ({0},{1}) не принадлежит кругу с радиусом {2}", positionX, positionY, Radius);
				}
			}
		}
	}
}
