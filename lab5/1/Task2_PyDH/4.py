# сторона Боба
import pickle  #для чтенения объекта из файла
#Боб читает публичный ключ Алисы
with open('public_Alice.pem') as publickfile:
    p = publickfile.read()
    Alice_pubkey = int(p)
#Боб берет свой секретный ключ
with open('private_Bob.pem') as publickfile:
    p = publickfile.read()
    Bob_privatekey = int(p)
# Боб берет свои параметры - объект Bob
f = open(r'Bob.pem', 'rb')
Bob = pickle.load(f)
f.close()
#Вычисляют  ключ  для симметричного шифрования протокола, получив от Алисы открытый ключ,
Bob_sharedkey = Bob.gen_shared_key(Alice_pubkey) # Боб, получив от Алисы открытый ключ, вычисляет симметричный ключ
print ('Bob_secret shared key: ', Bob_sharedkey)
