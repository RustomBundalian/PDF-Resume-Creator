using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;


namespace PDF_Resume_Creator
{
    public partial class PDFResumeCreator : Form
    {
        public PDFResumeCreator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class MyResume
        {
            public string Fullname { get; set; }

            public string Profile { get; set; }

            public string Profiles { get; set; }

            public string Employment { get; set; }

            public string Student { get; set; }

            public string StdFrom { get; set; }

            public string Employments { get; set; }

            public string Education { get; set; }

            public string Hs { get; set; }

            public string HsFrom { get; set; }

            public string Educations { get; set; }

            public string Elem { get; set; }

            public string ElemFrom { get; set; }

            public string Elems { get; set; }

        }
            private void btnGenerate_Click(object sender, EventArgs e)
        {
            string myJson = File.ReadAllText(@"C:\Users\Tom\source\repos\PDF Resume Creator\Bundalian.JSON");

            MyResume JsonInfo = JsonConvert.DeserializeObject<MyResume>(myJson);

            Document Resume = new Document();
            PdfWriter.GetInstance(Resume, new FileStream(@"C:\Users\Tom\source\repos\PDF Resume Creator\BUNDALIAN_RUSTOM.pdf", FileMode.Create));
            Resume.Open();

            Paragraph myName = new Paragraph(JsonInfo.Fullname + "\n\n");
            myName.Font.Size = 30;
            Paragraph myProfile = new Paragraph(JsonInfo.Profile + "\n");
            myProfile.Font.Size = 18;
            Paragraph myProfiles = new Paragraph(JsonInfo.Profiles + "\n\n");
            Resume.Add(myName);
            Resume.Add(myProfile);
            Resume.Add(myProfiles);
            Paragraph employment = new Paragraph(JsonInfo.Employment + "\n");
            employment.Font.Size = 18;
            Paragraph student = new Paragraph(JsonInfo.Student + "\n");
            student.Font.Size = 12;
            Paragraph stdfrom = new Paragraph(JsonInfo.StdFrom + "\n");
            stdfrom.Font.Size = 9;
            Paragraph employments = new Paragraph(JsonInfo.Employments + "\n\n");
            Resume.Add(employment);
            Resume.Add(student);
            Resume.Add(stdfrom);
            Resume.Add(employments);
            Paragraph education = new Paragraph(JsonInfo.Education + "\n");
            education.Font.Size = 18;
            Paragraph hs = new Paragraph(JsonInfo.Hs + "\n");
            hs.Font.Size = 12;
            Paragraph hsfrom = new Paragraph(JsonInfo.HsFrom + "\n");
            hsfrom.Font.Size = 9;
            Paragraph educations = new Paragraph(JsonInfo.Educations + "\n\n");
            Resume.Add(education);
            Resume.Add(student);
            Resume.Add(stdfrom);
            Resume.Add(employments);
            Paragraph elem = new Paragraph(JsonInfo.Elem + "\n");
            elem.Font.Size = 12;
            Paragraph elemfrom = new Paragraph(JsonInfo.ElemFrom + "\n");
            elemfrom.Font.Size = 9;
            Paragraph elems = new Paragraph(JsonInfo.Elems);
            Resume.Add(elem);
            Resume.Add(elemfrom);
            Resume.Add(elems);
            MessageBox.Show("You successfully generated your own Resume!");
            Resume.Close();
        }
    }
}
