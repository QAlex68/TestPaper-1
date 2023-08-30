# Контрольная задача - реализация Python 3.11: Написать программу, которая из имеющегося массива
# строк формирует  новый массив из строк, длина которых меньше, либо равна 3 символам.
# Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
# При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
# Примеры:
# [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
# [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
# [“Russia”, “Denmark”, “Kazan”] → []

def get_short_strings(array): 
    new_array = []
    for i in range(len(array)):   
        if len(array[i]) <= 3:
            new_array.append(array[i])        
    return new_array; 


def get_list_on_keyboard():
    list_ok = []
    is_valid_str = 0
    print("Введите строковые переменные любой длины (окончание ввода пустая строка): ")
    str_input = input("Следующая переменная: ")
    is_valid_str = len(str_input)
    if is_valid_str != 0:
        list_ok.append(str_input)
    else:
        return list_ok
    while is_valid_str != 0:
        str_input = input("Следующая переменная: ")
        is_valid_str = len(str_input)
        if is_valid_str != 0:
            list_ok.append(str_input)
    return list_ok

my_list = get_list_on_keyboard()
print("Сгенерирован массив - ", my_list) 
short_list = get_short_strings(my_list)
print("Массив строк длиной не более 3 символов - ", short_list) 