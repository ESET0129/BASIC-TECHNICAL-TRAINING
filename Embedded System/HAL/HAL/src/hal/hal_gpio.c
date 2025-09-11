// // void HAL_GPIO_Init(volatile uint8_t *port, uint_8 pin, uint8_t direct )
// // if(value){
// //     *port |= (1 << pin);
// // }else{
// //     *port &= ~(1 << pin);
// // }

// // void HAL_GPIO_write(volatile uint8_t *port, uint_8 pin, uint8_t value )
// // if(value){
// //     *port |= (1 << pin);
// // }else{
// //     *port &= ~(1 << pin);
// // }

// // void HAL_GPIO_Toggle(volatile uint8_t *port, uint_8 pin){
// //     *port ^= (1<<pin);
// // }

// // uint8_t HAL_GPIO_Read(volatile uint8_t *port,uint8_t pin){
// //     volatile uint8_t *pin_reg=port-2;
// //     return((*pin_reg)&(1<<pin))? 1:0;
// // }

// #include "hal_gpio.h"

// void HAL_GPIO_Init(volatile uint8_t *port, uint8_t pin, uint8_t direction) {
//     volatile uint8_t *ddr = port - 1;
//     if (direction == OUTPUT) {
//         *ddr |= (1 << pin);
//     } else {
//         *ddr &= ~(1 << pin);
//     }
// }

// void HAL_GPIO_Write(volatile uint8_t *port, uint8_t pin, uint8_t value) {
//     if (value) {
//         *port |= (1 << pin);
//     } else {
//         *port &= ~(1 << pin);
//     }
// }

// void HAL_GPIO_Toggle(volatile uint8_t *port, uint8_t pin) {
//     *port ^= (1 << pin);
// }

// uint8_t HAL_GPIO_Read(volatile uint8_t *port, uint8_t pin) {
//     volatile uint8_t *pin_reg = port - 2;
//     return ((*pin_reg) & (1 << pin)) ? 1 : 0;
// }

#include "hal/hal_gpio.h"


void HAL_GPIO_Init(volatile uint8_t *port, uint8_t pin, uint8_t direction) {
    volatile uint8_t *ddr = port - 1;

    if (direction == OUTPUT) {
        *ddr |= (1 << pin);
    } else { 
        *ddr &= ~(1 << pin);
    }
}


void HAL_GPIO_Write(volatile uint8_t *port, uint8_t pin, uint8_t value) {
    if (value) {
       
        *port |= (1 << pin);
    } else {
       
        *port &= ~(1 << pin);
    }
}


void HAL_GPIO_Toggle(volatile uint8_t *port, uint8_t pin) {
    
    *port ^= (1 << pin);
}


uint8_t HAL_GPIO_Read(volatile uint8_t *port, uint8_t pin) {
    volatile uint8_t *pin_reg = port - 2;

   
    return ((*pin_reg) & (1 << pin)) ? 1 : 0;
}