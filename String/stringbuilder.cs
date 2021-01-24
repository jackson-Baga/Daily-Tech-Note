using System.Text;

namespace String
{
    internal class stringbuilder
    {
        private static void Main(string[] args)
        {
        }
    }

    public class StringBuilderRecord
    {
        //string initialize
        private string s1 = new string(new char[] { 'c', 'h', 'i', 'n', 'a' });

        private string s2 = "abc";

        private StringBuilder sb = new StringBuilder(5);
        //StringBuilder.Append         //将信息追加到当前StringBuilder的结尾。
        //StringBuilder.AppendFormat   //用带格式文本替换字符串中传递的格式说明符。
        //StringBuilder.Insert         //将字符串或对象插入到当前StringBuilder对象的指定索引处。
        //StringBuilder.Remove         //从当前StringBuilder对象中移除指定数量的字符。
        //StringBuilder.Replace        //替换指定索引处的指定字符。
    }
}