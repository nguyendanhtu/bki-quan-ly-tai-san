﻿using System;
using System.Collections.Generic;
using WebDS;
using WebUS;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IP.Core.IPCommon;
using IP.Core.IPBusinessService;
using IP.Core.IPData;
using IP.Core.IPUserService;
using WebDS.CDBNames;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            load_data();
        }

    }

    #region member
    DS_CM_DM_TU_DIEN m_ds_dm_tu_dien = new DS_CM_DM_TU_DIEN();
    US_CM_DM_TU_DIEN m_us_dm_tu_dien = new US_CM_DM_TU_DIEN();

    DS_DM_DON_VI m_ds_dm_don_vi = new DS_DM_DON_VI();
    US_DM_DON_VI m_us_dm_don_vi = new US_DM_DON_VI();

    DS_DM_DAT m_ds_dm_dat = new DS_DM_DAT();
    US_DM_DAT m_us_dm_dat = new US_DM_DAT();

    DS_DM_NHA m_ds_dm_nha = new DS_DM_NHA();
    US_DM_NHA m_us_dm_nha = new US_DM_NHA();




    #endregion

    #region private method

    private void load_data_to_grid()
    {

    }

    private void load_data_to_cbo_bo_tinh()
    {
        try
        {
            m_us_dm_don_vi.FillDataset(m_ds_dm_don_vi, "Where id_loai_don_vi=574");
            m_cbo_bo_tinh.DataSource = m_ds_dm_don_vi.DM_DON_VI;
            m_cbo_bo_tinh.DataValueField = CIPConvert.ToStr(DM_DON_VI.ID);
            m_cbo_bo_tinh.DataTextField = CIPConvert.ToStr(DM_DON_VI.TEN_DON_VI);
            m_cbo_bo_tinh.DataBind();
        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(ex);
        }
    }

    private void load_data_to_cbo_don_vi_chu_quan()
    {
        string v_id_bo_tinh = m_cbo_bo_tinh.SelectedValue;
        m_us_dm_don_vi.FillDataset(m_ds_dm_don_vi, "where ID_LOAI_DON_VI = 575 and ID_DON_VI_CAP_TREN LIKE '%"
            + v_id_bo_tinh + "%'");
        m_cbo_don_vi_chu_quan.DataSource = m_ds_dm_don_vi.DM_DON_VI;
        m_cbo_don_vi_chu_quan.DataTextField = "TEN_DON_VI";
        m_cbo_don_vi_chu_quan.DataValueField = "ID";
        m_cbo_don_vi_chu_quan.DataBind();
        m_cbo_don_vi_chu_quan.Items.Insert(0, new ListItem("Tất cả đơn vị trực thuộc", ""));
    }
    private void load_data_to_cbo_don_vi_su_dung()
    {
        US_DM_DON_VI v_us_dm_don_vi = new US_DM_DON_VI();
        DS_DM_DON_VI v_ds_dm_don_vi = new DS_DM_DON_VI();

        string v_id_don_vi_chu_quan = m_cbo_don_vi_chu_quan.SelectedValue;
        v_us_dm_don_vi.FillDataset(v_ds_dm_don_vi, "where ID_LOAI_DON_VI = 576 and ID_DON_VI_CAP_TREN LIKE '%" + v_id_don_vi_chu_quan
            + "%'");
        m_cbo_don_vi_su_dung_tai_san.DataSource = v_ds_dm_don_vi.DM_DON_VI;
        m_cbo_don_vi_su_dung_tai_san.DataTextField = "TEN_DON_VI";
        m_cbo_don_vi_su_dung_tai_san.DataValueField = "ID";
        m_cbo_don_vi_su_dung_tai_san.DataBind();
    }


    private void load_data()
    {
        try
        {
            load_data_to_cbo_bo_tinh();
            load_data_to_cbo_don_vi_chu_quan();
            load_data_to_cbo_don_vi_su_dung();
            load_data_to_grid_nha();

        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(ex);
        }
    }
    private void load_data_to_grid_nha()
    {
        try
        {
            string v_id_don_vi_su_dung = m_cbo_don_vi_su_dung_tai_san.SelectedValue;
            m_us_dm_nha.FillDataset(m_ds_dm_nha, "where id_don_vi_su_dung like '%" + v_id_don_vi_su_dung + "%'");
            m_grv_nha.DataSource = m_ds_dm_nha.DM_NHA;
            m_grv_nha.DataBind();
        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(ex);
        }
    }


    #endregion


    protected void m_cbo_bo_tinh_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            load_data_to_cbo_don_vi_chu_quan();
        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(ex);
        }
    }
    protected void m_cbo_don_vi_chu_quan_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            load_data_to_cbo_don_vi_chu_quan();
        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(ex);
        }

    }
    protected void m_cbo_don_vi_su_dung_tai_san_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            load_data_to_cbo_don_vi_su_dung();
        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(ex);
        }
    }

    protected void m_cmd_loc_du_lieu_Click(object sender, EventArgs e)
    {
        try
        {
            load_data_to_grid_nha();
        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(ex);
        }
    }

 
}