-- DB using SQL Server

-- create table TrxOrder
CREATE TABLE TrxOrder (
	[Id] int IDENTITY(1,1) PRIMARY KEY,
    [OrderDt] datetime NOT NULL,
    [Status] varchar(255),
    [PaymentDt] datetime NULL
);

-- create index
CREATE INDEX TrxOrderIndexs ON TrxOrder ([OrderDt], [Status], [PaymentDt]);

-- seed
INSERT INTO TrxOrder ( OrderDt, Status, PaymentDt ) VALUES
( '2021-01-01', 'Unpaid', NULL ), 
( '2021-01-02', 'Paid', '2021-01-03 13:00:00'),
( '2021-01-02', 'Unpaid', NULL),
( '2021-01-03', 'Unpaid', NULL),
( '2021-01-04', 'Paid', '2021-01-05 16:30:00')

-- select
select * from TrxOrder