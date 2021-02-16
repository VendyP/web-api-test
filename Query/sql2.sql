-- DB using SQL Server

-- create table TrxOrder
CREATE TABLE TrxOrderDetail (
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	[OrderId] int NOT NULL,
    [Harga] decimal(18,0) NOT NULL,
    [Jumlah] int NOT NULL,
    [SubTotal] decimal(18,0) NOT NULL
);

-- create index
CREATE INDEX TrxOrderDetailIndexs ON TrxOrderDetail ([OrderId]);

-- seed
INSERT INTO TrxOrderDetail ( OrderId, Harga, Jumlah,SubTotal ) VALUES
( 1, 7500, 2, 15000 ), 
( 2, 10000, 2, 20000 ), 
( 2, 25000, 1, 25000),
( 2, 25000, 1, 25000),
( 3, 10000, 2, 20000 ), 
( 4, 5000, 1, 5000 ), 
( 5, 150000, 1, 150000),
( 5, 175000, 2, 300000)

-- select
select * from TrxOrderDetail