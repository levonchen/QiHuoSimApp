# -*- coding: utf-8 -*-
"""
Created on Tue Dec 31 20:19:59 2019

@author: TF
"""


from tqsdk import TqApi
import json
import time
import struct
from datetime import datetime

api = TqApi()

quote = api.get_quote("SHFE.fu2009")

print(quote.last_price,quote.volume)

while True:
    try:
        f = open(r'\\.\pipe\qihuopipe', 'r+b', 0)
        while True:
            api.wait_update()
            #print(quote)
            itObj = {
                'datetime':quote.datetime,
                'ask_price1':quote.ask_price1,
                'bid_price1':quote.bid_price1,
                'last_price':quote.last_price
            }
            strtick = str(quote.ask_price1) + ',' + str(quote.bid_price1) + ',' + str(quote.datetime) #json.dumps(itObj)

            newline = str(quote.datetime) + "," + \
                      str(quote.ask_price1) + "," + \
                      str(quote.ask_volume1) + "," + \
                      str(quote.bid_price1) + "," + \
                      str(quote.bid_volume1) + "," + \
                      str(quote.ask_price2) + "," + \
                      str(quote.ask_volume2) + "," + \
                      str(quote.bid_price2) + "," + \
                      str(quote.bid_volume2) + "," + \
                      str(quote.ask_price3) + "," + \
                      str(quote.ask_volume3) + "," + \
                      str(quote.bid_price3) + "," + \
                      str(quote.bid_volume3) + "," + \
                      str(quote.ask_price4) + "," + \
                      str(quote.ask_volume4) + "," + \
                      str(quote.bid_price4) + "," + \
                      str(quote.bid_volume4) + "," + \
                      str(quote.ask_price5) + "," + \
                      str(quote.ask_volume5) + "," + \
                      str(quote.bid_price5) + "," + \
                      str(quote.bid_volume5) + "," + \
                      str(quote.last_price) + "," + \
                      str(quote.highest) + "," + \
                      str(quote.lowest) + "," + \
                      str(quote.open) + "," + \
                      "" + "," + \
                      str(quote.average) + "," + \
                      str(quote.volume) + "," + \
                      str(quote.amount) + "\n"

            print(newline)
            f.write(struct.pack('I', len(newline)) + newline.encode('ascii'))  # Write str length and str
            f.seek(0)
    except FileNotFoundError:
        print("File Not Found Error")
        time.sleep(3)




#
# try:
#
#     while True:
#             #n = struct.unpack('I', f.read(4))[0]    # Read str length
#             #s = f.read(n).decode('ascii')           # Read str
#             #f.seek(0)
#             #print ('Read:', s)
#             time.sleep(3)
#             s = datetime.utcnow().strftime('%Y-%m-%d %H:%M:%S.%f')[:-3]
#             s="Completed- "+ s
#
#             print ('Wrote:', s)
# except FileNotFoundError :
#     raise
