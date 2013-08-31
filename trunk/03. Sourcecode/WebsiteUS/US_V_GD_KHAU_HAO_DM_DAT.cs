///************************************************
/// Generated by: Vanna
/// Date: 31/08/2013 06:04:01
/// Goal: Create User Service Class for V_GD_KHAU_HAO_DM_DAT
///************************************************
/// <summary>
/// Create User Service Class for V_GD_KHAU_HAO_DM_DAT
/// </summary>

using System;
using WebDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using WebDS.CDBNames;


namespace WebUS
{
    public class US_V_GD_KHAU_HAO_DM_DAT : US_Object
    {
        private const string c_TableName = "V_GD_KHAU_HAO_DM_DAT";
        #region "Public Properties"
        public string strTEN_DV_SU_DUNG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DV_SU_DUNG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DV_SU_DUNG"] = value;
            }
        }

        public bool IsTEN_DV_SU_DUNGNull()
        {
            return pm_objDR.IsNull("TEN_DV_SU_DUNG");
        }

        public void SetTEN_DV_SU_DUNGNull()
        {
            pm_objDR["TEN_DV_SU_DUNG"] = System.Convert.DBNull;
        }

        public string strTEN_DV_CHU_QUAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DV_CHU_QUAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DV_CHU_QUAN"] = value;
            }
        }

        public bool IsTEN_DV_CHU_QUANNull()
        {
            return pm_objDR.IsNull("TEN_DV_CHU_QUAN");
        }

        public void SetTEN_DV_CHU_QUANNull()
        {
            pm_objDR["TEN_DV_CHU_QUAN"] = System.Convert.DBNull;
        }

        public string strTEN_DV_BO_TINH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DV_BO_TINH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DV_BO_TINH"] = value;
            }
        }

        public bool IsTEN_DV_BO_TINHNull()
        {
            return pm_objDR.IsNull("TEN_DV_BO_TINH");
        }

        public void SetTEN_DV_BO_TINHNull()
        {
            pm_objDR["TEN_DV_BO_TINH"] = System.Convert.DBNull;
        }

        public string strTEN_TRANG_THAI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_TRANG_THAI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_TRANG_THAI"] = value;
            }
        }

        public bool IsTEN_TRANG_THAINull()
        {
            return pm_objDR.IsNull("TEN_TRANG_THAI");
        }

        public void SetTEN_TRANG_THAINull()
        {
            pm_objDR["TEN_TRANG_THAI"] = System.Convert.DBNull;
        }

        public string strTEN_TINH_TRANG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_TINH_TRANG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_TINH_TRANG"] = value;
            }
        }

        public bool IsTEN_TINH_TRANGNull()
        {
            return pm_objDR.IsNull("TEN_TINH_TRANG");
        }

        public void SetTEN_TINH_TRANGNull()
        {
            pm_objDR["TEN_TINH_TRANG"] = System.Convert.DBNull;
        }

        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public string strMA_TAI_SAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_TAI_SAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_TAI_SAN"] = value;
            }
        }

        public bool IsMA_TAI_SANNull()
        {
            return pm_objDR.IsNull("MA_TAI_SAN");
        }

        public void SetMA_TAI_SANNull()
        {
            pm_objDR["MA_TAI_SAN"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_TAI_SAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_TAI_SAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_TAI_SAN"] = value;
            }
        }

        public bool IsID_LOAI_TAI_SANNull()
        {
            return pm_objDR.IsNull("ID_LOAI_TAI_SAN");
        }

        public void SetID_LOAI_TAI_SANNull()
        {
            pm_objDR["ID_LOAI_TAI_SAN"] = System.Convert.DBNull;
        }

        public string strDIA_CHI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIA_CHI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIA_CHI"] = value;
            }
        }

        public bool IsDIA_CHINull()
        {
            return pm_objDR.IsNull("DIA_CHI");
        }

        public void SetDIA_CHINull()
        {
            pm_objDR["DIA_CHI"] = System.Convert.DBNull;
        }

        public decimal dcDT_KHUON_VIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DT_KHUON_VIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DT_KHUON_VIEN"] = value;
            }
        }

        public bool IsDT_KHUON_VIENNull()
        {
            return pm_objDR.IsNull("DT_KHUON_VIEN");
        }

        public void SetDT_KHUON_VIENNull()
        {
            pm_objDR["DT_KHUON_VIEN"] = System.Convert.DBNull;
        }

        public decimal dcDT_TRU_SO_LAM_VIEC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DT_TRU_SO_LAM_VIEC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DT_TRU_SO_LAM_VIEC"] = value;
            }
        }

        public bool IsDT_TRU_SO_LAM_VIECNull()
        {
            return pm_objDR.IsNull("DT_TRU_SO_LAM_VIEC");
        }

        public void SetDT_TRU_SO_LAM_VIECNull()
        {
            pm_objDR["DT_TRU_SO_LAM_VIEC"] = System.Convert.DBNull;
        }

        public decimal dcDT_CO_SO_HOAT_DONG_SU_NGHIEP
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DT_CO_SO_HOAT_DONG_SU_NGHIEP", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DT_CO_SO_HOAT_DONG_SU_NGHIEP"] = value;
            }
        }

        public bool IsDT_CO_SO_HOAT_DONG_SU_NGHIEPNull()
        {
            return pm_objDR.IsNull("DT_CO_SO_HOAT_DONG_SU_NGHIEP");
        }

        public void SetDT_CO_SO_HOAT_DONG_SU_NGHIEPNull()
        {
            pm_objDR["DT_CO_SO_HOAT_DONG_SU_NGHIEP"] = System.Convert.DBNull;
        }

        public decimal dcDT_LAM_NHA_O
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DT_LAM_NHA_O", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DT_LAM_NHA_O"] = value;
            }
        }

        public bool IsDT_LAM_NHA_ONull()
        {
            return pm_objDR.IsNull("DT_LAM_NHA_O");
        }

        public void SetDT_LAM_NHA_ONull()
        {
            pm_objDR["DT_LAM_NHA_O"] = System.Convert.DBNull;
        }

        public decimal dcDT_CHO_THUE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DT_CHO_THUE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DT_CHO_THUE"] = value;
            }
        }

        public bool IsDT_CHO_THUENull()
        {
            return pm_objDR.IsNull("DT_CHO_THUE");
        }

        public void SetDT_CHO_THUENull()
        {
            pm_objDR["DT_CHO_THUE"] = System.Convert.DBNull;
        }

        public decimal dcDT_BO_TRONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DT_BO_TRONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DT_BO_TRONG"] = value;
            }
        }

        public bool IsDT_BO_TRONGNull()
        {
            return pm_objDR.IsNull("DT_BO_TRONG");
        }

        public void SetDT_BO_TRONGNull()
        {
            pm_objDR["DT_BO_TRONG"] = System.Convert.DBNull;
        }

        public decimal dcDT_BI_LAN_CHIEM
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DT_BI_LAN_CHIEM", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DT_BI_LAN_CHIEM"] = value;
            }
        }

        public bool IsDT_BI_LAN_CHIEMNull()
        {
            return pm_objDR.IsNull("DT_BI_LAN_CHIEM");
        }

        public void SetDT_BI_LAN_CHIEMNull()
        {
            pm_objDR["DT_BI_LAN_CHIEM"] = System.Convert.DBNull;
        }

        public decimal dcDT_SU_DUNG_MUC_DICH_KHAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DT_SU_DUNG_MUC_DICH_KHAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DT_SU_DUNG_MUC_DICH_KHAC"] = value;
            }
        }

        public bool IsDT_SU_DUNG_MUC_DICH_KHACNull()
        {
            return pm_objDR.IsNull("DT_SU_DUNG_MUC_DICH_KHAC");
        }

        public void SetDT_SU_DUNG_MUC_DICH_KHACNull()
        {
            pm_objDR["DT_SU_DUNG_MUC_DICH_KHAC"] = System.Convert.DBNull;
        }

        public decimal dcGT_THEO_SO_KE_TOAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GT_THEO_SO_KE_TOAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GT_THEO_SO_KE_TOAN"] = value;
            }
        }

        public bool IsGT_THEO_SO_KE_TOANNull()
        {
            return pm_objDR.IsNull("GT_THEO_SO_KE_TOAN");
        }

        public void SetGT_THEO_SO_KE_TOANNull()
        {
            pm_objDR["GT_THEO_SO_KE_TOAN"] = System.Convert.DBNull;
        }

        public decimal dcID_TRANG_THAI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRANG_THAI"] = value;
            }
        }

        public bool IsID_TRANG_THAINull()
        {
            return pm_objDR.IsNull("ID_TRANG_THAI");
        }

        public void SetID_TRANG_THAINull()
        {
            pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CAP_NHAT_CUOI
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_NHAT_CUOI", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CAP_NHAT_CUOI"] = value;
            }
        }

        public bool IsNGAY_CAP_NHAT_CUOINull()
        {
            return pm_objDR.IsNull("NGAY_CAP_NHAT_CUOI");
        }

        public void SetNGAY_CAP_NHAT_CUOINull()
        {
            pm_objDR["NGAY_CAP_NHAT_CUOI"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_LAP
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_LAP", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_LAP"] = value;
            }
        }

        public bool IsID_NGUOI_LAPNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_LAP");
        }

        public void SetID_NGUOI_LAPNull()
        {
            pm_objDR["ID_NGUOI_LAP"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_DUYET
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_DUYET", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_DUYET"] = value;
            }
        }

        public bool IsID_NGUOI_DUYETNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_DUYET");
        }

        public void SetID_NGUOI_DUYETNull()
        {
            pm_objDR["ID_NGUOI_DUYET"] = System.Convert.DBNull;
        }

        public decimal dcID_DON_VI_SU_DUNG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_SU_DUNG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI_SU_DUNG"] = value;
            }
        }

        public bool IsID_DON_VI_SU_DUNGNull()
        {
            return pm_objDR.IsNull("ID_DON_VI_SU_DUNG");
        }

        public void SetID_DON_VI_SU_DUNGNull()
        {
            pm_objDR["ID_DON_VI_SU_DUNG"] = System.Convert.DBNull;
        }

        public decimal dcID_DON_VI_CHU_QUAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_CHU_QUAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI_CHU_QUAN"] = value;
            }
        }

        public bool IsID_DON_VI_CHU_QUANNull()
        {
            return pm_objDR.IsNull("ID_DON_VI_CHU_QUAN");
        }

        public void SetID_DON_VI_CHU_QUANNull()
        {
            pm_objDR["ID_DON_VI_CHU_QUAN"] = System.Convert.DBNull;
        }

        public decimal dcSO_NAM_DA_SU_DUNG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_NAM_DA_SU_DUNG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_NAM_DA_SU_DUNG"] = value;
            }
        }

        public bool IsSO_NAM_DA_SU_DUNGNull()
        {
            return pm_objDR.IsNull("SO_NAM_DA_SU_DUNG");
        }

        public void SetSO_NAM_DA_SU_DUNGNull()
        {
            pm_objDR["SO_NAM_DA_SU_DUNG"] = System.Convert.DBNull;
        }

        public decimal dcID_TINH_TRANG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TINH_TRANG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TINH_TRANG"] = value;
            }
        }

        public bool IsID_TINH_TRANGNull()
        {
            return pm_objDR.IsNull("ID_TINH_TRANG");
        }

        public void SetID_TINH_TRANGNull()
        {
            pm_objDR["ID_TINH_TRANG"] = System.Convert.DBNull;
        }

        public decimal dcID_KH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_KH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_KH"] = value;
            }
        }

        public bool IsID_KHNull()
        {
            return pm_objDR.IsNull("ID_KH");
        }

        public void SetID_KHNull()
        {
            pm_objDR["ID_KH"] = System.Convert.DBNull;
        }

        public string strMA_PHIEU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_PHIEU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_PHIEU"] = value;
            }
        }

        public bool IsMA_PHIEUNull()
        {
            return pm_objDR.IsNull("MA_PHIEU");
        }

        public void SetMA_PHIEUNull()
        {
            pm_objDR["MA_PHIEU"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_LAP_KH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_LAP_KH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_LAP_KH"] = value;
            }
        }

        public bool IsID_NGUOI_LAP_KHNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_LAP_KH");
        }

        public void SetID_NGUOI_LAP_KHNull()
        {
            pm_objDR["ID_NGUOI_LAP_KH"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_DUYET_KH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_DUYET_KH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_DUYET_KH"] = value;
            }
        }

        public bool IsID_NGUOI_DUYET_KHNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_DUYET_KH");
        }

        public void SetID_NGUOI_DUYET_KHNull()
        {
            pm_objDR["ID_NGUOI_DUYET_KH"] = System.Convert.DBNull;
        }

        public decimal dcID_DON_VI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI"] = value;
            }
        }

        public bool IsID_DON_VINull()
        {
            return pm_objDR.IsNull("ID_DON_VI");
        }

        public void SetID_DON_VINull()
        {
            pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
        }

        public decimal dcID_TAI_SAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TAI_SAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TAI_SAN"] = value;
            }
        }

        public bool IsID_TAI_SANNull()
        {
            return pm_objDR.IsNull("ID_TAI_SAN");
        }

        public void SetID_TAI_SANNull()
        {
            pm_objDR["ID_TAI_SAN"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_TAI_SAN_KH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_TAI_SAN_KH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_TAI_SAN_KH"] = value;
            }
        }

        public bool IsID_LOAI_TAI_SAN_KHNull()
        {
            return pm_objDR.IsNull("ID_LOAI_TAI_SAN_KH");
        }

        public void SetID_LOAI_TAI_SAN_KHNull()
        {
            pm_objDR["ID_LOAI_TAI_SAN_KH"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_LAP
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_LAP", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_LAP"] = value;
            }
        }

        public bool IsNGAY_LAPNull()
        {
            return pm_objDR.IsNull("NGAY_LAP");
        }

        public void SetNGAY_LAPNull()
        {
            pm_objDR["NGAY_LAP"] = System.Convert.DBNull;
        }

        public decimal dcGIA_TRI_KHAU_HAO
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIA_TRI_KHAU_HAO", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIA_TRI_KHAU_HAO"] = value;
            }
        }

        public bool IsGIA_TRI_KHAU_HAONull()
        {
            return pm_objDR.IsNull("GIA_TRI_KHAU_HAO");
        }

        public void SetGIA_TRI_KHAU_HAONull()
        {
            pm_objDR["GIA_TRI_KHAU_HAO"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_DUYET
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_DUYET", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_DUYET"] = value;
            }
        }

        public bool IsNGAY_DUYETNull()
        {
            return pm_objDR.IsNull("NGAY_DUYET");
        }

        public void SetNGAY_DUYETNull()
        {
            pm_objDR["NGAY_DUYET"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_GD_KHAU_HAO_DM_DAT()
        {
            pm_objDS = new DS_V_GD_KHAU_HAO_DM_DAT();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_GD_KHAU_HAO_DM_DAT(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_GD_KHAU_HAO_DM_DAT(decimal i_dbID)
        {
            pm_objDS = new DS_V_GD_KHAU_HAO_DM_DAT();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        #region "Additional Functions"
        public void FillDataSetByKeyWord(
            string ip_str_id_bo_tinh
            , string ip_str_id_dv_chu_quan
            , string ip_str_id_dv_su_dung
            , string ip_str_id_trang_thai
            , string ip_str_user_name
            , string ip_str_loai_hinh_dv
            , string ip_str_tu_khoa
            , DS_V_GD_KHAU_HAO_DM_DAT op_ds_v_gd_khau_hao_dm_dat)
        {
            CStoredProc v_obj_procedure = new CStoredProc("pr_V_GD_KHAU_HAO_DM_DAT_Load_data_to_grid_by_tu_khoa");
            v_obj_procedure.addDecimalInputParam("@ip_id_bo_tinh", ip_str_id_bo_tinh);
            v_obj_procedure.addDecimalInputParam("@ip_id_dv_chu_quan", ip_str_id_dv_chu_quan);
            v_obj_procedure.addDecimalInputParam("@ip_id_dv_su_dung", ip_str_id_dv_su_dung);
            v_obj_procedure.addDecimalInputParam("@ip_dc_id_trang_thai_dat", ip_str_id_trang_thai);
            v_obj_procedure.addNVarcharInputParam("@ip_str_user_name", ip_str_user_name);
            v_obj_procedure.addNVarcharInputParam("@ip_str_loai_hinh_don_vi", ip_str_loai_hinh_dv);
            v_obj_procedure.addNVarcharInputParam("@ip_str_tu_khoa", ip_str_tu_khoa);
            v_obj_procedure.fillDataSetByCommand(this, op_ds_v_gd_khau_hao_dm_dat);
        }
        #endregion
    }
}
