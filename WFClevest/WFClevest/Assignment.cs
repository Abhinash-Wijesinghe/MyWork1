using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WFClevest
{
    /// <summary>
    /// The class of the GUI window.
    /// </summary>
    public partial class Assignment : Form
    {
        #region Variables
        // The Utility class to be used.
        private Classes.Utility utilityClass = new Classes.Utility();
        // The list to be used as the data source for the ListBox.
        private List<string> displayList = new List<string>();
        #endregion

        #region Methods
        /// <summary>
        /// Displays the results for question number 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// An input file should be selected in the file open dialog.
        /// </remarks>
        private void btnQ1Results_Click(object sender, EventArgs e)
        {
            CleanUpResults();

            string path = getSelectedFilename();
            if (path == "")
            {
                return;
            }
            string text = System.IO.File.ReadAllText(path);

            int floorNo = utilityClass.FindFloorNumber(text);

            displayList?.Add(floorNo >= 0 
                ? "Instructions take the worker to floor:" + floorNo.ToString() 
                : "Instructions take the worker to floor:" + floorNo.ToString() + " (basement Level)");

            lboxResults.DataSource  = displayList;
        }

        /// <summary>
        /// Displays the results for question number 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// An input file should be selected in the file open dialog.
        /// </remarks>
        private void btnQ2Results_Click(object sender, EventArgs e)
        {
            CleanUpResults();

            string path = getSelectedFilename();
            if (path == "")
            {
                return;
            }
            string text = System.IO.File.ReadAllText(path);

            int noOfHouses = utilityClass.FindHousesVisited(text);

            displayList?.Add("Number of houses have their meters read at least once = " + noOfHouses.ToString());

            lboxResults.DataSource = displayList;
        }

        /// <summary>
        /// Displays the results for question number 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// An input file should be selected in the file open dialog.
        /// </remarks>
        private void btnQ3Results_Click(object sender, EventArgs e)
        {
            CleanUpResults();

            string path = getSelectedFilename();
            if (path == "")
            {
                return;
            }
            string[] text = System.IO.File.ReadAllLines(path);

            int noOfStrings = utilityClass.FindGoodStringToImport(text);

            displayList?.Add("Number of good strings = " + noOfStrings.ToString());

            lboxResults.DataSource = displayList;
        }

        /// <summary>
        /// Displays the results for question number 4.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// An input file should be selected in the file open dialog.
        /// </remarks>
        private void btnQ4Results_Click(object sender, EventArgs e)
        {
            CleanUpResults();

            string path = getSelectedFilename();
            if (path == "")
            {
                return;
            }
            string[] text = System.IO.File.ReadAllLines(path);

            int value = utilityClass.FindOutput(text);

            // Work In Progress...



        }

        /// <summary>
        /// Gets the full path of the file selected.
        /// </summary>
        /// <returns>
        /// The full path of the file if selected by clicking OK button.
        /// </returns>
        private string getSelectedFilename()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
 
            return fileDialog.ShowDialog() == DialogResult.OK ? fileDialog.FileName : "";
        }

        /// <summary>
        /// Clean ups the result list and ListBox.
        /// </summary>
        private void CleanUpResults()
        {
            displayList.Clear();
            lboxResults.DataSource = null;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Instanciate new instance of the <see cref="Assignment" /> class.
        /// </summary>
        public Assignment()
        {
            InitializeComponent();
        }
        #endregion

    }
}
