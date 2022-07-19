using RunKeeper.Classes;

namespace RunKeeper.Views
{
    public partial class RunEditView : Form
    {
        RunModel editRunModel;

        #region Constructors
        public RunEditView()
        {
            InitializeComponent();

            editRunModel = new RunModel();
        }
        public RunEditView(RunModel existingRun)
        {
            editRunModel = new RunModel(existingRun);
        }
        #endregion
    }
}
