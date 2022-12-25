from Crypto.Hash import SHA256 #pip install pycryptodome
from Crypto.PublicKey import RSA
from Crypto.Signature import pkcs1_15
import os
#СТОРОНА ОТПРАВИТЕЛЯ
# Генерируете новый ключ (или берете ранее сгенерированный)
privatekey = RSA.generate(1024, os.urandom) #секретный ключ
# Получаете хэш файла
message1 = b'digital signature'
h = SHA256.new(message1)
# Подписываете хэш закрытым ключом
signature = pkcs1_15.new(privatekey).sign(h)
# Получаете открытый (публичный) ключ из закрытого
pubkey = privatekey.publickey()
# Пересылаете пользователю файл, публичный ключ и подпись
#СТОРОНА ПОЛУЧАТЕЛЯ
# На стороне пользователя заново вычисляете хэш файла  и сверяете подпись
message2 = b'digital signature'
h = SHA256.new(message2)
try:
  pkcs1_15.new(pubkey).verify(h, signature)
  print ("Верификация успешна!")
except (ValueError, TypeError):
  print ("Верификация не прошла. Документ подделан!")
