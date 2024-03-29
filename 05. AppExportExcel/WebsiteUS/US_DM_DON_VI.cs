///************************************************
/// Generated by: MinhNN
/// Date: 30/07/2013 10:43:33
/// Goal: Create User Service Class for DM_DON_VI
///************************************************
/// <summary>
/// Create User Service Class for DM_DON_VI
/// </summary>

using System;
using WebDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using WebDS;
using WebDS.CDBNames;


namespace WebUS
{

    public class US_DM_DON_VI : US_Object
    {

        private const string c_TableName = "DM_DON_VI";
        #region "Public Properties"
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

        public string strMA_DON_VI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_DON_VI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_DON_VI"] = value;
            }
        }

        public bool IsMA_DON_VINull()
        {
            return pm_objDR.IsNull("MA_DON_VI");
        }

        public void SetMA_DON_VINull()
        {
            pm_objDR["MA_DON_VI"] = System.Convert.DBNull;
        }

        public string strTEN_DON_VI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DON_VI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DON_VI"] = value;
            }
        }

        public bool IsTEN_DON_VINull()
        {
            return pm_objDR.IsNull("TEN_DON_VI");
        }

        public void SetTEN_DON_VINull()
        {
            pm_objDR["TEN_DON_VI"] = System.Convert.DBNull;
        }

        public string strLOAI_HINH_DON_VI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LOAI_HINH_DON_VI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LOAI_HINH_DON_VI"] = value;
            }
        }

        public bool IsLOAI_HINH_DON_VINull()
        {
            return pm_objDR.IsNull("LOAI_HINH_DON_VI");
        }

        public void SetLOAI_HINH_DON_VINull()
        {
            pm_objDR["LOAI_HINH_DON_VI"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_DON_VI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_DON_VI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_DON_VI"] = value;
            }
        }

        public bool IsID_LOAI_DON_VINull()
        {
            return pm_objDR.IsNull("ID_LOAI_DON_VI");
        }

        public void SetID_LOAI_DON_VINull()
        {
            pm_objDR["ID_LOAI_DON_VI"] = System.Convert.DBNull;
        }

        public decimal dcID_DON_VI_CAP_TREN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_CAP_TREN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI_CAP_TREN"] = value;
            }
        }

        public bool IsID_DON_VI_CAP_TRENNull()
        {
            return pm_objDR.IsNull("ID_DON_VI_CAP_TREN");
        }

        public void SetID_DON_VI_CAP_TRENNull()
        {
            pm_objDR["ID_DON_VI_CAP_TREN"] = System.Convert.DBNull;
        }

        public decimal dcSTT
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "STT", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["STT"] = value;
            }
        }

        public bool IsSTTNull()
        {
            return pm_objDR.IsNull("STT");
        }

        public void SetSTTNull()
        {
            pm_objDR["STT"] = System.Convert.DBNull;
        }

        public decimal dcLEVEL_MODE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "LEVEL_MODE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["LEVEL_MODE"] = value;
            }
        }

        public bool IsLEVEL_MODENull()
        {
            return pm_objDR.IsNull("LEVEL_MODE");
        }

        public void SetLEVEL_MODENull()
        {
            pm_objDR["LEVEL_MODE"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_DM_DON_VI()
        {
            pm_objDS = new DS_DM_DON_VI();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_DM_DON_VI(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_DM_DON_VI(decimal i_dbID)
        {
            pm_objDS = new DS_DM_DON_VI();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion


        #region Addtional
        public bool check_is_having_ma_don_vi(string ip_str_ma_don_vi)
        {
            DS_DM_DON_VI v_ds_dm_don_vi = new DS_DM_DON_VI();
            CStoredProc v_cstore = new CStoredProc("pr_DM_DON_VI_check_ma_don_vi");
            v_cstore.addNVarcharInputParam("@ip_str_ma_don_vi", ip_str_ma_don_vi);
            v_cstore.fillDataSetByCommand(this, v_ds_dm_don_vi);
            if (v_ds_dm_don_vi.DM_DON_VI.Rows.Count == 0)
                return false;
            return true;
        }
        public bool InitUSWithIDIsOK(decimal ip_dc_id_don_vi) {
            pm_objDS = new DS_DM_DON_VI();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", ip_dc_id_don_vi, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            if (pm_objDS.Tables[pm_strTableName].Rows.Count == 0) return false ;
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
            return true;
        }

        public void FillDatasetByQueryString(
            WebDS.DS_DM_DON_VI op_ds_don_vi
            , string v_dc_id_loai_don_vi)
        {
            CStoredProc cstored = new CStoredProc("pr_DM_DON_VI_grid");
            cstored.addDecimalInputParam("@ID_LOAI_DON_VI", v_dc_id_loai_don_vi);
            cstored.fillDataSetByCommand(this, op_ds_don_vi);
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="op_ds_don_vi"></param>
        /// <param name="ip_dc_id_loai_don_vi"></param>
        /// <param name="ip_dc_id_don_vi"></param>
        /// <param name="ip_dc_id_don_vi_cap_tren1"></param>
        /// <param name="ip_dc_id_don_vi_cap_tren2"></param>
        /// <param name="ip_str_user_name"></param>
        public void FillDataset(
            WebDS.DS_DM_DON_VI op_ds_don_vi
            , decimal ip_dc_id_loai_don_vi

            , decimal ip_dc_id_don_vi_cap_tren1
            , decimal ip_dc_id_don_vi_cap_tren2
            , string ip_str_user_name)
        {
            CStoredProc cstored = new CStoredProc("pr_DM_DON_VI_Select_by_user_name");
            cstored.addNVarcharInputParam("@ip_str_user_name", ip_str_user_name);
            cstored.addDecimalInputParam("@ip_dc_loai_don_vi", ip_dc_id_loai_don_vi);

            cstored.addDecimalInputParam("@ip_dc_id_dv_cap_tren1", ip_dc_id_don_vi_cap_tren1);
            cstored.addDecimalInputParam("@ip_dc_id_dv_cap_tren2", ip_dc_id_don_vi_cap_tren2);
            cstored.fillDataSetByCommand(this, op_ds_don_vi);
        }
        public void FillDataset(
           DS_DM_DON_VI op_ds_don_vi
           , decimal ip_dc_id_loai_don_vi
           , decimal ip_dc_id_don_vi_cap_tren1
           , decimal ip_dc_id_don_vi_cap_tren2
           , string ip_str_loai_hinh_don_vi
           , string ip_str_user_name
           )
        {
            CStoredProc v_obj_procedure = new CStoredProc("pr_DM_DON_VI_loai_hinh_don_vi_Select_by_user_name");
            v_obj_procedure.addNVarcharInputParam("@ip_str_user_name", ip_str_user_name);
            v_obj_procedure.addDecimalInputParam("@ip_dc_loai_don_vi", ip_dc_id_loai_don_vi);
            v_obj_procedure.addDecimalInputParam("@ip_dc_id_dv_cap_tren1", ip_dc_id_don_vi_cap_tren1);
            v_obj_procedure.addDecimalInputParam("@ip_dc_id_dv_cap_tren2", ip_dc_id_don_vi_cap_tren2);
            v_obj_procedure.addNVarcharInputParam("@ip_str_loai_hinh_don_vi", ip_str_loai_hinh_don_vi);
            v_obj_procedure.fillDataSetByCommand(this, op_ds_don_vi);
        }
        public void FillDataset_Load_data_to_grid_danh_muc_don_vi(
          DS_DM_DON_VI op_ds_don_vi
            , decimal v_dc_id_loai_don_vi
            , string v_str_user_name
            )
        {
            CStoredProc cstored = new CStoredProc("pr_DM_DON_VI_Load_to_grid_danh_muc");
            cstored.addDecimalInputParam("@ip_dc_loai_don_vi", v_dc_id_loai_don_vi);
            cstored.addNVarcharInputParam("@ip_str_user_name", v_str_user_name);
            cstored.fillDataSetByCommand(this, op_ds_don_vi);
        }
        public void FillDataset(
            decimal ip_id_user_group
            , bool is_user_group_using_data
            , DS_DM_DON_VI op_ds_don_vi)
        {

            string v_str_sql_condition = " WHERE " + DM_DON_VI.ID;


            if (is_user_group_using_data)
            {
                v_str_sql_condition += " IN (SELECT ID_DON_VI FROM HT_QUAN_HE_SU_DUNG_DU_LIEU WHERE ID_USER_GROUP =" + ip_id_user_group.ToString() + ")";
            }
            else
            {
                v_str_sql_condition += " NOT IN (SELECT ID_DON_VI FROM HT_QUAN_HE_SU_DUNG_DU_LIEU WHERE ID_USER_GROUP =" + ip_id_user_group.ToString() + ")";
            }
            this.FillDataset(op_ds_don_vi, v_str_sql_condition);
        }

        #endregion
    }
}
