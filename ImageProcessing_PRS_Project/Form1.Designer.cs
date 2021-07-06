namespace ImageProcessing_PRS_Project
{
    partial class mainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flpRight = new System.Windows.Forms.FlowLayoutPanel();
            this.sepia = new System.Windows.Forms.Button();
            this.blackandwhite = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.contrast = new System.Windows.Forms.Button();
            this.oldphoto = new System.Windows.Forms.Button();
            this.nightvision = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.colorize = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.gpbTest = new System.Windows.Forms.GroupBox();
            this.pgbStatus = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.lblSequentialTime = new System.Windows.Forms.Label();
            this.lblParallelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSekvencijelno = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.gpbLeft = new System.Windows.Forms.GroupBox();
            this.rbSekvencijelno = new System.Windows.Forms.RadioButton();
            this.rbParalelno = new System.Windows.Forms.RadioButton();
            this.imgCurrentImage = new System.Windows.Forms.PictureBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolbar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCopyrights = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.gpbTest.SuspendLayout();
            this.gpbLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrentImage)).BeginInit();
            this.menuToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUploadImage.BackColor = System.Drawing.Color.LightGray;
            this.btnUploadImage.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.import;
            this.btnUploadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(260, 493);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnUploadImage.Size = new System.Drawing.Size(135, 32);
            this.btnUploadImage.TabIndex = 0;
            this.btnUploadImage.Text = "Import image";
            this.btnUploadImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 10;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flpRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgCurrentImage, 1, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(1600, 600);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1003, 433);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flpRight
            // 
            this.flpRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpRight.AutoScroll = true;
            this.flpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpRight.Controls.Add(this.sepia);
            this.flpRight.Controls.Add(this.blackandwhite);
            this.flpRight.Controls.Add(this.negative);
            this.flpRight.Controls.Add(this.contrast);
            this.flpRight.Controls.Add(this.oldphoto);
            this.flpRight.Controls.Add(this.nightvision);
            this.flpRight.Controls.Add(this.red);
            this.flpRight.Controls.Add(this.blue);
            this.flpRight.Controls.Add(this.colorize);
            this.flpRight.Location = new System.Drawing.Point(804, 3);
            this.flpRight.Name = "flpRight";
            this.flpRight.Size = new System.Drawing.Size(196, 427);
            this.flpRight.TabIndex = 2;
            // 
            // sepia
            // 
            this.sepia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sepia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.sepia.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.sepia;
            this.sepia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sepia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sepia.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepia.ForeColor = System.Drawing.Color.LightYellow;
            this.sepia.Location = new System.Drawing.Point(3, 0);
            this.sepia.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.sepia.Name = "sepia";
            this.sepia.Size = new System.Drawing.Size(170, 84);
            this.sepia.TabIndex = 36;
            this.sepia.UseVisualStyleBackColor = false;
            this.sepia.Click += new System.EventHandler(this.btnEffectsClick);
            // 
            // blackandwhite
            // 
            this.blackandwhite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blackandwhite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.blackandwhite.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.grayScale;
            this.blackandwhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackandwhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackandwhite.Location = new System.Drawing.Point(3, 85);
            this.blackandwhite.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.blackandwhite.Name = "blackandwhite";
            this.blackandwhite.Size = new System.Drawing.Size(170, 84);
            this.blackandwhite.TabIndex = 35;
            this.blackandwhite.UseVisualStyleBackColor = false;
            this.blackandwhite.Click += new System.EventHandler(this.btnEffectsClick);
            // 
            // negative
            // 
            this.negative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.negative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.negative.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.negative;
            this.negative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.negative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.negative.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negative.Location = new System.Drawing.Point(3, 170);
            this.negative.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(170, 84);
            this.negative.TabIndex = 37;
            this.negative.UseVisualStyleBackColor = false;
            this.negative.Click += new System.EventHandler(this.btnEffectsClick);
            // 
            // contrast
            // 
            this.contrast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contrast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.contrast.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.contrast;
            this.contrast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contrast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contrast.Location = new System.Drawing.Point(3, 255);
            this.contrast.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.contrast.Name = "contrast";
            this.contrast.Size = new System.Drawing.Size(170, 84);
            this.contrast.TabIndex = 48;
            this.contrast.UseVisualStyleBackColor = false;
            this.contrast.Click += new System.EventHandler(this.btnEffectsClick);
            // 
            // oldphoto
            // 
            this.oldphoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldphoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.oldphoto.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.oldphoto;
            this.oldphoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oldphoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oldphoto.Location = new System.Drawing.Point(3, 340);
            this.oldphoto.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.oldphoto.Name = "oldphoto";
            this.oldphoto.Size = new System.Drawing.Size(170, 84);
            this.oldphoto.TabIndex = 51;
            this.oldphoto.UseVisualStyleBackColor = false;
            this.oldphoto.Click += new System.EventHandler(this.btnEffectsClick);
            // 
            // nightvision
            // 
            this.nightvision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nightvision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.nightvision.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.nightVision;
            this.nightvision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nightvision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightvision.Location = new System.Drawing.Point(3, 425);
            this.nightvision.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.nightvision.Name = "nightvision";
            this.nightvision.Size = new System.Drawing.Size(170, 84);
            this.nightvision.TabIndex = 57;
            this.nightvision.UseVisualStyleBackColor = false;
            this.nightvision.Click += new System.EventHandler(this.btnEffectsClick);
            // 
            // red
            // 
            this.red.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.red.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.red;
            this.red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.red.Location = new System.Drawing.Point(3, 510);
            this.red.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(170, 84);
            this.red.TabIndex = 58;
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.btnEffectsClick);
            // 
            // blue
            // 
            this.blue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.blue.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.blue;
            this.blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blue.Location = new System.Drawing.Point(3, 595);
            this.blue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(170, 84);
            this.blue.TabIndex = 59;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.btnEffectsClick);
            // 
            // colorize
            // 
            this.colorize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.colorize.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.painting;
            this.colorize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorize.Location = new System.Drawing.Point(3, 680);
            this.colorize.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.colorize.Name = "colorize";
            this.colorize.Size = new System.Drawing.Size(170, 84);
            this.colorize.TabIndex = 60;
            this.colorize.UseVisualStyleBackColor = false;
            this.colorize.Click += new System.EventHandler(this.btnEffectsClick);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.gpbTest);
            this.pnlLeft.Controls.Add(this.gpbLeft);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(194, 427);
            this.pnlLeft.TabIndex = 3;
            // 
            // gpbTest
            // 
            this.gpbTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbTest.Controls.Add(this.pgbStatus);
            this.gpbTest.Controls.Add(this.label2);
            this.gpbTest.Controls.Add(this.rtbResults);
            this.gpbTest.Controls.Add(this.lblSequentialTime);
            this.gpbTest.Controls.Add(this.lblParallelTime);
            this.gpbTest.Controls.Add(this.label1);
            this.gpbTest.Controls.Add(this.lblSekvencijelno);
            this.gpbTest.Controls.Add(this.btnStart);
            this.gpbTest.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTest.ForeColor = System.Drawing.Color.White;
            this.gpbTest.Location = new System.Drawing.Point(3, 96);
            this.gpbTest.Name = "gpbTest";
            this.gpbTest.Size = new System.Drawing.Size(188, 331);
            this.gpbTest.TabIndex = 4;
            this.gpbTest.TabStop = false;
            this.gpbTest.Text = "Benchmark test";
            // 
            // pgbStatus
            // 
            this.pgbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbStatus.Location = new System.Drawing.Point(95, 302);
            this.pgbStatus.Name = "pgbStatus";
            this.pgbStatus.Size = new System.Drawing.Size(83, 20);
            this.pgbStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbStatus.TabIndex = 14;
            this.pgbStatus.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Results:";
            // 
            // rtbResults
            // 
            this.rtbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rtbResults.ForeColor = System.Drawing.Color.White;
            this.rtbResults.Location = new System.Drawing.Point(10, 159);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(168, 134);
            this.rtbResults.TabIndex = 12;
            this.rtbResults.Text = "";
            // 
            // lblSequentialTime
            // 
            this.lblSequentialTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSequentialTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblSequentialTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSequentialTime.Location = new System.Drawing.Point(10, 44);
            this.lblSequentialTime.MinimumSize = new System.Drawing.Size(160, 25);
            this.lblSequentialTime.Name = "lblSequentialTime";
            this.lblSequentialTime.Size = new System.Drawing.Size(168, 25);
            this.lblSequentialTime.TabIndex = 11;
            this.lblSequentialTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParallelTime
            // 
            this.lblParallelTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParallelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblParallelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParallelTime.Location = new System.Drawing.Point(10, 104);
            this.lblParallelTime.MinimumSize = new System.Drawing.Size(160, 25);
            this.lblParallelTime.Name = "lblParallelTime";
            this.lblParallelTime.Size = new System.Drawing.Size(168, 25);
            this.lblParallelTime.TabIndex = 10;
            this.lblParallelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Parallel execution:";
            // 
            // lblSekvencijelno
            // 
            this.lblSekvencijelno.AutoSize = true;
            this.lblSekvencijelno.Location = new System.Drawing.Point(10, 24);
            this.lblSekvencijelno.Name = "lblSekvencijelno";
            this.lblSekvencijelno.Size = new System.Drawing.Size(154, 15);
            this.lblSekvencijelno.TabIndex = 8;
            this.lblSekvencijelno.Text = "Sequential execution:";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.start;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(10, 299);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnStart.Size = new System.Drawing.Size(79, 26);
            this.btnStart.TabIndex = 7;
            this.btnStart.Tag = "1";
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gpbLeft
            // 
            this.gpbLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbLeft.Controls.Add(this.rbSekvencijelno);
            this.gpbLeft.Controls.Add(this.rbParalelno);
            this.gpbLeft.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLeft.ForeColor = System.Drawing.Color.White;
            this.gpbLeft.Location = new System.Drawing.Point(3, -3);
            this.gpbLeft.Name = "gpbLeft";
            this.gpbLeft.Size = new System.Drawing.Size(188, 93);
            this.gpbLeft.TabIndex = 3;
            this.gpbLeft.TabStop = false;
            this.gpbLeft.Text = "Execution type";
            // 
            // rbSekvencijelno
            // 
            this.rbSekvencijelno.AutoSize = true;
            this.rbSekvencijelno.Checked = true;
            this.rbSekvencijelno.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSekvencijelno.ForeColor = System.Drawing.Color.White;
            this.rbSekvencijelno.Location = new System.Drawing.Point(6, 28);
            this.rbSekvencijelno.Name = "rbSekvencijelno";
            this.rbSekvencijelno.Size = new System.Drawing.Size(165, 18);
            this.rbSekvencijelno.TabIndex = 0;
            this.rbSekvencijelno.TabStop = true;
            this.rbSekvencijelno.Text = "Sequential execution";
            this.rbSekvencijelno.UseVisualStyleBackColor = true;
            // 
            // rbParalelno
            // 
            this.rbParalelno.AutoSize = true;
            this.rbParalelno.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbParalelno.ForeColor = System.Drawing.Color.White;
            this.rbParalelno.Location = new System.Drawing.Point(6, 52);
            this.rbParalelno.Name = "rbParalelno";
            this.rbParalelno.Size = new System.Drawing.Size(151, 18);
            this.rbParalelno.TabIndex = 2;
            this.rbParalelno.Text = "Parallel execution";
            this.rbParalelno.UseVisualStyleBackColor = true;
            // 
            // imgCurrentImage
            // 
            this.imgCurrentImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCurrentImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.imgCurrentImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgCurrentImage.BackgroundImage")));
            this.imgCurrentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCurrentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCurrentImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCurrentImage.Location = new System.Drawing.Point(203, 3);
            this.imgCurrentImage.Name = "imgCurrentImage";
            this.imgCurrentImage.Size = new System.Drawing.Size(595, 427);
            this.imgCurrentImage.TabIndex = 4;
            this.imgCurrentImage.TabStop = false;
            this.imgCurrentImage.Click += new System.EventHandler(this.imgCurrentImage_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveImage.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveImage.BackgroundImage = global::ImageProcessing_PRS_Project.Properties.Resources.save;
            this.btnSaveImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.Location = new System.Drawing.Point(606, 493);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSaveImage.Size = new System.Drawing.Size(135, 32);
            this.btnSaveImage.TabIndex = 6;
            this.btnSaveImage.Text = "Save image";
            this.btnSaveImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUndo.BackColor = System.Drawing.Color.LightGray;
            this.btnUndo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.BackgroundImage")));
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(401, 493);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnUndo.Size = new System.Drawing.Size(96, 32);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "Undo";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRedo.BackColor = System.Drawing.Color.LightGray;
            this.btnRedo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRedo.BackgroundImage")));
            this.btnRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.Location = new System.Drawing.Point(504, 493);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnRedo.Size = new System.Drawing.Size(96, 32);
            this.btnRedo.TabIndex = 8;
            this.btnRedo.Text = "Redo";
            this.btnRedo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuToolbar
            // 
            this.menuToolbar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuToolbar.Location = new System.Drawing.Point(0, 0);
            this.menuToolbar.Name = "menuToolbar";
            this.menuToolbar.Size = new System.Drawing.Size(1003, 24);
            this.menuToolbar.TabIndex = 9;
            this.menuToolbar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::ImageProcessing_PRS_Project.Properties.Resources.info;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::ImageProcessing_PRS_Project.Properties.Resources.close;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.technicalSupportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // technicalSupportToolStripMenuItem
            // 
            this.technicalSupportToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.technicalSupportToolStripMenuItem.Image = global::ImageProcessing_PRS_Project.Properties.Resources.question_mark;
            this.technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            this.technicalSupportToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.technicalSupportToolStripMenuItem.Text = "Technical support";
            this.technicalSupportToolStripMenuItem.Click += new System.EventHandler(this.technicalSupportToolStripMenuItem_Click);
            // 
            // lblCopyrights
            // 
            this.lblCopyrights.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCopyrights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblCopyrights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblCopyrights.Location = new System.Drawing.Point(203, 560);
            this.lblCopyrights.MinimumSize = new System.Drawing.Size(160, 25);
            this.lblCopyrights.Name = "lblCopyrights";
            this.lblCopyrights.Size = new System.Drawing.Size(595, 25);
            this.lblCopyrights.TabIndex = 15;
            this.lblCopyrights.Text = "© 2019 Faculty of Electrical Engineering East Sarajevo - All Rights Reserved";
            this.lblCopyrights.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1003, 594);
            this.Controls.Add(this.lblCopyrights);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.menuToolbar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuToolbar;
            this.MinimumSize = new System.Drawing.Size(1019, 633);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Editor - ETF Istočno Sarajevo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flpRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.gpbTest.ResumeLayout(false);
            this.gpbTest.PerformLayout();
            this.gpbLeft.ResumeLayout(false);
            this.gpbLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrentImage)).EndInit();
            this.menuToolbar.ResumeLayout(false);
            this.menuToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.RadioButton rbParalelno;
        private System.Windows.Forms.RadioButton rbSekvencijelno;
        private System.Windows.Forms.GroupBox gpbTest;
        private System.Windows.Forms.GroupBox gpbLeft;
        private System.Windows.Forms.Button blackandwhite;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button sepia;
        private System.Windows.Forms.Button contrast;
        private System.Windows.Forms.Button oldphoto;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button nightvision;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button colorize;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSequentialTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSekvencijelno;
        private System.Windows.Forms.Label lblParallelTime;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.ProgressBar pgbStatus;
        private System.Windows.Forms.PictureBox imgCurrentImage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuToolbar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalSupportToolStripMenuItem;
        private System.Windows.Forms.Label lblCopyrights;
    }
}

