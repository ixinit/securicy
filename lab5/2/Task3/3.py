# -*- coding: utf-8 -*-
import rsa
import base64
# Боб берет оба своих ключа и расшифровывает сообщение Алисы
#Боб читает из файла ключи
with open('public.pem') as publickfile:
    p = publickfile.read()
    bob_pub = rsa.PublicKey.load_pkcs1(p)
with open('private.pem') as privatefile:
    p = privatefile.read()
    bob_priv = rsa.PrivateKey.load_pkcs1(p)
# Читает зашифрованный файл Алисы
with open('msg.txt', 'r') as f:
    crypto_msg = f.read()
# Base64 декодирование шифровки
crypto = base64.decodebytes(crypto_msg.encode('utf8'))
message = rsa.decrypt(crypto, bob_priv)
print(message.decode('utf8'))
