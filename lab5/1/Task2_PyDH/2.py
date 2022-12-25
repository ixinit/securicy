import pyDH
import pickle  #для сохренения объекта в файл
Bob = pyDH.DiffieHellman()
Bob_pubkey = Bob.gen_public_key() # Боб передаст свой открытый ключ Алисе
Bob_privatekey = Bob.get_private_key() # Этот секретный ключ только у Боба
#сохраняет свои параметры - объект Bob
f = open(r'Bob.pem', 'wb')
pickle.dump(Bob, f)
f.close()
#сохраняет публичный ключ, чтобы его передать Алисе
pub = str(Bob_pubkey)
pubfile = open('public_Bob.pem', 'w+')  # pem- общепринятое расширение для ключа
pubfile.write(pub)
pubfile.close()
#сохраняет секретный ключ
private = str(Bob_privatekey)
privatefile = open('private_Bob.pem', 'w+')   # pem- общепринятое расширение для ключа
privatefile.write(private)
privatefile.close()
print ("Открытый ключ Боба:",pub)
print ('Закрытый ключ  Боба:',private)
