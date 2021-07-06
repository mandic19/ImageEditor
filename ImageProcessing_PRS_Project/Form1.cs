using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Diagnostics;

namespace ImageProcessing_PRS_Project
{
    public partial class mainWindow : Form
    {
        Bitmap bitmap;
        Bitmap bmpCrop1, bmpCrop2, bmpCrop3, bmpCrop4, bmpCrop5, bmpCrop6, bmpCrop7, bmpCrop8;
        Bitmap[] buffer = new Bitmap[5];
        Stopwatch vr_sekvencijalnog_izvrsenja = new Stopwatch();
        Stopwatch vr_paralelnog_izvrsenja = new Stopwatch();

        int brojac = 0, buffer_brojac = 0, trenutna_pozicija = 0, prethodna_pozicija = 0;

        public mainWindow()
        {
            InitializeComponent();
            imgCurrentImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Metoda za sekvencijelno editovanje pixela fotografije kojoj se prosjedjuje ime kliknutog dugmeta filtera
        public void SequentialProcessing(string effect)
        {
            Color pixel_color = new Color();
            int height, width;

            try
            {
                Bitmap btmp = new Bitmap(imgCurrentImage.Image);        //Smjestamo u objekat tipa bitmap-a ucitanu sliku iz imageBoxa
                height = btmp.Height;                                   //Odredjujemo visinu ucitane fotografije
                width = btmp.Width;                                     //Odredjujemo sirinu ucitane fotografije


                //Switch petlja za selekciju odabranog filtera

                switch (effect)                                         
                {
                    case "sepia":
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                pixel_color = btmp.GetPixel(j, i);
                                sepiaEffect(pixel_color, i, j, btmp);                    //Za svaki piksel poziva se f-ja za njegovo transformisanje u sepia oblik
                            }
                        }
                        break;
                    case "blackandwhite":
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                pixel_color = btmp.GetPixel(j, i);
                                blackAndWhiteEffect(pixel_color, i, j, btmp);           //Za svaki piksel poziva se f-ja za njegovo transformisanje u b&w oblik
                            }
                        }
                        break;
                    case "negative":
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                pixel_color = btmp.GetPixel(j, i);
                                negativeEffect(pixel_color, i, j, btmp);                //Za svaki piksel poziva se f-ja za njegovo transformisanje u negative oblik
                            }
                        }
                        break;
                    case "colorize":
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                pixel_color = btmp.GetPixel(j, i);
                                colorizeEffect(pixel_color, i, j, btmp);                //Za svaki piksel poziva se f-ja za njegovo transformisanje u colorize oblik
                            }
                        }
                        break;
                    case "oldphoto":
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                pixel_color = btmp.GetPixel(j, i);
                                oldPhotoEffect(pixel_color, i, j, btmp);                //Za svaki piksel poziva se f-ja za njegovo transformisanje u old_photo oblik
                            }
                           
                            if (i % (height / 10) == 0 && pgbStatus.Value < 91 && Convert.ToInt32(btnStart.Tag)==2)
                            {
                                pgbStatus.Value += 10;                                  //Dio koda se odnosi na Benchmark dio programa i uvecava progres bar na svaki deseti dio transformisane foto za 10%
                            }
                        }
                        break;
                    case "blue":
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                pixel_color = btmp.GetPixel(j, i);                       //Za svaki piksel poziva se f-ja za njegovo transformisanje u blue oblik
                                blueEffect(pixel_color, i, j, btmp);
                            }
                        }
                        break;

                    case "contrast":
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                pixel_color = btmp.GetPixel(j, i);
                                contrastEffect(pixel_color, i, j, btmp);                 //Za svaki piksel poziva se f-ja za njegovo transformisanje u contrast_photo oblik
                            }
                        }
                        break;

                    case "red":
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                pixel_color = btmp.GetPixel(j, i);                         //Za svaki piksel poziva se f-ja za njegovo transformisanje u red oblik
                                redEffect(pixel_color, i, j, btmp);
                            }
                        }
                        break;

                    case "nightvision":
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                pixel_color = btmp.GetPixel(j, i);                        //Za svaki piksel poziva se f-ja za njegovo transformisanje u night vision oblik
                                nightVisionEffect(pixel_color, i, j, btmp);
                            }
                        }
                        break;
                }


                imgCurrentImage.Image = btmp;                                              //U image box smijestamo trasformisanu fotografiju
                vr_sekvencijalnog_izvrsenja.Stop();                                        // Zaustavljamo stopericu


                //Dio koda se odnosi na buffer bitmap-a koji omogucava UNDO i REDO opcije (FIFO algoritam primjenjen)
                trenutna_pozicija++;                        
                if (trenutna_pozicija > 4)
                {
                    rotirajBuffer();                                //Rotiranje buffera po fifo algoritmu izbacuje se onaj koji je prvi usao u buffer
                    trenutna_pozicija = 4;
                }
                buffer_brojac = trenutna_pozicija;
                buffer[trenutna_pozicija] = btmp;


            }
            catch (Exception exc)
            {
                //Ako smo pokusali primjeniti filter a najprije nismo importovali foto ispisace se poruka...
                MessageBox.Show("Najprije importujte sliku !!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Metoda za paralelno editovanje pixela fotografije
        public void ParallelProcessing(string effect)
        {
            try
            {
            int height, width;
            bitmap = (Bitmap)imgCurrentImage.Image;         //Smjestamo u objekat tipa bitmap-a ucitanu sliku iz imageBoxa

            height = bitmap.Height;                         //Odredjujemo visinu ucitane fotografije
            width = bitmap.Width;                           //Odredjujemo sirinu ucitane fotografije


            // Naredni dio koda 'sjecka' fotografiju na 8 vodoravnih dijelova i smijesta ih u 8 bitmapa
            // Ovo se radi iz razloga sto C# ne daje mogucnost visestrukih thredova kada je rijec o radu sa i na GUI-u

            bmpCrop1 = bitmap.Clone(new Rectangle(0, 0, width, height / 8), bitmap.PixelFormat);
            bmpCrop2 = bitmap.Clone(new Rectangle(0, height / 8, width, height / 8), bitmap.PixelFormat);
            bmpCrop3 = bitmap.Clone(new Rectangle(0, height / 4, width, height / 8), bitmap.PixelFormat);
            bmpCrop4 = bitmap.Clone(new Rectangle(0, 3 * height / 8, width, height / 8), bitmap.PixelFormat);
            bmpCrop5 = bitmap.Clone(new Rectangle(0, height / 2, width, height / 8), bitmap.PixelFormat);
            bmpCrop6 = bitmap.Clone(new Rectangle(0, 5 * height / 8, width, height / 8), bitmap.PixelFormat);
            bmpCrop7 = bitmap.Clone(new Rectangle(0, 6 * height / 8, width, height / 8), bitmap.PixelFormat);
            bmpCrop8 = bitmap.Clone(new Rectangle(0, 7 * height / 8, width, height / 8), bitmap.PixelFormat);


            Thread first_quaver = new Thread(() => thread_quaver(bmpCrop1, effect));                  // Thread koji vrsi transformaciju prve osmine foto
            first_quaver.Start();                                                                     // Startovanje prve niti
            Thread second_quaver = new Thread(() => thread_quaver(bmpCrop2, effect));                 // Thread koji vrsi transformaciju druge osmine foto
                second_quaver.Start();                                                                // Startovanje druge niti
                Thread third_quaver = new Thread(() => thread_quaver(bmpCrop3, effect));
            third_quaver.Start();
            Thread forth_quaver = new Thread(() => thread_quaver(bmpCrop4, effect));
            forth_quaver.Start();
            Thread fifth_quaver = new Thread(() => thread_quaver(bmpCrop5, effect));
            fifth_quaver.Start();
            Thread sixth_quaver = new Thread(() => thread_quaver(bmpCrop6, effect));
            sixth_quaver.Start();
            Thread seventh_quaver = new Thread(() => thread_quaver(bmpCrop7, effect));
            seventh_quaver.Start();
            Thread eight_quaver = new Thread(() => thread_quaver(bmpCrop8, effect));
            eight_quaver.Start();
            }
            catch (Exception exc)
            {
                //Ako smo pokusali primjeniti filter a najprije nismo importovali foto ispisace se poruka...
                MessageBox.Show("Najprije importujte sliku !!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metoda za tranformaciju dijelova fotografije (sekvencijelno izvrsavanje vise niti)
        public void thread_quaver(Bitmap btmp, string effect)
        {
            int height, width;
            height = btmp.Height;
            width = btmp.Width;
            Color pixel_color = new Color();


            switch (effect)
            {
                case "sepia":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            pixel_color = btmp.GetPixel(j, i);
                            sepiaEffect(pixel_color, i, j, btmp);
                        }
                    }
                    break;
                case "blackandwhite":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            pixel_color = btmp.GetPixel(j, i);
                            blackAndWhiteEffect(pixel_color, i, j, btmp);
                        }
                    }
                    break;
                case "negative":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            pixel_color = btmp.GetPixel(j, i);
                            negativeEffect(pixel_color, i, j, btmp);
                        }
                    }
                    break;
                case "colorize":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            pixel_color = btmp.GetPixel(j, i);
                            colorizeEffect(pixel_color, i, j, btmp);
                        }
                    }
                    break;
                case "oldphoto":
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        pixel_color = btmp.GetPixel(j, i);
                            oldPhotoEffect(pixel_color, i, j, btmp);

                        }
                    }
                break;
                case "blue":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            pixel_color = btmp.GetPixel(j, i);
                            blueEffect(pixel_color, i, j, btmp);

                        }
                    }
                    break;
                case "contrast":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            pixel_color = btmp.GetPixel(j, i);
                            contrastEffect(pixel_color, i, j, btmp);

                        }
                    }
                    break;

                case "red":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            pixel_color = btmp.GetPixel(j, i);
                            redEffect(pixel_color, i, j, btmp);

                        }
                    }
                    break;
                case "nightvision":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            pixel_color = btmp.GetPixel(j, i);
                            nightVisionEffect(pixel_color, i, j, btmp);

                        }
                    }
                    break;

            }
            brojac++;
         
        }
       
        // Event otkucaj kazaljke (Timer)
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            if (brojac == 8)                // Ako je svih 8 niti zavrsilo sa izvrsenjem onda...
            {
                imgCurrentImage.Image = MergeBitmaps();     //U image box smjestamo fotografiju koju spajamo iz 8 dijelova preko funkcije merge
                vr_paralelnog_izvrsenja.Stop();             //Zaustavljamo stopericu

                //Dio koda je vezan za benchmark test ispisivanje rezultata mjerenja vremena izvrsenja itd.
                if (btnStart.Tag == "4")
                {
                    pgbStatus.Value = 100;
                    lblParallelTime.Text = Math.Round(Convert.ToSingle(vr_paralelnog_izvrsenja.ElapsedMilliseconds), 2) + " [ms]";
                    float sekvencijelno_vrijeme = Convert.ToSingle(vr_sekvencijalnog_izvrsenja.ElapsedMilliseconds);
                    float paralelno_vrijeme = Convert.ToSingle(vr_paralelnog_izvrsenja.ElapsedMilliseconds);
                    rtbResults.Text = "Paralelizacijom procesa brzina izvršenja programa je uvećana za: " + Math.Round((100.0f * (sekvencijelno_vrijeme - paralelno_vrijeme) / sekvencijelno_vrijeme), 2) + "%";
                    rtbResults.Text += "\n\nCompleted !";
                    pgbStatus.Visible = false;
                    pgbStatus.Value = 0;
                    btnStart.BackgroundImage = Properties.Resources.stop;
                    btnStart.Text = "Stop";
                    btnStart.Tag = "5";
                }


                //Dio koda se odnosi na buffer bitmap-a koji omogucava UNDO i REDO opcije (FIFO algoritam primjenjen)
                    trenutna_pozicija++;
                    if (trenutna_pozicija > 4)
                    {
                    rotirajBuffer();                    //Rotiranje buffera po fifo algoritmu izbacuje se onaj koji je prvi usao u buffer
                    trenutna_pozicija = 4;
                    }
                    buffer_brojac = trenutna_pozicija;
                    buffer[trenutna_pozicija] = (Bitmap)imgCurrentImage.Image;

                    brojac = 0;
                
            }
            else
            {
                if (btnStart.Tag == "4")
                {
                    switch (brojac)
                    {
                        case 1:
                            pgbStatus.Value = 12;
                            break;
                        case 2:
                            pgbStatus.Value = 25;
                            break;
                        case 3:
                            pgbStatus.Value = 37;
                            break;
                        case 4:
                            pgbStatus.Value = 50;
                            break;
                        case 5:
                            pgbStatus.Value = 62;
                            break;
                        case 6:
                            pgbStatus.Value = 75;
                            break;
                        case 7:
                            pgbStatus.Value = 87;
                            break;
                    }
                }
            }
        }

        //Metoda kojom se vrsi ponovno spajanje 'isjeckanih' dijelova fotografije
        public Bitmap MergeBitmaps()
        {
            Bitmap outputImage = new Bitmap(bmpCrop1.Width, bmpCrop1.Height*8, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.DrawImage(bmpCrop1, new Rectangle(new Point(), bmpCrop1.Size),
                    new Rectangle(new Point(), bmpCrop1.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(bmpCrop2, new Rectangle(new Point(0, bmpCrop2.Height), bmpCrop2.Size),
                    new Rectangle(new Point(), bmpCrop2.Size), GraphicsUnit.Pixel);

                graphics.DrawImage(bmpCrop3, new Rectangle(new Point(0, 2*bmpCrop3.Height), bmpCrop3.Size),
                    new Rectangle(new Point(), bmpCrop3.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(bmpCrop4, new Rectangle(new Point(0, 3 * bmpCrop4.Height), bmpCrop4.Size),
                    new Rectangle(new Point(), bmpCrop4.Size), GraphicsUnit.Pixel);

                graphics.DrawImage(bmpCrop5, new Rectangle(new Point(0, 4 * bmpCrop5.Height), bmpCrop5.Size),
                    new Rectangle(new Point(), bmpCrop5.Size), GraphicsUnit.Pixel);

                graphics.DrawImage(bmpCrop6, new Rectangle(new Point(0, 5*bmpCrop6.Height), bmpCrop6.Size),
                    new Rectangle(new Point(), bmpCrop6.Size), GraphicsUnit.Pixel);

                graphics.DrawImage(bmpCrop7, new Rectangle(new Point(0, 6 * bmpCrop7.Height), bmpCrop7.Size),
                    new Rectangle(new Point(), bmpCrop7.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(bmpCrop8, new Rectangle(new Point(0, 7 * bmpCrop8.Height), bmpCrop8.Size),
                    new Rectangle(new Point(), bmpCrop8.Size), GraphicsUnit.Pixel);
            }

            return outputImage;
        }

        // Event klika na dugme import image
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
             uploadImage();         //Poziva se funkcija za upload fotografije
        }

        //Metoda za uploadovanje fotografija
        public void uploadImage()
        {
            OpenFileDialog fileOpen = new OpenFileDialog();

            fileOpen.Title = "Open Image";
            fileOpen.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg;*.gif;)|*.jpeg;*.bmp;*.png;*.jpg;*.gif";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(Image.FromFile(fileOpen.FileName));
                imgCurrentImage.Image = Image.FromFile(fileOpen.FileName);

                buffer_brojac = 0;
                trenutna_pozicija = buffer_brojac;
                buffer[buffer_brojac] = bitmap;
            }
            fileOpen.Dispose();
        }

        //Event klika na frejm za fotografiju
        private void imgCurrentImage_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if(pic.Image==null)         //Ako je frejm prazan
            {
                uploadImage();          // Poziv metode za upload fotografije
            }
        }

        // Event klika na dugme Save foto
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            saveImage();        //Poziv metode za Cuvanje foto na racunaru
        }

        // Metod za cuvanje fografija na racunaru
        public void saveImage()
        {
            try
            {
                SaveFileDialog fileSave = new SaveFileDialog();
                fileSave.Title = "Save image";
                fileSave.Filter = "JPEG (.jpg)|*.jpg|BMP (.bmp)|*.bmp|GIF (.gif)|*.gif";        // Ponudjeni formati za cuvanje

                ImageFormat format = ImageFormat.Png;
                if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(fileSave.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".gif":
                            format = ImageFormat.Gif;
                            break;
                    }
                    imgCurrentImage.Image.Save(fileSave.FileName, format);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Najprije importujte sliku !!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Event klika na dugme UNDO
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (trenutna_pozicija > 0)
            {
                trenutna_pozicija--;
                imgCurrentImage.Image = buffer[trenutna_pozicija];
            }
        }

        //Event klika na dugme REDO
        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (trenutna_pozicija < buffer_brojac)
            {
                trenutna_pozicija++;
                imgCurrentImage.Image = buffer[trenutna_pozicija];
            }
        }

        //rotira buffre za jedno mjesto izbacuje bitmap po fifo algoritmu
        public void rotirajBuffer()
        {
            for (int i = 1; i < 5; i++)
            {
                buffer[i - 1] = buffer[i];
            }
            buffer[4] = null;
        }

        //Event klika na dugme start za zapocinjanje Benchmark testa
        private void btnStart_Click(object sender, EventArgs e)
        {

            switch (btnStart.Tag)           //petlja za odredjivanje koraka testa
            {
                case "1":                   //Ako smo na prvom koraku

                    if(imgCurrentImage.Image == null)       //Ako nemamo importovanu foto 
                    {
                        uploadImage();                      // Pozovi metodu za importovanje
                    }
                    if (imgCurrentImage.Image != null)      //Ako frejm za foto nije prazan radi..
                    {
                        //Mjenjamo ikonicu start u next
                        btnStart.BackgroundImage = Properties.Resources.next;      
                        btnStart.Text = "Next";

                        //Onemogucujemo koristenje ostatka programa sve do zavrsetka testa
                        btnUploadImage.Enabled = false;
                        gpbLeft.Visible = false;
                        btnRedo.Enabled = false;
                        btnUndo.Enabled = false;
                        btnSaveImage.Enabled = false;
                        flpRight.Enabled = false;
                        gpbTest.Location = new Point(3, -3);

                        if (trenutna_pozicija < 4)
                        {
                            prethodna_pozicija = trenutna_pozicija;
                        }
                        else
                        {
                            prethodna_pozicija = trenutna_pozicija-1;
                        }
                        btnStart.Tag = "2";         //Povecavamo korak na 2.
                    }
                    break;

                case "2":
                    //Vrsi se sekvencijalno izvrsenje filtera old photo
                    flpRight.Enabled = true;
                    rbSekvencijelno.Checked = true;
                    pgbStatus.Visible = true;
                    oldphoto.PerformClick();
                    lblSequentialTime.Text = Math.Round(Convert.ToSingle(vr_sekvencijalnog_izvrsenja.ElapsedMilliseconds), 2) + " [ms]";
                    btnStart.Tag = "3";
                    flpRight.Enabled = false;
                    pgbStatus.Visible = false;
                    pgbStatus.Value = 0;
                    break;

                case "3":
                    
                    imgCurrentImage.Image = buffer[prethodna_pozicija];     //Vraca se netransformisana fotografija u frejm
                    btnStart.Tag = "4";                                     //Povecavamo korak na 4.
                    break;

                case "4":
                   
                    pgbStatus.Visible = true;
                    flpRight.Enabled = true;
                    rbParalelno.Checked = true;
                    oldphoto.PerformClick();                                //Vrsi se paralelno izvrsenje filtera old photo
                    flpRight.Enabled = false;
                    break;

                case "5":
                    // Okoncanje testa, omogucava se ponovo koristenje ostatka programa
                    imgCurrentImage.Image = bitmap;
                    buffer[0] = bitmap;

                    buffer_brojac = 0;
                    trenutna_pozicija = 0;
                    btnStart.BackgroundImage = Properties.Resources.start;
                    btnStart.Text = "Start";
                    btnStart.Tag = "1";

                    lblSequentialTime.Text = null;
                    lblParallelTime.Text = null;
                    rtbResults.Text = null;

                    btnRedo.Enabled = true;
                    btnUndo.Enabled = true;
                    btnSaveImage.Enabled = true;
                    flpRight.Enabled = true;
                    rbSekvencijelno.Checked = true;
                    btnUploadImage.Enabled = true;
                    gpbTest.Location = new Point(3, 96);
                    gpbLeft.Visible = true;
                    break;
            }
        }

        //Event klika na dugme exit u tool meniju
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();           //Zatvori program
        }

        //Event za zatvaranje programa
        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ako frejm za foto nije prazan pita se da li zelite sacuvati foto
            if (imgCurrentImage.Image != null)
            {
                DialogResult result = MessageBox.Show("Želite li sačuvati fotografiju?", "Da li ste sigurni?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:      
                        saveImage();                //Poziv funkcije za cuvanje fotografije na racunaru
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;            
                        break;
                }
            }
        }
        //Event klika na dugme about u tool meniju
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About aboutWindow = new About();        
            aboutWindow.Show();                         //Poziva se objekat klase About koji sadrzi info o projektu i autorima
        }

        private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.etf.ues.rs.ba/etf.php?task=view&fak_id=0");
        }

        //
        // Metode za primjenu filtera fotografija (Metode i event-i za editovanje bit mapa)
        //

        // Sepia filter
        public void sepiaEffect(Color pixel_color, int i, int j, Bitmap btmp)
        {
            int grayScale = (int)((pixel_color.R * .3) + (pixel_color.G * .59) + (pixel_color.B * .11));
            btmp.SetPixel(j, i, Color.FromArgb(pixel_color.A, grayScale * 1, Convert.ToInt32(grayScale * 0.95), Convert.ToInt32(grayScale * 0.65)));
        }

        // Crno bijeli filter
        public void blackAndWhiteEffect(Color pixel_color, int i, int j, Bitmap btmp)
        {
            int grayScale = Convert.ToInt32((pixel_color.R * .3) + (pixel_color.G * .59) + (pixel_color.B * .11));
            btmp.SetPixel(j, i, Color.FromArgb(pixel_color.A, grayScale, grayScale, grayScale));
        }

        //FIlter Negativ
        public void negativeEffect(Color pixel_color, int i, int j, Bitmap btmp)
        {
            btmp.SetPixel(j, i, Color.FromArgb(pixel_color.A, 255 - pixel_color.R, 255 - pixel_color.G, 255 - pixel_color.B));
        }

        //Filter za pojacanje intenziteta boja
        public void colorizeEffect(Color pixel_color, int i, int j, Bitmap btmp)
        {
            int outputRed=0, outputGreen=0, outputBlue=0;
            if (pixel_color.R > 255/2 && pixel_color.R<=235)
            {
               outputRed = pixel_color.R + 20;
            }
            else
            {
                if(pixel_color.R>20)
                     outputRed = pixel_color.R - 20;
            }

            if (pixel_color.G > 255 / 2 && pixel_color.G <= 235)
            {
                outputGreen = pixel_color.G + 20;
            }
            else
            {
                if (pixel_color.G > 20)
                    outputGreen = pixel_color.G - 20;
            }

            if (pixel_color.B > 255 / 2 && pixel_color.B <= 235)
            {
                outputBlue = pixel_color.B + 20;
            }
            else
            {
                if (pixel_color.B > 20)
                    outputBlue = pixel_color.B - 20;
            }
            btmp.SetPixel(j, i, Color.FromArgb(pixel_color.A, outputRed, outputGreen, outputBlue));
        }
        
        //Filter 'Stare fotografije'
        public void oldPhotoEffect(Color pixel_color, int i, int j, Bitmap btmp)
        {
            int grayScale = (int)((pixel_color.R * .3) + (pixel_color.G * .59) + (pixel_color.B * .11));
            btmp.SetPixel(j, i, Color.FromArgb(pixel_color.A, Convert.ToInt32(grayScale * 1), Convert.ToInt32(grayScale * 0.85), Convert.ToInt32(grayScale * 0.65)));
        }

        //Filter za pojacavanje kontrasta boja
        public void contrastEffect(Color pixel_color, int i, int j, Bitmap btmp)
        {
            double outputRed = pixel_color.R / 255.0;
            outputRed -= 0.5;
            outputRed *= 1.5;
            outputRed += 0.5;
            outputRed *= 255;
            if (outputRed < 0) outputRed = 0;
            if (outputRed > 255) outputRed = 255;

            double outputGreen = pixel_color.G / 255.0;
            outputGreen -= 0.5;
            outputGreen *= 1.5;
            outputGreen += 0.5;
            outputGreen *= 255;
            if (outputGreen < 0) outputGreen = 0;
            if (outputGreen > 255) outputGreen = 255;

            double outputBlue = pixel_color.B / 255.0;
            outputBlue -= 0.5;
            outputBlue *= 1.5;
            outputBlue += 0.5;
            outputBlue *= 255;
            if (outputBlue < 0) outputBlue = 0;
            if (outputBlue > 255) outputBlue = 255;
            btmp.SetPixel(j, i, Color.FromArgb(pixel_color.A, Convert.ToInt32(outputRed), Convert.ToInt32(outputGreen), Convert.ToInt32(outputBlue)));
        }

        //Filter crvena pozadina
        public void redEffect(Color pixel_color, int i, int j, Bitmap btmp)
        {
            int grayScale = (int)((pixel_color.R * .3) + (pixel_color.G * .59) + (pixel_color.B * .11));
            btmp.SetPixel(j, i, Color.FromArgb(pixel_color.A, Convert.ToInt32(grayScale * 0.9411), Convert.ToInt32(grayScale * 0.5), Convert.ToInt32(grayScale * 0.5)));
        }

        //Filter plava pozadina
        public void blueEffect(Color pixel_color, int i, int j, Bitmap btmp)
        {
            int grayScale = (int)((pixel_color.R * .3) + (pixel_color.G * .59) + (pixel_color.B * .11));
            btmp.SetPixel(j, i, Color.FromArgb(pixel_color.A, Convert.ToInt32(grayScale * 0.5294), Convert.ToInt32(grayScale * 0.8078), Convert.ToInt32(grayScale * 0.98)));
        }

        //Filter Night Vision
        public void nightVisionEffect(Color pixel_color, int i, int j, Bitmap btmp)
        {
            int grayScale = (int)((pixel_color.R * .3) + (pixel_color.G * .59) + (pixel_color.B * .11));
            btmp.SetPixel(j, i, Color.FromArgb(pixel_color.A, 255-Convert.ToInt32(grayScale * 1), 255-Convert.ToInt32(grayScale * 0.85), 255-Convert.ToInt32(grayScale * 0.65)));
        }


        // Dio koda koji se izvrsava na pritisak dugmeta nekog od ponudjenih filtera (Event click filter)
        private void btnEffectsClick(object sender, EventArgs e)
        {
            Button pressed_effect_button = (Button)sender;

            //Ako je izabrano sekvencialno izvrsenje radi
            if (rbSekvencijelno.Checked)
            {
                vr_sekvencijalnog_izvrsenja.Reset();                        //Resetujemo objekat stoperice
                vr_sekvencijalnog_izvrsenja.Start();                        //Startujemo stoprticu
                SequentialProcessing(pressed_effect_button.Name);           //Poziva se metoda za sekvencijelno izvrsenje dijela programa
            }
            else
            {
                vr_paralelnog_izvrsenja.Reset();                            //Resetujemo objekat stoperice
                vr_paralelnog_izvrsenja.Start();                            //Startujemo stoprticu
                ParallelProcessing(pressed_effect_button.Name);             //Poziva se metoda za paralelno izvrsenje dijela programa
            }
        }

    }
}
