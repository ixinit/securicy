from Crypto.Hash import SHA
from Crypto.Random import get_random_bytes
from Crypto.Cipher import ARC4
plaintext = b'Test text Test text Test text Test text'
key = b'key'
nonce = get_random_bytes(16)
tempkey = SHA.new(key+nonce).digest()
cipher = ARC4.new(tempkey)
ciphertext = cipher.encrypt(plaintext)
print(ciphertext)
tempkey2 = SHA.new(key+nonce).digest()
cipher2 = ARC4.new(tempkey2)
result = cipher2.decrypt(ciphertext)
print(result)
