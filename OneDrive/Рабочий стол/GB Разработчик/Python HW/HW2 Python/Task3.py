# Требуется вывести все целые степени двойки (т.е. числа
# вида 2k), не превосходящие числа N.
# 10 -> 1 2 4 8

# N = int(input('Введите число N: '))
# flag = True
# number = 2
# for i in range(N):
#     if flag:
#         number = number ** i
#         if number <= N:
#             print(number)
#             number = 2
#         else:
#             flag = False
#     else:
#         i = N

n = int(input())
i = 0
while 2 ** i <= n:
    print(2 ** i)
    i += 1