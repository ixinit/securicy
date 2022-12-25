# -*- coding: utf-8 -*-
import rsa
import base64
# Боб формирует публичный и секретный ключи, публичный ключ передает Алисе
# Сохраняет секретный ключ для себя (расшифровки Алисиного послания)
(bob_pub, bob_priv) = rsa.newkeys(2048)
print ("Открытый ключ:",bob_pub)
print ('Закрытый ключ:',bob_priv)
#сохраняет публичный ключ
pub = bob_pub.save_pkcs1().decode('utf-8') # формат ключа - pkcs1
pubfile = open('public.pem', 'w+')  # pem- общепринятое расширение для ключа
pubfile.write(pub)
pubfile.close()
#сохраняет секретный ключ
private = bob_priv.save_pkcs1().decode('utf-8') # формат ключа - pkcs1
privatefile = open('private.pem', 'w+')   # pem- общепринятое расширение для ключа
privatefile.write(private)
privatefile.close()
