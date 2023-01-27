namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string rootPath = @"C:\Users\VM\Desktop\Kokosa";

        private void btn_np_Click(object sender, EventArgs e)
        {
            string projectName = txtbox_ProjectName.Text;
            if (projectName == "") 
            {
                lbl_error.ForeColor= System.Drawing.Color.Red;
                lbl_error.Text = "Please enter project name.";
            } else {
                Directory.CreateDirectory(rootPath + @"\" + projectName);
            }
            //Logic.NewFolder();
        }
    }
}