using System.IO;
namespace XP_Tracker;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        checkBox_pg10.Checked = Properties.Settings.Default.checkboxPg10;
        checkBox_pg14.Checked = Properties.Settings.Default.checkboxPg14;
        checkBox_pg19.Checked = Properties.Settings.Default.checkboxPg19;
        checkBox_pg22WhatComesNext.Checked = Properties.Settings.Default.checkboxPg22;
        checkBox_pg22TheMakingsOfAProgrammer.Checked = Properties.Settings.Default.checkboxPg22_2;
        checkBox_pg24.Checked = Properties.Settings.Default.checkbox_Pg24;
        checkBox_pg28.Checked = Properties.Settings.Default.checkbox_Pg28;
        checkBox_pg34.Checked = Properties.Settings.Default.checkbox_Pg34;
        checkBox_pg42.Checked = Properties.Settings.Default.checkbox_Pg42;
        checkBoxPg43.Checked = Properties.Settings.Default.checkbox_Pg43;
    }

    int xpEarned = 25;

    private void addXpEarned(int value)
    { 
        xpEarned = xpEarned + value;
        label1_XpEarnedDisplayed.Text = xpEarned.ToString();

     /* TODO
     [x] Check to see if value equals 600
     [] Get the image for a filled in dot
     [] If value equals 600 fill in the level 2 dot
     [] Else leave the level 2 dot empty
     [] Think about using a switch here instead of a lot of "If" statements
    */
        if (xpEarned == 600) MessageBox.Show("You have reached Level 2!"); //Using a messagebox as a test. 

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

    private void checkBox_pg24_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_pg24.Checked == true)
        {
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            addXpEarned(50);
        }
        else
        {
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            subtractXpEarned(50);
        }
    }

    private void checkBox_pg28_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_pg28.Checked == true)
        {
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBox_pg34_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_pg34.Checked == true)
        {
            pictureBox20.Visible = true;
            addXpEarned(25);
        }
        else
        {
            pictureBox20.Visible = false;
            subtractXpEarned(25);
        }
    }

    private void checkBox_pg42_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_pg42.Checked == true)
        {
            pictureBox22.Visible = true;
            pictureBox21.Visible = true;
            pictureBox23.Visible = true;
            pictureBox24.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox22.Visible = false;
            pictureBox21.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Properties.Settings.Default.checkboxPg10 = checkBox_pg10.Checked;
        Properties.Settings.Default.checkboxPg14 = checkBox_pg14.Checked;
        Properties.Settings.Default.checkboxPg19 = checkBox_pg19.Checked;
        Properties.Settings.Default.checkboxPg22 = checkBox_pg22WhatComesNext.Checked;
        Properties.Settings.Default.checkboxPg22_2 = checkBox_pg22TheMakingsOfAProgrammer.Checked;
        Properties.Settings.Default.checkbox_Pg24 = checkBox_pg24.Checked;
        Properties.Settings.Default.checkbox_Pg28 = checkBox_pg28.Checked;
        Properties.Settings.Default.checkbox_Pg34 = checkBox_pg34.Checked;
        Properties.Settings.Default.checkbox_Pg42 = checkBox_pg42.Checked;
        Properties.Settings.Default.checkbox_Pg43 = checkBoxPg43.Checked;

        Properties.Settings.Default.Save();
    }

    private void checkBoxPg43_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg43.Checked == true)
        {
            pictureBox25.Visible = true;
            pictureBox26.Visible = true;
            addXpEarned(50);
        }
        else
        {
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            subtractXpEarned(50);
        }
    }
}
