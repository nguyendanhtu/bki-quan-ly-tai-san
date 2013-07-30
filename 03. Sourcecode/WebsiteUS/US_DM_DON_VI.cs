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
    }
}
