--************************************************************************************************************************************
--指向当前要使用的数据库
use master
go
--判断当前数据库是否存在
if exists (select * from sysdatabases where name='JDT')
drop database JDT --删除数据库
go
--创建数据库
create database JDT
on primary
(
	--数据库文件的逻辑名
    name='JDT_data',
    --数据库物理文件名（绝对路径）
    filename='D:\DB\JDT_data.mdf',
    --数据库文件初始大小
    size=10MB,
    --数据文件增长量
    filegrowth=1MB
)
--创建日志文件
log on
(
    name='JDT_log',
    filename='D:\DB\JDT_log.ldf',
    size=2MB,
    filegrowth=1MB
)
go

--创建配方表 
--use JDT
--go
--create table Products
--(
-- ProductID int identity(1,1)  primary key,
-- ProductName varchar(20) NOT NULL,
-- StopProduction  varchar(2) NOT NULL,

--)


use JDT
go
--创建检测数据表，  
CREATE TABLE TemperaTureMeasure 
(
Id int identity(1,1),

--ProductName varchar(20) NOT NULL,
Q3TempPv REAL , 
Q5UPTempPv REAL ,
Q5DownTempPv REAL  , 
Q6UPTempPv REAL ,
Q6DownTempPv REAL  ,
Q7UPTempPv REAL  , 
Q7DownTempPv REAL   ,
Q9UPTempPv REAL  ,
Q9DownTempPv REAL  , 
Q10UPTempPv REAL  ,
Q10DownTempPv REAL  , 
Q11UPTempPv REAL , 
Q11DownTempPv REAL, 
FHeatingTempPv REAL ,
BHeatingTempPv REAL  , 
SpareHeatingTempPv REAL , 
Furnace1TempPv REAL , 
Furnace2TempPv REAL , 
Furnace3TempPv REAL, 
Q3MoldsTempPv REAL  ,
Q5MoldsTempPv REAL  , 
Q6MoldsTempPv REAL , 
Q7MoldsTempPv REAL , 
Q12MoldsTempPv REAL , 
APhaseCurrentPv REAL , 
BPhaseCurrentPv REAL, 
CPhaseCurrentPv REAL ,
HighFrequency1TempPv REAL , 
HighFrequency1UpTempPv REAL , 
HighFrequency1DownTempPv REAL ,
CoolingWaterFlowPv REAL , 
CoolingWaterTmepPv REAL ,
--ProductID int not null references Products(ProductID)  ,
Formula VARCHAR (50) NOT NULL,
InsertTime VARCHAR (50) NOT NULL
);



Alter table TemperaTureMeasure add  TravelHeight REAL

Alter table TemperaTureMeasure add  RunTime REAL



select * from TemperaTureMeasure



select * from TemperaTureMeasure     where Formula='TEST1'  and InsertTime between '2020/08/20 10:19:35' and '2020/08/20 13:19:35' order by InsertTime DESC
 --references CODE(CodeId)  ,
use JDT
go
CREATE TABLE SysAdmins
 (
 LoginId INTEGER identity(1000,1) primary key ,
 LoginName VARCHAR (20) NOT NULL,
 LoginPwd VARCHAR (20) NOT NULL, 
 Role INTEGER  NOT NULL,
 );
-- CREATE TABLE CODE
-- (
-- CodeId INTEGER identity(1000,1)  primary key,
-- InsertTime varchar(20) NOT NULL,
-- CodeNum varchar(20) NOT NULL unique(CodeNum)
--);
CREATE TABLE MeasureData 
(
Id int identity(1,1),
InsertTime VARCHAR (50) NOT NULL,
BCRReadData1 VARCHAR (50) NOT NULL,
BCRReadData2 VARCHAR (50) NOT NULL,
RecipeName varchar(50) NOT NULL, 
SlotNum INTEGER NOT NULL  ,
ReadLength INTEGER NOT NULL  ,
MeasureValue01 INTEGER ,
MeasureValue02 INTEGER  , 
MeasureValue03 INTEGER ,
MeasureValue04 INTEGER  ,
MeasureValue05 INTEGER  , 
MeasureValue06 INTEGER   ,
MeasureValue07 INTEGER  ,
MeasureValue08 INTEGER  ,
MeasureValue09 INTEGER  ,
MeasureValue10 INTEGER  ,
MeasureValue11 INTEGER , 
MeasureValue12 INTEGER  ,
MeasureValue13 INTEGER    ,
MeasureValue14 INTEGER  ,
MeasureValue15 INTEGER , 
MeasureValue16 INTEGER  ,
MeasureValue17 INTEGER    ,
MeasureValue18 INTEGER ,
MeasureValue19 INTEGER    ,
MeasureValue20 INTEGER  ,
MeasureValue21 INTEGER , 
MeasureValue22 INTEGER  ,
MeasureValue23 INTEGER    ,
MeasureValue24 INTEGER ,
MeasureValue25 INTEGER   ,
errorRange INTEGER NOT NULL ,
pass VARCHAR (10) NOT NULL ,
);


use JDT
go
 insert into   MeasureData ( InsertTime, ReadLength ,RecipeName,errorRange,pass,BCRReadData1,BCRReadData2,SlotNum,MeasureValue01,MeasureValue02,MeasureValue03,
 MeasureValue04,MeasureValue05,MeasureValue06,MeasureValue07,MeasureValue08,MeasureValue09,MeasureValue10,MeasureValue11,MeasureValue12) 
 values( '2020/09/22 11:05:18',12,'YTRR90',5590,'OK','00001','00002',10,1000,1200,1300,1500,1200,1400,5000,1800,1900,1230,2340,5600 )


 
 select  top 50 * from MeasureData where ReadLength=12 and RecipeName='YTRR90'   order by  InsertTime  DESC 



--Alter table MeasureData add  BCRReadData1  VARCHAR(50) NOT NULL
--create table Products
--(
-- ProductID int identity(1,1)  primary key,
-- ProductName varchar(20) NOT NULL,
-- StopProduction  varchar(2) NOT NULL,

--)

CREATE TABLE AlarmData
(Id INTEGER identity(1000,1)  primary key ,
 InsertTime  VARCHAR(50) NOT NULL,
  VarName VARCHAR (20),
 AlarmState VARCHAR (20), 
 Priority  integer, 
 AlarmValue VARCHAR (20),
  Operator VARCHAR(20), 
 Note VARCHAR (150),
 AlarmImage text
 );







 Insert into AlarmData(InsertTime,VarName,AlarmState,Priority,AlarmValue,Note,Operator) values('2020/09/01 11:26:16','aaa','ACK',1,'100','dfdfdfdfd','李白')

 use JDT
 go
 select * from AlarmData

-- select * from AlarmData     where 1=1  and InsertTime between '2020/09/01 09:05:02' and '2020/09/01 14:05:02' order by InsertTime DESC
--Select top 20 * from AlarmData order by InsertTime DESC
--delete from AlarmData where Priority=2









