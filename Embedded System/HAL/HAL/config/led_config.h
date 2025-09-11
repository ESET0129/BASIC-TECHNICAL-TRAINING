// #define LED_PORT & PORTB
// #define LED_PIN4

// #define BUTTON_PORT & PORTD
// #define BUTTON_PIN2

// // #define BUTTON_PIN PD2
// // #define LED_PIN PD5



#ifndef LED_CONFIG_H
#define LED_CONFIG_H

#include <avr/io.h>

// Define the port and pin for the LED
#define LED_PORT    &PORTB
#define LED_PIN     4

// Define the port and pin for the button
#define BUTTON_PORT &PORTC
#define BUTTON_PIN  2

#endif // 