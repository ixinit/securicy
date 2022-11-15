# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.

# XOR для шифрования/расшифровки
def xor_cipher(str, key):
    encript_str = ""
    for letter in str:
        encript_str += chr(ord(letter) ^ key)
    return encript_str



# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    strg = "Пример XOR шифрования"
    key = 8
    print("original:\t", strg)
    encr_strg = xor_cipher(strg, key)
    print("encript:\t", encr_strg)
    print("decript:\t", xor_cipher(encr_strg, key))

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
