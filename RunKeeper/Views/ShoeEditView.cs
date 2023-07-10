using RunKeeper.Classes;

namespace RunKeeper.Views
{
    public partial class ShoeEditView : Form
    {
        private ShoeModel editShoeModel;

        #region Constructors
        public ShoeEditView()
        {
            InitializeComponent();

            editShoeModel = new ShoeModel();
        }
        public ShoeEditView(ShoeModel existingShoe)
        {
            editShoeModel = new ShoeModel(existingShoe);
        }
        #endregion

        private void ShoeEditView_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
