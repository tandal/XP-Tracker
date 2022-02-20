namespace XP_Tracker;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    int xpEarned = 25;
    private void addXpEarned(int value)
    { 
        xpEarned = xpEarned + value;
        label1_XpEarnedDisplayed.Text = xpEarned.ToString();
    }

    private void subtractXpEarned(int value)
    {
        xpEarned = xpEarned - value;
        label1_XpEarnedDisplayed.Text = xpEarned.ToString();
    }

    private void checkBox_pg10_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_pg10.Checked == true)
        {
            pictureBox2.Visible = true;
            addXpEarned(25);
        }
        else 
        {
            pictureBox2.Visible = false;
            subtractXpEarned(25);
        }
            
    }

    private void checkBox_pg14_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_pg14.Checked == true)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox6.Visible = true;
            addXpEarned(75);
        }
        else
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
            subtractXpEarned(75);
        }
    }

    private void checkBox_pg19_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_pg19.Checked == true)
        {
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            addXpEarned(50);
        }
        else
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            subtractXpEarned(50);

        }
    }

    private void checkBox_pg22WhatComesNext_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_pg22WhatComesNext.Checked == true)
        {
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            addXpEarned(50);
        }
        else
        {
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            subtractXpEarned(50);
        }
    }

    private void checkBox_pg22TheMakingsOfAProgrammer_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_pg22TheMakingsOfAProgrammer.Checked == true)
        {
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            addXpEarned(50);
        }
        else
        {
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            subtractXpEarned(50);
        }
    }
}
