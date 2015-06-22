using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace FingerprintNetSample
{
    // State object for reading client data asynchronously
    public class StateObjectImage
    {
        // Client  socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 1024 * 10;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received image bytes
        public ArrayList imageBytes = new ArrayList();
    }

    class SocketControlImage
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        public static System.Drawing.Image image;

        public Thread oThread;

        public SocketControlImage()
        {
            oThread = new Thread(new ThreadStart(SocketControlImage.StartListeningImage));
        }

        public void StartListening()
        {
            if (!oThread.IsAlive)
                oThread.Start();
        }

        public void StopListening()
        {
            if (oThread.IsAlive)
                oThread.Abort();
        }

        //----------------------------------------------------------------------
        public static void StartListeningImage()
        {
            // Data buffer for incoming data.
            byte[] bytes = new Byte[1024];

            // Establish the local endpoint for the socket.
            // The DNS name of the computer running the listener is "server.domain.com".
            //IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPHostEntry ipHostInfo = Dns.Resolve("127.0.0.1");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11001);

            // Create a TCP/IP socket.
            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                while (true)
                {
                    // Set the event to nonsignaled state.
                    allDone.Reset();

                    // Start an asynchronous socket to listen for connections.
                    System.Windows.Forms.MessageBox.Show("Waiting for a connection...");
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    // Wait until a connection is made before continuing.
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }

            System.Windows.Forms.MessageBox.Show("\nPress ENTER to continue...");
            Console.Read();

        }
        //----------------------------------------------------------------------
        public static void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.
            allDone.Set();

            // Get the socket that handles the client request.
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.
            StateObjectImage state = new StateObjectImage();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObjectImage.BufferSize, 0,
                new AsyncCallback(Read_Image), state);
        }
        //--------------------------------------------------------
        public static void Read_Image(IAsyncResult ar)
        {
            StateObjectImage so = (StateObjectImage)ar.AsyncState;
            Socket s = so.workSocket;

            int read = s.EndReceive(ar);

            if (read > 0)
            {
                //so.sb.Append(Encoding.ASCII.GetString(so.buffer, 0, read));
                foreach (byte el in so.buffer)
                {
                    so.imageBytes.Add(el);
                }
                s.BeginReceive(so.buffer, 0, StateObjectImage.BufferSize, 0, new AsyncCallback(Read_Image), so);
                System.Windows.Forms.MessageBox.Show("read > 0, call Read_Image recursively");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Else case");
                if (so.imageBytes.Count > 0)
                {
                    //All of the data has been read, so displays it to the console
                    byte[] imageBytesArray = new byte[so.imageBytes.Count];
                    so.imageBytes.CopyTo(imageBytesArray);
                    image = ImageConverter.byteArrayToImage(imageBytesArray);
                    //Send(s, "<EOF>");
                    //System.Windows.Forms.MessageBox.Show("Sent!");
                }
                System.Windows.Forms.MessageBox.Show("Receive done!");
                Send(s, "<EOF>");  //this sends a msg to the client and closes the socket connection. I didn't paste the function
                s.Close();
            }
        }

        private static void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
