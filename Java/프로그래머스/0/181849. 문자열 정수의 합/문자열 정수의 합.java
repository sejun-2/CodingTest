class Solution {
    public int solution(String num_str) {
        int answer = 0;
        int sum =0;
        for(int i=0; i<num_str.length(); i++){
            char c = num_str.charAt(i);
            sum = c - '0';
            answer += sum;
        };
        
        return answer;
    }
}