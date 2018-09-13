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
        private int customerCount = 0;
        private int productCost = 30, productPrice = 35;
        private int revenue = 0;
        private int servedCustomer = 0, pendingOrders = 0;
        private bool orderisActive = false;
        private int timeSpentSec = 0, timeSpentMin = 0;
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

            //clear data for new simulation session
            revenue = 0;
            orderisActive = false;
            servedCustomer = 0;
            pendingOrders = 0;
            timeSpentMin = 0;
            timeSpentSec = 0;
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
                if (openMin == 24)
                {
                    openMin = 0;
                    openHour += 1;
                }
            }
            openTimeSec.Text = openSecond.ToString();
            openTimeMin.Text = openMin.ToString();
            openTimeHour.Text = openHour.ToString();
        }

        private int orderSec = 0; // order timer variables

        private void orderTimer_Tick(object sender, EventArgs e)
        {
            if (orderisActive)
            {
                orderSec--;
                timeSpentSec++;
                if (orderSec == 0)
                {
                    customerCount--;
                    pendingOrders++;
                    pendOrd.Text = pendingOrders.ToString();
                    orderisActive = false;
                }
                if (orderSec < 0)
                    orderSec = randomSec();

                if (timeSpentSec == 60)
                {
                    timeSpentMin += 1;
                    timeSpentSec = 0;
                }
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
            nextCust.Text = custInterval.ToString();
        }

        private int waitSec = 0; // wait time variable
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
            if (prepSec > 0)
                timeSpentSec++;

            if (timeSpentSec == 60)
            {
                timeSpentMin++;
                timeSpentSec = 0;
            }
            if (prepSec == 0)
            {
                pendingOrders--;
                servedCustomer++;
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

            //reset timer values
            openHour = 0;
            openMin = 0;
            openSecond = 0;
            customerCount = 0;

            //bunch of stuff here: Show results of the simulation session.
            // daily = itself
            // weekly = daily * 7
            // monthly = weekly * 4
            // yearly = monthly * 12
            customersServed();
            totalRevenue();
            avgTime();
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }
        private void customersServed()
        {
            csDay.Text = servedCustomer.ToString();
            csWeek.Text = (servedCustomer * 7).ToString();
            csMonth.Text = (int.Parse(csWeek.Text)*4).ToString();
            csYear.Text = (int.Parse(csMonth.Text) * 12).ToString();

        }
        
        private void totalRevenue()
        {
            for (int x = 0; x < servedCustomer; x++)
            {
                revenue += (productPrice - productCost);
            }
            trDay.Text = revenue.ToString();
            trWeek.Text = (revenue * 7).ToString();
            trMonth.Text = (int.Parse(trWeek.Text) * 4).ToString();
            trYear.Text = (int.Parse(trMonth.Text) * 12).ToString();
            avgRev.Text = (revenue / servedCustomer).ToString();
        }
        private void avgTime()
        {
            for (int i = 0; i < timeSpentMin; i++)
            {
                timeSpentMin--;
                timeSpentSec += 60;
            }
            double avgTimeSpent = timeSpentSec / servedCustomer;
            double avgMins = 0;
            for (int x = 0; x < avgTimeSpent; x++)
            {
                if (x == 60)
                {
                    avgMins++;
                    x = 0;
                    avgTimeSpent -= 60;
                }
            }
            avgMin.Text = avgMins.ToString();
            avgSec.Text = avgTimeSpent.ToString();
        }
    }
}
