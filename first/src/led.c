#include<avr/io.h>
#include <util/delay.h>

#define led_pin PD4 //digital pin 4

int main(void){
    DDRD |= (1<< led_pin); //set pin as output
    while(1){
        //turn led on
        PORTD |= (1<< led_pin);
        _delay_ms(500);

        PORTD &= ~(1<< led_pin);//turn led off 
        _delay_ms(500);
    }

}