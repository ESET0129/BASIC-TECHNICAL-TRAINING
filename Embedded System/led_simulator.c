#include <stdio.h>
#define led_pin 1
void delay_ms(int ms){
    volatile long i,j;
    

}
int main(){
    int counter=0;
    int max_blink=20;
    int thresold =10;

    for(int i=0;i<=max_blink;i++){
        if(counter<=thresold){
            printf("LED on(counter:%d)\n",counter);
            delay_ms(200);

    
            printf("LED OFF(counter: %d)\n",counter);
            delay_ms(200);
        }
    
        else{
        printf("counter reached thresold  or above: %d\n",counter);
        delay_ms(500);
        }
        counter++;
}
printf("blinking sequence completed\n");

 // Example of a while loop
    int countdown = 3;
    //while loop for countdown
    while(countdown>0){
        printf("Countdown: %d\n", countdown);
         		// Decrement operator (--)
         //delay timer
         countdown--;
         delay_ms(200);
}
    
    printf("Liftoff!\n");

    return 0; 	// Indicate successful execution
} 
