using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using NExifTool;
using Medallion.Shell;

namespace MapSample
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

        //after YouTube video "C# - GMap - How to Display Map based on Latitude and Longitude? - GMap Part I"
        //Youtube user: Balaji S

        private void btnLoadtoMap_Click(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txtLat.Text);
            double longt = Convert.ToDouble(txtLong.Text);
            map.Position = new PointLatLng(lat, longt);
            map.MinZoom = 5;
            map.MaxZoom = 200;
            map.Zoom = 10;
        }

        //after Youtube video "How to upload an image on windows form Application C#"
        //YouTube user: C# Ui Academy

        private void Btn1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpeg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Fiiles(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image1.ImageLocation = imageLocation;
                  
                }
            }
            catch (Exception)

            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            int longt;
            int latdt;

            longt = 4;
            latdt = 5;

            txtLat.Text = latdt.ToString();
            txtLong.Text = longt.ToString();

            //test reasding

        }
    }
    
        
}


