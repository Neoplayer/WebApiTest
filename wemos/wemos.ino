#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>
#include <ESP8266WiFiMulti.h>
#include <WiFiClient.h>

const char *ssid = "Mi Note 10 Lite";
const char *password = "123456789";

ESP8266WiFiMulti WiFiMulti;

// Register structure:
// User|Pass|0:I5,4:I4,7:O2
//           Enum:Pin,Enum:Pin,....

void setup()
{
    Serial.begin(115200);

    WiFi.begin(ssid, password);

    Serial.print("Connecting");
    while (WiFi.status() != WL_CONNECTED)
    {
        delay(1000);
        Serial.print(".");
    }

    
    pinMode(LED_BUILTIN, OUTPUT);
    

    Register();
}

void loop()
{
    Ping();

    delay(500);
}

void Ping()
{
  // wait for WiFi connection
    if ((WiFiMulti.run() == WL_CONNECTED))
    {
        WiFiClient client;
        HTTPClient http;

        Serial.print("[HTTP] begin Ping...\n");
        if (http.begin(client, "http://194.58.107.109:8080/W/Ping"))
        { // HTTP

            http.addHeader("Content-Type", "application/json");
          //Post Data
            String postData = "{\"user\": \"Me\",\"password\": \"123\",\"data\": \"string\"}"; // todo modules data here!

            Serial.print("[HTTP] POST...\n");
            // start connection and send HTTP header
            int httpCode = http.POST(postData);

            // httpCode will be negative on error
            if (httpCode > 0)
            {
                // HTTP header has been send and Server response header has been handled
                Serial.printf("[HTTP] POST... code: %d\n", httpCode);

                // file found at server
                if (httpCode == HTTP_CODE_OK || httpCode == HTTP_CODE_MOVED_PERMANENTLY)
                {
                    String payload = http.getString();
                    Serial.println(payload);
                    if(payload != "")
                    {
                      HandleCommand(payload);
                    }
                }
            }
            else
            {
                Serial.printf("[HTTP] POST... failed, error: %s\n", http.errorToString(httpCode).c_str());
            }

            http.end();
        }
        else
        {
            Serial.printf("[HTTP} Unable to connect\n");
        }
    }
}

void HandleCommand(String command)
{
  int i = 0;
  String action;

  Serial.println("HandleCommands: " + command);
  
  while(true) {
    action = getValue(command, ',', i);
    i++;

    if(action != "")
    {
        Serial.println("Command: " + action);

        auto pin = atoi(getValue(action, ':', 0).c_str());
        Serial.println("Pin: " + String(pin));
        
        auto value = atoi(getValue(action, ':', 1).c_str());
        Serial.println("Value: " + String(value));

        
        digitalWrite(pin, value);
    }
    else
    {
      break;
    }
  }
  
  
  
//  auto pin = atoi(getValue(command, ':', 0).c_str());
//  Serial.println("Pin: " + String(pin));
//  
//  auto value = atoi(getValue(command, ':', 1).c_str());
//  Serial.println("Value: " + String(value));
//
//  Serial.println(getValue(command, ':', 2));
//
//  digitalWrite(pin, value);
}

String getValue(String data, char separator, int index)
{
    int found = 0;
    int strIndex[] = { 0, -1 };
    int maxIndex = data.length() - 1;

    for (int i = 0; i <= maxIndex && found <= index; i++) {
        if (data.charAt(i) == separator || i == maxIndex) {
            found++;
            strIndex[0] = strIndex[1] + 1;
            strIndex[1] = (i == maxIndex) ? i+1 : i;
        }
    }
    return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}

void Register()
{
    // wait for WiFi connection
    if ((WiFiMulti.run() == WL_CONNECTED))
    {
        WiFiClient client;
        HTTPClient http;

        Serial.println("[HTTP] begin Register...\n http://194.58.107.109:8080/W/Register?d=Me|123|0:" + String(LED_BUILTIN));
        
        if (http.begin(client, "http://194.58.107.109:8080/W/Register?d=Me|123|0:" + String(LED_BUILTIN)))
        { // HTTP

            Serial.print("[HTTP] GET...\n");
            // start connection and send HTTP header
            int httpCode = http.GET();

            // httpCode will be negative on error
            if (httpCode > 0)
            {
                // HTTP header has been send and Server response header has been handled
                Serial.printf("[HTTP] GET... code: %d\n", httpCode);

                // file found at server
                if (httpCode == HTTP_CODE_OK || httpCode == HTTP_CODE_MOVED_PERMANENTLY)
                {
                    String payload = http.getString();
                    Serial.println(payload);
                }
            }
            else
            {
                Serial.printf("[HTTP] GET... failed, error: %s\n", http.errorToString(httpCode).c_str());
            }

            http.end();
        }
        else
        {
            Serial.printf("[HTTP} Unable to connect\n");
        }
    }
}
