using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity;

namespace DAL
{
  public  class tempService
    {
       
        public List<VariableValues> GetTempValues(string start,string end)
        {
            string sql = "select * from TemperaTureMeasure  ";
        
                sql += "   where 1=1 and InsertTime between '{0}' and '{1}' order by InsertTime DESC";


          sql=  string.Format(sql, start, end);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<VariableValues> listVar = new List<VariableValues>();
            while (objReader.Read())
            {
                listVar.Add(new VariableValues()
                {
                    Q3TempPv = Convert.ToSingle(objReader["Q3TempPv"]),
                    Q5UPTempPv = Convert.ToSingle(objReader["Q5UPTempPv"]),
                    Q5DownTempPv = Convert.ToSingle(objReader["Q5DownTempPv"]),
                    Q6UPTempPv = Convert.ToSingle(objReader["Q6UPTempPv"]),
                    Q6DownTempPv = Convert.ToSingle(objReader["Q6DownTempPv"]),
                    Q7UPTempPv = Convert.ToSingle(objReader["Q7UPTempPv"]),
                    Q7DownTempPv = Convert.ToSingle(objReader["Q7DownTempPv"]),
                    Q9UPTempPv = Convert.ToSingle(objReader["Q9UPTempPv"]),
                    Q9DownTempPv = Convert.ToSingle(objReader["Q9DownTempPv"]),
                    Q10UPTempPv = Convert.ToSingle(objReader["Q10UPTempPv"]),
                    Q10DownTempPv = Convert.ToSingle(objReader["Q10DownTempPv"]),
                    Q11UPTempPv = Convert.ToSingle(objReader["Q11UPTempPv"]),
                    Q11DownTempPv = Convert.ToSingle(objReader["Q11DownTempPv"]),
                    FHeatingTempPv = Convert.ToSingle(objReader["FHeatingTempPv"]),
                    BHeatingTempPv = Convert.ToSingle(objReader["BHeatingTempPv"]),
                    SpareHeatingTempPv = Convert.ToSingle(objReader["SpareHeatingTempPv"]),
                    Furnace1TempPv = Convert.ToSingle(objReader["Furnace1TempPv"]),
                    Furnace2TempPv = Convert.ToSingle(objReader["Furnace2TempPv"]),
                    Furnace3TempPv = Convert.ToSingle(objReader["Furnace3TempPv"]),
                    Q3MoldsTempPv = Convert.ToSingle(objReader["Q3MoldsTempPv"]),
                    Q5MoldsTempPv = Convert.ToSingle(objReader["Q5MoldsTempPv"]),
                    Q6MoldsTempPv = Convert.ToSingle(objReader["Q6MoldsTempPv"]),
                    Q7MoldsTempPv = Convert.ToSingle(objReader["Q7MoldsTempPv"]),
                    Q12MoldsTempPv = Convert.ToSingle(objReader["Q12MoldsTempPv"]),
                    APhaseCurrentPv = Convert.ToSingle(objReader["APhaseCurrentPv"]),
                    BPhaseCurrentPv = Convert.ToSingle(objReader["BPhaseCurrentPv"]),
                    CPhaseCurrentPv = Convert.ToSingle(objReader["CPhaseCurrentPv"]),
                    HighFrequency1TempPv = Convert.ToSingle(objReader["HighFrequency1TempPv"]),
                    HighFrequency1UpTempPv = Convert.ToSingle(objReader["HighFrequency1UpTempPv"]),
                    HighFrequency1DownTempPv = Convert.ToSingle(objReader["HighFrequency1DownTempPv"]),
                    CoolingWaterFlowPv = Convert.ToSingle(objReader["CoolingWaterFlowPv"]),
                    CoolingWaterTmepPv = Convert.ToSingle(objReader["CoolingWaterTmepPv"]),
                    InsertTime = objReader["InsertTime"].ToString(),             
                });
            }
            objReader.Close();
            return listVar;
        }
    }
}
