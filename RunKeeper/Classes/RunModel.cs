namespace RunKeeper.Classes
{
    public class RunModel
    {
        DateTime RunDate { get; set; }
        double Distance { get; set; }
        int Duration { get; set; }
        int Pace { get; set; }
        int ElevationGain { get; set; }
        int AverageHR { get; set; }
        int Temperature { get; set; }
        int Humidity { get; set; }
        string Notes { get; set; }
        ShoeModel ShoesUsed { get; set; }

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
    }
}
