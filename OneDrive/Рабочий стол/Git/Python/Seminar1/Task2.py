# на вход 5 чисел, найти максимальное.

max = 0
for i in range(5):
    n = int (input())
    if n > max:
        max = n
print (max)
        