// Написать программу, которая из имеющегося массива строк формирует массив из строк длинна которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести клавиатуры, либо задать при старте программы. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] FillArray()
{
	Console.WriteLine("Введите слова через пробел: ");
	var array = Console.ReadLine().Split(" ");
	return array;
}

string[] FindElementsLen3(string[] array){
	string temp = String.Empty;
	for(int i = 0; i < array.Length; i++){
		if(array[i].Length <= 3){
			temp += " " + array[i];
		} 
	}
	var arrayElLen3 = temp.Split(" ");
	return arrayElLen3;
}

