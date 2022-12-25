# сторона Алисы
import pickle  #для чтенения объекта из файла
#Алиса читает публичный ключ Боба
with open('public_Bob.pem') as publickfile:
    p = publickfile.read()
    Bob_pubkey = int(p)
#Алиса берет свой секретный ключ
with open('private_Alice.pem') as publickfile:
    p = publickfile.read()
    Alice_privatekey = int(p)
# Алиса берет свои параметры -объект Alice
f = open(r'Alice.pem', 'rb')
Alice = pickle.load(f)
f.close()
#Вычисляют  ключ  для симметричного шифрования протокола, получив от Боба открытый ключ,
Alice_sharedkey = Alice.gen_shared_key(Bob_pubkey)
print ('Alice_secret shared key: ', Alice_sharedkey)
