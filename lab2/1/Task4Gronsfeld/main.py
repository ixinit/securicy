A = 'АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЫЪЬЭЮЯ ' * 2
# алфавит

def f(mc, k, op):
    k *= len(mc) // len(k) + 1
    return ''.join([A[A.index(j) + int(k[i]) * op] for i, j in enumerate(mc)])

def encrypt(message, key):
    return f(message, key, 1)

def decrypt(ciphertext, key):
    return f(ciphertext, key, -1)

# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print(encrypt('ПРИМЕР ШИФРОВАНИЯ ГРОНСФЕЛЬДА', '2019'))  # шифрование - текст, ключ
    print(decrypt('СРЙХЖРААКФСЧДАОСА ДЩРНТЭЖЛЭМВ', '2019'))  # дешифрование, текст, ключ

