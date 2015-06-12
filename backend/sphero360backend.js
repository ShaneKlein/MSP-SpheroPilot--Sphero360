"use strict";

/* eslint no-use-before-define: 0 */

//Requires
var sphero = require("sphero");
var net = require("net");

//Set the port you want to connect to!
var orb = sphero("COM6");

//Try to connect to Sphero.
orb.connect(listen);

var speed = 0;
var direction = 0;

//Runs once connected to Sphero.
function listen() {
	
	//Turn on the blue taillight so we know what the back of the Sphero is.
	orb.setBackLed(127);
 
	//Create server to connect to.
	var server = net.createServer(function(socket) {
		
		//Activates when data is received
		socket.on('data', function (data) {
			
			//Make it a string.
			data = data + "";
			
			handleCommand(data);
		});
	});
 
	//Start server
	server.listen(9000, '127.0.0.1');

}

//Handles when input from frontend is received
function handleCommand(c)
{	
	//Sometimes more than one message comes through at a time, so split it up...
	var commands = c.split("*");
	
	//Run for each command. length - 1 because the last will be empty.
	for(var i = 0; i < commands.length - 1; i++)
	{
		//Speed is in front of the |
		speed = commands[i].split("|")[0];
		
		//Direction is behind the |
		direction = commands[i].split("|")[1];
		
		//Output to log
		console.log("Speed: " + speed + "; Direction: " + direction);
		
		//Let's roll!
		orb.roll(speed, direction);
	}
}