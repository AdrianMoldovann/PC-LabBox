/*
Title: Laboratory Box Firmware
Code created by: Adrian Moldovan
Date: 18/05/2021
Project developed for FCT FabLab to the FabYourself course.
*/

#include <SD.h>
#include <SPI.h>
#include <RTClib.h>

RTC_Millis rtc;
File myFile;

#define SWITCH 7
#define CHIPSELECT 6
#define TMP 3
#define LDR 2
#define HALL 1
#define LED 0

float temperature = 0;
int SwitchState = 0;
int SamplingTime = 500; //500 milliseconds
int FileCount = 0;
char filename[15];

void setup() {

  Serial.begin(9600);

  // following line sets the RTC to the date & time this sketch was compiled
  rtc.begin(DateTime(F(__DATE__), F(__TIME__)));
  // This line sets the RTC with an explicit date & time, for example to set
  // January 21, 2014 at 3am you would call:
  // rtc.adjust(DateTime(2014, 1, 21, 3, 0, 0));

  Serial.print("Initializing SD card...");
  if (!SD.begin(CHIPSELECT)) {
    Serial.println("Initialization failed! Please Reset!");
    while (true) {
      digitalWrite(LED, HIGH);
      delay(700);
      digitalWrite(LED, LOW);
      delay(700);
    }
  }
  Serial.println("Initialization successful.");

  pinMode(LED, OUTPUT);
  pinMode(TMP, INPUT);
  pinMode(LDR, INPUT);
  pinMode(HALL, INPUT);
  pinMode(CHIPSELECT, OUTPUT);
  pinMode(SWITCH, INPUT_PULLUP);
  attachInterrupt(digitalPinToInterrupt(SWITCH), ButtonCheck, RISING);
}

void loop() {

  if (SwitchState) {
    DateTime now = rtc.now();
    char Data [40];
    FileCount++;

    sprintf (filename, "data(%d).txt", FileCount);
    Serial.println(filename);

    if (!SD.exists(filename)) {

      myFile = SD.open(filename, FILE_WRITE);
    } else {
      SD.remove(filename);
      myFile = SD.open(filename, FILE_WRITE);
    }

    char title [] = "Time, Hall sensor, Light sensor, Temperature";

    myFile.println(title);
    Serial.println(title);

    do {
      now = rtc.now();
      temperature = (3.2*analogRead(TMP))
      int hall = analogRead(HALL);
      int ldr = analogRead(LDR);

      sprintf(Data, "%d:%d:%d,%d,%d,%.2f", now.hour(), now.minute(), now.second(), hall, ldr, temperature);
      Serial.println(Data);
      myFile.println(Data);

      digitalWrite(LED, LOW);
      delay(SamplingTime);

    }
    while (SwitchState);

    myFile.close();
  }

  digitalWrite(LED, HIGH);

  delay(50);

}

void ButtonCheck () {
  SwitchState = !SwitchState;
}
