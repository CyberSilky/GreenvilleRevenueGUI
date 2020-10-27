using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

//Name: James Shoemaker
//Date: 0329/2020
//Program Description: Week 2 assignment

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            //Initialize variables

            int last_years_contestants = 0;
            int this_years_contestants = 0;
            int display_data = 0;


            //Declare Constant
            const double EXPECTED_REVENUE = 750.00;

            last_years_contestants = Convert.ToInt32(txtLastYear.Text);
            this_years_contestants = Convert.ToInt32(txtThisYear.Text);

            //Calculate the contestants
            display_data = last_years_contestants + this_years_contestants;

            //Create message to user that includes the conestant variables
            lblResponse2.Text = $" Last year's competition had {last_years_contestants} contestants and this year's has {this_years_contestants} contestants.";

            //Create a message to the user that display's the constant
            lblResponse3.Text = $" Revenue expected this year is ${EXPECTED_REVENUE}";
            
            //Create if statements for different calculations
            if(display_data > last_years_contestants * 2)
            {
                lblResponse1.Text = " The competition is more than twice as big this year!";
            }
            if(this_years_contestants > last_years_contestants && this_years_contestants < last_years_contestants *2)
            {
                lblResponse1.Text = " The competition is bigger than ever!";
            }
            if(this_years_contestants <= last_years_contestants)
            {
                lblResponse1.Text = " A tighter race this year! Come and cast your vote!";
            }
                   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
