namespace RunKeeper.Classes
{
    public class ShoeModel
    {
        string ShoeName { get; set; }
        double MilesRun { get; set; }

        #region Constructors
        public ShoeModel()
        {
            ShoeName = "";
            MilesRun = 0.0;
        }
        public ShoeModel(ShoeModel existingShoe)
        {
            ShoeName = existingShoe.ShoeName;
            MilesRun = existingShoe.MilesRun;
        }
        #endregion
    }
}
