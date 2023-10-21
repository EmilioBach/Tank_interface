String inputString = "";    //guardar comandos
bool stringComplete = false;//si se completa un comando...

void setup() 
{
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);
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
      digitalWrite(LED_BUILTIN, HIGH);
    }
    //oruga 2
    else if(inputString.equals("$Go_2"))
    {
      digitalWrite(LED_BUILTIN, LOW);
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