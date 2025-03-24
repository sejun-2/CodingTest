using System;

public class Solution {
    public string solution(string my_string) {
        char[] array = my_string.ToCharArray();
        string answer = "";

        for (int i = array.Length - 1; i >= 0; i--) {
            answer += array[i]; 
        }

        return answer;
    }
}