public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if((str1 + str2) != (str2 + str1))
            return "";
                
        int nLen1 = str1.Length;
        int nLen2 = str2.Length;
        
        while(nLen2 != 0)
        {
            int nTemp = nLen2;
            nLen2 = nLen1 % nLen2;
            nLen1 = nTemp;
        }
        
        return str1.Substring(0, nLen1);
    }
}