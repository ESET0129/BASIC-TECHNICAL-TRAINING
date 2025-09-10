// #include <Arduino.h>
// #include <avr/io.h>
// #include <util/delay.h>

// #define DATA_PIND4 PB2
// #define DATA_PIND7 PD7
// #define DATA_PIND5 PB1
// #define DATA_PIND6 PB0
// #define EN PB3 
// #define DATA_RS PB4

// void lcd_pulse()
// {
//     PORTB |= (1<<EN);
//     _delay_ms(100);
//     PORTB &= ~(1<<EN);
//     _delay_ms(200);
// }

// void lcd_command(unsigned char cmd)
// {
//     PORTB &= ~(1<<DATA_RS);
//     // Displaying Text - HighNibble
//     PORTB &= ~(1<<DATA_RS);
//     if(cmd & 0x10){PORTB |= (1<<DATA_PIND4);}else{PORTB &= ~(1<<DATA_PIND4);}
//     if(cmd & 0x20){PORTB |= (1<<DATA_PIND5);}else{PORTB &= ~(1<<DATA_PIND5);}
//     if(cmd & 0x40){PORTB |= (1<<DATA_PIND6);}else{PORTB &= ~(1<<DATA_PIND6);}
//     if(cmd & 0x80){PORTB |= (1<<DATA_PIND7);}else{PORTB &= ~(1<<DATA_PIND7);}
//     lcd_pulse();

//     // Accepting commands = LowNibble
//     if(cmd & 0x01){PORTB |= (1<<DATA_PIND4);}else{PORTB &= ~(1<<DATA_PIND4);}
//     if(cmd & 0x02){PORTB |= (1<<DATA_PIND5);}else{PORTB &= ~(1<<DATA_PIND5);}
//     if(cmd & 0x04){PORTB |= (1<<DATA_PIND6);}else{PORTB &= ~(1<<DATA_PIND6);}
//     if(cmd & 0x08){PORTB |= (1<<DATA_PIND7);}else{PORTB &= ~(1<<DATA_PIND7);}
//     lcd_pulse();
// }

// void lcd_init()
// {
//     _delay_ms(200);
//     lcd_command(0x02);
//     lcd_command(0x28);
//     lcd_command(0x0C);
//     lcd_command(0x06);
//     lcd_command(0x01);
//     _delay_ms(200);
// }

// void lcd_data(unsigned char data){
//     PORTB |=(1<<DATA_RS);
//     // Displaying Text - HighNibble
//     PORTB &= ~(1<<DATA_RS);
//     if(data & 0x10){PORTB |= (1<<DATA_PIND4);}else{PORTB &= ~(1<<DATA_PIND4);}
//     if(data & 0x20){PORTB |= (1<<DATA_PIND5);}else{PORTB &= ~(1<<DATA_PIND5);}
//     if(data & 0x40){PORTB |= (1<<DATA_PIND6);}else{PORTB &= ~(1<<DATA_PIND6);}
//     if(data & 0x80){PORTB |= (1<<DATA_PIND7);}else{PORTB &= ~(1<<DATA_PIND7);}
//     lcd_pulse();

//     // Accepting commands = LowNibble
//     if(data & 0x01){PORTB |= (1<<DATA_PIND4);}else{PORTB &= ~(1<<DATA_PIND4);}
//     if(data & 0x02){PORTB |= (1<<DATA_PIND5);}else{PORTB &= ~(1<<DATA_PIND5);}
//     if(data & 0x04){PORTB |= (1<<DATA_PIND6);}else{PORTB &= ~(1<<DATA_PIND6);}
//     if(data & 0x08){PORTB |= (1<<DATA_PIND7);}else{PORTB &= ~(1<<DATA_PIND7);}
//     lcd_pulse();
// }
// void lcd_print(char *str){
//     while(*str){
//         lcd_data(*str++);
//     }
// }



// int main()
// {
//     DDRB = 0XFF;
//     DDRD |= (1 << DATA_PIND7);
//     lcd_init();

//     lcd_command(0x80);
//     lcd_print("NEPAL NEPAL");

//     lcd_command(0xC0);
//     lcd_print("LCD Dead!");

//     while(1){

//     }
// }

// #include <Arduino.h>
// #include <avr/io.h>
// #include <util/delay.h>

// // Pin definitions
// #define DATA_PIN07 PD7     // D7 -> PORTD7
// #define DATA_PIN06 PB0     // D6 -> PORTB0
// #define DATA_PIN05 PB1     // D5 -> PORTB1
// #define DATA_PIN04 PB2     // D4 -> PORTB2
// #define ENABLE     PB3     // EN -> PORTB3
// #define RS         PB4     // RS -> PORTB4

// // Pulse the Enable pin to latch data into the LCD
// void lcd_pulse() {
//     PORTB |= (1 << ENABLE);
//     _delay_us(1);
//     PORTB &= ~(1 << ENABLE);
//     _delay_ms(2);  // Delay for command to be processed
// }

// // Send a 4-bit nibble to the LCD
// void lcd_send_nibble(uint8_t nibble) {
//     // D4
//     if (nibble & 0x01) PORTB |= (1 << DATA_PIN04);
//     else PORTB &= ~(1 << DATA_PIN04);

//     // D5
//     if (nibble & 0x02) PORTB |= (1 << DATA_PIN05);
//     else PORTB &= ~(1 << DATA_PIN05);

//     // D6
//     if (nibble & 0x04) PORTB |= (1 << DATA_PIN06);
//     else PORTB &= ~(1 << DATA_PIN06);

//     // D7
//     if (nibble & 0x08) PORTD |= (1 << DATA_PIN07);
//     else PORTD &= ~(1 << DATA_PIN07);

//     lcd_pulse();
// }

// // Send a full 8-bit command
// void lcd_command(uint8_t cmd) {
//     PORTB &= ~(1 << RS);  // RS = 0 for command

//     lcd_send_nibble((cmd >> 4) & 0x0F);  // Send high nibble
//     lcd_send_nibble(cmd & 0x0F);         // Send low nibble
// }

// // Send a single character (data)
// void lcd_data(uint8_t data) {
//     PORTB |= (1 << RS);  // RS = 1 for data

//     lcd_send_nibble((data >> 4) & 0x0F);  // Send high nibble
//     lcd_send_nibble(data & 0x0F);         // Send low nibble
// }

// // Send a string to LCD
// void lcd_print(const char *str) {
//     while (*str) {
//         lcd_data(*str++);
//     }
// }

// // LCD initialization
// void lcd_init() {
//     _delay_ms(50); // Wait for LCD to power up

//     PORTB &= ~(1 << RS);   // RS = 0
//     PORTB &= ~(1 << ENABLE); // EN = 0

//     // Initializing LCD in 4-bit mode
//     lcd_send_nibble(0x03);  // Function Set
//     _delay_ms(5);
//     lcd_send_nibble(0x03);  // Repeat
//     _delay_us(150);
//     lcd_send_nibble(0x03);
//     lcd_send_nibble(0x02);  // Set to 4-bit mode

//     lcd_command(0x28);  // 4-bit mode, 2 lines, 5x8 font
//     lcd_command(0x0C);  // Display ON, cursor OFF
//     lcd_command(0x06);  // Entry mode: increment cursor
//     lcd_command(0x01);  // Clear display
//     _delay_ms(2);
// }

// // Main function
// int main(void) {
//     // Set data direction registers
//     DDRB |= (1 << DATA_PIN04) | (1 << DATA_PIN05) | (1 << DATA_PIN06) |
//             (1 << ENABLE) | (1 << RS);
//     DDRD |= (1 << DATA_PIN07);

//     lcd_init();

//     lcd_command(0x80);               // Move to line 1
//     lcd_print("NEPAL NEPAL NEPAL"); // Print text

//     lcd_command(0xC0);               // Move to line 2
//     lcd_print("WORKING woooow");    // Print text

//     while (1) {
//         // Main loop does nothing, LCD holds text
//     }

//     return 0;
// }


#include <Arduino.h>
#include <avr/io.h>
#include <util/delay.h>

#define DATA_PIN07 PD7
#define DATA_PIN06 PB0
#define DATA_PIN05 PB1
#define DATA_PIN04 PB2
#define ENABLE PB3
#define DATA_PIN PB4

#define DATA_RS PB4


void lcd_pulse(){
    PORTB |= (1<ENABLE);
    _delay_ms(100);
    PORTB &= ~(1<<ENABLE);
    _delay_ms(200);
}


void lcd_command(unsigned char cmd){
    PORTB &= ~(1<<DATA_RS);//RS=0
    if(cmd & 0x10){
        PORTB |= (1<<DATA_PIN04);//set 1
    }
    else{
        PORTB &= ~(1<<DATA_PIN04);//clear 1
    }

    if(cmd & 0x20) PORTB |= (1<<DATA_PIN05);
    else PORTB &= ~(1<<DATA_PIN05);

    if(cmd & 0x40) PORTB |= (1<<DATA_PIN06);
    else PORTB &= ~(1<<DATA_PIN06);

    if(cmd & 0x80) PORTD |= (1<<DATA_PIN07);
    else PORTD &= ~(1<<DATA_PIN07);

    lcd_pulse();

    // if(cmd & 0x20) PORTB |= (1<<DATA_PIN05);
    // else PORTB &= ~(1<<DATA_PIN05);

    if(cmd & 0x01){
        PORTB |= (1<<DATA_PIN04);//set 1
    }
    else{
        PORTB &= ~(1<<DATA_PIN04);//clear 1
    }

    if(cmd & 0x02) PORTB |= (1<<DATA_PIN05);
    else PORTB &= ~(1<<DATA_PIN05);

    if(cmd & 0x04) PORTB |= (1<<DATA_PIN06);
    else PORTB &= ~(1<<DATA_PIN06);

    if(cmd & 0x08) PORTD |= (1<<DATA_PIN07);
    else PORTD &= ~( 1<< DATA_PIN07);

    lcd_pulse();
}

void lcd_init(){
_delay_ms(200);
    lcd_command(0x02);//4 bit mode
    lcd_command(0x28);// 2 line, 5*7 matrix
    lcd_command(0x0C);// display on, cursor off
    lcd_command(0x06);// increment cursor
    lcd_command(0x01);//clear screen
_delay_ms(200);
}






void lcd_data(unsigned char data){
    PORTB |= (1<<DATA_RS);
    
    if(data & 0x10){
        PORTB |= (1<<DATA_PIN04);//set 1
    }
    else{
        PORTB &= ~(1<<DATA_PIN04);//clear 1
    }

    if(data & 0x20) PORTB |= (1<<DATA_PIN05);
    else PORTB &= ~(1<<DATA_PIN05);

    if(data & 0x40) PORTB |= (1<<DATA_PIN06);
    else PORTB &= ~(1<<DATA_PIN06);

    if(data & 0x80) PORTD |= (1<<DATA_PIN07);
    else PORTD &= ~(1<<DATA_PIN07);

    lcd_pulse();

    // if(cmd & 0x20) PORTB |= (1<<DATA_PIN05);
    // else PORTB &= ~(1<<DATA_PIN05);

    if(data & 0x01){
        PORTB |= (1<<DATA_PIN04);//set 1
    }
    else{
        PORTB &= ~(1<<DATA_PIN04);//clear 1
    }

    if(data & 0x02) PORTB |= (1<<DATA_PIN05);
    else PORTB &= ~(1<<DATA_PIN05);

    if(data & 0x04) PORTB |= (1<<DATA_PIN06);
    else PORTB &= ~(1<<DATA_PIN06);

    if(data & 0x08) PORTD |= (1<<DATA_PIN07);
    else PORTD &= ~(1<<DATA_PIN07);

    lcd_pulse();
}

void lcd_print(char * str){
    while(*str){
        lcd_data(*str++);
    }
}

int main(){
    DDRB = 0XFF;
    DDRD |= (1<<DATA_PIN07);

    lcd_init();

    lcd_command(0x80);
    lcd_print("NEPAL NEPAL NEAPAL");

    lcd_command(0xC0);
    lcd_print("WORKING woooow");

    while(1){

    }
}






