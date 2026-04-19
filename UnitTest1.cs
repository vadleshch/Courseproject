using Courseproject;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ulong[] KeyStreams = {
                0xF871EBEF945B7272,
                0xE40C04941DFF0537,
                0x0B981A59FBC8AC57,
                0x566D3B02C179DBB4,
                0x3B46F1F033554C72,
                0x5DE68BCC9872858F,
                0x575496024062F0E9,
                0xF932C998226DB6BA};
            State S = KCipher2.InitChiper(new uint[] { 0x00000000, 0x00000000, 0x00000000, 0x00000000 }, new uint[] { 0x00000000, 0x00000000, 0x00000000, 0x00000000 });
            for (int i = 0; i < KeyStreams.Length; i++)
            {
                Assert.Equal(KeyStreams[i], KCipher2.Stream(S));
                S = KCipher2.Next(S);
            }
        }
        [Fact]
        public void Test2()
        {
            ulong[] KeyStreams = {
                0x9FB6B580A6A5E7AFUL,
                0xD1989DC6A77D5E28UL,
                0x4EFCC8CB7BCFB32BUL,
                0xF69297F5DD974CE8UL,
                0xFBD9139C7A71F41AUL,
                0x61382C76D3D2F6CAUL,
                0xD5265037659CF838UL,
                0x774121C26F6474F3UL};
            State S = KCipher2.InitChiper( new uint[] { 0x0F1E2D3C, 0x4B5A6978, 0x8796A5B4, 0xC3D2E1F0 }, new uint[] { 0xF0E0D0C0, 0xB0A09080, 0x70605040, 0x30201000 });
            for (int i = 0; i < KeyStreams.Length; i++)
            {
                Assert.Equal(KeyStreams[i], KCipher2.Stream(S));
                S = KCipher2.Next(S);
            }
        }

        [Fact]
        public void Test3()
        {
            ulong[] KeyStreams = {
            0xDA38138B32864E05UL,
            0x24B8B90944E5117AUL,
            0xC3E883DCFA22C458UL,
            0x1F2C9DDFE98DC5DEUL,
            0x33B2FC05064C6FEFUL,
            0xA9A3D3ED31660DFFUL,
            0xF7DE1857E224E70FUL,
            0x4EFE5C36CEB974ACUL};
            State S = KCipher2.InitChiper(new uint[] { 0xAC2F75C0, 0x43FBC367, 0x09D315F2, 0x245746D8 }, new uint[] { 0xF6B29A58, 0x45CCCD8C, 0x6229393A, 0x7A4842C1 });
            for (int i = 0; i < KeyStreams.Length; i++)
            {
                Assert.Equal(KeyStreams[i], KCipher2.Stream(S));
                S = KCipher2.Next(S);
            }
        }
    }
}
