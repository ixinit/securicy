from hashlib import blake2b
msg = 'Привет от Самойловой студентам физмата!'.encode() # байт-формат
h = blake2b(key=b'Smolensk_key', digest_size=16)
h.update(msg)
print(h.hexdigest()) #Вывод в 16-ричном формате
