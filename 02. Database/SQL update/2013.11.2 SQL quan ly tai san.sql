UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Đất'
WHERE ID IN (100,132,197,128)
GO

UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Nhà'
WHERE ID IN (101,133,198,129)
GO

UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Ô tô'
WHERE ID IN (104,134,199,130)
GO

UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Tài sản khác'
WHERE ID IN (106,135,200,131)
GO

DELETE FROM CM_DM_TU_DIEN 
WHERE ID IN (638,639)
