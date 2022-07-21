﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
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
            string myJson = File.ReadAllText(@"C:\Users\Tom\source\repos\PDF Resume Creator\PDF Resume Creator\Bundalian.JSON");

            MyResume JsonInfo = JsonConvert.DeserializeObject<MyResume>(myJson);
        }
    }
}