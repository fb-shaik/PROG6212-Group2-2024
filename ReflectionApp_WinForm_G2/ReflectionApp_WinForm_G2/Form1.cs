using System.Reflection;

namespace ReflectionApp_WinForm_G2
{
    public partial class frmReflection : Form
    {
        public frmReflection()
        {
            InitializeComponent();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double total = 149.99;
            System.Type type = total.GetType();
            MessageBox.Show(total + " is of type " + type);
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            //replicate the same as we did for the double type button above
            string hello = "Hello World";
            System.Type type = hello.GetType();
            MessageBox.Show(hello + " is of type " + type);
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            //need an Assembly object & file path to the chosen .dll
            Assembly a = Assembly.LoadFrom("C:\\Users\\User\\source\\repos\\VehicleManagement\\bin\\Debug\\net8.0\\VehicleManagement.dll");

            //use the Rich text box to display details of the dll
            rtbTypes.AppendText("Details: " + a.Location + Environment.NewLine);
            rtbTypes.AppendText("Location: " + a.GetName() + Environment.NewLine);

            Type[] types = a.GetTypes();
            rtbTypes.AppendText("Number of Types: " + types.Count() + Environment.NewLine + "List of Types: "
                                + Environment.NewLine);

            foreach (Type t in types)
            {
                rtbTypes.Text += t + Environment.NewLine;
            }
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            Type MyType = Type.GetType("System.Collections");

            MemberInfo[] Mymemberinfoarray = MyType.GetMembers();

            rtbArrayList.AppendText(Mymemberinfoarray.Length + " items in " + Environment.NewLine);

            if (MyType.IsPublic)
            {
                rtbArrayList.AppendText(MyType.FullName + " is public " + Environment.NewLine);
            }
            else
            {
                rtbArrayList.AppendText(MyType.FullName + " is private " + Environment.NewLine);
            }

            foreach (MemberInfo m in Mymemberinfoarray)
            {
                rtbArrayList.AppendText(m.Name + " (" + m.MemberType + ")" + Environment.NewLine);
            }
        }

        private void btnAssemblies_Click(object sender, EventArgs e)
        {

        }
    }
}
