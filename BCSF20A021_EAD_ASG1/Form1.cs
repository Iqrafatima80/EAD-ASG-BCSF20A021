using System.Text;

namespace BCSF20A021_EAD_ASG1
{
    public partial class Form1 : Form
    {
        string[] sub = { "PF", "OOP", "DSA", "Web", "Database", "Algo" };
        string[] selected;
        List<string> resultLines = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
            Box1.Items.AddRange(sub);
            selected = new string[Box1.Items.Count];
            this.MaximizeBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first_name = textBox1.Text.Trim();
            string last_name = textBox2.Text.Trim();

            // Check if textBox1 and textBox2 have values, checkBox1 is checked, and Box1 has items selected
            resultLines.Clear(); // Clear the result lines list
            if (string.IsNullOrWhiteSpace(first_name) || string.IsNullOrWhiteSpace(last_name))
            {
                resultLines.Add("Please fill in both first name and last name.");
            }
            else if (!checkBox1.Checked)
            {
                resultLines.Add("Please check the prerequisite clearance checkbox.");
            }
            else if (Box1.CheckedItems.Count == 0)
            {
                resultLines.Add("Please select at least one subject.");
            }
            else
            {
                int i = 0;
                StringBuilder selectedSubjects = new StringBuilder(); 

                foreach (var s in Box1.CheckedItems)
                {
                    selected[i] = s.ToString();
                    i++;

                    if (i > 1) 
                    {
                        selectedSubjects.Append(", ");
                    }

                    selectedSubjects.Append(s.ToString());
                }
                string pre = "yes"; 

                resultLines.Add($"First Name: {first_name}");
                resultLines.Add($"Last Name: {last_name}");
                resultLines.Add($"Selected Subjects: {selectedSubjects.ToString()}");
                resultLines.Add($"Prerequisite Clearance: {pre}");
            }
            result.Text = string.Join("\n", resultLines);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Box1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
