using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop_sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Coffee shop operations simulator
        // 1 minute = 1 second
        // 1 hour = 1 minute
        // price = 35
        private int customerCount = 5;
        private int productCost = 30, productPrice = 35;
        private int revenue = 0;
        private int servedCustomer = 0, pendingOrders = 0;
        private bool orderisActive = false;
        private void startButton_Click(object sender, EventArgs e)
        {
            operationTimer = new Timer();
            operationTimer.Interval = 1000;
            operationTimer.Tick += new EventHandler(operationTimer_Tick);

            orderTimer = new Timer();
            orderTimer.Interval = 1000;
            orderTimer.Tick += new EventHandler(orderTimer_Tick);

            customerTimer = new Timer();
            customerTimer.Interval = 1000;
            customerTimer.Tick += new EventHandler(pendTimer_Tick);

            waitingTimer = new Timer();
            waitingTimer.Interval = 1000;
            waitingTimer.Tick += new EventHandler(waitingTimer_Tick);

            prepTimer = new Timer();
            prepTimer.Interval = 1000;
            prepTimer.Tick += new EventHandler(prepTimer_Tick);

            operationTimer.Start();
            orderTimer.Start();
            customerTimer.Start();
            waitingTimer.Start();
            prepTimer.Start();

            startButton.Enabled = false;
            stopButton.Enabled = true;
            
        }

        private static int randomCust()
        {
            Random rand = new Random();
            return rand.Next(1, 10);
        }

        private static int randomSec()
        {
            Random rand = new Random();
            return rand.Next(2, 5);
        }
        private static int randomWait()
        {
            Random rand = new Random();
            return rand.Next(3, 10);
        }
        private static int randomPrep()
        {
            Random rand = new Random();
            return rand.Next(2, 4);
        }
        private int openSecond = 0, openMin = 0, openHour = 0; // operationTimer variables
        private void operationTimer_Tick(object sender, EventArgs e)
        {
            openSecond += 1;
            if (openSecond == 60)
            {
                openSecond = 0;
                openMin += 1;
                if (openMin == 60)
                {
                    openMin = 0;
                    openHour += 1;
                }
            }
            openTimeSec.Text = openSecond.ToString();
            openTimeMin.Text = openMin.ToString();
            openTimeHour.Text = openHour.ToString();
        }

        private int orderSec = randomSec(); // order timer variables

        private void orderTimer_Tick(object sender, EventArgs e)
        {
            if (orderisActive)
            {
                orderSec--;
                if (orderSec == 0)
                {
                    customerCount--;
                    pendingOrders++;
                    pendOrd.Text = pendingOrders.ToString();
                    orderisActive = false;
                }
                if (orderSec < 0)
                    orderSec = randomSec();
            }
            orderTimeSec.Text = orderSec.ToString();
        }
        private int custInterval = randomCust();
        private void pendTimer_Tick(object sender, EventArgs e) //customer timer
        {
            custInterval -= 1;
            if (custInterval < 0)
            {
                customerCount += 1;
                
                custInterval = randomCust();
            }
            customerNumBox.Text = customerCount.ToString();
           // pendOrd.Text = custInterval.ToString();
        }

        private int waitSec = randomWait(); // wait time variable
        private void waitingTimer_Tick(object sender, EventArgs e)
        {
            if (!orderisActive && customerCount > 0)
            {
                //waitTimeSec.Text = "0";
                orderisActive = true;
                orderSec = randomSec();
                waitSec = randomWait();
                if (customerCount == 1)
                {
                    waitSec = 0;
                }
            }
            else if (orderisActive && customerCount > 1)
            {
                waitSec--;
                if (waitSec == 0 && orderisActive)
                    customerCount--;
                if (waitSec < 0)
                    waitSec = randomWait();
            }
            waitTimeSec.Text = waitSec.ToString();
        }

        private int prepSec = randomPrep();
        private void prepTimer_Tick(object sender, EventArgs e)
        {
            prepSec--;
            if (prepSec == 0)
            {
                pendingOrders--;
                pendOrd.Text = pendingOrders.ToString();
            }
            if (prepSec < 0 && pendingOrders > 0)
                prepSec = randomPrep();
            if (pendingOrders == 0)
                prepSec = 0;
            prepTimeSec.Text = prepSec.ToString();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            operationTimer.Dispose();
            orderTimer.Dispose();
            customerTimer.Dispose();
            waitingTimer.Dispose();
            prepTimer.Dispose();

            openHour = 0;
            openMin = 0;
            openSecond = 0;
            customerCount = 0;
            
            

            startButton.Enabled = true;
            stopButton.Enabled = false;
        }
    }
}
