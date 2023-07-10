using RunKeeper.Classes;
using RunKeeper.Views;

namespace RunKeeper
{
    public partial class RunKeeperMain : Form
    {
        public List<RunModel> runModels = new List<RunModel>();
        public List<ShoeModel> shoeModels = new List<ShoeModel>();

        #region Constructors
        public RunKeeperMain()
        {
            InitializeComponent();

            SetupRunDataGridView();
            SetupShoeDataGridView();
            
        }
        #endregion
        #region Setup View

        void SetupRunDataGridView()
        {
            runModels = RunModel.GetRuns();
            runDataGridView.DataSource = runModels;
        }
        void SetupShoeDataGridView()
        {
            shoeModels = ShoeModel.GetShoeModels();
            shoeDataGridView.DataSource = shoeModels;
        }

        #endregion
        #region Button Actions

        private void AddRunButtonClicked(object sender, EventArgs e)
        {
            RunEditView runEditView = new();
            runEditView.FormClosed += new FormClosedEventHandler(RunEditViewFormClosed);
            runEditView.Show();
        }

        private void AddShoesButtonClicked(object sender, EventArgs e)
        {
            ShoeEditView shoeEditView = new();
            shoeEditView.FormClosed += new FormClosedEventHandler(ShoeEditViewFormClosed);
            shoeEditView.Show();
        }

        #region Child Form Actions

        void ShoeEditViewFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {

        }

        void RunEditViewFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {

        }

        #endregion

        #endregion
    }
}