UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Nhà'
WHERE TEN_CHUC_NANG LIKE N'%Nhà, trụ sở làm việc%'
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Báo cáo của Tổng cục'
WHERE ID = 115
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'4-Hao mòn tài sản'
WHERE ID = 108
