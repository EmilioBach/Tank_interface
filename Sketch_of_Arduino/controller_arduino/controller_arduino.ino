#include <tanque_disp.h>
#include <tanque.h>

String inputString = "";    //guardar comandos
bool stringComplete = false;//si se completa un comando...

tanque tank;
tanque_disp tankd;

void setup() 
{
  Serial.begin(9600);
  tanque.info(13, 12, 11, 10);
}

void loop() 
{

  if(stringComplete)
  {
    inputString.trim();
    Serial.println(inputString);
    //agarrar comando

    //oruga 1
    if(inputString.equals("$Go_1"))
    {
      tanque.derecha();
    }
    //oruga 2
    if(inputString.equals("$Go_2"))
    {
      tanque.izquierda();
    }
    //torreta
    if(inputString.equals("$"){
      
    } //revisar
    if(inputString.equals("$Fire_2")){
      tankd.elastico();
    }
    if(inputString.equals("$Fire_2_off")){
      tankd.n_elastico();
    }
    if(inputString.equals("$Fire")){
      tankd.lapiz();
      delay(1000);
    }
    if(inputString.equals($Fire_off)){
      tankd.n_lapiz();
    }

    //borrar string
    inputString = "";
    stringComplete = false;
  }
}

void serialEvent()
{
  while (Serial.available())
  {
    //obtener un nuevo byte
    char inChar = (char)Serial.read();
    if(inChar == '\n')
    {
      stringComplete = true;
    }
    else
    {
      //agregar a inputString
      inputString += inChar;
    }
  }
}
