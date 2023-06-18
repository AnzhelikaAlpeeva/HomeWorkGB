# Вы пользуетесь общественным транспортом? 
# Вероятно, вы расплачивались за проезд и получали билет с номером. 
# Счастливым билетом называют такой билет с шестизначным номером, 
# где сумма первых трех цифр равна сумме последних трех. 
# Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6. 
# Вам требуется написать программу, которая проверяет счастливость билета.
# 385916 -> yes
# 123456 -> no

n = (input('Введите шестизначное число: '))

if n[0] + n[1] + n[2] == n[3] + n[4] + n[5]:
    m = 'yes'
else:
    m = 'no'

print(f'{n} {m}')