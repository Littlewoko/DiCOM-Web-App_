using DicomObjects;
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

namespace DiCOM_Web_App_
{
    public partial class Form1 : Form
    {
        DicomServer server;
        private int port = 104;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set up simplistic SCP behaviour - accept and display images
            server = new DicomServer();
            server.Listen(port);
            server.InstanceReceived += (o, ee) => { Viewer.Images.Add(new DicomImage(ee.Instance)); ee.Status = 0; };
            server.VerifyReceived += (o, ee) => ee.Status = 0;
            
        }

        private void Viewer_Click(object sender, EventArgs e)
        {
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            dbQueries.digest(Viewer.Images);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Viewer.Images.Send(ip, port, callerAET, calledAET);
        }
    }
}
