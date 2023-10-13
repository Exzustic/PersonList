using System.Security.Cryptography.X509Certificates;

namespace nedoDatabase
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        Boolean worker = false;
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean checkNameAndSurname(String str)
        {
            if (str == null)
            {
                return false;
            }
            char[] chars = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsLetter(chars[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public Boolean checkPesel(String str)
        {
            if (str == null)
            {
                return false;
            }
            if (str.Length != 11)
            {
                return false;
            }
            char[] chars = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsDigit(chars[i]))
                {
                    return false;
                }
            }
            return true;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (checkNameAndSurname(textBoxName.Text) && checkNameAndSurname(textBoxSurname.Text) && checkPesel(textBoxPesel.Text))
            {
                people.Add(new Person(textBoxName.Text, textBoxSurname.Text, textBoxPesel.Text, worker));
                textBoxName.Text = string.Empty;
                textBoxSurname.Text = string.Empty;
                textBoxPesel.Text = string.Empty;
                checkEmployee.Checked = false;
                labelCount.Text = "Count: " + people.Count;
                dataGridView1.Rows.Clear();
                for (int i = 0; i < people.Count; i++)
                {
                    switch (comboBox1.Text)
                    {
                        case "All":
                            dataGridView1.Rows.Add(people[i].getName(), people[i].getSurname(), people[i].getPesel(), (people[i].getEmployee() ? "Teacher" : "Student"));
                            break;
                        case "Teacher":
                            if (people[i].getEmployee())
                            {
                                dataGridView1.Rows.Add(people[i].getName(), people[i].getSurname(), people[i].getPesel(), (people[i].getEmployee() ? "Teacher" : "Student"));
                            }
                            break;
                        case "Student":
                            if (!people[i].getEmployee())
                            {
                                dataGridView1.Rows.Add(people[i].getName(), people[i].getSurname(), people[i].getPesel(), (people[i].getEmployee() ? "Teacher" : "Student"));
                            }
                            break;
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkNameAndSurname(textBoxName.Text) && checkNameAndSurname(textBoxSurname.Text) && checkPesel(textBoxPesel.Text))
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].getName() == textBoxName.Text &&
                       people[i].getSurname() == textBoxSurname.Text &&
                       people[i].getPesel() == textBoxPesel.Text)
                    {
                        people.RemoveAt(i);
                        break;
                    }
                }
                textBoxName.Text = string.Empty;           
                textBoxSurname.Text = string.Empty;        
                textBoxPesel.Text = string.Empty;          
                checkEmployee.Checked = false;
                labelCount.Text = "Count: " + people.Count;
                dataGridView1.Rows.Clear();

                for (int i = 0; i < people.Count; i++)
                {
                    switch (comboBox1.Text)
                    {
                        case "All":
                            dataGridView1.Rows.Add(people[i].getName(), people[i].getSurname(), people[i].getPesel(), (people[i].getEmployee() ? "Teacher" : "Student"));
                            break;
                        case "Teacher":
                            if (people[i].getEmployee())
                            {
                                dataGridView1.Rows.Add(people[i].getName(), people[i].getSurname(), people[i].getPesel(), (people[i].getEmployee() ? "Teacher" : "Student"));
                            }
                            break;
                        case "Student":
                            if (!people[i].getEmployee())
                            {
                                dataGridView1.Rows.Add(people[i].getName(), people[i].getSurname(), people[i].getPesel(), (people[i].getEmployee() ? "Teacher" : "Student"));
                            }
                            break;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].getName() == textBoxName.Text ||
                   people[i].getSurname() == textBoxSurname.Text ||
                   people[i].getPesel() == textBoxPesel.Text)
                {
                    textBoxName.Text = people[i].getName();
                    textBoxSurname.Text = people[i].getSurname();
                    textBoxPesel.Text = people[i].getPesel();
                    if (people[i].getEmployee())
                    {
                        checkEmployee.Checked = true;
                    }
                    else
                    {
                        checkEmployee.Checked = false;
                    }
                    break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxSurname.Text = string.Empty;
            textBoxPesel.Text = string.Empty;
            checkEmployee.Checked = false;
        }

        private void checkEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEmployee.Checked)
            {
                worker = true;
            }
            else
            {
                worker = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < people.Count; i++)
            {
                switch (comboBox1.Text)
                {
                    case "All":
                        dataGridView1.Rows.Add(people[i].getName(), people[i].getSurname(), people[i].getPesel(), (people[i].getEmployee() ? "Teacher" : "Student"));
                        break;
                    case "Teacher":
                        if (people[i].getEmployee())
                        {
                            dataGridView1.Rows.Add(people[i].getName(), people[i].getSurname(), people[i].getPesel(), (people[i].getEmployee() ? "Teacher" : "Student"));
                        }
                        break;
                    case "Student":
                        if (!people[i].getEmployee())
                        {
                            dataGridView1.Rows.Add(people[i].getName(), people[i].getSurname(), people[i].getPesel(), (people[i].getEmployee() ? "Teacher" : "Student"));
                        }
                        break;
                }
            }
        }
    }
}