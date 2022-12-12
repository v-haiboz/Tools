# ECOLAB.IOT.EventHubReceiver 
***
## Instructions  
> * 如何监听EvenHub.
>> 1. 请输入被监听EventHub的相关信息.
>>> Parameter Description:
>>> `Connection string:` ` `EventHub的连接字符串
>>> `Name:` ` ` ` ` EventHub的Name.
>>> `Consumer group:` EventHub的Consumer group
>>> <img src="/img/1.png"/>
>> 2. 点击开始监听.
>>> <img src="/img/2.png"/>
>> 3. 如何有数据会在接收区域输出.
>>>Note:
>>>1.应该有可能EventHub数量很大，所以当慢100条数据时，就会清空接受去，重新记录.
>>>2.Total Line:记录的总的条数(程序每次启动，将重新计数)。
>>> <img src="/img/4.png"/>
>> 4. 点击停止，将会停止数据的接收.
>>> <img src="/img/3.png"/>
## High order operation
>> Logging enabled
> 1.如想修改EventHub监听过程中，使用的storage acount(用来记录监听的checkpoint),请修改下边的文件即可.
>> + File path(..\EventHubReceiver\storageconfig.yaml)
>>  <img src="/img/6.png"/> 
>> + File Detailed
>>  <img src="/img/5.png"/>

