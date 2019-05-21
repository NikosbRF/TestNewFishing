using System;

namespace MapSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.btnLoadtoMap = new System.Windows.Forms.Button();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(371, 517);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.AutoSize = true;
            this.map.BackColor = System.Drawing.Color.White;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(377, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(411, 306);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(76, 109);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(120, 20);
            this.txtLat.TabIndex = 4;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(76, 135);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(120, 20);
            this.txtLong.TabIndex = 5;
            // 
            // btnLoadtoMap
            // 
            this.btnLoadtoMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnLoadtoMap.Location = new System.Drawing.Point(76, 161);
            this.btnLoadtoMap.Name = "btnLoadtoMap";
            this.btnLoadtoMap.Size = new System.Drawing.Size(158, 32);
            this.btnLoadtoMap.TabIndex = 6;
            this.btnLoadtoMap.Text = "LoadtoMap";
            this.btnLoadtoMap.UseVisualStyleBackColor = true;
            this.btnLoadtoMap.Click += new System.EventHandler(this.btnLoadtoMap_Click);
            // 
            // image1
            // 
            this.image1.BackColor = System.Drawing.Color.White;
            this.image1.Location = new System.Drawing.Point(76, 313);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(282, 192);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1.TabIndex = 7;
            this.image1.TabStop = false;
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Btn1.Location = new System.Drawing.Point(76, 237);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(158, 30);
            this.Btn1.TabIndex = 8;
            this.Btn1.Text = "Photo";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn2.Location = new System.Drawing.Point(76, 199);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(158, 32);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "Test2\r\n";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.btnLoadtoMap);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Button btnLoadtoMap;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button btn2;
    }
}

