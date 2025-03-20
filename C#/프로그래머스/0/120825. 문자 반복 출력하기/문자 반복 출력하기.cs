using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        
        char[] array = my_string.ToCharArray();
    
        for(int i=0; i<array.Length; i++){
            for(int j=0; j<n; j++){
                answer += array[i];
            }

        }
        return answer;
    }
}