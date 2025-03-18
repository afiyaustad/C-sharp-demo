using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExceptionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { /*
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();

            }
            catch (DivideByZeroException ex)
            {

                MessageBox.Show("please dont enter zero as denimonator: " + ex.Message);
            }

            catch (FormatException ex)
            {

                MessageBox.Show("please dont enter characters or special symbols: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("some genral error " + ex.Message);
            } */

//class exceptions are there u dont keept it on top delete sub class it is okay otherwise keep it down only and also u can see
//in between try and catch nothing should be writien only comments u can write bcause i have to catch the error
//Now whether the exception comes or dont come i want my code to be executed then i will use finally block 
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();

            }
            // dont write any thing here 
            // only comments 
            catch (DivideByZeroException ex)
            {

                MessageBox.Show("please dont enter zero as denimonator: " + ex.Message);
            }

            catch (FormatException ex)
            {

                MessageBox.Show("please dont enter characters or special symbols: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("some genral error " + ex.Message);
            }
            finally
            {
                MessageBox.Show(" I am still alive ");
            }


//try --->catch--> finally is okay
//try -->catch is okay   for this comment finally block no error
//try -->finally is also okay for this comment call catch balcks no errro
//comments as per the statemnts and see is it possible or not
        }
        //User Define Exception

        public class AxisBankException : ApplicationException
        {
            public AxisBankException(string message) : base(message)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(textBox4.Text);
                if (age < 18)
                {
                    AxisBankException obj = new AxisBankException("AxisBankException:Age should be above 18 to open an account");
                    throw obj;
                }
                else
                {

                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://www.axisbank.com/",
                        UseShellExecute = true
                    });

                }
            }
            catch (AxisBankException axisobj)
            {

                MessageBox.Show(axisobj.Message);
            }
        }
    }
}
