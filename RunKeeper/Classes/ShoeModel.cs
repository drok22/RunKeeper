using MySql.Data.MySqlClient;

namespace RunKeeper.Classes
{
    public class ShoeModel
    {
        public int ShoeId { get; set; }
        public string ShoeName { get; set; }
        public double KilometersRun { get; set; }
        public string Brand { get; set; }


        #region Constructors
        public ShoeModel()
        {
            ShoeName = "";
            Brand = "";
            KilometersRun = 0.0;
        }
        public ShoeModel(ShoeModel existingShoe)
        {
            Brand = existingShoe.Brand;
            ShoeName = existingShoe.ShoeName;
            KilometersRun = existingShoe.KilometersRun;
        }
        #endregion

        #region static methods

        public static List<ShoeModel> GetShoeModels(/*TODO: create parameters*/)
        {
            string shoeQuery = "select * from shoe";

            List<ShoeModel> shoeModels = new List<ShoeModel>();
            MySqlConnection connection = new MySqlConnection(MYSQLHelper.CONNECTIONSTRING);
            connection.Open();
            MySqlCommand shoeQueryCommand = new MySqlCommand(shoeQuery, connection);
            MySqlDataReader dataReader = shoeQueryCommand.ExecuteReader();

            shoeModels.Clear();
            while (dataReader.Read())
            {
                ShoeModel shoeModel = new ShoeModel();
                shoeModel.ShoeId = Convert.ToInt32(dataReader["shoe_id"]);
                shoeModel.ShoeName = dataReader["name"].ToString();
                shoeModel.Brand = dataReader["brand"].ToString();
                shoeModel.KilometersRun = Convert.ToInt32(dataReader["km_run"]);

                shoeModels.Add(shoeModel);
            }

            return shoeModels;
        }

        #endregion
    }
}
