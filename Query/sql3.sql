-- DB using SQL Server

select
o.Id,
o.OrderDt as tanggal_order,
o.Status as status,
o.PaymentDt as tanggal_pembayaran,
SUM(od.SubTotal) as total,
SUM(od.Jumlah) as jumlah_barang
from TrxOrder o
left join TrxOrderDetail od on o.Id = od.OrderId
group by o.Id, o.OrderDt, o.Status, o.PaymentDt
order by o.Id asc