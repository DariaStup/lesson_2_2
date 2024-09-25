using System.Xml.Linq;

string?[,] users = new string[3, 4] { { "Иван", "Катя", "Лёша", "Вера" }, { "Тверь", "Пермь", "Калуга", "Иваново" }, { "36", "29", "31", "19" } };

Console.WriteLine("Введите id пользователя, чтобы запросить информацию:");
int arr_index = 0;

try
{
    arr_index = Convert.ToInt32(Console.ReadLine());
        if (arr_index == 0 || arr_index  > 4)
        {
            throw new Exception("id пользовалеля не должно быть более 4");
        }
    Console.WriteLine($"{users[0, arr_index - 1]} {users[1, arr_index - 1]} {users[2, arr_index - 1]}");
}
catch (ArgumentOutOfRangeException ex)
//вне диапазона double
{
    Console.WriteLine(ex.Message);
}
catch (System.FormatException ex)
//ошибка приведения значения id к типу int
{
    Console.WriteLine(ex.Message);
}
catch (Exception e)
//id выходит за границы массива
{
    Console.WriteLine($"Ошибка: {e.Message}");
}


