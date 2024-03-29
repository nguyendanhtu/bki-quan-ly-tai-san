﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IP.Core.WinFormControls;
using IP.Core.IPCommon;
using IP.Core.IPBusinessService;
using IP.Core.IPData;
using IP.Core.IPUserService;
using WebDS.CDBNames;
using QltsForm;
using WebUS;
using WebDS;
using IP.Core.QltsFormControls;
using System.Threading;
public partial class BaoCao_F303_TH_tang_giam_tai_san_Chi__tiet_theo_tung_don_vi : System.Web.UI.Page
{
    #region Members

    #endregion

    #region private methods
    private void form_2_objExcelAssetParameters(CObjExcelAssetParameters op_obj_parameter)
    {
        op_obj_parameter.dcID_BO_TINH = CIPConvert.ToDecimal(m_cbo_bo_tinh.SelectedValue);
        op_obj_parameter.strTEN_BO_TINH = m_cbo_bo_tinh.SelectedItem.Text;
        op_obj_parameter.dcID_DON_VI_CHU_QUAN = CIPConvert.ToDecimal(m_cbo_don_vi_chu_quan.SelectedValue);
        op_obj_parameter.strTEN_DON_VI_CHU_QUAN = m_cbo_don_vi_chu_quan.SelectedItem.Text;
        op_obj_parameter.dcID_DON_VI_SU_DUNG = CONST_QLDB.ID_TAT_CA;
        op_obj_parameter.strTEN_DON_VI_SU_DUNG = CONST_QLDB.TAT_CA;
        op_obj_parameter.dcID_TRANG_THAI_TAI_SAN = CONST_QLDB.ID_TAT_CA;
        op_obj_parameter.strTEN_TRANG_THAI_TAI_SAN = CONST_QLDB.TAT_CA;
        op_obj_parameter.strKEY_SEARCH = String.Empty;
        op_obj_parameter.dcID_LOAI_TAI_SAN = CONST_QLDB.ID_TAT_CA;
        op_obj_parameter.strTEN_LOAI_TAI_SAN = CONST_QLDB.TAT_CA;
        op_obj_parameter.strLOAI_HINH_DON_VI = CONST_QLDB.TAT_CA;
        op_obj_parameter.strMA_LOAI_HINH_DON_VI = CONST_QLDB.TAT_CA;
        op_obj_parameter.strUSER_NAME = Person.get_user_name();
        op_obj_parameter.datDEN_NGAY = CIPConvert.ToDatetime(m_txt_den_ngay.Text);
        op_obj_parameter.datTU_NGAY = CIPConvert.ToDatetime(m_txt_tu_ngay.Text);
    }
    private void export_excel()
    {
        if (!check_validate_data_is_ok()) return;
        string v_str_output_file = "";
        F330_RPT_TANG_GIAM_TAI_SAN v_f330_tang_giam_tai_san = new F330_RPT_TANG_GIAM_TAI_SAN();
        CObjExcelAssetParameters v_obj_parameter = new CObjExcelAssetParameters();
        form_2_objExcelAssetParameters(v_obj_parameter);
        v_f330_tang_giam_tai_san.export_excel(
           F330_RPT_TANG_GIAM_TAI_SAN.TANG_GIAM_TAI_SAN.CHI_TIET_THEO_DON_VI
                                 , ref v_obj_parameter
                               );
        Response.Clear();
        v_str_output_file = "/QuanLyTaiSan/" + v_obj_parameter.strFILE_NAME_RESULT;
        Response.Redirect(v_str_output_file, false);
    }
    private void thongbao(string ip_str_thong_bao)
    {
        m_lbl_mess.Text = ip_str_thong_bao;
    }
    private void reset_thong_bao()
    {
        m_lbl_mess.Text = "";
    }
    private bool check_validate_data_is_ok()
    {
        if (m_txt_tu_ngay.Text.Equals(""))
        {
            m_txt_tu_ngay.Text = CIPConvert.ToStr("01/01/1900");
        }
        if (m_txt_den_ngay.Text.Equals(""))
        {
            m_txt_den_ngay.Text = CIPConvert.ToStr("01/01/3000");
        }
        if (!CValidateTextBox.IsValid(m_txt_tu_ngay, DataType.DateType, allowNull.YES))
        {
            thongbao("Bạn chưa nhập đúng Từ Ngày!");
            return false;
        }
        if (!CValidateTextBox.IsValid(m_txt_den_ngay, DataType.DateType, allowNull.YES))
        {
            thongbao("Bạn chưa nhập đúng Đến Ngày!");
            return false;
        }
        DateTime v_dat_tu_ngay = CIPConvert.ToDatetime(m_txt_tu_ngay.Text);
        DateTime v_dat_den_ngay = CIPConvert.ToDatetime(m_txt_den_ngay.Text);
        if (v_dat_den_ngay.CompareTo(v_dat_tu_ngay) < 0)
        {
            thongbao("Bạn nhập chưa đúng Từ Ngày, Đến Ngày!");
            return false;
        }

        return true;
    }
    private void load_data_to_grid_tai_san()
    {
        string v_str_user_name = Person.get_user_name();
        if (v_str_user_name.Equals("")) return;
        if (!check_validate_data_is_ok()) return;
        DS_RPT_TANG_GIAM_TAI_SAN v_ds_rpt_tang_giam_tai_san = new DS_RPT_TANG_GIAM_TAI_SAN();
        US_RPT_TANG_GIAM_TAI_SAN v_us_rpt_tang_giam_tai_san = new US_RPT_TANG_GIAM_TAI_SAN();
        v_us_rpt_tang_giam_tai_san.FillDataSet_chi_tiet_theo_don_vi(
            v_str_user_name
            , CIPConvert.ToDecimal(m_cbo_bo_tinh.SelectedValue)
            , CIPConvert.ToDecimal(m_cbo_don_vi_chu_quan.SelectedValue)
            , CIPConvert.ToDatetime(m_txt_tu_ngay.Text)
            , CIPConvert.ToDatetime(m_txt_den_ngay.Text)
            , v_ds_rpt_tang_giam_tai_san
            );
        m_grv_tai_san.DataSource = v_ds_rpt_tang_giam_tai_san.RPT_TANG_GIAM_TAI_SAN;
        m_grv_tai_san.DataBind();
    }
    #endregion

    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                WinFormControls.load_data_to_cbo_bo_tinh(
                    WinFormControls.eTAT_CA.YES
                    , m_cbo_bo_tinh
                    );
                WinFormControls.load_data_to_cbo_don_vi_chu_quan(
                    m_cbo_bo_tinh.SelectedValue
                    , WinFormControls.eTAT_CA.YES
                    , m_cbo_don_vi_chu_quan
                    );
                load_data_to_grid_tai_san();
            }
        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(this, ex);
        }
    }
    protected void m_cbo_bo_tinh_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            reset_thong_bao();
            WinFormControls.load_data_to_cbo_don_vi_chu_quan(
                m_cbo_bo_tinh.SelectedValue
                , WinFormControls.eTAT_CA.YES
                , m_cbo_don_vi_chu_quan
                );
            m_grv_tai_san.Visible = false;
        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(this, ex);
        }

    }
    protected void m_cmd_loc_du_lieu_Click(object sender, EventArgs e)
    {
        try
        {
            load_data_to_grid_tai_san();
            m_grv_tai_san.Visible = true;
        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(this, ex);
        }
    }
    protected void m_cmd_xuat_excel_Click(object sender, EventArgs e)
    {
        try
        {
            Thread.Sleep(1000);
            export_excel();
        }
        catch (System.Exception ex)
        {
            CSystemLog_301.ExceptionHandle(this, ex);
        }
    }

    #endregion
  
}