namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            grayscalingToolStripMenuItem = new ToolStripMenuItem();
            invertionToolStripMenuItem = new ToolStripMenuItem();
            mirrorHorizToolStripMenuItem = new ToolStripMenuItem();
            mirrorVertToolStripMenuItem = new ToolStripMenuItem();
            sepiaColorToolStripMenuItem = new ToolStripMenuItem();
            histToolStripMenuItem = new ToolStripMenuItem();
            contrastToolStripMenuItem = new ToolStripMenuItem();
            scaleToolStripMenuItem = new ToolStripMenuItem();
            binaryToolStripMenuItem = new ToolStripMenuItem();
            onToolStripMenuItem = new ToolStripMenuItem();
            offToolStripMenuItem = new ToolStripMenuItem();
            videoToolStripMenuItem = new ToolStripMenuItem();
            grayscaleToolStripMenuItem = new ToolStripMenuItem();
            convulaToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            blurToolStripMenuItem = new ToolStripMenuItem();
            edgeEnhanceToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectQuickToolStripMenuItem = new ToolStripMenuItem();
            prewittToolStripMenuItem = new ToolStripMenuItem();
            sobelToolStripMenuItem = new ToolStripMenuItem();
            kirshToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            horzVerticalToolStripMenuItem = new ToolStripMenuItem();
            allDirectionsToolStripMenuItem = new ToolStripMenuItem();
            lossyToolStripMenuItem = new ToolStripMenuItem();
            embossToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox5 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem, onToolStripMenuItem, offToolStripMenuItem, videoToolStripMenuItem, convulaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1029, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem, grayscalingToolStripMenuItem, invertionToolStripMenuItem, mirrorHorizToolStripMenuItem, mirrorVertToolStripMenuItem, sepiaColorToolStripMenuItem, histToolStripMenuItem, contrastToolStripMenuItem, scaleToolStripMenuItem, binaryToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(46, 24);
            dIPToolStripMenuItem.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem
            // 
            pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            pixelCopyToolStripMenuItem.Size = new Size(173, 26);
            pixelCopyToolStripMenuItem.Text = "Pixel Copy";
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click;
            // 
            // grayscalingToolStripMenuItem
            // 
            grayscalingToolStripMenuItem.Name = "grayscalingToolStripMenuItem";
            grayscalingToolStripMenuItem.Size = new Size(173, 26);
            grayscalingToolStripMenuItem.Text = "Grayscaling";
            grayscalingToolStripMenuItem.Click += grayscalingToolStripMenuItem_Click;
            // 
            // invertionToolStripMenuItem
            // 
            invertionToolStripMenuItem.Name = "invertionToolStripMenuItem";
            invertionToolStripMenuItem.Size = new Size(173, 26);
            invertionToolStripMenuItem.Text = "Invertion";
            invertionToolStripMenuItem.Click += invertionToolStripMenuItem_Click;
            // 
            // mirrorHorizToolStripMenuItem
            // 
            mirrorHorizToolStripMenuItem.Name = "mirrorHorizToolStripMenuItem";
            mirrorHorizToolStripMenuItem.Size = new Size(173, 26);
            mirrorHorizToolStripMenuItem.Text = "Mirror Horiz";
            mirrorHorizToolStripMenuItem.Click += mirrorHorizToolStripMenuItem_Click;
            // 
            // mirrorVertToolStripMenuItem
            // 
            mirrorVertToolStripMenuItem.Name = "mirrorVertToolStripMenuItem";
            mirrorVertToolStripMenuItem.Size = new Size(173, 26);
            mirrorVertToolStripMenuItem.Text = "Mirror Vert";
            mirrorVertToolStripMenuItem.Click += mirrorVertToolStripMenuItem_Click;
            // 
            // sepiaColorToolStripMenuItem
            // 
            sepiaColorToolStripMenuItem.Name = "sepiaColorToolStripMenuItem";
            sepiaColorToolStripMenuItem.Size = new Size(173, 26);
            sepiaColorToolStripMenuItem.Text = "Sepia Color";
            sepiaColorToolStripMenuItem.Click += sepiaColorToolStripMenuItem_Click;
            // 
            // histToolStripMenuItem
            // 
            histToolStripMenuItem.Name = "histToolStripMenuItem";
            histToolStripMenuItem.Size = new Size(173, 26);
            histToolStripMenuItem.Text = "Hist";
            histToolStripMenuItem.Click += histToolStripMenuItem_Click;
            // 
            // contrastToolStripMenuItem
            // 
            contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            contrastToolStripMenuItem.Size = new Size(173, 26);
            contrastToolStripMenuItem.Text = "Contrast";
            contrastToolStripMenuItem.Click += contrastToolStripMenuItem_Click;
            // 
            // scaleToolStripMenuItem
            // 
            scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            scaleToolStripMenuItem.Size = new Size(173, 26);
            scaleToolStripMenuItem.Text = "Scale";
            scaleToolStripMenuItem.Click += scaleToolStripMenuItem_Click;
            // 
            // binaryToolStripMenuItem
            // 
            binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            binaryToolStripMenuItem.Size = new Size(173, 26);
            binaryToolStripMenuItem.Text = "Binary";
            binaryToolStripMenuItem.Click += binaryToolStripMenuItem_Click;
            // 
            // onToolStripMenuItem
            // 
            onToolStripMenuItem.Name = "onToolStripMenuItem";
            onToolStripMenuItem.Size = new Size(40, 24);
            onToolStripMenuItem.Text = "on";
            onToolStripMenuItem.Click += onToolStripMenuItem_Click;
            // 
            // offToolStripMenuItem
            // 
            offToolStripMenuItem.Name = "offToolStripMenuItem";
            offToolStripMenuItem.Size = new Size(42, 24);
            offToolStripMenuItem.Text = "off";
            offToolStripMenuItem.Click += offToolStripMenuItem_Click;
            // 
            // videoToolStripMenuItem
            // 
            videoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grayscaleToolStripMenuItem });
            videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            videoToolStripMenuItem.Size = new Size(60, 24);
            videoToolStripMenuItem.Text = "video";
            // 
            // grayscaleToolStripMenuItem
            // 
            grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            grayscaleToolStripMenuItem.Size = new Size(155, 26);
            grayscaleToolStripMenuItem.Text = "Grayscale";
            grayscaleToolStripMenuItem.Click += grayscaleToolStripMenuItem_Click;
            // 
            // convulaToolStripMenuItem
            // 
            convulaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sharpenToolStripMenuItem, blurToolStripMenuItem, edgeEnhanceToolStripMenuItem, edgeDetectToolStripMenuItem, embossToolStripMenuItem });
            convulaToolStripMenuItem.Name = "convulaToolStripMenuItem";
            convulaToolStripMenuItem.Size = new Size(77, 24);
            convulaToolStripMenuItem.Text = "Convulo";
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(224, 26);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // blurToolStripMenuItem
            // 
            blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            blurToolStripMenuItem.Size = new Size(224, 26);
            blurToolStripMenuItem.Text = "Blur";
            blurToolStripMenuItem.Click += blurToolStripMenuItem_Click;
            // 
            // edgeEnhanceToolStripMenuItem
            // 
            edgeEnhanceToolStripMenuItem.Name = "edgeEnhanceToolStripMenuItem";
            edgeEnhanceToolStripMenuItem.Size = new Size(224, 26);
            edgeEnhanceToolStripMenuItem.Text = "Edge enhance";
            edgeEnhanceToolStripMenuItem.Click += edgeEnhanceToolStripMenuItem_Click;
            // 
            // edgeDetectToolStripMenuItem
            // 
            edgeDetectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { edgeDetectQuickToolStripMenuItem, prewittToolStripMenuItem, sobelToolStripMenuItem, kirshToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem, horzVerticalToolStripMenuItem, allDirectionsToolStripMenuItem, lossyToolStripMenuItem });
            edgeDetectToolStripMenuItem.Name = "edgeDetectToolStripMenuItem";
            edgeDetectToolStripMenuItem.Size = new Size(224, 26);
            edgeDetectToolStripMenuItem.Text = "Edge detect";
            edgeDetectToolStripMenuItem.Click += edgeDetectToolStripMenuItem_Click;
            // 
            // edgeDetectQuickToolStripMenuItem
            // 
            edgeDetectQuickToolStripMenuItem.Name = "edgeDetectQuickToolStripMenuItem";
            edgeDetectQuickToolStripMenuItem.Size = new Size(224, 26);
            edgeDetectQuickToolStripMenuItem.Text = "Edge Detect Quick";
            edgeDetectQuickToolStripMenuItem.Click += edgeDetectQuickToolStripMenuItem_Click_1;
            // 
            // prewittToolStripMenuItem
            // 
            prewittToolStripMenuItem.Name = "prewittToolStripMenuItem";
            prewittToolStripMenuItem.Size = new Size(224, 26);
            prewittToolStripMenuItem.Text = "Prewitt";
            prewittToolStripMenuItem.Click += prewittToolStripMenuItem_Click;
            // 
            // sobelToolStripMenuItem
            // 
            sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            sobelToolStripMenuItem.Size = new Size(224, 26);
            sobelToolStripMenuItem.Text = "Sobel";
            sobelToolStripMenuItem.Click += sobelToolStripMenuItem_Click;
            // 
            // kirshToolStripMenuItem
            // 
            kirshToolStripMenuItem.Name = "kirshToolStripMenuItem";
            kirshToolStripMenuItem.Size = new Size(224, 26);
            kirshToolStripMenuItem.Text = "Kirsh";
            kirshToolStripMenuItem.Click += kirshToolStripMenuItem_Click;
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(224, 26);
            horizontalToolStripMenuItem.Text = "Horizontal";
            horizontalToolStripMenuItem.Click += horizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(224, 26);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // horzVerticalToolStripMenuItem
            // 
            horzVerticalToolStripMenuItem.Name = "horzVerticalToolStripMenuItem";
            horzVerticalToolStripMenuItem.Size = new Size(224, 26);
            horzVerticalToolStripMenuItem.Text = "Horz/Vertical";
            horzVerticalToolStripMenuItem.Click += horzVerticalToolStripMenuItem_Click;
            // 
            // allDirectionsToolStripMenuItem
            // 
            allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            allDirectionsToolStripMenuItem.Size = new Size(224, 26);
            allDirectionsToolStripMenuItem.Text = "All Directions";
            allDirectionsToolStripMenuItem.Click += allDirectionsToolStripMenuItem_Click;
            // 
            // lossyToolStripMenuItem
            // 
            lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            lossyToolStripMenuItem.Size = new Size(224, 26);
            lossyToolStripMenuItem.Text = "Lossy";
            lossyToolStripMenuItem.Click += lossyToolStripMenuItem_Click;
            // 
            // embossToolStripMenuItem
            // 
            embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            embossToolStripMenuItem.Size = new Size(224, 26);
            embossToolStripMenuItem.Text = "Emboss";
            embossToolStripMenuItem.Click += embossToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(62, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(394, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(277, 257);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(576, 50);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = -50;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(431, 56);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(32, 50);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(441, 56);
            trackBar2.TabIndex = 4;
            trackBar2.Value = 1;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(303, 112);
            trackBar3.Maximum = 360;
            trackBar3.Minimum = -360;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(403, 56);
            trackBar3.TabIndex = 5;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(714, 235);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(277, 257);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(146, 507);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "load Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(455, 507);
            button2.Name = "button2";
            button2.Size = new Size(157, 29);
            button2.TabIndex = 10;
            button2.Text = "load Background";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(801, 507);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Subtract";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.FileOk += openFileDialog3_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 1011);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem grayscalingToolStripMenuItem;
        private ToolStripMenuItem invertionToolStripMenuItem;
        private ToolStripMenuItem mirrorHorizToolStripMenuItem;
        private ToolStripMenuItem mirrorVertToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem sepiaColorToolStripMenuItem;
        private ToolStripMenuItem histToolStripMenuItem;
        private ToolStripMenuItem contrastToolStripMenuItem;
        private ToolStripMenuItem scaleToolStripMenuItem;
        private ToolStripMenuItem binaryToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private ToolStripMenuItem videoToolStripMenuItem;
        private ToolStripMenuItem grayscaleToolStripMenuItem;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private ToolStripMenuItem convulaToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem blurToolStripMenuItem;
        private ToolStripMenuItem edgeEnhanceToolStripMenuItem;
        private ToolStripMenuItem edgeDetectToolStripMenuItem;
        private ToolStripMenuItem embossToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
        private ToolStripMenuItem edgeDetectQuickToolStripMenuItem;
        private ToolStripMenuItem prewittToolStripMenuItem;
        private ToolStripMenuItem sobelToolStripMenuItem;
        private ToolStripMenuItem kirshToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem horzVerticalToolStripMenuItem;
        private ToolStripMenuItem allDirectionsToolStripMenuItem;
    }
}
