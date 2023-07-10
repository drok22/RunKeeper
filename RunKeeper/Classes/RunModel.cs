using MySql.Data.MySqlClient;

namespace RunKeeper.Classes
{
    public class RunModel
    {
        private const double MILES_DIVIDER = 1.60934449;

        #region Properties
        public int RunID { get; set; }
        public DateTime RunDate { get; set; }
        public double Distance { get; set; }
        public int Duration { get; set; }
        public double Pace { get; set; }
        public int ElevationGain { get; set; }
        public int AverageHR { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public string Notes { get; set; }
        public ShoeModel ShoesUsed { get; set; }

        #endregion

        #region Display Values
        public double DistanceInMi
        {
            get { return Distance/MILES_DIVIDER; }
        }
        public string DurationDisplay
        {
            get { return Duration.ToString(); }
        }
        public string PaceDisplay
        {
            get { return DisplayTime(Duration); }
        }
        #endregion

        #region Constructors
        public RunModel()
        {
            RunDate = DateTime.Now;
            Distance = 0.0;
            Duration = 0;
            Pace = 0;
            ElevationGain = 0;
            AverageHR = 0;
            Temperature = 0;
            Humidity = 0;
            Notes = "";
            ShoesUsed = new ShoeModel();
        }
        public RunModel(RunModel existingRun)
        {
            RunDate = existingRun.RunDate;
            Distance = existingRun.Distance;
            Duration = existingRun.Duration;
            Pace = existingRun.Pace;
            ElevationGain = existingRun.ElevationGain;
            AverageHR = existingRun.AverageHR;
            Temperature = existingRun.Temperature;
            Humidity = existingRun.Humidity;
            Notes = existingRun.Notes;
            ShoesUsed = existingRun.ShoesUsed;
        }
        #endregion

        #region Calculations
        static public double CalculatePace(RunModel runModel)
        {
            double paceInMetersPerSecond = (runModel.Duration/1000) / (runModel.Distance);

            return paceInMetersPerSecond;
        }
        static public string DisplayTime(int Duration) 
        {
            return TimeSpan.FromSeconds(Duration / 1000).ToString();
        }

        #endregion

        #region Static Methods

        public static List<RunModel> GetRuns(/*TODO: create parameters*/)
        {
            string runQuery = "select * from run";

            List<RunModel> runModels = new List<RunModel>();
            MySqlConnection connection = new MySqlConnection(MYSQLHelper.CONNECTIONSTRING);
            connection.Open();
            MySqlCommand runQueryCommand = new MySqlCommand(runQuery, connection);
            MySqlDataReader dataReader = runQueryCommand.ExecuteReader();

            runModels.Clear();
            while (dataReader.Read())
            {
                RunModel runModel = new RunModel();
                runModel.RunID = Convert.ToInt32(dataReader["run_id"]);
                runModel.RunDate = Convert.ToDateTime(dataReader["date"]);
                runModel.Distance = Convert.ToDouble(dataReader["distance_in_m"]);
                runModel.Duration = Convert.ToInt32(dataReader["duration_in_ms"]);
                runModel.ElevationGain = Convert.ToInt32(dataReader["elevation_gain_in_m"]);
                runModel.AverageHR = Convert.ToInt32(dataReader["avg_hr"]);
                runModel.Temperature = Convert.ToInt32(dataReader["temperature_in_c"]);
                runModel.Humidity = Convert.ToInt32(dataReader["humidity"]);
                runModel.Notes = dataReader["notes"].ToString();

                // TODO: write the GetShoe method into ShoeModel.
                // TODO: can we just loop to find shoes instead, since we're already querying?
                //runModel.ShoesUsed = ShoeModel.GetShoe(dataReader["shoe_id"].ToString());
                
                runModel.Pace = RunModel.CalculatePace(runModel);
                string testString = DisplayTime(runModel.Duration);
                runModels.Add(runModel);
            }

            return runModels;
        }

        #endregion
    }
}
