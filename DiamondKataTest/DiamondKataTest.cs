using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DiamondKataNew;
using Xunit.Sdk;

namespace DiamondKataTest
{
    public class DiamondKataTest
    {
        [Fact]
        public void Check_If_Input_Character_Are_Equal()
        {
            Assert.Equal("A", Diamond.Create('A'));
        }

        [Fact]
        public void Check_If_Input_Character_Is_Not_Equal()
        {
            var exception = Record.Exception(() => Diamond.Create('B'));
            if (exception != null)
                Assert.Throws<OverflowException>(() => Diamond.Create('B'));
            else
                Assert.NotEqual("A", Diamond.Create('B'));
        }

        [Fact]
        public void Check_If_Input_Character_Is_Not_In_Range()
        {
            Assert.Throws<ArgumentException>(() => Diamond.Create('1'));
        }

        [Fact]
        public void C_should_not_give_character_sequence()
        {
            Assert.NotEqual(" A \nB B\n A ", Diamond.Create('C'));
        }

        [Fact]
        public void Space_Should_Be_Present_In_Between_C()
        {
            var exception = Record.Exception(() => Diamond.Create('C'));
            if (exception != null)
                Assert.Throws<OverflowException>(() => Diamond.Create('C'));
            else
            {
                var str = " A  \n B B \nC   C\n B B \n  A  ";
                var spaceStr = str.Substring(str.IndexOf('C') - 1, str.LastIndexOf('C') - 1);
                var retStr = Diamond.Create('C');
                Assert.Equal(spaceStr, retStr.Substring(retStr.IndexOf('C') -1, retStr.IndexOf('C') + 2));
                
            }
        }

        [Fact]
        public void B_Is_Missing_From_Character_Sequence()
        {
            var exception = Record.Exception(() => Diamond.Create('C'));
            if (exception != null)
                Assert.Throws<OverflowException>(() => Diamond.Create('C'));
            else
            {
                var str = " A  \n B B \nC   C\n B B \n  A  ";
                var spaceStr = str.Substring(str.IndexOf('A') - 1);
                var retStr = Diamond.Create('C');
                Assert.True(retStr.Substring(retStr.IndexOf('A') - 1) == spaceStr);
                
                //if(retStr.Contains('B'))
                //    Assert.True(retStr.Substring(retStr.IndexOf('A') - 1) == spaceStr);
                //else
                //    Assert.True(retStr.Substring(retStr.IndexOf('A') - 1) != spaceStr);
            }
        }

        [Fact]
        public void b_should_not_give_character_sequence()
        {
            Assert.Throws<ArgumentException>(() => Diamond.Create('b'));
        }
        [Fact]
        public void First_Character_Should_Not_Be_Blank_For_Character_Sequence()
        {
            var str = " A  \n B B \nC   C\n B B \n  A  ";
            var spaceStr = str.Substring(str.IndexOf('A'));
            var retStr = Diamond.Create('C');
            Assert.False(retStr.Substring(retStr.IndexOf('A') - 1) == spaceStr);
        }

        [Fact]
        public void Check_For_Execption_When_Character_Array_Has_B_Missing()
        { 
            var exception = Record.Exception(() => Diamond.Create('B'));
            if(exception != null)
                Assert.Throws<OverflowException>(() => Diamond.Create('B'));
            else
                Assert.Equal(" A \nB B\n A ", Diamond.Create('B'));

        }
    }
 }