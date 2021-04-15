#include <SoftwareSerial.h>// 시리얼 라이브러리 임포트
char c;
SoftwareSerial mySerial(3, 2); //RX, TX  블루투스 모듈 핀 번호 설정

void setup()
{
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(9600);  // 9600의 속도로 시리얼 모니터와의 통신 시작
  mySerial.begin(9600); // 9600의 속도로 블루투스 통신 시작
}

void loop()
{
  if(mySerial.available()){
    c = mySerial.read();
    if(c == '4'){
      Serial.write("비교");
      analogWrite(8, 255); 
    }else if(c == '5'){
      Serial.write("끔");
      analogWrite(8, 0); 
    }
  }
  /*
  if(mySerial.available())
  Serial.write(mySerial.read());
  if(mySerial.read().equals("1"))
  Serial.write("비교");
  //analogWrite(8, 200);        
  // 데이터 받기(유니티 -> 아두이노 -> 시리얼 모니터)
  if(mySerial.available()){
    //analogWrite(8, 200);                 // 진동모터를 200/255의 파워로 작동시킵니다.
    //delay(500);
    //if((String)mySerial.read() == "1"){
    analogWrite(8, 0);                   // 진동모터를 0의 파워로 작동시킵니다. (OFF)
    delay(500);                         // 3초간 대기
    Serial.write(mySerial.read());
    
  }
    //Serial.write(mySerial.read());
  
  // 데이터 보내기(시리얼 모니터 -> 아두이노 -> 유니티)
  if(Serial.available())
    mySerial.write(Serial.read());
    */
}
