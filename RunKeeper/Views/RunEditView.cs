using MySql.Data.MySqlClient;
using RunKeeper.Classes;

namespace RunKeeper.Views
{
    public partial class RunEditView : Form
    {
        public RunModel editRunModel;



        #region Constructors
        public RunEditView()
        {
            InitializeComponent();

            
            editRunModel = new RunModel();

            runModelBindingSource.DataSource = editRunModel;
        }
        public RunEditView(RunModel existingRun)
        {
            InitializeComponent();


            editRunModel = new RunModel(existingRun);

            runModelBindingSource.DataSource = editRunModel;
        }
        #endregion

        private void RunEditView_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
