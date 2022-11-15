# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.
import random
#ПЕрестановка выбирается случайным образом

def crypto(s, key):
    random.seed(key)
    ln = len(s)
    keys = random.sample(range(ln), ln)
    print(keys)
    out = ''
    for i in keys: out += s[i]
    return out


def encrypt(s, key):
    random.seed(key)
    ln = len(s)
    keys = random.sample(range(ln), ln)
    print(keys)
    out = [' ' for _ in range(ln)]
    for i, j in zip(keys, s):
        out[i] = j
    return ''.join(out)

# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    s1 = crypto('ОСНОВЫ ЗАЩИТЫ ИНФОРМАЦИИ', 5)
    print('crypt:\n' + s1)
    print('encrypt:\n' + encrypt(s1, 5))

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
