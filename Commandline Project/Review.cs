using System;
using System.Collections.Generic;
using System.Text;


namespace Commandline_Project
{
    public class Review
    {
        public int Stars;
        public string Message;
        public Review(int Stars, string Message)
        {
            this.Stars = Stars;
            this.Message = Message;
        }
    }
}
