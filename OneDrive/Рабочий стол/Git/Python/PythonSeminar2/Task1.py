# На вход - число N. Выход - последовательность из N членов. 
# (умножение на -3)

number = int(input())
result = 1
for i in range(number):
    print(result, end = " ")
    result *= -3

