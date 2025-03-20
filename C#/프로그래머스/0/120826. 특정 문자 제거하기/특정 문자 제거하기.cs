using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        
        char[] myArray = my_string.ToCharArray();
        char[] LetArray = letter.ToCharArray();
        
        for(int i=0; i<myArray.Length; i++){
            for(int j=0; j<LetArray.Length; j++){
                if(myArray[i] != LetArray[j]){
                answer += myArray[i];
                }
            }
            
        }
        
        return answer;
    }
}