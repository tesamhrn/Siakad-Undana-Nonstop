using Siakad_Undana_Nonstop.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Siakad_Undana_Nonstop.FormsNilai
{
    public partial class FormTambahUbahNilai : BaseFormTambahUbah
    {
        public FormTambahUbahNilai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=DESKTOP-QTP4H8O;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Grade_Table VALUES(@Name,@NIM,@JK,@DateYear,@Angkatan)", connecting);
            cmd.Parameters.AddWithValue("@ID Semester", textBoxIdSemester.Text);
            cmd.Parameters.AddWithValue("@Kode Mata Kuliah", textBoxKodeMk.Text);
            cmd.Parameters.AddWithValue("@NIM", textBoxNim.Text);
            cmd.Parameters.AddWithValue("@Nilai Angka", textBoxNilaiAngka.Text);
            cmd.Parameters.AddWithValue("@Nilai Huruf", textBoxNilaiHuruf.Text);

            cmd.ExecuteNonQuery();

            connecting.Close();

            MessageBox.Show("Anda Telah menyimpan Data");
        }
    }
}
