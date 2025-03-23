class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
		String ab = Integer.toString(a) + Integer.toString(b);
        String ba = Integer.toString(b) + Integer.toString(a);
        int ab2 = Integer.parseInt(ab);
        int ba2 = Integer.parseInt(ba);
        
        answer = ab2>=ba2 ? ab2 : ba2;
        
        return answer;
        
               
    }
}