namespace RunKeeper.Classes
{
    public class MYSQLHelper
    {
        public const string SERVER = "localhost";
        public const string DATABASE = "runkeeper";
        public const string USERNAME = "root";
        public const string PASSWORD = "password";
        public const string CONNECTIONSTRING = "SERVER=" + SERVER + ";" +
                                                "DATABASE=" + DATABASE + ";" +
                                                "UID=" + USERNAME + ";" +
                                                "PASSWORD=" + PASSWORD + ";";


        //TODO: place convenience methods here.
        //TODO: possibly hold a copy of this class to maintain a DATABASE connection.
    }
}
