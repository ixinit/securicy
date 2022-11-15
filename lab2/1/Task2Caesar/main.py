# -*- coding: utf-8 -*-
ALPHA = u'АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЫЪЬЭЮЯ '
#Шифр Цезаря: шифрование и дешифрование
def encode(text, step):
    return text.translate(
        str.maketrans(ALPHA, ALPHA[step:] + ALPHA[:step]))

def decode(text, step):
    return text.translate(
        str.maketrans(ALPHA[step:] + ALPHA[:step], ALPHA))

# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print(encode('ЭТА СТРОКА ВЫШЕ ЗАШИФРОВАНА', 13))
    print(decode('ИЯМЛЮЯЭЪЧМЛОЁДСЛФМДХАЭЪОМЫМ', 13))
    print()

    # ШИФРОВАНИЕ
    print("ШИФРОВАНИЕ")
    f = open("source1.txt",encoding="UTF-8")  # ANSI кодировка!!!
    plaintext = f.read()
    f.close()
    ciphertext = encode(plaintext, 5)
    print(plaintext)
    print(ciphertext)
    f = open("cipher.txt", "w")
    f.write((ciphertext + "\n"))  # Сохраняет в ANSI -ФАЙЛ
    f.close()
    print()

    # ДЕШИФРОВАНИЕ ЧИТАЕМ ИЗ ФАЙЛА!!
    print("ДЕШИФРОВАНИЕ ЧИТАЕМ ИЗ ФАЙЛА!!")
    f = open("cipher.txt")  # ANSI кодировка!!!
    ciphertext2 = f.read()
    f.close()
    # decipher
    plaintext2 = decode(ciphertext2, 5)
    print(plaintext2)
    #print()

    # ВЗЛАМЫВАЕМ МЕТОДОМ ГРУБОЙ СИЛЫ - ЧИТАЕМ ИЗ ФАЙЛА!!
    print("ВЗЛАМЫВАЕМ МЕТОДОМ ГРУБОЙ СИЛЫ - ЧИТАЕМ ИЗ ФАЙЛА!!")
    f = open("cipher.txt")  # ANSI кодировка!!!
    ciphertext2 = f.read()
    f.close()
    for key in range(1, 33):  # Перебираем все ключи
        plaintext2 = decode(ciphertext2, key)
        print(plaintext2)

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
