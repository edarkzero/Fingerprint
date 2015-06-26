using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace FingerprintClient
{
    public class SocketManager
    {
        private string response;

        public SocketManager(string data)
        {
            if (data != "," || data != "" || data != " ")
                response = AsynchronousClient.StartClient(data,null);
        }

        public SocketManager(byte[] data)
        {
            if (data.Length > 0)
                response = AsynchronousClient.StartClient(null, data);
        }

        public string[] getResponse()
        {
            return response.Split(new String[]{"[{sep}]"},StringSplitOptions.RemoveEmptyEntries);
        }

        public static void SendTCP(string M)
        {
            byte[] SendingBuffer = null;
            int BufferSize = 1024;
            TcpClient client = null;
            string lblStatus = "";
            NetworkStream netstream = null;
            Int32 PortN = 11001;
            string IPA = "127.0.0.1";

            try
            {
                 client = new TcpClient(IPA, PortN);
                 lblStatus = "Connected to the Server...\n";
                 netstream = client.GetStream();
                 FileStream Fs = new FileStream(M, FileMode.Open, FileAccess.Read);
                 int NoOfPackets = Convert.ToInt32
	          (Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)));
                 //progressBar1.Maximum = NoOfPackets;
                 int TotalLength = (int)Fs.Length, CurrentPacketLength, counter = 0;
                 for (int i = 0; i < NoOfPackets; i++)
                 {
                     if (TotalLength > BufferSize)
                     {
                         CurrentPacketLength = BufferSize;
                         TotalLength = TotalLength - CurrentPacketLength;
                     }
                     else
                         CurrentPacketLength = TotalLength;
                         SendingBuffer = new byte[CurrentPacketLength];
                         Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                         netstream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
                         /*if (progressBar1.Value >= progressBar1.Maximum)
                              progressBar1.Value = progressBar1.Minimum;
                         progressBar1.PerformStep();*/
                }
                
                     lblStatus += "Sent "+Fs.Length.ToString()+"bytes to the server";
                     Fs.Close();
                     Console.WriteLine(lblStatus);
                 }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.Message);
            }
            finally
            {
                 netstream.Close();
                 client.Close();
            }
        } 
    }

    // State object for receiving data from remote device.
    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 1024*10;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
    }

    public class AsynchronousClient
    {
        // The port number for the remote device.
        private const int port = 11000;

        // ManualResetEvent instances signal completion.
        private static ManualResetEvent connectDone =
            new ManualResetEvent(false);
        private static ManualResetEvent sendDone =
            new ManualResetEvent(false);
        private static ManualResetEvent receiveDone =
            new ManualResetEvent(false);

        // The response from the remote device.
        private static String response = String.Empty;

        public static string StartClient(string data,byte[] parsedData)
        {
            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                // The name of the 
                // remote device is "host.contoso.com".
                IPHostEntry ipHostInfo = Dns.Resolve("127.0.0.1");
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                // Create a TCP/IP socket.
                Socket client = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint.
                client.BeginConnect(remoteEP,
                    new AsyncCallback(ConnectCallback), client);
                connectDone.WaitOne();

                // Send test data to the remote device.
                Send(client, data + "<EOF>", parsedData);
                sendDone.WaitOne();

                // Receive the response from the remote device.
                Receive(client);
                receiveDone.WaitOne();

                // Write the response to the console.
                Console.WriteLine("Response received : {0}", response);                

                // Release the socket.
                client.Shutdown(SocketShutdown.Both);
                client.Close();

                return response;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.
                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.
                connectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Receive(Socket client)
        {
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = client;

                // Begin receiving the data from the remote device.
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // Get the rest of the data.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    // All the data has arrived; put it in response.
                    if (state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                    }
                    // Signal that all bytes have been received.
                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Send(Socket client, String data, byte[] parsedData)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData;
            if (parsedData == null)
                byteData = Encoding.ASCII.GetBytes(data);
            else
            {
                byte[] eofBytes = Encoding.ASCII.GetBytes("<EOF>");
                byteData = parsedData.Concat(eofBytes).ToArray();
            }

            // Print length of each row
            for (int i = byteData.Length-1; i > byteData.Length-8; i--)
            {
                Console.WriteLine("{0} is {1}", i, byteData[i]);
            }

            // Begin sending the data to the remote device.
            client.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = client.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to server.", bytesSent);

                // Signal that all bytes have been sent.
                sendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    public class SynchronousSocketClient
    {
        public static string data = null;

        public static void StartListening()
        {
            // Data buffer for incoming data.
            byte[] bytes = new Byte[1024];

            // Establish the local endpoint for the socket.
            // Dns.GetHostName returns the name of the 
            // host running the application.
            IPHostEntry ipHostInfo = Dns.Resolve("127.0.0.1");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11002);

            // Create a TCP/IP socket.
            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and 
            // listen for incoming connections.
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Start listening for connections.
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    // Program is suspended while waiting for an incoming connection.
                    Socket handler = listener.Accept();
                    data = null;

                    // An incoming connection needs to be processed.
                    while (true)
                    {
                        bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    // Show the data on the console.
                    Console.WriteLine("Text received : {0}", data);

                    // Echo the data back to the client.
                    byte[] msg = Encoding.ASCII.GetBytes(data);

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }
        
        public static void StartClient() {
            // Data buffer for incoming data.
            byte[] bytes = new byte[1024];

            // Connect to a remote device.
            try {
                // Establish the remote endpoint for the socket.
                // This example uses port 11000 on the local computer.
                IPHostEntry ipHostInfo = Dns.Resolve("127.0.0.1");
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress,11004);

                // Create a TCP/IP  socket.
                Socket sender = new Socket(AddressFamily.InterNetwork, 
                    SocketType.Stream, ProtocolType.Tcp );

                // Connect the socket to the remote endpoint. Catch any errors.
                try {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.
                    byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");
                    //byte[] msg = info;

                    // Send the data through the socket.
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.                    
                    int bytesRec = sender.Receive(bytes);
                    data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    Console.WriteLine("Echoed test = {0}",data);

                    // Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                
                } catch (ArgumentNullException ane) {
                    Console.WriteLine("ArgumentNullException : {0}",ane.ToString());
                } catch (SocketException se) {
                    Console.WriteLine("SocketException : {0}",se.ToString());
                } catch (Exception e) {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            } catch (Exception e) {
                Console.WriteLine( e.ToString());
            }
        }
    }
}
