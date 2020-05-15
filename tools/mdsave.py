# -*- coding: utf-8 -*-
"""
Created on Tue Dec 31 20:19:59 2019

@author: TF
"""

import sys
import os
sys.path.append(os.path.abspath(os.path.join(os.getcwd(), "..")))

from tqsdk import TqApi
import json
import time
from threading import Timer
from datetime import datetime

cwdir = os.getcwd()
print(cwdir)


def checkTime(inc):

    dtn = datetime.now()
    print(dtn.strftime("%Y-%m-%d %H:%M:%S"))
    nHour = dtn.time().hour
    nMin = dtn.time().minute
    #晚上23点以后主动退出
    if nHour > 23 or nHour < 2:
        print("Exit!!!")
        sys.exit(0)

    t = Timer(inc,checkTime,(inc,))
    t.start()

#30分钟调用一次
checkTime(60 * 30)


PathRoot = "C:\\DataRecord\\"
ContractName = "SHFE.fu2009"


def getSavePath(contracrName) :
    dtpart = time.strftime("%Y_%m_%d",time.localtime())
    name = contracrName + dtpart + ".csv"
    if not os.path.exists(PathRoot):
        os.makedirs(PathRoot)
    filepath = PathRoot + name
    return filepath

FileFullPath = getSavePath(ContractName)
def saveTick(quote):
    with open(FileFullPath,"a+",newline='') as file:
        newline = str(quote.datetime) + "," + \
                  str(quote.ask_price1) + "," + \
                  str(quote.ask_volume1)+ "," +  \
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
                str(quote.volume)+ "," + \
                str(quote.amount) +"\n"

        file.write(newline)


def acceptMD():
    api = TqApi()
    quote = api.get_quote("SHFE.fu2009")

    saveTick(quote)

    while True:
        try:
            api.wait_update()
            saveTick(quote)
        except FileNotFoundError:
            print("File Not Found Error")
            time.sleep(3)




acceptMD()
