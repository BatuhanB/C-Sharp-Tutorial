using System.Linq;
using System.Text;

namespace Algorithms
{
    public class LongestCommonPrefix
    {
        public string FindLongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";
        var shortest = strs.OrderBy(x=>x.Length).First();
        StringBuilder sb = new();
        int i = 0;
        for(;i<=shortest.Length;i++){
            if(strs.Any(s=>s[i] != shortest[i])) break;
            sb.Append(shortest[i]);
        }
        return sb.ToString();
    }
    }
}
