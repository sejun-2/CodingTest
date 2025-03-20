using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int num1 = 0;
        int num2 = 0;
        for(int i=0; i<num_list.Length; i++){
            if(num_list[i]%2 == 0){
                num1+=1;
            }
        }
        for(int j=0; j<num_list.Length; j++){
            if(num_list[j]%2 == 1){
                num2+=1;
            }
        }
        int[] answer = new int[2] {num1, num2};      
        
        return answer;
    }
}