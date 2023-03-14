using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuanLyThuVien
{
    class clsConnect
    {
        SqlConnection con;
        string connect = "Data Source = SUMMERIST\\SQLEXPRESS; Initial Catalog = demoqltv1; Integrated Security = True";
        DataTable dt;
        public SqlConnection OpenConnect()
        {
            con = new SqlConnection(connect);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public SqlConnection CloseConnect()
        {
            con = new SqlConnection(connect);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }

        public DataTable LoadTheLoai()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("TheLoaiTen_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }

        public DataTable LoadTenSach()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("LoadTenSach", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }

        public DataTable LoadDataSach()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("Sach_LoadDL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }


        public DataTable LoadPhieuPhat()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("LoadPhieuPhat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }


        public DataTable LoadDataLuat()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("LuatTV_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }

        public DataTable LoadTraSach()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("LoadTraSach", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }

        public DataTable LoadDataReport()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("ThongKeSachMuonTra", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }

        public DataTable LoadDataTG()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("TacGia_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }

        public DataTable TimKiemTheoTen(string ChuoiTimKiem)
        {
            OpenConnect();
            dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sach_TimKiemSachTheoTen", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("TenSach", SqlDbType.NVarChar)).Value = ChuoiTimKiem;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }


        public DataTable LoadDangNhap()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("LoadDangNhap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }

        public DataTable LoadDocGia()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("DocGia_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
        public DataTable TimKiemTenDocGia(string ChuoiTimKiem)
        {
            OpenConnect();
            dt = new DataTable();
            SqlCommand cmd = new SqlCommand("DocGia_TimKiemTheoTen", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("Tendocgia", SqlDbType.NVarChar)).Value = ChuoiTimKiem;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }

        public DataSet LoadDocGiaToDT(string ChuoiTimKiem)
        {
            DataSet ds = new DataSet();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("DocGia_LoadDT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("DocgiaID", SqlDbType.NVarChar)).Value = ChuoiTimKiem;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            CloseConnect();
            return ds;
        }

        public DataSet LoadDocGiaToTraSach(string ChuoiTimKiem)
        {
            DataSet ds = new DataSet();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("TraSach_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("DocgiaID", SqlDbType.NVarChar)).Value = ChuoiTimKiem;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            CloseConnect();
            return ds;
        }

        public DataSet MuonSach_Load(string ChuoiTimKiem)
        {
            DataSet ds = new DataSet();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("MuonSach_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("DocgiaID", SqlDbType.NVarChar)).Value = ChuoiTimKiem;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            CloseConnect();
            return ds;
        }
    }
}
