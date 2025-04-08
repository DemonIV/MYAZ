namespace ValueAndReferenceTypes
{
    public class RefTypes
    {
        public int x { get; set; }
        public int y { get; set; }

        public void Swap(ref int x,ref int y)
        {
            var temp=x;
            x = y;
            y = temp;
        }
        public void CheckOut(out int x)
        {
            x = 100;
            return;
        }
    }
}
