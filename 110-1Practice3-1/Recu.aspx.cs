using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice3_1
{
    public partial class Recu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int total;
            int z = 4;
            if (z % 2 != 0)
            {
                total = Odd(z);
                Response.Write(total);
            }
            else
            {
                total = Even(z);
                Response.Write(total);
            }
        }

        int Odd(int n)
        {
            if (n == 1)
                return 11;
            else if (n == 2)
                return 11 + 4;
            else
                return Odd(n - 2) + Odd(n - 1);
        }
        int Even(int e)
        {
            if (e == 1)
                return 11;
            else if (e == 2)
                return 18;
            else
                return Even(e - 2) + Even(e - 1);

        }
    }
}