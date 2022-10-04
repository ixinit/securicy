#pip install pycryptodome
from Crypto.Hash import SHA3_512, keccak

with open('./files/test.txt', 'r') as myfile:
  data = myfile.read()

k_hsh = keccak.new(digest_bits=256)
hsh1 = k_hsh.update(data.encode('utf8'))
print(hsh1.hexdigest())

s_hsh = SHA3_512.new()
hsh2 = s_hsh.update(data.encode('utf8'))
print(hsh2.hexdigest())
