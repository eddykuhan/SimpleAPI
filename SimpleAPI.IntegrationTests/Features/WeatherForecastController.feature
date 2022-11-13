Feature: WeatherForecastController

THis feature sends request to water forecast controller to get back the data

@tag1
Scenario: A GET request sent to the controller
	Given I am a caller of this API
	When  I make a GET  request to "v1/weatherforecast"
	Then I should receive below data


