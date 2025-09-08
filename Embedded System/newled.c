#include<avr/io.h>
#include <util/delay.h>

#define led_pin PD4 //digital pin 4
#define button_pin PD2//button pin at 2
int main(){
    DDRD |= (1<< PD4); //set pin as output
    //DDRD |= (1 << button);
    DDRD &= ~(1 << PD2);
    PORTD |= (1<< PD2);
    while(1){
        //turn led on
        if(!(PIND & (1 << PD2))){

            PORTD |= (1<< PD4);
            _delay_ms(500);
        
            PORTD &= ~(1<< PD4);
            _delay_ms(500);
        }else {
            PORTD &= ~(1<<);
        }
        _delay_ms(200);
    }
}
    



