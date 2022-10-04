from hashlib import blake2b, blake2s
# ПРимер 1 алгоритм blake2b
h = blake2b(digest_size=20)
msg = 'Привет от Самойловой студентам физмата!'.encode() # байт-формат
h.update(msg)
#h.update(b'Hello from Samoilova')
print(h.digest()) # в байтовом формате
#Преобразуем байты в 16-ричный формат
print(h.digest().hex())
print((h.digest_size))
print(len(h.digest()))
#**********************************
# ПРимер 2 алгоритм blake2s
h = blake2s(digest_size=20)
h.update(msg)
#Преобразуем байты  хэша в 16-ричный формат
print(h.digest().hex())

