# ВЗЛАМЫВАЕМ МЕТОДОМ ГРУБОЙ СИЛЫ - ЧИТАЕМ ИЗ ФАЙЛА!!
ALPHA = u'АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЫЪЬЭЮЯ '

def decode(text, step):
    return text.translate(
        str.maketrans(ALPHA[step:] + ALPHA[:step], ALPHA))

if __name__ == '__main__':
    f = open("cipher.txt")  # ANSI кодировка!!!
    ciphertext2 = f.read()
    f.close()
    for key in range(1, 33):  # Перебираем все ключи
        plaintext2 = decode(ciphertext2, key)
        print(plaintext2)

