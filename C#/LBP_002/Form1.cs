using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomUIControls.Graphing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;



namespace LBP_002
{
    public partial class panel1 : Form
    {
        public panel1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
            serialPort1.DataReceived += serialPort1_DataReceived;



        }

        private void left_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void On_btn_Click(object sender, EventArgs e)
        {
           
            serialPort1.WriteLine("S");
            On_btn.Enabled = false;
            OFF_btn.Enabled = true;
            On_btn.BackgroundImage = Image.FromFile("C:\\Users\\BBillionaire\\Desktop\\LBP_PROJECT\\Images\\Buttons\\Neutral.png");
            OFF_btn.BackgroundImage = Image.FromFile("C:\\Users\\BBillionaire\\Desktop\\LBP_PROJECT\\Images\\Buttons\\1OFF.png");
            groupBox1.Text = ("ПИТАНИЕ = ВКЛ");
            groupBox1.Text = ("ПИТАНИЕ = ВКЛ");
            //Fixed_V.Visible = true;
            NFixed_V.Visible = true;
            dezhurka_text.Text = ("АКТИВНЫЙ РЕЖИМ");
            groupBox2.Visible = true;
            fized_v.Visible = true;
          








        }

        private void OFF_btn_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("D");
            On_btn.Enabled = true;
            OFF_btn.Enabled = false;
            OFF_btn.BackgroundImage = Image.FromFile("C:\\Users\\BBillionaire\\Desktop\\LBP_PROJECT\\Images\\Buttons\\Neutral.png");
            On_btn.BackgroundImage = Image.FromFile("C:\\Users\\BBillionaire\\Desktop\\LBP_PROJECT\\Images\\Buttons\\1ON.png");
            groupBox1.Text = ("ПИТАНИЕ = ВЫКЛ");
            Fixed_V.Visible = false;
            NFixed_V.Visible = false;
            dezhurka_text.Text = ("ДЕЖУРНЫЙ РЕЖИМ");
            groupBox2.Visible = false;
            fized_v.Visible = false;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("S");
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = true;
            pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\BBillionaire\\Desktop\\LBP_PROJECT\\Images\\Buttons\\Neutral_2.png");
            pictureBox2.BackgroundImage = Image.FromFile("C:\\Users\\BBillionaire\\Desktop\\LBP_PROJECT\\Images\\Buttons\\OFF_1.png");
            groupBox2.Text = ("ОСВЕЩЕНИЕ = ВКЛ");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("D");
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = false;
            pictureBox2.BackgroundImage = Image.FromFile("C:\\Users\\BBillionaire\\Desktop\\LBP_PROJECT\\Images\\Buttons\\Neutral_1.png");
            pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\BBillionaire\\Desktop\\LBP_PROJECT\\Images\\Buttons\\On_1.png");
            groupBox2.Text = ("ОСВЕЩЕНИЕ = ВЫКЛ");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox1.Text = ("ОСВЕЩЕНИЕ ");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Text = ("Питание = ");
        }

        private void panel1_Load(object sender, EventArgs e)
        {
            OFF_btn.Enabled = false;
        }



        private void dezhurka_text_Click(object sender, EventArgs e)
        {

        }

        private void Fixed_V_Enter(object sender, EventArgs e)
        {

        }

        private void c2DPushGraph1_Click(object sender, EventArgs e)
        {

        }

        private void aGauge1_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void Degree_label_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void aGauge2_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void aGauge2_ValueInRangeChanged_1(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void Volt_changer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Val_trackBar_Scroll(object sender, EventArgs e)
        {
            
        }

        private void Volt_changer_ValueChanged_1(object sender, EventArgs e)
        {

            //  aGauge4.Value = Volt_changer.Value;
            //  serialPort1.WriteLine(Volt_changer.Value.ToString());
            // Degree_label.Text = "Degree =" + Volt_changer.Value.ToString();


        }

       
        private void aGauge4_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        
        }

        private void VoltChanger_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void amp_trackBar_Scroll(object sender, EventArgs e)
        {
            serialPort1.WriteLine(amp_trackBar.Value.ToString() );
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        string Datareceive;
        double DataFromPort_;
        double k1, k2, k3, k4, k5, k6,k7;
        double aa2,aa3;
      
        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

         Datareceive = serialPort1.ReadLine();
            double.TryParse(Datareceive, out DataFromPort_);
            //
            if (DataFromPort_ >= 0 && DataFromPort_ < 1024)
                k1 = DataFromPort_;
                
            //
            if (DataFromPort_ >= 1025 && DataFromPort_ < 2049)
                k2 = DataFromPort_;
            //
          aGauge4.Value = (int)k1*20-17000;
            //aGauge1.Value = (int)k2;
            
         aa2 =( (k1 - 1024) * (5.0 / 1023.0));

           aa3 = Math.Round(aa2, 1, MidpointRounding.AwayFromZero);

   
 

        }
        private delegate void LineReceivedEvent(string POT);

        private void label7_Click(object sender, EventArgs e)
        {

        }


      

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
        }

       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Fixed_V.Visible = true;
            pictureBox10.Enabled = false;
            pictureBox3.Enabled = true;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("260");
            label1.ForeColor = Color.LightGray;
            label21.ForeColor = Color.LightGray;
            label22.ForeColor = Color.LightGray;
            label20.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

            serialPort1.WriteLine("261");
            label20.ForeColor = Color.LightGray;
            label21.ForeColor = Color.LightGray;
            label22.ForeColor = Color.LightGray;
            label1.ForeColor = Color.Black;
        }

        private void label21_Click(object sender, EventArgs e)
        {

            serialPort1.WriteLine("262");
            label20.ForeColor = Color.LightGray;
            label1.ForeColor = Color.LightGray;
            label22.ForeColor = Color.LightGray;
            label21.ForeColor = Color.Black;
        }

        private void label22_Click(object sender, EventArgs e)
        {

            serialPort1.WriteLine("263");
            label20.ForeColor = Color.LightGray;
            label21.ForeColor = Color.LightGray;
            label1.ForeColor = Color.LightGray;
            label22.ForeColor = Color.Black;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("5");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            serialPort1.WriteLine("21");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("42");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("89");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("125");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("202");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("214");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("244");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            Fixed_V.Visible = false;
            pictureBox3.Enabled = false;
            pictureBox10.Enabled = true;

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
         timer1.Interval = 50; // 500 миллисекунд

         serialPort1.WriteLine(trackBar3.Value.ToString());
            //label16.Text = ("" + aa3);
            label19.Text = ("V: " + aa3);
            label18.Text = ("A: " + aa3);




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
