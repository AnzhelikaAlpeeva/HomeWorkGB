# Создайте список из случайных чисел. Найдите второй максимум.
# a = [1, 2, 3] # Первый максимум == 3, второй == 2

import random
list = [] 
for i in range(0, 10):
    number = random.randint(-10, 10)
    list.append(number)
print(list)
list.sort()
print(list)
print(list[-2])