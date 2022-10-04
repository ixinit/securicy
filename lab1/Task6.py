# -*- coding: utf-8 -*-
"""
Created on Fri Aug 10 09:51:50 2018
https://pypi.org/project/ImageHash/ - пакет для сравнения изображений
@author: Самойлова
average hashing (aHash)
perception hashing (pHash)
difference hashing (dHash)
wavelet hashing (wHash)
"""
# pip install Pillow
# pip install ImageHash
# pip install six
from PIL import Image
import imagehash
img1 = Image.open("./images/pycharm.png")
img2 = Image.open("./images/pycharm.png")
img1.show()
img2.show()
hash = imagehash.phash(img1)
print(hash)
otherhash = imagehash.phash(img2)
print(otherhash)
print(hash == otherhash)
print(hash - otherhash)
