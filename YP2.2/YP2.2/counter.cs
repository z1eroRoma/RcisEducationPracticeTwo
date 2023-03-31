namespace ConsoleApp3
{
    using System;  

    class counter
    {
        private int shetchick;
        public counter()
        {
            this.shetchick = 0;
        }
        public counter(int n)
        {
            this.shetchick = n;
        }
        public void shetchickOfLow()
        {
            this.shetchick--;
        }
        public void shetchickOfSum()
        {
            this.shetchick++;
        }
        public int Output
        {
            get { return shetchick; }
        }
    }
}