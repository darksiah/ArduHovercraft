// Sweep
// by BARRAGAN <http://barraganstudio.com> 
// This example code is in the public domain.

#include <Wire.h>
#include <L3G.h>
#include <Servo.h> 
#include <PID_v1.h>

L3G gyro;


double Setpoint, Input, Output;
PID myPID(&Input, &Output, &Setpoint,2,5,1, DIRECT);

Servo mCentral;
Servo mTrasero;
Servo direccion;

int i;
int valores[] = {0,0,90};

boolean on = true;
char buffer[20];


void setup() 
{ 
  pinMode(13,OUTPUT);
  
  Serial.begin(9600);
  Wire.begin();
  
  if (!gyro.init())
  {
    Serial.println("Fallo al detectar GYRO!");
    while (1);
  }
  
  gyro.enableDefault();
  
  
  Serial.setTimeout(100);

  mCentral.attach(4,1039,1855); 
  mTrasero.attach(5,1039,1855);
  direccion.attach(6);

  mCentral.write(0);
  mTrasero.write(0);
  direccion.write(90);

  myPID.SetMode(AUTOMATIC);

  delay(3000);

  Serial.println("Hovercraft Ready");
  apagar();
}


void loop() 
{
  
  gyro.read(); 
  myPID.Compute();
  
  Input =  (int)gyro.g.z;
  Setpoint = valores[2];
  
  Serial.println(Output);
  
  if(on==true)
  {
    imprimirGyro();
    mCentral.write(valores[0]);
    mTrasero.write(valores[1]);
    direccion.write(constrain(valores[2],40,130));
    //debug();
  }

}

void serialEvent() {
  if (Serial.available()) {
    for (i=0;i<3;i++)
    {
      valores[i] = Serial.parseInt(); 
      
      if (valores[i] == 888) {encender(); break;}
      else if (valores[i] == 999) {apagar(); break;}
    }   
  }
}

void debug()
{
  for (i = 0;i<3;i++)
  {
    sprintf(buffer,"%.3d ",valores[i]);
    Serial.print(buffer);
  }
  Serial.println();

}  

void apagar()
{
  

  mCentral.write(0);
  mTrasero.write(0);
  delay(3000);
  on = false;
  direccion.write(0);
  valores[0]  = 0;
  valores[1]  = 0;
  valores[2]  = 90;
  Serial.println("Sistema Apagado");
  digitalWrite(13,LOW);
}
void encender()
{
  valores[0] = 40;
  valores[1] = 30;
  valores[2] = 90;

  delay(200);

  on = true;

  Serial.println("Sistema Encendido");
  digitalWrite(13,HIGH);

}

void imprimirGyro()
{
  Serial.print("G ");
  Serial.print("X: ");
  Serial.print((int)gyro.g.x);
  Serial.print(" Y: ");
  Serial.print((int)gyro.g.y);
  Serial.print(" Z: ");
  Serial.println((int)gyro.g.z);

  delay(100);
}




