using ValueAndReferenceTypes;

namespace ValueAndRefrence_Types_Tests
{
    public class ValAndRefTypesTests
    {
        [Fact]
        public void RefTypeTest()
        {
            //arrange
            var p1 = new RefTypes()

            {
                x = 10,
                y = 20,
            };

            var p2 = p1;

            //act
            p1.x = 30;
            //assert
            Assert.Equal(p1.x, p2.x);
        }
        [Fact]
        public void ValTypeTest()
        {
            //arrange
            var p1 = new ValueTypes()

            {
                x = 10,
                y = 20
            };

            var p2 = p1;

            //act
            p1.x = 30;
            //assert
            Assert.NotEqual(p1.x, p2.x);
        }


        [Fact]
        public void RecordTypeTest()
        {
            //arrange
            var p1 = new RecordType();
            p1.x = 3;
            p1.y = 5;
            //act
            var p2 = new RecordType();
            p2.x = 3;
            p2.y = 5;
            //assert
            Assert.Equal(p1, p2);

        }

        [Fact]
        public void SwapByVal()
        {   //arrange
            int a = 23 ,b = 55;
            var valType = new ValueTypes();
            //act
            valType.Swap(a, b);
            //assert
            Assert.Equal(55, b);
            Assert.Equal(23, a);
        }
        [Fact]
        public void SwapByRef()
        {   //arrange
            int a = 23, b = 55;
            var valType = new RefTypes();
            //act
            valType.Swap(ref a, ref b);
            //assert
            Assert.Equal(55, a);
            Assert.Equal(23, b);
        }

        [Fact]

        public void CheckOutKeyword()
        {
            //arrange
            var refType = new RefTypes();
            int b= 50;
            //act
            refType.CheckOut(out b);
            //assert
            Assert.Equal(100, b);
        }
    }

}
