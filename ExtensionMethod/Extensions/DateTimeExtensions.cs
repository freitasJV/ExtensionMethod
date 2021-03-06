﻿using System.Globalization;

namespace System
{
    static class DateTimeExtensions
    {
        /// <summary>
        /// A classe estática, implementando um método estático,
        /// recebendo como 1º argumento o tipo ao qual se deseja fazer o 
        /// extension method. Caso tenha mais argumentos é só acrescentar conforme a necessidade
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
                return $"{duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} horas";
            else
                return $"{duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} dias";
        }
    }
}
