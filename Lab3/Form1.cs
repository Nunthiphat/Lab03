using System.Xml.Linq;

namespace Lab3
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Double> grade = new List<Double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            String _name = tb_Name.Text;
            String _id = tb_Id.Text;
            String _birthYear = tb_BirthYear.Text;
            String _height = tb_Height.Text;
            String _grade = tb_Grade.Text;
            String _subject = tb_Subject.Text;

            int iBirth = Int32.Parse(_birthYear);
            double iHeight = double.Parse(_height);
            double iGrade = double.Parse(_grade);

            this.tb_Name.Text = "";
            this.tb_Id.Text = "";
            this.tb_BirthYear.Text = "";
            this.tb_Height.Text = "";
            this.tb_Grade.Text = "";
            this.tb_Subject.Text = "";

            Student newStudent = new Student(_name, _id, iBirth, iHeight, iGrade, _subject);
            this.students.Add(newStudent);
            this.grade.Add(iGrade);

            BindingSource source = new BindingSource();
            source.DataSource = this.students;
            this.dataGridView1.DataSource = source;

            Int32 StdCount = students.Count;
            double MostGrade = grade.Max();
            Double LeastGrade = grade.Min();

            tb_MaxGrade.Text = LeastGrade.ToString();
            tb_MinGrade.Text = MostGrade.ToString();
            //tb_CountSTD.Text = StdCount.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}