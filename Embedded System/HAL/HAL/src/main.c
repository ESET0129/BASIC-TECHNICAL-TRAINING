// #include<avr/io.h>
// #include <util/delay.h>
// #include "hal_gpio.h"
// #include "led_config.h"


// // #define led_pin PD4 //digital pin 4
// // #define button_pin PD2//button pin at 2
// // int main(){
// //     DDRD |= (1<< PD4); //set pin as output
// //     //DDRD |= (1 << button);
// //     DDRD &= ~(1 << PD2);
// //     PORTD |= (1<< PD2);
// //     while(1){
// //         //turn led on
// //         if(!(PIND & (1 << PD2))){

// //             PORTD |= (1<< PD4);
// //             _delay_ms(500);
        
// //             PORTD &= ~(1<< PD4);
// //             _delay_ms(500);
// //         }else {
// //             PORTD &= ~(1<<);
// //         }
// //         _delay_ms(200);
// //     }
// // }
    

// int main(void){
//     HAL_GPIO_Init(LED_PORT,LED_PIN,output);
//     HAL_GPIO_Init(BUTTON_PORT, BUTTON_PIN, input);
//     *(BUTTON_PORT) |= (1<<BUTTON_PIN);


// }

// #include "hal/hal_gpio.h"
// #include "../config/led_config.h"
// #include <util/delay.h>

// int main(void) {
//     HAL_GPIO_Init(LED_PORT, LED_PIN, OUTPUT);
//     HAL_GPIO_Init(BUTTON_PORT, BUTTON_PIN, INPUT);

//     *(BUTTON_PORT) |= (1 << BUTTON_PIN);

//     uint8_t led_state = 0;
//     uint8_t last_button_state = 1;  // pull-up means idle state is HIGH

//     while (1) {
//         uint8_t button_state = HAL_GPIO_Read(BUTTON_PORT, BUTTON_PIN);

//         // Simple debounce and edge detection
//         if (button_state && !last_button_state) {
//             led_state = !led_state;
//             HAL_GPIO_Write(LED_PORT, LED_PIN, led_state);
//             _delay_ms(50);  // debounce delay
//         }

//         last_button_state = button_state;
//         _delay_ms(10);  // polling delay
//     }
// }    


#include "hal/hal_gpio.h"
//#include "hal/hal_gpio.c"
#include "../config/led_config.h"
#include <util/delay.h>

// Define modes for the LED
#define MODE_1_ON 1
#define MODE_2_SLOW_BLINK 2
#define MODE_3_FAST_BLINK 3

int main(void) {
    HAL_GPIO_Init(LED_PORT, LED_PIN, OUTPUT);
    HAL_GPIO_Init(BUTTON_PORT, BUTTON_PIN, INPUT);

    
    *(BUTTON_PORT) |= (1 << BUTTON_PIN);

    // Initial state variables
    uint8_t current_mode = MODE_1_ON;
    uint8_t last_button_state = 1; 
    while (1) {
        uint8_t button_state = HAL_GPIO_Read(BUTTON_PORT, BUTTON_PIN);

      
        if (!button_state && last_button_state) {
            // Button pressed
            current_mode++;
            if (current_mode > MODE_3_FAST_BLINK) {
                current_mode = MODE_1_ON; // back to the first mode
            }
            _delay_ms(100); 
        }

        last_button_state = button_state;

        // Control LED based on the current mode
        switch (current_mode) {
            case MODE_1_ON:
                HAL_GPIO_Write(LED_PORT, LED_PIN, 1);
                break;
            case MODE_2_SLOW_BLINK:
                HAL_GPIO_Toggle(LED_PORT, LED_PIN);
                _delay_ms(800); // Slow blink delay
                break;
            case MODE_3_FAST_BLINK:
                HAL_GPIO_Toggle(LED_PORT, LED_PIN);
                _delay_ms(200); // Fast blink delay
                break;
        }

        _delay_ms(20);
    }
}