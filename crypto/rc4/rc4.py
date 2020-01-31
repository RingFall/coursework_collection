# -*- coding: UTF-8 -*-
import hashlib, base64, sys

def rc4(text, key = 'default-key', mode = "encode"):
    if mode == "decode":
        text = base64.b64decode(text)
    result = ''
    key_len = len(key)
    #1 S盒
    S = list(range(256))
    j = 0
    for i in range(256):
        j = (j + S[i] + ord(key[i%key_len]))%256
        S[i],S[j] = S[j],S[i]
    #2 秘钥流
    i = j = 0
    for element in text:
        i = (i+1)%256
        j = (j+S[i])%256
        S[i],S[j] = S[j],S[i]
        k = chr(ord(element) ^ S[(S[i]+S[j])%256])
        result += k
    if mode == "encode":
        result = base64.b64encode(result)
    return result

if __name__ == '__main__':
    text = raw_input("文本:".decode('UTF-8').encode('GBK'))
    key = raw_input("密钥:".decode('UTF-8').encode('GBK'))
    mode = raw_input("模式(encode/decode):".decode('UTF-8').encode('GBK'))
    print rc4(text,key,mode)