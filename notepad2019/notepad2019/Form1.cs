using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace notepad2019
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    Form F2 = new Form();
           
            


        //        DialogResult me = MessageBox.Show("هل تريد حفظ الملف  ", "حفظ ملف ",
        //        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        //        if (me == DialogResult.Yes)
        //        {
        //            SaveFileDialog savefile = new SaveFileDialog();

        //            savefile.Title = "Save File";
        //            savefile.Filter = "Text Document(*.txt)|*.txt|(*.docx)|*.docx|All Filse|(*.*)";
        //            if (savefile.ShowDialog() == DialogResult.OK)
        //            {
        //                Rtextbox1.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);
        //                this.Text = savefile.FileName;
        //                Application.Exit();

        //                F2.Show();
        //            }
        //            else
        //            {
        //            Application.Exit();
        //            F2.Show();
        //            }
        //        }
        //        else
        //    {
        //        Application.Exit();
        //        F2.Show();
        //        }



                //Label l = new Label();
                //l.Text = "new file";
                //l.Location = new Point(1107, 43);

                //this.Controls.Add(l);

                Rtextbox1.Clear();

            
        }

        private void الخطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowHelp = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowApply = true;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                Rtextbox1.ForeColor = fontDialog1.Color;
                Rtextbox1.Font = fontDialog1.Font;
            }


        }

        private void فتحToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfile = new OpenFileDialog();//فتح الملفات 
            openfile.Title = "Open File";
            openfile.Filter = "Text Document(*.txt)|*.txt|(*.pdf)|*.pdf|(*.docx)|*.docx|All Files|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                Rtextbox1.LoadFile(openfile.FileName, RichTextBoxStreamType.PlainText);
                //this.Text = openfile.FileName;

            }


        }

        private void حفظباسمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();//حفظ ملف
            savefile.Title = "Save File";
            savefile.Filter = "Text Document(*.txt)|*.txt|(*.docx)|*.docx|All Filse|(*.*)";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                Rtextbox1.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);
                this.Text = savefile.FileName;
            }
        }

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        { 


            
        }

        private void انهاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ex = MessageBox.Show("هل تريد حفظ الملف قبل الاغلاق ", "اغلاق الملف ",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ex == DialogResult.Yes)
            {
                SaveFileDialog savefile = new SaveFileDialog();

                savefile.Title = "Save File";
                savefile.Filter = "Text Document(*.txt)|*.txt|(*.docx)|*.docx|All Filse|(*.*)";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    Rtextbox1.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = savefile.FileName;


                }
                else { Close(); }
            }
            else { Close(); }
        }

        private void الوقتالتاريخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rtextbox1.Text = System.DateTime.Now.ToString();
        }

        private void قصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rtextbox1.Cut();
        }

        private void نسخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rtextbox1.Copy();
        }

        private void لصقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rtextbox1.Paste();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rtextbox1.Clear();
        }

        private void تحديدالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rtextbox1.SelectAll();
        }

        private void الالوانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { Rtextbox1.ForeColor = colorDialog1.Color; }
        }

        private void تراجعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rtextbox1.Undo();//تراجع 
        }

        private void ملفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void طباعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog P = new PrintPreviewDialog();//اشتقاق كائن من كلاس الطباعة 

            P.ShowDialog();


        }

        private void نافذةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();



        }

        private void مناليمينالىاليسارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rtextbox1.RightToLeft = RightToLeft.Yes;
        }

        private void مناليسارالىاليمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rtextbox1.RightToLeft = RightToLeft.No;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void حولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad.F1 m = new Notepad.F1();
            m.ShowDialog();
        }

        private void لونالخلفيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { Rtextbox1.BackColor= colorDialog1.Color; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

