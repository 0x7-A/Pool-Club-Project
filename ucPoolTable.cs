using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace PoolClub
{
    public partial class ucPoolTable : UserControl
    {
        private int secondsCounter = 0;
        private int minutesCounter = 0;
        private int hoursCounter = 0;

        private int totalSecond = 0;

        public event EventHandler<PoolTableInfoEventArgs> onEndBuutonClick;

        private enum enBtnState { Start = 0, Pause = 1};
        private enBtnState buttonState = enBtnState.Start;


        private string _TablePLayer;
        private string _TableName;


        [Category("Pool State")]
        private bool IsAvailable { set;  get; }



        [Category("Pool Settings")]
        public string TablePlayer { 
            get
            {
                return _TablePLayer;
            }
            set
            {
                _TablePLayer = value;
                lblTablePlayer.Text = value;
            }
        }


        [Category("Pool Settings")]
        public string TableName
        {
            get
            {
                return _TableName;
            }
            set
            {
                _TableName = value;
                gbPoolTable.Text = value;
            }
        }


        [Category("Pool Settings")]
        public float HourlyRate { get; set; } = 25;

        public ucPoolTable()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsCounter++;

            if(secondsCounter >= 60)
            {
                minutesCounter++;
                secondsCounter = 0;


                if(minutesCounter >= 60)
                {
                    minutesCounter = 0;
                    hoursCounter++;
                    lblHours.Text = hoursCounter.ToString();
                }

                lblMinutes.Text = minutesCounter.ToString();

            }

            lblSeconds.Text = secondsCounter.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnClicked();
        }

        private void btnClicked()
        {
            switch (buttonState)
            {
                case enBtnState.Start:
                    timer1.Enabled = true;
                    btnStart.Text = "Pause";
                    pTableLight.BackColor = Color.Firebrick;
                    buttonState = enBtnState.Pause;
                    btnEnd.Visible = true;
                    IsAvailable = false;
                    break;
                case enBtnState.Pause:
                    timer1.Enabled = false;
                    btnStart.Text = "continue";
                    pTableLight.BackColor = Color.Silver;
                    buttonState = enBtnState.Start;
                    pTableLight.BackColor = Color.Firebrick;
                    break;

            }
        }


     

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            totalSecond = TotalSeconds();
            RaiseonEndBuutonClick(new PoolTableInfoEventArgs(getTimeConsumed(), totalSecond, HourlyRate, GetTotalFees()));
            pTableLight.BackColor = Color.DarkGreen;
            btnEnd.Visible = false;
            lblTablePlayer.Text = "";
            btnStart.Text = "Start";
            buttonState = enBtnState.Start;
            IsAvailable = true;
            

            hoursCounter = 0;
            minutesCounter = 0;
            secondsCounter = 0;


        }

        protected virtual void RaiseonEndBuutonClick(PoolTableInfoEventArgs e)
        {
            onEndBuutonClick?.Invoke(this, e);
        }

        private string getTimeConsumed()
        {
            return hoursCounter.ToString("D2") +  ":" + minutesCounter.ToString("D2") + ":" + secondsCounter.ToString("D2");
        }

        private int TotalSeconds()
        {
            return hoursCounter * 3600 + minutesCounter * 60 + secondsCounter; 
        }

        private float  GetTotalFees()
        {
            return   HourlyRate * totalSecond / 3600;
        }

      
    }

    public class PoolTableInfoEventArgs : EventArgs
    {
        public int TotalSecond { get; }
        public string TimeConsumed { get; }
        public float HourlyRate { get; }
        public float TotalFees { get; }

        public string TableName {  get; }

        public PoolTableInfoEventArgs(string TimeConsumed, int TotalSecond, float HourlyRate, float TotalFees)
        {
            this.TimeConsumed = TimeConsumed;
            this.TotalSecond = TotalSecond;
            this.TotalFees = TotalFees;
            this.HourlyRate = HourlyRate;
            this.TableName = TableName;
        }
    }
}
