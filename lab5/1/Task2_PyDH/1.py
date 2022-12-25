import pyDH
import pickle  #для сохренения объекта в файл
Alice = pyDH.DiffieHellman()
Alice_pubkey = Alice.gen_public_key() # Алиса передаст свой открытый ключ Бобу
Alice_privatekey = Alice.get_private_key() # Этот секретный ключ только у Алисы
#сохраняет свои параметры - объект Alice
f = open(r'Alice.pem', 'wb')
pickle.dump(Alice, f)
f.close()
#сохраняет публичный ключ, чтобы его передать Бобу
pub = str(Alice_pubkey)
pubfile = open('public_Alice.pem', 'w+')  # pem- общепринятое расширение для ключа
pubfile.write(pub)
pubfile.close()
#сохраняет секретный ключ
private = str(Alice_privatekey)
privatefile = open('private_Alice.pem', 'w+')   # pem- общепринятое расширение для ключа
privatefile.write(private)
privatefile.close()
print ("Открытый ключ Алисы:",pub)
print ('Закрытый ключ Алисы:',private)
