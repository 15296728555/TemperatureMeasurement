using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity;

namespace DAL
{
  public  class TempService
    {
       
        
        
        public List<VariableValues> GetTempValues(string start,string end,string formula ,float height )
        {
            string sql;
            if (formula.Length<2&&height.ToString().Length<1)
            {
              sql = "select * from TemperaTureMeasure  ";

                sql += "   where 1=1 and InsertTime between '{0}' and '{1}' order by InsertTime DESC";
                sql = string.Format(sql,  start, end);
            }
            else if(formula.Length < 2 && height.ToString().Length >= 1)
            {
                sql = "select * from TemperaTureMeasure  ";

                sql += "   where TravelHeight>  {0} and InsertTime between '{1}' and '{2}' order by InsertTime DESC";
                sql = string.Format(sql,  height, start, end);

            }


            else 
            {
                sql = "select * from TemperaTureMeasure  ";
                sql += "   where  InsertTime between '{0}' and '{1}' ";
               
                sql += " and  formula= '{2}'  order by InsertTime DESC ";
                sql = string.Format(sql,  start, end, formula);
            }
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<VariableValues> listVar = new List<VariableValues>();
            while (objReader.Read())
            {
                listVar.Add(new VariableValues()
                {
                    Q3TempPv = objReader["Q3TempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q3TempPv"]),
                    Q5UPTempPv = objReader["Q5UPTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q5UPTempPv"]),
                    Q5DownTempPv = objReader["Q5DownTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q5DownTempPv"]),
                    Q6UPTempPv = objReader["Q6UPTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q6UPTempPv"]),
                    Q6DownTempPv = objReader["Q6DownTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q6DownTempPv"]),
                    Q7UPTempPv = objReader["Q7UPTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q7UPTempPv"]),
                    Q7DownTempPv = objReader["Q7DownTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q7DownTempPv"]),
                    Q9UPTempPv = objReader["Q9UPTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q9UPTempPv"]),
                    Q9DownTempPv = objReader["Q9DownTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q9DownTempPv"]),
                    Q10UPTempPv = objReader["Q10UPTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q10UPTempPv"]),
                    Q10DownTempPv = objReader["Q10DownTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q10DownTempPv"]),
                    Q11UPTempPv = objReader["Q11UPTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q11UPTempPv"]),
                    Q11DownTempPv = objReader["Q11DownTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q11DownTempPv"]),
                    FHeatingTempPv = objReader["FHeatingTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["FHeatingTempPv"]),
                    BHeatingTempPv = objReader["BHeatingTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["BHeatingTempPv"]),
                    SpareHeatingTempPv = objReader["SpareHeatingTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["SpareHeatingTempPv"]),
                    Furnace1TempPv = objReader["Furnace1TempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Furnace1TempPv"]),
                    Furnace2TempPv = objReader["Furnace2TempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Furnace2TempPv"]),
                    Furnace3TempPv = objReader["Furnace3TempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Furnace3TempPv"]),
                    Q3MoldsTempPv = objReader["Q3MoldsTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q3MoldsTempPv"]),
                    Q5MoldsTempPv = objReader["Q5MoldsTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q5MoldsTempPv"]),
                    Q6MoldsTempPv = objReader["Q6MoldsTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q6MoldsTempPv"]),
                    Q7MoldsTempPv = objReader["Q7MoldsTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q7MoldsTempPv"]),
                    Q12MoldsTempPv = objReader["Q12MoldsTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["Q12MoldsTempPv"]),
                    APhaseCurrentPv = objReader["APhaseCurrentPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["APhaseCurrentPv"]),
                    BPhaseCurrentPv = objReader["BPhaseCurrentPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["BPhaseCurrentPv"]),
                    CPhaseCurrentPv = objReader["CPhaseCurrentPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["CPhaseCurrentPv"]),
                    HighFrequency1TempPv = objReader["HighFrequency1TempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["HighFrequency1TempPv"]),
                    HighFrequency1UpTempPv = objReader["HighFrequency1UpTempPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["HighFrequency1UpTempPv"]),
                    HighFrequency1DownTempPv = objReader["CoolingWaterFlowPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["HighFrequency1DownTempPv"]),
                    CoolingWaterFlowPv = objReader["CoolingWaterFlowPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["CoolingWaterFlowPv"]),
                
                    CoolingWaterTmepPv =objReader["CoolingWaterTmepPv"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["CoolingWaterTmepPv"]),
                    InsertTime = objReader["InsertTime"].ToString(),
                    Formula = objReader["Formula"].ToString(),
                    TravelHeight= objReader["TravelHeight"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["TravelHeight"]),
                    RunTime = objReader["RunTime"] is DBNull ? Convert.ToSingle(0.0) : Convert.ToSingle(objReader["RunTime"]),


                });
            }
            objReader.Close();
            return listVar;
        }


        public List<AlarmInfo> GetAlarmInfoValues(string start, string end)
        {
               string sql;         
                sql = "select * from AlarmData  ";
                sql += "   where 1=1  and InsertTime between '{0}' and '{1}' order by InsertTime DESC";
                sql = string.Format(sql, start, end);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<AlarmInfo> listVar = new List<AlarmInfo>();
            while (objReader.Read())
            {
                listVar.Add(new AlarmInfo()
                {
                   InsertTime=objReader["InsertTime"].ToString(),
                    VarName= objReader["VarName"].ToString(),
                    AlarmState = objReader["AlarmState"].ToString(),
                    AlarmValue = objReader["AlarmValue"].ToString(),
                    Priority= Convert.ToInt32(objReader["Priority"]),
                    Note = objReader["Note"].ToString(),
                    Operator= objReader["Operator"].ToString(),
                    AlarmImage= objReader["AlarmImage"].ToString(),
                });
            }
            objReader.Close();
            return listVar;
        }

    }
}
