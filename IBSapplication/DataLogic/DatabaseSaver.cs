using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  DTOLogic;
using Interfaces;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataLogic
{
    class DatabaseSaver : IDatabaseSaver
    {
        private SqlCommand command;
        private SqlConnection connection;
       
        
        public DatabaseSaver()
        {
            connection = new SqlConnection(@"Data Source=st-i4dab.uni.au.dk ;Initial Catalog=E18ST3PRJ3Gr4;Integrated Security=False;User ID=E18ST3PRJ3Gr4;Password=E18ST3PRJ3Gr4 ;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        }

        public void SaveToDatabase(DTO_SaveData basicData, List<double> processedDataList)
        {
            connection.Open();

            command = new SqlCommand("INSERT INTO OperationsData (CPR, FullName, Date, StaffID, BloodPressureData)" + "VALUES (@CPR, @FullName, @Date, @StaffID, @BloodPressureData)", connection);

            command.Parameters.AddWithValue("@CPR", basicData.CPRnumber);
            command.Parameters.AddWithValue("@FullName", basicData.fullName);
            command.Parameters.AddWithValue("@Date", basicData.date);
            command.Parameters.AddWithValue("@StaffID", basicData.staffID);
            command.Parameters.AddWithValue("@BloodPressureData", processedDataList); //måske skal den gemme i en seperat tabel
          

        }
    }
}
