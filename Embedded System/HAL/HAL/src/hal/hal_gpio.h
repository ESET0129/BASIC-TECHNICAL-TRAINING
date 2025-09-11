// // // #include<avr/io.h>
// // // #include <util/delay.h>

// // // #define led_pin PD4 //digital pin 4
// // // #define button_pin PD2//button pin at 2
// // // int main(){
// // //     DDRD |= (1<< PD4); //set pin as output
// // //     //DDRD |= (1 << button);
// // //     DDRD &= ~(1 << PD2);
// // //     PORTD |= (1<< PD2);
// // //     while(1){
// // //         //turn led on
// // //         if(!(PIND & (1 << PD2))){

// // //             PORTD |= (1<< PD4);
// // //             _delay_ms(500);
        
// // //             PORTD &= ~(1<< PD4);
// // //             _delay_ms(500);
// // //         }else {
// // //             PORTD &= ~(1<<);
// // //         }
// // //         _delay_ms(200);
// // //     }
// // // }
    

// // #ifndef HAL_GPIO_H
// // #define HAL_GPIO_H

// // #include <avr/io.h>

// // #define input 0
// // #define output 1

// // void HAL_GPIO_Init(volatile uint8_t *port, uint_8 pin, uint8_t direct );
// // void HAL_GPIO_write(volatile uint8_t *port, uint_8 pin, uint8_t value );
// // void HAL_GPIO_Toggle(volatile uint8_t *port, uint_8 pin);

// // uint8_t HAL_GPIO_Read(volatile uint8_t *port,uint8_t pin);




// // #endif


// #ifndef HAL_GPIO_H
// #define HAL_GPIO_H

// #include <avr/io.h>

// #define INPUT 0
// #define OUTPUT 1

// void HAL_GPIO_Init(volatile uint8_t *port, uint8_t pin, uint8_t direction);
// void HAL_GPIO_Write(volatile uint8_t *port, uint8_t pin, uint8_t value);
// void HAL_GPIO_Toggle(volatile uint8_t *port, uint8_t pin);
// uint8_t HAL_GPIO_Read(volatile uint8_t *port, uint8_t pin);

// #endif


#ifndef HAL_GPIO_H_
#define HAL_GPIO_H_

#include <avr/io.h>
#include <stdint.h>

// Direction defines
#define INPUT 0
#define OUTPUT 1

// Value defines
#define LOW 0
#define HIGH 1

void HAL_GPIO_Init(volatile uint8_t *port, uint8_t pin, uint8_t direction);

void HAL_GPIO_Write(volatile uint8_t *port, uint8_t pin, uint8_t value);

void HAL_GPIO_Toggle(volatile uint8_t *port, uint8_t pin);

uint8_t HAL_GPIO_Read(volatile uint8_t *port, uint8_t pin);

#endif 
