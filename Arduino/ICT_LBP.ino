int Fic33V = 2;
int Fic5V = 3;
int Fic12V=7;
int a11=5;
int a22=6;
int Fic24V=8;
//int digPin7 = 8;
int a33=9;
int a44=10;
int a55=10;

//const int ampermeter = A0;
const int ampermeterConst = A2;


void setup() {
  // put your setup code here, to run once:
pinMode(a11, OUTPUT);
pinMode(a22, OUTPUT);
pinMode(a33, OUTPUT);
pinMode(a44, OUTPUT);
pinMode(a55, OUTPUT);
pinMode(Fic33V, OUTPUT);
pinMode(Fic5V, OUTPUT);
pinMode(Fic12V, OUTPUT);
pinMode(Fic24V, OUTPUT);
Serial.begin(9600); 
   
}

void loop() {

//FicVolts();
analogSent();
analogINT();
//Check();
   
}


  void analogSent()
  {// int SendAmper = analogRead(ampermeter);
   
    int SendAmper1 = analogRead(ampermeterConst);
    
  
   //Serial.println(SendAmper+4);
   Serial.println(SendAmper1);
      delay(60);
    }
  
  
 void analogINT ()
 {
   int analog = Serial.parseInt();
    
 
     if (analog > 0 && analog < 10)
   {
   analogWrite(a11, 0);         
   }
    if (analog > 10 && analog < 256)
   {
   analogWrite(a11, analog);         
   }
   
      if (analog == 260 )
   {
    digitalWrite(Fic5V, LOW);
    delay(250);
    digitalWrite(Fic12V, LOW);
    delay(250);
    digitalWrite(Fic24V, LOW);
    delay(250);
    digitalWrite(Fic33V, HIGH);         
   }
   
      if (analog == 261 )
   {
    digitalWrite(Fic33V, LOW);
    delay(250);
    digitalWrite(Fic12V, LOW);
    delay(250);
    digitalWrite(Fic24V, LOW);
    delay(250);
    digitalWrite(Fic5V, HIGH);         
   }
  
   if (analog == 262 )
   {
    digitalWrite(Fic33V, LOW);
     delay(250);;
    digitalWrite(Fic5V, LOW);
     delay(250);
    digitalWrite(Fic24V, LOW);
     delay(250);
    digitalWrite(Fic12V, HIGH);         
   }
    if (analog == 263 )
   {
    digitalWrite(Fic33V, LOW);
     delay(250);
    digitalWrite(Fic5V, LOW);
     delay(250);
    digitalWrite(Fic12V, LOW);
     delay(250);
    digitalWrite(Fic24V, HIGH);         
   }
  
/*  if (analog > 257 && analog < 260)
   {
   analogWrite(a22, 0);         
   }
   if (analog > 259 && analog < 512)
   {
   analogWrite(a22, analog);         
   }
   
   if (analog ==540)
   {
        digitalWrite(a55,HIGH);
   }
   if (analog ==600)
   {
        digitalWrite(a55,LOW);   
   }
   if (analog > 643 && analog < 707)
   {
        digitalWrite(a55,HIGH);   
   }
   if (analog > 708 && analog < 768)
   {
        digitalWrite(a55,LOW);   
   }
 */
 
  
  }
  

 

 void Check(){
  
digitalWrite(Fic33V,HIGH);
delay(500);
digitalWrite(Fic33V,LOW);
delay(500);

digitalWrite(Fic5V,HIGH);
delay(500);
digitalWrite(Fic5V,LOW);
delay(500);

digitalWrite(Fic12V,HIGH);
delay(500);
digitalWrite(Fic12V,LOW);
delay(500);

digitalWrite(Fic24V,HIGH);
delay(500);
digitalWrite(Fic24V,LOW);
delay(500);
}
