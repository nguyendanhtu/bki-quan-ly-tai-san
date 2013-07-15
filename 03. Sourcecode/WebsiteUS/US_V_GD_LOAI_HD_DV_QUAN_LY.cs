///************************************************
/// Generated by: LinhDH
/// Date: 21/03/2013 12:51:05
/// Goal: Create User Service Class for V_GD_LOAI_HD_DV_QUAN_LY
///************************************************
/// <summary>
/// Create User Service Class for V_GD_LOAI_HD_DV_QUAN_LY
/// </summary>

namespace WebUS
{
using WebDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


public class US_V_GD_LOAI_HD_DV_QUAN_LY : US_Object
{
	private const string c_TableName = "V_GD_LOAI_HD_DV_QUAN_LY";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_HOP_DONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_HOP_DONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_HOP_DONG"] = value;
		}
	}

	public bool IsID_LOAI_HOP_DONGNull()	{
		return pm_objDR.IsNull("ID_LOAI_HOP_DONG");
	}

	public void SetID_LOAI_HOP_DONGNull() {
		pm_objDR["ID_LOAI_HOP_DONG"] = System.Convert.DBNull;
	}

	public string strTEN_LOAI_HD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_LOAI_HD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_LOAI_HD"] = value;
		}
	}

	public bool IsTEN_LOAI_HDNull() 
	{
		return pm_objDR.IsNull("TEN_LOAI_HD");
	}

	public void SetTEN_LOAI_HDNull() {
		pm_objDR["TEN_LOAI_HD"] = System.Convert.DBNull;
	}

	public decimal dcID_DV_QUAN_LY 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DV_QUAN_LY", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DV_QUAN_LY"] = value;
		}
	}

	public bool IsID_DV_QUAN_LYNull()	{
		return pm_objDR.IsNull("ID_DV_QUAN_LY");
	}

	public void SetID_DV_QUAN_LYNull() {
		pm_objDR["ID_DV_QUAN_LY"] = System.Convert.DBNull;
	}

	public string strTEN_DV_QUAN_LY 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DV_QUAN_LY", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DV_QUAN_LY"] = value;
		}
	}

	public bool IsTEN_DV_QUAN_LYNull() 
	{
		return pm_objDR.IsNull("TEN_DV_QUAN_LY");
	}

	public void SetTEN_DV_QUAN_LYNull() {
		pm_objDR["TEN_DV_QUAN_LY"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_LOAI_HD_DV_QUAN_LY() 
	{
		pm_objDS = new DS_V_GD_LOAI_HD_DV_QUAN_LY();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_LOAI_HD_DV_QUAN_LY(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_LOAI_HD_DV_QUAN_LY(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_LOAI_HD_DV_QUAN_LY();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    #region Additional Function
    public void update_dv_quan_ly_loai_hd(decimal ip_dc_id_dv_quan_ly, string ip_str_loai_dh)
    {
        CStoredProc v_cstore = new CStoredProc("pr_V_GD_LOAI_HD_DV_QUAN_LY_Cap_Nhat_DV_Quan_Ly_Cho_Loai_HD");
        v_cstore.addDecimalInputParam("@ID_DV_QUAN_LY", ip_dc_id_dv_quan_ly);
        v_cstore.addNVarcharInputParam("@LIST_ID_LOAI_HD", ip_str_loai_dh);
        v_cstore.ExecuteCommand(this);
    }
    #endregion 
}
}
