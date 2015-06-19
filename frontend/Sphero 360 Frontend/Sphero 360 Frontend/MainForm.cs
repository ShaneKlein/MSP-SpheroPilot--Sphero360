using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Sphero_360_Frontend
{
    public partial class MainForm : Form
    {
        private int _direction = 0;
        private int _oldDirection = 0;

        private int _speed = 0;
        private int _oldSpeed = 0;

        private System.Drawing.Color _spheroColor = System.Drawing.Color.LimeGreen;

        private TcpClient _tcpClient = new TcpClient();
        private NetworkStream _stream;

        private GamePadState _currentState;
        private GamePadState _previousState = new GamePadState();

        //Constructor
        public MainForm()
        {
            //Makes the Form.
            InitializeComponent();
        }

        //On load
        public void MainForm_Load(object sender, EventArgs e)
        {
        }

        //This timer runs to make sure the ball doesn't stop rolling if the user is just holding down acceleration.
        private void speedTimer_Tick(object sender, EventArgs e)
        {
            //Only bother to send if we're going to move.
            if (_speed > 0)
            {
                _roll(_speed, _direction);
            }

            if (spheroColorDialog.Color != _spheroColor)
            {
                _changeColor(spheroColorDialog.Color);
            }
        }

        //This timer runs to check for new input.
        private void inputTimer_Tick(object sender, EventArgs e)
        {
            bool stoppedOrb = false;

            //Get the gamepad's state
            _currentState = GamePad.GetState(PlayerIndex.One);

            //Calculate the speed. The trigger goes from 0 to 1, so multiply by 100. (Min speed 0, Max speed 100)
            _speed = (int)(_currentState.Triggers.Left * (int) _txtMaxSpeed.Value);

            //Calculate the direction. The X of the Thumb Stick goes from -1 to 1, so multiply by rotation amount and add to direction.
            _direction += (int)(_currentState.ThumbSticks.Left.X * (int)_txtTurnRate.Value);

            //Check if the user is pressing A to boost.
            if (_currentState.Buttons.A == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                _speed = (int)_txtBoostSpeed.Value;
            }

            //Check if the user just pressed X to reverse (Spin 180 degrees). Only activates if X wasn't held down the previous tick.
            if (_currentState.Buttons.X == Microsoft.Xna.Framework.Input.ButtonState.Pressed && _previousState.Buttons.X == Microsoft.Xna.Framework.Input.ButtonState.Released)
            {
                _direction += 180;
            }

            //Check if user is pressing B to stop.
            if (_currentState.Buttons.B == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                _stopOrb();
                stoppedOrb = true;
            }

            //Reduce the direction (Convert the direction if >= 360)
            while (_direction >= 360)
            {
                _direction -= 360;
            }

            //Reduce the direction (Convert the direction if < 0)
            while (_direction < 0)
            {
                _direction += 360;
            }

            //We want to try to rotate, but we're not moving. Since we have to be moving to rotate, speed = 1
            if (_speed == 0 && _direction != _oldDirection)
            {
                _speed = 1;
            }

            //Only call _roll if the ball is turned or speed changed. Otherwise, let the speedTimer handle it so we don't spam.
            if (!stoppedOrb && (_direction != _oldDirection || _speed != _oldSpeed))
            {
                _roll(_speed, _direction);
            }

            //Set previousState to currentState for next tick.
            _previousState = _currentState;

            //Set _oldSpeed = _speed for next tick.
            _oldSpeed = _speed;

            //Set _oldDirection = _direction for next tick.
            _oldDirection = _direction;
        }

        //Makes the ball roll at speed oriented in direction
        private void _roll(int speed, int direction)
        {
            //Message is JSON object containing speed and direction
            string jsonMessage = "{\"speed\":\"" + speed + "\", \"direction\":\"" + direction + "\"}";
            
            //Send it
            _sendMessage(jsonMessage);
        }

        //Changes the color of the ball
        private void _changeColor(System.Drawing.Color newCollor)
        {
            //Set our current color to the new color
            _spheroColor = newCollor;

            //Send message. We have to convert the color to a hex code.
            //The horribly ugly converting the color to Argb to color before converting to hex is because before that, it could output "Lime"
            string jsonMessage = "{\"color\":\"" + ColorTranslator.ToHtml(System.Drawing.Color.FromArgb(_spheroColor.ToArgb())) + "\"}";

            //Send it
            _sendMessage(jsonMessage);
        }

        //Stops the ball
        private void _stopOrb()
        {
            string jsonMessage = "{\"stopOrb\":true}";
            _speed = 0;
            _sendMessage(jsonMessage);
        }

        private void _sendMessage(string message)
        {
            //Only do stuff if we're (supposed to be) connected.
            if (_tcpClient.Connected)
            {
                //Convert our message into a Byte Array
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                //Try to send it!
                try
                {
                    _stream.Write(data, 0, data.Length);
                }
                catch (Exception ex)
                {
                    //Couldn't send...

                    //Close connection
                    _tcpClient.Close();

                    _updateConnectDisconnectFormItems();

                    //Show error message
                    MessageBox.Show("Connection ended." + System.Environment.NewLine + "Error Message: " + ex.ToString());
                }
            }
        }

        private void _btnConnectToBackend_Click(object sender, EventArgs e)
        {
            _connectServer();
        }

        private void _btnDisconnectFromBackend_Click(object sender, EventArgs e)
        {
            _disconnectServer();
        }

        //Update form controls and timers related to being connected to the server.
        private void _updateConnectDisconnectFormItems()
        {
            if (_tcpClient.Connected)
            {
                _btnConnectToBackend.Enabled = false;
                _btnDisconnectFromBackend.Enabled = true;

                _txtServer.Enabled = false;
                _txtPort.Enabled = false;

                inputTimer.Enabled = true;
                speedTimer.Enabled = true;
            }
            else
            {
                _btnConnectToBackend.Enabled = true;
                _btnDisconnectFromBackend.Enabled = false;

                _txtServer.Enabled = true;
                _txtPort.Enabled = true;

                inputTimer.Enabled = false;
                speedTimer.Enabled = false;
            }
        }

        //Connect to server and open stream
        private void _connectServer()
        {
            //Try to connect
            try
            {
                _tcpClient = new TcpClient();
                _tcpClient.Connect(_txtServer.Text, (int)_txtPort.Value);

                //Create stream
                _stream = _tcpClient.GetStream();

                _updateConnectDisconnectFormItems();
            }
            catch (Exception ex)
            {
                //Show error message because we couldn't connect.
                MessageBox.Show("Failed to connect to Node.JS Server. Please try again after ensuring the server is running." + System.Environment.NewLine + "Error Details: " + ex.ToString());
            }
        }

        //Disconnect from server
        private void _disconnectServer()
        {
            if (_tcpClient.Connected)
            {
                //Close stream
                _stream.Close();

                //Close tcpClient
                _tcpClient.Close();
            }

            _updateConnectDisconnectFormItems();
        }

        private void _btnShowColorDialog_Click(object sender, EventArgs e)
        {
            spheroColorDialog.ShowDialog();
        }
    }
}