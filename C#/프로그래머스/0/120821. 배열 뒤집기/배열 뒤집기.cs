using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length];
        
        int index = 0;
        
        for(int i = num_list.Length - 1; i >= 0; i--) {
            answer[index] = num_list[i];
            index++;
        }  
        
        return answer;
    }
}