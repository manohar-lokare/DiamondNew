using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DiamondKataNew;

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
            Assert.NotEqual("A", Diamond.Create('B'));
        }

        [Fact]
        public void Check_If_Input_Character_Is_Not_In_Range()
        {
            Assert.Throws<ArgumentException>(() => Diamond.Create('1'));
        }
        [Fact]
        public void B_should_give_character_sequence()
        {
            Assert.Equal(" A \nB B\n A ", Diamond.Create('B'));
        }

        [Fact]
        public void C_should_not_give_character_sequence()
        {
            Assert.NotEqual(" A \nB B\n A ", Diamond.Create('C'));
        }

        [Fact]
        public void Space_Should_Be_Present_In_Between_C()
        {
            var str = " A  \n B B \nC   C\n B B \n  A ";
            var spaceStr = str.Substring(str.IndexOf('C') -1, str.LastIndexOf('C') - 1);
            Assert.Equal(spaceStr, Diamond.Create('C').Substring(str.IndexOf('C'), str.IndexOf('C') + 3));
        }

        [Fact]
        public void First_Character_Should_Be_Blank_For_Character_Sequence()
        {
            var str = " A  \n B B \nC   C\n B B \n  A  ";            
            var spaceStr = str.Substring(str.IndexOf('A') -1); //expected string is "C   C\n B B \n  A  "
            var retStr = Diamond.Create('C');
            Assert.True(retStr.Substring(retStr.IndexOf('A') -1) == spaceStr);
        }
    }
 }