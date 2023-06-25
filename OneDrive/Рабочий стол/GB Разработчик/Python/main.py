# a = 3
# b = 11
# s = 2022
# print('Hello, world!')
# print(f'first - {a} second - {b} third - {s}')


# 1. Четырехзначное?
# Пользователь вводит целое число. Выведите YES, если
# это число является четырехзначным, и NO в противном случае.




# #########       СЕМИНАР 2

# #####     while

# Вводятся числа, пока не введут 0. Найти произведение четных чисел.

# mult = 1
# while True:
#     number = int(input('Введите число: '))
#     if number == 0:
#         break
#     if number % 2 == 0:
#         mult *= number
# print(mult)


# mult = 1
# number = int(input('Введите число: '))
# while number != 0:
#     if number % 2 == 0:
#         mult *= number
#     number = int(input('Введите число: '))



# #######  for  ########

# Переменная - итератор используется

# for number in 1, 2, 3, 4, 5, 6:
#     if number % 3 == 0:
#         print(number)

# for el in range(10):  # 0 - 9
#     print(el)

# for el in range(2, 10):
#     print(el)

# for el in range(2, 10, 3):
#     print(el)

# for el in range(10, 2, -3):
#     print(el)

# some_str = 'hello world!'
# for letter in some_str:
#     print(letter)

# for ind in range(0, len(some_str)):
#     print(some_str[ind])

# Переменная - итератор не используется

# for _ in range(10):
#     print('hello')

# Вводится количество чисел, затем сами числа, найти сумму четных чисел.

# count = int(input('Введите кол-во чисел: '))
# summa = 0
# for _ in range(count):
#     number = int(input('Введите число: '))
#     if number % 2 == 0:
#         summa += number
# print(summa)


# По данному целому неотрицательному n вычислите 
# значение n!. N! = 1 * 2 * 3 * … * N (произведение всех 
# чисел от 1 до N) 0! = 1 Решить задачу используя цикл 
# while
# Input: 5
# Output: 120

# number = int(input('Введите число: '))
# mul = 1
# while number > 1:
    
#     number -= 1
# print(mul)



# Дано натуральное число A > 1. Определите, каким по 
# счету числом Фибоначчи оно является, то есть 
# выведите такое число n, что φ(n)=A. Если А не 
# является числом Фибоначчи, выведите число -1.
# Input: 5
# Output: 6 
# a = int(input('Введите число: '))

# first = 0
# second = 1

# temp_number = first + second

# count = 3
# while temp_number < a:
#     first = second
#     second = temp_number
#     temp_number = first + second
#     count += 1
# if temp_number == a:
#     print(count)
# else:
#     print(-1)



# Уставшие от необычно теплой зимы, жители решили узнать, 
# действительно ли это самая длинная оттепель за всю историю 
# наблюдений за погодой. Они обратились к синоптикам, а те, в 
# свою очередь, занялись исследованиями статистики за 
# прошлые годы. Их интересует, сколько дней длилась самая 
# длинная оттепель. Оттепелью они называют период, в 
# который среднесуточная температура ежедневно превышала 
# 0 градусов Цельсия. Напишите программу, помогающую 
# синоптикам в работе.
# Пользователь вводит число N – общее количество
# рассматриваемых дней (1 ≤ N ≤ 100). В следующих строках
# располагается N целых чисел.
# Каждое число – среднесуточная температура в
# соответствующий день. Температуры – целые числа и лежат в
# диапазоне от –50 до 50
# Input: 6 -> -20 30 -40 50 10 -10
# Output: 2

# n = int(input('Введите кол-во дней: '))
# count = 0
# max_count = 0
# for _ in range(n):
#     t = int(input('Введите температуру: '))
#     if t > 0:
#         count += 1
#     else:
#         if count > max_count:
#             max_count = count
#         count = 0
# if count > max_count:
#     max_count = count
# print(max_count)


# Иван Васильевич пришел на рынок и решил 
# купить два арбуза: один для себя, а другой для тещи. 
# Понятно, что для себя нужно выбрать арбуз 
# потяжелей, а для тещи полегче. Но вот незадача: 
# арбузов слишком много и он не знает как же выбрать 
# самый легкий и самый тяжелый арбуз? Помогите ему!
# Пользователь вводит одно число N – количество
# арбузов. Вторая строка содержит N чисел,
# записанных на новой строчке каждое. Здесь каждое
# число – это масса соответствующего арбуза
# Input: 5 -> 5 1 6 5 9
# Output: 1 9


# count = int(input('Введите кол-во арбузов: '))

# first_weight = int(input('Введите вес арбуза: '))
# minn = first_weight
# maxx = first_weight

# for i in range(count - 1):
#     weight = int(input('Введите вес арбуза: '))
#     if weight < minn:
#         minn = weight
#     if weight > maxx:
#         maxx = weight
# print(minn, maxx)





# ##############   SEMINAR3      ################
colors = {'green', 'blue','gray'}
colors.discard('red') 