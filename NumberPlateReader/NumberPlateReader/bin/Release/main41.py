#!/usr/bin/python

import requests
import base64
import json


# Sample image file is available at http://plates.openalpr.com/ea7the.jpg
try:
    IMAGE_PATH = r'C:\dhruv_tut\NumberPlateReader\NumberPlateReader\bin\Release\test.jpg'
    SECRET_KEY = 'sk_4a3325c60a92d3cbb5d4de18'
    
    with open(IMAGE_PATH, 'rb') as image_file:
        img_base64 = base64.b64encode(image_file.read())
    
    url = 'https://api.openalpr.com/v2/recognize_bytes?recognize_vehicle=0&country=ind&secret_key=%s' % (SECRET_KEY)
    r = requests.post(url, data = img_base64)
    a=json.dumps(r.json())
    a=a.split('plate')[2].split(',')[0].split('"')[2]
    file1 = open(r"output\Output.txt","w")
    file1.write(a)
    file1.close()
  
except:
    file1 = open(r"output\Output.txt","w")
    file1.write("error1")
    file1.close()