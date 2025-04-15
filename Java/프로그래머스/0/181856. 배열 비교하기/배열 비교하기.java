class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0; 
        int num1 = 0;
        int num2 = 0;
        int a1 = arr1.length;
        int a2 = arr2.length;
        
        if(a2 > a1){
            answer = -1;
        } else if (a1 > a2){
            answer = 1;
        } else if (a1 == a2){
            for(int i =0; i <arr1.length; i++){
                num1 += arr1[i];
            }
            for(int i =0; i <arr2.length; i++){
                num2 += arr2[i];
            }
            if(num1 > num2){
                answer = 1;
            } else if(num1 < num2){
                answer = -1;
            } else if(num1 == num2)
                answer = 0;
        }         
        return answer;
    }
}
