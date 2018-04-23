using System.Windows.Controls;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;

namespace DXPivotGrid_SortByGrandTotals {
    public partial class MainPage : UserControl {
        string dataFileName = "DXPivotGrid_SortByGrandTotals.nwind.xml";
        public MainPage() {
            InitializeComponent();

            // Parses an XML file and creates a collection of data items.
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(dataFileName);
            XmlSerializer s = new XmlSerializer(typeof(OrderData));
            object dataSource = s.Deserialize(stream);

            // Binds a pivot grid to this collection.
            pivotGridControl1.DataSource = dataSource;
        }
    }
}