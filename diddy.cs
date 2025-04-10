// ultrasound
const int trigPin = 13;
const int echoPin = 5;

float duration; 
float distance;

void setup() {
 Serial.begin (9600);
 pinMode(trigPin, OUTPUT);
 pinMode(echoPin, INPUT);
 }

void loop () {
 digitalWrite(trigPin, LOW);
 delayMicroseconds(2);

 digitalWrite(trigPin, HIGH);
 delayMicroseconds (10);
 digitalWrite(trigPin, LOW);

 duration = pulseIn(echoPin, HIGH);

 distance = (duration * 0.0343) / 2;

 Serial.print("Afstand: ");
 Serial.println(distance);


 delay(100);
}


#include <Servo.h>
// Importeer de Servo bibliotheek om de servo aan te sturen
Servo servo;

int pos = 0;

void setup(){
 servo.attach(8);
 servo.write(0);
 delay(40);
}
void loop() {

 for (pos = 0; pos <= 180; pos++) {
  servo.write(pos); // Geef de positie aan de servo door
  delay(10);
 }

 for (pos = 180; pos >= 0; pos--) {
   servo.write(pos); // Geef de positie aan de servo door
   delay(10);
 }
}
