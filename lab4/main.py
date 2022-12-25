from Crypto.Hash import SHA
from Crypto.Random import get_random_bytes
from Crypto.Cipher import ARC4
plaintext = b'Hello, Samoilova Tatiana!'
key = b'sample key of any length'
nonce = get_random_bytes(16)
tempkey = SHA.new(key+nonce).digest()
cipher = ARC4.new(tempkey)
ciphertext = cipher.encrypt(plaintext)
print (ciphertext)

