# Создайте список из случайных чисел. Найдите максимальное количество его одинаковых элементов.

import random

list = [] 
for i in range(0, 10):
    number = random.randint(-10, 10)
    list.append(number)

max_el = set(list)
for i in max_el:
    print(f"'{i}': {list.count(i)}")





        




        



