# Создайте список из случайных чисел. Найдите номер его последнего локального максимума 
# (локальный максимум — это элемент, который больше любого из своих соседей).

import random
list = []
loc_max = 0

for _ in range(0, 10):
    number = random.randint(-10, 10)
    list.append(number)
for i in range(1, 10):
    if list[i] > list[i-1]:
        if list[i] > list[i+1]:
            loc_max = list[i]
print(list)
print(loc_max)