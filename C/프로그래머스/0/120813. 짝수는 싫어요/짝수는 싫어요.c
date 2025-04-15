#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int* solution(int n) {
    if (n < 1 || n > 100) return NULL;  // 조건 검사
    
    int* answer = (int*)malloc(n * sizeof(int));
    int index = 0;
    
    for (int i = 1; i <= n; i += 2) {
        answer[index++] = i;
    }
    
    // 실제 사용 시 배열 크기를 알기 위해 index를 함께 반환해야 함
    return answer;
}