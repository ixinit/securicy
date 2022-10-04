#ГЕНЕРИРУЕМ MAC: ПЕредающая сторона
from Crypto.Hash import HMAC, SHA256
secret_key = b'Swordfish'
h = HMAC.new(secret_key, digestmod=SHA256)
message1 = 'У Самойловой на вкладе 123 млн. рублей'
h.update(message1.encode())
mac1 = h.hexdigest()
print(mac1)
# Сообщение и хеш надо сохранить в файлах

#ПРОВЕРЯЕМ MAC: Принимающая сторона
# We have received a message 'message2' together
# with its MAC 'mac1'
#Прочитать сообщение и хеш их файла
secret_key = b'Swordfish'
h = HMAC.new(secret_key, digestmod=SHA256)
message2 = 'У Самойловой на вкладе 123 млн. рублей' #его и надо подделать!
h.update(message2.encode())
mac2 = h.hexdigest()
print(mac2)
try:
    h.hexverify(mac1)
    print("The message '%s' is authentic" % message2)
except ValueError:
    print("The message or the key is wrong")
