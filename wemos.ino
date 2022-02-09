#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>
#include <ESP8266WiFiMulti.h>
#include <WiFiClient.h>

const char *ssid = "Нюсовский";
const char *password = "96734414349111118500";

ESP8266WiFiMulti WiFiMulti;

// Register structure:
// User|Pass|0:I5,4:I4,7:O2
//           Enum:Pin,Enum:Pin,....

void setup()
{
    Serial.begin(115200);

    WiFi.begin(ssid, password);

    while (WiFi.status() != WL_CONNECTED)
    {

        delay(1000);
        Serial.print("Connecting..");
    }

    Register();
}

void loop()
{
    // wait for WiFi connection
    if ((WiFiMulti.run() == WL_CONNECTED))
    {

        WiFiClient client;

        HTTPClient http;

        Serial.print("[HTTP] begin...\n");
        if (http.begin(client, "http://194.58.107.109:8080/WeatherForecast"))
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

    delay(40000);
}

void Register()
{
    // wait for WiFi connection
    if ((WiFiMulti.run() == WL_CONNECTED))
    {

        WiFiClient client;

        HTTPClient http;

        Serial.print("[HTTP] begin...\n");
        if (http.begin(client, "http://194.58.107.109:8080/Register"))
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