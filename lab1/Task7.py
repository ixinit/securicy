import zlib

buffersize = 8 # 256 byte buffer

with open('./files/тест.txt', 'rb') as file:
    buffr = file.read(buffersize)
    crcvalue = 0
    while len(buffr) > 0:
        crcvalue = zlib.crc32(buffr, crcvalue)
        buffr = file.read(buffersize)

print(crcvalue) # Decimal
print(format(crcvalue & 0xFFFFFFFF, '08x')) # Hexadecimal
