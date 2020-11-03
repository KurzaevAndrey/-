using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPract9
{
  public partial class Form1 : Form
  {
    Random _rnd = new Random();
    Point _tmp_location;
    int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
    int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
    

    public Form1()
    {
      InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      textBox1.Text = e.X.ToString();
      textBox2.Text = e.Y.ToString();
      int wButton = button1.Size.Width;
      int hButton = button1.Size.Height;
      
      int tempH = button1.Location.Y + hButton + 10;
      int tempW = button1.Location.X + wButton + 10;
      
      if (e.X > button1.Location.X - 10)
      {
        if (e.X < tempW)
        {
          if (e.Y > button1.Location.Y - 10)
          {
            if (e.Y < tempH)
         
            {
              _tmp_location = this.Location;
              _tmp_location.X += _rnd.Next(-100, 100);
              _tmp_location.Y += _rnd.Next(-100, 100);
              if (_tmp_location.X < 0 || _tmp_location.X > (_w - this.Width / 2) ||
                _tmp_location.Y < 0 || _tmp_location.Y > (_h - this.Height / 2))
              { // новыми координатами станет центр окна
                _tmp_location.X = _w / 2;
                _tmp_location.Y = _h / 2;
              }
              this.Location = _tmp_location;
            }
          }
          
        }
        
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      MessageBox.Show("OK");
      Application.Exit();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Come back when you will come more richer", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
