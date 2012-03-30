using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) // CREATE JSON clicked - this will generate json object 
        {
            string filepath = jsonfile.Text;
            int dirends = filepath.LastIndexOf(@"\");
            string dirpath = filepath.Substring(0,++dirends);

            if (Directory.Exists(dirpath))
            {
                patherrorlbl.Visible = false;

                //string jsonBreed;
                // creates random 4-digit id
                int seed = DateTime.Now.Second;
                var _random = new Random(seed);
                int id = _random.Next(1000, 9999);
                idTxtbx.Text = id.ToString();
                string lifespan = lifespanstart.Text + "-" + lifespanend.Text;

                string name = breedname.Text;
                string orig = origin.Text; 
                string grp = group.Text;
                string wgt = weight.Text; 
                string tmpr = temper.SelectedItem.ToString();
                string desc = breedNotes.Text;
                string pic = picfilename.Text;
                //string str = "{ \n\t\"id\" : {0}, \n\t\"name\" : \"{1}\", \n\t\"origin\" : \"{2}\", \n\t\"group\" : \"{3}\" , \n\t\"weight\" : \"{4}\", \n\t\"temperament\" : \"{5}\", \n\t\"lifespan\" : \"{6}\", \n\t\"description\" : \"{7}\", \n\t\"picfilename\" : \"{8}\", ";
                //building json object string

                // obj = "{ "; curlies were the effin prob all along. Escape them using {{ and }}

                string obj = string.Format("\n\r{{ \n\r\t\"id\" : {0}, \n\r\t\"name\" : \"{1}\", \n\r\t\"origin\" : \"{2}\", \n\r\t\"group\" : \"{3}\" , \n\r\t\"weight\" : \"{4}\", \n\r\t\"temperament\" : \"{5}\", \n\r\t\"lifespan\" : \"{6}\", \n\r\t\"description\" : \"{7}\", \n\r\t\"picfilename\" : \"{8}\",", id, name, orig, grp, wgt, tmpr, lifespan, desc, pic);

                //adds health sub-object if it has health issues
                if (HasHealthIssues.SelectedItem.ToString() == "True")
                {
                    obj += string.Format("\n\n\t\"hasHealthIssue\": true, \n\n\t\"healthIssue\" : \n\n\t{{ \n\n\t\"issue\":\"{0}\"  \n\n\t}}, \n\n", healthIssue.Text);
                }
                else obj += "\n\r\t\"hasHealthIssue\": false, \n\n\t\"healthIssue\" : null, ";

                if (HasTrainingTips.SelectedItem.ToString() == "True")
                {
                    obj += string.Format(" \n\r\t\"hasTrainingTip\": true, \n\r\t\"trainingTip\" : \n\n\t{{ \n\t\"tip\":\"{0}\"  \n\t}}, \n", TrainingTips.Text);
                }
                else
                {
                    obj += " \n\r\t\"hasTrainingTip\": false, \n\r\t\"trainingTip\" : null, ";
                }

                obj += string.Format("\n\r\t\"height\" : \"{0}\" ",heightTxtbox.Text);

                obj += "\n\n" + @"}"; //last closing bracket

                writeJson(obj, filepath);
            }
            else { patherrorlbl.Visible = true; return; }

        }//end of button click

        private static void writeJson( string str, string path)
        {
            using (StreamWriter outputfile = new StreamWriter(path, true))
            {
                //writes/appends each url into a new line of the file
                    outputfile.Write(str);
            }
        }

        private void button2_Click(object sender, EventArgs e) //clear button clicked
        {
            foreach (Control c in tabPage1.Controls)
            {
                if (c is TextBox)
                {
                    if (!(c.Name == "idTxtbx" || c.Name == "jsonfile"))
                    {
                        c.Text = "";
                    }
                }
            }
        } //end of clear button
        

    }
}
