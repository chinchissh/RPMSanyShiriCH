using System;
using System.Collections.Generic;

namespace CalculateLib
{
    public class Calculations
    {
        /// <summary>
        /// Вычисляет сумму ряда с использованием заданного значения x и точности epsilon.
        /// </summary>
        /// <param name="x">Значение x, должно быть в диапазоне (-1, 1).</param>
        /// <param name="epsilon">Точность вычислений, должна быть положительной.</param>
        /// <returns>Список строк, содержащих промежуточные результаты и общую сумму ряда.</returns>
        public List<string> CalculateSumSeries(double x, double epsilon)
        {
            List<string> result = new List<string>();

            if (x <= -1 || x >= 1)
            {
                throw new ArgumentException("Значение x должно быть в диапазоне (-1, 1)");
            }

            if (epsilon <= 0)
            {
                throw new ArgumentException("Значение точности (epsilon) должно быть положительным");
            }

            double sum = 0;
            double term = 1;
            int n = 0;

            while (Math.Abs(term) >= epsilon)
            {
                sum += term;
                n++;
                result.Add($"n = {n}, term = {term}, sum = {sum}");

                term *= (-1) * x * (n + 1) / (n + 2);
            }

            result.Add($"Total sum = {sum}");

            return result;
        }
    }
}
