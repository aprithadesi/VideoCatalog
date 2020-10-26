using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using IWshRuntimeLibrary;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Video_Processors
{
    public partial class Loaders : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["Video_Processors.Properties.Settings.mysqlset"].ConnectionString;
        Bitmap bmp = null;
        public string line, fpath, tseek, ff, message, tt, mm, pathname, filepath, duration;
        public int ExitCode;
        public Loaders()
        {
            InitializeComponent();
        }
        enum RecycleFlag : int

        {

            SHERB_NOCONFIRMATION = 0x00000001, // No confirmation, when emptying

            SHERB_NOPROGRESSUI = 0x00000001, // No progress tracking window during the emptying of the recycle bin

            SHERB_NOSOUND = 0x00000004 // No sound when the emptying of the recycle bin is complete

        }
        [DllImport("Shell32.dll")]

        static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);


        public string Sfname;



        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = dialog.FileName;
                }
            }
        }
        private void textbox1_dragdrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                textBox1.Text = files.First(); //select the first one  
        }

        private void textbox1_dragover(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void btn_pro_Click(object sender, EventArgs e)
        {
            string sourceFile = textBox1.Text;
            //string fileName = Path.GetFileName(sourceFile);
            string fileName = Path.GetFileNameWithoutExtension(sourceFile);
            string destinationFile = "E:\\Content\\" + fileName + ".mp4";
            // string sourceFile = textBox1.Text;
            //string fileName = Path.GetFileName(sourceFile);
            //string fileName = Path.GetFileNameWithoutExtension(sourceFile);

            //  string destinationFile = "E:\\Content\\" + fileName + ".mp4";
            //  MessageBox.Show(fileName);

            //  MessageBox.Show(destinationFile);
            // Create Shot Cut before moving

            WshShell wsh = new WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut("e:\\pro\\" + fileName + ".lnk") as IWshRuntimeLibrary.IWshShortcut;
            shortcut.Arguments = "";
            shortcut.TargetPath = destinationFile;

            // not sure about what this is for
            shortcut.WindowStyle = 1;
            shortcut.Description = "PRO ShortCuts";
            shortcut.WorkingDirectory = destinationFile;
            // shortcut.IconLocation = "specify icon location";
            shortcut.Save();


            // To move a file or folder to a new location:
            //System.IO.File.Move(sourceFile, destinationFile);

            // To move an entire directory. To programmatically modify or combine
            // path strings, use the System.IO.Path class.
            //System.IO.File.Move(sourceFile, destinationFile);
            //CopyFile();

            // System.IO.File.Copy(sourceFile, destinationFile);

            lbl_pro.Text = "PRO";

        }

        private void btn__Click(object sender, EventArgs e)
        {

            //string fileName = Path.GetFileName(sourceFile);
            // string fileName = Path.GetFileNameWithoutExtension(sourceFile);
            string sourceFile = textBox1.Text;
            //string fileName = Path.GetFileName(sourceFile);
            string fileName = Path.GetFileNameWithoutExtension(sourceFile);
            string destinationFile = "E:\\Content\\" + fileName + ".mp4";

            //  MessageBox.Show(fileName);

            //  MessageBox.Show(destinationFile);
            // Create Shot Cut before moving

            WshShell wsh = new WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut("e:\\pre\\" + fileName + ".lnk") as IWshRuntimeLibrary.IWshShortcut;
            shortcut.Arguments = "";
            shortcut.TargetPath = destinationFile;

            // not sure about what this is for
            shortcut.WindowStyle = 1;
            shortcut.Description = "PRE ShortCuts";
            shortcut.WorkingDirectory = destinationFile;
            // shortcut.IconLocation = "specify icon location";
            shortcut.Save();


            // To move a file or folder to a new location:
            //System.IO.File.Move(sourceFile, destinationFile);

            // To move an entire directory. To programmatically modify or combine
            // path strings, use the System.IO.Path class.

            // below  function is executed by seprate class
            //System.IO.File.Move(sourceFile, destinationFile);
            //  CopyFile();

            // System.IO.File.Copy(sourceFile, destinationFile);
            lbl_pre.Text = "PRE";

        }
        public void CopyFile()
        {
            string sourceFile = textBox1.Text;
            //string fileName = Path.GetFileName(sourceFile);
            string fileName = Path.GetFileNameWithoutExtension(sourceFile);
            //string destinationFile = "E:\\Content\\" + fileName + ".mp4";

            string destinationFile = "E:\\Content\\" + fileName + ".mp4";
            System.IO.File.Move(sourceFile, destinationFile);
        }


        private void Btn_copyonly_Click(object sender, EventArgs e)
        {
            CopyFile();
            lbl_copy.Text = "Copied";
        }

        private void Btn_both_Click(object sender, EventArgs e)
        {
            btn_pre.PerformClick();
            btn_pro.PerformClick();
            btn_clr.PerformClick();
                        

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_panic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Active");
        }

        private void btnaddpath_Click_1(object sender, EventArgs e)
        {
            AddPath aa = new AddPath(this);
            aa.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
              //  if //(this.validation())
                {
                    string name = txtname.Text.Trim();
                    string type = ddltype.Text.Trim();
                  string category = ddlcategory.Text.Trim();
                    string timeseek = dtptime.Text.Trim();

                    StreamReader errorreader;
                    var cmd = "ffmpeg -i " + string.Format("\"{0}\"", filepath.ToString());
                    Process ffmpeg = new Process();
                    ffmpeg.StartInfo.RedirectStandardOutput = true;
                    ffmpeg.StartInfo.RedirectStandardError = true;
                    ffmpeg.StartInfo.UseShellExecute = false;
                    ffmpeg.StartInfo.CreateNoWindow = true;
                    ffmpeg.StartInfo.FileName = "cmd.exe";
                    ffmpeg.StartInfo.Arguments = "/C " + cmd;
                    ffmpeg.Start();
                    ffmpeg.BeginOutputReadLine();
                    errorreader = ffmpeg.StandardError;
                    while ((line = errorreader.ReadLine()) != null)
                    {
                        line = line.ToString() + Environment.NewLine;
                        if (line.Contains("Duration"))
                        {
                            //// txtduration.Text = line.ToString();
                            duration = line.ToString();
                        }
                    }
                    ffmpeg.Close();


                    filepath = filepath.Replace(@"\", @"\\");
                    Image img = pictureBox1.Image;
                    byte[] imageBt = imgToByteArray(img);

                    int rand = RandomNumber(1, 100);

                    string[] s = { "\\bin" };
                    string imgPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Images\\" + rand + ".jpg";
                    imgPath = imgPath.Replace(@"\", @"\\");
                    // MessageBox.Show(imgPath);
                    img.Save(imgPath, ImageFormat.Jpeg);

                    DateTime now = DateTime.Now;
                    string currentdate = now.ToString("yyyy-MM-dd");
                    string Dated = currentdate.ToString();

                    MySqlConnection mConn = new MySqlConnection(constring);
                    string Query = "insert into processor.videoinfo(id,name,type,category,filepath,duration,timeseek,bimage,imgpath,dated)Values(null,'" + name + "','" + type + "','" + category + "','" + filepath + "','" + duration + "','" + timeseek + "','" + imageBt + "','" + imgPath + "','" + Dated + "')";
                    MySqlCommand cd = new MySqlCommand(Query, mConn);
                    mConn.Open();
                    MySqlDataReader reader = cd.ExecuteReader();
                    reader.Close();
                    mConn.Close();
                    MessageBox.Show("Data Saved");
                 //   txtname.Text = "";
                   // ddltype.Text = "";
                    if (ddltype != null)
                        ddltype.SelectedIndex = -1;
                    ddlcategory.Text = "";
                    if (ddlcategory != null)
                        ddlcategory.SelectedIndex = -1;
                    ////txtfilepath.Text = "";
                    ////txtduration.Text = "";
                    dtptime.Text = "00:00:00";
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            lbl_copy.Text = "Ready";
            lbl_pre.Text = "Ready";
            lbl_pro.Text = "Ready";
          

        }

        private void btn_mst_Click(object sender, EventArgs e)
        {
            string sourceFile = textBox1.Text;
            //string fileName = Path.GetFileName(sourceFile);
            string fileName = Path.GetFileNameWithoutExtension(sourceFile);
            string destinationFile = "E:\\Content\\" + fileName + ".mp4";
            // string sourceFile = textBox1.Text;
            //string fileName = Path.GetFileName(sourceFile);
            //string fileName = Path.GetFileNameWithoutExtension(sourceFile);

            //  string destinationFile = "E:\\Content\\" + fileName + ".mp4";
            //  MessageBox.Show(fileName);

            //  MessageBox.Show(destinationFile);
            // Create Shot Cut before moving

            WshShell wsh = new WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut("e:\\MUST\\" + fileName + ".lnk") as IWshRuntimeLibrary.IWshShortcut;
            shortcut.Arguments = "";
            shortcut.TargetPath = destinationFile;

            // not sure about what this is for
            shortcut.WindowStyle = 1;
            shortcut.Description = "must ShortCuts";
            shortcut.WorkingDirectory = destinationFile;
            // shortcut.IconLocation = "specify icon location";
            shortcut.Save();


            // To move a file or folder to a new location:
            //System.IO.File.Move(sourceFile, destinationFile);

            // To move an entire directory. To programmatically modify or combine
            // path strings, use the System.IO.Path class.
            //System.IO.File.Move(sourceFile, destinationFile);
            //CopyFile();

            // System.IO.File.Copy(sourceFile, destinationFile);

            lbl_pro.Text = "MUST";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))// Check for not empty
            {
                // Do something
                // sPlayerExe: C:\Program Files\MPC-BE x64\mpc-be64.exe
                // vidFile:    "E:\TV\Konzerte, Shows\Seer - Open Air in Grundlsee 2014.mp4"
                // startPos:   /startpos 01:14:10
                
            }
        }

        public void recyblebin()
        {

            SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlag.SHERB_NOSOUND | RecycleFlag.SHERB_NOCONFIRMATION);
        }

        private void btn_rbc_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            recyblebin();
        }

        private void Loaders_Load(object sender, EventArgs e)
        {

        }

        private void btn_thumbgen_Click(object sender, EventArgs e)

        {
            filepath = textBox1.Text;

            if ((!string.IsNullOrEmpty(filepath)) && (!string.IsNullOrEmpty(dtptime.Text)))
            {
                CreateBitmapAtRuntime();

                string video = filepath.ToString();
                // string thumbnail = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "out.jpg";
                //string thumbnail = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Visual Studio 2017\\Backup Files\\MediaCenterTestKit\\MediaCenterTestKit\\bin\\Debug\\" + "out.jpg";

                string[] s = { "\\bin" };
                string thumbnail = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\bin\\Debug\\" + "out.jpg";

                //  var cmd = "ffmpeg  -itsoffset -1  -i " + '"' + video + '"' + " -vcodec mjpeg -vframes 1 -an -f rawvideo -s 320x240 -y " + '"' + thumbnail + '"';
                //  var cmd = "ffmpeg -i " + txtfilepath.Text + " -ss " + dtptime.Text + " -f image2 -vframes 1 -y " + thumbnail;

                var cmd = "ffmpeg -ss " + dtptime.Text + " -i " + '"' + video + '"' + " -vframes 1 -q:v 2 -y " + '"' + thumbnail + '"';

                var startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C " + cmd
                };

                var process = new Process
                {
                    StartInfo = startInfo
                };

                process.Start();
                process.WaitForExit(5000);

                MemoryStream ms = new MemoryStream(System.IO.File.ReadAllBytes(thumbnail));
                bmp = (Bitmap)Image.FromStream(ms);
                Image kk = bmp.GetThumbnailImage(256, 256, null, new IntPtr());
                this.Refresh();
                //pictureBox1.Image = bmp;
                pictureBox1.Image = kk;
            }
            else
            {
                MessageBox.Show("Enter FilePath and TimeSeek");
            }

        }
        public static byte[] imgToByteArray(Image inImg)
        {
            ImageConverter imgCon = new ImageConverter();
            return (byte[])imgCon.ConvertTo(inImg, typeof(byte[]));
        }
        public void CreateBitmapAtRuntime()
        {
            try
            {
                //String t1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "out.jpg"; 
                //String t1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Visual Studio 2017\\Backup Files\\MediaCenterTestKit\\MediaCenterTestKit\\bin\\Debug\\" + "out.jpg";

                string[] s = { "\\bin" };
                string t1 = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\bin\\Debug\\" + "out.jpg";


                Bitmap image = new Bitmap(256, 256);
                using (Graphics g = Graphics.FromImage(image))
                {
                    g.FillRectangle(Brushes.White, 0, 0, 256, 256);
                }
                if (System.IO.File.Exists(t1))
                {
                    System.IO.File.Delete(t1);
                }
                image.Save(t1);
                image.Dispose();
                GC.Collect();
            }
            catch (Exception ex)
            {
                //
            }
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string convertImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //convert the image to byte array
                image.Save(ms, ImageFormat.Jpeg);
                byte[] bin = ms.ToArray();
                //convert byte array to base64 string
                return Convert.ToBase64String(bin);
            }
        }
        private void btnaddpath_Click(object sender, EventArgs e)
        {
            AddPath aa = new AddPath(this);
            aa.Show();
        }

    }
}




   

