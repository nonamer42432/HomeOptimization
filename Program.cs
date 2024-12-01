using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";
        Dictionary<string, int> wordCounts = WordFrequency(text);

        foreach (var item in wordCounts)
        {
            // Используем интерполяцию для читаемости
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    static Dictionary<string, int> WordFrequency(string text)
    {
        // Используем Linq для компановки и эффективности кода
        return text.Split(new char[] { ' ', ',', '!' }, StringSplitOptions.RemoveEmptyEntries).GroupBy(word => word.ToLower()).ToDictionary(group => group.Key, group => group.Count());
        // Разбиваем строку на слова, удаляя пустые элементы
        // Групперуем слова по регистрации ключа
        // Создаем словарь частоты
    }
}