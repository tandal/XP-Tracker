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
        checkBoxPg45.Checked = Properties.Settings.Default.checkbox_Pg45;
        checkBoxPg50.Checked = Properties.Settings.Default.checkbox_Pg50;
        checkBoxPg53.Checked = Properties.Settings.Default.checkbox_Pg53;
        checkBoxPg54.Checked = Properties.Settings.Default.checkbox_Pg54;
        checkBoxPg65.Checked = Properties.Settings.Default.checkbox_Pg65;
        checkBoxPg72.Checked = Properties.Settings.Default.checkbox_Pg72;
        checkBoxPg74.Checked = Properties.Settings.Default.checkbox_Pg74;
        checkBoxPg78.Checked = Properties.Settings.Default.checkbox_Pg78;
        checkBoxPg79.Checked = Properties.Settings.Default.checkbox_Pg79;
        checkBoxPg84.Checked = Properties.Settings.Default.checkbox_Pg84;
        checkBoxPg85.Checked = Properties.Settings.Default.checkbox_Pg85;
        checkBoxPg90.Checked = Properties.Settings.Default.checkbox_Pg90;
        checkBoxPg91.Checked = Properties.Settings.Default.checkbox_Pg91;
        checkBoxPg101.Checked = Properties.Settings.Default.checkbox_Pg101;
        checkBoxPg102.Checked = Properties.Settings.Default.checkbox_Pg102;
        checkBoxPg117.Checked = Properties.Settings.Default.checkbox_Pg117;
        checkBoxPg118.Checked = Properties.Settings.Default.checkbox_Pg118;
    }


    int xpEarned = 25;

    private void addXpEarned(int value)
    { 
        xpEarned = xpEarned + value;
        label1_XpEarnedDisplayed.Text = xpEarned.ToString();

        /* TODO
        [x] Check to see if value equals 600
        [x] Get the image for a filled in dot
        [x] If value equals 600 fill in the level 2 dot
        [x] Else leave the level 2 dot empty
        [] Think about other code alternatives when checking the level progress
       */
        if (xpEarned >= 600) pictureBoxLevel2Complete.Show();
        if (xpEarned >= 1200) pictureBoxLevel3Complete.Show();
        if (xpEarned >= 2000) pictureBoxLevel4Complete.Show();
    }

    private void subtractXpEarned(int value)
    {
        xpEarned = xpEarned - value;
        label1_XpEarnedDisplayed.Text = xpEarned.ToString();
        if (xpEarned < 600) pictureBoxLevel2Complete.Hide();
        if (xpEarned < 1200) pictureBoxLevel3Complete.Hide();
        if (xpEarned < 2000) pictureBoxLevel4Complete.Hide();
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
        Properties.Settings.Default.checkbox_Pg45 = checkBoxPg45.Checked;
        Properties.Settings.Default.checkbox_Pg50 = checkBoxPg50.Checked;
        Properties.Settings.Default.checkbox_Pg53 = checkBoxPg53.Checked;
        Properties.Settings.Default.checkbox_Pg54 = checkBoxPg54.Checked;
        Properties.Settings.Default.checkbox_Pg65 = checkBoxPg65.Checked;
        Properties.Settings.Default.checkbox_Pg72 = checkBoxPg72.Checked;
        Properties.Settings.Default.checkbox_Pg74 = checkBoxPg74.Checked;
        Properties.Settings.Default.checkbox_Pg78 = checkBoxPg78.Checked;
        Properties.Settings.Default.checkbox_Pg79 = checkBoxPg79.Checked;
        Properties.Settings.Default.checkbox_Pg84 = checkBoxPg84.Checked;
        Properties.Settings.Default.checkbox_Pg85 = checkBoxPg85.Checked;
        Properties.Settings.Default.checkbox_Pg90 = checkBoxPg90.Checked;
        Properties.Settings.Default.checkbox_Pg91 = checkBoxPg91.Checked;
        Properties.Settings.Default.checkbox_Pg101 = checkBoxPg101.Checked;
        Properties.Settings.Default.checkbox_Pg102 = checkBoxPg102.Checked;
        Properties.Settings.Default.checkbox_Pg117 = checkBoxPg117.Checked;
        Properties.Settings.Default.checkbox_Pg118 = checkBoxPg118.Checked;

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

    private void checkBoxPg45_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg45.Checked == true)
        {
            pictureBox27.Visible = true;
            addXpEarned(25);
        }
        else
        {
            pictureBox27.Visible = false;
            subtractXpEarned(25);
        }
    }

    private void checkBoxPg50_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg50.Checked == true)
        {
            pictureBox28.Visible = true;
            pictureBox29.Visible = true;
            pictureBox30.Visible = true;
            pictureBox31.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg53_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg53.Checked == true)
        {
            pictureBox32.Visible = true;
            pictureBox33.Visible = true;
            pictureBox34.Visible = true;
            pictureBox35.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg54_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg54.Checked == true)
        {
            pictureBox36.Visible = true;
            pictureBox37.Visible = true;
            pictureBox38.Visible = true;
            pictureBox39.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg65_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg65.Checked == true)
        {
            pictureBox40.Visible = true;
            pictureBox41.Visible = true;
            pictureBox42.Visible = true;
            pictureBox43.Visible = true;
            pictureBox44.Visible = true;
            pictureBox45.Visible = true;
            pictureBox46.Visible = true;
            pictureBox47.Visible = true;
            addXpEarned(200);
        }
        else
        {
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            subtractXpEarned(200);
        }
    }

    private void checkBoxPg72_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg72.Checked == true)
        {
            pictureBox48.Visible = true;
            pictureBox49.Visible = true;
            pictureBox50.Visible = true;
            pictureBox51.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox51.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg74_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg74.Checked == true)
        {
            pictureBox52.Visible = true;
            pictureBox53.Visible = true;
            pictureBox54.Visible = true;
            pictureBox55.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox52.Visible = false;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox55.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg78_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg78.Checked == true)
        {
            pictureBox56.Visible = true;
            pictureBox57.Visible = true;
            pictureBox58.Visible = true;
            pictureBox59.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox56.Visible = false;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            pictureBox59.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg79_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg79.Checked == true)
        {
            pictureBox60.Visible = true;
            pictureBox61.Visible = true;
            addXpEarned(50);
        }
        else
        {
            pictureBox60.Visible = false;
            pictureBox61.Visible = false;
            subtractXpEarned(50);
        }
    }

    private void checkBoxPg84_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg84.Checked == true)
        {
            pictureBox62.Visible = true;
            pictureBox63.Visible = true;
            pictureBox64.Visible = true;
            pictureBox65.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox62.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox65.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg85_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg85.Checked == true)
        {
            pictureBox66.Visible = true;
            pictureBox67.Visible = true;
            pictureBox68.Visible = true;
            pictureBox69.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox66.Visible = false;
            pictureBox67.Visible = false;
            pictureBox68.Visible = false;
            pictureBox69.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg90_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg90.Checked == true)
        {
            pictureBox70.Visible = true;
            pictureBox71.Visible = true;
            pictureBox72.Visible = true;
            pictureBox73.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox72.Visible = false;
            pictureBox73.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg91_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg91.Checked == true)
        {
            pictureBox74.Visible = true;
            pictureBox75.Visible = true;
            addXpEarned(50);
        }
        else
        {
            pictureBox74.Visible = false;
            pictureBox75.Visible = false;
            subtractXpEarned(50);
        }
    }

    private void checkBoxPg101_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg101.Checked == true)
        {
            pictureBox76.Visible = true;
            pictureBox77.Visible = true;
            pictureBox78.Visible = true;
            pictureBox79.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox76.Visible = false;
            pictureBox77.Visible = false;
            pictureBox78.Visible = false;
            pictureBox79.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg102_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg102.Checked == true)
        {
            pictureBox80.Visible = true;
            pictureBox81.Visible = true;
            pictureBox82.Visible = true;
            pictureBox83.Visible = true;
            addXpEarned(100);
        }
        else
        {
            pictureBox80.Visible = false;
            pictureBox81.Visible = false;
            pictureBox82.Visible = false;
            pictureBox83.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg117_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg117.Checked == true)
        {
            pictureBox84.Visible = true;
            addXpEarned(25);
        }
        else
        {
            pictureBox84.Visible = false;
            subtractXpEarned(100);
        }
    }

    private void checkBoxPg118_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxPg118.Checked == true)
        {
            pictureBox85.Visible = true;
            pictureBox86.Visible = true;
            pictureBox87.Visible = true;
            pictureBox88.Visible = true;
            pictureBox89.Visible = true;
            pictureBox90.Visible = true;
            pictureBox91.Visible = true;
            pictureBox92.Visible = true;
            pictureBox93.Visible = true;
            pictureBox94.Visible = true;
            addXpEarned(250);
        }
        else
        {
            pictureBox85.Visible = false;
            pictureBox86.Visible = false;
            pictureBox87.Visible = false;
            pictureBox88.Visible = false;
            pictureBox89.Visible = false;
            pictureBox90.Visible = false;
            pictureBox91.Visible = false;
            pictureBox92.Visible = false;
            pictureBox93.Visible = false;
            pictureBox94.Visible = false;
            subtractXpEarned(250);
        }
    }
}
