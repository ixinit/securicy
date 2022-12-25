# -*- coding: utf-8 -*-
import rsa
import base64
#Алиса читает публичный ключ
with open('public.pem') as publickfile:
    p = publickfile.read()
    bob_pub = rsa.PublicKey.load_pkcs1(p)
# Алиса формирует сообщение Бобу и кодирует его в UTF8,
# поскольку RSA работает только с байтами
message = 'Привет, Алиса зашифровала сообщение для Боба с помощью публичного ключа Боба. Привет Боб!'.encode('utf8')
# Алиса шифрует сообщение публичным ключом Боба
crypto = rsa.encrypt(message, bob_pub)
#Алиса сохраняет шифровку в файл
crypto_msg = base64.encodebytes(crypto).decode('utf8')
print(crypto_msg)
# Сохранить зашифрованную информацию для локального
with open('msg.txt', 'w+') as f:
            f.write(crypto_msg)
