namespace ValueAndReferenceTypes
{
    public struct ValueTypes
    {
        public int x { get; set; }
        public int y { get; set; }

        public void Swap(int x, int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

    }
}
