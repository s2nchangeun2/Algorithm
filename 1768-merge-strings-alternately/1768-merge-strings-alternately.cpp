class Solution {
public:
    string mergeAlternately(string word1, string word2) {
        string strResult = "";
        int nIndex = 0;
        while(nIndex < word1.length() || nIndex < word2.length())
        {
            if(nIndex < word1.length())
                strResult += word1[nIndex];
            if (nIndex < word2.length())
                strResult += word2[nIndex];

            nIndex++;
        }
        return strResult;             
    }
};